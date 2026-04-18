namespace WillowMaze.Wasm.Decompiled;


public readonly class FirebaseMessaging$$ExternalSyntheticLambda1 : java.lang.Action {
    public readonly com.google.firebase.messaging.FirebaseMessaging f$0;
    public readonly com.google.android.gms.tasks.TaskCompletionSource f$1;

    public FirebaseMessaging$$ExternalSyntheticLambda1(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.f$0 = firebaseMessaging;
        this.f$1 = taskCompletionSource;
    }

    public static void FuGgjbwEtDNPsuRc(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        firebaseMessaging.m390xd5738b77(taskCompletionSource);
    }

    public override readonly void Run() {
        FuGgjbwEtDNPsuRc(this.f$0, this.f$1);
    }
}

