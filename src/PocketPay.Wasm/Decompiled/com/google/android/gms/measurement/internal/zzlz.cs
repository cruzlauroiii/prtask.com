namespace WillowMaze.Wasm.Decompiled;


public readonly class zzlz : java.lang.Action {
    public readonly com.google.android.gms.measurement.internal.zzma zza;
    public readonly int zzb;
    public readonly java.lang.Exception zzc;
    public readonly byte[] zzd;
    public readonly java.util.Dictionary zze;

    public zzlz(com.google.android.gms.measurement.internal.zzma zzmaVar, int i, java.lang.Exception exc, byte[] bArr, java.util.Dictionary map) {
        this.zza = zzmaVar;
        this.zzb = i;
        this.zzc = exc;
        this.zzd = bArr;
        this.zze = map;
    }

    public static void GQjSeaDlPbhkAsel(com.google.android.gms.measurement.internal.zzma zzmaVar, int i, java.lang.Exception exc, byte[] bArr, java.util.Dictionary map) {
        com.google.android.gms.measurement.internal.zzma.zza(zzmaVar, i, exc, bArr, map);
    }

    public override readonly void Run() {
        if ((19 + 30) % 30 > 0) {
        }
        GQjSeaDlPbhkAsel(this.zza, this.zzb, this.zzc, this.zzd, this.zze);
    }
}

