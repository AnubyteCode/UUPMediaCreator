﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System.Text.Json.Serialization;

namespace Microsoft.StoreServices.DisplayCatalog.Product
{
    public class ProductConfiguration2
    {
        [JsonPropertyName("ProductConfigurationRenderHint")]
        public string ProductConfigurationRenderHint;

        [JsonPropertyName("ProductConfigurationProperties")]
        public ProductConfigurationProperty2[] ProductConfigurationProperties;
    }
}