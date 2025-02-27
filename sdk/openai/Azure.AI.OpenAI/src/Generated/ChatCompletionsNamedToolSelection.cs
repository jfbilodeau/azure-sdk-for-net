// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// An abstract representation of an explicit, named tool selection to use for a chat completions request.
    /// Please note <see cref="ChatCompletionsNamedToolSelection"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ChatCompletionsNamedFunctionToolSelection"/>.
    /// </summary>
    internal abstract partial class ChatCompletionsNamedToolSelection
    {
        /// <summary> Initializes a new instance of <see cref="ChatCompletionsNamedToolSelection"/>. </summary>
        protected ChatCompletionsNamedToolSelection()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ChatCompletionsNamedToolSelection"/>. </summary>
        /// <param name="type"> The object type. </param>
        internal ChatCompletionsNamedToolSelection(string type)
        {
            Type = type;
        }

        /// <summary> The object type. </summary>
        internal string Type { get; set; }
    }
}
