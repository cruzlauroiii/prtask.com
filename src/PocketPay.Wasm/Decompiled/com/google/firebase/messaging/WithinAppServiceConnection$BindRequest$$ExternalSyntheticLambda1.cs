namespace WillowMaze.Wasm.Decompiled;


public readonly class WithinAppServiceConnection$BindRequest$$ExternalSyntheticLambda1 : com.google.android.gms.tasks.OnCompleteListener {
    public readonly java.util.concurrent.ScheduledTask f$0;

    public WithinAppServiceConnection$BindRequest$$ExternalSyntheticLambda1(java.util.concurrent.ScheduledTask scheduledTask) {
        this.f$0 = scheduledTask;
    }

    public static void NZxNlDbULTqnWuiR(java.util.concurrent.ScheduledTask scheduledTask, com.google.android.gms.tasks.Task task) {
        com.google.firebase.messaging.WithinAppServiceConnection$BindRequest.lambda$arrangeTimeout$1(scheduledTask, task);
    }

    public override readonly void OnComplete(com.google.android.gms.tasks.Task task) {
        NZxNlDbULTqnWuiR(this.f$0, task);
    }
}

