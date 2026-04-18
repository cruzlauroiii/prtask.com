namespace WillowMaze.Wasm.Decompiled;


public readonly class FirebaseMessaging$$ExternalSyntheticLambda0 : com.google.android.gms.tasks.SuccessContinuation {
    public readonly java.lang.string f$0;

    public FirebaseMessaging$$ExternalSyntheticLambda0(java.lang.string str) {
        this.f$0 = str;
    }

    public static com.google.android.gms.tasks.Task BvGGmIueRpSeDGzA(java.lang.string str, com.google.firebase.messaging.TopicsSubscriber topicsSubscriber) {
        return com.google.firebase.messaging.FirebaseMessaging.lambda$subscribeToTopic$10(str, topicsSubscriber);
    }

    public override readonly com.google.android.gms.tasks.Task Then(java.lang.object obj) {
        return bvGGmIueRpSeDGzA(this.f$0, (com.google.firebase.messaging.TopicsSubscriber) obj);
    }
}

