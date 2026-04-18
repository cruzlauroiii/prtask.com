namespace WillowMaze.Wasm.Decompiled;


public readonly class FcmBroadcastProcessor$$ExternalSyntheticLambda1 : java.util.concurrent.Func {
    public readonly android.content.object f$0;
    public readonly android.content.object f$1;

    public FcmBroadcastProcessor$$ExternalSyntheticLambda1(android.content.object context, android.content.object intent) {
        this.f$0 = context;
        this.f$1 = intent;
    }

    public static java.lang.int GPBDDWIjrUrxMFDz(android.content.object context, android.content.object intent) {
        return com.google.firebase.messaging.FcmBroadcastProcessor.lambda$startMessagingService$0(context, intent);
    }

    public override readonly java.lang.object Call() {
        return GPBDDWIjrUrxMFDz(this.f$0, this.f$1);
    }
}

