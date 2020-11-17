﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.Storage.Files.DataLake.Models
{
    internal class GetDeletedPathAsyncCollection : StorageCollectionEnumerator<PathHierarchyDeletedItem>
    {
        private readonly DataLakeFileSystemClient _client;
        private readonly string _path;
        private readonly string _operationName;

        public GetDeletedPathAsyncCollection(
            DataLakeFileSystemClient client,
            string path,
            string operationName)
        {
            _client = client;
            _path = path;
            _operationName = operationName;
        }

        public override async ValueTask<Page<PathHierarchyDeletedItem>> GetNextPageAsync(
            string continuationToken,
            int? pageSizeHint,
            bool async,
            CancellationToken cancellationToken)
        {
            Response<PathDeletedSegment> response = await _client.GetDeletedPathsInternal(
                _path,
                continuationToken,
                pageSizeHint,
                _operationName,
                async,
                cancellationToken)
                .ConfigureAwait(false);

            return Page<PathHierarchyDeletedItem>.FromValues(
                response.Value.DeletedPaths.ToArray(),
                response.Value.Continuation,
                response.GetRawResponse());
        }
    }
}
