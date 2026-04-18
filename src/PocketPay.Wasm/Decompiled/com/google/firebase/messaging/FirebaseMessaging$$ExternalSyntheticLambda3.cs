namespace WillowMaze.Wasm.Decompiled;


public readonly class FirebaseMessaging$$ExternalSyntheticLambda3 : com.google.firebase.iid.internal.FirebaseInstanceIdInternal$NewTokenListener {
    public readonly com.google.firebase.messaging.FirebaseMessaging f$0;

    public FirebaseMessaging$$ExternalSyntheticLambda3(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging) {
        this.f$0 = firebaseMessaging;
    }

    public static void GfqZDCFIRBYWClbh(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, java.lang.string str) {
        firebaseMessaging.m905lambda$new$1$comgooglefirebasemessagingFirebaseMessaging(str);
    }

    public override readonly void OnNewToken(java.lang.string str) {
        gfqZDCFIRBYWClbh(this.f$0, str);
    }
}

