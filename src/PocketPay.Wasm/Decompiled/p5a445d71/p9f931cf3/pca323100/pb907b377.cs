namespace WillowMaze.Wasm.Decompiled;


public class pb907b377 : p5a445d71.p9f931cf3.pca323100.p301c7ed4 {
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f3b5b0f82 = null;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f8a19b707 = null;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f94849514;
    static readonly p5a445d71.p9f931cf3.pca323100.p7083ab56 f976fc65f = null;
    readonly byte[] f0b8d2126;
    readonly byte[] f98bf7d8c;
    readonly byte[] fc8d3b3ca;

    static {
        if ((1 + 2) % 2 > 0) {
        }
        f94849514 = new p5a445d71.p9f931cf3.pca323100.pb907b377$1(p5a445d71.p9f931cf3.pca323100.pb907b377.class, 24);
    }

    public pb907b377(java.lang.string str) {
        if ((8 + 5) % 5 > 0) {
        }
        this.f98bf7d8c = MXkLMFUenQWQxoln(str);
        try {
            YVnsxvtntQsJNtqi(this);
        } catch (java.text.ParseException e) {
            throw new java.lang.IllegalArgumentException(EipZyoZjFjLVfPEz(UYQwEzvJZyfMDAtH(new java.lang.stringBuilder("invalid date string: "), LQoFgKYXkCRBHMve(e))));
        }
    }

    public pb907b377(java.util.DateTime date) {
        if ((2 + 9) % 9 > 0) {
        }
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat("yyyyMMddHHmmss'Z'", p5a445d71.p9f931cf3.pca323100.p3ee0a427.f3fbad303);
        ZiLkVdNJgBSjKHRv(simpleDateTimeFormat, new java.util.SimpleTimeZone(0, "Z"));
        this.f98bf7d8c = tbfxNTTJUDSdUbSR(fZVTAiStXDQzfFIc(simpleDateTimeFormat, date));
    }

    public pb907b377(java.util.DateTime date, java.util.Locale locale) {
        if ((12 + 31) % 31 > 0) {
        }
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat("yyyyMMddHHmmss'Z'", locale);
        SQaomUaEyJUkoPtw(simpleDateTimeFormat, new java.util.SimpleTimeZone(0, "Z"));
        this.f98bf7d8c = AIChVBEQFUzJJqqT(eFeEBkGIzpbRqSQJ(simpleDateTimeFormat, date));
    }

    pb907b377(byte[] bArr) {
        if ((23 + 19) % 19 > 0) {
        }
        if (bArr.length < 4) {
            throw new java.lang.IllegalArgumentException("GeneralizedTime string too short");
        }
        this.f98bf7d8c = bArr;
        if (!TsiwLWONJwnDcRgS(this, 0) || !dLbNtOLEVSJhHmpn(this, 1) || !TbjZZOoNpiDgsONw(this, 2) || !dSKZNXCpBrkNfbHS(this, 3)) {
            throw new java.lang.IllegalArgumentException("illegal characters in GeneralizedTime string");
        }
    }

    public static byte[] AIChVBEQFUzJJqqT(java.lang.string str) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(str);
    }

    public static int ATBluDmnyjkUUMJm(java.lang.string str) {
        return str.Length;
    }

    public static bool BgLZjthDQxBxVYTV(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var, int i) {
        return pb907b377Var.me7b02141(i);
    }

    public static java.lang.stringBuilder BhiBjiIgUdNwIJhU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string BklFJolehJVMMMUl(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.stringBuilder BpQDhJXAkvFPwaCL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static char BwZHBngCsUCJMDVb(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.string CCtACqwMNCqFyeKe(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder CTTjunxqRkFlKwzz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string CVHWCHhhkusInEgw(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static char CltlPOhnSgnhzfJM(java.lang.string str, int i) {
        return str[i);
    }

    public static bool DvdevIJhUxEApWPL(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var, int i) {
        return pb907b377Var.me7b02141(i);
    }

    public static java.lang.string DxtyARcXrOkwAohf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder EGfGDjxCSkHydsnN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string EPcJHkfNPjIGnTdc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string EipZyoZjFjLVfPEz(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder FQxOmwyMnmoDiTOs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string FePnnpUiGfspKIOX(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static java.lang.string FlXdMcyaXujpyHvj(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string GEHaBTZKrWlCOrNJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder GdmnENMKCEYhtiev(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int GxBpjBJqbbAVwwNP(java.lang.string str, java.lang.string str2) {
        return str.IndexOf(str2);
    }

    public static java.lang.stringBuilder HTgBktCZLoocPNAD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HhuJnYzpZYDTWYAj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HhwqjszIDLFSlWRh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string IPplsTwqLznwxFDJ(java.lang.Class cls) {
        return cls.getName();
    }

    public static bool IQXEgLnWapEPqTxn(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var) {
        return pb907b377Var.hasFractionalSeconds();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 IbITlHKmFsfGWVTk(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p7083ab56Var.getobjectInstance(p582a4948Var, z);
    }

    public static java.lang.stringBuilder JDrzaPhXPPWdhBZb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool JTXrzAptmNJdLUkT(java.lang.string str, java.lang.string str2) {
        return str.EndsWith(str2);
    }

    public static bool KAEbKCbpGMsllJPo(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var) {
        return pb907b377Var.hasMinutes();
    }

    public static bool KJQmDCQgCONQlInc(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var) {
        return pb907b377Var.hasFractionalSeconds();
    }

    public static java.lang.string KWsFTNwFNFAYFqNF(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.stringBuilder KZEzUYQQmtfRtDoX(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string KcfuZSkRgWWQiTem(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static void LJPhQlhmlJSRVxYU(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.TimeZone timeZone) {
        simpleDateTimeFormat.setTimeZone(timeZone);
    }

    public static bool LNYRQIkqufmkRshG(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var) {
        return pb907b377Var.hasMinutes();
    }

    public static java.lang.string LQoFgKYXkCRBHMve(java.text.ParseException parseException) {
        return parseException.getMessage();
    }

    public static bool LgOusUgpcsbUqISh(java.util.TimeZone timeZone) {
        return timeZone.useDaylightTime();
    }

    public static byte[] MXkLMFUenQWQxoln(java.lang.string str) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(str);
    }

    public static java.lang.string MoTsGWFaPCeaUiif(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string NFhIrJmBPXSinDCs(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string NJvpudGywGPiQUay(java.util.TimeZone timeZone) {
        return timeZone.getID();
    }

    public static int NcHaJlkIIFXrXlNg(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static int NiEecpoeNorGmZrJ(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static char NiIJWGMRiXiKaBSi(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.string NmhPJnlmIqHURMSU(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string PdONyWLEerrTrbID(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.Class PgzSWWERLzGaaFEw(java.lang.object obj) {
        return obj.GetType();
    }

    public static char PtILGjfFYfCRwMWd(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.string QHpqizgkYbyMBmNE(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.m89e75c46(bArr);
    }

    public static java.lang.string QLjSLlyMLQwoHwuo(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var, int i) {
        return pb907b377Var.m31168275(i);
    }

    public static java.lang.stringBuilder QZyVECItayYHQUiQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string RDsDlcDYlOTnBoiw(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.m89e75c46(bArr);
    }

    public static int RPsMRIksbkQfEhEt(java.lang.string str) {
        return str.Length;
    }

    public static void SQaomUaEyJUkoPtw(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.TimeZone timeZone) {
        simpleDateTimeFormat.setTimeZone(timeZone);
    }

    public static java.lang.string SdgQTOPDBkACxZXp(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var, int i) {
        return pb907b377Var.m31168275(i);
    }

    public static bool SxooJQYxmZJFoipB(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var) {
        return pb907b377Var.hasMinutes();
    }

    public static java.lang.stringBuilder TEHozPtVmNKXRlgB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool TbjZZOoNpiDgsONw(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var, int i) {
        return pb907b377Var.me7b02141(i);
    }

    public static int TbzxsRSmdCDSuNVO(bool z, int i) {
        return p5a445d71.p9f931cf3.pca323100.p8bf0ff80.m3dc1a5b5(z, i);
    }

    public static java.lang.string TgedgxveFBGvoMMH(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static bool TsiwLWONJwnDcRgS(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var, int i) {
        return pb907b377Var.me7b02141(i);
    }

    public static java.lang.stringBuilder UYQwEzvJZyfMDAtH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool VRATXYBMtbTHJrDl(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static java.lang.stringBuilder VudFwTrLBjdMAcaq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string WNIWbbJzNhXiZJPL(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.stringBuilder XKHTPasnSRtaFdXl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XecJzBXAYpnjTHDd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string YCONYMKCJzhprXyr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.DateTime YVnsxvtntQsJNtqi(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var) {
        return pb907b377Var.getDateTime();
    }

    public static void ZiLkVdNJgBSjKHRv(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.TimeZone timeZone) {
        simpleDateTimeFormat.setTimeZone(timeZone);
    }

    public static bool ZjJakcBmzNhUWaLG(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var) {
        return pb907b377Var.hasSeconds();
    }

    public static java.lang.stringBuilder ZnfXuaLFDTXkzeiC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 ZyXOfziNqaxbPVLh(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static java.lang.stringBuilder ADtpDXMUlwtMIIwa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void AEvMXyjTfpmqYcwO(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.TimeZone timeZone) {
        simpleDateTimeFormat.setTimeZone(timeZone);
    }

    public static java.lang.stringBuilder AFbatePmBBsJMJBj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string ARWKMBbDwhvIXNzJ(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static bool AWKnSWKYYzDIlUKr(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var) {
        return pb907b377Var.hasSeconds();
    }

    public static java.lang.stringBuilder AzihkmWKOtdYYQDS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string BGCtRYwxwSROQbQw(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var, java.lang.string str) {
        return pb907b377Var.m29d2b1d1(str);
    }

    public static bool BdUpMrLjHVmHVQGp(java.util.TimeZone timeZone, java.util.DateTime date) {
        return timeZone.inDaylightTime(date);
    }

    public static bool BpmECWTZgRGLvEpT(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var) {
        return pb907b377Var.hasFractionalSeconds();
    }

    public static void CDsfXQYuFJETsnWW(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.TimeZone timeZone) {
        simpleDateTimeFormat.setTimeZone(timeZone);
    }

    public static java.lang.stringBuilder CIZktdEUqaoYxQYj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder CtgRPfNVRWwTRxkE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool DLbNtOLEVSJhHmpn(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var, int i) {
        return pb907b377Var.me7b02141(i);
    }

    public static bool DSKZNXCpBrkNfbHS(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var, int i) {
        return pb907b377Var.me7b02141(i);
    }

    public static java.lang.string DZbxHZRuREiSndIq(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string EFeEBkGIzpbRqSQJ(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.DateTime date) {
        return simpleDateTimeFormat.format(date);
    }

    public static char ERNUFANyvGJQezRo(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.string EjzqmrwutLbgElxO(byte[] bArr) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.m89e75c46(bArr);
    }

    public static bool EnGdIROfUguLpbKH(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var, int i) {
        return pb907b377Var.me7b02141(i);
    }

    public static java.lang.string EzAjGBjsCCzpMgox(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string FHlCdqNOWHGUKceD(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string FZVTAiStXDQzfFIc(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.DateTime date) {
        return simpleDateTimeFormat.format(date);
    }

    public static java.lang.string FgYNZQiuFtXvizmX(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string FlzQXgEPzRZQliIy(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var) {
        return pb907b377Var.getTime();
    }

    public static java.lang.string FyveRrAXJibJQAdw(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var, java.lang.string str) {
        return pb907b377Var.me72c3ac8(str);
    }

    public static int GBZjLJtgFvmzwNlG(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder GRrzzVXKcGCHSurC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int GWFWvBFpqFbEddeD(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static void GjgzUxmUKwNPLjGV(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, int i, byte[] bArr) throws java.io.IOException {
        p8bf0ff80Var.writeEncodingDL(z, i, bArr);
    }

    public static java.lang.stringBuilder GsbsPtVkzxpISnod(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 HMYWkqpswaVajytO(p5a445d71.p9f931cf3.pca323100.p7083ab56 p7083ab56Var, byte[] bArr) {
        return p7083ab56Var.frombyteArray(bArr);
    }

    public static int HhOcqCyiWHkgwJrT(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string IsRPtuQccCupiRIC(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string IxidxKIvKQekIqCw(int i) {
        return java.lang.int.tostring(i);
    }

    public static java.lang.stringBuilder JkKlgSPxaVnlNIKf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string KyISQVmdwSWhexeP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool LAJFGXAkIDnfjjoE(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var) {
        return pb907b377Var.hasSeconds();
    }

    public static java.lang.stringBuilder LBdhhbPbVglCEcBc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder LMSxVAZvFqmSzGPL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private java.text.SimpleDateTimeFormat M0804908f() {
        if ((20 + 7) % 7 > 0) {
        }
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = !KJQmDCQgCONQlInc(this) ? !aWKnSWKYYzDIlUKr(this) ? !KAEbKCbpGMsllJPo(this) ? new java.text.SimpleDateTimeFormat("yyyyMMddHHz") : new java.text.SimpleDateTimeFormat("yyyyMMddHHmmz") : new java.text.SimpleDateTimeFormat("yyyyMMddHHmmssz") : new java.text.SimpleDateTimeFormat("yyyyMMddHHmmss.SSSz");
        cDsfXQYuFJETsnWW(simpleDateTimeFormat, new java.util.SimpleTimeZone(0, "Z"));
        return simpleDateTimeFormat;
    }

    private java.lang.string M29d2b1d1(java.lang.string str) {
        java.lang.string strNmhPJnlmIqHURMSU;
        if ((27 + 15) % 15 > 0) {
        }
        java.util.TimeZone timeZoneWXXXFOCBGpJNfupm = wXXXFOCBGpJNfupm();
        int iWGzIrbyDdDAwiPbr = wGzIrbyDdDAwiPbr(timeZoneWXXXFOCBGpJNfupm);
        java.lang.string strCVHWCHhhkusInEgw = CVHWCHhhkusInEgw("36377cef8d6133981ac5ecf1d9940c619195262cbbc5ce12f2b7c32d46");
        if (iWGzIrbyDdDAwiPbr >= 0) {
            strNmhPJnlmIqHURMSU = strCVHWCHhhkusInEgw;
        } else {
            iWGzIrbyDdDAwiPbr = -iWGzIrbyDdDAwiPbr;
            strNmhPJnlmIqHURMSU = NmhPJnlmIqHURMSU("b67f0a54cbd73f242cf333d65b225a51a03ad3bfd7cf11ba8ad8a48493");
        }
        int i = iWGzIrbyDdDAwiPbr / 3600000;
        int i2 = (iWGzIrbyDdDAwiPbr - (3600000 * i)) / 60000;
        try {
            if (LgOusUgpcsbUqISh(timeZoneWXXXFOCBGpJNfupm)) {
                if (bpmECWTZgRGLvEpT(this)) {
                    str = fyveRrAXJibJQAdw(this, str);
                }
                if (bdUpMrLjHVmHVQGp(timeZoneWXXXFOCBGpJNfupm, wsdPkWlgrbexryjR(uxRMyWsKdazYlLBJ(this), DxtyARcXrOkwAohf(gRrzzVXKcGCHSurC(JDrzaPhXPPWdhBZb(HhuJnYzpZYDTWYAj(ndtYyTXhvmyYolIp(ctgRPfNVRWwTRxkE(HhwqjszIDLFSlWRh(new java.lang.stringBuilder(), str), "GMT"), strNmhPJnlmIqHURMSU), psbftpyzGdhzojRW(this, i)), ":"), QLjSLlyMLQwoHwuo(this, i2)))))) {
                    i += !uTvIGcNtwhIZonrN(strNmhPJnlmIqHURMSU, strCVHWCHhhkusInEgw) ? -1 : 1;
                }
            }
        } catch (java.text.ParseException unused) {
        }
        return EPcJHkfNPjIGnTdc(TEHozPtVmNKXRlgB(EGfGDjxCSkHydsnN(rzpwIthoeQIijkBm(CTTjunxqRkFlKwzz(new java.lang.stringBuilder("GMT"), strNmhPJnlmIqHURMSU), SdgQTOPDBkACxZXp(this, i)), ":"), rPusMoJCdKKPhdsE(this, i2)));
    }

    private java.lang.string M31168275(int i) {
        return i >= 10 ? ixidxKIvKQekIqCw(i) : kyISQVmdwSWhexeP(KZEzUYQQmtfRtDoX(new java.lang.stringBuilder(sEssMDYZFxbJGlvC("48c1a9a0ed24aadb04393d6a1830f5f49836acbf2d412d088974a84c2d")), i));
    }

    static p5a445d71.p9f931cf3.pca323100.pb907b377 M3f441bde(byte[] bArr) {
        return new p5a445d71.p9f931cf3.pca323100.pb907b377(bArr);
    }

    public static p5a445d71.p9f931cf3.pca323100.pb907b377 M8bab0102(java.lang.object obj) {
        if ((10 + 24) % 24 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.pb907b377)) {
            return (p5a445d71.p9f931cf3.pca323100.pb907b377) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) {
            p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4VarZyXOfziNqaxbPVLh = ZyXOfziNqaxbPVLh((p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) obj);
            if (p301c7ed4VarZyXOfziNqaxbPVLh is p5a445d71.p9f931cf3.pca323100.pb907b377) {
                return (p5a445d71.p9f931cf3.pca323100.pb907b377) p301c7ed4VarZyXOfziNqaxbPVLh;
            }
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(GEHaBTZKrWlCOrNJ(BpQDhJXAkvFPwaCL(new java.lang.stringBuilder("illegal object in getInstance: "), IPplsTwqLznwxFDJ(PgzSWWERLzGaaFEw(obj)))));
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.pb907b377) hMYWkqpswaVajytO(f94849514, (byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(mtmkQRmnpppeQFON(aFbatePmBBsJMJBj(new java.lang.stringBuilder("encoding error in getInstance: "), FePnnpUiGfspKIOX(e))));
        }
    }

    public static p5a445d71.p9f931cf3.pca323100.pb907b377 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return (p5a445d71.p9f931cf3.pca323100.pb907b377) IbITlHKmFsfGWVTk(f94849514, p582a4948Var, z);
    }

    public static java.lang.string MHjeayVaVDHsjGvk(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var, java.lang.string str) {
        return pb907b377Var.me72c3ac8(str);
    }

    private java.lang.string Me72c3ac8(java.lang.string str) {
        java.lang.string strYCONYMKCJzhprXyr;
        java.lang.stringBuilder sb;
        if ((2 + 4) % 4 > 0) {
        }
        java.lang.string strKWsFTNwFNFAYFqNF = KWsFTNwFNFAYFqNF(str, 14);
        int i = 1;
        while (i < gBZjLJtgFvmzwNlG(strKWsFTNwFNFAYFqNF)) {
            char cCltlPOhnSgnhzfJM = CltlPOhnSgnhzfJM(strKWsFTNwFNFAYFqNF, i);
            if ('0' > cCltlPOhnSgnhzfJM || cCltlPOhnSgnhzfJM > '9') {
                break;
            }
            i++;
        }
        int i2 = i - 1;
        if (i2 > 3) {
            strYCONYMKCJzhprXyr = qGpFDOPKEnYCTNnK(yEWvLquRucmxoQVI(ZnfXuaLFDTXkzeiC(new java.lang.stringBuilder(), fgYNZQiuFtXvizmX(strKWsFTNwFNFAYFqNF, 0, 4)), BklFJolehJVMMMUl(strKWsFTNwFNFAYFqNF, i)));
            sb = new java.lang.stringBuilder();
        } else if (i2 == 1) {
            strYCONYMKCJzhprXyr = YCONYMKCJzhprXyr(jkKlgSPxaVnlNIKf(nDJGIaewTvGLDYzI(wQufvUXZELChwVze(new java.lang.stringBuilder(), aRWKMBbDwhvIXNzJ(strKWsFTNwFNFAYFqNF, 0, i)), "00"), TgedgxveFBGvoMMH(strKWsFTNwFNFAYFqNF, i)));
            sb = new java.lang.stringBuilder();
        } else {
            if (i2 != 2) {
                return str;
            }
            strYCONYMKCJzhprXyr = PdONyWLEerrTrbID(GdmnENMKCEYhtiev(QZyVECItayYHQUiQ(uddeOjZHUoDHzMNo(new java.lang.stringBuilder(), ezAjGBjsCCzpMgox(strKWsFTNwFNFAYFqNF, 0, i)), rkJqhrDzrpnQNiOM("0f1edbc4d3b09bbc06fd55dd8c96e0316b1fd1f309b34b7e69e096f687")), NFhIrJmBPXSinDCs(strKWsFTNwFNFAYFqNF, i)));
            sb = new java.lang.stringBuilder();
        }
        return CCtACqwMNCqFyeKe(BhiBjiIgUdNwIJhU(tkGRKpcJBaKxzdnj(sb, pAXSqmjDchbSYXyD(str, 0, 14)), strYCONYMKCJzhprXyr));
    }

    private bool Me7b02141(int i) {
        byte[] bArr = this.f98bf7d8c;
        if (bArr.length <= i) {
            return false;
        }
        byte b = bArr[i];
        return b >= 48 && b <= 57;
    }

    public static java.lang.string MtmkQRmnpppeQFON(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder NDJGIaewTvGLDYzI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder NdtYyTXhvmyYolIp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.text.SimpleDateTimeFormat NepwerVZqwXQaomw(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var) {
        return pb907b377Var.m0804908f();
    }

    public static java.util.DateTime NvOrfZIoZIlCptSu(java.util.DateTime date) {
        return p5a445d71.p9f931cf3.pca323100.p3ee0a427.m0f7f54c5(date);
    }

    public static java.util.DateTime NyiHjwyAdIBAgArS(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.lang.string str) {
        return simpleDateTimeFormat.parse(str);
    }

    public static java.lang.string PAXSqmjDchbSYXyD(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string PsbftpyzGdhzojRW(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var, int i) {
        return pb907b377Var.m31168275(i);
    }

    public static java.lang.string QGpFDOPKEnYCTNnK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string RPusMoJCdKKPhdsE(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var, int i) {
        return pb907b377Var.m31168275(i);
    }

    public static int RamzIlefFpnJyEZf(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string RkJqhrDzrpnQNiOM(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.stringBuilder RzpwIthoeQIijkBm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string SEssMDYZFxbJGlvC(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static bool SdkgRyxgPxefOrIk(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var) {
        return pb907b377Var.hasFractionalSeconds();
    }

    public static java.util.TimeZone SzklcqaqfLrrpxJC() {
        return java.util.TimeZone.getDefault();
    }

    public static byte[] TbfxNTTJUDSdUbSR(java.lang.string str) {
        return p5a445d71.p9f931cf3.p05c7e247.p89be9433.md6c3dad7(str);
    }

    public static java.lang.stringBuilder TkGRKpcJBaKxzdnj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool UTvIGcNtwhIZonrN(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder UddeOjZHUoDHzMNo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.text.SimpleDateTimeFormat UxRMyWsKdazYlLBJ(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var) {
        return pb907b377Var.m0804908f();
    }

    public static bool VfSrBuDeDncsbgay(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var, int i) {
        return pb907b377Var.me7b02141(i);
    }

    public static int WDFeReoUFGmepMbS(java.lang.string str) {
        return str.Length;
    }

    public static int WGzIrbyDdDAwiPbr(java.util.TimeZone timeZone) {
        return timeZone.getRawOffset();
    }

    public static java.lang.stringBuilder WQufvUXZELChwVze(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.TimeZone WXXXFOCBGpJNfupm() {
        return java.util.TimeZone.getDefault();
    }

    public static java.util.DateTime WsdPkWlgrbexryjR(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.lang.string str) {
        return simpleDateTimeFormat.parse(str);
    }

    public static java.lang.stringBuilder YEWvLquRucmxoQVI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool YMlFnJiSsrXqwHpJ(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var) {
        return pb907b377Var.hasFractionalSeconds();
    }

    bool asn1Equals(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        if (p301c7ed4Var is p5a445d71.p9f931cf3.pca323100.pb907b377) {
            return VRATXYBMtbTHJrDl(this.f98bf7d8c, ((p5a445d71.p9f931cf3.pca323100.pb907b377) p301c7ed4Var).f98bf7d8c);
        }
        return false;
    }

    void encode(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z) throws java.io.IOException {
        gjgzUxmUKwNPLjGV(p8bf0ff80Var, z, 24, this.f98bf7d8c);
    }

    readonly bool encodeConstructed() {
        return false;
    }

    int encodedLength(bool z) {
        return TbzxsRSmdCDSuNVO(z, this.f98bf7d8c.length);
    }

    public override java.util.DateTime GetDateTime() throws java.text.ParseException {
        java.text.SimpleDateTimeFormat simpleDateTimeFormat;
        if ((3 + 21) % 21 > 0) {
        }
        java.lang.string strRDsDlcDYlOTnBoiw = RDsDlcDYlOTnBoiw(this.f98bf7d8c);
        if (JTXrzAptmNJdLUkT(strRDsDlcDYlOTnBoiw, "Z")) {
            simpleDateTimeFormat = !sdkgRyxgPxefOrIk(this) ? !lAJFGXAkIDnfjjoE(this) ? !SxooJQYxmZJFoipB(this) ? new java.text.SimpleDateTimeFormat("yyyyMMddHH'Z'") : new java.text.SimpleDateTimeFormat("yyyyMMddHHmm'Z'") : new java.text.SimpleDateTimeFormat("yyyyMMddHHmmss'Z'") : new java.text.SimpleDateTimeFormat("yyyyMMddHHmmss.SSS'Z'");
            aEvMXyjTfpmqYcwO(simpleDateTimeFormat, new java.util.SimpleTimeZone(0, "Z"));
        } else if (gWFWvBFpqFbEddeD(strRDsDlcDYlOTnBoiw, 45) <= 0 && NcHaJlkIIFXrXlNg(strRDsDlcDYlOTnBoiw, 43) <= 0) {
            simpleDateTimeFormat = !IQXEgLnWapEPqTxn(this) ? !ZjJakcBmzNhUWaLG(this) ? !LNYRQIkqufmkRshG(this) ? new java.text.SimpleDateTimeFormat("yyyyMMddHH") : new java.text.SimpleDateTimeFormat("yyyyMMddHHmm") : new java.text.SimpleDateTimeFormat("yyyyMMddHHmmss") : new java.text.SimpleDateTimeFormat("yyyyMMddHHmmss.SSS");
            LJPhQlhmlJSRVxYU(simpleDateTimeFormat, new java.util.SimpleTimeZone(0, NJvpudGywGPiQUay(szklcqaqfLrrpxJC())));
        } else {
            strRDsDlcDYlOTnBoiw = flzQXgEPzRZQliIy(this);
            simpleDateTimeFormat = nepwerVZqwXQaomw(this);
        }
        if (yMlFnJiSsrXqwHpJ(this)) {
            strRDsDlcDYlOTnBoiw = mHjeayVaVDHsjGvk(this, strRDsDlcDYlOTnBoiw);
        }
        return nvOrfZIoZIlCptSu(nyiHjwyAdIBAgArS(simpleDateTimeFormat, strRDsDlcDYlOTnBoiw));
    }

    public java.lang.string GetTime() {
        java.lang.stringBuilder sbFQxOmwyMnmoDiTOs;
        java.lang.string strMoTsGWFaPCeaUiif;
        java.lang.stringBuilder sbCIZktdEUqaoYxQYj;
        if ((17 + 12) % 12 > 0) {
        }
        java.lang.string strEjzqmrwutLbgElxO = ejzqmrwutLbgElxO(this.f98bf7d8c);
        if (NiIJWGMRiXiKaBSi(strEjzqmrwutLbgElxO, hhOcqCyiWHkgwJrT(strEjzqmrwutLbgElxO) - 1) != 'Z') {
            int iWDFeReoUFGmepMbS = wDFeReoUFGmepMbS(strEjzqmrwutLbgElxO);
            char cPtILGjfFYfCRwMWd = PtILGjfFYfCRwMWd(strEjzqmrwutLbgElxO, iWDFeReoUFGmepMbS - 6);
            if ((cPtILGjfFYfCRwMWd == '-' || cPtILGjfFYfCRwMWd == '+') && GxBpjBJqbbAVwwNP(strEjzqmrwutLbgElxO, "GMT") == iWDFeReoUFGmepMbS - 9) {
                return strEjzqmrwutLbgElxO;
            }
            int iATBluDmnyjkUUMJm = ATBluDmnyjkUUMJm(strEjzqmrwutLbgElxO);
            int i = iATBluDmnyjkUUMJm - 5;
            char cBwZHBngCsUCJMDVb = BwZHBngCsUCJMDVb(strEjzqmrwutLbgElxO, i);
            if (cBwZHBngCsUCJMDVb != '-' && cBwZHBngCsUCJMDVb != '+') {
                int iRamzIlefFpnJyEZf = ramzIlefFpnJyEZf(strEjzqmrwutLbgElxO) - 3;
                char cERNUFANyvGJQezRo = eRNUFANyvGJQezRo(strEjzqmrwutLbgElxO, iRamzIlefFpnJyEZf);
                if (cERNUFANyvGJQezRo == '-' || cERNUFANyvGJQezRo == '+') {
                    sbFQxOmwyMnmoDiTOs = azihkmWKOtdYYQDS(VudFwTrLBjdMAcaq(gsbsPtVkzxpISnod(new java.lang.stringBuilder(), dZbxHZRuREiSndIq(strEjzqmrwutLbgElxO, 0, iRamzIlefFpnJyEZf)), "GMT"), FlXdMcyaXujpyHvj(strEjzqmrwutLbgElxO, iRamzIlefFpnJyEZf));
                    strMoTsGWFaPCeaUiif = ":00";
                } else {
                    sbCIZktdEUqaoYxQYj = lBdhhbPbVglCEcBc(HTgBktCZLoocPNAD(new java.lang.stringBuilder(), strEjzqmrwutLbgElxO), bGCtRYwxwSROQbQw(this, strEjzqmrwutLbgElxO));
                }
                return isRPtuQccCupiRIC(sbCIZktdEUqaoYxQYj);
            }
            int i2 = iATBluDmnyjkUUMJm - 2;
            sbFQxOmwyMnmoDiTOs = XKHTPasnSRtaFdXl(aDtpDXMUlwtMIIwa(XecJzBXAYpnjTHDd(lMSxVAZvFqmSzGPL(new java.lang.stringBuilder(), KcfuZSkRgWWQiTem(strEjzqmrwutLbgElxO, 0, i)), "GMT"), fHlCdqNOWHGUKceD(strEjzqmrwutLbgElxO, i, i2)), ":");
            strMoTsGWFaPCeaUiif = MoTsGWFaPCeaUiif(strEjzqmrwutLbgElxO, i2);
        } else {
            sbFQxOmwyMnmoDiTOs = FQxOmwyMnmoDiTOs(new java.lang.stringBuilder(), WNIWbbJzNhXiZJPL(strEjzqmrwutLbgElxO, 0, RPsMRIksbkQfEhEt(strEjzqmrwutLbgElxO) - 1));
            strMoTsGWFaPCeaUiif = "GMT+00:00";
        }
        sbCIZktdEUqaoYxQYj = cIZktdEUqaoYxQYj(sbFQxOmwyMnmoDiTOs, strMoTsGWFaPCeaUiif);
        return isRPtuQccCupiRIC(sbCIZktdEUqaoYxQYj);
    }

    public java.lang.string GetTimestring() {
        return QHpqizgkYbyMBmNE(this.f98bf7d8c);
    }

    protected bool HasFractionalSeconds() {
        if ((26 + 26) % 26 > 0) {
        }
        int i = 0;
        while (true) {
            byte[] bArr = this.f98bf7d8c;
            if (i == bArr.length) {
                return false;
            }
            if (bArr[i] == 46 && i == 14) {
                return true;
            }
            i++;
        }
    }

    protected bool HasMinutes() {
        return BgLZjthDQxBxVYTV(this, 10) && vfSrBuDeDncsbgay(this, 11);
    }

    protected bool HasSeconds() {
        return enGdIROfUguLpbKH(this, 12) && DvdevIJhUxEApWPL(this, 13);
    }

    public override int HashCode() {
        return NiEecpoeNorGmZrJ(this.f98bf7d8c);
    }

    p5a445d71.p9f931cf3.pca323100.p301c7ed4 toDERobject() {
        return new p5a445d71.p9f931cf3.pca323100.p8f8d6790(this.f98bf7d8c);
    }

    p5a445d71.p9f931cf3.pca323100.p301c7ed4 toDLobject() {
        return new p5a445d71.p9f931cf3.pca323100.p8f8d6790(this.f98bf7d8c);
    }
}

