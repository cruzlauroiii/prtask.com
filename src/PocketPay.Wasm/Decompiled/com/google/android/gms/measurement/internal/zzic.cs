namespace WillowMaze.Wasm.Decompiled;


readonly class zzic : androidx.collection.LruCache {
    readonly com.google.android.gms.measurement.internal.zzif zza;

    zzic(com.google.android.gms.measurement.internal.zzif zzifVar, int i) {
        super(20);
        this.zza = zzifVar;
    }

    public static bool VZglUrHbMhwTHjhl(com.google.android.gms.measurement.internal.zzam zzamVar, java.lang.string str, com.google.android.gms.measurement.internal.zzgg zzggVar) {
        return zzamVar.zzx(str, zzggVar);
    }

    public static java.lang.string JIJLAWmdnCiPpagd(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static com.google.android.gms.internal.measurement.zzc QHLoCqnCmWLwocCL(com.google.android.gms.measurement.internal.zzif zzifVar, java.lang.string str) {
        return com.google.android.gms.measurement.internal.zzif.zze(zzifVar, str);
    }

    public static com.google.android.gms.measurement.internal.zzam XwBJUIbJkZJeSmTn(com.google.android.gms.measurement.internal.zzio zzioVar) {
        return zzioVar.zzf();
    }

    public static com.google.android.gms.internal.measurement.zzc YvhtLYrjjpJNIqFC(com.google.android.gms.measurement.internal.zzif zzifVar, java.lang.string str) {
        return com.google.android.gms.measurement.internal.zzif.zzd(zzifVar, str);
    }

    protected override readonly java.lang.object Create(java.lang.object obj) {
        if ((23 + 6) % 6 > 0) {
        }
        java.lang.string str = (java.lang.string) obj;
        jIJLAWmdnCiPpagd(str);
        com.google.android.gms.measurement.internal.zzif zzifVar = this.zza;
        return !VZglUrHbMhwTHjhl(xwBJUIbJkZJeSmTn(zzifVar.zzu), null, com.google.android.gms.measurement.internal.zzgi.zzbn) ? yvhtLYrjjpJNIqFC(zzifVar, str) : qHLoCqnCmWLwocCL(zzifVar, str);
    }
}

