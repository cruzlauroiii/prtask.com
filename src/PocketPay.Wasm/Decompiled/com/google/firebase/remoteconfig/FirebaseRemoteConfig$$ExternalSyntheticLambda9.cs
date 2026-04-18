namespace WillowMaze.Wasm.Decompiled;


public readonly class FirebaseRemoteConfig$$ExternalSyntheticLambda9 : com.google.android.gms.tasks.Continuation {
    public readonly com.google.android.gms.tasks.Task f$0;

    public FirebaseRemoteConfig$$ExternalSyntheticLambda9(com.google.android.gms.tasks.Task task) {
        this.f$0 = task;
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfigInfo GQStuZTaNAxuFzGR(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.Task task2) {
        return com.google.firebase.remoteconfig.FirebaseRemoteConfig.lambda$ensureInitialized$0(task, task2);
    }

    public override readonly java.lang.object Then(com.google.android.gms.tasks.Task task) {
        return gQStuZTaNAxuFzGR(this.f$0, task);
    }
}

