/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Taskrouter.V1.Workspace.Worker
{

    /// <summary>
    /// FetchWorkersRealTimeStatisticsOptions
    /// </summary>
    public class FetchWorkersRealTimeStatisticsOptions : IOptions<WorkersRealTimeStatisticsResource>
    {
        /// <summary>
        /// The SID of the Workspace with the resource to fetch
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// Only calculate real-time statistics on this TaskChannel
        /// </summary>
        public string TaskChannel { get; set; }

        /// <summary>
        /// Construct a new FetchWorkersRealTimeStatisticsOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the resource to fetch </param>
        public FetchWorkersRealTimeStatisticsOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (TaskChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskChannel", TaskChannel));
            }

            return p;
        }
    }

}