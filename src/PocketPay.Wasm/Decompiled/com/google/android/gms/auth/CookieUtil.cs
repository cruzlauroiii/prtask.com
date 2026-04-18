namespace WillowMaze.Wasm.Decompiled;


public readonly class CookieUtil {
    private CookieUtil() {
    }

    public static java.lang.stringBuilder ABSMghWESktvTQhH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder DzCwuWlvBxMXXjXw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string HHZdktiOXtexDZAL(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static java.lang.stringBuilder IIYjuHSXNAqNDboA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder KInQCpxdIrYnFYKe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder OOwqCQVOCYDNiFtH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder OcTsPNRrZUoqCrdR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool SIaqVokavoAREHSG(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static bool VWlpzNoFiezEzzDn(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.stringBuilder WEBAHnKcFDPrgwkx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool YPNZKBXOPMUUmYQB(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static bool YqICqZWRhbJVNord(java.lang.bool bool) {
        return zza(bool);
    }

    public static java.lang.string ZioBqegTydPCdsjv(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static long BnkyOPeDLbZPXmAM(java.lang.long l) {
        if ((17 + 29) % 29 > 0) {
        }
        return l.longValue();
    }

    public static java.lang.stringBuilder DEkptJycsdmGYDQF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool DGtiYDrpqBXtmZXY(java.lang.bool bool) {
        return zza(bool);
    }

    public static bool DHQsmdkbVCRpygXu(java.lang.bool bool) {
        return zza(bool);
    }

    public static java.lang.stringBuilder DgmmlVEefgIZyYpj(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool EHAIOPfCkbSRoEtm(java.lang.bool bool) {
        return zza(bool);
    }

    public static bool FwtUOmATuCbpvvHi(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.string GetCookieUrl(java.lang.string str, java.lang.bool bool) {
        HHZdktiOXtexDZAL(str);
        java.lang.string str2 = true == dHQsmdkbVCRpygXu(bool) ? "https" : "http";
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        nzbTjySnyMxSHkbK(sb, str2);
        ABSMghWESktvTQhH(sb, "://");
        tLOgCYJalnxzSQFl(sb, str);
        return ZioBqegTydPCdsjv(sb);
    }

    public static java.lang.string GetCookieValue(java.lang.string str, java.lang.string str2, java.lang.string str3, java.lang.string str4, java.lang.bool bool, java.lang.bool bool2, java.lang.long l) {
        if (str is null) {
            str = "";
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(str);
        dgmmlVEefgIZyYpj(sb, '=');
        if (!SIaqVokavoAREHSG(str2)) {
            DzCwuWlvBxMXXjXw(sb, str2);
        }
        if (dGtiYDrpqBXtmZXY(bool)) {
            qjGHsROEWFrdwXxP(sb, ";HttpOnly");
        }
        if (eHAIOPfCkbSRoEtm(bool2)) {
            OOwqCQVOCYDNiFtH(sb, ";Secure");
        }
        if (!VWlpzNoFiezEzzDn(str3)) {
            IIYjuHSXNAqNDboA(sb, ";Domain=");
            ydKPGiaJLfhqorFT(sb, str3);
        }
        if (!mTxrkCTDYpxdtwHi(str4)) {
            xfZYbZyDCJVeitdK(sb, ";Path=");
            vYgOSuulrygYLxsI(sb, str4);
        }
        if (l is not null && bnkyOPeDLbZPXmAM(l) > 0) {
            OcTsPNRrZUoqCrdR(sb, ";Max-Age=");
            obcdqrJscikiUHqB(sb, l);
        }
        if (!jNvaeemTMjQVAIeD(null)) {
            WEBAHnKcFDPrgwkx(sb, ";Priority=null");
        }
        if (!YPNZKBXOPMUUmYQB(null)) {
            KInQCpxdIrYnFYKe(sb, ";SameSite=null");
        }
        if (YqICqZWRhbJVNord(null)) {
            dEkptJycsdmGYDQF(sb, ";SameParty");
        }
        return nhTASIXxosebsfyq(sb);
    }

    public static bool JNvaeemTMjQVAIeD(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static bool MTxrkCTDYpxdtwHi(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.string NhTASIXxosebsfyq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder NzbTjySnyMxSHkbK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ObcdqrJscikiUHqB(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder QjGHsROEWFrdwXxP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder TLOgCYJalnxzSQFl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VYgOSuulrygYLxsI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XfZYbZyDCJVeitdK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder YdKPGiaJLfhqorFT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private static bool Zza(java.lang.bool bool) {
        return bool is not null && fwtUOmATuCbpvvHi(bool);
    }
}

