// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.AspNetCore.Mvc
{
    /// <summary>
    /// An attribute that enables binding for all properties on the decorated controller or Razor Page model.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class BindPropertiesAttribute : Attribute
    {
        /// <summary>
        /// When <c>true</c>, allows properties to be bound on GET requests.
        /// </summary>
        public bool SupportsGet { get; set; }
    }
}
