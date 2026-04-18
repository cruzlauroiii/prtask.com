namespace WillowMaze.Wasm.Decompiled;


class ConfigRealtimeHttpClient$1 : java.lang.Action {
    readonly com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient this$0;

    ConfigRealtimeHttpClient$1(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient configRealtimeHttpClient) {
        this.this$0 = configRealtimeHttpClient;
    }

    public static void QXObIJjcYMuRAbYe(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient configRealtimeHttpClient) {
        configRealtimeHttpClient.beginRealtimeHttpStream();
    }

    public override void Run() {
        QXObIJjcYMuRAbYe(this.this$0);
    }
}

