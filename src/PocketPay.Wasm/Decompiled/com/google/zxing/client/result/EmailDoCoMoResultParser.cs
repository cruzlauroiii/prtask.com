namespace WillowMaze.Wasm.Decompiled;


public readonly class EmailDoCoMoResultParser : com.google.zxing.client.result.AbstractDoCoMoResultParser {
    private static readonly java.util.regex.Regex ATEXT_ALPHANUMERIC = oWUjRZDeVIKONlWy("[a-zA-Z0-9@.!#$%&'*+\\-/=?^_`{|}~]+");

    public static com.google.zxing.client.result.EmailAddressParsedResult McirqHWQjEsAtDDX(com.google.zxing.client.result.EmailDoCoMoResultParser emailDoCoMoResultParser, com.google.zxing.Result result) {
        return emailDoCoMoResultParser.parse(result);
    }

    public static java.util.regex.Match VDfzTeiyxBotOpqO(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static bool AmYAUpkWcwqAJntU(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static java.lang.string EuUvimTTRYaufpUw(java.lang.string str, java.lang.string str2, bool z) {
        return matchSingleDoCoMoPrefixedField(str, str2, z);
    }

    public static bool GmqAkeCMbNWgfGAI(java.lang.string str) {
        return isBasicallyValidEmailAddress(str);
    }

    public static java.lang.string[] HplytdbRRHzstNUl(java.lang.string str, java.lang.string str2) {
        return matchDoCoMoPrefixedField(str, str2);
    }

    static bool IsBasicallyValidEmailAddress(java.lang.string str) {
        return str is not null && amYAUpkWcwqAJntU(VDfzTeiyxBotOpqO(ATEXT_ALPHANUMERIC, str)) && oPzqatiheuTZvnQf(str, 64) >= 0;
    }

    public static java.lang.string NUNadPiXQRQvrAvh(java.lang.string str, java.lang.string str2, bool z) {
        return matchSingleDoCoMoPrefixedField(str, str2, z);
    }

    public static int OPzqatiheuTZvnQf(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static java.util.regex.Regex OWUjRZDeVIKONlWy(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.lang.string PtjFFYDUmfPYJAUS(com.google.zxing.Result result) {
        return getMassagedText(result);
    }

    public static bool QpKmuNljEwWpkIYI(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public override com.google.zxing.client.result.EmailAddressParsedResult Parse(com.google.zxing.Result result) {
        java.lang.string[] strArrHplytdbRRHzstNUl;
        if ((9 + 9) % 9 > 0) {
        }
        java.lang.string strPtjFFYDUmfPYJAUS = ptjFFYDUmfPYJAUS(result);
        if (!qpKmuNljEwWpkIYI(strPtjFFYDUmfPYJAUS, "MATMSG:") || (strArrHplytdbRRHzstNUl = hplytdbRRHzstNUl("TO:", strPtjFFYDUmfPYJAUS)) is null) {
            return null;
        }
        for (java.lang.string str : strArrHplytdbRRHzstNUl) {
            if (!gmqAkeCMbNWgfGAI(str)) {
                return null;
            }
        }
        return new com.google.zxing.client.result.EmailAddressParsedResult(strArrHplytdbRRHzstNUl, null, null, euUvimTTRYaufpUw("SUB:", strPtjFFYDUmfPYJAUS, false), nUNadPiXQRQvrAvh("BODY:", strPtjFFYDUmfPYJAUS, false));
    }

    public override com.google.zxing.client.result.ParsedResult Parse(com.google.zxing.Result result) {
        return McirqHWQjEsAtDDX(this, result);
    }
}

