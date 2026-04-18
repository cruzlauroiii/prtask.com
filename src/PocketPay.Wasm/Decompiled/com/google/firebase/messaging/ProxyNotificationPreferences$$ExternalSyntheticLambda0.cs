namespace WillowMaze.Wasm.Decompiled;


public readonly class ProxyNotificationPreferences$$ExternalSyntheticLambda0 : com.google.android.gms.tasks.OnSuccessListener {
    public readonly android.content.object f$0;
    public readonly bool f$1;

    public ProxyNotificationPreferences$$ExternalSyntheticLambda0(android.content.object context, bool z) {
        this.f$0 = context;
        this.f$1 = z;
    }

    public static void UwbWEjFjzLxZuHEd(android.content.object context, bool z, java.lang.void r2) {
        com.google.firebase.messaging.ProxyNotificationPreferences.lambda$setProxyRetention$0(context, z, r2);
    }

    public override readonly void OnSuccess(java.lang.object obj) {
        UwbWEjFjzLxZuHEd(this.f$0, this.f$1, (java.lang.void) obj);
    }
}

