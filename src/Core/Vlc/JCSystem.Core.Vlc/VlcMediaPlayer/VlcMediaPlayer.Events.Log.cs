﻿using System;
using System.Runtime.InteropServices;
using System.Threading;
using JCSystem.Core.Vlc.Interops;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc.h;

#if NETSTANDARD1_3
using System.Threading.Tasks;
#endif

namespace JCSystem.Core.Vlc
{
    public sealed partial class VlcMediaPlayer
    {
        private object _logLock = new object();

        /// <summary>
        /// The real log event handlers.
        /// </summary>
        private EventHandler<VlcMediaPlayerLogEventArgs> _log;

        /// <summary>
        /// A boolean to make sure that we are calling SetLog only once
        /// </summary>
        private bool _logAttached;

        /// <summary>
        /// The event that is triggered when a log is emitted from libVLC.
        /// Listening to this event will discard the default logger in libvlc.
        /// </summary>
        public event EventHandler<VlcMediaPlayerLogEventArgs> Log
        {
            add
            {
                lock (_logLock)
                {
                    _log += value;
                    if (!_logAttached)
                    {
                        Manager.SetLog(OnLogInternal);
                        _logAttached = true;
                    }
                }
            }

            remove
            {
                lock (_logLock)
                {
                    _log -= value;
                }
            }
        }

        private void OnLogInternal(IntPtr data, VlcLogLevel level, IntPtr ctx, string format, IntPtr args)
        {
            if (_log != null)
            {
                // Original source for va_list handling: https://stackoverflow.com/a/37629480/2663813
                var byteLength = Win32Interops._vscprintf(format, args) + 1;
                var utf8Buffer = Marshal.AllocHGlobal(byteLength);

                string formattedDecodedMessage;
                try {
                    Win32Interops.vsprintf(utf8Buffer, format, args);

                    formattedDecodedMessage = Utf8InteropStringConverter.Utf8InteropToString(utf8Buffer);
                }
                finally
                {
                    Marshal.FreeHGlobal(utf8Buffer);
                }

                string module;
                string file;
                uint? line;
                Manager.GetLogContext(ctx, out module, out file, out line);

                // Do the notification on another thread, so that VLC is not interrupted by the logging
#if NETSTANDARD1_3
                Task.Run(() => this.log(this.myMediaPlayerInstance, new VlcMediaPlayerLogEventArgs(level, formattedDecodedMessage, module, file, line)));
#else
                ThreadPool.QueueUserWorkItem(eventArgs =>
                {
                    _log(myMediaPlayerInstance, (VlcMediaPlayerLogEventArgs)eventArgs);
                }, new VlcMediaPlayerLogEventArgs(level, formattedDecodedMessage, module, file, line));
#endif
            }
        }
    }
}