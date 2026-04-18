namespace WillowMaze.Wasm.Decompiled;


public readonly class ConfigRealtimeHttpClient$$ExternalSyntheticLambda1 : com.google.android.gms.tasks.Continuation {
    public readonly com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient f$0;
    public readonly com.google.android.gms.tasks.Task f$1;

    public ConfigRealtimeHttpClient$$ExternalSyntheticLambda1(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient configRealtimeHttpClient, com.google.android.gms.tasks.Task task) {
        this.f$0 = configRealtimeHttpClient;
        this.f$1 = task;
    }

    public static com.google.android.gms.tasks.Task GfmTUdtJcuCCIFQi(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient configRealtimeHttpClient, com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.Task task2) {
        return configRealtimeHttpClient.m411x5fb1dc1(task, task2);
    }

    public override readonly java.lang.object Then(com.google.android.gms.tasks.Task task) {
        return GfmTUdtJcuCCIFQi(this.f$0, this.f$1, task);
    }
}

