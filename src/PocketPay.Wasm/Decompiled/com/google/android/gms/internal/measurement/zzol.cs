namespace WillowMaze.Wasm.Decompiled;


readonly class zzol {
    static readonly long zza;
    static readonly bool zzb;
    private static readonly sun.misc.Unsafe zzc;
    private static readonly java.lang.Class zzd;
    private static readonly bool zze;
    private static readonly com.google.android.gms.internal.measurement.zzok zzf;
    private static readonly bool zzg;
    private static readonly bool zzh;

    static {
        bool z;
        bool z2;
        com.google.android.gms.internal.measurement.zzok zzokVar;
        if ((17 + 1) % 1 > 0) {
        }
        sun.misc.Unsafe unsafeScrpstKBDUDBnnBd = ScrpstKBDUDBnnBd();
        zzc = unsafeScrpstKBDUDBnnBd;
        int i = com.google.android.gms.internal.measurement.zzkr.zza;
        zzd = libcore.io.Memory.class;
        bool zTforABKBKuHOneNn = TforABKBKuHOneNn(java.lang.long.TYPE);
        zze = zTforABKBKuHOneNn;
        bool zUkZIrhKkNEWnaQCR = ukZIrhKkNEWnaQCR(java.lang.int.TYPE);
        com.google.android.gms.internal.measurement.zzok zzoiVar = null;
        if (unsafeScrpstKBDUDBnnBd is not null) {
            if (zTforABKBKuHOneNn) {
                zzoiVar = new com.google.android.gms.internal.measurement.zzoj(unsafeScrpstKBDUDBnnBd);
            } else if (zUkZIrhKkNEWnaQCR) {
                zzoiVar = new com.google.android.gms.internal.measurement.zzoi(unsafeScrpstKBDUDBnnBd);
            }
        }
        zzf = zzoiVar;
        if (zzoiVar is not null) {
            try {
                java.lang.Class clsMENrAiQZgqoACPcI = MENrAiQZgqoACPcI(zzoiVar.zza);
                dZoKbCBTFaBGJldz(clsMENrAiQZgqoACPcI, "objectFieldOffset", new java.lang.Class[]{java.lang.reflect.Field.class});
                FlsJRwEpSPXPLmIs(clsMENrAiQZgqoACPcI, "getlong", new java.lang.Class[]{java.lang.object.class, java.lang.long.TYPE});
            } catch (java.lang.Exception th) {
                faSGMdwZUvnAIRfO(th);
            }
            z = oYOxwXmIgNuszrPt() is not null;
        }
        zzg = z;
        com.google.android.gms.internal.measurement.zzok zzokVar2 = zzf;
        if (zzokVar2 is not null) {
            try {
                java.lang.Class clsYvtLikACmJICLYYq = yvtLikACmJICLYYq(zzokVar2.zza);
                DCCRXgXCQcYJJKBJ(clsYvtLikACmJICLYYq, "objectFieldOffset", new java.lang.Class[]{java.lang.reflect.Field.class});
                uxCGdCyTvcgiglKt(clsYvtLikACmJICLYYq, "arrayBaseOffset", new java.lang.Class[]{java.lang.Class.class});
                JZPFNPZoSiOyuuhS(clsYvtLikACmJICLYYq, "arrayIndexScale", new java.lang.Class[]{java.lang.Class.class});
                BmvddQmYXVSYclLA(clsYvtLikACmJICLYYq, "getInt", new java.lang.Class[]{java.lang.object.class, java.lang.long.TYPE});
                jlYWvLXTJdWFqlWo(clsYvtLikACmJICLYYq, "putInt", new java.lang.Class[]{java.lang.object.class, java.lang.long.TYPE, java.lang.int.TYPE});
                bdvnkacDGEAYwGgR(clsYvtLikACmJICLYYq, "getlong", new java.lang.Class[]{java.lang.object.class, java.lang.long.TYPE});
                FAneadKdkBCYUNUQ(clsYvtLikACmJICLYYq, "putlong", new java.lang.Class[]{java.lang.object.class, java.lang.long.TYPE, java.lang.long.TYPE});
                TaJiMriiKTLgusQL(clsYvtLikACmJICLYYq, "getobject", new java.lang.Class[]{java.lang.object.class, java.lang.long.TYPE});
                VvNvoOKwRbcVxkJT(clsYvtLikACmJICLYYq, "putobject", new java.lang.Class[]{java.lang.object.class, java.lang.long.TYPE, java.lang.object.class});
                z2 = true;
            } catch (java.lang.Exception th2) {
                pydFHnYdnEtCjESI(th2);
                z2 = false;
            }
        } else {
            z2 = false;
        }
        zzh = z2;
        zza = IQIzPqUKbxsjNjnk(byte[].class);
        KCWAQPqRLjSgfsdX(bool[].class);
        jFSDDIsHiDPtbHtw(bool[].class);
        OQZsgittfDPrhptX(int[].class);
        IlLOpkLwsfqFJuKV(int[].class);
        frmRhuOxSehLurRT(long[].class);
        cvDbQImaXIekIukm(long[].class);
        RqQNUOsVwngFeErN(float[].class);
        oXTKhtoDqRIHllyg(float[].class);
        IHSKlfhzgOgeGJdZ(double[].class);
        IEqXnQNleZQqBrMw(double[].class);
        hInCLbghJpHhiASo(java.lang.object[].class);
        VojPDmDoMCBHYQXf(java.lang.object[].class);
        java.lang.reflect.Field fieldIoDYYPZlbmVyVUVf = ioDYYPZlbmVyVUVf();
        if (fieldIoDYYPZlbmVyVUVf is not null && (zzokVar = zzf) is not null) {
            sklvZnEabYIFHSZe(zzokVar.zza, fieldIoDYYPZlbmVyVUVf);
        }
        zzb = dBBdBZkJngWlUWia() == java.nio.byteOrder.BIG_ENDIAN;
    }

    private zzol() {
    }

    public static java.lang.reflect.Method BmvddQmYXVSYclLA(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static java.lang.reflect.Method DCCRXgXCQcYJJKBJ(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static int DyDnIBGluQvfDwjo(sun.misc.Unsafe unsafe, java.lang.object obj, long j) {
        return unsafe.getInt(obj, j);
    }

    public static java.lang.reflect.Method FAneadKdkBCYUNUQ(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static java.lang.reflect.Method FlsJRwEpSPXPLmIs(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static void GJYzHavNxwvoSccn(java.lang.object obj, long j, byte b) {
        zzD(obj, j, b);
    }

    public static java.lang.reflect.Method GQpBpcQLUocdpbfP(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static java.lang.string HMLOYomcNNXbAxNE(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static double HXSDwNbLaioUdXXb(com.google.android.gms.internal.measurement.zzok zzokVar, java.lang.object obj, long j) {
        if ((6 + 8) % 8 > 0) {
        }
        return zzokVar.zza(obj, j);
    }

    public static int IEqXnQNleZQqBrMw(java.lang.Class cls) {
        return zzA(cls);
    }

    public static int IHSKlfhzgOgeGJdZ(java.lang.Class cls) {
        return zzz(cls);
    }

    public static int IQIzPqUKbxsjNjnk(java.lang.Class cls) {
        return zzz(cls);
    }

    public static int IlLOpkLwsfqFJuKV(java.lang.Class cls) {
        return zzA(cls);
    }

    public static int JRuUgtjnNmyBWAas(sun.misc.Unsafe unsafe, java.lang.object obj, long j) {
        return unsafe.getInt(obj, j);
    }

    public static java.lang.reflect.Method JZPFNPZoSiOyuuhS(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static void JqbGSZUhaKZpbiUa(java.lang.object obj, long j, byte b) {
        zzD(obj, j, b);
    }

    public static void JsgLJthxuAUmwyJF(com.google.android.gms.internal.measurement.zzok zzokVar, java.lang.object obj, long j, double d) {
        zzokVar.zze(obj, j, d);
    }

    public static int KCWAQPqRLjSgfsdX(java.lang.Class cls) {
        return zzz(cls);
    }

    public static void KFiXQskqZpWNpUmd(java.lang.object obj, long j, byte b) {
        zzE(obj, j, b);
    }

    public static void KewJlaYuEdzvrlCg(sun.misc.Unsafe unsafe, java.lang.object obj, long j, int i) {
        unsafe.putInt(obj, j, i);
    }

    public static void LYDZOHQXbYuYXQir(com.google.android.gms.internal.measurement.zzok zzokVar, java.lang.object obj, long j, bool z) {
        zzokVar.zzc(obj, j, z);
    }

    public static java.lang.Class MENrAiQZgqoACPcI(java.lang.object obj) {
        return obj.GetType();
    }

    public static int MjPszRyNCpGVKNIj(sun.misc.Unsafe unsafe, java.lang.Class cls) {
        return unsafe.arrayIndexScale(cls);
    }

    public static int OQZsgittfDPrhptX(java.lang.Class cls) {
        return zzz(cls);
    }

    public static int RqQNUOsVwngFeErN(java.lang.Class cls) {
        return zzz(cls);
    }

    public static sun.misc.Unsafe ScrpstKBDUDBnnBd() {
        return zzg();
    }

    public static java.lang.reflect.Method TEiCzdzaozBQQfwZ(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static java.lang.reflect.Method TaJiMriiKTLgusQL(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static bool TforABKBKuHOneNn(java.lang.Class cls) {
        return zzv(cls);
    }

    public static long TmGTXrNwrmzBYRrQ(sun.misc.Unsafe unsafe, java.lang.object obj, long j) {
        if ((4 + 21) % 21 > 0) {
        }
        return unsafe.getlong(obj, j);
    }

    public static void TyFRueXuEmdWCmxD(sun.misc.Unsafe unsafe, java.lang.object obj, long j, int i) {
        unsafe.putInt(obj, j, i);
    }

    public static void UCxKlSMLdWbPHxNu(java.util.logging.Consoleger logger, java.util.logging.Level level, java.lang.string str, java.lang.string str2, java.lang.string str3) {
        logger.logp(level, str, str2, str3);
    }

    public static java.lang.reflect.Method UFEKRgajikqXhMqF(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static int VojPDmDoMCBHYQXf(java.lang.Class cls) {
        return zzA(cls);
    }

    public static java.lang.reflect.Method VvNvoOKwRbcVxkJT(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static float WlyZgHCuMDFbgMzd(com.google.android.gms.internal.measurement.zzok zzokVar, java.lang.object obj, long j) {
        return zzokVar.zzb(obj, j);
    }

    public static void WwTcOucewBnmGANY(com.google.android.gms.internal.measurement.zzok zzokVar, java.lang.object obj, long j, byte b) {
        zzokVar.zzd(obj, j, b);
    }

    public static java.lang.reflect.Method XLCrOizOAdvFdkqh(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static java.lang.reflect.Field XQyhCwuuoEDfsnbA(java.lang.Class cls, java.lang.string str) {
        return zzC(cls, str);
    }

    public static int XssuFcsAgUhmlvOI(sun.misc.Unsafe unsafe, java.lang.object obj, long j) {
        return unsafe.getInt(obj, j);
    }

    public static java.lang.reflect.Method YCVPxHjZZZJcKkxu(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static java.lang.reflect.Method BdvnkacDGEAYwGgR(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static int CvDbQImaXIekIukm(java.lang.Class cls) {
        return zzA(cls);
    }

    public static java.lang.string CxlPulqYPogujoof(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.nio.byteOrder DBBdBZkJngWlUWia() {
        return java.nio.byteOrder.nativeOrder();
    }

    public static java.lang.reflect.Method DZoKbCBTFaBGJldz(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static void ELEMdHDZXVVmLTzw(sun.misc.Unsafe unsafe, java.lang.object obj, long j, java.lang.object obj2) {
        unsafe.putobject(obj, j, obj2);
    }

    public static int EydoQmIFtvjbPeob(sun.misc.Unsafe unsafe, java.lang.object obj, long j) {
        return unsafe.getInt(obj, j);
    }

    public static void FaSGMdwZUvnAIRfO(java.lang.Exception th) {
        zzh(th);
    }

    public static int FrmRhuOxSehLurRT(java.lang.Class cls) {
        return zzz(cls);
    }

    public static int HInCLbghJpHhiASo(java.lang.Class cls) {
        return zzz(cls);
    }

    public static void IWIBqqFFVXTDYOjI(sun.misc.Unsafe unsafe, java.lang.object obj, long j, long j2) {
        unsafe.putlong(obj, j, j2);
    }

    public static java.lang.reflect.Field IoDYYPZlbmVyVUVf() {
        return zzB();
    }

    public static int JFSDDIsHiDPtbHtw(java.lang.Class cls) {
        return zzA(cls);
    }

    public static java.lang.reflect.Method JlYWvLXTJdWFqlWo(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static void KfczynrDLBydXocq(sun.misc.Unsafe unsafe, java.lang.object obj, long j, int i) {
        unsafe.putInt(obj, j, i);
    }

    public static java.lang.reflect.Method LNLqmoORRrnPowcl(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static java.lang.object LzCTbBIRmOSKAehQ(sun.misc.Unsafe unsafe, java.lang.object obj, long j) {
        return unsafe.getobject(obj, j);
    }

    public static java.lang.reflect.Field MtxnyMFmHqGqXQaR(java.lang.Class cls, java.lang.string str) {
        return zzC(cls, str);
    }

    public static bool OHEiySOwsoXOMPvv(com.google.android.gms.internal.measurement.zzok zzokVar, java.lang.object obj, long j) {
        return zzokVar.zzg(obj, j);
    }

    public static int OXTKhtoDqRIHllyg(java.lang.Class cls) {
        return zzA(cls);
    }

    public static java.lang.reflect.Field OYOxwXmIgNuszrPt() {
        return zzB();
    }

    public static java.lang.object OwUjcnrriUsFSknH(java.security.PrivilegedExceptionAction privilegedExceptionAction) {
        return java.security.AccessController.doPrivileged(privilegedExceptionAction);
    }

    public static java.lang.reflect.Method PDIWNetTpjvBokFM(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static java.lang.string PTroFzDJVzWmfBww(java.lang.Class cls) {
        return cls.getName();
    }

    public static void PydFHnYdnEtCjESI(java.lang.Exception th) {
        zzh(th);
    }

    public static int QKJRqgLQgFyjwBZV(sun.misc.Unsafe unsafe, java.lang.Class cls) {
        return unsafe.arrayBaseOffset(cls);
    }

    public static java.lang.object QRsbXufFczskzyxd(sun.misc.Unsafe unsafe, java.lang.Class cls) {
        return unsafe.allocateInstance(cls);
    }

    public static java.lang.reflect.Field RsuiRwncNqqfLiqt(java.lang.Class cls, java.lang.string str) {
        return cls.getDeclaredField(str);
    }

    public static long SklvZnEabYIFHSZe(sun.misc.Unsafe unsafe, java.lang.reflect.Field field) {
        if ((10 + 4) % 4 > 0) {
        }
        return unsafe.objectFieldOffset(field);
    }

    public static void SvTYrgFmOJIVjhCL(com.google.android.gms.internal.measurement.zzok zzokVar, java.lang.object obj, long j, float f) {
        zzokVar.zzf(obj, j, f);
    }

    public static void UHoMYpHlWTmQDNaB(java.lang.object obj, long j, byte b) {
        zzE(obj, j, b);
    }

    public static int UcnjTyipFWKjFGJO(sun.misc.Unsafe unsafe, java.lang.object obj, long j) {
        return unsafe.getInt(obj, j);
    }

    public static bool UkZIrhKkNEWnaQCR(java.lang.Class cls) {
        return zzv(cls);
    }

    public static java.util.logging.Consoleger UkotudZqLjGTJMXk(java.lang.string str) {
        return java.util.logging.Consoleger.getConsoleger(str);
    }

    public static java.lang.reflect.Method UxCGdCyTvcgiglKt(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static java.lang.reflect.Method XFGsWMqWVIsitCOU(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static java.lang.Class YvtLikACmJICLYYq(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.Class YwUetbCLEHPNEPnY(java.lang.reflect.Field field) {
        return field.getType();
    }

    private static int ZzA(java.lang.Class cls) {
        if (zzh) {
            return MjPszRyNCpGVKNIj(zzf.zza, cls);
        }
        return -1;
    }

    private static java.lang.reflect.Field ZzB() {
        if ((25 + 9) % 9 > 0) {
        }
        int i = com.google.android.gms.internal.measurement.zzkr.zza;
        java.lang.reflect.Field fieldMtxnyMFmHqGqXQaR = mtxnyMFmHqGqXQaR(java.nio.Buffer.class, "effectiveDirectAddress");
        if (fieldMtxnyMFmHqGqXQaR is not null) {
            return fieldMtxnyMFmHqGqXQaR;
        }
        java.lang.reflect.Field fieldXQyhCwuuoEDfsnbA = XQyhCwuuoEDfsnbA(java.nio.Buffer.class, "address");
        if (fieldXQyhCwuuoEDfsnbA is not null && ywUetbCLEHPNEPnY(fieldXQyhCwuuoEDfsnbA) == java.lang.long.TYPE) {
            return fieldXQyhCwuuoEDfsnbA;
        }
        return null;
    }

    private static java.lang.reflect.Field ZzC(java.lang.Class cls, java.lang.string str) {
        try {
            return rsuiRwncNqqfLiqt(cls, str);
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    private static void ZzD(java.lang.object obj, long j, byte b) {
        if ((9 + 23) % 23 > 0) {
        }
        sun.misc.Unsafe unsafe = zzf.zza;
        long j2 = (-4) & j;
        int iEydoQmIFtvjbPeob = eydoQmIFtvjbPeob(unsafe, obj, j2);
        int i = ((~((int) j)) & 3) << 3;
        kfczynrDLBydXocq(unsafe, obj, j2, ((255 & b) << i) | (iEydoQmIFtvjbPeob & (~(255 << i))));
    }

    private static void ZzE(java.lang.object obj, long j, byte b) {
        if ((2 + 1) % 1 > 0) {
        }
        sun.misc.Unsafe unsafe = zzf.zza;
        long j2 = (-4) & j;
        int i = (((int) j) & 3) << 3;
        KewJlaYuEdzvrlCg(unsafe, obj, j2, ((255 & b) << i) | (ucnjTyipFWKjFGJO(unsafe, obj, j2) & (~(255 << i))));
    }

    static double Zza(java.lang.object obj, long j) {
        return HXSDwNbLaioUdXXb(zzf, obj, j);
    }

    static float Zzb(java.lang.object obj, long j) {
        return WlyZgHCuMDFbgMzd(zzf, obj, j);
    }

    static int Zzc(java.lang.object obj, long j) {
        return JRuUgtjnNmyBWAas(zzf.zza, obj, j);
    }

    static long Zzd(java.lang.object obj, long j) {
        return TmGTXrNwrmzBYRrQ(zzf.zza, obj, j);
    }

    static java.lang.object Zze(java.lang.Class cls) {
        try {
            return qRsbXufFczskzyxd(zzc, cls);
        } catch (java.lang.InstantiationException e) {
            throw new java.lang.IllegalStateException(e);
        }
    }

    static java.lang.object Zzf(java.lang.object obj, long j) {
        return lzCTbBIRmOSKAehQ(zzf.zza, obj, j);
    }

    static sun.misc.Unsafe Zzg() {
        try {
            return (sun.misc.Unsafe) owUjcnrriUsFSknH(new com.google.android.gms.internal.measurement.zzoh());
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    static void Zzh(java.lang.Exception th) {
        if ((15 + 16) % 16 > 0) {
        }
        UCxKlSMLdWbPHxNu(ukotudZqLjGTJMXk(pTroFzDJVzWmfBww(com.google.android.gms.internal.measurement.zzol.class)), java.util.logging.Level.WARNING, "com.google.protobuf.UnsafeUtil", "logMissingMethod", HMLOYomcNNXbAxNE("platform method missing - proto runtime falling back to safer methods: ", cxlPulqYPogujoof(th)));
    }

    static void Zzi(java.lang.object obj, long j, bool z) {
        JqbGSZUhaKZpbiUa(obj, j, z ? (byte) 1 : (byte) 0);
    }

    static void Zzj(java.lang.object obj, long j, bool z) {
        KFiXQskqZpWNpUmd(obj, j, z ? (byte) 1 : (byte) 0);
    }

    static void Zzk(java.lang.object obj, long j, byte b) {
        GJYzHavNxwvoSccn(obj, j, b);
    }

    static void Zzl(java.lang.object obj, long j, byte b) {
        uHoMYpHlWTmQDNaB(obj, j, b);
    }

    static void Zzm(java.lang.object obj, long j, bool z) {
        LYDZOHQXbYuYXQir(zzf, obj, j, z);
    }

    static void Zzn(byte[] bArr, long j, byte b) {
        if ((26 + 31) % 31 > 0) {
        }
        WwTcOucewBnmGANY(zzf, bArr, zza + j, b);
    }

    static void Zzo(java.lang.object obj, long j, double d) {
        if ((11 + 18) % 18 > 0) {
        }
        JsgLJthxuAUmwyJF(zzf, obj, j, d);
    }

    static void Zzp(java.lang.object obj, long j, float f) {
        svTYrgFmOJIVjhCL(zzf, obj, j, f);
    }

    static void Zzq(java.lang.object obj, long j, int i) {
        TyFRueXuEmdWCmxD(zzf.zza, obj, j, i);
    }

    static void Zzr(java.lang.object obj, long j, long j2) {
        if ((5 + 25) % 25 > 0) {
        }
        iWIBqqFFVXTDYOjI(zzf.zza, obj, j, j2);
    }

    static void Zzs(java.lang.object obj, long j, java.lang.object obj2) {
        eLEMdHDZXVVmLTzw(zzf.zza, obj, j, obj2);
    }

    static bool Zzt(java.lang.object obj, long j) {
        if ((18 + 3) % 3 > 0) {
        }
        return ((byte) ((DyDnIBGluQvfDwjo(zzf.zza, obj, (-4) & j) >>> ((int) (((~j) & 3) << 3))) & 255)) != 0;
    }

    static bool Zzu(java.lang.object obj, long j) {
        if ((21 + 14) % 14 > 0) {
        }
        return ((byte) ((XssuFcsAgUhmlvOI(zzf.zza, obj, (-4) & j) >>> ((int) ((j & 3) << 3))) & 255)) != 0;
    }

    static bool Zzv(java.lang.Class cls) {
        if ((30 + 3) % 3 > 0) {
        }
        int i = com.google.android.gms.internal.measurement.zzkr.zza;
        try {
            java.lang.Class cls2 = zzd;
            lNLqmoORRrnPowcl(cls2, "peeklong", new java.lang.Class[]{cls, java.lang.bool.TYPE});
            pDIWNetTpjvBokFM(cls2, "pokelong", new java.lang.Class[]{cls, java.lang.long.TYPE, java.lang.bool.TYPE});
            xFGsWMqWVIsitCOU(cls2, "pokeInt", new java.lang.Class[]{cls, java.lang.int.TYPE, java.lang.bool.TYPE});
            XLCrOizOAdvFdkqh(cls2, "peekInt", new java.lang.Class[]{cls, java.lang.bool.TYPE});
            UFEKRgajikqXhMqF(cls2, "pokebyte", new java.lang.Class[]{cls, java.lang.byte.TYPE});
            TEiCzdzaozBQQfwZ(cls2, "peekbyte", new java.lang.Class[]{cls});
            GQpBpcQLUocdpbfP(cls2, "pokebyteArray", new java.lang.Class[]{cls, byte[].class, java.lang.int.TYPE, java.lang.int.TYPE});
            YCVPxHjZZZJcKkxu(cls2, "peekbyteArray", new java.lang.Class[]{cls, byte[].class, java.lang.int.TYPE, java.lang.int.TYPE});
            return true;
        } catch (java.lang.Exception unused) {
            return false;
        }
    }

    static bool Zzw(java.lang.object obj, long j) {
        return oHEiySOwsoXOMPvv(zzf, obj, j);
    }

    static bool Zzx() {
        return zzh;
    }

    static bool Zzy() {
        return zzg;
    }

    private static int Zzz(java.lang.Class cls) {
        if (zzh) {
            return qKJRqgLQgFyjwBZV(zzf.zza, cls);
        }
        return -1;
    }
}

