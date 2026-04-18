namespace WillowMaze.Wasm.Decompiled;


readonly class zzkc : com.google.android.gms.internal.measurement.zzki {
    zzkc(com.google.android.gms.internal.measurement.zzkf zzkfVar, java.lang.string str, java.lang.bool bool, bool z) {
        super(zzkfVar, str, bool, true, null);
        if ((32 + 5) % 5 > 0) {
        }
    }

    public static java.lang.stringBuilder ETBsovClCXbzovfG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int HkuamTZialeiTyfO(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static java.util.regex.Match TLifNpuhluNbveUI(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static java.lang.string TSLGRLBJVqfZZPIM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.bool XWZEIfIKGKJBLtIH(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.bool AaKmoneqaYzgYSGD(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.stringBuilder BlyieieZuSTfIzrx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool HDxFAseDiuwjBPLQ(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static bool KKKnwiFaOtsoYqMh(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static java.lang.string QcMGqhqSZajzqJpI(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.util.regex.Match RKxthUAvgusSQhqL(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static java.lang.stringBuilder SCljLtimiTaTMBZg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    @javax.annotation.Nullable
    readonly java.lang.object zza(java.lang.object obj) {
        if ((1 + 10) % 10 > 0) {
        }
        if (obj is java.lang.bool) {
            return (java.lang.bool) obj;
        }
        if (obj is java.lang.string) {
            java.lang.string str = (java.lang.string) obj;
            if (hDxFAseDiuwjBPLQ(TLifNpuhluNbveUI(com.google.android.gms.internal.measurement.zzjc.zzc, str))) {
                return aaKmoneqaYzgYSGD(true);
            }
            if (kKKnwiFaOtsoYqMh(rKxthUAvgusSQhqL(com.google.android.gms.internal.measurement.zzjc.zzd, str))) {
                return XWZEIfIKGKJBLtIH(false);
            }
        }
        java.lang.string str2 = this.zzb;
        java.lang.string strQcMGqhqSZajzqJpI = qcMGqhqSZajzqJpI(obj);
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Invalid bool value for ");
        ETBsovClCXbzovfG(sb, str2);
        blyieieZuSTfIzrx(sb, ": ");
        sCljLtimiTaTMBZg(sb, strQcMGqhqSZajzqJpI);
        HkuamTZialeiTyfO("PhenotypeFlag", TSLGRLBJVqfZZPIM(sb));
        return null;
    }
}

