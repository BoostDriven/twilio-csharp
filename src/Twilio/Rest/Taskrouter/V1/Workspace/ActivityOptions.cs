/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Taskrouter.V1.Workspace
{

    /// <summary>
    /// FetchActivityOptions
    /// </summary>
    public class FetchActivityOptions : IOptions<ActivityResource>
    {
        /// <summary>
        /// The SID of the Workspace with the Activity resources to fetch
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The SID of the resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchActivityOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Activity resources to fetch </param>
        /// <param name="pathSid"> The SID of the resource to fetch </param>
        public FetchActivityOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathSid = pathSid;
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
    /// UpdateActivityOptions
    /// </summary>
    public class UpdateActivityOptions : IOptions<ActivityResource>
    {
        /// <summary>
        /// The SID of the Workspace with the Activity resources to update
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The SID of the Activity resource to update
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A string to describe the Activity resource
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Construct a new UpdateActivityOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Activity resources to update </param>
        /// <param name="pathSid"> The SID of the Activity resource to update </param>
        public UpdateActivityOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteActivityOptions
    /// </summary>
    public class DeleteActivityOptions : IOptions<ActivityResource>
    {
        /// <summary>
        /// The SID of the Workspace with the Activity resources to delete
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The SID of the Activity resource to delete
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteActivityOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Activity resources to delete </param>
        /// <param name="pathSid"> The SID of the Activity resource to delete </param>
        public DeleteActivityOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathSid = pathSid;
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
    /// ReadActivityOptions
    /// </summary>
    public class ReadActivityOptions : ReadOptions<ActivityResource>
    {
        /// <summary>
        /// The SID of the Workspace with the Activity resources to read
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The friendly_name of the Activity resources to read
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// Whether to return activities that are available or unavailable
        /// </summary>
        public string Available { get; set; }

        /// <summary>
        /// Construct a new ReadActivityOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Activity resources to read </param>
        public ReadActivityOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (Available != null)
            {
                p.Add(new KeyValuePair<string, string>("Available", Available));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// CreateActivityOptions
    /// </summary>
    public class CreateActivityOptions : IOptions<ActivityResource>
    {
        /// <summary>
        /// The SID of the Workspace that the new Activity belongs to
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// A string to describe the Activity resource
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// Whether the Worker should be eligible to receive a Task when it occupies the Activity
        /// </summary>
        public bool? Available { get; set; }

        /// <summary>
        /// Construct a new CreateActivityOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace that the new Activity belongs to </param>
        /// <param name="friendlyName"> A string to describe the Activity resource </param>
        public CreateActivityOptions(string pathWorkspaceSid, string friendlyName)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            FriendlyName = friendlyName;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (Available != null)
            {
                p.Add(new KeyValuePair<string, string>("Available", Available.Value.ToString().ToLower()));
            }

            return p;
        }
    }

}