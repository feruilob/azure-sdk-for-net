// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.Chat
{
    /// <summary> Result of the send message operation. </summary>
    internal partial class SendChatMessageResult
    {
        /// <summary> Initializes a new instance of SendChatMessageResult. </summary>
        /// <param name="id"> A server-generated message id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal SendChatMessageResult(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
        }

        /// <summary> A server-generated message id. </summary>
        public string Id { get; }
    }
}
