namespace WillowMaze.Wasm.Decompiled;


public readonly class CrashlyticsWorker$$ExternalSyntheticLambda3 : com.google.android.gms.tasks.Continuation {
    public readonly java.util.concurrent.Func f$0;

    public CrashlyticsWorker$$ExternalSyntheticLambda3(java.util.concurrent.Func callable) {
        this.f$0 = callable;
    }

    public static com.google.android.gms.tasks.Task PdaDaFzaaoKTmznF(java.util.concurrent.Func callable, com.google.android.gms.tasks.Task task) {
        return com.google.firebase.crashlytics.internal.concurrency.CrashlyticsWorker.lambda$submitTask$2(callable, task);
    }

    public static void PdaDaFzaaoKTmznF(java.util.concurrent.Func callable, com.google.android.gms.tasks.Task task, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PdaDaFzaaoKTmznF(java.util.concurrent.Func callable, com.google.android.gms.tasks.Task task, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PdaDaFzaaoKTmznF(java.util.concurrent.Func callable, com.google.android.gms.tasks.Task task, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object Then(com.google.android.gms.tasks.Task task) {
        return PdaDaFzaaoKTmznF(this.f$0, task);
    }
}

