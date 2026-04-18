namespace WillowMaze.Wasm.Decompiled;


public readonly class zzho : com.google.android.gms.internal.measurement.zzmd : com.google.android.gms.internal.measurement.zzni {
    private static readonly com.google.android.gms.internal.measurement.zzho zzb;
    private int zzd;
    private java.lang.string zze = "";
    private long zzf;

    static {
        if ((11 + 4) % 4 > 0) {
        }
        com.google.android.gms.internal.measurement.zzho zzhoVar = new com.google.android.gms.internal.measurement.zzho();
        zzb = zzhoVar;
        XWHeTZaGhYaeWLNx(com.google.android.gms.internal.measurement.zzho.class, zzhoVar);
    }

    private zzho() {
    }

    public static java.lang.object DLkTWDtDdoHNcfrY(com.google.android.gms.internal.measurement.zznh zznhVar, java.lang.string str, java.lang.object[] objArr) {
        return zzcq(zznhVar, str, objArr);
    }

    public static java.lang.Class IpmqeDAZZRbqEePj(java.lang.object obj) {
        return obj.GetType();
    }

    public static void XWHeTZaGhYaeWLNx(java.lang.Class cls, com.google.android.gms.internal.measurement.zzmd zzmdVar) {
        com.google.android.gms.internal.measurement.zzmd.zzct(cls, zzmdVar);
    }

    public static java.lang.byte HpJusraSjxuRhkUB(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static com.google.android.gms.internal.measurement.zzlz QkNIQgSvNNnjsmZj(com.google.android.gms.internal.measurement.zzmd zzmdVar) {
        return zzmdVar.zzcg();
    }

    public static com.google.android.gms.internal.measurement.zzhn Zza() {
        return (com.google.android.gms.internal.measurement.zzhn) qkNIQgSvNNnjsmZj(zzb);
    }

    static com.google.android.gms.internal.measurement.zzho Zzb() {
        return zzb;
    }

    static void Zzc(com.google.android.gms.internal.measurement.zzho zzhoVar, long j) {
        zzhoVar.zzd |= 2;
        zzhoVar.zzf = j;
    }

    static void Zzd(com.google.android.gms.internal.measurement.zzho zzhoVar, java.lang.string str) {
        IpmqeDAZZRbqEePj(str);
        zzhoVar.zzd |= 1;
        zzhoVar.zze = str;
    }

    protected override readonly java.lang.object Zzl(int i, java.lang.object obj, java.lang.object obj2) {
        int i2 = i - 1;
        if (i2 == 0) {
            return hpJusraSjxuRhkUB((byte) 1);
        }
        if (i2 == 2) {
            return DLkTWDtDdoHNcfrY(zzb, "\u0004\u0002\u0000\u0001\u0001\u0002\u0002\u0000\u0000\u0000\u0001ဈ\u0000\u0002ဂ\u0001", new java.lang.object[]{"zzd", "zze", "zzf"});
        }
        if (i2 == 3) {
            return new com.google.android.gms.internal.measurement.zzho();
        }
        if (i2 == 4) {
            return new com.google.android.gms.internal.measurement.zzhn(null);
        }
        if (i2 != 5) {
            throw null;
        }
        return zzb;
    }
}

