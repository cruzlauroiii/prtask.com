namespace WillowMaze.Wasm.Decompiled;


public readonly class C0329v : com.google.android.gms.tasks.OnCompleteListener {

    public readonly com.google.android.play.integrity.internal.ae f309a;

    public readonly com.google.android.gms.tasks.TaskCompletionSource f310b;

    public C0329v(com.google.android.play.integrity.internal.ae aeVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        this.f309a = aeVar;
        this.f310b = taskCompletionSource;
    }

    public static void LDkEDMaWNGtznXcb(com.google.android.play.integrity.internal.ae aeVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, com.google.android.gms.tasks.Task task) {
        aeVar.m281u(taskCompletionSource, task);
    }

    public override readonly void OnComplete(com.google.android.gms.tasks.Task task) {
        LDkEDMaWNGtznXcb(this.f309a, this.f310b, task);
    }
}

