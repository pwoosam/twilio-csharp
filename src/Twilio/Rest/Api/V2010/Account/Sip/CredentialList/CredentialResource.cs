/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// CredentialResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account.Sip.CredentialList 
{

    public class CredentialResource : Resource 
    {
        private static Request BuildReadRequest(ReadCredentialOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/CredentialLists/" + options.PathCredentialListSid + "/Credentials.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns> 
        public static ResourceSet<CredentialResource> Read(ReadCredentialOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<CredentialResource>.FromJson("credentials", response.Content);
            return new ResourceSet<CredentialResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<CredentialResource>> ReadAsync(ReadCredentialOptions options, 
                                                                                                   ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<CredentialResource>.FromJson("credentials", response.Content);
            return new ResourceSet<CredentialResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathCredentialListSid"> The credential_list_sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns> 
        public static ResourceSet<CredentialResource> Read(string pathCredentialListSid, 
                                                           string pathAccountSid = null, 
                                                           int? pageSize = null, 
                                                           long? limit = null, 
                                                           ITwilioRestClient client = null)
        {
            var options = new ReadCredentialOptions(pathCredentialListSid){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathCredentialListSid"> The credential_list_sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<CredentialResource>> ReadAsync(string pathCredentialListSid, 
                                                                                                   string pathAccountSid = null, 
                                                                                                   int? pageSize = null, 
                                                                                                   long? limit = null, 
                                                                                                   ITwilioRestClient client = null)
        {
            var options = new ReadCredentialOptions(pathCredentialListSid){PathAccountSid = pathAccountSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<CredentialResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<CredentialResource>.FromJson("credentials", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<CredentialResource> NextPage(Page<CredentialResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<CredentialResource>.FromJson("credentials", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<CredentialResource> PreviousPage(Page<CredentialResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<CredentialResource>.FromJson("credentials", response.Content);
        }

        private static Request BuildCreateRequest(CreateCredentialOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/CredentialLists/" + options.PathCredentialListSid + "/Credentials.json",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns> 
        public static CredentialResource Create(CreateCredentialOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns> 
        public static async System.Threading.Tasks.Task<CredentialResource> CreateAsync(CreateCredentialOptions options, 
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathCredentialListSid"> The credential_list_sid </param>
        /// <param name="username"> The username for this credential. </param>
        /// <param name="password"> The password will not be returned in the response. </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns> 
        public static CredentialResource Create(string pathCredentialListSid, 
                                                string username, 
                                                string password, 
                                                string pathAccountSid = null, 
                                                ITwilioRestClient client = null)
        {
            var options = new CreateCredentialOptions(pathCredentialListSid, username, password){PathAccountSid = pathAccountSid};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathCredentialListSid"> The credential_list_sid </param>
        /// <param name="username"> The username for this credential. </param>
        /// <param name="password"> The password will not be returned in the response. </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns> 
        public static async System.Threading.Tasks.Task<CredentialResource> CreateAsync(string pathCredentialListSid, 
                                                                                        string username, 
                                                                                        string password, 
                                                                                        string pathAccountSid = null, 
                                                                                        ITwilioRestClient client = null)
        {
            var options = new CreateCredentialOptions(pathCredentialListSid, username, password){PathAccountSid = pathAccountSid};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildFetchRequest(FetchCredentialOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/CredentialLists/" + options.PathCredentialListSid + "/Credentials/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns> 
        public static CredentialResource Fetch(FetchCredentialOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns> 
        public static async System.Threading.Tasks.Task<CredentialResource> FetchAsync(FetchCredentialOptions options, 
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathCredentialListSid"> The credential_list_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns> 
        public static CredentialResource Fetch(string pathCredentialListSid, 
                                               string pathSid, 
                                               string pathAccountSid = null, 
                                               ITwilioRestClient client = null)
        {
            var options = new FetchCredentialOptions(pathCredentialListSid, pathSid){PathAccountSid = pathAccountSid};
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathCredentialListSid"> The credential_list_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns> 
        public static async System.Threading.Tasks.Task<CredentialResource> FetchAsync(string pathCredentialListSid, 
                                                                                       string pathSid, 
                                                                                       string pathAccountSid = null, 
                                                                                       ITwilioRestClient client = null)
        {
            var options = new FetchCredentialOptions(pathCredentialListSid, pathSid){PathAccountSid = pathAccountSid};
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateCredentialOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/CredentialLists/" + options.PathCredentialListSid + "/Credentials/" + options.PathSid + ".json",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns> 
        public static CredentialResource Update(UpdateCredentialOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns> 
        public static async System.Threading.Tasks.Task<CredentialResource> UpdateAsync(UpdateCredentialOptions options, 
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathCredentialListSid"> The credential_list_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="password"> The password will not be returned in the response. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns> 
        public static CredentialResource Update(string pathCredentialListSid, 
                                                string pathSid, 
                                                string pathAccountSid = null, 
                                                string password = null, 
                                                ITwilioRestClient client = null)
        {
            var options = new UpdateCredentialOptions(pathCredentialListSid, pathSid){PathAccountSid = pathAccountSid, Password = password};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathCredentialListSid"> The credential_list_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="password"> The password will not be returned in the response. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns> 
        public static async System.Threading.Tasks.Task<CredentialResource> UpdateAsync(string pathCredentialListSid, 
                                                                                        string pathSid, 
                                                                                        string pathAccountSid = null, 
                                                                                        string password = null, 
                                                                                        ITwilioRestClient client = null)
        {
            var options = new UpdateCredentialOptions(pathCredentialListSid, pathSid){PathAccountSid = pathAccountSid, Password = password};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteCredentialOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SIP/CredentialLists/" + options.PathCredentialListSid + "/Credentials/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns> 
        public static bool Delete(DeleteCredentialOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Credential parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteCredentialOptions options, 
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathCredentialListSid"> The credential_list_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Credential </returns> 
        public static bool Delete(string pathCredentialListSid, 
                                  string pathSid, 
                                  string pathAccountSid = null, 
                                  ITwilioRestClient client = null)
        {
            var options = new DeleteCredentialOptions(pathCredentialListSid, pathSid){PathAccountSid = pathAccountSid};
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathCredentialListSid"> The credential_list_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="pathAccountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Credential </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathCredentialListSid, 
                                                                          string pathSid, 
                                                                          string pathAccountSid = null, 
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteCredentialOptions(pathCredentialListSid, pathSid){PathAccountSid = pathAccountSid};
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a CredentialResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CredentialResource object represented by the provided JSON </returns> 
        public static CredentialResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<CredentialResource>(json);
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
        /// The unique id of the Account that responsible for this resource.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The credential_list_sid
        /// </summary>
        [JsonProperty("credential_list_sid")]
        public string CredentialListSid { get; private set; }
        /// <summary>
        /// The username for this credential.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; private set; }
        /// <summary>
        /// The date that this resource was created, given as GMT in RFC 2822 format.
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date that this resource was last updated, given as GMT in RFC 2822 format.
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The URI for this resource, relative to https://api.
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }

        private CredentialResource()
        {

        }
    }

}