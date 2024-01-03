// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace xms_error_responses.Models
{
    /// <summary>
    /// The PetActionError.
    /// Please note <see cref="PetActionError"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="PetHungryOrThirstyError"/> and <see cref="PetSadError"/>.
    /// </summary>
    public abstract partial class PetActionError : PetAction
    {
        /// <summary> Initializes a new instance of <see cref="PetActionError"/>. </summary>
        protected PetActionError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PetActionError"/>. </summary>
        /// <param name="actionResponse"> action feedback. </param>
        /// <param name="errorType"></param>
        /// <param name="errorMessage"> the error message. </param>
        internal PetActionError(string actionResponse, string errorType, string errorMessage) : base(actionResponse)
        {
            ErrorType = errorType;
            ErrorMessage = errorMessage;
        }

        /// <summary> Gets or sets the error type. </summary>
        internal string ErrorType { get; set; }
        /// <summary> the error message. </summary>
        public string ErrorMessage { get; }
    }
}
