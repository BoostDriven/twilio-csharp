/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// CurrentCallResource
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

    public class CurrentCallResource : Resource
    {
        private static Request BuildFetchRequest(FetchCurrentCallOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/TrustedComms/CurrentCall",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a current call given the originating and terminating number via `X-XCNAM-Sensitive-Phone-Number-From` and
        /// `X-XCNAM-Sensitive-Phone-Number-To` headers.
        /// </summary>
        /// <param name="options"> Fetch CurrentCall parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CurrentCall </returns>
        public static CurrentCallResource Fetch(FetchCurrentCallOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a current call given the originating and terminating number via `X-XCNAM-Sensitive-Phone-Number-From` and
        /// `X-XCNAM-Sensitive-Phone-Number-To` headers.
        /// </summary>
        /// <param name="options"> Fetch CurrentCall parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CurrentCall </returns>
        public static async System.Threading.Tasks.Task<CurrentCallResource> FetchAsync(FetchCurrentCallOptions options,
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Retrieve a current call given the originating and terminating number via `X-XCNAM-Sensitive-Phone-Number-From` and
        /// `X-XCNAM-Sensitive-Phone-Number-To` headers.
        /// </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of CurrentCall </returns>
        public static CurrentCallResource Fetch(ITwilioRestClient client = null)
        {
            var options = new FetchCurrentCallOptions();
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a current call given the originating and terminating number via `X-XCNAM-Sensitive-Phone-Number-From` and
        /// `X-XCNAM-Sensitive-Phone-Number-To` headers.
        /// </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of CurrentCall </returns>
        public static async System.Threading.Tasks.Task<CurrentCallResource> FetchAsync(ITwilioRestClient client = null)
        {
            var options = new FetchCurrentCallOptions();
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a CurrentCallResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CurrentCallResource object represented by the provided JSON </returns>
        public static CurrentCallResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<CurrentCallResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A string that uniquely identifies this current phone call.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The originating phone number
        /// </summary>
        [JsonProperty("from")]
        public string From { get; private set; }
        /// <summary>
        /// The terminating phone number
        /// </summary>
        [JsonProperty("to")]
        public string To { get; private set; }
        /// <summary>
        /// The status of the current phone call
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; private set; }
        /// <summary>
        /// The business reason for this current phone call
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; private set; }
        /// <summary>
        /// The date this current phone call was created
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; private set; }
        /// <summary>
        /// Caller name of the current phone call
        /// </summary>
        [JsonProperty("caller")]
        public string Caller { get; private set; }
        /// <summary>
        /// Logo URL of the caller
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; private set; }
        /// <summary>
        /// Background color of the current phone call
        /// </summary>
        [JsonProperty("bg_color")]
        public string BgColor { get; private set; }
        /// <summary>
        /// Font color of the current phone call
        /// </summary>
        [JsonProperty("font_color")]
        public string FontColor { get; private set; }
        /// <summary>
        /// The use case for the current phone call
        /// </summary>
        [JsonProperty("use_case")]
        public string UseCase { get; private set; }
        /// <summary>
        /// The name of the CPS organization
        /// </summary>
        [JsonProperty("manager")]
        public string Manager { get; private set; }
        /// <summary>
        /// Shield image URL that serves as authenticity proof of the current phone call
        /// </summary>
        [JsonProperty("shield_img")]
        public string ShieldImg { get; private set; }
        /// <summary>
        /// The URL of this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private CurrentCallResource()
        {

        }
    }

}