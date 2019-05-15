/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// TaskChannelResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Taskrouter.V1.Workspace 
{

    public class TaskChannelResource : Resource 
    {
        private static Request BuildFetchRequest(FetchTaskChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/TaskChannels/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch TaskChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskChannel </returns> 
        public static TaskChannelResource Fetch(FetchTaskChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch TaskChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskChannel </returns> 
        public static async System.Threading.Tasks.Task<TaskChannelResource> FetchAsync(FetchTaskChannelOptions options, 
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
        /// <param name="pathWorkspaceSid"> The unique ID of the Workspace that this TaskChannel belongs to. </param>
        /// <param name="pathSid"> The unique ID for this TaskChannel. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskChannel </returns> 
        public static TaskChannelResource Fetch(string pathWorkspaceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchTaskChannelOptions(pathWorkspaceSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathWorkspaceSid"> The unique ID of the Workspace that this TaskChannel belongs to. </param>
        /// <param name="pathSid"> The unique ID for this TaskChannel. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskChannel </returns> 
        public static async System.Threading.Tasks.Task<TaskChannelResource> FetchAsync(string pathWorkspaceSid, 
                                                                                        string pathSid, 
                                                                                        ITwilioRestClient client = null)
        {
            var options = new FetchTaskChannelOptions(pathWorkspaceSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadTaskChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/TaskChannels",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read TaskChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskChannel </returns> 
        public static ResourceSet<TaskChannelResource> Read(ReadTaskChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<TaskChannelResource>.FromJson("channels", response.Content);
            return new ResourceSet<TaskChannelResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read TaskChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskChannel </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<TaskChannelResource>> ReadAsync(ReadTaskChannelOptions options, 
                                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<TaskChannelResource>.FromJson("channels", response.Content);
            return new ResourceSet<TaskChannelResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathWorkspaceSid"> The unique ID of the Workspace that this TaskChannel belongs to. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskChannel </returns> 
        public static ResourceSet<TaskChannelResource> Read(string pathWorkspaceSid, 
                                                            int? pageSize = null, 
                                                            long? limit = null, 
                                                            ITwilioRestClient client = null)
        {
            var options = new ReadTaskChannelOptions(pathWorkspaceSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathWorkspaceSid"> The unique ID of the Workspace that this TaskChannel belongs to. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskChannel </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<TaskChannelResource>> ReadAsync(string pathWorkspaceSid, 
                                                                                                    int? pageSize = null, 
                                                                                                    long? limit = null, 
                                                                                                    ITwilioRestClient client = null)
        {
            var options = new ReadTaskChannelOptions(pathWorkspaceSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<TaskChannelResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<TaskChannelResource>.FromJson("channels", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<TaskChannelResource> NextPage(Page<TaskChannelResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Taskrouter,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<TaskChannelResource>.FromJson("channels", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<TaskChannelResource> PreviousPage(Page<TaskChannelResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Taskrouter,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<TaskChannelResource>.FromJson("channels", response.Content);
        }

        private static Request BuildUpdateRequest(UpdateTaskChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/TaskChannels/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update TaskChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskChannel </returns> 
        public static TaskChannelResource Update(UpdateTaskChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update TaskChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskChannel </returns> 
        public static async System.Threading.Tasks.Task<TaskChannelResource> UpdateAsync(UpdateTaskChannelOptions options, 
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
        /// <param name="pathWorkspaceSid"> The unique ID of the Workspace that this TaskChannel belongs to. </param>
        /// <param name="pathSid"> The unique ID for this TaskChannel. </param>
        /// <param name="friendlyName"> Toggle the FriendlyName for the TaskChannel </param>
        /// <param name="channelOptimizedRouting"> If true then prioritize longest idle workers </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskChannel </returns> 
        public static TaskChannelResource Update(string pathWorkspaceSid, 
                                                 string pathSid, 
                                                 string friendlyName = null, 
                                                 bool? channelOptimizedRouting = null, 
                                                 ITwilioRestClient client = null)
        {
            var options = new UpdateTaskChannelOptions(pathWorkspaceSid, pathSid){FriendlyName = friendlyName, ChannelOptimizedRouting = channelOptimizedRouting};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathWorkspaceSid"> The unique ID of the Workspace that this TaskChannel belongs to. </param>
        /// <param name="pathSid"> The unique ID for this TaskChannel. </param>
        /// <param name="friendlyName"> Toggle the FriendlyName for the TaskChannel </param>
        /// <param name="channelOptimizedRouting"> If true then prioritize longest idle workers </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskChannel </returns> 
        public static async System.Threading.Tasks.Task<TaskChannelResource> UpdateAsync(string pathWorkspaceSid, 
                                                                                         string pathSid, 
                                                                                         string friendlyName = null, 
                                                                                         bool? channelOptimizedRouting = null, 
                                                                                         ITwilioRestClient client = null)
        {
            var options = new UpdateTaskChannelOptions(pathWorkspaceSid, pathSid){FriendlyName = friendlyName, ChannelOptimizedRouting = channelOptimizedRouting};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteTaskChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/TaskChannels/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete TaskChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskChannel </returns> 
        public static bool Delete(DeleteTaskChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete TaskChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskChannel </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteTaskChannelOptions options, 
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
        /// <param name="pathWorkspaceSid"> The unique ID of the Workspace that this TaskChannel belongs to. </param>
        /// <param name="pathSid"> The unique ID for this TaskChannel. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskChannel </returns> 
        public static bool Delete(string pathWorkspaceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteTaskChannelOptions(pathWorkspaceSid, pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathWorkspaceSid"> The unique ID of the Workspace that this TaskChannel belongs to. </param>
        /// <param name="pathSid"> The unique ID for this TaskChannel. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskChannel </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathWorkspaceSid, 
                                                                          string pathSid, 
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteTaskChannelOptions(pathWorkspaceSid, pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateTaskChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/TaskChannels",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create TaskChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskChannel </returns> 
        public static TaskChannelResource Create(CreateTaskChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create TaskChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskChannel </returns> 
        public static async System.Threading.Tasks.Task<TaskChannelResource> CreateAsync(CreateTaskChannelOptions options, 
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
        /// <param name="pathWorkspaceSid"> The unique ID of the Workspace that this TaskChannel belongs to. </param>
        /// <param name="friendlyName"> String representing user-friendly name for the TaskChannel </param>
        /// <param name="uniqueName"> String representing unique name for the TaskChannel </param>
        /// <param name="channelOptimizedRouting"> If true then prioritize longest idle workers </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskChannel </returns> 
        public static TaskChannelResource Create(string pathWorkspaceSid, 
                                                 string friendlyName, 
                                                 string uniqueName, 
                                                 bool? channelOptimizedRouting = null, 
                                                 ITwilioRestClient client = null)
        {
            var options = new CreateTaskChannelOptions(pathWorkspaceSid, friendlyName, uniqueName){ChannelOptimizedRouting = channelOptimizedRouting};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathWorkspaceSid"> The unique ID of the Workspace that this TaskChannel belongs to. </param>
        /// <param name="friendlyName"> String representing user-friendly name for the TaskChannel </param>
        /// <param name="uniqueName"> String representing unique name for the TaskChannel </param>
        /// <param name="channelOptimizedRouting"> If true then prioritize longest idle workers </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskChannel </returns> 
        public static async System.Threading.Tasks.Task<TaskChannelResource> CreateAsync(string pathWorkspaceSid, 
                                                                                         string friendlyName, 
                                                                                         string uniqueName, 
                                                                                         bool? channelOptimizedRouting = null, 
                                                                                         ITwilioRestClient client = null)
        {
            var options = new CreateTaskChannelOptions(pathWorkspaceSid, friendlyName, uniqueName){ChannelOptimizedRouting = channelOptimizedRouting};
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a TaskChannelResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TaskChannelResource object represented by the provided JSON </returns> 
        public static TaskChannelResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<TaskChannelResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique ID of the Account that owns this TaskChannel.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The date this TaskChannel was created.
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this TaskChannel was updated.
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The friendly name of this TaskChannel
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The unique ID for this TaskChannel.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The unique name of TaskChannel, such as 'voice', 'sms', etc.
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// The unique ID of the Workspace that this TaskChannel belongs to.
        /// </summary>
        [JsonProperty("workspace_sid")]
        public string WorkspaceSid { get; private set; }
        /// <summary>
        /// If true then prioritize longest idle workers
        /// </summary>
        [JsonProperty("channel_optimized_routing")]
        public bool? ChannelOptimizedRouting { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private TaskChannelResource()
        {

        }
    }

}