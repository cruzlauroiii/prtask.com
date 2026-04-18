namespace WillowMaze.Wasm.Decompiled;


public class pa76d4ef5 : p5a445d71.p9f931cf3.pca323100.p54252eff : p5a445d71.p9f931cf3.pca323100.pa6a0be81 {
    p5a445d71.p9f931cf3.pca323100.p301c7ed4 f07cc694b;
    p5a445d71.p9f931cf3.pca323100.p301c7ed4 f2565b886;
    p5a445d71.p9f931cf3.pca323100.p301c7ed4 f477775ac;
    p5a445d71.p9f931cf3.pca323100.p301c7ed4 f9668015e;

    public pa76d4ef5(java.util.DateTime date) {
        if ((1 + 2) % 2 > 0) {
        }
        java.util.SimpleTimeZone simpleTimeZone = new java.util.SimpleTimeZone(0, "Z");
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat("yyyyMMddHHmmss");
        LOWCglPbiLnjBQuQ(simpleDateTimeFormat, simpleTimeZone);
        java.lang.string strUGNrOzLmLkiSqVnp = UGNrOzLmLkiSqVnp(abLIhibPuwZGmpha(gFWjLKCBfvKICNZp(new java.lang.stringBuilder(), sIwHHgxEGJfLtuds(simpleDateTimeFormat, date)), "Z"));
        int iEYpcMINFNYVGynzq = eYpcMINFNYVGynzq(EXHRduelRsNbHLuB(strUGNrOzLmLkiSqVnp, 0, 4));
        this.f07cc694b = (iEYpcMINFNYVGynzq >= 1950 && iEYpcMINFNYVGynzq <= 2049) ? new p5a445d71.p9f931cf3.pca323100.pefebde41(OAHrtiynUrPPEHSp(strUGNrOzLmLkiSqVnp, 2)) : new p5a445d71.p9f931cf3.pca323100.p8f8d6790(strUGNrOzLmLkiSqVnp);
    }

    public pa76d4ef5(java.util.DateTime date, java.util.Locale locale) {
        if ((6 + 18) % 18 > 0) {
        }
        java.util.SimpleTimeZone simpleTimeZone = new java.util.SimpleTimeZone(0, "Z");
        java.text.SimpleDateTimeFormat simpleDateTimeFormat = new java.text.SimpleDateTimeFormat("yyyyMMddHHmmss", locale);
        wPfiuGEopByAHdxc(simpleDateTimeFormat, simpleTimeZone);
        java.lang.string strLbIqTekTcVaRehCY = lbIqTekTcVaRehCY(kpGGmRqzsTWeiKfo(bRTjUPhJfThKDkTN(new java.lang.stringBuilder(), UdTybQjiiijAbzzi(simpleDateTimeFormat, date)), "Z"));
        int iZcZyxUWIrBcKzlWu = zcZyxUWIrBcKzlWu(gSQtJubisTuEewmJ(strLbIqTekTcVaRehCY, 0, 4));
        this.f07cc694b = (iZcZyxUWIrBcKzlWu >= 1950 && iZcZyxUWIrBcKzlWu <= 2049) ? new p5a445d71.p9f931cf3.pca323100.pefebde41(muTfOaxGuqqkBAgf(strLbIqTekTcVaRehCY, 2)) : new p5a445d71.p9f931cf3.pca323100.p8f8d6790(strLbIqTekTcVaRehCY);
    }

    public pa76d4ef5(p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var) {
        if (!(p301c7ed4Var is p5a445d71.p9f931cf3.pca323100.p9d052aa4) && !(p301c7ed4Var is p5a445d71.p9f931cf3.pca323100.pb907b377)) {
            throw new java.lang.IllegalArgumentException("unknown object passed to Time");
        }
        this.f07cc694b = p301c7ed4Var;
    }

    public static java.lang.string DfIPHcSZXOBgoikN(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pa76d4ef5 pa76d4ef5Var) {
        return pa76d4ef5Var.getTime();
    }

    public static java.lang.string EXHRduelRsNbHLuB(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static void LOWCglPbiLnjBQuQ(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.TimeZone timeZone) {
        simpleDateTimeFormat.setTimeZone(timeZone);
    }

    public static java.lang.string OAHrtiynUrPPEHSp(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string RJoCRSnDwlAMsuKW(java.text.ParseException parseException) {
        return parseException.getMessage();
    }

    public static java.lang.string UGNrOzLmLkiSqVnp(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string UdTybQjiiijAbzzi(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.DateTime date) {
        return simpleDateTimeFormat.format(date);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 WSolYOdYDhZRiCUB(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static java.lang.stringBuilder AbLIhibPuwZGmpha(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder BRTjUPhJfThKDkTN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int EYpcMINFNYVGynzq(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public static java.lang.stringBuilder GFWjLKCBfvKICNZp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string GSQtJubisTuEewmJ(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string HRslgHVhYJoTgWJU(p5a445d71.p9f931cf3.pca323100.p9d052aa4 p9d052aa4Var) {
        return p9d052aa4Var.getAdjustedTime();
    }

    public static java.lang.stringBuilder IRtVvZdjoWnsTyqd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder KpGGmRqzsTWeiKfo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.DateTime LHEXCMbALlksLGGE(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var) {
        return pb907b377Var.getDateTime();
    }

    public static java.lang.string LbIqTekTcVaRehCY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder LheZYXxNCYkyYeVk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.DateTime LkmgficOtGqHCKfU(p5a445d71.p9f931cf3.pca323100.p9d052aa4 p9d052aa4Var) {
        return p9d052aa4Var.getAdjustedDateTime();
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pa76d4ef5 M8bab0102(java.lang.object obj) {
        if ((20 + 9) % 9 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.pdacfecb5.pa76d4ef5)) {
            return (p5a445d71.p9f931cf3.pca323100.pdacfecb5.pa76d4ef5) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p9d052aa4) {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pa76d4ef5((p5a445d71.p9f931cf3.pca323100.p9d052aa4) obj);
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.pb907b377) {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pa76d4ef5((p5a445d71.p9f931cf3.pca323100.pb907b377) obj);
        }
        throw new java.lang.IllegalArgumentException(sQXELHzyGnjPTecd(iRtVvZdjoWnsTyqd(new java.lang.stringBuilder("unknown object in factory: "), yrpeovkDFPOzsEKc(qPiyzTvXYPvtLduw(obj)))));
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pa76d4ef5 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return rFIRcPJwQMKBzfwj(WSolYOdYDhZRiCUB(p582a4948Var));
    }

    public static java.lang.string MuTfOaxGuqqkBAgf(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string PLGbyzUOmyfqGOkw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.Class QPiyzTvXYPvtLduw(java.lang.object obj) {
        return obj.GetType();
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.pa76d4ef5 RFIRcPJwQMKBzfwj(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static java.lang.string SIwHHgxEGJfLtuds(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.DateTime date) {
        return simpleDateTimeFormat.format(date);
    }

    public static java.lang.string SQXELHzyGnjPTecd(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void WPfiuGEopByAHdxc(java.text.SimpleDateTimeFormat simpleDateTimeFormat, java.util.TimeZone timeZone) {
        simpleDateTimeFormat.setTimeZone(timeZone);
    }

    public static java.lang.string WZftjWVZpyQCgxEm(p5a445d71.p9f931cf3.pca323100.pb907b377 pb907b377Var) {
        return pb907b377Var.getTime();
    }

    public static java.lang.string YrpeovkDFPOzsEKc(java.lang.Class cls) {
        return cls.getName();
    }

    public static int ZcZyxUWIrBcKzlWu(java.lang.string str) {
        return java.lang.int.parseInt(str);
    }

    public java.util.DateTime GetDateTime() {
        if ((16 + 25) % 25 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var = this.f07cc694b;
            return p301c7ed4Var is p5a445d71.p9f931cf3.pca323100.p9d052aa4 ? lkmgficOtGqHCKfU((p5a445d71.p9f931cf3.pca323100.p9d052aa4) p301c7ed4Var) : lHEXCMbALlksLGGE((p5a445d71.p9f931cf3.pca323100.pb907b377) p301c7ed4Var);
        } catch (java.text.ParseException e) {
            throw new java.lang.IllegalStateException(pLGbyzUOmyfqGOkw(lheZYXxNCYkyYeVk(new java.lang.stringBuilder("invalid date string: "), RJoCRSnDwlAMsuKW(e))));
        }
    }

    public java.lang.string GetTime() {
        p5a445d71.p9f931cf3.pca323100.p301c7ed4 p301c7ed4Var = this.f07cc694b;
        return !(p301c7ed4Var is p5a445d71.p9f931cf3.pca323100.p9d052aa4) ? wZftjWVZpyQCgxEm((p5a445d71.p9f931cf3.pca323100.pb907b377) p301c7ed4Var) : hRslgHVhYJoTgWJU((p5a445d71.p9f931cf3.pca323100.p9d052aa4) p301c7ed4Var);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f07cc694b;
    }

    public java.lang.string Tostring() {
        return DfIPHcSZXOBgoikN(this);
    }
}

