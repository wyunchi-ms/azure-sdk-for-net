// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AssetContainerPermission.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AssetContainerPermission
    {
        /// <summary>
        /// The SAS URL will allow read access to the container.
        /// </summary>
        [EnumMember(Value = "Read")]
        Read,
        /// <summary>
        /// The SAS URL will allow read and write access to the container.
        /// </summary>
        [EnumMember(Value = "ReadWrite")]
        ReadWrite,
        /// <summary>
        /// The SAS URL will allow read, write and delete access to the
        /// container.
        /// </summary>
        [EnumMember(Value = "ReadWriteDelete")]
        ReadWriteDelete
    }
    internal static class AssetContainerPermissionEnumExtension
    {
        internal static string ToSerializedValue(this AssetContainerPermission? value)
        {
            return value == null ? null : ((AssetContainerPermission)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AssetContainerPermission value)
        {
            switch( value )
            {
                case AssetContainerPermission.Read:
                    return "Read";
                case AssetContainerPermission.ReadWrite:
                    return "ReadWrite";
                case AssetContainerPermission.ReadWriteDelete:
                    return "ReadWriteDelete";
            }
            return null;
        }

        internal static AssetContainerPermission? ParseAssetContainerPermission(this string value)
        {
            switch( value )
            {
                case "Read":
                    return AssetContainerPermission.Read;
                case "ReadWrite":
                    return AssetContainerPermission.ReadWrite;
                case "ReadWriteDelete":
                    return AssetContainerPermission.ReadWriteDelete;
            }
            return null;
        }
    }
}