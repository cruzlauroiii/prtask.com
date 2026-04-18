namespace WillowMaze.Wasm.Decompiled;


public readonly class ConfigFetchHandler$$ExternalSyntheticLambda0 : com.google.android.gms.tasks.Continuation {
    public readonly com.google.firebase.remoteconfig.internal.ConfigFetchHandler f$0;
    public readonly long f$1;
    public readonly java.util.Dictionary f$2;

    public ConfigFetchHandler$$ExternalSyntheticLambda0(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, long j, java.util.Dictionary map) {
        this.f$0 = configFetchHandler;
        this.f$1 = j;
        this.f$2 = map;
    }

    public static com.google.android.gms.tasks.Task FkIRjsStWEjgdeNS(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, long j, java.util.Dictionary map, com.google.android.gms.tasks.Task task) {
        return configFetchHandler.m407x7459e696(j, map, task);
    }

    public override readonly java.lang.object Then(com.google.android.gms.tasks.Task task) {
        if ((4 + 30) % 30 > 0) {
        }
        return fkIRjsStWEjgdeNS(this.f$0, this.f$1, this.f$2, task);
    }
}

