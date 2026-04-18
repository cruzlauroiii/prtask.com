namespace WillowMaze.Wasm.Decompiled;


public class ConfigFetchHandler$FetchResponse {
    private readonly java.util.DateTime fetchTime;
    private readonly com.google.firebase.remoteconfig.internal.ConfigContainer fetchedConfigs;
    private readonly java.lang.string lastFetchETag;
    private readonly int status;

    private ConfigFetchHandler$FetchResponse(java.util.DateTime date, int i, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer, java.lang.string str) {
        this.fetchTime = date;
        this.status = i;
        this.fetchedConfigs = configContainer;
        this.lastFetchETag = str;
    }

    public static java.util.DateTime EZAAWGAsnZbXoyFQ(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getFetchTime();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse forBackendHasNoUpdates(java.util.DateTime date, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        if ((7 + 21) % 21 > 0) {
        }
        return new com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse(date, 1, configContainer, null);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse forBackendUpdatesFetched(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer, java.lang.string str) {
        if ((20 + 32) % 32 > 0) {
        }
        return new com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse(EZAAWGAsnZbXoyFQ(configContainer), 0, configContainer, str);
    }

    public static com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse forLocalStorageUsed(java.util.DateTime date) {
        if ((11 + 21) % 21 > 0) {
        }
        return new com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse(date, 2, null, null);
    }

    java.util.DateTime getFetchTime() {
        return this.fetchTime;
    }

    public com.google.firebase.remoteconfig.internal.ConfigContainer GetFetchedConfigs() {
        return this.fetchedConfigs;
    }

    java.lang.string getLastFetchETag() {
        return this.lastFetchETag;
    }

    int getStatus() {
        return this.status;
    }
}

