﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.StorageSync.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class StorageSyncResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StorageSyncResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.StorageSync.Properties.StorageSyncResources", typeof(StorageSyncResources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate thumbprints not found. Check if server is registered..
        /// </summary>
        internal static string CertificateThumbprintNotFound {
            get {
                return ResourceManager.GetString("CertificateThumbprintNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No information in the cloud exception..
        /// </summary>
        internal static string CloudNoInformationError {
            get {
                return ResourceManager.GetString("CloudNoInformationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CoSetProxyBlanket failed with HRESULT.
        /// </summary>
        internal static string ComError1 {
            get {
                return ResourceManager.GetString("ComError1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating Role Assignment....
        /// </summary>
        internal static string CreateRoleAssignmentMessage {
            get {
                return ResourceManager.GetString("CreateRoleAssignmentMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating Service Principal....
        /// </summary>
        internal static string CreateServicePrincipalMessage {
            get {
                return ResourceManager.GetString("CreateServicePrincipalMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to COM Exception while loading certificate: HResult: {0} Message: {1}.
        /// </summary>
        internal static string GetSyncServerCertificateErrorMessageFormat {
            get {
                return ResourceManager.GetString("GetSyncServerCertificateErrorMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid argument {0}.
        /// </summary>
        internal static string InvalidArgumentErrorFormat {
            get {
                return ResourceManager.GetString("InvalidArgumentErrorFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invoke change detection for Cloud Endpoint.
        /// </summary>
        internal static string InvokeChangeDetectionActionMessage {
            get {
                return ResourceManager.GetString("InvokeChangeDetectionActionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed mounting network path {0}. Error: {1}.
        /// </summary>
        internal static string InvokeCompatibilityCheckError1Format {
            get {
                return ResourceManager.GetString("InvokeCompatibilityCheckError1Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invoke Storage Sync File Recall.
        /// </summary>
        internal static string InvokeStorageSyncFileRecallActionMessage {
            get {
                return ResourceManager.GetString("InvokeStorageSyncFileRecallActionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We cannot find the Storage Sync agent installed in the system. The given registry AfsAgentInstallerPath cannot be found..
        /// </summary>
        internal static string MissingAfsAgentInstallerPathErrorMessage {
            get {
                return ResourceManager.GetString("MissingAfsAgentInstallerPathErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The given parent resource is not in the required format. Please check the format and try again..
        /// </summary>
        internal static string MissingParentResourceIdErrorMessage {
            get {
                return ResourceManager.GetString("MissingParentResourceIdErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The given resource is not in the required format. Please check the format and try again..
        /// </summary>
        internal static string MissingResourceIdErrorMessage {
            get {
                return ResourceManager.GetString("MissingResourceIdErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot access directory: {0}. Ensure directory exists..
        /// </summary>
        internal static string NamespaceEnumeratorErrorFormat {
            get {
                return ResourceManager.GetString("NamespaceEnumeratorErrorFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create a new Cloud Endpoint.
        /// </summary>
        internal static string NewCloudEndpointActionMessage {
            get {
                return ResourceManager.GetString("NewCloudEndpointActionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The given storage account subscription {0} is in other subscription than the current azure context subscription {1}. We will try to inform Azure File Sync about the storage account subscription..
        /// </summary>
        internal static string NewCloudEndpointCrossSubscriptionWarningFormat {
            get {
                return ResourceManager.GetString("NewCloudEndpointCrossSubscriptionWarningFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The given storage account tenant {0} does not match with current azure tenant. We do not support cloud endpoint creation with storage account pointing to any other tenant than itself. Please try this operation again with correct tenant..
        /// </summary>
        internal static string NewCloudEndpointCrossTenantErrorFormat {
            get {
                return ResourceManager.GetString("NewCloudEndpointCrossTenantErrorFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The given subscription {0} was unable to registered to Azure File Sync..
        /// </summary>
        internal static string NewCloudEndpointUnableToRegisterErrorFormat {
            get {
                return ResourceManager.GetString("NewCloudEndpointUnableToRegisterErrorFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create a new Server Endpoint.
        /// </summary>
        internal static string NewServerEndpointActionMessage {
            get {
                return ResourceManager.GetString("NewServerEndpointActionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create a new Storage Sync Service.
        /// </summary>
        internal static string NewStorageSyncServiceActionMessage {
            get {
                return ResourceManager.GetString("NewStorageSyncServiceActionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create a new Sync Group.
        /// </summary>
        internal static string NewSyncGroupActionMessage {
            get {
                return ResourceManager.GetString("NewSyncGroupActionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create a new Registered Server for Storage Sync Service.
        /// </summary>
        internal static string RegisterServerActionMessage {
            get {
                return ResourceManager.GetString("RegisterServerActionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove a given Cloud Endpoint.
        /// </summary>
        internal static string RemoveCloudEndpointActionMessage {
            get {
                return ResourceManager.GetString("RemoveCloudEndpointActionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Cloud Endpoint &apos;{0}&apos; and all content in it.
        /// </summary>
        internal static string RemoveCloudEndpointPromptFormat {
            get {
                return ResourceManager.GetString("RemoveCloudEndpointPromptFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove a given Server Endpoint.
        /// </summary>
        internal static string RemoveServerEndpointActionMessage {
            get {
                return ResourceManager.GetString("RemoveServerEndpointActionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Server Endpoint &apos;{0}&apos; and all content in it.
        /// </summary>
        internal static string RemoveServerEndpointPromptFormat {
            get {
                return ResourceManager.GetString("RemoveServerEndpointPromptFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove a given Storage Sync Service.
        /// </summary>
        internal static string RemoveStorageSyncServiceActionMessage {
            get {
                return ResourceManager.GetString("RemoveStorageSyncServiceActionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Storage Sync Service &apos;{0}&apos; and all content in it.
        /// </summary>
        internal static string RemoveStorageSyncServicePromptFormat {
            get {
                return ResourceManager.GetString("RemoveStorageSyncServicePromptFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove a given Sync Group.
        /// </summary>
        internal static string RemoveSyncGroupActionMessage {
            get {
                return ResourceManager.GetString("RemoveSyncGroupActionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Sync Group &apos;{0}&apos; and all content in it.
        /// </summary>
        internal static string RemoveSyncGroupPromptFormat {
            get {
                return ResourceManager.GetString("RemoveSyncGroupPromptFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Triggering certificate rollover on service.
        /// </summary>
        internal static string ResetCertificateMessage17 {
            get {
                return ResourceManager.GetString("ResetCertificateMessage17", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate Rollover request completed on the service.
        /// </summary>
        internal static string ResetCertificateMessage18 {
            get {
                return ResourceManager.GetString("ResetCertificateMessage18", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting rollover certificate for ServerId: {0}.
        /// </summary>
        internal static string ResetCertificateMessageFormat1 {
            get {
                return ResourceManager.GetString("ResetCertificateMessageFormat1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting old certificate  with thumbprint: {0}.
        /// </summary>
        internal static string ResetCertificateMessageFormat10 {
            get {
                return ResourceManager.GetString("ResetCertificateMessageFormat10", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully deleted the certificate from the store: {0}.
        /// </summary>
        internal static string ResetCertificateMessageFormat11 {
            get {
                return ResourceManager.GetString("ResetCertificateMessageFormat11", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to COM Exception during deletion of old Primary certificate: HResult:{0} MessageFormat:{1}. Ignoring the error...
        /// </summary>
        internal static string ResetCertificateMessageFormat12 {
            get {
                return ResourceManager.GetString("ResetCertificateMessageFormat12", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Validating Certificate with Thumbprint: {0}.
        /// </summary>
        internal static string ResetCertificateMessageFormat13 {
            get {
                return ResourceManager.GetString("ResetCertificateMessageFormat13", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate is expired. Current Time: {0} Certificate NotAfter: {1}.
        /// </summary>
        internal static string ResetCertificateMessageFormat14 {
            get {
                return ResourceManager.GetString("ResetCertificateMessageFormat14", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Certificate contains Private Key.
        /// </summary>
        internal static string ResetCertificateMessageFormat15 {
            get {
                return ResourceManager.GetString("ResetCertificateMessageFormat15", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully validated certificate with thumbprint: {0}.
        /// </summary>
        internal static string ResetCertificateMessageFormat16 {
            get {
                return ResourceManager.GetString("ResetCertificateMessageFormat16", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Primary Certificate Thumbprint: {0} Secondary Certificate Thumbprint: {1}.
        /// </summary>
        internal static string ResetCertificateMessageFormat2 {
            get {
                return ResourceManager.GetString("ResetCertificateMessageFormat2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Succesfully retrieved secondary certificate with thumbprint: {0} from store with HResult: {1}.
        /// </summary>
        internal static string ResetCertificateMessageFormat3 {
            get {
                return ResourceManager.GetString("ResetCertificateMessageFormat3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to retrieve the secondary certificate from store with HResult: {0}.
        /// </summary>
        internal static string ResetCertificateMessageFormat4 {
            get {
                return ResourceManager.GetString("ResetCertificateMessageFormat4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generating new Secondary Certificate.. Current Thumbprint: {0}.
        /// </summary>
        internal static string ResetCertificateMessageFormat5 {
            get {
                return ResourceManager.GetString("ResetCertificateMessageFormat5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Primary and Secondary certificates are same. Cannot proceed to switch and delete certificate step. Primary Thumbprint: {0}.
        /// </summary>
        internal static string ResetCertificateMessageFormat6 {
            get {
                return ResourceManager.GetString("ResetCertificateMessageFormat6", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Switching primary certificate to secondary and updating monitoring with latest certificate. Primary Certificate: {0} Secondary Certificate: {1}.
        /// </summary>
        internal static string ResetCertificateMessageFormat7 {
            get {
                return ResourceManager.GetString("ResetCertificateMessageFormat7", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to COM Exception while switching certificate: HResult:{0} MessageFormat:{1}.
        /// </summary>
        internal static string ResetCertificateMessageFormat8 {
            get {
                return ResourceManager.GetString("ResetCertificateMessageFormat8", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Successfully switched to secondary certificate. Certificate: {0}.
        /// </summary>
        internal static string ResetCertificateMessageFormat9 {
            get {
                return ResourceManager.GetString("ResetCertificateMessageFormat9", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reset Server Certificate for Storage sync service.
        /// </summary>
        internal static string ResetServerCertificateActionMessage {
            get {
                return ResourceManager.GetString("ResetServerCertificateActionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to generate secondary certificate. HResult: {0}.
        /// </summary>
        internal static string RolloverSecondaryCertificateErrorMessageFormat {
            get {
                return ResourceManager.GetString("RolloverSecondaryCertificateErrorMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating a Server endpoint.
        /// </summary>
        internal static string SetServerEndpointActionMessage {
            get {
                return ResourceManager.GetString("SetServerEndpointActionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating a Storage Sync Service.
        /// </summary>
        internal static string SetStorageSyncServiceActionMessage {
            get {
                return ResourceManager.GetString("SetStorageSyncServiceActionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unregister a given Storage Sync Server.
        /// </summary>
        internal static string UnregisterServerActionMessage {
            get {
                return ResourceManager.GetString("UnregisterServerActionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unregister Storage Sync Server for Storage Sync Service &apos;{0}&apos; and all content in it.
        /// </summary>
        internal static string UnregisterServerPromptFormat {
            get {
                return ResourceManager.GetString("UnregisterServerPromptFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} value {1} is unsupported.
        /// </summary>
        internal static string UnsupportedErrorFormat {
            get {
                return ResourceManager.GetString("UnsupportedErrorFormat", resourceCulture);
            }
        }
    }
}
