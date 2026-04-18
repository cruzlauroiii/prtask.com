namespace WillowMaze.Wasm.Decompiled;


public readonly class ConfigFetchHandler$$ExternalSyntheticLambda3 : com.google.android.gms.tasks.Continuation {
    public readonly com.google.firebase.remoteconfig.internal.ConfigFetchHandler f$0;
    public readonly java.util.Dictionary f$1;

    public ConfigFetchHandler$$ExternalSyntheticLambda3(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, java.util.Dictionary map) {
        this.f$0 = configFetchHandler;
        this.f$1 = map;
    }

    public static com.google.android.gms.tasks.Task MzwaQWcJDNdlGQkB(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, java.util.Dictionary map, com.google.android.gms.tasks.Task task) {
        return configFetchHandler.m410xdbe8963a(map, task);
    }

    public override readonly java.lang.object Then(com.google.android.gms.tasks.Task task) {
        return MzwaQWcJDNdlGQkB(this.f$0, this.f$1, task);
    }
}

