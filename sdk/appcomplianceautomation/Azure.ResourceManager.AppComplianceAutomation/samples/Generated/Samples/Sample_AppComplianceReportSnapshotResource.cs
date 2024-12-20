// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.AppComplianceAutomation.Samples
{
    public partial class Sample_AppComplianceReportSnapshotResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SnapshotGet()
        {
            // Generated from example definition: specification/appcomplianceautomation/resource-manager/Microsoft.AppComplianceAutomation/stable/2024-06-27/examples/Snapshot_Get.json
            // this example is just showing the usage of "Snapshot_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AppComplianceReportSnapshotResource created on azure
            // for more information of creating AppComplianceReportSnapshotResource, please refer to the document of AppComplianceReportSnapshotResource
            string reportName = "testReportName";
            string snapshotName = "testSnapshot";
            ResourceIdentifier appComplianceReportSnapshotResourceId = AppComplianceReportSnapshotResource.CreateResourceIdentifier(reportName, snapshotName);
            AppComplianceReportSnapshotResource appComplianceReportSnapshot = client.GetAppComplianceReportSnapshotResource(appComplianceReportSnapshotResourceId);

            // invoke the operation
            AppComplianceReportSnapshotResource result = await appComplianceReportSnapshot.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppComplianceReportSnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
