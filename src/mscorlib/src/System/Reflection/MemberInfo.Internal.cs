// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Reflection
{
    public abstract partial class MemberInfo
    {
        internal virtual bool CacheEquals(object o) { throw new NotImplementedException(); }
    }
}
