﻿using Adyen.Model.ApplicationInformation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Adyen.Model.Modification
{
    [DataContract]
    public class AdjustAuthorisationRequest : AbstractModificationRequest
    {
        public AdjustAuthorisationRequest()
        {
            if (ApplicationInfo == null)
                ApplicationInfo = new ApplicationInfo();
        }
        [DataMember(Name = "AdjustAuthorisationRequest", EmitDefaultValue = false)]
        public Amount ModificationAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaptureRequest {\n");
            sb.Append(base.ToString());
            sb.Append("  modificationAmount.Currency: ").Append(ModificationAmount.Currency).Append("\n");
            sb.Append("  modificationAmount.Value: ").Append(ModificationAmount.Value).Append("\n");
            sb.Append("  originalReference: ").Append(OriginalReference).Append("\n");
            sb.Append("}");
            return sb.ToString();
        }
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
