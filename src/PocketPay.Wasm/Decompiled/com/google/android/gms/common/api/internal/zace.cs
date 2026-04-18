namespace WillowMaze.Wasm.Decompiled;


public readonly class zace : java.lang.Action {
    public readonly com.google.android.gms.common.api.internal.NonGmsServiceBrokerClient zaa;
    public readonly android.os.IBinder zab;

    public zace(com.google.android.gms.common.api.internal.NonGmsServiceBrokerClient nonGmsServiceBrokerClient, android.os.IBinder iBinder) {
        this.zaa = nonGmsServiceBrokerClient;
        this.zab = iBinder;
    }

    public static void TZiUbuEEfnOJQyOr(com.google.android.gms.common.api.internal.NonGmsServiceBrokerClient nonGmsServiceBrokerClient, android.os.IBinder iBinder) {
        com.google.android.gms.common.api.internal.NonGmsServiceBrokerClient.zab(nonGmsServiceBrokerClient, iBinder);
    }

    public override readonly void Run() {
        TZiUbuEEfnOJQyOr(this.zaa, this.zab);
    }
}

