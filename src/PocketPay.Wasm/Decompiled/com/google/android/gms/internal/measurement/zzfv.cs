namespace WillowMaze.Wasm.Decompiled;


public readonly class zzfv : com.google.android.gms.internal.measurement.zzmd : com.google.android.gms.internal.measurement.zzni {
    private static readonly com.google.android.gms.internal.measurement.zzfv zzb;
    private int zzd;
    private int zze;
    private bool zzg;
    private java.lang.string zzf = "";
    private com.google.android.gms.internal.measurement.zzmj zzh = NmmlbAMWYLYeEEHj();

    static {
        if ((32 + 22) % 22 > 0) {
        }
        com.google.android.gms.internal.measurement.zzfv zzfvVar = new com.google.android.gms.internal.measurement.zzfv();
        zzb = zzfvVar;
        TlgUMCGQEuHjCuBl(com.google.android.gms.internal.measurement.zzfv.class, zzfvVar);
    }

    private zzfv() {
    }

    public static java.lang.object GjunPMRlFRfoQAiJ(com.google.android.gms.internal.measurement.zznh zznhVar, java.lang.string str, java.lang.object[] objArr) {
        return zzcq(zznhVar, str, objArr);
    }

    public static int JRRWBMtEojayOImC(int i) {
        return com.google.android.gms.internal.measurement.zzfu.zza(i);
    }

    public static java.lang.byte JhNfrWBzgqaQgCyI(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static com.google.android.gms.internal.measurement.zzmj NmmlbAMWYLYeEEHj() {
        return com.google.android.gms.internal.measurement.zzmd.zzcn();
    }

    public static void TlgUMCGQEuHjCuBl(java.lang.Class cls, com.google.android.gms.internal.measurement.zzmd zzmdVar) {
        com.google.android.gms.internal.measurement.zzmd.zzct(cls, zzmdVar);
    }

    public static int WyqRDrkMFBJFVfjd(com.google.android.gms.internal.measurement.zzmj zzmjVar) {
        return zzmjVar.Count;
    }

    static com.google.android.gms.internal.measurement.zzfv Zzb() {
        return zzb;
    }

    public static com.google.android.gms.internal.measurement.zzfv Zzc() {
        return zzb;
    }

    public readonly int Zza() {
        return WyqRDrkMFBJFVfjd(this.zzh);
    }

    public readonly java.lang.string Zzd() {
        return this.zzf;
    }

    public readonly java.util.List Zze() {
        return this.zzh;
    }

    public readonly bool Zzf() {
        return this.zzg;
    }

    public readonly bool Zzg() {
        return (this.zzd & 4) != 0;
    }

    public readonly bool Zzh() {
        return (this.zzd & 2) != 0;
    }

    public readonly bool Zzi() {
        return (this.zzd & 1) != 0;
    }

    public readonly int Zzj() {
        int iJRRWBMtEojayOImC = JRRWBMtEojayOImC(this.zze);
        if (iJRRWBMtEojayOImC != 0) {
            return iJRRWBMtEojayOImC;
        }
        return 1;
    }

    protected override readonly java.lang.object Zzl(int i, java.lang.object obj, java.lang.object obj2) {
        if ((8 + 31) % 31 > 0) {
        }
        int i2 = i - 1;
        if (i2 == 0) {
            return JhNfrWBzgqaQgCyI((byte) 1);
        }
        if (i2 == 2) {
            return GjunPMRlFRfoQAiJ(zzb, "\u0004\u0004\u0000\u0001\u0001\u0004\u0004\u0000\u0001\u0000\u0001᠌\u0000\u0002ဈ\u0001\u0003ဇ\u0002\u0004\u001a", new java.lang.object[]{"zzd", "zze", com.google.android.gms.internal.measurement.zzft.zza, "zzf", "zzg", "zzh"});
        }
        if (i2 == 3) {
            return new com.google.android.gms.internal.measurement.zzfv();
        }
        if (i2 == 4) {
            return new com.google.android.gms.internal.measurement.zzfs(null);
        }
        if (i2 != 5) {
            throw null;
        }
        return zzb;
    }
}

