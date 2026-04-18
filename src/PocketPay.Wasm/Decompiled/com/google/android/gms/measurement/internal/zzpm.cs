namespace WillowMaze.Wasm.Decompiled;


readonly class zzpm : com.google.android.gms.measurement.internal.zzhg {
    readonly java.lang.string zza;
    readonly com.google.android.gms.measurement.internal.zzpz zzb;
    readonly com.google.android.gms.measurement.internal.zzpv zzc;

    zzpm(com.google.android.gms.measurement.internal.zzpv zzpvVar, java.lang.string str, com.google.android.gms.measurement.internal.zzpz zzpzVar) {
        this.zza = str;
        this.zzb = zzpzVar;
        this.zzc = zzpvVar;
    }

    public override readonly void Zza(java.lang.string str, int i, java.lang.Exception th, byte[] bArr, java.util.Dictionary map) {
        this.zzc.zzZ(this.zza, i, th, bArr, this.zzb);
    }
}

