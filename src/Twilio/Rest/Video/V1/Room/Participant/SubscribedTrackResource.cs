/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// SubscribedTrackResource
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

    public class SubscribedTrackResource : Resource 
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

        private static Request BuildFetchRequest(FetchSubscribedTrackOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Video,
                "/v1/Rooms/" + options.PathRoomSid + "/Participants/" + options.PathParticipantSid + "/SubscribedTracks/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Returns a single Track resource represented by `TrackSid`.  Note: This is one resource with the Video API that
        /// requires a Sid, as Track Name on the subscriber side is not guaranteed to be unique.
        /// </summary>
        /// <param name="options"> Fetch SubscribedTrack parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribedTrack </returns> 
        public static SubscribedTrackResource Fetch(FetchSubscribedTrackOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Returns a single Track resource represented by `TrackSid`.  Note: This is one resource with the Video API that
        /// requires a Sid, as Track Name on the subscriber side is not guaranteed to be unique.
        /// </summary>
        /// <param name="options"> Fetch SubscribedTrack parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribedTrack </returns> 
        public static async System.Threading.Tasks.Task<SubscribedTrackResource> FetchAsync(FetchSubscribedTrackOptions options, 
                                                                                            ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Returns a single Track resource represented by `TrackSid`.  Note: This is one resource with the Video API that
        /// requires a Sid, as Track Name on the subscriber side is not guaranteed to be unique.
        /// </summary>
        /// <param name="pathRoomSid"> Unique Room identifier where this Track is subscribed. </param>
        /// <param name="pathParticipantSid"> Unique Participant identifier that subscribes to this Track. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribedTrack </returns> 
        public static SubscribedTrackResource Fetch(string pathRoomSid, 
                                                    string pathParticipantSid, 
                                                    string pathSid, 
                                                    ITwilioRestClient client = null)
        {
            var options = new FetchSubscribedTrackOptions(pathRoomSid, pathParticipantSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Returns a single Track resource represented by `TrackSid`.  Note: This is one resource with the Video API that
        /// requires a Sid, as Track Name on the subscriber side is not guaranteed to be unique.
        /// </summary>
        /// <param name="pathRoomSid"> Unique Room identifier where this Track is subscribed. </param>
        /// <param name="pathParticipantSid"> Unique Participant identifier that subscribes to this Track. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribedTrack </returns> 
        public static async System.Threading.Tasks.Task<SubscribedTrackResource> FetchAsync(string pathRoomSid, 
                                                                                            string pathParticipantSid, 
                                                                                            string pathSid, 
                                                                                            ITwilioRestClient client = null)
        {
            var options = new FetchSubscribedTrackOptions(pathRoomSid, pathParticipantSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadSubscribedTrackOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Video,
                "/v1/Rooms/" + options.PathRoomSid + "/Participants/" + options.PathParticipantSid + "/SubscribedTracks",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Returns a list of tracks that are subscribed for the participant.
        /// </summary>
        /// <param name="options"> Read SubscribedTrack parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribedTrack </returns> 
        public static ResourceSet<SubscribedTrackResource> Read(ReadSubscribedTrackOptions options, 
                                                                ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<SubscribedTrackResource>.FromJson("subscribed_tracks", response.Content);
            return new ResourceSet<SubscribedTrackResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Returns a list of tracks that are subscribed for the participant.
        /// </summary>
        /// <param name="options"> Read SubscribedTrack parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribedTrack </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<SubscribedTrackResource>> ReadAsync(ReadSubscribedTrackOptions options, 
                                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<SubscribedTrackResource>.FromJson("subscribed_tracks", response.Content);
            return new ResourceSet<SubscribedTrackResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Returns a list of tracks that are subscribed for the participant.
        /// </summary>
        /// <param name="pathRoomSid"> Unique Room identifier where the Tracks are subscribed. </param>
        /// <param name="pathParticipantSid"> Unique Participant identifier that subscribes to this Track. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribedTrack </returns> 
        public static ResourceSet<SubscribedTrackResource> Read(string pathRoomSid, 
                                                                string pathParticipantSid, 
                                                                int? pageSize = null, 
                                                                long? limit = null, 
                                                                ITwilioRestClient client = null)
        {
            var options = new ReadSubscribedTrackOptions(pathRoomSid, pathParticipantSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Returns a list of tracks that are subscribed for the participant.
        /// </summary>
        /// <param name="pathRoomSid"> Unique Room identifier where the Tracks are subscribed. </param>
        /// <param name="pathParticipantSid"> Unique Participant identifier that subscribes to this Track. </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribedTrack </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<SubscribedTrackResource>> ReadAsync(string pathRoomSid, 
                                                                                                        string pathParticipantSid, 
                                                                                                        int? pageSize = null, 
                                                                                                        long? limit = null, 
                                                                                                        ITwilioRestClient client = null)
        {
            var options = new ReadSubscribedTrackOptions(pathRoomSid, pathParticipantSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<SubscribedTrackResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<SubscribedTrackResource>.FromJson("subscribed_tracks", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<SubscribedTrackResource> NextPage(Page<SubscribedTrackResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Video,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<SubscribedTrackResource>.FromJson("subscribed_tracks", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<SubscribedTrackResource> PreviousPage(Page<SubscribedTrackResource> page, 
                                                                 ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Video,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<SubscribedTrackResource>.FromJson("subscribed_tracks", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a SubscribedTrackResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SubscribedTrackResource object represented by the provided JSON </returns> 
        public static SubscribedTrackResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<SubscribedTrackResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// Unique Participant identifier that subscribes to this Track.
        /// </summary>
        [JsonProperty("participant_sid")]
        public string ParticipantSid { get; private set; }
        /// <summary>
        /// Unique Participant identifier that publishes this Track.
        /// </summary>
        [JsonProperty("publisher_sid")]
        public string PublisherSid { get; private set; }
        /// <summary>
        /// Unique Room identifier where this Track is published.
        /// </summary>
        [JsonProperty("room_sid")]
        public string RoomSid { get; private set; }
        /// <summary>
        /// Track name. Limited to 128 characters.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }
        /// <summary>
        /// The date that this resource was created.
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date that this resource was last updated.
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// Specifies whether the Track is enabled or not.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; private set; }
        /// <summary>
        /// Specifies whether Track represents `audio`, `video` or `data`
        /// </summary>
        [JsonProperty("kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public SubscribedTrackResource.KindEnum Kind { get; private set; }
        /// <summary>
        /// The absolute URL for this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private SubscribedTrackResource()
        {

        }
    }

}