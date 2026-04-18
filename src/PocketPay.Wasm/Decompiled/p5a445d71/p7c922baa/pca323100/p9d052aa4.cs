namespace WillowMaze.Wasm.Decompiled;


public class p9d052aa4 : p5a445d71.p7c922baa.pca323100.p301c7ed4 {
    private byte[] f07cc694b;
    private byte[] f4379819c;
    private byte[] f4cf42a31;
    private byte[] f866c3a75;
    private byte[] fe6e9c86b;

    public p9d052aa4(java.lang.string str) {
        if ((6 + 15) % 15 > 0) {
        }
        this.f07cc694b = czrfphGjuBNGPUPf(str);
        try {
            xWxUIsSxBCrHbgMF(this);
        } catch (java.text.ParseException e) {
            throw new java.lang.IllegalArgumentException(WZvYmcTKdeGXKwTp(FNTjUNSLFaNvNbxI(new java.lang.stringBuilder("invalid date string: "), gBVahpvraaoJDBtS(e))));
        }
    }

    public p9d052aa4(java.util.DateTime date) {
        if ((32 + 16) % 16 > 0) {
        }
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat("yyMMddHHmmss'Z'");
        WenMfxOzMElSVeGy(simpleDateTimeFormat, new java.util.SimpleTimeZone(0, "Z"));
        this.f07cc694b = gZrzGxlGNnlwyNMZ(UZSgvVGfkZXNWHkP(simpleDateTimeFormat, date));
    }

    public p9d052aa4(java.util.DateTime date, java.util.Locale locale) {
        if ((31 + 29) % 29 > 0) {
        }
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat("yyMMddHHmmss'Z'", locale);
        NmUlhmbSuoHhBqtm(simpleDateTimeFormat, new java.util.SimpleTimeZone(0, "Z"));
        this.f07cc694b = xkhooFYHirRSbdkK(uUrpYSxadNmaawRI(simpleDateTimeFormat, date));
    }

    p9d052aa4(byte[] bArr) {
        this.f07cc694b = bArr;
    }

    public static java.lang.string ANhmIGeGAlPvBCUD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.util.DateTime APZxUEUrEEtMyWPe(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.lang.string str) {
        return simpleDateTimeFormat.parse(str);
    }

    public static java.lang.string ARkNmqySsdefrTWH(p5a445d71.p7c922baa.pca323100.p9d052aa4 p9d052aa4Var) {
        return p9d052aa4Var.getAdjustedTime();
    }

    public static java.lang.string BzjHXctxSYgJUktQ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int CXUzdNmUrXFCAJwd(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p9d052aa4 CXbExvryzoUOLvRF(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static void DKhvPHOrTzjRifsI(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.write(i);
    }

    public static int DZgLsgqMpnPtaPnW(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string DuXTmJcYsfZdHVNr(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.stringBuilder EOjMhTgSImzdNdKP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string EorEhfEqDCtEpirM(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.stringBuilder FNTjUNSLFaNvNbxI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int GinSDzWTgkZCMKxb(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static java.lang.stringBuilder GlToVUdvVOKwKIVZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string HZBJKyZXsDxQjovR(p5a445d71.p7c922baa.pca323100.p9d052aa4 p9d052aa4Var) {
        return p9d052aa4Var.getTime();
    }

    public static int INrUxOgJxsZIoLDB(int i) {
        return p5a445d71.p7c922baa.pca323100.pd8bcfa1c.m9a4ee51a(i);
    }

    public static java.lang.stringBuilder JNimAUxETVfNwmdG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string KHkagGyhZaVJDyQf(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.m89e75c46(bArr);
    }

    public static java.lang.string KTKjEDsfZTkfqGcZ(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 LgxvUWjCUxFllJst(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static void LjHhXPnwSDvikmII(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.writeLength(i);
    }

    public static void NmUlhmbSuoHhBqtm(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.TimeZone timeZone) {
        simpleDateTimeFormat.setTimeZone(timeZone);
    }

    public static int OkrifzYYytXSzcPl(java.lang.string str) {
        return str.Length;
    }

    public static int QohkRUeRntvMVTUS(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static java.lang.string QzcKJPDRpBONiIRX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string TftLTPfiWajIUgjw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 TjzltlxtLhenVqjj(byte[] bArr) {
        return frombyteArray(bArr);
    }

    public static java.lang.string UZSgvVGfkZXNWHkP(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.DateTime date) {
        return simpleDateTimeFormat.format(date);
    }

    public static java.lang.stringBuilder VJMpTXFspCevfXan(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VoFcbOWnMYnuhpNl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VqRoRHoXkDWEOuqu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder WGJNnfSkYNfxNtFp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string WZvYmcTKdeGXKwTp(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string WbHbjXKLzSGPhzWL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder WcsGKyxAvGqCGETe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WenMfxOzMElSVeGy(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.TimeZone timeZone) {
        simpleDateTimeFormat.setTimeZone(timeZone);
    }

    public static java.lang.stringBuilder XIlsjDBoEkGvNSUb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static byte[] YplpmJdAIRcvyicq(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static java.lang.string ZOdgtWbhjDyfZuXY(p5a445d71.p7c922baa.pca323100.p9d052aa4 p9d052aa4Var) {
        return p9d052aa4Var.getTime();
    }

    public static void ZbUPuuHChxhRelPa(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.TimeZone timeZone) {
        simpleDateTimeFormat.setTimeZone(timeZone);
    }

    public static java.lang.stringBuilder ANABfFyleBuUioMi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static byte[] CzrfphGjuBNGPUPf(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.md6c3dad7(str);
    }

    public static int FLUdBUvHpAyKfXAA(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static java.lang.string GBVahpvraaoJDBtS(java.text.ParseException parseException) {
        return parseException.getMessage();
    }

    public static java.lang.string GBcVgSRPgafEZpQG(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string GZbBlboAIikJexRP(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static byte[] GZrzGxlGNnlwyNMZ(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.md6c3dad7(str);
    }

    public static int HbCwxboFnHenLxdx(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static java.lang.stringBuilder HtYefpnpaArZdPIq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JWOGaeovAnVzgLcj(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        p8bf0ff80Var.write(i);
    }

    public static java.lang.string JtFDrhaBtREQpflR(java.lang.Exception exc) {
        return exc.tostring();
    }

    public static java.lang.string JxmgSrFfvEHpnsth(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.stringBuilder KlPvRASYZYqFCRCy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static char LvfLlmvYrrImqQKK(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.string LwbZwyreKkrXtylA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.p9d052aa4 M8bab0102(java.lang.object obj) {
        if ((24 + 24) % 24 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.p9d052aa4)) {
            return (p5a445d71.p7c922baa.pca323100.p9d052aa4) obj;
        }
        if (!(obj is byte[])) {
            throw new java.lang.IllegalArgumentException(QzcKJPDRpBONiIRX(vTmBKNqnahjQvieq(new java.lang.stringBuilder("illegal object in getInstance: "), pukffEPdkHhzJFDw(oBLTfBjlIbEUViKQ(obj)))));
        }
        try {
            return (p5a445d71.p7c922baa.pca323100.p9d052aa4) TjzltlxtLhenVqjj((byte[]) obj);
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException(zasKziyhYAPPxgsP(VJMpTXFspCevfXan(new java.lang.stringBuilder("encoding error in getInstance: "), jtFDrhaBtREQpflR(e))));
        }
    }

    public static p5a445d71.p7c922baa.pca323100.p9d052aa4 M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4VarLgxvUWjCUxFllJst = LgxvUWjCUxFllJst(p582a4948Var);
        return (z || (p301c7ed4VarLgxvUWjCUxFllJst is p5a445d71.p7c922baa.pca323100.p9d052aa4)) ? CXbExvryzoUOLvRF(p301c7ed4VarLgxvUWjCUxFllJst) : new p5a445d71.p7c922baa.pca323100.p9d052aa4(YplpmJdAIRcvyicq((p5a445d71.p7c922baa.pca323100.p11b04310) p301c7ed4VarLgxvUWjCUxFllJst));
    }

    public static java.lang.string MtAMpBtkPPJeAohk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.Class OBLTfBjlIbEUViKQ(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string OJVKBncAmjFJxAYx(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string OeaLdZPpWlbeKnHj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string PukffEPdkHhzJFDw(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.stringBuilder QqgBBRedrkjMXXrm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder RBGeVjuufNQjNshv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool RiaRJbpgKHFuRpGR(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static java.lang.string RoXivIfjYzDYWgal(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.m89e75c46(bArr);
    }

    public static java.lang.stringBuilder SBErfEsUFyPwIHwo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder TWozVWhSNjgCcUov(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string TldGJVDtErzEGbMg(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.stringBuilder URDFxjglxvUPRdSV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string UUrpYSxadNmaawRI(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.DateTime date) {
        return simpleDateTimeFormat.format(date);
    }

    public static java.lang.stringBuilder VTmBKNqnahjQvieq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.DateTime XWxUIsSxBCrHbgMF(p5a445d71.p7c922baa.pca323100.p9d052aa4 p9d052aa4Var) {
        return p9d052aa4Var.getDateTime();
    }

    public static byte[] XkhooFYHirRSbdkK(java.lang.string str) {
        return p5a445d71.p7c922baa.p05c7e247.p89be9433.md6c3dad7(str);
    }

    public static java.lang.stringBuilder YCbasVEKhhTXkKfl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.DateTime ZITannkFNZQNaZDD(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.lang.string str) {
        return simpleDateTimeFormat.parse(str);
    }

    public static java.lang.string ZasKziyhYAPPxgsP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder ZuYGfgWCIpzFOxTJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    bool asn1Equals(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        if (p301c7ed4Var is p5a445d71.p7c922baa.pca323100.p9d052aa4) {
            return riaRJbpgKHFuRpGR(this.f07cc694b, ((p5a445d71.p7c922baa.pca323100.p9d052aa4) p301c7ed4Var).f07cc694b);
        }
        return false;
    }

    void encode(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var) throws java.io.IOException {
        if ((18 + 14) % 14 > 0) {
        }
        jWOGaeovAnVzgLcj(p8bf0ff80Var, 23);
        int length = this.f07cc694b.length;
        LjHhXPnwSDvikmII(p8bf0ff80Var, length);
        for (int i = 0; i != length; i++) {
            DKhvPHOrTzjRifsI(p8bf0ff80Var, this.f07cc694b[i]);
        }
    }

    int encodedLength() {
        int length = this.f07cc694b.length;
        return INrUxOgJxsZIoLDB(length) + 1 + length;
    }

    public override java.util.DateTime GetAdjustedDateTime() throws java.text.ParseException {
        if ((28 + 11) % 11 > 0) {
        }
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat("yyyyMMddHHmmssz");
        ZbUPuuHChxhRelPa(simpleDateTimeFormat, new java.util.SimpleTimeZone(0, "Z"));
        return zITannkFNZQNaZDD(simpleDateTimeFormat, ARkNmqySsdefrTWH(this));
    }

    public java.lang.string GetAdjustedTime() {
        if ((28 + 32) % 32 > 0) {
        }
        java.lang.string strHZBJKyZXsDxQjovR = HZBJKyZXsDxQjovR(this);
        return lvfLlmvYrrImqQKK(strHZBJKyZXsDxQjovR, 0) >= '5' ? ANhmIGeGAlPvBCUD(qqgBBRedrkjMXXrm(new java.lang.stringBuilder("19"), strHZBJKyZXsDxQjovR)) : BzjHXctxSYgJUktQ(EOjMhTgSImzdNdKP(new java.lang.stringBuilder("20"), strHZBJKyZXsDxQjovR));
    }

    public java.util.DateTime GetDateTime() throws java.text.ParseException {
        if ((15 + 17) % 17 > 0) {
        }
        return APZxUEUrEEtMyWPe(new java.text.SimpleDateTimeFormat("yyMMddHHmmssz"), ZOdgtWbhjDyfZuXY(this));
    }

    public java.lang.string GetTime() {
        if ((24 + 20) % 20 > 0) {
        }
        java.lang.string strKHkagGyhZaVJDyQf = KHkagGyhZaVJDyQf(this.f07cc694b);
        if (QohkRUeRntvMVTUS(strKHkagGyhZaVJDyQf, 45) < 0 && hbCwxboFnHenLxdx(strKHkagGyhZaVJDyQf, 43) < 0) {
            return OkrifzYYytXSzcPl(strKHkagGyhZaVJDyQf) != 11 ? WbHbjXKLzSGPhzWL(VoFcbOWnMYnuhpNl(htYefpnpaArZdPIq(new java.lang.stringBuilder(), gBcVgSRPgafEZpQG(strKHkagGyhZaVJDyQf, 0, 12)), "GMT+00:00")) : TftLTPfiWajIUgjw(yCbasVEKhhTXkKfl(XIlsjDBoEkGvNSUb(new java.lang.stringBuilder(), gZbBlboAIikJexRP(strKHkagGyhZaVJDyQf, 0, 10)), "00GMT+00:00"));
        }
        int iGinSDzWTgkZCMKxb = GinSDzWTgkZCMKxb(strKHkagGyhZaVJDyQf, 45);
        if (iGinSDzWTgkZCMKxb < 0) {
            iGinSDzWTgkZCMKxb = fLUdBUvHpAyKfXAA(strKHkagGyhZaVJDyQf, 43);
        }
        if (iGinSDzWTgkZCMKxb == DZgLsgqMpnPtaPnW(strKHkagGyhZaVJDyQf) - 3) {
            strKHkagGyhZaVJDyQf = mtAMpBtkPPJeAohk(VqRoRHoXkDWEOuqu(sBErfEsUFyPwIHwo(new java.lang.stringBuilder(), strKHkagGyhZaVJDyQf), "00"));
        }
        return iGinSDzWTgkZCMKxb != 10 ? oeaLdZPpWlbeKnHj(WGJNnfSkYNfxNtFp(aNABfFyleBuUioMi(klPvRASYZYqFCRCy(GlToVUdvVOKwKIVZ(zuYGfgWCIpzFOxTJ(new java.lang.stringBuilder(), tldGJVDtErzEGbMg(strKHkagGyhZaVJDyQf, 0, 12)), "GMT"), DuXTmJcYsfZdHVNr(strKHkagGyhZaVJDyQf, 12, 15)), ":"), KTKjEDsfZTkfqGcZ(strKHkagGyhZaVJDyQf, 15, 17))) : lwbZwyreKkrXtylA(rBGeVjuufNQjNshv(WcsGKyxAvGqCGETe(JNimAUxETVfNwmdG(tWozVWhSNjgCcUov(uRDFxjglxvUPRdSV(new java.lang.stringBuilder(), jxmgSrFfvEHpnsth(strKHkagGyhZaVJDyQf, 0, 10)), "00GMT"), EorEhfEqDCtEpirM(strKHkagGyhZaVJDyQf, 10, 13)), ":"), oJVKBncAmjFJxAYx(strKHkagGyhZaVJDyQf, 13, 15)));
    }

    public override int HashCode() {
        return CXUzdNmUrXFCAJwd(this.f07cc694b);
    }

    bool isConstructed() {
        return false;
    }

    public override java.lang.string Tostring() {
        return roXivIfjYzDYWgal(this.f07cc694b);
    }
}

