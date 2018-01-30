﻿using System;
using JCSystem.Core.Vlc.Interops;
using JCSystem.Core.Vlc.Interops.Signatures.libvlc.h;

namespace JCSystem.Core.Vlc
{
	public sealed class FilterModuleDescription
    {
        public string Name { get; private set; }
        public string ShortName { get; private set; }
        public string LongName { get; private set; }
        public string Help { get; private set; }

        private FilterModuleDescription()
        {
        }

        internal static FilterModuleDescription GetFilterModuleDescription(ModuleDescriptionStructure module)
        {
            if (module.Name == IntPtr.Zero)
                return null;
            var result = new FilterModuleDescription
            {
                Name = Utf8InteropStringConverter.Utf8InteropToString(module.Name),
                ShortName = Utf8InteropStringConverter.Utf8InteropToString(module.ShortName),
                LongName = Utf8InteropStringConverter.Utf8InteropToString(module.LongName),
                Help = Utf8InteropStringConverter.Utf8InteropToString(module.Help)
            };
            return result;
        }
    }
}
