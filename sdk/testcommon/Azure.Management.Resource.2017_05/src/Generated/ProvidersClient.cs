// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Resource.Models;

namespace Azure.Management.Resource
{
    /// <summary> The Providers service client. </summary>
    public partial class ProvidersClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ProvidersRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ProvidersClient for mocking. </summary>
        protected ProvidersClient()
        {
        }
        /// <summary> Initializes a new instance of ProvidersClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal ProvidersClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2017-05-10")
        {
            RestClient = new ProvidersRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Unregisters a subscription from a resource provider. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider to unregister. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Provider>> UnregisterAsync(string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProvidersClient.Unregister");
            scope.Start();
            try
            {
                return await RestClient.UnregisterAsync(resourceProviderNamespace, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Unregisters a subscription from a resource provider. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider to unregister. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Provider> Unregister(string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProvidersClient.Unregister");
            scope.Start();
            try
            {
                return RestClient.Unregister(resourceProviderNamespace, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Registers a subscription with a resource provider. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider to register. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Provider>> RegisterAsync(string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProvidersClient.Register");
            scope.Start();
            try
            {
                return await RestClient.RegisterAsync(resourceProviderNamespace, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Registers a subscription with a resource provider. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider to register. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Provider> Register(string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProvidersClient.Register");
            scope.Start();
            try
            {
                return RestClient.Register(resourceProviderNamespace, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified resource provider. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Provider>> GetAsync(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProvidersClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceProviderNamespace, expand, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified resource provider. </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> The $expand query parameter. For example, to include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Provider> Get(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ProvidersClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceProviderNamespace, expand, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all resource providers for a subscription. </summary>
        /// <param name="top"> The number of results to return. If null is passed returns all deployments. </param>
        /// <param name="expand"> The properties to include in the results. For example, use &amp;$expand=metadata in the query string to retrieve resource provider metadata. To include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<Provider> ListAsync(int? top = null, string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Provider>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ProvidersClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(top, expand, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Provider>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ProvidersClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, top, expand, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all resource providers for a subscription. </summary>
        /// <param name="top"> The number of results to return. If null is passed returns all deployments. </param>
        /// <param name="expand"> The properties to include in the results. For example, use &amp;$expand=metadata in the query string to retrieve resource provider metadata. To include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<Provider> List(int? top = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Page<Provider> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ProvidersClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(top, expand, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Provider> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ProvidersClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, top, expand, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
