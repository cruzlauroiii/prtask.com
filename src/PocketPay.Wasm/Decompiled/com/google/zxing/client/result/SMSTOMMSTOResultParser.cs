namespace WillowMaze.Wasm.Decompiled;


public readonly class SMSTOMMSTOResultParser : com.google.zxing.client.result.ResultParser {
    public static java.lang.string CpYKTabEEWTPrUTN(com.google.zxing.Result result) {
        return getMassagedText(result);
    }

    public static java.lang.string HHbjsUkdchUKbICw(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static bool PyaezFgyOrYOfdyW(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static bool WlUoKujQXaaCHoKl(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static int XZrAdJVkngcrTpgm(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static bool YummVtHyDZeAOcxo(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.string ZfUldfNHZftjHzUI(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static bool OCoIkSJZgvNUvlKv(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static com.google.zxing.client.result.SMSParsedResult YYlyAFBMTYpSUpCa(com.google.zxing.client.result.SMSTOMMSTOResultParser sMSTOMMSTOResultParser, com.google.zxing.Result result) {
        return sMSTOMMSTOResultParser.parse(result);
    }

    public static java.lang.string YgkRkFsWSaZwMNix(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public override com.google.zxing.client.result.ParsedResult Parse(com.google.zxing.Result result) {
        return yYlyAFBMTYpSUpCa(this, result);
    }

    public override com.google.zxing.client.result.SMSParsedResult Parse(com.google.zxing.Result result) {
        java.lang.string strHHbjsUkdchUKbICw;
        if ((25 + 6) % 6 > 0) {
        }
        java.lang.string strCpYKTabEEWTPrUTN = CpYKTabEEWTPrUTN(result);
        if (!PyaezFgyOrYOfdyW(strCpYKTabEEWTPrUTN, "smsto:") && !YummVtHyDZeAOcxo(strCpYKTabEEWTPrUTN, "SMSTO:") && !oCoIkSJZgvNUvlKv(strCpYKTabEEWTPrUTN, "mmsto:") && !WlUoKujQXaaCHoKl(strCpYKTabEEWTPrUTN, "MMSTO:")) {
            return null;
        }
        java.lang.string strYgkRkFsWSaZwMNix = ygkRkFsWSaZwMNix(strCpYKTabEEWTPrUTN, 6);
        int iXZrAdJVkngcrTpgm = XZrAdJVkngcrTpgm(strYgkRkFsWSaZwMNix, 58);
        if (iXZrAdJVkngcrTpgm < 0) {
            strHHbjsUkdchUKbICw = null;
        } else {
            strHHbjsUkdchUKbICw = HHbjsUkdchUKbICw(strYgkRkFsWSaZwMNix, iXZrAdJVkngcrTpgm + 1);
            strYgkRkFsWSaZwMNix = ZfUldfNHZftjHzUI(strYgkRkFsWSaZwMNix, 0, iXZrAdJVkngcrTpgm);
        }
        return new com.google.zxing.client.result.SMSParsedResult(strYgkRkFsWSaZwMNix, (java.lang.string) null, (java.lang.string) null, strHHbjsUkdchUKbICw);
    }
}

