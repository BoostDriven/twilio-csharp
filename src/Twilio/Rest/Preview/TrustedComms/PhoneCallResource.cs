/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
/// 
/// PhoneCallResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Preview.TrustedComms 
{

    public class PhoneCallResource : Resource 
    {
        private static Request BuildCreateRequest(CreatePhoneCallOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/TrustedComms/Business/PhoneCalls",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Initiates a Branded Call.
        /// </summary>
        /// <param name="options"> Create PhoneCall parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneCall </returns> 
        public static PhoneCallResource Create(CreatePhoneCallOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Initiates a Branded Call.
        /// </summary>
        /// <param name="options"> Create PhoneCall parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneCall </returns> 
        public static async System.Threading.Tasks.Task<PhoneCallResource> CreateAsync(CreatePhoneCallOptions options, 
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Initiates a Branded Call.
        /// </summary>
        /// <param name="from"> The originating Phone Number </param>
        /// <param name="to"> The terminating Phone Number </param>
        /// <param name="url"> The Twiml URL </param>
        /// <param name="reason"> The business reason for this phone call </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PhoneCall </returns> 
        public static PhoneCallResource Create(string from, 
                                               string to, 
                                               string url, 
                                               string reason = null, 
                                               ITwilioRestClient client = null)
        {
            var options = new CreatePhoneCallOptions(from, to, url){Reason = reason};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Initiates a Branded Call.
        /// </summary>
        /// <param name="from"> The originating Phone Number </param>
        /// <param name="to"> The terminating Phone Number </param>
        /// <param name="url"> The Twiml URL </param>
        /// <param name="reason"> The business reason for this phone call </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PhoneCall </returns> 
        public static async System.Threading.Tasks.Task<PhoneCallResource> CreateAsync(string from, 
                                                                                       string to, 
                                                                                       string url, 
                                                                                       string reason = null, 
                                                                                       ITwilioRestClient client = null)
        {
            var options = new CreatePhoneCallOptions(from, to, url){Reason = reason};
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a PhoneCallResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> PhoneCallResource object represented by the provided JSON </returns> 
        public static PhoneCallResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<PhoneCallResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A string that uniquely identifies this Current Call.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// Account Sid.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The originating Phone Number
        /// </summary>
        [JsonProperty("from")]
        public string From { get; private set; }
        /// <summary>
        /// The terminating Phone Number
        /// </summary>
        [JsonProperty("to")]
        public string To { get; private set; }
        /// <summary>
        /// The business reason for this phone call
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; private set; }
        /// <summary>
        /// The date this Current Call was created
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; private set; }
        /// <summary>
        /// The URL of this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private PhoneCallResource()
        {

        }
    }

}