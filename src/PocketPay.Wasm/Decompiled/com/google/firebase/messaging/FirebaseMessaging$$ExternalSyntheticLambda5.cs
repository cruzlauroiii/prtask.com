namespace WillowMaze.Wasm.Decompiled;


public readonly class FirebaseMessaging$$ExternalSyntheticLambda5 : com.google.android.gms.tasks.OnSuccessListener {
    public readonly com.google.firebase.messaging.FirebaseMessaging f$0;

    public FirebaseMessaging$$ExternalSyntheticLambda5(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging) {
        this.f$0 = firebaseMessaging;
    }

    public static void ZkqIVmmODkfCZwKN(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, com.google.firebase.messaging.TopicsSubscriber topicsSubscriber) {
        firebaseMessaging.m907lambda$new$3$comgooglefirebasemessagingFirebaseMessaging(topicsSubscriber);
    }

    public override readonly void OnSuccess(java.lang.object obj) {
        zkqIVmmODkfCZwKN(this.f$0, (com.google.firebase.messaging.TopicsSubscriber) obj);
    }
}

