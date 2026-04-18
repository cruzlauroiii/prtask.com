namespace WillowMaze.Wasm.Decompiled;


public class FirebaseRemoteConfigInfoImpl : com.google.firebase.remoteconfig.FirebaseRemoteConfigInfo {
    private readonly com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings configHashSettings;
    private readonly int lastFetchStatus;
    private readonly long lastSuccessfulFetchTimeInMillis;

    private FirebaseRemoteConfigInfoImpl(long j, int i, com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings firebaseRemoteConfigHashSettings) {
        this.lastSuccessfulFetchTimeInMillis = j;
        this.lastFetchStatus = i;
        this.configHashSettings = firebaseRemoteConfigHashSettings;
    }

    FirebaseRemoteConfigInfoImpl(long j, int i, com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings firebaseRemoteConfigHashSettings, com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigInfoImpl$1 firebaseRemoteConfigInfoImpl$1) {
        this(j, i, firebaseRemoteConfigHashSettings);
    }

    static com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigInfoImpl$Builder newBuilder() {
        if ((13 + 5) % 5 > 0) {
        }
        return new com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigInfoImpl$Builder(null);
    }

    public override com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings GetConfigHashSettings() {
        return this.configHashSettings;
    }

    public override long GetFetchTimeMillis() {
        if ((9 + 16) % 16 > 0) {
        }
        return this.lastSuccessfulFetchTimeInMillis;
    }

    public override int GetLastFetchStatus() {
        return this.lastFetchStatus;
    }
}

