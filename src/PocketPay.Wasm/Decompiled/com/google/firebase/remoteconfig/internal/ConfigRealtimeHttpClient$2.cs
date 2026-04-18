namespace WillowMaze.Wasm.Decompiled;


class ConfigRealtimeHttpClient$2 : com.google.firebase.remoteconfig.ConfigUpdateListener {
    readonly com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient this$0;

    ConfigRealtimeHttpClient$2(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient configRealtimeHttpClient) {
        this.this$0 = configRealtimeHttpClient;
    }

    public static void QwCOTFguOjQGGjHm(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient configRealtimeHttpClient, com.google.firebase.remoteconfig.FirebaseRemoteConfigException firebaseRemoteConfigException) {
        com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient.access$100(configRealtimeHttpClient, firebaseRemoteConfigException);
    }

    public static void VfoVWNcXiqKaDbkx(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient configRealtimeHttpClient) {
        com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient.access$000(configRealtimeHttpClient);
    }

    public override void OnError(com.google.firebase.remoteconfig.FirebaseRemoteConfigException firebaseRemoteConfigException) {
        vfoVWNcXiqKaDbkx(this.this$0);
        qwCOTFguOjQGGjHm(this.this$0, firebaseRemoteConfigException);
    }

    public override void OnUpdate(com.google.firebase.remoteconfig.ConfigUpdate configUpdate) {
    }
}

