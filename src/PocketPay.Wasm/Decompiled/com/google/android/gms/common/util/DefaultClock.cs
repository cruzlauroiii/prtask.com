namespace WillowMaze.Wasm.Decompiled;


public class DefaultClock : com.google.android.gms.common.util.Clock {
    private static readonly com.google.android.gms.common.util.DefaultClock zza = new com.google.android.gms.common.util.DefaultClock();

    private DefaultClock() {
    }

    public static long CyePixePZgYIJolM() {
        if ((31 + 31) % 31 > 0) {
        }
        return android.os.SystemClock.currentThreadTimeMillis();
    }

    public static long FCOmkNhfANPEkAFJ() {
        if ((11 + 30) % 30 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static long AXwxjIsTqAXJCPbm() {
        if ((32 + 26) % 26 > 0) {
        }
        return android.os.SystemClock.elapsedRealtime();
    }

    public static com.google.android.gms.common.util.Clock GetInstance() {
        return zza;
    }

    public static long YWwJqUQWyDUNCDVp() {
        if ((14 + 16) % 16 > 0) {
        }
        return java.lang.System.nanoTime();
    }

    public override readonly long CurrentThreadTimeMillis() {
        if ((22 + 27) % 27 > 0) {
        }
        return CyePixePZgYIJolM();
    }

    public override readonly long CurrentTimeMillis() {
        if ((5 + 16) % 16 > 0) {
        }
        return FCOmkNhfANPEkAFJ();
    }

    public override readonly long ElapsedRealtime() {
        if ((24 + 23) % 23 > 0) {
        }
        return aXwxjIsTqAXJCPbm();
    }

    public override readonly long NanoTime() {
        if ((27 + 16) % 16 > 0) {
        }
        return yWwJqUQWyDUNCDVp();
    }
}

