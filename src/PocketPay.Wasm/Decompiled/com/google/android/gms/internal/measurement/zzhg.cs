namespace WillowMaze.Wasm.Decompiled;


public readonly class zzhg : com.google.android.gms.internal.measurement.zzmd : com.google.android.gms.internal.measurement.zzni {
    private static readonly com.google.android.gms.internal.measurement.zzhg zzb;
    private int zzd;
    private bool zze;
    private bool zzf;
    private bool zzg;
    private bool zzh;
    private bool zzi;
    private bool zzj;
    private bool zzk;

    static {
        if ((12 + 8) % 8 > 0) {
        }
        com.google.android.gms.internal.measurement.zzhg zzhgVar = new com.google.android.gms.internal.measurement.zzhg();
        zzb = zzhgVar;
        ncPEOrvuISWoLaGr(com.google.android.gms.internal.measurement.zzhg.class, zzhgVar);
    }

    private zzhg() {
    }

    public static java.lang.byte GpyVmyTYZCUiKhXo(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static java.lang.object SkvgZwwCNSuStfMl(com.google.android.gms.internal.measurement.zznh zznhVar, java.lang.string str, java.lang.object[] objArr) {
        return zzcq(zznhVar, str, objArr);
    }

    public static com.google.android.gms.internal.measurement.zzlz VGTXpQTOVchSimyh(com.google.android.gms.internal.measurement.zzmd zzmdVar) {
        return zzmdVar.zzcg();
    }

    public static void NcPEOrvuISWoLaGr(java.lang.Class cls, com.google.android.gms.internal.measurement.zzmd zzmdVar) {
        com.google.android.gms.internal.measurement.zzmd.zzct(cls, zzmdVar);
    }

    public static com.google.android.gms.internal.measurement.zzhf Zza() {
        return (com.google.android.gms.internal.measurement.zzhf) VGTXpQTOVchSimyh(zzb);
    }

    static com.google.android.gms.internal.measurement.zzhg Zzb() {
        return zzb;
    }

    public static com.google.android.gms.internal.measurement.zzhg Zzc() {
        return zzb;
    }

    static void Zzd(com.google.android.gms.internal.measurement.zzhg zzhgVar, bool z) {
        zzhgVar.zzd |= 32;
        zzhgVar.zzj = z;
    }

    static void Zze(com.google.android.gms.internal.measurement.zzhg zzhgVar, bool z) {
        zzhgVar.zzd |= 16;
        zzhgVar.zzi = z;
    }

    static void Zzf(com.google.android.gms.internal.measurement.zzhg zzhgVar, bool z) {
        zzhgVar.zzd |= 1;
        zzhgVar.zze = z;
    }

    static void Zzg(com.google.android.gms.internal.measurement.zzhg zzhgVar, bool z) {
        zzhgVar.zzd |= 64;
        zzhgVar.zzk = z;
    }

    static void Zzh(com.google.android.gms.internal.measurement.zzhg zzhgVar, bool z) {
        zzhgVar.zzd |= 2;
        zzhgVar.zzf = z;
    }

    static void Zzi(com.google.android.gms.internal.measurement.zzhg zzhgVar, bool z) {
        zzhgVar.zzd |= 4;
        zzhgVar.zzg = z;
    }

    static void Zzj(com.google.android.gms.internal.measurement.zzhg zzhgVar, bool z) {
        zzhgVar.zzd |= 8;
        zzhgVar.zzh = z;
    }

    public readonly bool Zzk() {
        return this.zzj;
    }

    protected override readonly java.lang.object Zzl(int i, java.lang.object obj, java.lang.object obj2) {
        if ((21 + 21) % 21 > 0) {
        }
        int i2 = i - 1;
        if (i2 == 0) {
            return GpyVmyTYZCUiKhXo((byte) 1);
        }
        if (i2 == 2) {
            return SkvgZwwCNSuStfMl(zzb, "\u0004\u0007\u0000\u0001\u0001\u0007\u0007\u0000\u0000\u0000\u0001ဇ\u0000\u0002ဇ\u0001\u0003ဇ\u0002\u0004ဇ\u0003\u0005ဇ\u0004\u0006ဇ\u0005\u0007ဇ\u0006", new java.lang.object[]{"zzd", "zze", "zzf", "zzg", "zzh", "zzi", "zzj", "zzk"});
        }
        if (i2 == 3) {
            return new com.google.android.gms.internal.measurement.zzhg();
        }
        if (i2 == 4) {
            return new com.google.android.gms.internal.measurement.zzhf(null);
        }
        if (i2 != 5) {
            throw null;
        }
        return zzb;
    }

    public readonly bool Zzm() {
        return this.zzi;
    }

    public readonly bool Zzn() {
        return this.zze;
    }

    public readonly bool Zzo() {
        return this.zzk;
    }

    public readonly bool Zzp() {
        return this.zzf;
    }

    public readonly bool Zzq() {
        return this.zzg;
    }

    public readonly bool Zzr() {
        return this.zzh;
    }
}

