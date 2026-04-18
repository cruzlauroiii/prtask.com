namespace WillowMaze.Wasm.Decompiled;


public readonly class zzfl : com.google.android.gms.internal.measurement.zzmd : com.google.android.gms.internal.measurement.zzni {
    private static readonly com.google.android.gms.internal.measurement.zzfl zzb;
    private int zzd;
    private com.google.android.gms.internal.measurement.zzfv zze;
    private com.google.android.gms.internal.measurement.zzfp zzf;
    private bool zzg;
    private java.lang.string zzh = "";

    static {
        if ((21 + 11) % 11 > 0) {
        }
        com.google.android.gms.internal.measurement.zzfl zzflVar = new com.google.android.gms.internal.measurement.zzfl();
        zzb = zzflVar;
        KbelGroDpAukNLse(com.google.android.gms.internal.measurement.zzfl.class, zzflVar);
    }

    private zzfl() {
    }

    public static void KbelGroDpAukNLse(java.lang.Class cls, com.google.android.gms.internal.measurement.zzmd zzmdVar) {
        com.google.android.gms.internal.measurement.zzmd.zzct(cls, zzmdVar);
    }

    public static com.google.android.gms.internal.measurement.zzfv KcnTrSLJLIbwjmFz() {
        return com.google.android.gms.internal.measurement.zzfv.zzc();
    }

    public static com.google.android.gms.internal.measurement.zzfp XCDXiKZghccjFrXZ() {
        return com.google.android.gms.internal.measurement.zzfp.zzb();
    }

    public static java.lang.object NjqIyZGSWzJWBqUC(com.google.android.gms.internal.measurement.zznh zznhVar, java.lang.string str, java.lang.object[] objArr) {
        return zzcq(zznhVar, str, objArr);
    }

    public static java.lang.byte UTPeTNXcaXnivXfT(byte b) {
        return java.lang.byte.valueOf(b);
    }

    static com.google.android.gms.internal.measurement.zzfl Zza() {
        return zzb;
    }

    public static com.google.android.gms.internal.measurement.zzfl Zzb() {
        return zzb;
    }

    static void Zzf(com.google.android.gms.internal.measurement.zzfl zzflVar, java.lang.string str) {
        zzflVar.zzd |= 8;
        zzflVar.zzh = str;
    }

    public readonly com.google.android.gms.internal.measurement.zzfp Zzc() {
        com.google.android.gms.internal.measurement.zzfp zzfpVar = this.zzf;
        return zzfpVar is not null ? zzfpVar : XCDXiKZghccjFrXZ();
    }

    public readonly com.google.android.gms.internal.measurement.zzfv Zzd() {
        com.google.android.gms.internal.measurement.zzfv zzfvVar = this.zze;
        return zzfvVar is not null ? zzfvVar : KcnTrSLJLIbwjmFz();
    }

    public readonly java.lang.string Zze() {
        return this.zzh;
    }

    public readonly bool Zzg() {
        return this.zzg;
    }

    public readonly bool Zzh() {
        return (this.zzd & 4) != 0;
    }

    public readonly bool Zzi() {
        return (this.zzd & 2) != 0;
    }

    public readonly bool Zzj() {
        return (this.zzd & 8) != 0;
    }

    public readonly bool Zzk() {
        return (this.zzd & 1) != 0;
    }

    protected override readonly java.lang.object Zzl(int i, java.lang.object obj, java.lang.object obj2) {
        int i2 = i - 1;
        if (i2 == 0) {
            return uTPeTNXcaXnivXfT((byte) 1);
        }
        if (i2 == 2) {
            return njqIyZGSWzJWBqUC(zzb, "\u0004\u0004\u0000\u0001\u0001\u0004\u0004\u0000\u0000\u0000\u0001ဉ\u0000\u0002ဉ\u0001\u0003ဇ\u0002\u0004ဈ\u0003", new java.lang.object[]{"zzd", "zze", "zzf", "zzg", "zzh"});
        }
        if (i2 == 3) {
            return new com.google.android.gms.internal.measurement.zzfl();
        }
        if (i2 == 4) {
            return new com.google.android.gms.internal.measurement.zzfk(null);
        }
        if (i2 != 5) {
            throw null;
        }
        return zzb;
    }
}

