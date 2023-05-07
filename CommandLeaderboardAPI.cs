using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.Azure.Cosmos;
using hire_downs.command.Models;
using System.Collections.Generic;

namespace hire_downs.command
{
    public static class CommandLeaderboardAPI
    {
        [FunctionName("CommandLeaderboardAPI")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req)
        {
            CosmosClient cosmosClient = new CosmosClient("AccountEndpoint=https://test-command-leaderboard-db.documents.azure.com:443/;AccountKey=<KEY>;");
            Database db = await cosmosClient.CreateDatabaseIfNotExistsAsync("command-leaderboard");
            Container container = await db.CreateContainerIfNotExistsAsync(
                id: "data",
                partitionKeyPath: "/id"
            );

            List<ScoreItem> leaderboard = new List<ScoreItem>();

            using FeedIterator<ScoreItem> feed = container.GetItemQueryIterator<ScoreItem>(
                queryText: "SELECT TOP 10 data.username, data.score FROM data ORDER BY data.score DESC"
            );

            // Iterate query result pages
            while (feed.HasMoreResults)
            {
                FeedResponse<ScoreItem> response = await feed.ReadNextAsync();

                // Iterate query results
                foreach (ScoreItem item in response)
                {
                    leaderboard.Add(item);
                }
            }

            return new OkObjectResult(JsonConvert.SerializeObject(leaderboard));
        }
    }
}
