using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Notify.V1.Service.User 
{

    /// <summary>
    /// CreateSegmentMembershipOptions
    /// </summary>
    public class CreateSegmentMembershipOptions : IOptions<SegmentMembershipResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The identity
        /// </summary>
        public string PathIdentity { get; }
        /// <summary>
        /// The segment
        /// </summary>
        public string Segment { get; }

        /// <summary>
        /// Construct a new CreateSegmentMembershipOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathIdentity"> The identity </param>
        /// <param name="segment"> The segment </param>
        public CreateSegmentMembershipOptions(string pathServiceSid, string pathIdentity, string segment)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
            Segment = segment;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Segment != null)
            {
                p.Add(new KeyValuePair<string, string>("Segment", Segment));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteSegmentMembershipOptions
    /// </summary>
    public class DeleteSegmentMembershipOptions : IOptions<SegmentMembershipResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The identity
        /// </summary>
        public string PathIdentity { get; }
        /// <summary>
        /// The segment
        /// </summary>
        public string PathSegment { get; }

        /// <summary>
        /// Construct a new DeleteSegmentMembershipOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathIdentity"> The identity </param>
        /// <param name="pathSegment"> The segment </param>
        public DeleteSegmentMembershipOptions(string pathServiceSid, string pathIdentity, string pathSegment)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
            PathSegment = pathSegment;
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
    /// FetchSegmentMembershipOptions
    /// </summary>
    public class FetchSegmentMembershipOptions : IOptions<SegmentMembershipResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The identity
        /// </summary>
        public string PathIdentity { get; }
        /// <summary>
        /// The segment
        /// </summary>
        public string PathSegment { get; }

        /// <summary>
        /// Construct a new FetchSegmentMembershipOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathIdentity"> The identity </param>
        /// <param name="pathSegment"> The segment </param>
        public FetchSegmentMembershipOptions(string pathServiceSid, string pathIdentity, string pathSegment)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
            PathSegment = pathSegment;
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

}