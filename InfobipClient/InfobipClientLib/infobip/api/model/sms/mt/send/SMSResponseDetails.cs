using System.Collections.Generic;
using InfobipClient.infobip.api.model;
using Newtonsoft.Json;
using System;

namespace InfobipClient.infobip.api.model.sms.mt.send
{
    /// <summary>
    /// This is a generated class and is not intended for modification!
    /// </summary>
    public class SMSResponseDetails
    {
        [JsonProperty("smsCount")]
        public int? SmsCount { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        public override bool Equals(object obj)
        {
            var thisClass = obj as SMSResponseDetails;
            return thisClass != null &&
                EqualityComparer<int?>.Default.Equals(SmsCount, thisClass.SmsCount) &&
                EqualityComparer<string>.Default.Equals(MessageId, thisClass.MessageId) &&
                EqualityComparer<string>.Default.Equals(To, thisClass.To) &&
                EqualityComparer<Status>.Default.Equals(Status, thisClass.Status);
        }

        public override int GetHashCode()
        {
            var hashCode = -1559463931;
            hashCode = hashCode * -1521134295 +  EqualityComparer<int?>.Default.GetHashCode(SmsCount);
            hashCode = hashCode * -1521134295 +  EqualityComparer<string>.Default.GetHashCode(MessageId);
            hashCode = hashCode * -1521134295 +  EqualityComparer<string>.Default.GetHashCode(To);
            hashCode = hashCode * -1521134295 +  EqualityComparer<Status>.Default.GetHashCode(Status);
            return hashCode;
        }
    }
}