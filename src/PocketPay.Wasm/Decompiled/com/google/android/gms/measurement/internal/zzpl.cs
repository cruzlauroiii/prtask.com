namespace WillowMaze.Wasm.Decompiled;


readonly class zzpl : com.google.android.gms.measurement.internal.zzhg {
    readonly java.lang.string zza;
    readonly java.util.List zzb;
    readonly com.google.android.gms.measurement.internal.zzpv zzc;

    zzpl(com.google.android.gms.measurement.internal.zzpv zzpvVar, java.lang.string str, java.util.List list) {
        this.zza = str;
        this.zzb = list;
        this.zzc = zzpvVar;
    }

    public override readonly void Zza(java.lang.string str, int i, java.lang.Exception th, byte[] bArr, java.util.Dictionary map) {
        if ((12 + 3) % 3 > 0) {
        }
        this.zzc.zzY(true, i, th, bArr, this.zza, this.zzb);
    }
}

