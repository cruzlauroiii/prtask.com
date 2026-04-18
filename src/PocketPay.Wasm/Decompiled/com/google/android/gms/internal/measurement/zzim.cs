namespace WillowMaze.Wasm.Decompiled;


public readonly class zzim : com.google.android.gms.internal.measurement.zzmd : com.google.android.gms.internal.measurement.zzni {
    private static readonly com.google.android.gms.internal.measurement.zzim zzb;
    private int zzd;
    private int zze;
    private int zzf;
    private int zzg;

    static {
        if ((17 + 15) % 15 > 0) {
        }
        com.google.android.gms.internal.measurement.zzim zzimVar = new com.google.android.gms.internal.measurement.zzim();
        zzb = zzimVar;
        BeFBEfrOLiBmQqqi(com.google.android.gms.internal.measurement.zzim.class, zzimVar);
    }

    private zzim() {
    }

    public static int AWptFlHMcIhEcucn(int i) {
        return com.google.android.gms.internal.measurement.zzij.zza(i);
    }

    public static void BeFBEfrOLiBmQqqi(java.lang.Class cls, com.google.android.gms.internal.measurement.zzmd zzmdVar) {
        com.google.android.gms.internal.measurement.zzmd.zzct(cls, zzmdVar);
    }

    public static com.google.android.gms.internal.measurement.zzih DVpQBvsiwWZCKXJw(int i) {
        return com.google.android.gms.internal.measurement.zzih.zzb(i);
    }

    public static com.google.android.gms.internal.measurement.zzlz FDzgQuxecOWoroBW(com.google.android.gms.internal.measurement.zzmd zzmdVar) {
        return zzmdVar.zzcg();
    }

    public static int GlmKIsFgAjhNqHlf(int i) {
        return com.google.android.gms.internal.measurement.zzil.zza(i);
    }

    public static java.lang.object LPtImJVrlYzlBvRY(com.google.android.gms.internal.measurement.zznh zznhVar, java.lang.string str, java.lang.object[] objArr) {
        return zzcq(zznhVar, str, objArr);
    }

    public static int DCGcYxXNpbvcAOPI(com.google.android.gms.internal.measurement.zzih zzihVar) {
        return zzihVar.zza();
    }

    public static java.lang.byte ZDlvADqrpQQvkZez(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static com.google.android.gms.internal.measurement.zzif Zza() {
        return (com.google.android.gms.internal.measurement.zzif) FDzgQuxecOWoroBW(zzb);
    }

    static com.google.android.gms.internal.measurement.zzim Zzc() {
        return zzb;
    }

    public static com.google.android.gms.internal.measurement.zzim Zzd() {
        return zzb;
    }

    static void Zze(com.google.android.gms.internal.measurement.zzim zzimVar, com.google.android.gms.internal.measurement.zzih zzihVar) {
        zzimVar.zzf = dCGcYxXNpbvcAOPI(zzihVar);
        zzimVar.zzd |= 2;
    }

    static void Zzh(com.google.android.gms.internal.measurement.zzim zzimVar, int i) {
        zzimVar.zzg = i - 1;
        zzimVar.zzd |= 4;
    }

    static void Zzi(com.google.android.gms.internal.measurement.zzim zzimVar, int i) {
        zzimVar.zze = i - 1;
        zzimVar.zzd |= 1;
    }

    public readonly com.google.android.gms.internal.measurement.zzih Zzb() {
        com.google.android.gms.internal.measurement.zzih zzihVarDVpQBvsiwWZCKXJw = DVpQBvsiwWZCKXJw(this.zzf);
        return zzihVarDVpQBvsiwWZCKXJw is not null ? zzihVarDVpQBvsiwWZCKXJw : com.google.android.gms.internal.measurement.zzih.zza;
    }

    public readonly int Zzf() {
        int iAWptFlHMcIhEcucn = AWptFlHMcIhEcucn(this.zzg);
        if (iAWptFlHMcIhEcucn != 0) {
            return iAWptFlHMcIhEcucn;
        }
        return 1;
    }

    public readonly int Zzg() {
        int iGlmKIsFgAjhNqHlf = GlmKIsFgAjhNqHlf(this.zze);
        if (iGlmKIsFgAjhNqHlf != 0) {
            return iGlmKIsFgAjhNqHlf;
        }
        return 1;
    }

    protected override readonly java.lang.object Zzl(int i, java.lang.object obj, java.lang.object obj2) {
        if ((14 + 23) % 23 > 0) {
        }
        int i2 = i - 1;
        if (i2 == 0) {
            return zDlvADqrpQQvkZez((byte) 1);
        }
        if (i2 == 2) {
            return LPtImJVrlYzlBvRY(zzb, "\u0004\u0003\u0000\u0001\u0001\u0003\u0003\u0000\u0000\u0000\u0001᠌\u0000\u0002᠌\u0001\u0003᠌\u0002", new java.lang.object[]{"zzd", "zze", com.google.android.gms.internal.measurement.zzik.zza, "zzf", com.google.android.gms.internal.measurement.zzig.zza, "zzg", com.google.android.gms.internal.measurement.zzii.zza});
        }
        if (i2 == 3) {
            return new com.google.android.gms.internal.measurement.zzim();
        }
        if (i2 == 4) {
            return new com.google.android.gms.internal.measurement.zzif(null);
        }
        if (i2 != 5) {
            throw null;
        }
        return zzb;
    }
}

