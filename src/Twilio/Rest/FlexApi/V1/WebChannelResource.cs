/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// WebChannelResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.FlexApi.V1
{

    public class WebChannelResource : Resource
    {
        public sealed class ChatStatusEnum : StringEnum
        {
            private ChatStatusEnum(string value) : base(value) {}
            public ChatStatusEnum() {}
            public static implicit operator ChatStatusEnum(string value)
            {
                return new ChatStatusEnum(value);
            }

            public static readonly ChatStatusEnum Inactive = new ChatStatusEnum("inactive");
        }

        private static Request BuildReadRequest(ReadWebChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                "/v1/WebChannels",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read WebChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WebChannel </returns>
        public static ResourceSet<WebChannelResource> Read(ReadWebChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<WebChannelResource>.FromJson("flex_chat_channels", response.Content);
            return new ResourceSet<WebChannelResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read WebChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WebChannel </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<WebChannelResource>> ReadAsync(ReadWebChannelOptions options,
                                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<WebChannelResource>.FromJson("flex_chat_channels", response.Content);
            return new ResourceSet<WebChannelResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WebChannel </returns>
        public static ResourceSet<WebChannelResource> Read(int? pageSize = null,
                                                           long? limit = null,
                                                           ITwilioRestClient client = null)
        {
            var options = new ReadWebChannelOptions(){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WebChannel </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<WebChannelResource>> ReadAsync(int? pageSize = null,
                                                                                                   long? limit = null,
                                                                                                   ITwilioRestClient client = null)
        {
            var options = new ReadWebChannelOptions(){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<WebChannelResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<WebChannelResource>.FromJson("flex_chat_channels", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<WebChannelResource> NextPage(Page<WebChannelResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.FlexApi,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<WebChannelResource>.FromJson("flex_chat_channels", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<WebChannelResource> PreviousPage(Page<WebChannelResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.FlexApi,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<WebChannelResource>.FromJson("flex_chat_channels", response.Content);
        }

        private static Request BuildFetchRequest(FetchWebChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                "/v1/WebChannels/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch WebChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WebChannel </returns>
        public static WebChannelResource Fetch(FetchWebChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch WebChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WebChannel </returns>
        public static async System.Threading.Tasks.Task<WebChannelResource> FetchAsync(FetchWebChannelOptions options,
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> The SID of the WebChannel resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WebChannel </returns>
        public static WebChannelResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchWebChannelOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> The SID of the WebChannel resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WebChannel </returns>
        public static async System.Threading.Tasks.Task<WebChannelResource> FetchAsync(string pathSid,
                                                                                       ITwilioRestClient client = null)
        {
            var options = new FetchWebChannelOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateWebChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                "/v1/WebChannels",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create WebChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WebChannel </returns>
        public static WebChannelResource Create(CreateWebChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create WebChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WebChannel </returns>
        public static async System.Threading.Tasks.Task<WebChannelResource> CreateAsync(CreateWebChannelOptions options,
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="flexFlowSid"> The SID of the FlexFlow </param>
        /// <param name="identity"> The chat identity </param>
        /// <param name="customerFriendlyName"> The chat participant's friendly name </param>
        /// <param name="chatFriendlyName"> The chat channel's friendly name </param>
        /// <param name="chatUniqueName"> The chat channel's unique name </param>
        /// <param name="preEngagementData"> The pre-engagement data </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WebChannel </returns>
        public static WebChannelResource Create(string flexFlowSid,
                                                string identity,
                                                string customerFriendlyName,
                                                string chatFriendlyName,
                                                string chatUniqueName = null,
                                                string preEngagementData = null,
                                                ITwilioRestClient client = null)
        {
            var options = new CreateWebChannelOptions(flexFlowSid, identity, customerFriendlyName, chatFriendlyName){ChatUniqueName = chatUniqueName, PreEngagementData = preEngagementData};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="flexFlowSid"> The SID of the FlexFlow </param>
        /// <param name="identity"> The chat identity </param>
        /// <param name="customerFriendlyName"> The chat participant's friendly name </param>
        /// <param name="chatFriendlyName"> The chat channel's friendly name </param>
        /// <param name="chatUniqueName"> The chat channel's unique name </param>
        /// <param name="preEngagementData"> The pre-engagement data </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WebChannel </returns>
        public static async System.Threading.Tasks.Task<WebChannelResource> CreateAsync(string flexFlowSid,
                                                                                        string identity,
                                                                                        string customerFriendlyName,
                                                                                        string chatFriendlyName,
                                                                                        string chatUniqueName = null,
                                                                                        string preEngagementData = null,
                                                                                        ITwilioRestClient client = null)
        {
            var options = new CreateWebChannelOptions(flexFlowSid, identity, customerFriendlyName, chatFriendlyName){ChatUniqueName = chatUniqueName, PreEngagementData = preEngagementData};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateWebChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                "/v1/WebChannels/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update WebChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WebChannel </returns>
        public static WebChannelResource Update(UpdateWebChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update WebChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WebChannel </returns>
        public static async System.Threading.Tasks.Task<WebChannelResource> UpdateAsync(UpdateWebChannelOptions options,
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to update </param>
        /// <param name="chatStatus"> The chat status </param>
        /// <param name="postEngagementData"> The post-engagement data </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WebChannel </returns>
        public static WebChannelResource Update(string pathSid,
                                                WebChannelResource.ChatStatusEnum chatStatus = null,
                                                string postEngagementData = null,
                                                ITwilioRestClient client = null)
        {
            var options = new UpdateWebChannelOptions(pathSid){ChatStatus = chatStatus, PostEngagementData = postEngagementData};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to update </param>
        /// <param name="chatStatus"> The chat status </param>
        /// <param name="postEngagementData"> The post-engagement data </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WebChannel </returns>
        public static async System.Threading.Tasks.Task<WebChannelResource> UpdateAsync(string pathSid,
                                                                                        WebChannelResource.ChatStatusEnum chatStatus = null,
                                                                                        string postEngagementData = null,
                                                                                        ITwilioRestClient client = null)
        {
            var options = new UpdateWebChannelOptions(pathSid){ChatStatus = chatStatus, PostEngagementData = postEngagementData};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteWebChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.FlexApi,
                "/v1/WebChannels/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete WebChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WebChannel </returns>
        public static bool Delete(DeleteWebChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete WebChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WebChannel </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteWebChannelOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WebChannel </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteWebChannelOptions(pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WebChannel </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteWebChannelOptions(pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a WebChannelResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> WebChannelResource object represented by the provided JSON </returns>
        public static WebChannelResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<WebChannelResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The SID of the Account that created the resource and owns this Workflow
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The SID of the FlexFlow
        /// </summary>
        [JsonProperty("flex_flow_sid")]
        public string FlexFlowSid { get; private set; }
        /// <summary>
        /// The unique string that identifies the WebChannel resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The absolute URL of the WebChannel resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }

        private WebChannelResource()
        {

        }
    }

}