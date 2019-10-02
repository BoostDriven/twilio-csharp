/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Video.V1.Room.Participant
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Returns a list of Subscribe Rules for the Participant.
    /// </summary>
    public class FetchSubscribeRulesOptions : IOptions<SubscribeRulesResource>
    {
        /// <summary>
        /// The SID of the Room resource where the subscribe rules to fetch apply
        /// </summary>
        public string PathRoomSid { get; }
        /// <summary>
        /// The SID of the Participant resource with the subscribe rules to fetch
        /// </summary>
        public string PathParticipantSid { get; }

        /// <summary>
        /// Construct a new FetchSubscribeRulesOptions
        /// </summary>
        /// <param name="pathRoomSid"> The SID of the Room resource where the subscribe rules to fetch apply </param>
        /// <param name="pathParticipantSid"> The SID of the Participant resource with the subscribe rules to fetch </param>
        public FetchSubscribeRulesOptions(string pathRoomSid, string pathParticipantSid)
        {
            PathRoomSid = pathRoomSid;
            PathParticipantSid = pathParticipantSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Update the Subscribe Rules for the Participant
    /// </summary>
    public class UpdateSubscribeRulesOptions : IOptions<SubscribeRulesResource>
    {
        /// <summary>
        /// The SID of the Room resource where the subscribe rules to update apply
        /// </summary>
        public string PathRoomSid { get; }
        /// <summary>
        /// The SID of the Participant resource to update the Subscribe Rules
        /// </summary>
        public string PathParticipantSid { get; }
        /// <summary>
        /// A JSON-encoded array of subscribe rules
        /// </summary>
        public object Rules { get; set; }

        /// <summary>
        /// Construct a new UpdateSubscribeRulesOptions
        /// </summary>
        /// <param name="pathRoomSid"> The SID of the Room resource where the subscribe rules to update apply </param>
        /// <param name="pathParticipantSid"> The SID of the Participant resource to update the Subscribe Rules </param>
        public UpdateSubscribeRulesOptions(string pathRoomSid, string pathParticipantSid)
        {
            PathRoomSid = pathRoomSid;
            PathParticipantSid = pathParticipantSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Rules != null)
            {
                p.Add(new KeyValuePair<string, string>("Rules", Serializers.JsonObject(Rules)));
            }

            return p;
        }
    }

}