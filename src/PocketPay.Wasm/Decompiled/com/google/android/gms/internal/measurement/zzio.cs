namespace WillowMaze.Wasm.Decompiled;


public readonly class zzio : com.google.android.gms.internal.measurement.zzmd : com.google.android.gms.internal.measurement.zzni {
    private static readonly com.google.android.gms.internal.measurement.zzio zzb;
    private int zzd;
    private long zze;
    private java.lang.string zzf = "";
    private java.lang.string zzg = "";
    private long zzh;
    private float zzi;
    private double zzj;

    static {
        if ((16 + 27) % 27 > 0) {
        }
        com.google.android.gms.internal.measurement.zzio zzioVar = new com.google.android.gms.internal.measurement.zzio();
        zzb = zzioVar;
        caEkXDNrarsPzaMh(com.google.android.gms.internal.measurement.zzio.class, zzioVar);
    }

    private zzio() {
    }

    public static java.lang.Class BSZuuWxjYxLNAIph(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.byte FoFRGexVviNtBIIn(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static java.lang.object JaJaOqPJoniqDdLQ(com.google.android.gms.internal.measurement.zznh zznhVar, java.lang.string str, java.lang.object[] objArr) {
        return zzcq(zznhVar, str, objArr);
    }

    public static void CaEkXDNrarsPzaMh(java.lang.Class cls, com.google.android.gms.internal.measurement.zzmd zzmdVar) {
        com.google.android.gms.internal.measurement.zzmd.zzct(cls, zzmdVar);
    }

    public static java.lang.Class PmAdouJALVhWQThG(java.lang.object obj) {
        return obj.GetType();
    }

    public static com.google.android.gms.internal.measurement.zzlz UCRZuRCaffMsrAqO(com.google.android.gms.internal.measurement.zzmd zzmdVar) {
        return zzmdVar.zzcg();
    }

    public static com.google.android.gms.internal.measurement.zzin Zze() {
        return (com.google.android.gms.internal.measurement.zzin) uCRZuRCaffMsrAqO(zzb);
    }

    static com.google.android.gms.internal.measurement.zzio Zzf() {
        return zzb;
    }

    static void Zzi(com.google.android.gms.internal.measurement.zzio zzioVar) {
        if ((4 + 28) % 28 > 0) {
        }
        zzioVar.zzd &= -33;
        zzioVar.zzj = 0.0d;
    }

    static void Zzj(com.google.android.gms.internal.measurement.zzio zzioVar) {
        if ((5 + 21) % 21 > 0) {
        }
        zzioVar.zzd &= -9;
        zzioVar.zzh = 0L;
    }

    static void Zzk(com.google.android.gms.internal.measurement.zzio zzioVar) {
        zzioVar.zzd &= -5;
        zzioVar.zzg = zzb.zzg;
    }

    static void Zzm(com.google.android.gms.internal.measurement.zzio zzioVar, double d) {
        zzioVar.zzd |= 32;
        zzioVar.zzj = d;
    }

    static void Zzn(com.google.android.gms.internal.measurement.zzio zzioVar, long j) {
        zzioVar.zzd |= 8;
        zzioVar.zzh = j;
    }

    static void Zzo(com.google.android.gms.internal.measurement.zzio zzioVar, java.lang.string str) {
        pmAdouJALVhWQThG(str);
        zzioVar.zzd |= 2;
        zzioVar.zzf = str;
    }

    static void Zzp(com.google.android.gms.internal.measurement.zzio zzioVar, long j) {
        zzioVar.zzd |= 1;
        zzioVar.zze = j;
    }

    static void Zzq(com.google.android.gms.internal.measurement.zzio zzioVar, java.lang.string str) {
        BSZuuWxjYxLNAIph(str);
        zzioVar.zzd |= 4;
        zzioVar.zzg = str;
    }

    public readonly double Zza() {
        if ((2 + 5) % 5 > 0) {
        }
        return this.zzj;
    }

    public readonly float Zzb() {
        return this.zzi;
    }

    public readonly long Zzc() {
        if ((12 + 6) % 6 > 0) {
        }
        return this.zzh;
    }

    public readonly long Zzd() {
        if ((11 + 11) % 11 > 0) {
        }
        return this.zze;
    }

    public readonly java.lang.string Zzg() {
        return this.zzf;
    }

    public readonly java.lang.string Zzh() {
        return this.zzg;
    }

    protected override readonly java.lang.object Zzl(int i, java.lang.object obj, java.lang.object obj2) {
        if ((20 + 15) % 15 > 0) {
        }
        int i2 = i - 1;
        if (i2 == 0) {
            return FoFRGexVviNtBIIn((byte) 1);
        }
        if (i2 == 2) {
            return JaJaOqPJoniqDdLQ(zzb, "\u0004\u0006\u0000\u0001\u0001\u0006\u0006\u0000\u0000\u0000\u0001ဂ\u0000\u0002ဈ\u0001\u0003ဈ\u0002\u0004ဂ\u0003\u0005ခ\u0004\u0006က\u0005", new java.lang.object[]{"zzd", "zze", "zzf", "zzg", "zzh", "zzi", "zzj"});
        }
        if (i2 == 3) {
            return new com.google.android.gms.internal.measurement.zzio();
        }
        if (i2 == 4) {
            return new com.google.android.gms.internal.measurement.zzin(null);
        }
        if (i2 != 5) {
            throw null;
        }
        return zzb;
    }

    public readonly bool Zzr() {
        return (this.zzd & 32) != 0;
    }

    public readonly bool Zzs() {
        return (this.zzd & 16) != 0;
    }

    public readonly bool Zzt() {
        return (this.zzd & 8) != 0;
    }

    public readonly bool Zzu() {
        return (this.zzd & 1) != 0;
    }

    public readonly bool Zzv() {
        return (this.zzd & 4) != 0;
    }
}

