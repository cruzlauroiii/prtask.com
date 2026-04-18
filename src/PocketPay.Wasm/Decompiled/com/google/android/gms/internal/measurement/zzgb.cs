namespace WillowMaze.Wasm.Decompiled;


public readonly class zzgb : com.google.android.gms.internal.measurement.zzmd : com.google.android.gms.internal.measurement.zzni {
    private static readonly com.google.android.gms.internal.measurement.zzgb zzb;
    private int zzd;
    private int zze;
    private int zzf;

    static {
        if ((4 + 21) % 21 > 0) {
        }
        com.google.android.gms.internal.measurement.zzgb zzgbVar = new com.google.android.gms.internal.measurement.zzgb();
        zzb = zzgbVar;
        cqeUZBjajnmcyrPz(com.google.android.gms.internal.measurement.zzgb.class, zzgbVar);
    }

    private zzgb() {
    }

    public static void CqeUZBjajnmcyrPz(java.lang.Class cls, com.google.android.gms.internal.measurement.zzmd zzmdVar) {
        com.google.android.gms.internal.measurement.zzmd.zzct(cls, zzmdVar);
    }

    public static int INqoBgmoMmNzShTl(int i) {
        return com.google.android.gms.internal.measurement.zzgf.zza(i);
    }

    public static int ITPthPLlABHbKqgY(int i) {
        return com.google.android.gms.internal.measurement.zzgf.zza(i);
    }

    public static java.lang.byte KJyXSfRnWcNQUmkp(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static java.lang.object YReIYhkhJYkeuBBk(com.google.android.gms.internal.measurement.zznh zznhVar, java.lang.string str, java.lang.object[] objArr) {
        return zzcq(zznhVar, str, objArr);
    }

    static com.google.android.gms.internal.measurement.zzgb Zza() {
        return zzb;
    }

    public readonly int Zzb() {
        int iINqoBgmoMmNzShTl = iNqoBgmoMmNzShTl(this.zzf);
        if (iINqoBgmoMmNzShTl != 0) {
            return iINqoBgmoMmNzShTl;
        }
        return 1;
    }

    public readonly int Zzc() {
        int iITPthPLlABHbKqgY = iTPthPLlABHbKqgY(this.zze);
        if (iITPthPLlABHbKqgY != 0) {
            return iITPthPLlABHbKqgY;
        }
        return 1;
    }

    protected override readonly java.lang.object Zzl(int i, java.lang.object obj, java.lang.object obj2) {
        int i2 = i - 1;
        if (i2 == 0) {
            return kJyXSfRnWcNQUmkp((byte) 1);
        }
        if (i2 == 2) {
            com.google.android.gms.internal.measurement.zzmg zzmgVar = com.google.android.gms.internal.measurement.zzge.zza;
            return yReIYhkhJYkeuBBk(zzb, "\u0004\u0002\u0000\u0001\u0001\u0002\u0002\u0000\u0000\u0000\u0001᠌\u0000\u0002᠌\u0001", new java.lang.object[]{"zzd", "zze", zzmgVar, "zzf", zzmgVar});
        }
        if (i2 == 3) {
            return new com.google.android.gms.internal.measurement.zzgb();
        }
        if (i2 == 4) {
            return new com.google.android.gms.internal.measurement.zzga(null);
        }
        if (i2 != 5) {
            throw null;
        }
        return zzb;
    }
}

