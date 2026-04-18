using Android.Os;
using Android.Util;
using Java.Util.Concurrent.Atomic;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes22.dex */
public readonly class zzcs : zzcx {
    private readonly object zza;
    private bool zzb;

    public zzcs() {
        this.zza = new object();
    }

    public static Dictionary<string, object> DYbCcFzyipxUXncq(zzcs r1, long r2) {
        return r1.zzb(r2);
    }

    public static string JoZqbEfYDERUwNnK(Class r1) {
        return r1.getCanonicalName();
    }

    public static Dictionary<string, object> PkhocJNRySPebwYD(zzcs r1, long r2) {
        return r1.zzb(r2);
    }

    public static object RPVcKjKDOWDYIfyk(Dictionary<string, object> r1, string r2) {
        return r1[r2);
    }

    public static object WtUrVhlfVYXgDFWS(Dictionary<string, object> r1, Class r2) {
        return zzf(r1, r2);
    }

    public static Class XhmsaYRqUqfRJwHe(object r1) {
        return r1.GetType();
    }

    public static void XuiOwelIgRHGroJw(object r0, long r1) {
        r0.wait(r1);
    }

    public static void YZxwYLAeiqJCugHX(object r0, object r1) {
        r0.set(r1);
    }

    public static object YyzaekkGgdmsyoup(Dictionary<string, object> r1, Class r2) {
        return zzf(r1, r2);
    }

    public static int ZnTbZLcAFQYwcXve(string r1, string r2, Exception r3) {
        return Console.w(r1, r2, r3);
    }

    public static object FuMXUrsfdUvwItoz(Class r1, object r2) {
        return r1.cast(r2);
    }

    public static string HasPgTbwXjQAKpls(string r1, object[] r2) {
        return string.format(r1, r2);
    }

    public static void JNaVAjFeeFObYetC(object r0) {
        r0.notify();
    }

    public static object OInXNYTWeaGkZqnx(object r1) {
        return r1[);
    }

    public static void TfmvwLDBsNAGbXEt(object r0) {
        r0.notify();
    }

    public static string ZIQpoFjkVwHUwcus(Class r1) {
        return r1.getCanonicalName();
    }

    public static readonly object Zzf(Dictionary<string, object> r2, Class r3) {
        if (((28 + 13) % 13) > 0) goto L27;
    L27:
        if (r2 is not null) goto L20;
    L24:
        return null;
    L20:
        object r22 = RPVcKjKDOWDYIfyk(r2, "r");
        if (r22 is null) goto L24;
        return fuMXUrsfdUvwItoz(r3, r22);
    L39:
        e = move-exception;
        ZnTbZLcAFQYwcXve("AM", hasPgTbwXjQAKpls("Unexpected object type. Expected, Received: %s, %s", new object[]{zIQpoFjkVwHUwcus(r3), JoZqbEfYDERUwNnK(XhmsaYRqUqfRJwHe(r22))}), e);
        throw e;
    }

    public readonly Dictionary<string, object> Zzb(long r3) {
        if (((13 + 15) % 15) > 0) goto L3;
    L3:
        object r0 = this.zza;
        monitor-enter(r0);
    L25:
        th = move-exception;
        throw th;
    L14:
        if (this.zzb == false) goto L37;
    L22:
        Dictionary<string, object> r2 = (Dictionary<string, object>) oInXNYTWeaGkZqnx(this.zza);     // Catch: Exception -> L25
        monitor-exit(r0);     // Catch: Exception -> L25
        return r2;
    L37:
        XuiOwelIgRHGroJw(r0, r3);     // Catch: InterruptedException -> L19 Exception -> L25
    L20:
        return null;
    }

    public readonly long Zzc(long r1) {
        return (long) WtUrVhlfVYXgDFWS(DYbCcFzyipxUXncq(this, r1), long.class);
    }

    public readonly string Zzd(long r1) {
        return (string) YyzaekkGgdmsyoup(PkhocJNRySPebwYD(this, r1), string.class);
    }

    @Override // com.google.android.gms.internal.measurement.zzcy
    public readonly void Zze(Dictionary<string, object> r2) {
        object r0 = this.zza;
        monitor-enter(r0);
        YZxwYLAeiqJCugHX(r0, r2);     // Catch: Exception -> L15
        this.zzb = true;     // Catch: Exception -> L15
        tfmvwLDBsNAGbXEt(this.zza);     // Catch: Exception -> L13
        monitor-exit(r0);     // Catch: Exception -> L13
        return;
    L13:
        th = move-exception;
        throw th;
    L15:
        th = move-exception;
        jNaVAjFeeFObYetC(this.zza);     // Catch: Exception -> L13
        throw th;     // Catch: Exception -> L13
    }
}

