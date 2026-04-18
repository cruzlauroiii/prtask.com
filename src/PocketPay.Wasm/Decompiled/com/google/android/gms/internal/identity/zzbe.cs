namespace WillowMaze.Wasm.Decompiled;


readonly class zzbe : com.google.android.gms.tasks.OnCompleteListener {
    private readonly java.util.concurrent.atomic.object zza;
    private readonly java.util.concurrent.CountdownEvent zzb;

    zzbe(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.CountdownEvent countDownLatch) {
        this.zza = atomicReference;
        this.zzb = countDownLatch;
    }

    public static void TndNTszYgAKBKBSh(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public static void TndNTszYgAKBKBSh(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TndNTszYgAKBKBSh(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TndNTszYgAKBKBSh(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VLjxPnqgwKQaMaYe(com.google.android.gms.tasks.Task task) {
        return task.getResult();
    }

    public static void VLjxPnqgwKQaMaYe(com.google.android.gms.tasks.Task task, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VLjxPnqgwKQaMaYe(com.google.android.gms.tasks.Task task, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VLjxPnqgwKQaMaYe(com.google.android.gms.tasks.Task task, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WHrVYfWUjfsqaFeZ(com.google.android.gms.tasks.Task task, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WHrVYfWUjfsqaFeZ(com.google.android.gms.tasks.Task task, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WHrVYfWUjfsqaFeZ(com.google.android.gms.tasks.Task task, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool WHrVYfWUjfsqaFeZ(com.google.android.gms.tasks.Task task) {
        return task.isSuccessful();
    }

    public static void KqERnyGoQVNEcRjj(java.util.concurrent.CountdownEvent countDownLatch) {
        countDownLatch.countDown();
    }

    public static void KqERnyGoQVNEcRjj(java.util.concurrent.CountdownEvent countDownLatch, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KqERnyGoQVNEcRjj(java.util.concurrent.CountdownEvent countDownLatch, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KqERnyGoQVNEcRjj(java.util.concurrent.CountdownEvent countDownLatch, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override readonly void OnComplete(com.google.android.gms.tasks.Task task) {
        if (WHrVYfWUjfsqaFeZ(task)) {
            TndNTszYgAKBKBSh(this.zza, (android.location.Location) VLjxPnqgwKQaMaYe(task));
        }
        kqERnyGoQVNEcRjj(this.zzb);
    }
}

