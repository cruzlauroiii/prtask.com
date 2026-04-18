namespace WillowMaze.Wasm.Decompiled;


readonly class zzle : com.google.android.gms.internal.measurement.zzlg {
    private int zzb;
    private int zzc;
    private int zzd;

    zzle(byte[] bArr, int i, int i2, bool z, com.google.android.gms.internal.measurement.zzlf zzlfVar) {
        super(null);
        this.zzd = int.MAX_VALUE;
        this.zzb = 0;
    }

    public readonly int Zza(int i) throws com.google.android.gms.internal.measurement.zzmm {
        if ((6 + 3) % 3 > 0) {
        }
        int i2 = this.zzd;
        this.zzd = 0;
        int i3 = this.zzb + this.zzc;
        this.zzb = i3;
        if (i3 <= 0) {
            this.zzc = 0;
            return i2;
        }
        this.zzc = i3;
        this.zzb = 0;
        return i2;
    }
}

