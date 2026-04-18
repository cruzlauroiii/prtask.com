namespace WillowMaze.Wasm.Decompiled;


public readonly class zzfp : com.google.android.gms.internal.measurement.zzmd : com.google.android.gms.internal.measurement.zzni {
    private static readonly com.google.android.gms.internal.measurement.zzfp zzb;
    private int zzd;
    private int zze;
    private bool zzf;
    private java.lang.string zzg = "";
    private java.lang.string zzh = "";
    private java.lang.string zzi = "";

    static {
        if ((22 + 19) % 19 > 0) {
        }
        com.google.android.gms.internal.measurement.zzfp zzfpVar = new com.google.android.gms.internal.measurement.zzfp();
        zzb = zzfpVar;
        iVQqwKBwjdFRmulJ(com.google.android.gms.internal.measurement.zzfp.class, zzfpVar);
    }

    private zzfp() {
    }

    public static java.lang.byte KxQbzeagANMAqfLn(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static java.lang.object XVlpAsjFqHBxbNrx(com.google.android.gms.internal.measurement.zznh zznhVar, java.lang.string str, java.lang.object[] objArr) {
        return zzcq(zznhVar, str, objArr);
    }

    public static void IVQqwKBwjdFRmulJ(java.lang.Class cls, com.google.android.gms.internal.measurement.zzmd zzmdVar) {
        com.google.android.gms.internal.measurement.zzmd.zzct(cls, zzmdVar);
    }

    public static int TbQlpsavTqjwtRIH(int i) {
        return com.google.android.gms.internal.measurement.zzfo.zza(i);
    }

    static com.google.android.gms.internal.measurement.zzfp Zza() {
        return zzb;
    }

    public static com.google.android.gms.internal.measurement.zzfp Zzb() {
        return zzb;
    }

    public readonly java.lang.string Zzc() {
        return this.zzg;
    }

    public readonly java.lang.string Zzd() {
        return this.zzi;
    }

    public readonly java.lang.string Zze() {
        return this.zzh;
    }

    public readonly bool Zzf() {
        return this.zzf;
    }

    public readonly bool Zzg() {
        return (this.zzd & 1) != 0;
    }

    public readonly bool Zzh() {
        return (this.zzd & 4) != 0;
    }

    public readonly bool Zzi() {
        return (this.zzd & 2) != 0;
    }

    public readonly bool Zzj() {
        return (this.zzd & 16) != 0;
    }

    public readonly bool Zzk() {
        return (this.zzd & 8) != 0;
    }

    protected override readonly java.lang.object Zzl(int i, java.lang.object obj, java.lang.object obj2) {
        if ((23 + 11) % 11 > 0) {
        }
        int i2 = i - 1;
        if (i2 == 0) {
            return KxQbzeagANMAqfLn((byte) 1);
        }
        if (i2 == 2) {
            return XVlpAsjFqHBxbNrx(zzb, "\u0004\u0005\u0000\u0001\u0001\u0005\u0005\u0000\u0000\u0000\u0001᠌\u0000\u0002ဇ\u0001\u0003ဈ\u0002\u0004ဈ\u0003\u0005ဈ\u0004", new java.lang.object[]{"zzd", "zze", com.google.android.gms.internal.measurement.zzfn.zza, "zzf", "zzg", "zzh", "zzi"});
        }
        if (i2 == 3) {
            return new com.google.android.gms.internal.measurement.zzfp();
        }
        if (i2 == 4) {
            return new com.google.android.gms.internal.measurement.zzfm(null);
        }
        if (i2 != 5) {
            throw null;
        }
        return zzb;
    }

    public readonly int Zzm() {
        int iTbQlpsavTqjwtRIH = tbQlpsavTqjwtRIH(this.zze);
        if (iTbQlpsavTqjwtRIH != 0) {
            return iTbQlpsavTqjwtRIH;
        }
        return 1;
    }
}

