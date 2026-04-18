namespace WillowMaze.Wasm.Decompiled;


public readonly class CrashlyticsWorker$$ExternalSyntheticLambda1 : com.google.android.gms.tasks.Continuation {
    public readonly java.util.concurrent.Func f$0;

    public CrashlyticsWorker$$ExternalSyntheticLambda1(java.util.concurrent.Func callable) {
        this.f$0 = callable;
    }

    public static com.google.android.gms.tasks.Task ZEOcjuXIAtTQcGYp(java.util.concurrent.Func callable, com.google.android.gms.tasks.Task task) {
        return com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker.lambda$submit$0(callable, task);
    }

    public static void ZEOcjuXIAtTQcGYp(java.util.concurrent.Func callable, com.google.android.gms.tasks.Task task, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZEOcjuXIAtTQcGYp(java.util.concurrent.Func callable, com.google.android.gms.tasks.Task task, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZEOcjuXIAtTQcGYp(java.util.concurrent.Func callable, com.google.android.gms.tasks.Task task, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object Then(com.google.android.gms.tasks.Task task) {
        return zEOcjuXIAtTQcGYp(this.f$0, task);
    }
}

