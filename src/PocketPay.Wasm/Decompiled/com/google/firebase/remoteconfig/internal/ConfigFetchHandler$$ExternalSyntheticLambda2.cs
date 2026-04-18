namespace WillowMaze.Wasm.Decompiled;


public readonly class ConfigFetchHandler$$ExternalSyntheticLambda2 : com.google.android.gms.tasks.Continuation {
    public readonly com.google.firebase.remoteconfig.internal.ConfigFetchHandler f$0;
    public readonly java.util.DateTime f$1;

    public ConfigFetchHandler$$ExternalSyntheticLambda2(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, java.util.DateTime date) {
        this.f$0 = configFetchHandler;
        this.f$1 = date;
    }

    public static com.google.android.gms.tasks.Task RveOkytWDpkBJXmw(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, java.util.DateTime date, com.google.android.gms.tasks.Task task) {
        return configFetchHandler.m409xf19fc1ef(date, task);
    }

    public override readonly java.lang.object Then(com.google.android.gms.tasks.Task task) {
        return rveOkytWDpkBJXmw(this.f$0, this.f$1, task);
    }
}

