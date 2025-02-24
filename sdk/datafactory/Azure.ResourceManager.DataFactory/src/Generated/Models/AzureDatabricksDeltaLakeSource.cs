// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A copy activity Azure Databricks Delta Lake source. </summary>
    public partial class AzureDatabricksDeltaLakeSource : CopyActivitySource
    {
        /// <summary> Initializes a new instance of AzureDatabricksDeltaLakeSource. </summary>
        public AzureDatabricksDeltaLakeSource()
        {
            CopySourceType = "AzureDatabricksDeltaLakeSource";
        }

        /// <summary> Initializes a new instance of AzureDatabricksDeltaLakeSource. </summary>
        /// <param name="copySourceType"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="query"> Azure Databricks Delta Lake Sql query. Type: string (or Expression with resultType string). </param>
        /// <param name="exportSettings"> Azure Databricks Delta Lake export settings. </param>
        internal AzureDatabricksDeltaLakeSource(string copySourceType, BinaryData sourceRetryCount, BinaryData sourceRetryWait, BinaryData maxConcurrentConnections, BinaryData disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties, BinaryData query, AzureDatabricksDeltaLakeExportCommand exportSettings) : base(copySourceType, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            Query = query;
            ExportSettings = exportSettings;
            CopySourceType = copySourceType ?? "AzureDatabricksDeltaLakeSource";
        }

        /// <summary> Azure Databricks Delta Lake Sql query. Type: string (or Expression with resultType string). </summary>
        public BinaryData Query { get; set; }
        /// <summary> Azure Databricks Delta Lake export settings. </summary>
        public AzureDatabricksDeltaLakeExportCommand ExportSettings { get; set; }
    }
}
