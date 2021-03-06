/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Taskrouter.V1.Workspace.TaskQueue
{

    /// <summary>
    /// FetchTaskQueueRealTimeStatisticsOptions
    /// </summary>
    public class FetchTaskQueueRealTimeStatisticsOptions : IOptions<TaskQueueRealTimeStatisticsResource>
    {
        /// <summary>
        /// The SID of the Workspace with the TaskQueue to fetch
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The SID of the TaskQueue for which to fetch statistics
        /// </summary>
        public string PathTaskQueueSid { get; }
        /// <summary>
        /// The TaskChannel for which to fetch statistics
        /// </summary>
        public string TaskChannel { get; set; }

        /// <summary>
        /// Construct a new FetchTaskQueueRealTimeStatisticsOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the TaskQueue to fetch </param>
        /// <param name="pathTaskQueueSid"> The SID of the TaskQueue for which to fetch statistics </param>
        public FetchTaskQueueRealTimeStatisticsOptions(string pathWorkspaceSid, string pathTaskQueueSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathTaskQueueSid = pathTaskQueueSid;
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