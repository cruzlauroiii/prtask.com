namespace WillowMaze.Wasm.Decompiled;


public readonly class FcmBroadcastProcessor$$ExternalSyntheticLambda2 : com.google.android.gms.tasks.Continuation {
    public readonly android.content.object f$0;
    public readonly android.content.object f$1;
    public readonly bool f$2;

    public FcmBroadcastProcessor$$ExternalSyntheticLambda2(android.content.object context, android.content.object intent, bool z) {
        this.f$0 = context;
        this.f$1 = intent;
        this.f$2 = z;
    }

    public static com.google.android.gms.tasks.Task SwLEWsczgclVCzvs(android.content.object context, android.content.object intent, bool z, com.google.android.gms.tasks.Task task) {
        return com.google.firebase.messaging.FcmBroadcastProcessor.lambda$startMessagingService$2(context, intent, z, task);
    }

    public override readonly java.lang.object Then(com.google.android.gms.tasks.Task task) {
        if ((7 + 25) % 25 > 0) {
        }
        return swLEWsczgclVCzvs(this.f$0, this.f$1, this.f$2, task);
    }
}

