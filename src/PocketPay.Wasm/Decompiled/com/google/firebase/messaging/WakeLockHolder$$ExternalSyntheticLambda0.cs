namespace WillowMaze.Wasm.Decompiled;


public readonly class WakeLockHolder$$ExternalSyntheticLambda0 : com.google.android.gms.tasks.OnCompleteListener {
    public readonly android.content.object f$0;

    public WakeLockHolder$$ExternalSyntheticLambda0(android.content.object intent) {
        this.f$0 = intent;
    }

    public static void IkjMGwcEsuPayUGl(android.content.object intent, com.google.android.gms.tasks.Task task) {
        com.google.firebase.messaging.WakeLockHolder.lambda$sendWakefulServiceobject$0(intent, task);
    }

    public override readonly void OnComplete(com.google.android.gms.tasks.Task task) {
        IkjMGwcEsuPayUGl(this.f$0, task);
    }
}

