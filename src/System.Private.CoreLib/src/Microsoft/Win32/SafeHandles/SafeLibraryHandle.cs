// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Win32.SafeHandles;
using System;

namespace Microsoft.Win32 
{
    sealed internal class SafeLibraryHandle : SafeHandleZeroOrMinusOneIsInvalid 
    {
        internal SafeLibraryHandle() : base(true) {}
        internal SafeLibraryHandle(IntPtr handle) : base(handle, true) {}

        override protected bool ReleaseHandle()
        {
            return Interop.mincore.FreeLibrary(handle);
        }
    }
}
