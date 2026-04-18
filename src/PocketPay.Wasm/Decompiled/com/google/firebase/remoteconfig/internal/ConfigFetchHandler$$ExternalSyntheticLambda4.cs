namespace WillowMaze.Wasm.Decompiled;


public readonly class ConfigFetchHandler$$ExternalSyntheticLambda4 : com.google.android.gms.tasks.SuccessContinuation {
    public readonly com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse f$0;

    public ConfigFetchHandler$$ExternalSyntheticLambda4(com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse configFetchHandler$FetchResponse) {
        this.f$0 = configFetchHandler$FetchResponse;
    }

    public static com.google.android.gms.tasks.Task PtFAFphFCispRxmW(com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse configFetchHandler$FetchResponse, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return com.google.firebase.remoteconfig.internal.ConfigFetchHandler.lambda$fetchFromBackendAndCacheResponse$4(configFetchHandler$FetchResponse, configContainer);
    }

    public override readonly com.google.android.gms.tasks.Task Then(java.lang.object obj) {
        return ptFAFphFCispRxmW(this.f$0, (com.google.firebase.remoteconfig.internal.ConfigContainer) obj);
    }
}

