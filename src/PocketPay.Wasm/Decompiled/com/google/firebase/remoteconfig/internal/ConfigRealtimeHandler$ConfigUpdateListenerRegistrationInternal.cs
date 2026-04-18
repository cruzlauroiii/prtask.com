namespace WillowMaze.Wasm.Decompiled;


public class ConfigRealtimeHandler$ConfigUpdateListenerRegistrationInternal : com.google.firebase.remoteconfig.ConfigUpdateListenerRegistration {
    private readonly com.google.firebase.remoteconfig.ConfigUpdateListener listener;
    readonly com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler this$0;

    public ConfigRealtimeHandler$ConfigUpdateListenerRegistrationInternal(com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler configRealtimeHandler, com.google.firebase.remoteconfig.ConfigUpdateListener configUpdateListener) {
        this.this$0 = configRealtimeHandler;
        this.listener = configUpdateListener;
    }

    public static void XWbDZrlpOshcFlyg(com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler configRealtimeHandler, com.google.firebase.remoteconfig.ConfigUpdateListener configUpdateListener) {
        com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler.access$000(configRealtimeHandler, configUpdateListener);
    }

    public override void Remove() {
        xWbDZrlpOshcFlyg(this.this$0, this.listener);
    }
}

