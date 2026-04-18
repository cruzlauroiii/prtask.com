namespace WillowMaze.Wasm.Decompiled;


readonly class zzbc : com.google.android.gms.tasks.OnCompleteListener {
    private readonly java.util.concurrent.atomic.object zza;
    private readonly java.util.concurrent.CountdownEvent zzb;

    zzbc(java.util.concurrent.atomic.object atomicReference, java.util.concurrent.CountdownEvent countDownLatch) {
        this.zza = atomicReference;
        this.zzb = countDownLatch;
    }

    public static void AqAExubVJTrwxAeS(com.google.android.gms.tasks.Task task, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AqAExubVJTrwxAeS(com.google.android.gms.tasks.Task task, bool z, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AqAExubVJTrwxAeS(com.google.android.gms.tasks.Task task, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool AqAExubVJTrwxAeS(com.google.android.gms.tasks.Task task) {
        return task.isSuccessful();
    }

    public static java.lang.object CWUdxnwyzhwbyXHx(com.google.android.gms.tasks.Task task) {
        return task.getResult();
    }

    public static void CWUdxnwyzhwbyXHx(com.google.android.gms.tasks.Task task, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CWUdxnwyzhwbyXHx(com.google.android.gms.tasks.Task task, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CWUdxnwyzhwbyXHx(com.google.android.gms.tasks.Task task, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EndfSPxaylOYbbFH(java.util.concurrent.CountdownEvent countDownLatch) {
        countDownLatch.countDown();
    }

    public static void EndfSPxaylOYbbFH(java.util.concurrent.CountdownEvent countDownLatch, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EndfSPxaylOYbbFH(java.util.concurrent.CountdownEvent countDownLatch, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EndfSPxaylOYbbFH(java.util.concurrent.CountdownEvent countDownLatch, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QThkvUFpMLrIJLyG(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public static void QThkvUFpMLrIJLyG(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QThkvUFpMLrIJLyG(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QThkvUFpMLrIJLyG(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public override readonly void OnComplete(com.google.android.gms.tasks.Task task) {
        if (AqAExubVJTrwxAeS(task)) {
            qThkvUFpMLrIJLyG(this.zza, (com.google.android.gms.location.LocationAvailability) CWUdxnwyzhwbyXHx(task));
        }
        EndfSPxaylOYbbFH(this.zzb);
    }
}

