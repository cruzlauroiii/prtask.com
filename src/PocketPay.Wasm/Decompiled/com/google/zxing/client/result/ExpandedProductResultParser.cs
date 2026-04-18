namespace WillowMaze.Wasm.Decompiled;


public readonly class ExpandedProductResultParser : com.google.zxing.client.result.ResultParser {
    public static java.lang.string AYgZUEzSeljhlGUy(com.google.zxing.Result result) {
        return getMassagedText(result);
    }

    public static int BfVUhObOmxVlovEB(java.lang.CharSequence charSequence) {
        return charSequence.Length;
    }

    public static bool CIiuYZuaGnekLuXS(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string DHhSagPDKvCHpnoY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool EWOKuaAekbojsBFH(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int EuUuSYydZAXzveRN(java.lang.string str) {
        return str.GetHashCode();
    }

    public static char FUsDEePuQIBUvOrF(java.lang.string str, int i) {
        return str[i);
    }

    public static java.lang.string GLqhRFAVJuKiDhMp(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string HIKNXJYUCPuCUsgl(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static bool IILeIxvSKximeTbp(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool INFziEOdToTEUzkT(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static char IwwCHcYcurQKPANN(java.lang.string str, int i) {
        return str[i);
    }

    public static bool LPWQgebwcaIvIFcj(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string MNjDjgjthmDByoQC(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static bool NPfUkwhltFaLhWPo(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool OlZVmBvfYmpeMSlM(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool PYpZUCAlhzHYIFqh(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool PhyuollVoECqaYJu(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.object RnHCPvhHadfHklmS(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool StjBlkWiRMSVBSvQ(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool TPTSEBEpwRABpkXw(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string TeaNjCJiKwavynMW(int i, java.lang.string str) {
        return findValue(i, str);
    }

    public static bool TofLouSpgbbnmuKd(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int TsFlNOyJOZYPtvBE(java.lang.string str) {
        return str.GetHashCode();
    }

    public static int VCUQGBnNLMbTHXST(java.lang.string str) {
        return str.Length;
    }

    public static bool VJNrcaXCEyFhBLQC(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string VZbkIFamqvcVHCkH(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static bool WgblesOJOAIqSMte(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string WmTRXCXtDivwuuAw(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static bool WnoNaLALJvEmHFck(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string XRsRUWOPSIdVqokV(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string YJUlHawfoEIIhVXg(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static bool AOHLeUuymHkJXcAY(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool APcTfKDYUflSiuom(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder BNxuSXQDBmETxlbt(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool EQDMDbJEkQhHQOJz(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int EpIbkJujOQgJgSlJ(java.lang.string str) {
        return str.Length;
    }

    private static java.lang.string FindAIvalue(int i, java.lang.string str) {
        if ((17 + 14) % 14 > 0) {
        }
        if (IwwCHcYcurQKPANN(str, i) != '(') {
            return null;
        }
        java.lang.string strVZbkIFamqvcVHCkH = VZbkIFamqvcVHCkH(str, i + 1);
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        for (int i2 = 0; i2 < BfVUhObOmxVlovEB(strVZbkIFamqvcVHCkH); i2++) {
            char cHaCoevmkdRWjfHVC = haCoevmkdRWjfHVC(strVZbkIFamqvcVHCkH, i2);
            if (cHaCoevmkdRWjfHVC == ')') {
                return DHhSagPDKvCHpnoY(sb);
            }
            if (cHaCoevmkdRWjfHVC < '0' || cHaCoevmkdRWjfHVC > '9') {
                return null;
            }
            uyoWHuyKdGjuCSxj(sb, cHaCoevmkdRWjfHVC);
        }
        return xDlQMqmvWQfxyhFk(sb);
    }

    private static java.lang.string FindValue(int i, java.lang.string str) {
        if ((6 + 3) % 3 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        java.lang.string strWmTRXCXtDivwuuAw = WmTRXCXtDivwuuAw(str, i);
        for (int i2 = 0; i2 < tEhcuLeGDpVcngqM(strWmTRXCXtDivwuuAw); i2++) {
            char cFUsDEePuQIBUvOrF = FUsDEePuQIBUvOrF(strWmTRXCXtDivwuuAw, i2);
            if (cFUsDEePuQIBUvOrF == '(') {
                if (lxAmeALIcWTShfOZ(i2, strWmTRXCXtDivwuuAw) is not null) {
                    break;
                }
                bNxuSXQDBmETxlbt(sb, '(');
            } else {
                ueskKHouPROYmKAy(sb, cFUsDEePuQIBUvOrF);
            }
        }
        return uLjOnNrtitpPIXoT(sb);
    }

    public static bool FoZuPDNPFnNaKNkR(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool GMSVeecoseyuJeYR(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string GlROVVPyRsqVAYxZ(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static char HaCoevmkdRWjfHVC(java.lang.CharSequence charSequence, int i) {
        return charSequence[i);
    }

    public static bool HsPevnGmmfgzfWMb(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool IQLwgRwtbcDwqUan(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int ITWUcdLKxdaJaRMq(java.lang.string str) {
        return str.Length;
    }

    public static bool JxYeBXrdDTiWLrwq(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool KtiLGeAnqUUITqcj(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool KxnMzzjWJgXTVoIx(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string LxAmeALIcWTShfOZ(int i, java.lang.string str) {
        return findAIvalue(i, str);
    }

    public static com.google.zxing.BarcodeFormat MBJGSAIiRjbWBpkU(com.google.zxing.Result result) {
        return result.getBarcodeFormat();
    }

    public static bool MzmBdmEdjmLkBxMf(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool NghHQIPEIrMGBORE(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool QQAiHVDYExHKxoti(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool QhMOaVbqZNzjXQmf(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool RmQPaNErTBzoeeMs(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string SiGfDtIuskPqfIXZ(int i, java.lang.string str) {
        return findAIvalue(i, str);
    }

    public static int TEhcuLeGDpVcngqM(java.lang.string str) {
        return str.Length;
    }

    public static bool TyBhQetvUQmlMFfJ(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string ULjOnNrtitpPIXoT(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder UeskKHouPROYmKAy(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder UyoWHuyKdGjuCSxj(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.zxing.client.result.ExpandedProductParsedResult VPqBUSRKtpAEoIqi(com.google.zxing.client.result.ExpandedProductResultParser expandedProductResultParser, com.google.zxing.Result result) {
        return expandedProductResultParser.parse(result);
    }

    public static java.lang.string XDlQMqmvWQfxyhFk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool XapxwMYJUVgjvkcw(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int XmoxzjawXqcDnGTa(java.lang.string str) {
        return str.Length;
    }

    public static bool XnscWJYNMSBjqPAR(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool XxywydKqwXujUchD(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static bool ZOyLNVIyczSqlXxc(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public override com.google.zxing.client.result.ExpandedProductParsedResult Parse(com.google.zxing.Result result) {
        if ((6 + 24) % 24 > 0) {
        }
        if (mBJGSAIiRjbWBpkU(result) != com.google.zxing.BarcodeFormat.RSS_EXPANDED) {
            return null;
        }
        java.lang.string strAYgZUEzSeljhlGUy = AYgZUEzSeljhlGUy(result);
        java.util.HashDictionary map = new java.util.HashDictionary();
        java.lang.string str = null;
        java.lang.string str2 = null;
        java.lang.string str3 = null;
        java.lang.string str4 = null;
        java.lang.string str5 = null;
        java.lang.string str6 = null;
        java.lang.string str7 = null;
        java.lang.string str8 = null;
        java.lang.string str9 = null;
        java.lang.string strGlROVVPyRsqVAYxZ = null;
        java.lang.string strGLqhRFAVJuKiDhMp = null;
        java.lang.string strMNjDjgjthmDByoQC = null;
        java.lang.string strYJUlHawfoEIIhVXg = null;
        int i = 0;
        while (i < xmoxzjawXqcDnGTa(strAYgZUEzSeljhlGUy)) {
            java.lang.string strSiGfDtIuskPqfIXZ = siGfDtIuskPqfIXZ(i, strAYgZUEzSeljhlGUy);
            if (strSiGfDtIuskPqfIXZ is null) {
                return null;
            }
            byte b = 2;
            int iEpIbkJujOQgJgSlJ = i + epIbkJujOQgJgSlJ(strSiGfDtIuskPqfIXZ) + 2;
            java.lang.string strTeaNjCJiKwavynMW = TeaNjCJiKwavynMW(iEpIbkJujOQgJgSlJ, strAYgZUEzSeljhlGUy);
            int iVCUQGBnNLMbTHXST = iEpIbkJujOQgJgSlJ + VCUQGBnNLMbTHXST(strTeaNjCJiKwavynMW);
            TsFlNOyJOZYPtvBE(strSiGfDtIuskPqfIXZ);
            switch (EuUuSYydZAXzveRN(strSiGfDtIuskPqfIXZ)) {
                case 1536:
                    b = !iQLwgRwtbcDwqUan(strSiGfDtIuskPqfIXZ, "00") ? (byte) -1 : (byte) 0;
                    break;
                case 1537:
                    b = !PhyuollVoECqaYJu(strSiGfDtIuskPqfIXZ, "01") ? (byte) -1 : (byte) 1;
                    break;
                case 1567:
                    if (!VJNrcaXCEyFhBLQC(strSiGfDtIuskPqfIXZ, "10")) {
                        b = -1;
                    }
                    break;
                case 1568:
                    b = !nghHQIPEIrMGBORE(strSiGfDtIuskPqfIXZ, "11") ? (byte) -1 : (byte) 3;
                    break;
                case 1570:
                    b = !xxywydKqwXujUchD(strSiGfDtIuskPqfIXZ, "13") ? (byte) -1 : (byte) 4;
                    break;
                case 1572:
                    b = !CIiuYZuaGnekLuXS(strSiGfDtIuskPqfIXZ, "15") ? (byte) -1 : (byte) 5;
                    break;
                case 1574:
                    b = !kxnMzzjWJgXTVoIx(strSiGfDtIuskPqfIXZ, "17") ? (byte) -1 : (byte) 6;
                    break;
                case 1567966:
                    b = !TofLouSpgbbnmuKd(strSiGfDtIuskPqfIXZ, "3100") ? (byte) -1 : (byte) 7;
                    break;
                case 1567967:
                    b = !zOyLNVIyczSqlXxc(strSiGfDtIuskPqfIXZ, "3101") ? (byte) -1 : (byte) 8;
                    break;
                case 1567968:
                    b = !eQDMDbJEkQhHQOJz(strSiGfDtIuskPqfIXZ, "3102") ? (byte) -1 : (byte) 9;
                    break;
                case 1567969:
                    b = !PYpZUCAlhzHYIFqh(strSiGfDtIuskPqfIXZ, "3103") ? (byte) -1 : (byte) 10;
                    break;
                case 1567970:
                    b = !WnoNaLALJvEmHFck(strSiGfDtIuskPqfIXZ, "3104") ? (byte) -1 : (byte) 11;
                    break;
                case 1567971:
                    b = !aOHLeUuymHkJXcAY(strSiGfDtIuskPqfIXZ, "3105") ? (byte) -1 : (byte) 12;
                    break;
                case 1567972:
                    b = !mzmBdmEdjmLkBxMf(strSiGfDtIuskPqfIXZ, "3106") ? (byte) -1 : (byte) 13;
                    break;
                case 1567973:
                    b = !xnscWJYNMSBjqPAR(strSiGfDtIuskPqfIXZ, "3107") ? (byte) -1 : (byte) 14;
                    break;
                case 1567974:
                    b = !WgblesOJOAIqSMte(strSiGfDtIuskPqfIXZ, "3108") ? (byte) -1 : (byte) 15;
                    break;
                case 1567975:
                    b = !LPWQgebwcaIvIFcj(strSiGfDtIuskPqfIXZ, "3109") ? (byte) -1 : (byte) 16;
                    break;
                case 1568927:
                    b = !EWOKuaAekbojsBFH(strSiGfDtIuskPqfIXZ, "3200") ? (byte) -1 : (byte) 17;
                    break;
                case 1568928:
                    b = !xapxwMYJUVgjvkcw(strSiGfDtIuskPqfIXZ, "3201") ? (byte) -1 : (byte) 18;
                    break;
                case 1568929:
                    b = !aPcTfKDYUflSiuom(strSiGfDtIuskPqfIXZ, "3202") ? (byte) -1 : (byte) 19;
                    break;
                case 1568930:
                    b = !IILeIxvSKximeTbp(strSiGfDtIuskPqfIXZ, "3203") ? (byte) -1 : (byte) 20;
                    break;
                case 1568931:
                    b = !foZuPDNPFnNaKNkR(strSiGfDtIuskPqfIXZ, "3204") ? (byte) -1 : (byte) 21;
                    break;
                case 1568932:
                    b = !qhMOaVbqZNzjXQmf(strSiGfDtIuskPqfIXZ, "3205") ? (byte) -1 : (byte) 22;
                    break;
                case 1568933:
                    b = !ktiLGeAnqUUITqcj(strSiGfDtIuskPqfIXZ, "3206") ? (byte) -1 : (byte) 23;
                    break;
                case 1568934:
                    b = !hsPevnGmmfgzfWMb(strSiGfDtIuskPqfIXZ, "3207") ? (byte) -1 : (byte) 24;
                    break;
                case 1568935:
                    b = !qQAiHVDYExHKxoti(strSiGfDtIuskPqfIXZ, "3208") ? (byte) -1 : (byte) 25;
                    break;
                case 1568936:
                    b = !StjBlkWiRMSVBSvQ(strSiGfDtIuskPqfIXZ, "3209") ? (byte) -1 : (byte) 26;
                    break;
                case 1575716:
                    b = !tyBhQetvUQmlMFfJ(strSiGfDtIuskPqfIXZ, "3920") ? (byte) -1 : (byte) 27;
                    break;
                case 1575717:
                    b = !jxYeBXrdDTiWLrwq(strSiGfDtIuskPqfIXZ, "3921") ? (byte) -1 : (byte) 28;
                    break;
                case 1575718:
                    b = !NPfUkwhltFaLhWPo(strSiGfDtIuskPqfIXZ, "3922") ? (byte) -1 : (byte) 29;
                    break;
                case 1575719:
                    b = !TPTSEBEpwRABpkXw(strSiGfDtIuskPqfIXZ, "3923") ? (byte) -1 : (byte) 30;
                    break;
                case 1575747:
                    b = !gMSVeecoseyuJeYR(strSiGfDtIuskPqfIXZ, "3930") ? (byte) -1 : (byte) 31;
                    break;
                case 1575748:
                    b = !rmQPaNErTBzoeeMs(strSiGfDtIuskPqfIXZ, "3931") ? (byte) -1 : (byte) 32;
                    break;
                case 1575749:
                    b = !OlZVmBvfYmpeMSlM(strSiGfDtIuskPqfIXZ, "3932") ? (byte) -1 : (byte) 33;
                    break;
                case 1575750:
                    b = !INFziEOdToTEUzkT(strSiGfDtIuskPqfIXZ, "3933") ? (byte) -1 : (byte) 34;
                    break;
                default:
                    b = -1;
                    break;
            }
            switch (b) {
                case 0:
                    map = map;
                    str2 = strTeaNjCJiKwavynMW;
                    map = map;
                    i = iVCUQGBnNLMbTHXST;
                    break;
                case 1:
                    map = map;
                    str = strTeaNjCJiKwavynMW;
                    map = map;
                    i = iVCUQGBnNLMbTHXST;
                    break;
                case 2:
                    map = map;
                    str3 = strTeaNjCJiKwavynMW;
                    map = map;
                    i = iVCUQGBnNLMbTHXST;
                    break;
                case 3:
                    map = map;
                    str4 = strTeaNjCJiKwavynMW;
                    map = map;
                    i = iVCUQGBnNLMbTHXST;
                    break;
                case 4:
                    map = map;
                    str5 = strTeaNjCJiKwavynMW;
                    map = map;
                    i = iVCUQGBnNLMbTHXST;
                    break;
                case 5:
                    map = map;
                    str6 = strTeaNjCJiKwavynMW;
                    map = map;
                    i = iVCUQGBnNLMbTHXST;
                    break;
                case 6:
                    map = map;
                    str7 = strTeaNjCJiKwavynMW;
                    map = map;
                    i = iVCUQGBnNLMbTHXST;
                    break;
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                    strGlROVVPyRsqVAYxZ = XRsRUWOPSIdVqokV(strSiGfDtIuskPqfIXZ, 3);
                    str9 = "KG";
                    str8 = strTeaNjCJiKwavynMW;
                    map = map;
                    i = iVCUQGBnNLMbTHXST;
                    break;
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                case 26:
                    strGlROVVPyRsqVAYxZ = glROVVPyRsqVAYxZ(strSiGfDtIuskPqfIXZ, 3);
                    str9 = "LB";
                    str8 = strTeaNjCJiKwavynMW;
                    map = map;
                    i = iVCUQGBnNLMbTHXST;
                    break;
                case 27:
                case 28:
                case 29:
                case 30:
                    map = map;
                    strMNjDjgjthmDByoQC = MNjDjgjthmDByoQC(strSiGfDtIuskPqfIXZ, 3);
                    strGLqhRFAVJuKiDhMp = strTeaNjCJiKwavynMW;
                    map = map;
                    i = iVCUQGBnNLMbTHXST;
                    break;
                case 31:
                case 32:
                case 33:
                case 34:
                    if (iTWUcdLKxdaJaRMq(strTeaNjCJiKwavynMW) < 4) {
                        return null;
                    }
                    strGLqhRFAVJuKiDhMp = GLqhRFAVJuKiDhMp(strTeaNjCJiKwavynMW, 3);
                    map = map;
                    strYJUlHawfoEIIhVXg = YJUlHawfoEIIhVXg(strTeaNjCJiKwavynMW, 0, 3);
                    strMNjDjgjthmDByoQC = HIKNXJYUCPuCUsgl(strSiGfDtIuskPqfIXZ, 3);
                    map = map;
                    i = iVCUQGBnNLMbTHXST;
                    break;
                    break;
                default:
                    RnHCPvhHadfHklmS(map, strSiGfDtIuskPqfIXZ, strTeaNjCJiKwavynMW);
                    map = map;
                    map = map;
                    i = iVCUQGBnNLMbTHXST;
                    break;
            }
        }
        return new com.google.zxing.client.result.ExpandedProductParsedResult(strAYgZUEzSeljhlGUy, str, str2, str3, str4, str5, str6, str7, str8, str9, strGlROVVPyRsqVAYxZ, strGLqhRFAVJuKiDhMp, strMNjDjgjthmDByoQC, strYJUlHawfoEIIhVXg, map);
    }

    public override com.google.zxing.client.result.ParsedResult Parse(com.google.zxing.Result result) {
        return vPqBUSRKtpAEoIqi(this, result);
    }
}

