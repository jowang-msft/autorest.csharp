// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using dpg_update1_LowLevel;

namespace dpg_update1_LowLevel.Tests
{
    public partial class ParamsClientTests : dpg_update1_LowLevelTestBase
    {
        public ParamsClientTests(bool isAsync) : base(isAsync)
        {
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task HeadNoParams_ShortVersion()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParamsClient client = CreateParamsClient(endpoint, credential);

            Response response = await client.HeadNoParamsAsync(null, null);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task HeadNoParams_AllParameters()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParamsClient client = CreateParamsClient(endpoint, credential);

            Response response = await client.HeadNoParamsAsync("<newParameter>", null);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task GetRequired_ShortVersion()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParamsClient client = CreateParamsClient(endpoint, credential);

            Response response = await client.GetRequiredAsync("<parameter>", null, null);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task GetRequired_AllParameters()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParamsClient client = CreateParamsClient(endpoint, credential);

            Response response = await client.GetRequiredAsync("<parameter>", "<newParameter>", null);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task PutRequiredOptional_ShortVersion()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParamsClient client = CreateParamsClient(endpoint, credential);

            Response response = await client.PutRequiredOptionalAsync("<requiredParam>", null, null, null);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task PutRequiredOptional_AllParameters()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParamsClient client = CreateParamsClient(endpoint, credential);

            Response response = await client.PutRequiredOptionalAsync("<requiredParam>", "<optionalParam>", "<newParameter>", null);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task PostParameters_ShortVersion()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParamsClient client = CreateParamsClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                url = "<url>",
            });
            Response response = await client.PostParametersAsync(content, new ContentType("application/json"));
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task PostParameters_AllParameters()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParamsClient client = CreateParamsClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                url = "<url>",
            });
            Response response = await client.PostParametersAsync(content, new ContentType("application/json"));
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task DeleteParameters_ShortVersion()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParamsClient client = CreateParamsClient(endpoint, credential);

            Response response = await client.DeleteParametersAsync();
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task DeleteParameters_AllParameters()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParamsClient client = CreateParamsClient(endpoint, credential);

            Response response = await client.DeleteParametersAsync();
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task GetOptional_ShortVersion()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParamsClient client = CreateParamsClient(endpoint, credential);

            Response response = await client.GetOptionalAsync(null, null, null);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task GetOptional_AllParameters()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParamsClient client = CreateParamsClient(endpoint, credential);

            Response response = await client.GetOptionalAsync("<optionalParam>", "<newParameter>", null);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task GetNewOperation_ShortVersion()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParamsClient client = CreateParamsClient(endpoint, credential);

            Response response = await client.GetNewOperationAsync(null);
        }

        [Test]
        [Ignore("Please remove the Ignore attribute to let the test method run")]
        public async Task GetNewOperation_AllParameters()
        {
            Uri endpoint = null;
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ParamsClient client = CreateParamsClient(endpoint, credential);

            Response response = await client.GetNewOperationAsync(null);
        }
    }
}