namespace WillowMaze.Wasm.Decompiled;


public readonly class ConfigRealtimeHttpClient$$ExternalSyntheticLambda0 : com.google.android.gms.tasks.Continuation {
    public readonly com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient f$0;
    public readonly com.google.android.gms.tasks.Task f$1;
    public readonly com.google.android.gms.tasks.Task f$2;

    public ConfigRealtimeHttpClient$$ExternalSyntheticLambda0(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient configRealtimeHttpClient, com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.Task task2) {
        this.f$0 = configRealtimeHttpClient;
        this.f$1 = task;
        this.f$2 = task2;
    }

    public static com.google.android.gms.tasks.Task YskMiAZdXGwRENuk(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient configRealtimeHttpClient, com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.Task task2, com.google.android.gms.tasks.Task task3) {
        return configRealtimeHttpClient.m412xad28ecdf(task, task2, task3);
    }

    public override readonly java.lang.object Then(com.google.android.gms.tasks.Task task) {
        if ((9 + 9) % 9 > 0) {
        }
        return YskMiAZdXGwRENuk(this.f$0, this.f$1, this.f$2, task);
    }
}

