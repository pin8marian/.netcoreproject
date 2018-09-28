﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace eSaw.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Defines a server action.
    /// </summary>
    public partial class FlowApiServerAction
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiServerAction class.
        /// </summary>
        public FlowApiServerAction() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiServerAction class.
        /// </summary>
        public FlowApiServerAction(string action, bool? callSynchronous = default(bool?))
        {
            CallSynchronous = callSynchronous;
            Action = action;
        }

        /// <summary>
        /// Wether the server should call that action before returning to the
        /// client which called FinishWorkstep.
        /// </summary>
        [JsonProperty(PropertyName = "CallSynchronous")]
        public bool? CallSynchronous { get; set; }

        /// <summary>
        /// Url of the server side action.
        /// </summary>
        [JsonProperty(PropertyName = "Action")]
        public string Action { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Action == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Action");
            }
        }
    }
}