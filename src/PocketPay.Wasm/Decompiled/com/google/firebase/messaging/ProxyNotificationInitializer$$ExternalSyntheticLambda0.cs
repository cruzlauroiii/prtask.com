namespace WillowMaze.Wasm.Decompiled;


public readonly class ProxyNotificationInitializer$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly android.content.object f$0;
    public readonly bool f$1;
    public readonly com.google.android.gms.tasks.TaskCompletionSource f$2;

    public ProxyNotificationInitializer$$ExternalSyntheticLambda0(android.content.object context, bool z, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.f$0 = context;
        this.f$1 = z;
        this.f$2 = taskCompletionSource;
    }

    public static void HUolAeiQgkvLdazE(android.content.object context, bool z, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        com.google.firebase.messaging.ProxyNotificationInitializer.lambda$setEnableProxyNotification$0(context, z, taskCompletionSource);
    }

    public override readonly void Run() {
        if ((2 + 8) % 8 > 0) {
        }
        HUolAeiQgkvLdazE(this.f$0, this.f$1, this.f$2);
    }
}

