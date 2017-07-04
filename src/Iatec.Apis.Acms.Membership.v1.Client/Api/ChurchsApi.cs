/* 
 * Acms Api
 *
 * The documentation for the ACMS Api
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Iatec.Apis.Acms.Membership.v1.Client.Client;
using Iatec.Apis.Acms.Membership.v1.Client.Model;

namespace Iatec.Apis.Acms.Membership.v1.Client.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IChurchsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get many churchs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Iatec.Apis.Acms.Membership.v1.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The specific ID of a church (optional)</param>
        /// <param name="abbreviation">Search by this abbreviation (optional)</param>
        /// <param name="lastUpdateDate">Filter by the date of the last update (optional)</param>
        /// <returns>List&lt;ChurchModel&gt;</returns>
        List<ChurchModel> GetMany (Guid? id = null, string abbreviation = null, string lastUpdateDate = null);

        /// <summary>
        /// Get many churchs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Iatec.Apis.Acms.Membership.v1.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The specific ID of a church (optional)</param>
        /// <param name="abbreviation">Search by this abbreviation (optional)</param>
        /// <param name="lastUpdateDate">Filter by the date of the last update (optional)</param>
        /// <returns>ApiResponse of List&lt;ChurchModel&gt;</returns>
        ApiResponse<List<ChurchModel>> GetManyWithHttpInfo (Guid? id = null, string abbreviation = null, string lastUpdateDate = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get many churchs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Iatec.Apis.Acms.Membership.v1.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The specific ID of a church (optional)</param>
        /// <param name="abbreviation">Search by this abbreviation (optional)</param>
        /// <param name="lastUpdateDate">Filter by the date of the last update (optional)</param>
        /// <returns>Task of List&lt;ChurchModel&gt;</returns>
        System.Threading.Tasks.Task<List<ChurchModel>> GetManyAsync (Guid? id = null, string abbreviation = null, string lastUpdateDate = null);

        /// <summary>
        /// Get many churchs
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Iatec.Apis.Acms.Membership.v1.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The specific ID of a church (optional)</param>
        /// <param name="abbreviation">Search by this abbreviation (optional)</param>
        /// <param name="lastUpdateDate">Filter by the date of the last update (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ChurchModel&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ChurchModel>>> GetManyAsyncWithHttpInfo (Guid? id = null, string abbreviation = null, string lastUpdateDate = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ChurchsApi : IChurchsApi
    {
        private Iatec.Apis.Acms.Membership.v1.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChurchsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ChurchsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Iatec.Apis.Acms.Membership.v1.Client.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChurchsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ChurchsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Iatec.Apis.Acms.Membership.v1.Client.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Iatec.Apis.Acms.Membership.v1.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get many churchs 
        /// </summary>
        /// <exception cref="Iatec.Apis.Acms.Membership.v1.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The specific ID of a church (optional)</param>
        /// <param name="abbreviation">Search by this abbreviation (optional)</param>
        /// <param name="lastUpdateDate">Filter by the date of the last update (optional)</param>
        /// <returns>List&lt;ChurchModel&gt;</returns>
        public List<ChurchModel> GetMany (Guid? id = null, string abbreviation = null, string lastUpdateDate = null)
        {
             ApiResponse<List<ChurchModel>> localVarResponse = GetManyWithHttpInfo(id, abbreviation, lastUpdateDate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get many churchs 
        /// </summary>
        /// <exception cref="Iatec.Apis.Acms.Membership.v1.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The specific ID of a church (optional)</param>
        /// <param name="abbreviation">Search by this abbreviation (optional)</param>
        /// <param name="lastUpdateDate">Filter by the date of the last update (optional)</param>
        /// <returns>ApiResponse of List&lt;ChurchModel&gt;</returns>
        public ApiResponse< List<ChurchModel> > GetManyWithHttpInfo (Guid? id = null, string abbreviation = null, string lastUpdateDate = null)
        {

            var localVarPath = "/arms";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (abbreviation != null) localVarQueryParams.Add("abbreviation", Configuration.ApiClient.ParameterToString(abbreviation)); // query parameter
            if (lastUpdateDate != null) localVarQueryParams.Add("lastUpdateDate", Configuration.ApiClient.ParameterToString(lastUpdateDate)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetMany", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ChurchModel>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ChurchModel>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ChurchModel>)));
            
        }

        /// <summary>
        /// Get many churchs 
        /// </summary>
        /// <exception cref="Iatec.Apis.Acms.Membership.v1.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The specific ID of a church (optional)</param>
        /// <param name="abbreviation">Search by this abbreviation (optional)</param>
        /// <param name="lastUpdateDate">Filter by the date of the last update (optional)</param>
        /// <returns>Task of List&lt;ChurchModel&gt;</returns>
        public async System.Threading.Tasks.Task<List<ChurchModel>> GetManyAsync (Guid? id = null, string abbreviation = null, string lastUpdateDate = null)
        {
             ApiResponse<List<ChurchModel>> localVarResponse = await GetManyAsyncWithHttpInfo(id, abbreviation, lastUpdateDate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get many churchs 
        /// </summary>
        /// <exception cref="Iatec.Apis.Acms.Membership.v1.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The specific ID of a church (optional)</param>
        /// <param name="abbreviation">Search by this abbreviation (optional)</param>
        /// <param name="lastUpdateDate">Filter by the date of the last update (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ChurchModel&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ChurchModel>>> GetManyAsyncWithHttpInfo (Guid? id = null, string abbreviation = null, string lastUpdateDate = null)
        {

            var localVarPath = "/arms";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (abbreviation != null) localVarQueryParams.Add("abbreviation", Configuration.ApiClient.ParameterToString(abbreviation)); // query parameter
            if (lastUpdateDate != null) localVarQueryParams.Add("lastUpdateDate", Configuration.ApiClient.ParameterToString(lastUpdateDate)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetMany", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ChurchModel>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<ChurchModel>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ChurchModel>)));
            
        }

    }
}
