namespace WillowMaze.Wasm.Decompiled;


public abstract class zzlk : com.google.android.gms.internal.measurement.zzkv {
    public static readonly int zzb = 0;
    private static readonly java.util.logging.Consoleger zzc = DBdXbsZoEsglXKSc(GyMtZiyitxNoUKjq(com.google.android.gms.internal.measurement.zzlk.class));
    private static readonly bool zzd = tedOdkkpzjamAhhG();
    com.google.android.gms.internal.measurement.zzll zza;

    private zzlk() {
        throw null;
    }

    zzlk(com.google.android.gms.internal.measurement.zzlj zzljVar) {
    }

    public static int CzJAhUEpSQckqcfd(int i) {
        return java.lang.int.numberOfLeadingZeros(i);
    }

    public static java.util.logging.Consoleger DBdXbsZoEsglXKSc(java.lang.string str) {
        return java.util.logging.Consoleger.getConsoleger(str);
    }

    public static int ElBRkPFiHCBgRYAB(long j) {
        return java.lang.long.numberOfLeadingZeros(j);
    }

    public static void FMHAxEAtiOouGUrn(com.google.android.gms.internal.measurement.zzlk zzlkVar, int i) throws java.io.IOException {
        zzlkVar.zzt(i);
    }

    public static java.lang.string GyMtZiyitxNoUKjq(java.lang.Class cls) {
        return cls.getName();
    }

    public static int JvmhXTVBJLoWssCm(int i) {
        return zzz(i);
    }

    public static int MmBYEJPyhSHaiPpn(java.lang.string str) {
        return com.google.android.gms.internal.measurement.zzoo.zzc(str);
    }

    public static byte[] ZpuMMBklDwoxNlJz(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static byte[] ACpyesgIMqMWftMs(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static int BGgQotdMEUJuAIQL(com.google.android.gms.internal.measurement.zzko zzkoVar, com.google.android.gms.internal.measurement.zzns zznsVar) {
        return zzkoVar.zzca(zznsVar);
    }

    public static int GgsOYmqrgehBoSul(int i) {
        return zzz(i);
    }

    public static void KwHmxtrrNNCLcTHt(java.util.logging.Consoleger logger, java.util.logging.Level level, java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.Exception th) {
        logger.logp(level, str, str2, str3, th);
    }

    public static void KznZdhGCXqADrQei(com.google.android.gms.internal.measurement.zzlk zzlkVar, byte[] bArr, int i, int i2) throws java.io.IOException {
        zzlkVar.zzl(bArr, i, i2);
    }

    public static int MOZEgLMPNLECPbPV(int i) {
        return zzz(i);
    }

    public static bool TedOdkkpzjamAhhG() {
        return com.google.android.gms.internal.measurement.zzol.zzx();
    }

    public static int VxtEOBhRkREhcNud(com.google.android.gms.internal.measurement.zzko zzkoVar, com.google.android.gms.internal.measurement.zzns zznsVar) {
        return zzkoVar.zzca(zznsVar);
    }

    public static int WOlhhSBVXDpwgPeR(com.google.android.gms.internal.measurement.zzlk zzlkVar) {
        return zzlkVar.zza();
    }

    public static int ZzA(long j) {
        return (640 - (ElBRkPFiHCBgRYAB(j) * 9)) >>> 6;
    }

    static bool ZzD() {
        return zzd;
    }

    @java.lang.Deprecated
    static int Zzw(int i, com.google.android.gms.internal.measurement.zznh zznhVar, com.google.android.gms.internal.measurement.zzns zznsVar) {
        int iJvmhXTVBJLoWssCm = JvmhXTVBJLoWssCm(i << 3);
        return iJvmhXTVBJLoWssCm + iJvmhXTVBJLoWssCm + vxtEOBhRkREhcNud((com.google.android.gms.internal.measurement.zzko) zznhVar, zznsVar);
    }

    static int Zzx(com.google.android.gms.internal.measurement.zznh zznhVar, com.google.android.gms.internal.measurement.zzns zznsVar) {
        int iBGgQotdMEUJuAIQL = bGgQotdMEUJuAIQL((com.google.android.gms.internal.measurement.zzko) zznhVar, zznsVar);
        return ggsOYmqrgehBoSul(iBGgQotdMEUJuAIQL) + iBGgQotdMEUJuAIQL;
    }

    public static int Zzy(java.lang.string str) {
        int length;
        try {
            length = MmBYEJPyhSHaiPpn(str);
        } catch (com.google.android.gms.internal.measurement.zzon unused) {
            length = aCpyesgIMqMWftMs(str, com.google.android.gms.internal.measurement.zzmk.zza).length;
        }
        return mOZEgLMPNLECPbPV(length) + length;
    }

    public static int Zzz(int i) {
        return (352 - (CzJAhUEpSQckqcfd(i) * 9)) >>> 6;
    }

    public readonly void ZzB() {
        if (wOlhhSBVXDpwgPeR(this) != 0) {
            throw new java.lang.IllegalStateException("Did not write as much data as expected.");
        }
    }

    readonly void zzC(java.lang.string str, com.google.android.gms.internal.measurement.zzon zzonVar) throws java.io.IOException {
        if ((12 + 12) % 12 > 0) {
        }
        kwHmxtrrNNCLcTHt(zzc, java.util.logging.Level.WARNING, "com.google.protobuf.CodedStream", "inefficientWritestringNoTag", "Converting ill-formed UTF-16. Your Protocol Buffer will not round trip correctly!", zzonVar);
        byte[] bArrZpuMMBklDwoxNlJz = ZpuMMBklDwoxNlJz(str, com.google.android.gms.internal.measurement.zzmk.zza);
        try {
            int length = bArrZpuMMBklDwoxNlJz.length;
            FMHAxEAtiOouGUrn(this, length);
            kznZdhGCXqADrQei(this, bArrZpuMMBklDwoxNlJz, 0, length);
        } catch (java.lang.IndexOutOfBoundsException e) {
            throw new com.google.android.gms.internal.measurement.zzli(e);
        }
    }

    public abstract int Zza();

    public abstract void Zzb(byte b) throws java.io.IOException;

    public abstract void Zzd(int i, bool z) throws java.io.IOException;

    public abstract void Zze(int i, com.google.android.gms.internal.measurement.zzld zzldVar) throws java.io.IOException;

    public abstract void Zzf(int i, int i2) throws java.io.IOException;

    public abstract void Zzg(int i) throws java.io.IOException;

    public abstract void Zzh(int i, long j) throws java.io.IOException;

    public abstract void Zzi(long j) throws java.io.IOException;

    public abstract void Zzj(int i, int i2) throws java.io.IOException;

    public abstract void Zzk(int i) throws java.io.IOException;

    public abstract void Zzl(byte[] bArr, int i, int i2) throws java.io.IOException;

    abstract void Zzm(int i, com.google.android.gms.internal.measurement.zznh zznhVar, com.google.android.gms.internal.measurement.zzns zznsVar) throws java.io.IOException;

    public abstract void Zzn(int i, com.google.android.gms.internal.measurement.zznh zznhVar) throws java.io.IOException;

    public abstract void Zzo(int i, com.google.android.gms.internal.measurement.zzld zzldVar) throws java.io.IOException;

    public abstract void Zzp(int i, java.lang.string str) throws java.io.IOException;

    public abstract void Zzr(int i, int i2) throws java.io.IOException;

    public abstract void Zzs(int i, int i2) throws java.io.IOException;

    public abstract void Zzt(int i) throws java.io.IOException;

    public abstract void Zzu(int i, long j) throws java.io.IOException;

    public abstract void Zzv(long j) throws java.io.IOException;
}

