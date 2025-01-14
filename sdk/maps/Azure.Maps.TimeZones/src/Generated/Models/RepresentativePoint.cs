// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.TimeZones
{
    /// <summary> Representative point property. </summary>
    internal partial class RepresentativePoint
    {
        /// <summary> Initializes a new instance of <see cref="RepresentativePoint"/>. </summary>
        internal RepresentativePoint()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RepresentativePoint"/>. </summary>
        /// <param name="latitude"> Latitude property. </param>
        /// <param name="longitude"> Longitude property. </param>
        internal RepresentativePoint(float? latitude, float? longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        /// <summary> Latitude property. </summary>
        public float? Latitude { get; }
        /// <summary> Longitude property. </summary>
        public float? Longitude { get; }
    }
}
