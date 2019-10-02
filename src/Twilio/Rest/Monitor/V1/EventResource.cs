/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// EventResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Monitor.V1
{

    public class EventResource : Resource
    {
        private static Request BuildFetchRequest(FetchEventOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Monitor,
                "/v1/Events/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Event parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Event </returns>
        public static EventResource Fetch(FetchEventOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Event parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Event </returns>
        public static async System.Threading.Tasks.Task<EventResource> FetchAsync(FetchEventOptions options,
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
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Event </returns>
        public static EventResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchEventOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Event </returns>
        public static async System.Threading.Tasks.Task<EventResource> FetchAsync(string pathSid,
                                                                                  ITwilioRestClient client = null)
        {
            var options = new FetchEventOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadEventOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Monitor,
                "/v1/Events",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Returns a list of events in the account, sorted by event-date.
        /// </summary>
        /// <param name="options"> Read Event parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Event </returns>
        public static ResourceSet<EventResource> Read(ReadEventOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<EventResource>.FromJson("events", response.Content);
            return new ResourceSet<EventResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Returns a list of events in the account, sorted by event-date.
        /// </summary>
        /// <param name="options"> Read Event parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Event </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<EventResource>> ReadAsync(ReadEventOptions options,
                                                                                              ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<EventResource>.FromJson("events", response.Content);
            return new ResourceSet<EventResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Returns a list of events in the account, sorted by event-date.
        /// </summary>
        /// <param name="actorSid"> Only include events initiated by this Actor </param>
        /// <param name="eventType"> Only include events of this Event Type </param>
        /// <param name="resourceSid"> Only include events that refer to this resource </param>
        /// <param name="sourceIpAddress"> Only include events that originated from this IP address </param>
        /// <param name="startDate"> Only include events that occurred on or after this date </param>
        /// <param name="endDate"> Only include events that occurred on or before this date </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Event </returns>
        public static ResourceSet<EventResource> Read(string actorSid = null,
                                                      string eventType = null,
                                                      string resourceSid = null,
                                                      string sourceIpAddress = null,
                                                      DateTime? startDate = null,
                                                      DateTime? endDate = null,
                                                      int? pageSize = null,
                                                      long? limit = null,
                                                      ITwilioRestClient client = null)
        {
            var options = new ReadEventOptions(){ActorSid = actorSid, EventType = eventType, ResourceSid = resourceSid, SourceIpAddress = sourceIpAddress, StartDate = startDate, EndDate = endDate, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Returns a list of events in the account, sorted by event-date.
        /// </summary>
        /// <param name="actorSid"> Only include events initiated by this Actor </param>
        /// <param name="eventType"> Only include events of this Event Type </param>
        /// <param name="resourceSid"> Only include events that refer to this resource </param>
        /// <param name="sourceIpAddress"> Only include events that originated from this IP address </param>
        /// <param name="startDate"> Only include events that occurred on or after this date </param>
        /// <param name="endDate"> Only include events that occurred on or before this date </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Event </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<EventResource>> ReadAsync(string actorSid = null,
                                                                                              string eventType = null,
                                                                                              string resourceSid = null,
                                                                                              string sourceIpAddress = null,
                                                                                              DateTime? startDate = null,
                                                                                              DateTime? endDate = null,
                                                                                              int? pageSize = null,
                                                                                              long? limit = null,
                                                                                              ITwilioRestClient client = null)
        {
            var options = new ReadEventOptions(){ActorSid = actorSid, EventType = eventType, ResourceSid = resourceSid, SourceIpAddress = sourceIpAddress, StartDate = startDate, EndDate = endDate, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<EventResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<EventResource>.FromJson("events", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<EventResource> NextPage(Page<EventResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Monitor,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<EventResource>.FromJson("events", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<EventResource> PreviousPage(Page<EventResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Monitor,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<EventResource>.FromJson("events", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a EventResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> EventResource object represented by the provided JSON </returns>
        public static EventResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<EventResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The SID of the actor that caused the event, if available
        /// </summary>
        [JsonProperty("actor_sid")]
        public string ActorSid { get; private set; }
        /// <summary>
        /// The type of actor that caused the event
        /// </summary>
        [JsonProperty("actor_type")]
        public string ActorType { get; private set; }
        /// <summary>
        /// A description of the event
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }
        /// <summary>
        /// A JSON string that represents an object with additional data about the event
        /// </summary>
        [JsonProperty("event_data")]
        public object EventData { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the event was recorded
        /// </summary>
        [JsonProperty("event_date")]
        public DateTime? EventDate { get; private set; }
        /// <summary>
        /// The event's type
        /// </summary>
        [JsonProperty("event_type")]
        public string EventType { get; private set; }
        /// <summary>
        /// The SID of the resource that was affected
        /// </summary>
        [JsonProperty("resource_sid")]
        public string ResourceSid { get; private set; }
        /// <summary>
        /// The type of resource that was affected
        /// </summary>
        [JsonProperty("resource_type")]
        public string ResourceType { get; private set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The originating system or interface that caused the event
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; private set; }
        /// <summary>
        /// The IP address of the source
        /// </summary>
        [JsonProperty("source_ip_address")]
        public string SourceIpAddress { get; private set; }
        /// <summary>
        /// The absolute URL of the resource that was affected
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The absolute URLs of related resources
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private EventResource()
        {

        }
    }

}