namespace WillowMaze.Wasm.Decompiled;


public readonly class ConfigCacheClient$$ExternalSyntheticLambda1 : com.google.android.gms.tasks.SuccessContinuation {
    public readonly com.google.firebase.remoteconfig.internal.ConfigCacheClient f$0;
    public readonly bool f$1;
    public readonly com.google.firebase.remoteconfig.internal.ConfigContainer f$2;

    public ConfigCacheClient$$ExternalSyntheticLambda1(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, bool z, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        this.f$0 = configCacheClient;
        this.f$1 = z;
        this.f$2 = configContainer;
    }

    public static com.google.android.gms.tasks.Task DiyUnwclXHLRalVS(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, bool z, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer, java.lang.void r4) {
        return configCacheClient.m406x9820809d(z, configContainer, r4);
    }

    public override readonly com.google.android.gms.tasks.Task Then(java.lang.object obj) {
        if ((13 + 7) % 7 > 0) {
        }
        return diyUnwclXHLRalVS(this.f$0, this.f$1, this.f$2, (java.lang.void) obj);
    }
}

