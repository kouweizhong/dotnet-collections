#if !NET45PLUS

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Diagnostics.CodeAnalysis;

namespace System.Collections.Generic
{
    /// <summary>
    /// Defined on a generic collection that sorts its contents using an <see cref="IComparer{TKey}"/>.
    /// </summary>
    /// <typeparam name="TKey">The type of element sorted in the collection.</typeparam>
    [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
#if NET40PLUS
    internal interface ISortKeyCollection<in TKey>
#else
    internal interface ISortKeyCollection<TKey>
#endif
    {
        /// <summary>
        /// Gets the comparer used to sort keys.
        /// </summary>
        IComparer<TKey> KeyComparer { get; }
    }
}

#endif
