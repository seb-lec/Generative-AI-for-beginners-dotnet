using System.ClientModel;
using Azure.AI.OpenAI;
using Microsoft.Extensions.AI;
using Azure;
using Azure.AI.Inference;

var deploymentName = "gpt-4o-mini";
var endpoint = new Uri("https://azureopenaiwithimagesgeneration.openai.azure.com/");
var apiKey = new ApiKeyCredential(Environment.GetEnvironmentVariable("AZURE_AI_KEY"));

IChatClient client = new AzureOpenAIClient(
    endpoint,
    apiKey)
.AsChatClient(deploymentName);

var response = await client.GetResponseAsync("What is AI?");

Console.WriteLine(response.Message);