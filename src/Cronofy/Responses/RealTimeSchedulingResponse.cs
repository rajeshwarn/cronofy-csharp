﻿namespace Cronofy.Responses
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Class for the deserialization of an real time scheduling response.
    /// </summary>
    internal sealed class RealTimeSchedulingResponse
    {
        /// <summary>
        /// Gets or sets the Url of the response.
        /// </summary>
        /// <value>
        /// The URL for the user to visit in order to add the event to their calendar.
        /// </value>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
