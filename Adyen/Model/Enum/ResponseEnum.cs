﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.Enum
{
    /// <summary>
    /// Indicates if the modification request has been received for processing.
    /// </summary>
    /// <value>Indicates if the modification request has been received for processing.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResponseEnum
    {

        /// <summary>
        /// Enum CaptureReceived for "[capture-received]"
        /// </summary>
        [EnumMember(Value = "[capture-received]")]
        CaptureReceived,

        /// <summary>
        /// Enum CancelReceived for "[cancel-received]"
        /// </summary>
        [EnumMember(Value = "[cancel-received]")]
        CancelReceived,

        /// <summary>
        /// Enum RefundReceived for "[refund-received]"
        /// </summary>
        [EnumMember(Value = "[refund-received]")]
        RefundReceived,

        /// <summary>
        /// Enum CancelOrRefundReceived for "[cancelOrRefund-received]"
        /// </summary>
        [EnumMember(Value = "[cancelOrRefund-received]")]
        CancelOrRefundReceived,

        /// <summary>
        /// Enum CancelOrRefundReceived for "[cancelOrRefund-received]"
        /// </summary>
        [EnumMember(Value = "[adjustAuthorisation-received]")]
        AdjustAuthorisationReceived
    }
}
