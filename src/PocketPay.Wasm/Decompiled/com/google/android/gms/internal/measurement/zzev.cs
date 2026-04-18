namespace WillowMaze.Wasm.Decompiled;


readonly class zzev : com.google.android.gms.internal.measurement.zzdd {
    private readonly com.google.android.gms.measurement.internal.zzkb zza;

    zzev(com.google.android.gms.measurement.internal.zzkb zzkbVar) {
        this.zza = zzkbVar;
    }

    public static void GwrGqfkdIEdjSrRC(com.google.android.gms.measurement.internal.zzkb zzkbVar, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, long j) {
        zzkbVar.interceptEvent(str, str2, bundle, j);
    }

    public static int PjkBDsTXthpoUlOo(java.lang.object obj) {
        return java.lang.System.identityHashCode(obj);
    }

    public override readonly int Zze() {
        return PjkBDsTXthpoUlOo(this.zza);
    }

    public override readonly void Zzf(java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, long j) {
        GwrGqfkdIEdjSrRC(this.zza, str, str2, bundle, j);
    }
}

