/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PublishedTrackResource
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

namespace Twilio.Rest.Video.V1.Room.Participant
{

    public class PublishedTrackResource : Resource
    {
        public sealed class KindEnum : StringEnum
        {
            private KindEnum(string value) : base(value) {}
            public KindEnum() {}
            public static implicit operator KindEnum(string value)
            {
                return new KindEnum(value);
            }

            public static readonly KindEnum Audio = new KindEnum("audio");
            public static readonly KindEnum Video = new KindEnum("video");
            public static readonly KindEnum Data = new KindEnum("data");
        }

        private static Request BuildFetchRequest(FetchPublishedTrackOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Video,
                "/v1/Rooms/" + options.PathRoomSid + "/Participants/" + options.PathParticipantSid + "/PublishedTracks/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Returns a single Track resource represented by TrackName or SID.
        /// </summary>
        /// <param name="options"> Fetch PublishedTrack parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PublishedTrack </returns>
        public static PublishedTrackResource Fetch(FetchPublishedTrackOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Returns a single Track resource represented by TrackName or SID.
        /// </summary>
        /// <param name="options"> Fetch PublishedTrack parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PublishedTrack </returns>
        public static async System.Threading.Tasks.Task<PublishedTrackResource> FetchAsync(FetchPublishedTrackOptions options,
                                                                                           ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Returns a single Track resource represented by TrackName or SID.
        /// </summary>
        /// <param name="pathRoomSid"> The SID of the Room resource where the Track resource to fetch is published </param>
        /// <param name="pathParticipantSid"> The SID of the Participant resource with the published track to fetch </param>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PublishedTrack </returns>
        public static PublishedTrackResource Fetch(string pathRoomSid,
                                                   string pathParticipantSid,
                                                   string pathSid,
                                                   ITwilioRestClient client = null)
        {
            var options = new FetchPublishedTrackOptions(pathRoomSid, pathParticipantSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Returns a single Track resource represented by TrackName or SID.
        /// </summary>
        /// <param name="pathRoomSid"> The SID of the Room resource where the Track resource to fetch is published </param>
        /// <param name="pathParticipantSid"> The SID of the Participant resource with the published track to fetch </param>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PublishedTrack </returns>
        public static async System.Threading.Tasks.Task<PublishedTrackResource> FetchAsync(string pathRoomSid,
                                                                                           string pathParticipantSid,
                                                                                           string pathSid,
                                                                                           ITwilioRestClient client = null)
        {
            var options = new FetchPublishedTrackOptions(pathRoomSid, pathParticipantSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadPublishedTrackOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Video,
                "/v1/Rooms/" + options.PathRoomSid + "/Participants/" + options.PathParticipantSid + "/PublishedTracks",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Returns a list of tracks associated with a given Participant. Only `currently` Published Tracks are in the list
        /// resource.
        /// </summary>
        /// <param name="options"> Read PublishedTrack parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PublishedTrack </returns>
        public static ResourceSet<PublishedTrackResource> Read(ReadPublishedTrackOptions options,
                                                               ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<PublishedTrackResource>.FromJson("published_tracks", response.Content);
            return new ResourceSet<PublishedTrackResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Returns a list of tracks associated with a given Participant. Only `currently` Published Tracks are in the list
        /// resource.
        /// </summary>
        /// <param name="options"> Read PublishedTrack parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PublishedTrack </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<PublishedTrackResource>> ReadAsync(ReadPublishedTrackOptions options,
                                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<PublishedTrackResource>.FromJson("published_tracks", response.Content);
            return new ResourceSet<PublishedTrackResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Returns a list of tracks associated with a given Participant. Only `currently` Published Tracks are in the list
        /// resource.
        /// </summary>
        /// <param name="pathRoomSid"> The SID of the Room resource where the Track resources to read are published </param>
        /// <param name="pathParticipantSid"> The SID of the Participant resource with the published tracks to read </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of PublishedTrack </returns>
        public static ResourceSet<PublishedTrackResource> Read(string pathRoomSid,
                                                               string pathParticipantSid,
                                                               int? pageSize = null,
                                                               long? limit = null,
                                                               ITwilioRestClient client = null)
        {
            var options = new ReadPublishedTrackOptions(pathRoomSid, pathParticipantSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Returns a list of tracks associated with a given Participant. Only `currently` Published Tracks are in the list
        /// resource.
        /// </summary>
        /// <param name="pathRoomSid"> The SID of the Room resource where the Track resources to read are published </param>
        /// <param name="pathParticipantSid"> The SID of the Participant resource with the published tracks to read </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of PublishedTrack </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<PublishedTrackResource>> ReadAsync(string pathRoomSid,
                                                                                                       string pathParticipantSid,
                                                                                                       int? pageSize = null,
                                                                                                       long? limit = null,
                                                                                                       ITwilioRestClient client = null)
        {
            var options = new ReadPublishedTrackOptions(pathRoomSid, pathParticipantSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<PublishedTrackResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<PublishedTrackResource>.FromJson("published_tracks", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<PublishedTrackResource> NextPage(Page<PublishedTrackResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Video,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<PublishedTrackResource>.FromJson("published_tracks", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<PublishedTrackResource> PreviousPage(Page<PublishedTrackResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Video,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<PublishedTrackResource>.FromJson("published_tracks", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a PublishedTrackResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> PublishedTrackResource object represented by the provided JSON </returns>
        public static PublishedTrackResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<PublishedTrackResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The SID of the Participant resource with the published track
        /// </summary>
        [JsonProperty("participant_sid")]
        public string ParticipantSid { get; private set; }
        /// <summary>
        /// The SID of the Room resource where the track is published
        /// </summary>
        [JsonProperty("room_sid")]
        public string RoomSid { get; private set; }
        /// <summary>
        /// The track name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }
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
        /// <summary>
        /// Whether the track is enabled
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; private set; }
        /// <summary>
        /// The track type
        /// </summary>
        [JsonProperty("kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public PublishedTrackResource.KindEnum Kind { get; private set; }
        /// <summary>
        /// The absolute URL of the resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private PublishedTrackResource()
        {

        }
    }

}