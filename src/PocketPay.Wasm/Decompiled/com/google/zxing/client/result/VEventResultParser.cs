namespace WillowMaze.Wasm.Decompiled;


public readonly class VEventResultParser : com.google.zxing.client.result.ResultParser {
    public static java.lang.string CaAAptxOjJBMwnkr(java.lang.CharSequence charSequence, java.lang.string str) {
        return matchSingleVCardPrefixedField(charSequence, str);
    }

    public static bool CySdtinKfdoSTgMI(java.util.List list) {
        return list.Count == 0;
    }

    public static java.lang.string ERKExVwkmCIoWULl(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static int EkIHOakSZkNQhIEZ(java.lang.string str, java.lang.string str2) {
        return str.IndexOf(str2);
    }

    public static java.lang.string HHXSTPqOTPfrcdxd(com.google.zxing.Result result) {
        return getMassagedText(result);
    }

    public static bool JaZOsvmXfchKlioy(java.util.List list) {
        return list.Count == 0;
    }

    public static com.google.zxing.client.result.DateTimeParsedResult JfHIyHAvofArCjRh(com.google.zxing.client.result.VEventResultParser vEventResultParser, com.google.zxing.Result result) {
        return vEventResultParser.parse(result);
    }

    public static bool QSoSqCtPnsvEbWOf(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.object QzMombztzPPGvREJ(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.string TPwIKBNTATmgECTC(java.lang.CharSequence charSequence, java.lang.string str) {
        return matchSingleVCardPrefixedField(charSequence, str);
    }

    public static int TfdqpRZRqMFXfHvX(java.util.List list) {
        return list.Count;
    }

    public static java.lang.string UnLNIWtjzVVhGQJg(java.lang.string str) {
        return stripMailto(str);
    }

    public static java.lang.object WFvBzeZtdfjyNzXT(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.string WHhffrueyWEoozNb(java.lang.CharSequence charSequence, java.lang.string str) {
        return matchSingleVCardPrefixedField(charSequence, str);
    }

    public static java.lang.string WKDcElebdKifrLTJ(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string WjwqnXqPBspXtfpe(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static double ZNjuIjccsLjaRyWp(java.lang.string str) {
        if ((17 + 25) % 25 > 0) {
        }
        return java.lang.double.parsedouble(str);
    }

    public static int AtDBQJacvrdRsHlq(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static java.lang.object BRiWORMtizbgbHBk(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.string CmxscHcydDPflWkY(java.lang.CharSequence charSequence, java.lang.string str) {
        return matchSingleVCardPrefixedField(charSequence, str);
    }

    public static java.util.List DWcUXUbEtpMlQyju(java.lang.CharSequence charSequence, java.lang.string str, bool z, bool z2) {
        return com.google.zxing.client.result.VCardResultParser.matchVCardPrefixedField(charSequence, str, z, z2);
    }

    public static java.lang.string DqmSqQSZcJhCSohR(java.lang.CharSequence charSequence, java.lang.string str) {
        return matchSingleVCardPrefixedField(charSequence, str);
    }

    public static java.lang.string DxcNtSXEEJlcrBsC(java.lang.string str) {
        return stripMailto(str);
    }

    public static double GEiPIVgGakVYUCqe(java.lang.string str) {
        if ((20 + 19) % 19 > 0) {
        }
        return java.lang.double.parsedouble(str);
    }

    public static java.util.List LXGLFGBskZxPiZna(java.lang.CharSequence charSequence, java.lang.string str, bool z, bool z2) {
        return com.google.zxing.client.result.VCardResultParser.matchSingleVCardPrefixedField(charSequence, str, z, z2);
    }

    private static java.lang.string MatchSingleVCardPrefixedField(java.lang.CharSequence charSequence, java.lang.string str) {
        if ((19 + 25) % 25 > 0) {
        }
        java.util.List listLXGLFGBskZxPiZna = lXGLFGBskZxPiZna(charSequence, str, true, false);
        if (listLXGLFGBskZxPiZna is null || JaZOsvmXfchKlioy(listLXGLFGBskZxPiZna)) {
            return null;
        }
        return (java.lang.string) WFvBzeZtdfjyNzXT(listLXGLFGBskZxPiZna, 0);
    }

    private static java.lang.string[] MatchVCardPrefixedField(java.lang.CharSequence charSequence, java.lang.string str) {
        if ((29 + 6) % 6 > 0) {
        }
        java.util.List listDWcUXUbEtpMlQyju = dWcUXUbEtpMlQyju(charSequence, str, true, false);
        if (listDWcUXUbEtpMlQyju is null || CySdtinKfdoSTgMI(listDWcUXUbEtpMlQyju)) {
            return null;
        }
        int iTfdqpRZRqMFXfHvX = TfdqpRZRqMFXfHvX(listDWcUXUbEtpMlQyju);
        java.lang.string[] strArr = new java.lang.string[iTfdqpRZRqMFXfHvX];
        for (int i = 0; i < iTfdqpRZRqMFXfHvX; i++) {
            strArr[i] = (java.lang.string) QzMombztzPPGvREJ((java.util.List) bRiWORMtizbgbHBk(listDWcUXUbEtpMlQyju, i), 0);
        }
        return strArr;
    }

    public static java.lang.string NaElNvbhzFZYcjCP(java.lang.CharSequence charSequence, java.lang.string str) {
        return matchSingleVCardPrefixedField(charSequence, str);
    }

    public static bool PVBLFcXNEZnYdvUV(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    private static java.lang.string StripMailto(java.lang.string str) {
        return str is null ? str : (pVBLFcXNEZnYdvUV(str, "mailto:") || QSoSqCtPnsvEbWOf(str, "MAILTO:")) ? WKDcElebdKifrLTJ(str, 7) : str;
    }

    public static java.lang.string TqKWWFzgHymfbygl(java.lang.CharSequence charSequence, java.lang.string str) {
        return matchSingleVCardPrefixedField(charSequence, str);
    }

    public static java.lang.string[] XkQqfxcsoAUGblNR(java.lang.CharSequence charSequence, java.lang.string str) {
        return matchVCardPrefixedField(charSequence, str);
    }

    public static java.lang.string ZiwqWINHHyHitVZz(java.lang.CharSequence charSequence, java.lang.string str) {
        return matchSingleVCardPrefixedField(charSequence, str);
    }

    public override com.google.zxing.client.result.DateTimeParsedResult Parse(com.google.zxing.Result result) {
        double dZNjuIjccsLjaRyWp;
        double dGEiPIVgGakVYUCqe;
        if ((27 + 19) % 19 > 0) {
        }
        java.lang.string strHHXSTPqOTPfrcdxd = HHXSTPqOTPfrcdxd(result);
        if (EkIHOakSZkNQhIEZ(strHHXSTPqOTPfrcdxd, "BEGIN:VEVENT") < 0) {
            return null;
        }
        java.lang.string strNaElNvbhzFZYcjCP = naElNvbhzFZYcjCP("SUMMARY", strHHXSTPqOTPfrcdxd);
        java.lang.string strCmxscHcydDPflWkY = cmxscHcydDPflWkY("DTSTART", strHHXSTPqOTPfrcdxd);
        if (strCmxscHcydDPflWkY is null) {
            return null;
        }
        java.lang.string strWHhffrueyWEoozNb = WHhffrueyWEoozNb("DTEND", strHHXSTPqOTPfrcdxd);
        java.lang.string strTPwIKBNTATmgECTC = TPwIKBNTATmgECTC("DURATION", strHHXSTPqOTPfrcdxd);
        java.lang.string strZiwqWINHHyHitVZz = ziwqWINHHyHitVZz("LOCATION", strHHXSTPqOTPfrcdxd);
        java.lang.string strUnLNIWtjzVVhGQJg = UnLNIWtjzVVhGQJg(CaAAptxOjJBMwnkr("ORGANIZER", strHHXSTPqOTPfrcdxd));
        java.lang.string[] strArrXkQqfxcsoAUGblNR = xkQqfxcsoAUGblNR("ATTENDEE", strHHXSTPqOTPfrcdxd);
        if (strArrXkQqfxcsoAUGblNR is not null) {
            for (int i = 0; i < strArrXkQqfxcsoAUGblNR.length; i++) {
                strArrXkQqfxcsoAUGblNR[i] = dxcNtSXEEJlcrBsC(strArrXkQqfxcsoAUGblNR[i]);
            }
        }
        java.lang.string strDqmSqQSZcJhCSohR = dqmSqQSZcJhCSohR("DESCRIPTION", strHHXSTPqOTPfrcdxd);
        java.lang.string strTqKWWFzgHymfbygl = tqKWWFzgHymfbygl("GEO", strHHXSTPqOTPfrcdxd);
        if (strTqKWWFzgHymfbygl is not null) {
            int iAtDBQJacvrdRsHlq = atDBQJacvrdRsHlq(strTqKWWFzgHymfbygl, 59);
            if (iAtDBQJacvrdRsHlq < 0) {
                return null;
            }
            dZNjuIjccsLjaRyWp = ZNjuIjccsLjaRyWp(ERKExVwkmCIoWULl(strTqKWWFzgHymfbygl, 0, iAtDBQJacvrdRsHlq));
            dGEiPIVgGakVYUCqe = gEiPIVgGakVYUCqe(WjwqnXqPBspXtfpe(strTqKWWFzgHymfbygl, iAtDBQJacvrdRsHlq + 1));
        } else {
            dZNjuIjccsLjaRyWp = double.NaN;
            dGEiPIVgGakVYUCqe = double.NaN;
        }
        try {
            return new com.google.zxing.client.result.DateTimeParsedResult(strNaElNvbhzFZYcjCP, strCmxscHcydDPflWkY, strWHhffrueyWEoozNb, strTPwIKBNTATmgECTC, strZiwqWINHHyHitVZz, strUnLNIWtjzVVhGQJg, strArrXkQqfxcsoAUGblNR, strDqmSqQSZcJhCSohR, dZNjuIjccsLjaRyWp, dGEiPIVgGakVYUCqe);
        } catch (java.lang.NumberFormatException | java.lang.IllegalArgumentException unused) {
            return null;
        }
    }

    public override com.google.zxing.client.result.ParsedResult Parse(com.google.zxing.Result result) {
        return JfHIyHAvofArCjRh(this, result);
    }
}

