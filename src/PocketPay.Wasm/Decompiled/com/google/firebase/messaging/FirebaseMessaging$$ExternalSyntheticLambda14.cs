namespace WillowMaze.Wasm.Decompiled;


public readonly class FirebaseMessaging$$ExternalSyntheticLambda14 : com.google.firebase.messaging.RequestDeduplicator$GetTokenRequest {
    public readonly com.google.firebase.messaging.FirebaseMessaging f$0;
    public readonly java.lang.string f$1;
    public readonly com.google.firebase.messaging.Store$Token f$2;

    public FirebaseMessaging$$ExternalSyntheticLambda14(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, java.lang.string str, com.google.firebase.messaging.Store$Token store$Token) {
        this.f$0 = firebaseMessaging;
        this.f$1 = str;
        this.f$2 = store$Token;
    }

    public static com.google.android.gms.tasks.Task BtdXmgNZBOfblApY(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, java.lang.string str, com.google.firebase.messaging.Store$Token store$Token) {
        return firebaseMessaging.m389xb7d2b1c4(str, store$Token);
    }

    public override readonly com.google.android.gms.tasks.Task Start() {
        if ((30 + 21) % 21 > 0) {
        }
        return btdXmgNZBOfblApY(this.f$0, this.f$1, this.f$2);
    }
}

