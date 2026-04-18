namespace WillowMaze.Wasm.Decompiled;


public readonly class FirebaseMessaging$$ExternalSyntheticLambda11 : java.lang.Action {
    public readonly com.google.firebase.messaging.FirebaseMessaging f$0;
    public readonly com.google.android.gms.tasks.TaskCompletionSource f$1;

    public FirebaseMessaging$$ExternalSyntheticLambda11(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.f$0 = firebaseMessaging;
        this.f$1 = taskCompletionSource;
    }

    public static void IwWOktSpAaNttKlG(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        firebaseMessaging.m392x6a533e85(taskCompletionSource);
    }

    public override readonly void Run() {
        iwWOktSpAaNttKlG(this.f$0, this.f$1);
    }
}

