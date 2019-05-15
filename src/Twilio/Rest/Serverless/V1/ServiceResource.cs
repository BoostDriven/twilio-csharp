/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
/// 
/// ServiceResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Serverless.V1 
{

    public class ServiceResource : Resource 
    {
        private static Request BuildReadRequest(ReadServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                "/v1/Services",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of all Services.
        /// </summary>
        /// <param name="options"> Read Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ResourceSet<ServiceResource> Read(ReadServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<ServiceResource>.FromJson("services", response.Content);
            return new ResourceSet<ServiceResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Services.
        /// </summary>
        /// <param name="options"> Read Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ServiceResource>> ReadAsync(ReadServiceOptions options, 
                                                                                                ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ServiceResource>.FromJson("services", response.Content);
            return new ResourceSet<ServiceResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of all Services.
        /// </summary>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ResourceSet<ServiceResource> Read(int? pageSize = null, 
                                                        long? limit = null, 
                                                        ITwilioRestClient client = null)
        {
            var options = new ReadServiceOptions(){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Services.
        /// </summary>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ServiceResource>> ReadAsync(int? pageSize = null, 
                                                                                                long? limit = null, 
                                                                                                ITwilioRestClient client = null)
        {
            var options = new ReadServiceOptions(){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<ServiceResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ServiceResource>.FromJson("services", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<ServiceResource> NextPage(Page<ServiceResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Serverless,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<ServiceResource>.FromJson("services", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<ServiceResource> PreviousPage(Page<ServiceResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Serverless,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<ServiceResource>.FromJson("services", response.Content);
        }

        private static Request BuildFetchRequest(FetchServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Serverless,
                "/v1/Services/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a specific Service.
        /// </summary>
        /// <param name="options"> Fetch Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Fetch(FetchServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a specific Service.
        /// </summary>
        /// <param name="options"> Fetch Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> FetchAsync(FetchServiceOptions options, 
                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Retrieve a specific Service.
        /// </summary>
        /// <param name="pathSid"> Serverless Service Sid or unique name. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchServiceOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a specific Service.
        /// </summary>
        /// <param name="pathSid"> Serverless Service Sid or unique name. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> FetchAsync(string pathSid, 
                                                                                    ITwilioRestClient client = null)
        {
            var options = new FetchServiceOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Serverless,
                "/v1/Services",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Create a new Service.
        /// </summary>
        /// <param name="options"> Create Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Create(CreateServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new Service.
        /// </summary>
        /// <param name="options"> Create Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> CreateAsync(CreateServiceOptions options, 
                                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new Service.
        /// </summary>
        /// <param name="uniqueName"> A unique, addressable name of this Service. </param>
        /// <param name="friendlyName"> A human-readable description of this Service. </param>
        /// <param name="includeCredentials"> Whether to inject Account credentials into a Function invocation context. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Create(string uniqueName, 
                                             string friendlyName, 
                                             bool? includeCredentials = null, 
                                             ITwilioRestClient client = null)
        {
            var options = new CreateServiceOptions(uniqueName, friendlyName){IncludeCredentials = includeCredentials};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new Service.
        /// </summary>
        /// <param name="uniqueName"> A unique, addressable name of this Service. </param>
        /// <param name="friendlyName"> A human-readable description of this Service. </param>
        /// <param name="includeCredentials"> Whether to inject Account credentials into a Function invocation context. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> CreateAsync(string uniqueName, 
                                                                                     string friendlyName, 
                                                                                     bool? includeCredentials = null, 
                                                                                     ITwilioRestClient client = null)
        {
            var options = new CreateServiceOptions(uniqueName, friendlyName){IncludeCredentials = includeCredentials};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Serverless,
                "/v1/Services/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Update a specific Service.
        /// </summary>
        /// <param name="options"> Update Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Update(UpdateServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Update a specific Service.
        /// </summary>
        /// <param name="options"> Update Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> UpdateAsync(UpdateServiceOptions options, 
                                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Update a specific Service.
        /// </summary>
        /// <param name="pathSid"> Service Sid. </param>
        /// <param name="includeCredentials"> Whether to inject Account credentials into a Function invocation context. </param>
        /// <param name="friendlyName"> A human-readable description of this Service. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Update(string pathSid, 
                                             bool? includeCredentials = null, 
                                             string friendlyName = null, 
                                             ITwilioRestClient client = null)
        {
            var options = new UpdateServiceOptions(pathSid){IncludeCredentials = includeCredentials, FriendlyName = friendlyName};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Update a specific Service.
        /// </summary>
        /// <param name="pathSid"> Service Sid. </param>
        /// <param name="includeCredentials"> Whether to inject Account credentials into a Function invocation context. </param>
        /// <param name="friendlyName"> A human-readable description of this Service. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> UpdateAsync(string pathSid, 
                                                                                     bool? includeCredentials = null, 
                                                                                     string friendlyName = null, 
                                                                                     ITwilioRestClient client = null)
        {
            var options = new UpdateServiceOptions(pathSid){IncludeCredentials = includeCredentials, FriendlyName = friendlyName};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a ServiceResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ServiceResource object represented by the provided JSON </returns> 
        public static ServiceResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ServiceResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// Service Sid.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// Account Sid.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// A human-readable description of this Service.
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// A unique, URL-friendly name of this Service.
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// Whether to inject Account credentials into a Function invocation context.
        /// </summary>
        [JsonProperty("include_credentials")]
        public bool? IncludeCredentials { get; private set; }
        /// <summary>
        /// The date that this Service was created.
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date that this Service was updated.
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The URL of this Service.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// Nested resource URLs.
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private ServiceResource()
        {

        }
    }

}