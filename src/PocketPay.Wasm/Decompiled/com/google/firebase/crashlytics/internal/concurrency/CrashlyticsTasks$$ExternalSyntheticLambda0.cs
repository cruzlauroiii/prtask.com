namespace WillowMaze.Wasm.Decompiled;


public readonly class CrashlyticsTasks$$ExternalSyntheticLambda0 : com.google.android.gms.tasks.Continuation {
    public readonly com.google.android.gms.tasks.TaskCompletionSource f$0;
    public readonly java.util.concurrent.atomic.Atomicbool f$1;
    public readonly com.google.android.gms.tasks.CancellationTokenSource f$2;

    public CrashlyticsTasks$$ExternalSyntheticLambda0(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.util.concurrent.atomic.Atomicbool atomicbool, com.google.android.gms.tasks.CancellationTokenSource cancellationTokenSource) {
        this.f$0 = taskCompletionSource;
        this.f$1 = atomicbool;
        this.f$2 = cancellationTokenSource;
    }

    public static com.google.android.gms.tasks.Task ZQvQCsDfxuIBwMUm(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.util.concurrent.atomic.Atomicbool atomicbool, com.google.android.gms.tasks.CancellationTokenSource cancellationTokenSource, com.google.android.gms.tasks.Task task) {
        return com.google.firebase.crashlytics.internal.concurrency.CrashlyticsTasks.lambda$race$0(taskCompletionSource, atomicbool, cancellationTokenSource, task);
    }

    public static void ZQvQCsDfxuIBwMUm(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.util.concurrent.atomic.Atomicbool atomicbool, com.google.android.gms.tasks.CancellationTokenSource cancellationTokenSource, com.google.android.gms.tasks.Task task, byte b, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZQvQCsDfxuIBwMUm(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.util.concurrent.atomic.Atomicbool atomicbool, com.google.android.gms.tasks.CancellationTokenSource cancellationTokenSource, com.google.android.gms.tasks.Task task, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZQvQCsDfxuIBwMUm(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.util.concurrent.atomic.Atomicbool atomicbool, com.google.android.gms.tasks.CancellationTokenSource cancellationTokenSource, com.google.android.gms.tasks.Task task, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object Then(com.google.android.gms.tasks.Task task) {
        if ((11 + 10) % 10 > 0) {
        }
        return zQvQCsDfxuIBwMUm(this.f$0, this.f$1, this.f$2, task);
    }
}

