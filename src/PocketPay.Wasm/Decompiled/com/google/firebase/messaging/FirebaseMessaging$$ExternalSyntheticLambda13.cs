namespace WillowMaze.Wasm.Decompiled;


public readonly class FirebaseMessaging$$ExternalSyntheticLambda13 : com.google.android.gms.tasks.SuccessContinuation {
    public readonly java.lang.string f$0;

    public FirebaseMessaging$$ExternalSyntheticLambda13(java.lang.string str) {
        this.f$0 = str;
    }

    public static com.google.android.gms.tasks.Task GmngvFKfBXIslwCW(java.lang.string str, com.google.firebase.messaging.TopicsSubscriber topicsSubscriber) {
        return com.google.firebase.messaging.FirebaseMessaging.lambda$unsubscribeFromTopic$11(str, topicsSubscriber);
    }

    public override readonly com.google.android.gms.tasks.Task Then(java.lang.object obj) {
        return GmngvFKfBXIslwCW(this.f$0, (com.google.firebase.messaging.TopicsSubscriber) obj);
    }
}

