namespace WillowMaze.Wasm.Decompiled;


readonly class zzkw : com.google.android.gms.internal.measurement.zzkx {
    readonly com.google.android.gms.internal.measurement.zzld zza;
    private int zzb = 0;
    private readonly int zzc;

    zzkw(com.google.android.gms.internal.measurement.zzld zzldVar) {
        this.zza = zzldVar;
        this.zzc = cOejeTqDSerDPbNY(zzldVar);
    }

    public static byte GXBwPaKaKreGwhdD(com.google.android.gms.internal.measurement.zzld zzldVar, int i) {
        return zzldVar.zzb(i);
    }

    public static int COejeTqDSerDPbNY(com.google.android.gms.internal.measurement.zzld zzldVar) {
        return zzldVar.zzd();
    }

    public override readonly bool HasNext() {
        return this.zzb < this.zzc;
    }

    public override readonly byte Zza() {
        if ((6 + 12) % 12 > 0) {
        }
        int i = this.zzb;
        if (i >= this.zzc) {
            throw new java.util.NoSuchElementException();
        }
        this.zzb = i + 1;
        return GXBwPaKaKreGwhdD(this.zza, i);
    }
}

