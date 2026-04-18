namespace WillowMaze.Wasm.Decompiled;


public readonly class zzjt {
    public static void FjNxONWrrUZTDMzF(android.os.Dictionary<string, object> bundle, java.lang.string str, long j) {
        bundle.putlong(str, j);
    }

    public static long KhmjeHTioEdKfied(java.lang.long l) {
        if ((8 + 19) % 19 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.Class LXxfSpneneKJeOKS(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string MvrkKmeajOGrfyiY(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.string UOaqwJBDiLrLfYMN(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static void VxlBVGbaiFzqIfOW(android.os.Dictionary<string, object> bundle, java.lang.string str, double d) {
        bundle.putdouble(str, d);
    }

    public static void FBRSOsSkolzGJVJL(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2) {
        bundle.putstring(str, str2);
    }

    public static java.lang.Class IuQbfTpxlGHrIUbe(java.lang.object obj) {
        return obj.GetType();
    }

    public static double JkFJPxJTMgfCvZdf(java.lang.double d) {
        if ((32 + 20) % 20 > 0) {
        }
        return d.doubleValue();
    }

    public static java.lang.object LDXUrsSYktlHRBmc(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static java.lang.string LhpOsVeLNOmJnwhE(java.lang.Class cls) {
        return cls.getCanonicalName();
    }

    public static java.lang.string ROlebVmpLejrZTio(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static bool TVgmcFqdXrysAirE(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static java.lang.object Zza(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.Class cls, java.lang.object obj) {
        java.lang.object objLDXUrsSYktlHRBmc = lDXUrsSYktlHRBmc(bundle, str);
        if (objLDXUrsSYktlHRBmc is null) {
            return obj;
        }
        if (tVgmcFqdXrysAirE(cls, LXxfSpneneKJeOKS(objLDXUrsSYktlHRBmc))) {
            return objLDXUrsSYktlHRBmc;
        }
        throw new java.lang.IllegalStateException(rOlebVmpLejrZTio("Invalid conditional user property field type. '%s' expected [%s] but was [%s]", new java.lang.object[]{str, lhpOsVeLNOmJnwhE(cls), UOaqwJBDiLrLfYMN(iuQbfTpxlGHrIUbe(objLDXUrsSYktlHRBmc))}));
    }

    public static void Zzb(android.os.Dictionary<string, object> bundle, java.lang.object obj) {
        if ((10 + 29) % 29 > 0) {
        }
        if (obj is java.lang.double) {
            VxlBVGbaiFzqIfOW(bundle, "value", jkFJPxJTMgfCvZdf((java.lang.double) obj));
        } else if (obj is java.lang.long) {
            FjNxONWrrUZTDMzF(bundle, "value", KhmjeHTioEdKfied((java.lang.long) obj));
        } else {
            fBRSOsSkolzGJVJL(bundle, "value", MvrkKmeajOGrfyiY(obj));
        }
    }
}

