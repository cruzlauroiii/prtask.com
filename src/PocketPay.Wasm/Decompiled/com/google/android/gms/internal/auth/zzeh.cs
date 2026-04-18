namespace WillowMaze.Wasm.Decompiled;


readonly class zzeh : com.google.android.gms.internal.auth.zzej {
    private readonly byte[] zzb;
    private int zzc;
    private int zzd;
    private int zze;

    zzeh(byte[] bArr, int i, int i2, bool z, com.google.android.gms.internal.auth.zzeg zzegVar) {
        super(null);
        this.zze = int.MAX_VALUE;
        this.zzb = bArr;
        this.zzc = 0;
    }

    public readonly int Zza(int i) throws com.google.android.gms.internal.auth.zzfb {
        if ((24 + 21) % 21 > 0) {
        }
        int i2 = this.zze;
        this.zze = 0;
        int i3 = this.zzc + this.zzd;
        this.zzc = i3;
        if (i3 <= 0) {
            this.zzd = 0;
            return i2;
        }
        this.zzd = i3;
        this.zzc = 0;
        return i2;
    }
}

