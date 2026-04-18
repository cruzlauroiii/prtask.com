#!/usr/bin/env dotnet-script
#r "nuget: Anthropic.SDK, 3.9.2"
using Anthropic.SDK;
using Anthropic.SDK.Messaging;

var apiKey = Environment.GetEnvironmentVariable("ANTHROPIC_API_KEY") ?? throw new Exception("no key");
var client = new AnthropicClient(apiKey);
var response = await client.Messages.GetClaudeMessageAsync(new MessageParameters
{
    Model = "claude-haiku-4-5-20251001",
    MaxTokens = 100,
    Messages = [new Message(RoleType.User, "Say OK")]
});
var text = response.Content.OfType<TextContent>().First().Text;
Console.WriteLine(text);
