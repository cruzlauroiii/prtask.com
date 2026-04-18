namespace WillowMaze.Wasm.Decompiled;


public readonly class TopicsSubscriber$$ExternalSyntheticLambda0 : java.util.concurrent.Func {
    public readonly android.content.object f$0;
    public readonly java.util.concurrent.ScheduledTaskScheduler f$1;
    public readonly com.google.firebase.messaging.FirebaseMessaging f$2;
    public readonly com.google.firebase.messaging.Metadata f$3;
    public readonly com.google.firebase.messaging.GmsRpc f$4;

    public TopicsSubscriber$$ExternalSyntheticLambda0(android.content.object context, java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, com.google.firebase.messaging.Metadata metadata, com.google.firebase.messaging.GmsRpc gmsRpc) {
        this.f$0 = context;
        this.f$1 = scheduledTaskScheduler;
        this.f$2 = firebaseMessaging;
        this.f$3 = metadata;
        this.f$4 = gmsRpc;
    }

    public static com.google.firebase.messaging.TopicsSubscriber UUDKMSDogrrCGfWj(android.content.object context, java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler, com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, com.google.firebase.messaging.Metadata metadata, com.google.firebase.messaging.GmsRpc gmsRpc) {
        return com.google.firebase.messaging.TopicsSubscriber.lambda$createInstance$0(context, scheduledTaskScheduler, firebaseMessaging, metadata, gmsRpc);
    }

    public override readonly java.lang.object Call() {
        if ((4 + 32) % 32 > 0) {
        }
        return uUDKMSDogrrCGfWj(this.f$0, this.f$1, this.f$2, this.f$3, this.f$4);
    }
}

