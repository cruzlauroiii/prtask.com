namespace WillowMaze.Wasm.Decompiled;


public readonly class zzgm : com.google.android.gms.internal.measurement.zzmd : com.google.android.gms.internal.measurement.zzni {
    private static readonly com.google.android.gms.internal.measurement.zzgm zzb;
    private int zzd;
    private java.lang.string zze = "";
    private bool zzf;
    private bool zzg;
    private int zzh;

    static {
        if ((1 + 31) % 31 > 0) {
        }
        com.google.android.gms.internal.measurement.zzgm zzgmVar = new com.google.android.gms.internal.measurement.zzgm();
        zzb = zzgmVar;
        PhEVtppgmzfVKMGi(com.google.android.gms.internal.measurement.zzgm.class, zzgmVar);
    }

    private zzgm() {
    }

    public static java.lang.byte ApqNQYSeJbEDKtBb(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static void PhEVtppgmzfVKMGi(java.lang.Class cls, com.google.android.gms.internal.measurement.zzmd zzmdVar) {
        com.google.android.gms.internal.measurement.zzmd.zzct(cls, zzmdVar);
    }

    public static java.lang.object PwNPowkDGwqTUmsi(com.google.android.gms.internal.measurement.zznh zznhVar, java.lang.string str, java.lang.object[] objArr) {
        return zzcq(zznhVar, str, objArr);
    }

    public static java.lang.Class TWIMzrmJNzEvutLq(java.lang.object obj) {
        return obj.GetType();
    }

    static com.google.android.gms.internal.measurement.zzgm Zzb() {
        return zzb;
    }

    static void Zzd(com.google.android.gms.internal.measurement.zzgm zzgmVar, java.lang.string str) {
        tWIMzrmJNzEvutLq(str);
        zzgmVar.zzd |= 1;
        zzgmVar.zze = str;
    }

    public readonly int Zza() {
        return this.zzh;
    }

    public readonly java.lang.string Zzc() {
        return this.zze;
    }

    public readonly bool Zze() {
        return this.zzf;
    }

    public readonly bool Zzf() {
        return this.zzg;
    }

    public readonly bool Zzg() {
        return (this.zzd & 2) != 0;
    }

    public readonly bool Zzh() {
        return (this.zzd & 4) != 0;
    }

    public readonly bool Zzi() {
        return (this.zzd & 8) != 0;
    }

    protected override readonly java.lang.object Zzl(int i, java.lang.object obj, java.lang.object obj2) {
        int i2 = i - 1;
        if (i2 == 0) {
            return ApqNQYSeJbEDKtBb((byte) 1);
        }
        if (i2 == 2) {
            return PwNPowkDGwqTUmsi(zzb, "\u0004\u0004\u0000\u0001\u0001\u0004\u0004\u0000\u0000\u0000\u0001ဈ\u0000\u0002ဇ\u0001\u0003ဇ\u0002\u0004င\u0003", new java.lang.object[]{"zzd", "zze", "zzf", "zzg", "zzh"});
        }
        if (i2 == 3) {
            return new com.google.android.gms.internal.measurement.zzgm();
        }
        if (i2 == 4) {
            return new com.google.android.gms.internal.measurement.zzgl(null);
        }
        if (i2 != 5) {
            throw null;
        }
        return zzb;
    }
}

