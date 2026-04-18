namespace WillowMaze.Wasm.Decompiled;


public readonly class ConfigCacheClient$$ExternalSyntheticLambda0 : java.util.concurrent.Func {
    public readonly com.google.firebase.remoteconfig.internal.ConfigCacheClient f$0;
    public readonly com.google.firebase.remoteconfig.internal.ConfigContainer f$1;

    public ConfigCacheClient$$ExternalSyntheticLambda0(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        this.f$0 = configCacheClient;
        this.f$1 = configContainer;
    }

    public static java.lang.void NwqnYHARXWKcWBHz(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configCacheClient.m405xddaae01c(configContainer);
    }

    public override readonly java.lang.object Call() {
        return nwqnYHARXWKcWBHz(this.f$0, this.f$1);
    }
}

