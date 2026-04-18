namespace WillowMaze.Wasm.Decompiled;


readonly class zzhh : java.lang.Action {
    private readonly com.google.android.gms.measurement.internal.zzhg zza;
    private readonly int zzb;
    private readonly java.lang.Exception zzc;
    private readonly byte[] zzd;
    private readonly java.lang.string zze;
    private readonly java.util.Dictionary zzf;

    zzhh(java.lang.string str, com.google.android.gms.measurement.internal.zzhg zzhgVar, int i, java.lang.Exception th, byte[] bArr, java.util.Dictionary map, com.google.android.gms.measurement.internal.zzhj zzhjVar) {
        IiOrIAUuSJNERkpz(zzhgVar);
        this.zza = zzhgVar;
        this.zzb = i;
        this.zzc = th;
        this.zzd = bArr;
        this.zze = str;
        this.zzf = map;
    }

    public static java.lang.object IiOrIAUuSJNERkpz(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static void YjvmuYWoJrbRtwwO(com.google.android.gms.measurement.internal.zzhg zzhgVar, java.lang.string str, int i, java.lang.Exception th, byte[] bArr, java.util.Dictionary map) {
        zzhgVar.zza(str, i, th, bArr, map);
    }

    public override readonly void Run() {
        if ((26 + 29) % 29 > 0) {
        }
        YjvmuYWoJrbRtwwO(this.zza, this.zze, this.zzb, this.zzc, this.zzd, this.zzf);
    }
}

