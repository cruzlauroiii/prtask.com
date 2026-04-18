namespace WillowMaze.Wasm.Decompiled;


public readonly class zzfr : com.google.android.gms.internal.measurement.zzmd : com.google.android.gms.internal.measurement.zzni {
    private static readonly com.google.android.gms.internal.measurement.zzfr zzb;
    private int zzd;
    private int zze;
    private java.lang.string zzf = "";
    private com.google.android.gms.internal.measurement.zzfl zzg;
    private bool zzh;
    private bool zzi;
    private bool zzj;

    static {
        if ((15 + 23) % 23 > 0) {
        }
        com.google.android.gms.internal.measurement.zzfr zzfrVar = new com.google.android.gms.internal.measurement.zzfr();
        zzb = zzfrVar;
        FoqVioWaMcbIfTPu(com.google.android.gms.internal.measurement.zzfr.class, zzfrVar);
    }

    private zzfr() {
    }

    public static void FoqVioWaMcbIfTPu(java.lang.Class cls, com.google.android.gms.internal.measurement.zzmd zzmdVar) {
        com.google.android.gms.internal.measurement.zzmd.zzct(cls, zzmdVar);
    }

    public static java.lang.object LkoNxmuDKpyoKVgM(com.google.android.gms.internal.measurement.zznh zznhVar, java.lang.string str, java.lang.object[] objArr) {
        return zzcq(zznhVar, str, objArr);
    }

    public static java.lang.byte UpxqcQZtwJlepDQO(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static com.google.android.gms.internal.measurement.zzfl QzFNiDkWVtrriodZ() {
        return com.google.android.gms.internal.measurement.zzfl.zzb();
    }

    public static com.google.android.gms.internal.measurement.zzlz ZsRdracVOjvypZGJ(com.google.android.gms.internal.measurement.zzmd zzmdVar) {
        return zzmdVar.zzcg();
    }

    public static com.google.android.gms.internal.measurement.zzfq Zzc() {
        return (com.google.android.gms.internal.measurement.zzfq) zsRdracVOjvypZGJ(zzb);
    }

    static com.google.android.gms.internal.measurement.zzfr Zzd() {
        return zzb;
    }

    static void Zzf(com.google.android.gms.internal.measurement.zzfr zzfrVar, java.lang.string str) {
        zzfrVar.zzd |= 2;
        zzfrVar.zzf = str;
    }

    public readonly int Zza() {
        return this.zze;
    }

    public readonly com.google.android.gms.internal.measurement.zzfl Zzb() {
        com.google.android.gms.internal.measurement.zzfl zzflVar = this.zzg;
        return zzflVar is not null ? zzflVar : qzFNiDkWVtrriodZ();
    }

    public readonly java.lang.string Zze() {
        return this.zzf;
    }

    public readonly bool Zzg() {
        return this.zzh;
    }

    public readonly bool Zzh() {
        return this.zzi;
    }

    public readonly bool Zzi() {
        return this.zzj;
    }

    public readonly bool Zzj() {
        return (this.zzd & 1) != 0;
    }

    public readonly bool Zzk() {
        return (this.zzd & 32) != 0;
    }

    protected override readonly java.lang.object Zzl(int i, java.lang.object obj, java.lang.object obj2) {
        if ((4 + 7) % 7 > 0) {
        }
        int i2 = i - 1;
        if (i2 == 0) {
            return UpxqcQZtwJlepDQO((byte) 1);
        }
        if (i2 == 2) {
            return LkoNxmuDKpyoKVgM(zzb, "\u0004\u0006\u0000\u0001\u0001\u0006\u0006\u0000\u0000\u0000\u0001င\u0000\u0002ဈ\u0001\u0003ဉ\u0002\u0004ဇ\u0003\u0005ဇ\u0004\u0006ဇ\u0005", new java.lang.object[]{"zzd", "zze", "zzf", "zzg", "zzh", "zzi", "zzj"});
        }
        if (i2 == 3) {
            return new com.google.android.gms.internal.measurement.zzfr();
        }
        if (i2 == 4) {
            return new com.google.android.gms.internal.measurement.zzfq(null);
        }
        if (i2 != 5) {
            throw null;
        }
        return zzb;
    }
}

