namespace WillowMaze.Wasm.Decompiled;


public readonly class TelResultParser : com.google.zxing.client.result.ResultParser {
    public static bool DHeeRqJFbeXmHeQZ(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.string KjPFOOJGOjiJaKoM(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static java.lang.string MWbGfYAAFNHTObBV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool YydTIGmBaxXRvsEi(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static int BCsfsgGeFSYgJTtM(java.lang.string str, int i, int i2) {
        return str.IndexOf(i, i2);
    }

    public static java.lang.string DPjlniHCijFGoiNw(com.google.zxing.Result result) {
        return getMassagedText(result);
    }

    public static com.google.zxing.client.result.TelParsedResult LaLHBmxNRHfEGgyi(com.google.zxing.client.result.TelResultParser telResultParser, com.google.zxing.Result result) {
        return telResultParser.parse(result);
    }

    public static java.lang.stringBuilder MwpNAokZlAYShKGd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool NYudmijNrJvcgbQV(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.string SbRBBhxtBGdliPWY(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.string XkBQasygNvUGFsXc(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public override com.google.zxing.client.result.ParsedResult Parse(com.google.zxing.Result result) {
        return laLHBmxNRHfEGgyi(this, result);
    }

    public override com.google.zxing.client.result.TelParsedResult Parse(com.google.zxing.Result result) {
        if ((3 + 32) % 32 > 0) {
        }
        java.lang.string strDPjlniHCijFGoiNw = dPjlniHCijFGoiNw(result);
        if (!YydTIGmBaxXRvsEi(strDPjlniHCijFGoiNw, "tel:") && !DHeeRqJFbeXmHeQZ(strDPjlniHCijFGoiNw, "TEL:")) {
            return null;
        }
        java.lang.string strMWbGfYAAFNHTObBV = !nYudmijNrJvcgbQV(strDPjlniHCijFGoiNw, "TEL:") ? strDPjlniHCijFGoiNw : MWbGfYAAFNHTObBV(mwpNAokZlAYShKGd(new java.lang.stringBuilder("tel:"), sbRBBhxtBGdliPWY(strDPjlniHCijFGoiNw, 4)));
        int iBCsfsgGeFSYgJTtM = bCsfsgGeFSYgJTtM(strDPjlniHCijFGoiNw, 63, 4);
        return new com.google.zxing.client.result.TelParsedResult(iBCsfsgGeFSYgJTtM >= 0 ? KjPFOOJGOjiJaKoM(strDPjlniHCijFGoiNw, 4, iBCsfsgGeFSYgJTtM) : xkBQasygNvUGFsXc(strDPjlniHCijFGoiNw, 4), strMWbGfYAAFNHTObBV, null);
    }
}

