﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.DataTransfer.DocumentDb {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ConfigurationResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ConfigurationResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.DataTransfer.DocumentDb.ConfigurationResources", typeof(ConfigurationResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional, default is {0}. Number of documents in one batch.
        /// </summary>
        public static string BulkSink_BatchSizeFormat {
            get {
                return ResourceManager.GetString("BulkSink_BatchSizeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more documents collection names. Use &quot;[a-b]&quot; placeholder to automatically generate collection index, e.g. &quot;Data[0-2]&quot; will result in the following collection names: Data0, Data1, Data2.
        /// </summary>
        public static string BulkSink_Collection {
            get {
                return ResourceManager.GetString("BulkSink_Collection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional, default is {0}. Specifies pricing/performance tier of the collection: {1}.
        /// </summary>
        public static string BulkSink_CollectionTierFormat {
            get {
                return ResourceManager.GetString("BulkSink_CollectionTierFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional, default is {0}. Size (in bytes) of the bulk insertion JSON array.
        /// </summary>
        public static string BulkSink_MaxScriptSizeFormat {
            get {
                return ResourceManager.GetString("BulkSink_MaxScriptSizeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional. Name of the property to use as hash partitioning key. If not provided - records will be randomly distributed across all target collections.
        /// </summary>
        public static string BulkSink_PartitionKey {
            get {
                return ResourceManager.GetString("BulkSink_PartitionKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional, default is {0}. Name of the file containing bulk insert stored procedure.
        /// </summary>
        public static string BulkSink_StoredProcFileFormat {
            get {
                return ResourceManager.GetString("BulkSink_StoredProcFileFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional, default is {0}. Specifies how to connect to DocumentDB account: {1}.
        /// </summary>
        public static string ConnectionModeFormat {
            get {
                return ResourceManager.GetString("ConnectionModeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection string (example: &quot;AccountEndpoint=xyz;AccountKey=xyz;Database=xyz&quot;).
        /// </summary>
        public static string ConnectionString {
            get {
                return ResourceManager.GetString("ConnectionString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name of the documents collection.
        /// </summary>
        public static string ParallelSink_Collection {
            get {
                return ResourceManager.GetString("ParallelSink_Collection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional, default is {0}. Specifies maximum throughput of the collection.
        /// </summary>
        public static string ParallelSink_CollectionThroughputFormat {
            get {
                return ResourceManager.GetString("ParallelSink_CollectionThroughputFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional, default is {0}. Number of parallel document create requests.
        /// </summary>
        public static string ParallelSink_ParallelRequestsFormat {
            get {
                return ResourceManager.GetString("ParallelSink_ParallelRequestsFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional. Path to the property to use as hash partitioning key (example: &quot;/deviceId&quot;).
        /// </summary>
        public static string ParallelSink_PartitionKey {
            get {
                return ResourceManager.GetString("ParallelSink_PartitionKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional, default is {0}. Number of retries on transient failures.
        /// </summary>
        public static string RetriesFormat {
            get {
                return ResourceManager.GetString("RetriesFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional, default is {0}. Retry interval on transient failures.
        /// </summary>
        public static string RetryIntervalFormat {
            get {
                return ResourceManager.GetString("RetryIntervalFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional, default is {0}. Specifies how timestamps should be persisted: {1}.
        /// </summary>
        public static string Sink_DatesFormat {
            get {
                return ResourceManager.GetString("Sink_DatesFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional. Disable automatic generation of document ids.
        /// </summary>
        public static string Sink_DisableIdGeneration {
            get {
                return ResourceManager.GetString("Sink_DisableIdGeneration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional. Name of the source field that should be treated as document ID.
        /// </summary>
        public static string Sink_IdField {
            get {
                return ResourceManager.GetString("Sink_IdField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional. Indexing policy for the collection.
        /// </summary>
        public static string Sink_IndexingPolicy {
            get {
                return ResourceManager.GetString("Sink_IndexingPolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional. Path to the file containing indexing policy for the collection.
        /// </summary>
        public static string Sink_IndexingPolicyFile {
            get {
                return ResourceManager.GetString("Sink_IndexingPolicyFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional. Update existing documents with the same ID.
        /// </summary>
        public static string Sink_UpdateExisting {
            get {
                return ResourceManager.GetString("Sink_UpdateExisting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Regex pattern to match one or more documents collection names.
        /// </summary>
        public static string Source_Collection {
            get {
                return ResourceManager.GetString("Source_Collection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional. Preserve internal DocumentDB fields in the output.
        /// </summary>
        public static string Source_InternalFields {
            get {
                return ResourceManager.GetString("Source_InternalFields", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional. Documents query to execute.
        /// </summary>
        public static string Source_Query {
            get {
                return ResourceManager.GetString("Source_Query", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional. Path to the file containing documents query.
        /// </summary>
        public static string Source_QueryFile {
            get {
                return ResourceManager.GetString("Source_QueryFile", resourceCulture);
            }
        }
    }
}
