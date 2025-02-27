﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Enum
{
    /// <summary>
    /// Indicates whether device fingerprinting was successfully completed.
    /// </summary>
    /// <value>Indicates whether device fingerprinting was successfully completed.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeviceFingerprintCompletedEnum
    {

        /// <summary>
        /// Enum U for "Unavailable"
        /// </summary>
        [EnumMember(Value = "U")]
        U,

        /// <summary>
        /// Enum Y for "Successfully Completed"
        /// </summary>
        [EnumMember(Value = "Y")]
        Y,

        /// <summary>
        /// Enum N for "Did not successfully complete"
        /// </summary>
        [EnumMember(Value = "N")]
        N
    }
}
