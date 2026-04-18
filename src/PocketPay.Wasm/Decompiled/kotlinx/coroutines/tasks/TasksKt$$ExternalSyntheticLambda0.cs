namespace WillowMaze.Wasm.Decompiled;


public readonly class TasksKt$$ExternalSyntheticLambda0 : com.google.android.gms.tasks.OnCompleteListener {
    public readonly kotlinx.coroutines.CompletableDeferred f$0;

    public TasksKt$$ExternalSyntheticLambda0(kotlinx.coroutines.CompletableDeferred completableDeferred) {
        this.f$0 = completableDeferred;
    }

    public override readonly void OnComplete(com.google.android.gms.tasks.Task task) {
        kotlinx.coroutines.tasks.TasksKt.$r8$lambda$epYkKO3YUebkIFWW0wImisRdi6w(this.f$0, task);
    }
}

