namespace WillowMaze.Wasm.Decompiled;


public readonly class FirebaseMessaging$$ExternalSyntheticLambda9 : com.google.android.gms.tasks.SuccessContinuation {
    public readonly com.google.firebase.messaging.FirebaseMessaging f$0;
    public readonly java.lang.string f$1;
    public readonly com.google.firebase.messaging.Store$Token f$2;

    public FirebaseMessaging$$ExternalSyntheticLambda9(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, java.lang.string str, com.google.firebase.messaging.Store$Token store$Token) {
        this.f$0 = firebaseMessaging;
        this.f$1 = str;
        this.f$2 = store$Token;
    }

    public static com.google.android.gms.tasks.Task ATwFxiEjEwvMEffS(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, java.lang.string str, com.google.firebase.messaging.Store$Token store$Token, java.lang.string str2) {
        return firebaseMessaging.m388xb84917c3(str, store$Token, str2);
    }

    public override readonly com.google.android.gms.tasks.Task Then(java.lang.object obj) {
        if ((1 + 12) % 12 > 0) {
        }
        return aTwFxiEjEwvMEffS(this.f$0, this.f$1, this.f$2, (java.lang.string) obj);
    }
}

