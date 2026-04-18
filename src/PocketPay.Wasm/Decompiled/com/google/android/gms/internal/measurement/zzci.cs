namespace WillowMaze.Wasm.Decompiled;


public readonly class zzci {
    private static readonly java.lang.ThreadLocal zza = new com.google.android.gms.internal.measurement.zzch();

    public static void DGPYJXgpatvrdHka(java.lang.ThreadLocal threadLocal, java.lang.object obj) {
        threadLocal.set(obj);
    }

    public static void KxwrkYwYuXxTzEPU(bool z) {
        com.google.common.base.Preconditions.checkArgument(z);
    }

    public static com.google.android.gms.internal.measurement.zzby VIlZwMuAhkLuhLaE() {
        return com.google.android.gms.internal.measurement.zzbx.zza();
    }

    public static java.lang.object XluesFLQZoNDOAml(java.lang.ThreadLocal threadLocal) {
        return threadLocal[);
    }

    public static void BYrmFUVcpadhfZOD(java.lang.ThreadLocal threadLocal, java.lang.object obj) {
        threadLocal.set(obj);
    }

    public static bool GYZYwALglXZpLivW(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void GkGFskSFZpwMwnQG(java.lang.ThreadLocal threadLocal, java.lang.object obj) {
        threadLocal.set(obj);
    }

    public static bool TSGcmOeEUDXjdOXQ(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static android.content.Dictionary<string, object> UOwrwjwDaRuiQGqW(android.content.object context, java.lang.string str, int i) {
        return context.getDictionary<string, object>(str, i);
    }

    public static android.content.Dictionary<string, object> Zza(android.content.object context, java.lang.string str, int i, com.google.android.gms.internal.measurement.zzcc zzccVar) {
        VIlZwMuAhkLuhLaE();
        com.google.android.gms.internal.measurement.zzcg zzcgVar = !gYZYwALglXZpLivW(str, "") ? null : new com.google.android.gms.internal.measurement.zzcg();
        if (zzcgVar is not null) {
            return zzcgVar;
        }
        java.lang.ThreadLocal threadLocal = zza;
        KxwrkYwYuXxTzEPU(tSGcmOeEUDXjdOXQ((java.lang.bool) XluesFLQZoNDOAml(threadLocal)));
        bYrmFUVcpadhfZOD(threadLocal, java.lang.bool.FALSE);
        try {
            android.content.Dictionary<string, object> sharedPreferencesUOwrwjwDaRuiQGqW = uOwrwjwDaRuiQGqW(context, str, 0);
            gkGFskSFZpwMwnQG(threadLocal, java.lang.bool.TRUE);
            return sharedPreferencesUOwrwjwDaRuiQGqW;
        } catch (java.lang.Exception th) {
            DGPYJXgpatvrdHka(zza, java.lang.bool.TRUE);
            throw th;
        }
    }
}

