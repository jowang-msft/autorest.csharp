// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace ClientAndOperationGroup.Samples
{
    internal class Samples_Gamma
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Four()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();

            Response response = client.Four(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Four_AllParameters()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();

            Response response = client.Four(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Four_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();

            Response response = await client.FourAsync(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Four_AllParameters_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();

            Response response = await client.FourAsync(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Five()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();

            Response response = client.Five(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Five_AllParameters()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();

            Response response = client.Five(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Five_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();

            Response response = await client.FiveAsync(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Five_AllParameters_Async()
        {
            var endpoint = new Uri("<https://my-service.azure.com>");
            var client = new ClientAndOperationGroupClient(endpoint).GetGammaClient();

            Response response = await client.FiveAsync(new RequestContext());

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }
    }
}
