// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.PhoneNumbers.Models
{
    /// <summary> Represents a location options parameter, used for fetching area codes. </summary>
    public partial class LocationOptionsQuery
    {
        /// <summary> Initializes a new instance of LocationOptionsQuery. </summary>
        public LocationOptionsQuery()
        {
        }

        /// <summary> Represents the location option label id, returned from the GetLocationOptions API. </summary>
        public string LabelId { get; set; }
        /// <summary> Represents the location options value, returned from the GetLocationOptions API. </summary>
        public string OptionsValue { get; set; }
    }
}
