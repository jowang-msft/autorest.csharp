// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class Index : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("fields"u8);
            writer.WriteStartArray();
            foreach (var item in Fields)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (!(ScoringProfiles is ChangeTrackingList<ScoringProfile> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("scoringProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in ScoringProfiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (DefaultScoringProfile != null)
            {
                writer.WritePropertyName("defaultScoringProfile"u8);
                writer.WriteStringValue(DefaultScoringProfile);
            }
            if (CorsOptions != null)
            {
                writer.WritePropertyName("corsOptions"u8);
                writer.WriteObjectValue(CorsOptions);
            }
            if (!(Suggesters is ChangeTrackingList<Suggester> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("suggesters"u8);
                writer.WriteStartArray();
                foreach (var item in Suggesters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Analyzers is ChangeTrackingList<Analyzer> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("analyzers"u8);
                writer.WriteStartArray();
                foreach (var item in Analyzers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Tokenizers is ChangeTrackingList<Tokenizer> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("tokenizers"u8);
                writer.WriteStartArray();
                foreach (var item in Tokenizers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(TokenFilters is ChangeTrackingList<TokenFilter> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("tokenFilters"u8);
                writer.WriteStartArray();
                foreach (var item in TokenFilters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(CharFilters is ChangeTrackingList<CharFilter> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("charFilters"u8);
                writer.WriteStartArray();
                foreach (var item in CharFilters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (EncryptionKey != null)
            {
                writer.WritePropertyName("encryptionKey"u8);
                writer.WriteObjectValue(EncryptionKey);
            }
            if (Similarity != null)
            {
                writer.WritePropertyName("similarity"u8);
                writer.WriteObjectValue(Similarity);
            }
            if (ETag != null)
            {
                writer.WritePropertyName("@odata.etag"u8);
                writer.WriteStringValue(ETag);
            }
            writer.WriteEndObject();
        }

        internal static Index DeserializeIndex(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IList<Field> fields = default;
            IList<ScoringProfile> scoringProfiles = default;
            Optional<string> defaultScoringProfile = default;
            Optional<CorsOptions> corsOptions = default;
            IList<Suggester> suggesters = default;
            IList<Analyzer> analyzers = default;
            IList<Tokenizer> tokenizers = default;
            IList<TokenFilter> tokenFilters = default;
            IList<CharFilter> charFilters = default;
            Optional<EncryptionKey> encryptionKey = default;
            Optional<Similarity> similarity = default;
            Optional<string> odataEtag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fields"u8))
                {
                    List<Field> array = new List<Field>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Field.DeserializeField(item));
                    }
                    fields = array;
                    continue;
                }
                if (property.NameEquals("scoringProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ScoringProfile> array = new List<ScoringProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScoringProfile.DeserializeScoringProfile(item));
                    }
                    scoringProfiles = array;
                    continue;
                }
                if (property.NameEquals("defaultScoringProfile"u8))
                {
                    defaultScoringProfile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("corsOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    corsOptions = CorsOptions.DeserializeCorsOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("suggesters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Suggester> array = new List<Suggester>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Suggester.DeserializeSuggester(item));
                    }
                    suggesters = array;
                    continue;
                }
                if (property.NameEquals("analyzers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Analyzer> array = new List<Analyzer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Analyzer.DeserializeAnalyzer(item));
                    }
                    analyzers = array;
                    continue;
                }
                if (property.NameEquals("tokenizers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Tokenizer> array = new List<Tokenizer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Tokenizer.DeserializeTokenizer(item));
                    }
                    tokenizers = array;
                    continue;
                }
                if (property.NameEquals("tokenFilters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TokenFilter> array = new List<TokenFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TokenFilter.DeserializeTokenFilter(item));
                    }
                    tokenFilters = array;
                    continue;
                }
                if (property.NameEquals("charFilters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CharFilter> array = new List<CharFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CharFilter.DeserializeCharFilter(item));
                    }
                    charFilters = array;
                    continue;
                }
                if (property.NameEquals("encryptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptionKey = EncryptionKey.DeserializeEncryptionKey(property.Value);
                    continue;
                }
                if (property.NameEquals("similarity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    similarity = Similarity.DeserializeSimilarity(property.Value);
                    continue;
                }
                if (property.NameEquals("@odata.etag"u8))
                {
                    odataEtag = property.Value.GetString();
                    continue;
                }
            }
            return new Index(name, fields, scoringProfiles ?? new ChangeTrackingList<ScoringProfile>(), defaultScoringProfile.Value, corsOptions.Value, suggesters ?? new ChangeTrackingList<Suggester>(), analyzers ?? new ChangeTrackingList<Analyzer>(), tokenizers ?? new ChangeTrackingList<Tokenizer>(), tokenFilters ?? new ChangeTrackingList<TokenFilter>(), charFilters ?? new ChangeTrackingList<CharFilter>(), encryptionKey.Value, similarity.Value, odataEtag.Value);
        }
    }
}
