// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Profile for diagnostics on the container service VMs. </summary>
    public partial class ContainerServiceVMDiagnostics
    {
        /// <summary> Initializes a new instance of ContainerServiceVMDiagnostics. </summary>
        /// <param name="enabled"> Whether the VM diagnostic agent is provisioned on the VM. </param>
        public ContainerServiceVMDiagnostics(bool enabled)
        {
            Enabled = enabled;
        }

        /// <summary> Initializes a new instance of ContainerServiceVMDiagnostics. </summary>
        /// <param name="enabled"> Whether the VM diagnostic agent is provisioned on the VM. </param>
        /// <param name="storageUri"> The URI of the storage account where diagnostics are stored. </param>
        internal ContainerServiceVMDiagnostics(bool enabled, string storageUri)
        {
            Enabled = enabled;
            StorageUri = storageUri;
        }

        /// <summary> Whether the VM diagnostic agent is provisioned on the VM. </summary>
        public bool Enabled { get; set; }
        /// <summary> The URI of the storage account where diagnostics are stored. </summary>
        public string StorageUri { get; }
    }
}