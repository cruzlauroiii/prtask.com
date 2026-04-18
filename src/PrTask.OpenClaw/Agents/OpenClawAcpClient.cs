using PrTask.OpenClaw.Models;

namespace PrTask.OpenClaw.Agents;

#pragma warning disable SA1600

/// <summary>
/// Agent Client Protocol (ACP) client for submitting tasks to agents.
/// Maps to openclaw's acp/client.ts - connects to an ACP server (in-process or remote)
/// and submits tasks, polls status, and retrieves results.
///
/// In-process usage: directly references the ACP server to submit tasks.
/// Remote usage: would use WebSocket/HTTP to communicate (not implemented yet).
/// </summary>
public sealed class OpenClawAcpClient : IAsyncDisposable
{
    private OpenClawAcpServer? Server;

    /// <summary>
    /// Connect to an in-process ACP server.
    /// </summary>
    public void ConnectInProcess(OpenClawAcpServer AcpServer)
    {
        Server = AcpServer ?? throw new ArgumentNullException(nameof(AcpServer));
    }

    /// <summary>
    /// Submit a task to a specific agent and return immediately.
    /// </summary>
    public async Task<AcpTask> SubmitTaskAsync(string AgentId, string Text, CancellationToken Cancel = default)
    {
        EnsureConnected();

        var Input = new AcpTaskInput { Text = Text };
        return await Server!.SubmitTaskAsync(AgentId, Input, Cancel).ConfigureAwait(false);
    }

    /// <summary>
    /// Submit a task and wait for completion.
    /// </summary>
    public async Task<AcpTask> SubmitAndWaitAsync(string AgentId, string Text, TimeSpan? Timeout = null, CancellationToken Cancel = default)
    {
        EnsureConnected();

        var Input = new AcpTaskInput { Text = Text };
        return await Server!.SubmitAndWaitAsync(AgentId, Input, Timeout, Cancel).ConfigureAwait(false);
    }

    /// <summary>
    /// Get the status of a previously submitted task.
    /// </summary>
    public AcpTask? GetTaskStatus(string TaskId)
    {
        EnsureConnected();
        return Server!.GetTask(TaskId);
    }

    /// <summary>
    /// Cancel a pending or in-progress task.
    /// </summary>
    public bool CancelTask(string TaskId)
    {
        EnsureConnected();
        return Server!.CancelTask(TaskId);
    }

    /// <summary>
    /// List all available agents on the connected server.
    /// </summary>
    public List<AcpAgentCard> ListAgents()
    {
        EnsureConnected();
        return Server!.ListAgents();
    }

    /// <summary>
    /// Get a specific agent's card.
    /// </summary>
    public AcpAgentCard? GetAgentCard(string AgentId)
    {
        EnsureConnected();
        return Server!.GetAgentCard(AgentId);
    }

    private void EnsureConnected()
    {
        if (Server is null)
        {
            throw new InvalidOperationException("ACP client not connected. Call ConnectInProcess() first.");
        }
    }

    public ValueTask DisposeAsync()
    {
        Server = null;
        return ValueTask.CompletedTask;
    }
}

#pragma warning restore SA1600
