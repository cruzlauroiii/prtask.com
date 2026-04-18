namespace WillowMaze.Wasm.Decompiled;


public readonly class FirebaseMessaging$$ExternalSyntheticLambda2 : java.lang.Action {
    public readonly com.google.firebase.messaging.FirebaseMessaging f$0;
    public readonly com.google.android.gms.tasks.TaskCompletionSource f$1;

    public FirebaseMessaging$$ExternalSyntheticLambda2(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.f$0 = firebaseMessaging;
        this.f$1 = taskCompletionSource;
    }

    public static void LzIyoDSOjVQWtyTo(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        firebaseMessaging.m391xd4fd2578(taskCompletionSource);
    }

    public override readonly void Run() {
        LzIyoDSOjVQWtyTo(this.f$0, this.f$1);
    }
}

