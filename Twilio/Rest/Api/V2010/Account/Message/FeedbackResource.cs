using Newtonsoft.Json;
using System;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account.Message {

    public class FeedbackResource : Resource {
        public sealed class Outcome : IStringEnum {
            public const string CONFIRMED="confirmed";
            public const string UMCONFIRMED="umconfirmed";
        
            private string value;
            
            public Outcome() { }
            
            public Outcome(string value) {
                this.value = value;
            }
            
            public override string ToString() {
                return value;
            }
            
            public static implicit operator Outcome(string value) {
                return new Outcome(value);
            }
            
            public static implicit operator string(Outcome value) {
                return value.ToString();
            }
            
            public void FromString(string value) {
                this.value = value;
            }
        }
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="messageSid"> The message_sid </param>
        /// <returns> FeedbackCreator capable of executing the create </returns> 
        public static FeedbackCreator Creator(string accountSid, string messageSid) {
            return new FeedbackCreator(accountSid, messageSid);
        }
    
        /// <summary>
        /// Create a FeedbackCreator to execute create.
        /// </summary>
        ///
        /// <param name="messageSid"> The message_sid </param>
        /// <returns> FeedbackCreator capable of executing the create </returns> 
        public static FeedbackCreator Creator(string messageSid) {
            return new FeedbackCreator(messageSid);
        }
    
        /// <summary>
        /// Converts a JSON string into a FeedbackResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> FeedbackResource object represented by the provided JSON </returns> 
        public static FeedbackResource FromJson(string json) {
            // Convert all checked exceptions to Runtime
            try {
                return JsonConvert.DeserializeObject<FeedbackResource>(json);
            } catch (JsonException e) {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("account_sid")]
        private readonly string accountSid;
        [JsonProperty("message_sid")]
        private readonly string messageSid;
        [JsonProperty("outcome")]
        [JsonConverter(typeof(StringEnumConverter))]
        private readonly FeedbackResource.Outcome outcome;
        [JsonProperty("date_created")]
        private readonly DateTime? dateCreated;
        [JsonProperty("date_updated")]
        private readonly DateTime? dateUpdated;
        [JsonProperty("uri")]
        private readonly string uri;
    
        public FeedbackResource() {
        
        }
    
        private FeedbackResource([JsonProperty("account_sid")]
                                 string accountSid, 
                                 [JsonProperty("message_sid")]
                                 string messageSid, 
                                 [JsonProperty("outcome")]
                                 FeedbackResource.Outcome outcome, 
                                 [JsonProperty("date_created")]
                                 string dateCreated, 
                                 [JsonProperty("date_updated")]
                                 string dateUpdated, 
                                 [JsonProperty("uri")]
                                 string uri) {
            this.accountSid = accountSid;
            this.messageSid = messageSid;
            this.outcome = outcome;
            this.dateCreated = MarshalConverter.DateTimeFromString(dateCreated);
            this.dateUpdated = MarshalConverter.DateTimeFromString(dateUpdated);
            this.uri = uri;
        }
    
        /// <returns> The account_sid </returns> 
        public string GetAccountSid() {
            return this.accountSid;
        }
    
        /// <returns> The message_sid </returns> 
        public string GetMessageSid() {
            return this.messageSid;
        }
    
        /// <returns> The outcome </returns> 
        public FeedbackResource.Outcome GetOutcome() {
            return this.outcome;
        }
    
        /// <returns> The date_created </returns> 
        public DateTime? GetDateCreated() {
            return this.dateCreated;
        }
    
        /// <returns> The date_updated </returns> 
        public DateTime? GetDateUpdated() {
            return this.dateUpdated;
        }
    
        /// <returns> The uri </returns> 
        public string GetUri() {
            return this.uri;
        }
    }
}