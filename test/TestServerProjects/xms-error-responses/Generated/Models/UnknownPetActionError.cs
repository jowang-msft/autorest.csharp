// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace xms_error_responses.Models
{
    /// <summary> The UnknownPetActionError. </summary>
    internal partial class UnknownPetActionError : PetActionError
    {
        /// <summary> Initializes a new instance of UnknownPetActionError. </summary>
        /// <param name="actionResponse"> action feedback. </param>
        /// <param name="errorType"></param>
        /// <param name="errorMessage"> the error message. </param>
        internal UnknownPetActionError(string actionResponse, string errorType, string errorMessage) : base(actionResponse, errorType, errorMessage)
        {
            ErrorType = errorType ?? "Unknown";
        }
    }
}