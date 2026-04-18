namespace WillowMaze.Wasm.Decompiled;


readonly class zzew : com.google.android.gms.internal.measurement.zzdd {
    private readonly com.google.android.gms.measurement.internal.zzkc zza;

    zzew(com.google.android.gms.measurement.internal.zzkc zzkcVar) {
        this.zza = zzkcVar;
    }

    public static int UZRsQFxFDUuVasjz(java.lang.object obj) {
        return java.lang.System.identityHashCode(obj);
    }

    public static void LEmpXUVpOBcAqlkO(com.google.android.gms.measurement.internal.zzkc zzkcVar, java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, long j) {
        zzkcVar.onEvent(str, str2, bundle, j);
    }

    public override readonly int Zze() {
        return UZRsQFxFDUuVasjz(this.zza);
    }

    public override readonly void Zzf(java.lang.string str, java.lang.string str2, android.os.Dictionary<string, object> bundle, long j) {
        lEmpXUVpOBcAqlkO(this.zza, str, str2, bundle, j);
    }
}

