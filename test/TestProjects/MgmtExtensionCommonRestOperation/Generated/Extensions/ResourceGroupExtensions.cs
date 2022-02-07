// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources;

namespace MgmtExtensionCommonRestOperation
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((client) =>
            {
                return new ResourceGroupExtensionClient(client, resourceGroup.Id);
            }
            );
        }

        /// <summary> Gets a collection of TypeOnes in the TypeOne. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of TypeOnes and their operations over a TypeOne. </returns>
        public static TypeOneCollection GetTypeOnes(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetTypeOnes();
        }

        /// <summary> Gets a collection of TypeTwos in the TypeTwo. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of TypeTwos and their operations over a TypeTwo. </returns>
        public static TypeTwoCollection GetTypeTwos(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetTypeTwos();
        }
    }
}