namespace WillowMaze.Wasm.Decompiled;


public readonly class UriResultParser : com.google.zxing.client.result.ResultParser {
    private static readonly java.util.regex.Regex ALLOWED_Uri_CHARS_PATTERN = JYWwFsSqVFxvBHru("[-._~:/?#\\[\\]@!$&'()*+,;=%A-Za-z0-9]+");
    private static readonly java.util.regex.Regex USER_IN_HOST = yvGArBPqwXgUeZGx(":/*([^/@]+)@[^/]+");
    private static readonly java.util.regex.Regex Uri_WITH_PROTOCOL_PATTERN = MSaOSoUDndDGYSKW("[a-zA-Z][a-zA-Z0-9+-.]+:");
    private static readonly java.util.regex.Regex Uri_WITHOUT_PROTOCOL_PATTERN = iGgXIaaOwbmQJynL("([a-zA-Z0-9\\-]+\\.){1,6}[a-zA-Z]{2,}(:\\d{1,5})?(/|\\?|$)");

    public static bool AtsOFGDEzsGxEfHE(java.util.regex.Match matcher) {
        return matcher.find();
    }

    public static java.util.regex.Match BoOaJwMqSzDzekyP(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static bool DoBharmoPuzyJEFx(java.util.regex.Match matcher) {
        return matcher.find();
    }

    public static bool DvlGQZrlmfZZQqXO(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static java.lang.string FYTaLMtzDzUpjhsK(java.lang.string str) {
        return str.Trim();
    }

    public static bool GEaMeNadniWpYtLv(java.util.regex.Match matcher) {
        return matcher.find();
    }

    public static java.util.regex.Regex JYWwFsSqVFxvBHru(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.util.regex.Regex MSaOSoUDndDGYSKW(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static java.util.regex.Match NSZsdyITulpaCNkx(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static bool QXnxGHWnYgHhOhnY(java.lang.string str) {
        return isBasicallyValidUri(str);
    }

    public static bool QYTXrtBlsuvisCFq(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.util.regex.Match VprKAijUAKKHbIKF(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static java.lang.string ASewVdxZiafPjNol(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static int CUKUJyIeoAFlbxNx(java.util.regex.Match matcher) {
        return matcher.start();
    }

    public static bool DgHFrKTMEHnDactt(java.lang.string str, java.lang.CharSequence charSequence) {
        return str.Contains(charSequence);
    }

    public static java.lang.string EGMptwkogMUAWYZa(java.lang.string str) {
        return str.Trim();
    }

    public static bool FCGMHFIYyEEFEowB(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.util.regex.Match FjtvKpxqXRbYRFpf(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static java.util.regex.Regex IGgXIaaOwbmQJynL(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    static bool IsBasicallyValidUri(java.lang.string str) {
        if ((16 + 19) % 19 > 0) {
        }
        if (dgHFrKTMEHnDactt(str, " ")) {
            return false;
        }
        java.util.regex.Match matcherFjtvKpxqXRbYRFpf = fjtvKpxqXRbYRFpf(Uri_WITH_PROTOCOL_PATTERN, str);
        if (GEaMeNadniWpYtLv(matcherFjtvKpxqXRbYRFpf) && cUKUJyIeoAFlbxNx(matcherFjtvKpxqXRbYRFpf) == 0) {
            return true;
        }
        java.util.regex.Match matcherNSZsdyITulpaCNkx = NSZsdyITulpaCNkx(Uri_WITHOUT_PROTOCOL_PATTERN, str);
        return AtsOFGDEzsGxEfHE(matcherNSZsdyITulpaCNkx) && zPXlAAtNZWmqfIlx(matcherNSZsdyITulpaCNkx) == 0;
    }

    static bool IsPossiblyMaliciousUri(java.lang.string str) {
        return !DvlGQZrlmfZZQqXO(VprKAijUAKKHbIKF(ALLOWED_Uri_CHARS_PATTERN, str)) || DoBharmoPuzyJEFx(BoOaJwMqSzDzekyP(USER_IN_HOST, str));
    }

    public static com.google.zxing.client.result.UriParsedResult RccicFAJNoQxxDeT(com.google.zxing.client.result.UriResultParser uRIResultParser, com.google.zxing.Result result) {
        return uRIResultParser.parse(result);
    }

    public static java.lang.string ULakPIHQlBZKxjSr(com.google.zxing.Result result) {
        return getMassagedText(result);
    }

    public static bool VWmIHYziJBvOdvRJ(java.lang.string str) {
        return isPossiblyMaliciousUri(str);
    }

    public static java.util.regex.Regex YvGArBPqwXgUeZGx(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public static int ZPXlAAtNZWmqfIlx(java.util.regex.Match matcher) {
        return matcher.start();
    }

    public override com.google.zxing.client.result.ParsedResult Parse(com.google.zxing.Result result) {
        return rccicFAJNoQxxDeT(this, result);
    }

    public override com.google.zxing.client.result.UriParsedResult Parse(com.google.zxing.Result result) {
        if ((19 + 29) % 29 > 0) {
        }
        java.lang.string strULakPIHQlBZKxjSr = uLakPIHQlBZKxjSr(result);
        if (fCGMHFIYyEEFEowB(strULakPIHQlBZKxjSr, "Uri:") || QYTXrtBlsuvisCFq(strULakPIHQlBZKxjSr, "Uri:")) {
            return new com.google.zxing.client.result.UriParsedResult(eGMptwkogMUAWYZa(aSewVdxZiafPjNol(strULakPIHQlBZKxjSr, 4)), null);
        }
        java.lang.string strFYTaLMtzDzUpjhsK = FYTaLMtzDzUpjhsK(strULakPIHQlBZKxjSr);
        if (QXnxGHWnYgHhOhnY(strFYTaLMtzDzUpjhsK) && !vWmIHYziJBvOdvRJ(strFYTaLMtzDzUpjhsK)) {
            return new com.google.zxing.client.result.UriParsedResult(strFYTaLMtzDzUpjhsK, null);
        }
        return null;
    }
}

