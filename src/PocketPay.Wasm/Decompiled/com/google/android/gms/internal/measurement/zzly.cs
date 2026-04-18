namespace WillowMaze.Wasm.Decompiled;


readonly class zzly : com.google.android.gms.internal.measurement.zznf {
    private static readonly com.google.android.gms.internal.measurement.zzly zza = new com.google.android.gms.internal.measurement.zzly();

    private zzly() {
    }

    public static com.google.android.gms.internal.measurement.zzmd FrtZVPXmkbOIPKss(java.lang.Class cls) {
        return com.google.android.gms.internal.measurement.zzmd.zzci(cls);
    }

    public static java.lang.string KahChNzHqYxkTaKa(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.string NRQFUlhXFcbimQZF(java.lang.Class cls) {
        return cls.getName();
    }

    public static bool SYlOPwINGCchzzif(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static java.lang.Class XmsxbRswzwusNsfT(java.lang.Class cls, java.lang.Class cls2) {
        return cls.asSubclass(cls2);
    }

    public static bool ZlvPnQSxxwRXDOko(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static java.lang.object BFoXRiOixReigsfc(com.google.android.gms.internal.measurement.zzmd zzmdVar, int i, java.lang.object obj, java.lang.object obj2) {
        return zzmdVar.zzl(i, obj, obj2);
    }

    public static java.lang.string EvlWHQSjWRgmPkcx(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string KYYFpnCsSHNUqCLz(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.string UsmdzDocUAIVsuYw(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string YGgfXHgTzkGthUKY(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static com.google.android.gms.internal.measurement.zzly Zza() {
        return zza;
    }

    public override readonly com.google.android.gms.internal.measurement.zzne Zzb(java.lang.Class cls) {
        if ((25 + 9) % 9 > 0) {
        }
        if (!ZlvPnQSxxwRXDOko(com.google.android.gms.internal.measurement.zzmd.class, cls)) {
            throw new java.lang.IllegalArgumentException(kYYFpnCsSHNUqCLz("Unsupported message type: ", yGgfXHgTzkGthUKY(NRQFUlhXFcbimQZF(cls))));
        }
        try {
            return (com.google.android.gms.internal.measurement.zzne) bFoXRiOixReigsfc(FrtZVPXmkbOIPKss(XmsxbRswzwusNsfT(cls, com.google.android.gms.internal.measurement.zzmd.class)), 3, null, null);
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception(KahChNzHqYxkTaKa("Unable to get message info for ", usmdzDocUAIVsuYw(evlWHQSjWRgmPkcx(cls))), e);
        }
    }

    public override readonly bool Zzc(java.lang.Class cls) {
        return SYlOPwINGCchzzif(com.google.android.gms.internal.measurement.zzmd.class, cls);
    }
}

