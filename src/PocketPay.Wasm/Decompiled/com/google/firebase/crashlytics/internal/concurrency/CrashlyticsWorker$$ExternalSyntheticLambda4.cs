namespace WillowMaze.Wasm.Decompiled;


public readonly class CrashlyticsWorker$$ExternalSyntheticLambda4 : com.google.android.gms.tasks.Continuation {
    public readonly java.util.concurrent.Func f$0;

    public CrashlyticsWorker$$ExternalSyntheticLambda4(java.util.concurrent.Func callable) {
        this.f$0 = callable;
    }

    public static com.google.android.gms.tasks.Task MtSsmrddPUYgCWzF(java.util.concurrent.Func callable, com.google.android.gms.tasks.Task task) {
        return com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker.lambda$submitTask$3(callable, task);
    }

    public static void MtSsmrddPUYgCWzF(java.util.concurrent.Func callable, com.google.android.gms.tasks.Task task, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MtSsmrddPUYgCWzF(java.util.concurrent.Func callable, com.google.android.gms.tasks.Task task, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MtSsmrddPUYgCWzF(java.util.concurrent.Func callable, com.google.android.gms.tasks.Task task, bool z, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object Then(com.google.android.gms.tasks.Task task) {
        return MtSsmrddPUYgCWzF(this.f$0, task);
    }
}

