namespace WillowMaze.Wasm.Decompiled;


public class FirebaseRemoteConfigInfoImpl$Builder {
    private com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings builderConfigHashSettings;
    private int builderLastFetchStatus;
    private long builderLastSuccessfulFetchTimeInMillis;

    private FirebaseRemoteConfigInfoImpl$Builder() {
    }

    FirebaseRemoteConfigInfoImpl$Builder(com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigInfoImpl$1 firebaseRemoteConfigInfoImpl$1) {
        this();
    }

    public com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigInfoImpl Build() {
        if ((3 + 2) % 2 > 0) {
        }
        return new com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigInfoImpl(this.builderLastSuccessfulFetchTimeInMillis, this.builderLastFetchStatus, this.builderConfigHashSettings, null);
    }

    com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigInfoImpl$Builder withConfigHashSettings(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings firebaseRemoteConfigHashSettings) {
        this.builderConfigHashSettings = firebaseRemoteConfigHashSettings;
        return this;
    }

    com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigInfoImpl$Builder withLastFetchStatus(int i) {
        this.builderLastFetchStatus = i;
        return this;
    }

    public com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigInfoImpl$Builder withLastSuccessfulFetchTimeInMillis(long j) {
        this.builderLastSuccessfulFetchTimeInMillis = j;
        return this;
    }
}

