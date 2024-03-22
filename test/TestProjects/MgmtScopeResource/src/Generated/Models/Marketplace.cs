// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace MgmtScopeResource.Models
{
    /// <summary> A marketplace resource. </summary>
    public partial class Marketplace : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="Marketplace"/>. </summary>
        internal Marketplace()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="Marketplace"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="billingPeriodId"> The id of the billing period resource that the usage belongs to. </param>
        /// <param name="usageStart"> The start of the date time range covered by the usage detail. </param>
        /// <param name="usageEnd"> The end of the date time range covered by the usage detail. </param>
        /// <param name="resourceRate"> The marketplace resource rate. </param>
        /// <param name="offerName"> The type of offer. </param>
        /// <param name="resourceGroup"> The name of resource group. </param>
        /// <param name="additionalInfo"> Additional information. </param>
        /// <param name="orderNumber"> The order number. </param>
        /// <param name="instanceName"> The name of the resource instance that the usage is about. </param>
        /// <param name="instanceId"> The uri of the resource instance that the usage is about. </param>
        /// <param name="currency"> The ISO currency in which the meter is charged, for example, USD. </param>
        /// <param name="consumedQuantity"> The quantity of usage. </param>
        /// <param name="unitOfMeasure"> The unit of measure. </param>
        /// <param name="pretaxCost"> The amount of cost before tax. </param>
        /// <param name="isEstimated"> The estimated usage is subject to change. </param>
        /// <param name="meterId"> The meter id (GUID). </param>
        /// <param name="subscriptionGuid"> Subscription guid. </param>
        /// <param name="subscriptionName"> Subscription name. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="departmentName"> Department name. </param>
        /// <param name="consumedService"> Consumed service name. </param>
        /// <param name="costCenter"> The cost center of this department if it is a department and a costcenter exists. </param>
        /// <param name="additionalProperties"> Additional details of this usage item. By default this is not populated, unless it's specified in $expand. </param>
        /// <param name="publisherName"> The name of publisher. </param>
        /// <param name="planName"> The name of plan. </param>
        /// <param name="isRecurringCharge"> Flag indicating whether this is a recurring charge or not. </param>
        /// <param name="etag"> The etag for the resource. </param>
        /// <param name="tags"> Resource tags. </param>
        internal Marketplace(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string billingPeriodId, DateTimeOffset? usageStart, DateTimeOffset? usageEnd, decimal? resourceRate, string offerName, string resourceGroup, string additionalInfo, string orderNumber, string instanceName, string instanceId, string currency, decimal? consumedQuantity, string unitOfMeasure, decimal? pretaxCost, bool? isEstimated, Guid? meterId, Guid? subscriptionGuid, string subscriptionName, string accountName, string departmentName, string consumedService, string costCenter, string additionalProperties, string publisherName, string planName, bool? isRecurringCharge, string etag, IReadOnlyDictionary<string, string> tags) : base(id, name, resourceType, systemData)
        {
            BillingPeriodId = billingPeriodId;
            UsageStart = usageStart;
            UsageEnd = usageEnd;
            ResourceRate = resourceRate;
            OfferName = offerName;
            ResourceGroup = resourceGroup;
            AdditionalInfo = additionalInfo;
            OrderNumber = orderNumber;
            InstanceName = instanceName;
            InstanceId = instanceId;
            Currency = currency;
            ConsumedQuantity = consumedQuantity;
            UnitOfMeasure = unitOfMeasure;
            PretaxCost = pretaxCost;
            IsEstimated = isEstimated;
            MeterId = meterId;
            SubscriptionGuid = subscriptionGuid;
            SubscriptionName = subscriptionName;
            AccountName = accountName;
            DepartmentName = departmentName;
            ConsumedService = consumedService;
            CostCenter = costCenter;
            AdditionalProperties = additionalProperties;
            PublisherName = publisherName;
            PlanName = planName;
            IsRecurringCharge = isRecurringCharge;
            Etag = etag;
            Tags = tags;
        }

        /// <summary> The id of the billing period resource that the usage belongs to. </summary>
        public string BillingPeriodId { get; }
        /// <summary> The start of the date time range covered by the usage detail. </summary>
        public DateTimeOffset? UsageStart { get; }
        /// <summary> The end of the date time range covered by the usage detail. </summary>
        public DateTimeOffset? UsageEnd { get; }
        /// <summary> The marketplace resource rate. </summary>
        public decimal? ResourceRate { get; }
        /// <summary> The type of offer. </summary>
        public string OfferName { get; }
        /// <summary> The name of resource group. </summary>
        public string ResourceGroup { get; }
        /// <summary> Additional information. </summary>
        public string AdditionalInfo { get; }
        /// <summary> The order number. </summary>
        public string OrderNumber { get; }
        /// <summary> The name of the resource instance that the usage is about. </summary>
        public string InstanceName { get; }
        /// <summary> The uri of the resource instance that the usage is about. </summary>
        public string InstanceId { get; }
        /// <summary> The ISO currency in which the meter is charged, for example, USD. </summary>
        public string Currency { get; }
        /// <summary> The quantity of usage. </summary>
        public decimal? ConsumedQuantity { get; }
        /// <summary> The unit of measure. </summary>
        public string UnitOfMeasure { get; }
        /// <summary> The amount of cost before tax. </summary>
        public decimal? PretaxCost { get; }
        /// <summary> The estimated usage is subject to change. </summary>
        public bool? IsEstimated { get; }
        /// <summary> The meter id (GUID). </summary>
        public Guid? MeterId { get; }
        /// <summary> Subscription guid. </summary>
        public Guid? SubscriptionGuid { get; }
        /// <summary> Subscription name. </summary>
        public string SubscriptionName { get; }
        /// <summary> Account name. </summary>
        public string AccountName { get; }
        /// <summary> Department name. </summary>
        public string DepartmentName { get; }
        /// <summary> Consumed service name. </summary>
        public string ConsumedService { get; }
        /// <summary> The cost center of this department if it is a department and a costcenter exists. </summary>
        public string CostCenter { get; }
        /// <summary> Additional details of this usage item. By default this is not populated, unless it's specified in $expand. </summary>
        public string AdditionalProperties { get; }
        /// <summary> The name of publisher. </summary>
        public string PublisherName { get; }
        /// <summary> The name of plan. </summary>
        public string PlanName { get; }
        /// <summary> Flag indicating whether this is a recurring charge or not. </summary>
        public bool? IsRecurringCharge { get; }
        /// <summary> The etag for the resource. </summary>
        public string Etag { get; }
        /// <summary> Resource tags. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
    }
}