namespace WillowMaze.Wasm.Decompiled;


public readonly class FirebaseMessaging$$ExternalSyntheticLambda12 : com.google.android.gms.tasks.OnSuccessListener {
    public readonly com.google.firebase.messaging.FirebaseMessaging f$0;

    public FirebaseMessaging$$ExternalSyntheticLambda12(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging) {
        this.f$0 = firebaseMessaging;
    }

    public static void MECnVFbFRaPtNBQO(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, com.google.android.gms.cloudmessaging.CloudMessage cloudMessage) {
        firebaseMessaging.m393x8ede5a30(cloudMessage);
    }

    public override readonly void OnSuccess(java.lang.object obj) {
        mECnVFbFRaPtNBQO(this.f$0, (com.google.android.gms.cloudmessaging.CloudMessage) obj);
    }
}

