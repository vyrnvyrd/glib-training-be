// <copyright file="IAssemblyProvider.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Reflection;

namespace Garuda.Extension.Extensions
{
    public interface IAssemblyProvider
    {
        IEnumerable<Assembly> GetAssemblies(string path, bool includingSubpaths);
    }
}