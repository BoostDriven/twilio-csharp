/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
/// 
/// SubscribeRulesResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Video.V1.Room.Participant 
{

    public class SubscribeRulesResource : Resource 
    {
        private static Request BuildFetchRequest(FetchSubscribeRulesOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Video,
                "/v1/Rooms/" + options.PathRoomSid + "/Participants/" + options.PathParticipantSid + "/SubscribeRules",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Returns a list of Subscribe Rules for the Participant.
        /// </summary>
        /// <param name="options"> Fetch SubscribeRules parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribeRules </returns> 
        public static SubscribeRulesResource Fetch(FetchSubscribeRulesOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Returns a list of Subscribe Rules for the Participant.
        /// </summary>
        /// <param name="options"> Fetch SubscribeRules parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribeRules </returns> 
        public static async System.Threading.Tasks.Task<SubscribeRulesResource> FetchAsync(FetchSubscribeRulesOptions options, 
                                                                                           ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Returns a list of Subscribe Rules for the Participant.
        /// </summary>
        /// <param name="pathRoomSid"> Unique Room identifier where the Subscribe Rules apply </param>
        /// <param name="pathParticipantSid"> Unique Participant identifier to apply Subscribe Rules. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribeRules </returns> 
        public static SubscribeRulesResource Fetch(string pathRoomSid, 
                                                   string pathParticipantSid, 
                                                   ITwilioRestClient client = null)
        {
            var options = new FetchSubscribeRulesOptions(pathRoomSid, pathParticipantSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Returns a list of Subscribe Rules for the Participant.
        /// </summary>
        /// <param name="pathRoomSid"> Unique Room identifier where the Subscribe Rules apply </param>
        /// <param name="pathParticipantSid"> Unique Participant identifier to apply Subscribe Rules. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribeRules </returns> 
        public static async System.Threading.Tasks.Task<SubscribeRulesResource> FetchAsync(string pathRoomSid, 
                                                                                           string pathParticipantSid, 
                                                                                           ITwilioRestClient client = null)
        {
            var options = new FetchSubscribeRulesOptions(pathRoomSid, pathParticipantSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateSubscribeRulesOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Video,
                "/v1/Rooms/" + options.PathRoomSid + "/Participants/" + options.PathParticipantSid + "/SubscribeRules",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Update the Subscribe Rules for the Participant
        /// </summary>
        /// <param name="options"> Update SubscribeRules parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribeRules </returns> 
        public static SubscribeRulesResource Update(UpdateSubscribeRulesOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Update the Subscribe Rules for the Participant
        /// </summary>
        /// <param name="options"> Update SubscribeRules parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribeRules </returns> 
        public static async System.Threading.Tasks.Task<SubscribeRulesResource> UpdateAsync(UpdateSubscribeRulesOptions options, 
                                                                                            ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Update the Subscribe Rules for the Participant
        /// </summary>
        /// <param name="pathRoomSid"> Unique Room identifier where the Subscribe Rules apply </param>
        /// <param name="pathParticipantSid"> Unique Participant identifier to apply Subscribe Rules. </param>
        /// <param name="rules"> A JSON-encoded array of Subscribe Rules. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SubscribeRules </returns> 
        public static SubscribeRulesResource Update(string pathRoomSid, 
                                                    string pathParticipantSid, 
                                                    object rules = null, 
                                                    ITwilioRestClient client = null)
        {
            var options = new UpdateSubscribeRulesOptions(pathRoomSid, pathParticipantSid){Rules = rules};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Update the Subscribe Rules for the Participant
        /// </summary>
        /// <param name="pathRoomSid"> Unique Room identifier where the Subscribe Rules apply </param>
        /// <param name="pathParticipantSid"> Unique Participant identifier to apply Subscribe Rules. </param>
        /// <param name="rules"> A JSON-encoded array of Subscribe Rules. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SubscribeRules </returns> 
        public static async System.Threading.Tasks.Task<SubscribeRulesResource> UpdateAsync(string pathRoomSid, 
                                                                                            string pathParticipantSid, 
                                                                                            object rules = null, 
                                                                                            ITwilioRestClient client = null)
        {
            var options = new UpdateSubscribeRulesOptions(pathRoomSid, pathParticipantSid){Rules = rules};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a SubscribeRulesResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SubscribeRulesResource object represented by the provided JSON </returns> 
        public static SubscribeRulesResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<SubscribeRulesResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique Participant identifier for the Subscribe Rules.
        /// </summary>
        [JsonProperty("participant_sid")]
        public string ParticipantSid { get; private set; }
        /// <summary>
        /// The unique Room identifier for the Subscribe Rules
        /// </summary>
        [JsonProperty("room_sid")]
        public string RoomSid { get; private set; }
        /// <summary>
        /// A collection of Subscribe Rules to include or exclude matching Tracks.
        /// </summary>
        [JsonProperty("rules")]
        public List<object> Rules { get; private set; }
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

        private SubscribeRulesResource()
        {

        }
    }

}