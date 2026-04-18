using System.Collections.Concurrent;
using PrTask.OpenClaw.Models;

namespace PrTask.OpenClaw.Agents;

#pragma warning disable SA1600

/// <summary>
/// Agent Client Protocol (ACP) server for agent-to-agent communication.
/// Maps to openclaw's acp/server.ts - handles task submission, status polling,
/// and result retrieval for the ACP protocol (draft spec from Google/Anthropic).
///
/// In-process usage: agents can submit tasks to other agents via this server.
/// The server manages task queues, dispatches to registered agent handlers,
/// and returns results.
/// </summary>
public sealed class OpenClawAcpServer : IAsyncDisposable
{
    private readonly ConcurrentDictionary<string, AcpTask> Tasks = new(StringComparer.OrdinalIgnoreCase);
    private readonly ConcurrentDictionary<string, AcpAgentCard> RegisteredAgents = new(StringComparer.OrdinalIgnoreCase);
    private readonly ConcurrentDictionary<string, Func<AcpTask, CancellationToken, Task<AcpTaskOutput>>> AgentHandlers = new(StringComparer.OrdinalIgnoreCase);
    private readonly AcpPolicy DefaultPolicy = new();
    private readonly CancellationTokenSource DisposeCts = new();

    /// <summary>
    /// Register an agent with its card (capabilities declaration) and handler.
    /// Maps to openclaw's ACP agent registration.
    /// </summary>
    public void RegisterAgent(AcpAgentCard Card, Func<AcpTask, CancellationToken, Task<AcpTaskOutput>> Handler)
    {
        ArgumentNullException.ThrowIfNull(Card);
        ArgumentNullException.ThrowIfNull(Handler);

        RegisteredAgents[Card.AgentId.ToLowerInvariant()] = Card;
        AgentHandlers[Card.AgentId.ToLowerInvariant()] = Handler;
    }

    /// <summary>
    /// Unregister an agent.
    /// </summary>
    public void UnregisterAgent(string AgentId)
    {
        var Key = AgentId.ToLowerInvariant();
        RegisteredAgents.TryRemove(Key, out _);
        AgentHandlers.TryRemove(Key, out _);
    }

    /// <summary>
    /// Submit a task to an agent.
    /// Returns the task with a pending status. The task will be executed asynchronously.
    /// Maps to openclaw's ACP task submission flow.
    /// </summary>
    public Task<AcpTask> SubmitTaskAsync(string AgentId, AcpTaskInput Input, CancellationToken Cancel = default)
    {
        ArgumentNullException.ThrowIfNull(Input);

        var NormalizedAgent = AgentId.ToLowerInvariant();
        if (!AgentHandlers.ContainsKey(NormalizedAgent))
        {
            return System.Threading.Tasks.Task.FromResult(new AcpTask
            {
                AgentId = AgentId,
                Status = AcpTaskStatus.Failed,
                Input = Input,
                Output = new AcpTaskOutput { Error = $"Agent '{AgentId}' not registered" },
                CompletedAt = DateTime.UtcNow,
            });
        }

        var NewTask = new AcpTask
        {
            AgentId = AgentId,
            Status = AcpTaskStatus.Pending,
            Input = Input,
        };

        Tasks[NewTask.Id] = NewTask;

        // Execute the task asynchronously
        _ = ExecuteTaskAsync(NewTask, Cancel);

        return System.Threading.Tasks.Task.FromResult(NewTask);
    }

    /// <summary>
    /// Submit and wait for task completion.
    /// Convenience method for synchronous task execution patterns.
    /// </summary>
    public async Task<AcpTask> SubmitAndWaitAsync(string AgentId, AcpTaskInput Input, TimeSpan? Timeout = null, CancellationToken Cancel = default)
    {
        var Task = await SubmitTaskAsync(AgentId, Input, Cancel).ConfigureAwait(false);

        var TimeoutMs = Timeout?.TotalMilliseconds ?? (DefaultPolicy.MaxTaskTimeoutSeconds * 1000);
        using var TimeoutCts = new CancellationTokenSource(TimeSpan.FromMilliseconds(TimeoutMs));
        using var LinkedCts = CancellationTokenSource.CreateLinkedTokenSource(Cancel, TimeoutCts.Token);

        // Poll for completion
        while (Task.Status is AcpTaskStatus.Pending or AcpTaskStatus.InProgress)
        {
            await System.Threading.Tasks.Task.Delay(100, LinkedCts.Token).ConfigureAwait(false);

            if (Tasks.TryGetValue(Task.Id, out var Updated))
            {
                Task = Updated;
            }
        }

        return Task;
    }

    /// <summary>
    /// Get a task by ID.
    /// </summary>
    public AcpTask? GetTask(string TaskId)
    {
        Tasks.TryGetValue(TaskId, out var Task);
        return Task;
    }

    /// <summary>
    /// Cancel a pending or in-progress task.
    /// </summary>
    public bool CancelTask(string TaskId)
    {
        if (Tasks.TryGetValue(TaskId, out var Task) && Task.Status is AcpTaskStatus.Pending or AcpTaskStatus.InProgress)
        {
            Task.Status = AcpTaskStatus.Cancelled;
            Task.CompletedAt = DateTime.UtcNow;
            return true;
        }

        return false;
    }

    /// <summary>
    /// List all registered agent cards.
    /// Maps to ACP agent directory listing.
    /// </summary>
    public List<AcpAgentCard> ListAgents()
    {
        return RegisteredAgents.Values.ToList();
    }

    /// <summary>
    /// Get a specific agent card.
    /// </summary>
    public AcpAgentCard? GetAgentCard(string AgentId)
    {
        RegisteredAgents.TryGetValue(AgentId.ToLowerInvariant(), out var Card);
        return Card;
    }

    private async Task ExecuteTaskAsync(AcpTask Task, CancellationToken Cancel)
    {
        var NormalizedAgent = Task.AgentId.ToLowerInvariant();
        if (!AgentHandlers.TryGetValue(NormalizedAgent, out var Handler))
        {
            Task.Status = AcpTaskStatus.Failed;
            Task.Output = new AcpTaskOutput { Error = "Agent handler not found" };
            Task.CompletedAt = DateTime.UtcNow;
            return;
        }

        Task.Status = AcpTaskStatus.InProgress;

        try
        {
            using var TimeoutCts = new CancellationTokenSource(TimeSpan.FromSeconds(DefaultPolicy.MaxTaskTimeoutSeconds));
            using var LinkedCts = CancellationTokenSource.CreateLinkedTokenSource(Cancel, TimeoutCts.Token, DisposeCts.Token);

            Task.Output = await Handler(Task, LinkedCts.Token).ConfigureAwait(false);
            Task.Status = AcpTaskStatus.Completed;
        }
        catch (OperationCanceledException)
        {
            Task.Status = AcpTaskStatus.Cancelled;
            Task.Output = new AcpTaskOutput { Error = "Task cancelled or timed out" };
        }
        catch (Exception Ex)
        {
            Task.Status = AcpTaskStatus.Failed;
            Task.Output = new AcpTaskOutput { Error = Ex.Message };
        }

        Task.CompletedAt = DateTime.UtcNow;
    }

    public async ValueTask DisposeAsync()
    {
        await DisposeCts.CancelAsync().ConfigureAwait(false);
        DisposeCts.Dispose();
    }
}

#pragma warning restore SA1600
