// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using _Type._Array;

namespace _Type._Array.Samples
{
    public partial class Samples_StringValue
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetStringValue_ShortVersion()
        {
            StringValue client = new ArrayClient().GetStringValueClient(apiVersion: "1.0.0");

            Response response = client.GetStringValue(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetStringValue_ShortVersion_Async()
        {
            StringValue client = new ArrayClient().GetStringValueClient(apiVersion: "1.0.0");

            Response response = await client.GetStringValueAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetStringValue_ShortVersion_Convenience()
        {
            StringValue client = new ArrayClient().GetStringValueClient(apiVersion: "1.0.0");

            Response<IReadOnlyList<string>> response = client.GetStringValue();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetStringValue_ShortVersion_Convenience_Async()
        {
            StringValue client = new ArrayClient().GetStringValueClient(apiVersion: "1.0.0");

            Response<IReadOnlyList<string>> response = await client.GetStringValueAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetStringValue_AllParameters()
        {
            StringValue client = new ArrayClient().GetStringValueClient(apiVersion: "1.0.0");

            Response response = client.GetStringValue(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetStringValue_AllParameters_Async()
        {
            StringValue client = new ArrayClient().GetStringValueClient(apiVersion: "1.0.0");

            Response response = await client.GetStringValueAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_GetStringValue_AllParameters_Convenience()
        {
            StringValue client = new ArrayClient().GetStringValueClient(apiVersion: "1.0.0");

            Response<IReadOnlyList<string>> response = client.GetStringValue();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_GetStringValue_AllParameters_Convenience_Async()
        {
            StringValue client = new ArrayClient().GetStringValueClient(apiVersion: "1.0.0");

            Response<IReadOnlyList<string>> response = await client.GetStringValueAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_ShortVersion()
        {
            StringValue client = new ArrayClient().GetStringValueClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object[]
            {
"<body>"
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_ShortVersion_Async()
        {
            StringValue client = new ArrayClient().GetStringValueClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object[]
            {
"<body>"
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_ShortVersion_Convenience()
        {
            StringValue client = new ArrayClient().GetStringValueClient(apiVersion: "1.0.0");

            Response response = client.Put(new string[] { "<body>" });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_ShortVersion_Convenience_Async()
        {
            StringValue client = new ArrayClient().GetStringValueClient(apiVersion: "1.0.0");

            Response response = await client.PutAsync(new string[] { "<body>" });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_AllParameters()
        {
            StringValue client = new ArrayClient().GetStringValueClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object[]
            {
"<body>"
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_AllParameters_Async()
        {
            StringValue client = new ArrayClient().GetStringValueClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object[]
            {
"<body>"
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Put_AllParameters_Convenience()
        {
            StringValue client = new ArrayClient().GetStringValueClient(apiVersion: "1.0.0");

            Response response = client.Put(new string[] { "<body>" });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Put_AllParameters_Convenience_Async()
        {
            StringValue client = new ArrayClient().GetStringValueClient(apiVersion: "1.0.0");

            Response response = await client.PutAsync(new string[] { "<body>" });
        }
    }
}
