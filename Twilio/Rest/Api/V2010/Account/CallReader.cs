using Twilio.Base;
using Twilio.Clients;
using Twilio.Exceptions;
using Twilio.Http;

#if NET40
using System.Threading.Tasks;
#endif

namespace Twilio.Rest.Api.V2010.Account {

    public class CallReader : Reader<CallResource> {
        private string accountSid;
        private Twilio.Types.PhoneNumber to;
        private Twilio.Types.PhoneNumber from;
        private string parentCallSid;
        private CallResource.Status status;
        private string startTime;
        private string endTime;
    
        /// <summary>
        /// Construct a new CallReader.
        /// </summary>
        public CallReader() {
        }
    
        /// <summary>
        /// Construct a new CallReader
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        public CallReader(string accountSid) {
            this.accountSid = accountSid;
        }
    
        /// <summary>
        /// Only show calls to this phone number or Client identifier
        /// </summary>
        ///
        /// <param name="to"> Phone number or Client identifier to filter `to` on </param>
        /// <returns> this </returns> 
        public CallReader ByTo(Twilio.Types.PhoneNumber to) {
            this.to = to;
            return this;
        }
    
        /// <summary>
        /// Only show calls from this phone number or Client identifier
        /// </summary>
        ///
        /// <param name="from"> Phone number or Client identifier to filter `from` on </param>
        /// <returns> this </returns> 
        public CallReader ByFrom(Twilio.Types.PhoneNumber from) {
            this.from = from;
            return this;
        }
    
        /// <summary>
        /// Only show calls spawned by the call with this Sid
        /// </summary>
        ///
        /// <param name="parentCallSid"> Parent Call Sid to filter on </param>
        /// <returns> this </returns> 
        public CallReader ByParentCallSid(string parentCallSid) {
            this.parentCallSid = parentCallSid;
            return this;
        }
    
        /// <summary>
        /// Only show calls currently in this status
        /// </summary>
        ///
        /// <param name="status"> Status to filter on </param>
        /// <returns> this </returns> 
        public CallReader ByStatus(CallResource.Status status) {
            this.status = status;
            return this;
        }
    
        /// <summary>
        /// Only show calls that started on this date
        /// </summary>
        ///
        /// <param name="startTime"> StartTime to filter on </param>
        /// <returns> this </returns> 
        public CallReader ByStartTime(string startTime) {
            this.startTime = startTime;
            return this;
        }
    
        /// <summary>
        /// Only show call that ended on this date
        /// </summary>
        ///
        /// <param name="endTime"> EndTime to filter on </param>
        /// <returns> this </returns> 
        public CallReader ByEndTime(string endTime) {
            this.endTime = endTime;
            return this;
        }
    
        #if NET40
        /// <summary>
        /// Make the request to the Twilio API to perform the read
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> CallResource ResourceSet </returns> 
        public override Task<ResourceSet<CallResource>> ReadAsync(ITwilioRestClient client) {
            var request = new Request(
                HttpMethod.GET,
                Domains.API,
                "/2010-04-01/Accounts/" + (this.accountSid != null ? this.accountSid : client.GetAccountSid()) + "/Calls.json"
            );
            AddQueryParams(request);
            
            var page = PageForRequest(client, request);
            
            return System.Threading.Tasks.Task.FromResult(new ResourceSet<CallResource>(this, client, page));
        }
        #endif
    
        /// <summary>
        /// Make the request to the Twilio API to perform the read
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> CallResource ResourceSet </returns> 
        public override ResourceSet<CallResource> Read(ITwilioRestClient client) {
            var request = new Request(
                HttpMethod.GET,
                Domains.API,
                "/2010-04-01/Accounts/" + (this.accountSid != null ? this.accountSid : client.GetAccountSid()) + "/Calls.json"
            );
            
            AddQueryParams(request);
            var page = PageForRequest(client, request);
            
            return new ResourceSet<CallResource>(this, client, page);
        }
    
        /// <summary>
        /// Retrieve the next page from the Twilio API
        /// </summary>
        ///
        /// <param name="nextPageUri"> URI from which to retrieve the next page </param>
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> Next Page </returns> 
        public override Page<CallResource> NextPage(Page<CallResource> page, ITwilioRestClient client) {
            var request = new Request(
                HttpMethod.GET,
                page.GetNextPageUrl(
                    Domains.API
                )
            );
            
            return PageForRequest(client, request);
        }
    
        /// <summary>
        /// Generate a Page of CallResource Resources for a given request
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <param name="request"> Request to generate a page for </param>
        /// <returns> Page for the Request </returns> 
        protected Page<CallResource> PageForRequest(ITwilioRestClient client, Request request) {
            var response = client.Request(request);
            if (response == null)
            {
                throw new ApiConnectionException("CallResource read failed: Unable to connect to server");
            }
            
            if (response.StatusCode < System.Net.HttpStatusCode.OK || response.StatusCode > System.Net.HttpStatusCode.NoContent)
            {
                var restException = RestException.FromJson(response.Content);
                if (restException == null)
                {
                    throw new ApiException("Server Error, no content");
                }
            
                throw new ApiException(
                    restException.Code,
                    (int)response.StatusCode,
                    restException.Message ?? "Unable to read records, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return Page<CallResource>.FromJson("calls", response.Content);
        }
    
        /// <summary>
        /// Add the requested query string arguments to the Request
        /// </summary>
        ///
        /// <param name="request"> Request to add query string arguments to </param>
        private void AddQueryParams(Request request) {
            if (to != null) {
                request.AddQueryParam("To", to.ToString());
            }
            
            if (from != null) {
                request.AddQueryParam("From", from.ToString());
            }
            
            if (parentCallSid != null) {
                request.AddQueryParam("ParentCallSid", parentCallSid);
            }
            
            if (status != null) {
                request.AddQueryParam("Status", status.ToString());
            }
            
            
            
            request.AddQueryParam("PageSize", PageSize.ToString());
        }
    }
}