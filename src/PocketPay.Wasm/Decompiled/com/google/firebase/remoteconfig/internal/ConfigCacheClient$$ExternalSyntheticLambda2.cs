namespace WillowMaze.Wasm.Decompiled;


public readonly class ConfigCacheClient$$ExternalSyntheticLambda2 : java.util.concurrent.Func {
    public readonly com.google.firebase.remoteconfig.internal.ConfigStorageClient f$0;

    public ConfigCacheClient$$ExternalSyntheticLambda2(com.google.firebase.remoteconfig.internal.ConfigStorageClient configStorageClient) {
        this.f$0 = configStorageClient;
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer EDeyqdnzckwvAbia(com.google.firebase.remoteconfig.internal.ConfigStorageClient configStorageClient) {
        return configStorageClient.read();
    }

    public override readonly java.lang.object Call() {
        return EDeyqdnzckwvAbia(this.f$0);
    }
}

