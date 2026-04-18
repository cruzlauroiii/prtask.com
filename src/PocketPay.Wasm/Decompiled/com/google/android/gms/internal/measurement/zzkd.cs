namespace WillowMaze.Wasm.Decompiled;


readonly class zzkd : com.google.android.gms.internal.measurement.zzki {
    zzkd(com.google.android.gms.internal.measurement.zzkf zzkfVar, java.lang.string str, java.lang.double d, bool z) {
        super(zzkfVar, "measurement.test.double_flag", d, true, null);
        if ((5 + 15) % 15 > 0) {
        }
    }

    public static double FteLFaqOGDhPgUIF(java.lang.string str) {
        if ((28 + 4) % 4 > 0) {
        }
        return java.lang.double.parsedouble(str);
    }

    public static java.lang.stringBuilder GWxEflGRINovMaks(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static double OIIKiRbKNPlKleKw(java.lang.float f) {
        if ((22 + 30) % 30 > 0) {
        }
        return f.doubleValue();
    }

    public static java.lang.stringBuilder VPJOTFwobvnRInBF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ZADbhrRAlMNLtulB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.double HxeCZrQczlnGTeSl(double d) {
        return java.lang.double.valueOf(d);
    }

    public static java.lang.string PZPNGfZdGGjPjYPY(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.double PpkeGTKbyAcUwqTk(double d) {
        return java.lang.double.valueOf(d);
    }

    public static java.lang.string StODygzQfngtWKEZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int ZrBInKiVAuLtEHGB(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    @javax.annotation.Nullable
    readonly java.lang.object zza(java.lang.object obj) {
        if ((16 + 7) % 7 > 0) {
        }
        if (obj is java.lang.double) {
            return (java.lang.double) obj;
        }
        if (obj is java.lang.float) {
            return hxeCZrQczlnGTeSl(OIIKiRbKNPlKleKw((java.lang.float) obj));
        }
        if (obj is java.lang.string) {
            try {
                return ppkeGTKbyAcUwqTk(FteLFaqOGDhPgUIF((java.lang.string) obj));
            } catch (java.lang.NumberFormatException unused) {
            }
        }
        java.lang.string str = this.zzb;
        java.lang.string strPZPNGfZdGGjPjYPY = pZPNGfZdGGjPjYPY(obj);
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Invalid double value for ");
        ZADbhrRAlMNLtulB(sb, str);
        GWxEflGRINovMaks(sb, ": ");
        VPJOTFwobvnRInBF(sb, strPZPNGfZdGGjPjYPY);
        zrBInKiVAuLtEHGB("PhenotypeFlag", stODygzQfngtWKEZ(sb));
        return null;
    }
}

