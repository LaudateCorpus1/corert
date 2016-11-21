// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace System.Runtime.CompilerServices
{
    // This Enum matchs the miImpl flags defined in corhdr.h. It is used to specify 
    // certain method properties.
    internal enum MethodImplOptions
    {
        NoInlining = 0x0008,
        NoOptimization = 0x0040,
        AggressiveInlining = 0x0100,
        InternalCall = 0x1000,
    }

    // Custom attribute to specify additional method properties.
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor, Inherited = false)]
    sealed internal class MethodImplAttribute : Attribute
    {
        internal MethodImplOptions _val;

        public MethodImplAttribute(MethodImplOptions methodImplOptions)
        {
            _val = methodImplOptions;
        }

        public MethodImplAttribute(short value)
        {
            _val = (MethodImplOptions)value;
        }

        public MethodImplAttribute()
        {
        }

        public MethodImplOptions Value { get { return _val; } }
    }
}
