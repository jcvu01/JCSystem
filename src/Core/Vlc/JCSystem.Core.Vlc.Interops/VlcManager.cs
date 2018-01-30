using System;
using System.Collections.Generic;
using System.IO;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc.h;

namespace JCSystem.Core.Vlc.Interops
{
    public sealed partial class VlcManager : VlcInteropsManager
    {
        private VlcInstance myVlcInstance;
        private static readonly Dictionary<DirectoryInfo, VlcManager> MyAllInstance = new Dictionary<DirectoryInfo, VlcManager>();

        public string VlcVersion => Utf8InteropStringConverter.Utf8InteropToString(GetInteropDelegate<GetVersion>().Invoke());

        public Version VlcVersionNumber
        {
            get
            {
                var versionString = VlcVersion;
                versionString = versionString.Split('-', ' ')[0];

                return new Version(versionString);
            }
        }

        internal VlcManager(DirectoryInfo dynamicLinkLibrariesPath)
            : base(dynamicLinkLibrariesPath)
        {
        }

        public override void Dispose(bool disposing)
        {
            if (myVlcInstance != null)
                myVlcInstance.Dispose();

            if (MyAllInstance.ContainsValue(this))
            {
                foreach (var kv in new Dictionary<DirectoryInfo, VlcManager>(MyAllInstance))
                {
                    if(kv.Value == this)
                        MyAllInstance.Remove(kv.Key);
                }
            }
            base.Dispose(disposing);
        }

        public static VlcManager GetInstance(DirectoryInfo dynamicLinkLibrariesPath)
        {
            if (!MyAllInstance.ContainsKey(dynamicLinkLibrariesPath))
                MyAllInstance[dynamicLinkLibrariesPath] = new VlcManager(dynamicLinkLibrariesPath);
            return MyAllInstance[dynamicLinkLibrariesPath];
        }

        private void EnsureVlcInstance()
        {
            if (myVlcInstance == null)
            {
                throw new InvalidOperationException("This VlcManager has not yet been initialized. Call CreateNewInstance to initialize it.");
            }
        }
    }
}