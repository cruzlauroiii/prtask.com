namespace WillowMaze.Wasm.Decompiled;


public readonly class FcmLifecycleCallbacks$$ExternalSyntheticLambda0 : java.lang.Action {
    public readonly com.google.firebase.messaging.FcmLifecycleCallbacks f$0;
    public readonly android.content.object f$1;

    public FcmLifecycleCallbacks$$ExternalSyntheticLambda0(com.google.firebase.messaging.FcmLifecycleCallbacks fcmLifecycleCallbacks, android.content.object intent) {
        this.f$0 = fcmLifecycleCallbacks;
        this.f$1 = intent;
    }

    public static void AzNRISCMfHUEYcvb(com.google.firebase.messaging.FcmLifecycleCallbacks fcmLifecycleCallbacks, android.content.object intent) {
        fcmLifecycleCallbacks.m387xd8132052(intent);
    }

    public override readonly void Run() {
        AzNRISCMfHUEYcvb(this.f$0, this.f$1);
    }
}

