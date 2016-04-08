// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RemoteApp
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// CollectionOperations operations.
    /// </summary>
    public partial interface ICollectionOperations
    {
        /// <summary>
        /// Gets the list of collections details in the resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CollectionListResult>> ListInResourceGroupWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of collections details in the subscription.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CollectionListResult>> ListInSubscriptionWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the collection details.
        /// </summary>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Collection>> GetWithHttpMessagesAsync(string collectionName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update a collection.
        /// </summary>
        /// <param name='details'>
        /// The details of the created or updated collection
        /// </param>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CollectionCreationDetailsWrapper>> CreateOrUpdateWithHttpMessagesAsync(CollectionCreationDetailsWrapper details, string collectionName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete the collection
        /// </summary>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string collectionName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete the collection
        /// </summary>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string collectionName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of published applications in this collection.
        /// </summary>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<PublishedApplicationDetailsListResult>> ListPublishedAppsWithHttpMessagesAsync(string collectionName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the specified published application in this collection.
        /// </summary>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='alias'>
        /// The alias for the application.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<PublishedApplicationDetails>> GetPublishedAppWithHttpMessagesAsync(string collectionName, string alias, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Publishes a new application or updates a previously published
        /// application.
        /// </summary>
        /// <param name='applicationDetails'>
        /// Details of the applicaton to publish or modify
        /// </param>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='alias'>
        /// The alias for the application.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<PublishingOperationResult>> PublishOrUpdateApplicationWithHttpMessagesAsync(ApplicationDetails applicationDetails, string collectionName, string alias, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Unpublishes published application matching the application alias
        /// (short unique name) from the collection.
        /// </summary>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='alias'>
        /// The alias for the application.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<PublishingOperationResult>> UnpublishWithHttpMessagesAsync(string collectionName, string alias, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of sessions on the current collection
        /// </summary>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<SessionList>> ListSessionsWithHttpMessagesAsync(string collectionName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the specified user's session on the current collection
        /// </summary>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='userUpn'>
        /// The UPN of the user
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<Session>> GetSessionWithHttpMessagesAsync(string collectionName, string userUpn, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Disconnects the specified user
        /// </summary>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='userUpn'>
        /// The UPN of the user
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> SessionDisconnectWithHttpMessagesAsync(string collectionName, string userUpn, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Disconnects the specified user
        /// </summary>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='userUpn'>
        /// The UPN of the user
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginSessionDisconnectWithHttpMessagesAsync(string collectionName, string userUpn, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Logs off the specified user
        /// </summary>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='userUpn'>
        /// The UPN of the user
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> SessionLogOffWithHttpMessagesAsync(string collectionName, string userUpn, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Logs off the specified user
        /// </summary>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='userUpn'>
        /// The UPN of the user
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginSessionLogOffWithHttpMessagesAsync(string collectionName, string userUpn, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sends a message to the specified user
        /// </summary>
        /// <param name='messageDetails'>
        /// Session message details
        /// </param>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='userUpn'>
        /// The UPN of the user
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> SessionSendMessageWithHttpMessagesAsync(SessionSendMessageCommandParameter messageDetails, string collectionName, string userUpn, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Sends a message to the specified user
        /// </summary>
        /// <param name='messageDetails'>
        /// Session message details
        /// </param>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='userUpn'>
        /// The UPN of the user
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginSessionSendMessageWithHttpMessagesAsync(SessionSendMessageCommandParameter messageDetails, string collectionName, string userUpn, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of applications available in this collection.
        /// </summary>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<StartMenuApplicationListResult>> ListStartMenuAppsWithHttpMessagesAsync(string collectionName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the specified Start Menu application available in this
        /// collection.
        /// </summary>
        /// <param name='applicationId'>
        /// The identifier of the application.
        /// </param>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<StartMenuApplication>> GetStartMenuAppWithHttpMessagesAsync(string applicationId, string collectionName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generates a CSV file of collection usage details and returns the
        /// URI
        /// </summary>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='date'>
        /// The year and month to get billing for
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<UsageDetailsInfo>> GetUsageDetailsWithHttpMessagesAsync(string collectionName, string resourceGroupName, BillingDate date, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Generates a CSV file of collection usage details and returns the
        /// URI
        /// </summary>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='date'>
        /// The year and month to get billing for
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<UsageDetailsInfo>> BeginGetUsageDetailsWithHttpMessagesAsync(string collectionName, string resourceGroupName, BillingDate date, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a summary of usage data for all users in the collection.
        /// </summary>
        /// <param name='usageMonth'>
        /// The requested month for collection usage information
        /// </param>
        /// <param name='usageYear'>
        /// The requested year for collection usage information
        /// </param>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CollectionUsageSummaryList>> GetUsageSummaryListWithHttpMessagesAsync(string usageMonth, string usageYear, string collectionName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a summary of collection usage data for the specified user.
        /// </summary>
        /// <param name='usageMonth'>
        /// The requested month for collection usage information
        /// </param>
        /// <param name='usageYear'>
        /// The requested year for collection usage information
        /// </param>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='userUpn'>
        /// The UPN of the user
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CollectionUsageSummary>> GetUsageSummaryWithHttpMessagesAsync(string usageMonth, string usageYear, string collectionName, string userUpn, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of collection metric values for specified time
        /// window.
        /// </summary>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='startTimeUtc'>
        /// UTC start time for the time window formatted as 'yyyyMMdd'
        /// </param>
        /// <param name='endTimeUtc'>
        /// UTC end time for the time window formatted as 'yyyyMMdd'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<CollectionMetricsDetailsWrapper>> GetMetricsWithHttpMessagesAsync(string collectionName, string resourceGroupName, string startTimeUtc = default(string), string endTimeUtc = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of all RemoteApp users associated with the given
        /// collection.
        /// </summary>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<SecurityPrincipalList>> GetUsersWithHttpMessagesAsync(string collectionName, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a RemoteApp user by their UPN.
        /// </summary>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='userUpn'>
        /// The UPN of the user
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<SecurityPrincipalInfo>> GetUserWithHttpMessagesAsync(string collectionName, string userUpn, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Adds a user to the given collection.
        /// </summary>
        /// <param name='securityPrincipal'>
        /// A RemoteApp user to add.
        /// </param>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='userUpn'>
        /// The UPN of the user
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<SecurityPrincipalOperationErrorDetails>> AddUserWithHttpMessagesAsync(SecurityPrincipal securityPrincipal, string collectionName, string userUpn, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a user from the given collection.
        /// </summary>
        /// <param name='securityPrincipal'>
        /// The RemoteApp user to remove.
        /// </param>
        /// <param name='collectionName'>
        /// The collection name.
        /// </param>
        /// <param name='userUpn'>
        /// The UPN of the user
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<SecurityPrincipalOperationErrorDetails>> DeleteUserWithHttpMessagesAsync(SecurityPrincipal securityPrincipal, string collectionName, string userUpn, string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}