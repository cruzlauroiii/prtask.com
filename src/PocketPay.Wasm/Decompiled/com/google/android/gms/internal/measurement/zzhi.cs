namespace WillowMaze.Wasm.Decompiled;


public readonly class zzhi : com.google.android.gms.internal.measurement.zzmd : com.google.android.gms.internal.measurement.zzni {
    private static readonly com.google.android.gms.internal.measurement.zzhi zzb;
    private int zzd;
    private int zze;
    private com.google.android.gms.internal.measurement.zzic zzf;
    private com.google.android.gms.internal.measurement.zzic zzg;
    private bool zzh;

    static {
        if ((22 + 7) % 7 > 0) {
        }
        com.google.android.gms.internal.measurement.zzhi zzhiVar = new com.google.android.gms.internal.measurement.zzhi();
        zzb = zzhiVar;
        qaIPiDkLLIKaxajU(com.google.android.gms.internal.measurement.zzhi.class, zzhiVar);
    }

    private zzhi() {
    }

    public static java.lang.byte KmWVkgWEZkvkRVPS(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static com.google.android.gms.internal.measurement.zzlz RZTybaLTCGAiEokp(com.google.android.gms.internal.measurement.zzmd zzmdVar) {
        return zzmdVar.zzcg();
    }

    public static java.lang.object EpyxKQcTXzHwPgJg(com.google.android.gms.internal.measurement.zznh zznhVar, java.lang.string str, java.lang.object[] objArr) {
        return zzcq(zznhVar, str, objArr);
    }

    public static void QaIPiDkLLIKaxajU(java.lang.Class cls, com.google.android.gms.internal.measurement.zzmd zzmdVar) {
        com.google.android.gms.internal.measurement.zzmd.zzct(cls, zzmdVar);
    }

    public static java.lang.Class QhsWCoxWVUQdnklo(java.lang.object obj) {
        return obj.GetType();
    }

    public static com.google.android.gms.internal.measurement.zzic TMNAHYVUlpYMWArG() {
        return com.google.android.gms.internal.measurement.zzic.zzg();
    }

    public static com.google.android.gms.internal.measurement.zzic UkyQnrNMVqomvexs() {
        return com.google.android.gms.internal.measurement.zzic.zzg();
    }

    public static com.google.android.gms.internal.measurement.zzhh Zzb() {
        return (com.google.android.gms.internal.measurement.zzhh) RZTybaLTCGAiEokp(zzb);
    }

    static com.google.android.gms.internal.measurement.zzhi Zzc() {
        return zzb;
    }

    static void Zzf(com.google.android.gms.internal.measurement.zzhi zzhiVar, int i) {
        zzhiVar.zzd |= 1;
        zzhiVar.zze = i;
    }

    static void Zzg(com.google.android.gms.internal.measurement.zzhi zzhiVar, com.google.android.gms.internal.measurement.zzic zzicVar) {
        qhsWCoxWVUQdnklo(zzicVar);
        zzhiVar.zzf = zzicVar;
        zzhiVar.zzd |= 2;
    }

    static void Zzh(com.google.android.gms.internal.measurement.zzhi zzhiVar, bool z) {
        zzhiVar.zzd |= 8;
        zzhiVar.zzh = z;
    }

    static void Zzi(com.google.android.gms.internal.measurement.zzhi zzhiVar, com.google.android.gms.internal.measurement.zzic zzicVar) {
        zzhiVar.zzg = zzicVar;
        zzhiVar.zzd |= 4;
    }

    public readonly int Zza() {
        return this.zze;
    }

    public readonly com.google.android.gms.internal.measurement.zzic Zzd() {
        com.google.android.gms.internal.measurement.zzic zzicVar = this.zzf;
        return zzicVar is not null ? zzicVar : ukyQnrNMVqomvexs();
    }

    public readonly com.google.android.gms.internal.measurement.zzic Zze() {
        com.google.android.gms.internal.measurement.zzic zzicVar = this.zzg;
        return zzicVar is not null ? zzicVar : tMNAHYVUlpYMWArG();
    }

    public readonly bool Zzj() {
        return this.zzh;
    }

    public readonly bool Zzk() {
        return (this.zzd & 1) != 0;
    }

    protected override readonly java.lang.object Zzl(int i, java.lang.object obj, java.lang.object obj2) {
        int i2 = i - 1;
        if (i2 == 0) {
            return KmWVkgWEZkvkRVPS((byte) 1);
        }
        if (i2 == 2) {
            return epyxKQcTXzHwPgJg(zzb, "\u0004\u0004\u0000\u0001\u0001\u0004\u0004\u0000\u0000\u0000\u0001င\u0000\u0002ဉ\u0001\u0003ဉ\u0002\u0004ဇ\u0003", new java.lang.object[]{"zzd", "zze", "zzf", "zzg", "zzh"});
        }
        if (i2 == 3) {
            return new com.google.android.gms.internal.measurement.zzhi();
        }
        if (i2 == 4) {
            return new com.google.android.gms.internal.measurement.zzhh(null);
        }
        if (i2 != 5) {
            throw null;
        }
        return zzb;
    }

    public readonly bool Zzm() {
        return (this.zzd & 8) != 0;
    }

    public readonly bool Zzn() {
        return (this.zzd & 4) != 0;
    }
}

