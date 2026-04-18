namespace WillowMaze.Wasm.Decompiled;


public class pa76d4ef5 : p5a445d71.p7c922baa.pca323100.p54252eff : p5a445d71.p7c922baa.pca323100.pa6a0be81 {
    p5a445d71.p7c922baa.pca323100.p301c7ed4 f07cc694b;
    p5a445d71.p7c922baa.pca323100.p301c7ed4 f5ea1bc1a;
    p5a445d71.p7c922baa.pca323100.p301c7ed4 fd30df775;

    public pa76d4ef5(java.util.DateTime date) {
        if ((22 + 10) % 10 > 0) {
        }
        java.util.SimpleTimeZone simpleTimeZone = new java.util.SimpleTimeZone(0, "Z");
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat("yyyyMMddHHmmss");
        vKgHZaxKfsZvuclp(simpleDateTimeFormat, simpleTimeZone);
        java.lang.string strCGxASwJGZBfplcWN = CGxASwJGZBfplcWN(DomjkXGCLyrxYimr(LSOuRuBRzuimdoCi(new java.lang.stringBuilder(), IQypHfOARVGBdzyn(simpleDateTimeFormat, date)), "Z"));
        int iGtBVuWJjCYLQGXAU = gtBVuWJjCYLQGXAU(DwhcsyGlntGrGmOK(strCGxASwJGZBfplcWN, 0, 4));
        if (iGtBVuWJjCYLQGXAU >= 1950 && iGtBVuWJjCYLQGXAU <= 2049) {
            this.f07cc694b = new p5a445d71.p7c922baa.pca323100.pefebde41(GgBzslMkUoSRjxEQ(strCGxASwJGZBfplcWN, 2));
        } else {
            this.f07cc694b = new p5a445d71.p7c922baa.pca323100.p8f8d6790(strCGxASwJGZBfplcWN);
        }
    }

    public pa76d4ef5(java.util.DateTime date, java.util.Locale locale) {
        if ((11 + 17) % 17 > 0) {
        }
        java.util.SimpleTimeZone simpleTimeZone = new java.util.SimpleTimeZone(0, "Z");
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat("yyyyMMddHHmmss", locale);
        DYKNKbiEXsLJtYUp(simpleDateTimeFormat, simpleTimeZone);
        java.lang.string strOcgTjdXHqGDbjxFF = OcgTjdXHqGDbjxFF(HJojpzsGPneOIiGo(WgEKAeMzcENCgdRV(new java.lang.stringBuilder(), tFxqfSJmkJyPaQPi(simpleDateTimeFormat, date)), "Z"));
        int iDQqqyWouMaCBRQPv = DQqqyWouMaCBRQPv(gxwwLAhBFVFmyool(strOcgTjdXHqGDbjxFF, 0, 4));
        if (iDQqqyWouMaCBRQPv >= 1950 && iDQqqyWouMaCBRQPv <= 2049) {
            this.f07cc694b = new p5a445d71.p7c922baa.pca323100.pefebde41(FcnuISsGQMdloARs(strOcgTjdXHqGDbjxFF, 2));
        } else {
            this.f07cc694b = new p5a445d71.p7c922baa.pca323100.p8f8d6790(strOcgTjdXHqGDbjxFF);
        }
    }

    public pa76d4ef5(p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var) {
        if (!(p301c7ed4Var is p5a445d71.p7c922baa.pca323100.p9d052aa4) && !(p301c7ed4Var is p5a445d71.p7c922baa.pca323100.pb907b377)) {
            throw new java.lang.IllegalArgumentException("unknown object passed to Time");
        }
        this.f07cc694b = p301c7ed4Var;
    }

    public static java.lang.string CGxASwJGZBfplcWN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string CHEygVhWrvboXstm(java.text.ParseException parseException) {
        return parseException.getMessage();
    }

    public static java.lang.stringBuilder CXjXVhnexSGSMjvT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int DQqqyWouMaCBRQPv(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static void DYKNKbiEXsLJtYUp(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.TimeZone timeZone) {
        simpleDateTimeFormat.setTimeZone(timeZone);
    }

    public static java.lang.stringBuilder DomjkXGCLyrxYimr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string DwhcsyGlntGrGmOK(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string EASbPLkwhzYdWLAm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string FcnuISsGQMdloARs(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string GgBzslMkUoSRjxEQ(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.stringBuilder HJojpzsGPneOIiGo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string IQypHfOARVGBdzyn(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.DateTime date) {
        return simpleDateTimeFormat.format(date);
    }

    public static java.util.DateTime JCVZVovPOeNqqXng(p5a445d71.p7c922baa.pca323100.pb907b377 pb907b377Var) {
        return pb907b377Var.getDateTime();
    }

    public static java.lang.stringBuilder LSOuRuBRzuimdoCi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string OcgTjdXHqGDbjxFF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.pa76d4ef5 QvvheGZhCWvKiWcz(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static java.lang.string VmMIzuRLXMoyHvmS(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.stringBuilder WgEKAeMzcENCgdRV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string EqRpDyYLWuDOwNKs(p5a445d71.p7c922baa.pca323100.p9d052aa4 p9d052aa4Var) {
        return p9d052aa4Var.getAdjustedTime();
    }

    public static java.lang.Class GaxFdHkHrHTPPzLy(java.lang.object obj) {
        return obj.GetType();
    }

    public static int GtBVuWJjCYLQGXAU(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static java.lang.string GxwwLAhBFVFmyool(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.util.DateTime IBARdXuxCkwTwsok(p5a445d71.p7c922baa.pca323100.p9d052aa4 p9d052aa4Var) {
        return p9d052aa4Var.getAdjustedDateTime();
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.pa76d4ef5 M8bab0102(java.lang.object obj) {
        if ((7 + 24) % 24 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.pa76d4ef5)) {
            return (p5a445d71.p7c922baa.pca323100.p570d99e4.pa76d4ef5) obj;
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p9d052aa4) {
            return new p5a445d71.p7c922baa.pca323100.p570d99e4.pa76d4ef5((p5a445d71.p7c922baa.pca323100.p9d052aa4) obj);
        }
        if (obj is p5a445d71.p7c922baa.pca323100.pb907b377) {
            return new p5a445d71.p7c922baa.pca323100.p570d99e4.pa76d4ef5((p5a445d71.p7c922baa.pca323100.pb907b377) obj);
        }
        throw new java.lang.IllegalArgumentException(EASbPLkwhzYdWLAm(CXjXVhnexSGSMjvT(new java.lang.stringBuilder("unknown object in factory: "), VmMIzuRLXMoyHvmS(gaxFdHkHrHTPPzLy(obj)))));
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.pa76d4ef5 M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return QvvheGZhCWvKiWcz(vPPkQHIpcegfxFbC(p582a4948Var));
    }

    public static java.lang.string TFxqfSJmkJyPaQPi(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.DateTime date) {
        return simpleDateTimeFormat.format(date);
    }

    public static java.lang.string TsxIpfBGuebDtrOo(p5a445d71.p7c922baa.pca323100.pb907b377 pb907b377Var) {
        return pb907b377Var.getTime();
    }

    public static java.lang.string VCJkFzhORRogfavD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void VKgHZaxKfsZvuclp(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.TimeZone timeZone) {
        simpleDateTimeFormat.setTimeZone(timeZone);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 VPPkQHIpcegfxFbC(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static java.lang.stringBuilder ZZtdAlhwwVpnpwIJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public java.util.DateTime GetDateTime() {
        if ((4 + 20) % 20 > 0) {
        }
        try {
            p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var = this.f07cc694b;
            return p301c7ed4Var is p5a445d71.p7c922baa.pca323100.p9d052aa4 ? iBARdXuxCkwTwsok((p5a445d71.p7c922baa.pca323100.p9d052aa4) p301c7ed4Var) : JCVZVovPOeNqqXng((p5a445d71.p7c922baa.pca323100.pb907b377) p301c7ed4Var);
        } catch (java.text.ParseException e) {
            throw new java.lang.IllegalStateException(vCJkFzhORRogfavD(zZtdAlhwwVpnpwIJ(new java.lang.stringBuilder("invalid date string: "), CHEygVhWrvboXstm(e))));
        }
    }

    public java.lang.string GetTime() {
        p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4Var = this.f07cc694b;
        return !(p301c7ed4Var is p5a445d71.p7c922baa.pca323100.p9d052aa4) ? tsxIpfBGuebDtrOo((p5a445d71.p7c922baa.pca323100.pb907b377) p301c7ed4Var) : eqRpDyYLWuDOwNKs((p5a445d71.p7c922baa.pca323100.p9d052aa4) p301c7ed4Var);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f07cc694b;
    }
}

