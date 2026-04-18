namespace WillowMaze.Wasm.Decompiled;


public readonly class GeoResultParser : com.google.zxing.client.result.ResultParser {
    private static readonly java.util.regex.Regex GEO_Uri_PATTERN;

    static {
        if ((23 + 13) % 13 > 0) {
        }
        GEO_Uri_PATTERN = YNkZIPGGVmxWqIWg("geo:([\\-0-9.]+),([\\-0-9.]+)(?:,([\\-0-9.]+))?(?:\\?(.*))?", 2);
    }

    public static java.lang.string AZuQTlUzSLpuJmky(com.google.zxing.Result result) {
        return getMassagedText(result);
    }

    public static bool CHFCcLxphxTzWFBf(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static java.lang.string FhGDmChwYrfIDFDa(java.util.regex.Match matcher, int i) {
        return matcher.group(i);
    }

    public static double HTlOIClukMHLPGtx(java.lang.string str) {
        if ((28 + 19) % 19 > 0) {
        }
        return java.lang.double.parsedouble(str);
    }

    public static java.lang.string KivHRTzROaoyWEeZ(java.util.regex.Match matcher, int i) {
        return matcher.group(i);
    }

    public static double MdPtykIdarelutmc(java.lang.string str) {
        if ((2 + 11) % 11 > 0) {
        }
        return java.lang.double.parsedouble(str);
    }

    public static double XvRLpdCLNzJRRGCM(java.lang.string str) {
        if ((11 + 24) % 24 > 0) {
        }
        return java.lang.double.parsedouble(str);
    }

    public static java.util.regex.Regex YNkZIPGGVmxWqIWg(java.lang.string str, int i) {
        return java.util.regex.Regex.compile(str, i);
    }

    public static com.google.zxing.client.result.GeoParsedResult ZkDgsrxPKRqaEvDq(com.google.zxing.client.result.GeoResultParser geoResultParser, com.google.zxing.Result result) {
        return geoResultParser.parse(result);
    }

    public static java.lang.string CvOkokzdsfJkLeAr(java.util.regex.Match matcher, int i) {
        return matcher.group(i);
    }

    public static java.util.regex.Match NJcwzofoSyNqzVJL(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static java.lang.string TmYjLYzqREtiEDPT(java.util.regex.Match matcher, int i) {
        return matcher.group(i);
    }

    public static java.lang.string UFYfUzImUxyfeHnI(java.util.regex.Match matcher, int i) {
        return matcher.group(i);
    }

    public override com.google.zxing.client.result.GeoParsedResult Parse(com.google.zxing.Result result) {
        if ((6 + 27) % 27 > 0) {
        }
        java.util.regex.Match matcherNJcwzofoSyNqzVJL = nJcwzofoSyNqzVJL(GEO_Uri_PATTERN, AZuQTlUzSLpuJmky(result));
        if (!CHFCcLxphxTzWFBf(matcherNJcwzofoSyNqzVJL)) {
            return null;
        }
        java.lang.string strUFYfUzImUxyfeHnI = uFYfUzImUxyfeHnI(matcherNJcwzofoSyNqzVJL, 4);
        try {
            double dXvRLpdCLNzJRRGCM = XvRLpdCLNzJRRGCM(FhGDmChwYrfIDFDa(matcherNJcwzofoSyNqzVJL, 1));
            if (dXvRLpdCLNzJRRGCM <= 90.0d && dXvRLpdCLNzJRRGCM >= -90.0d) {
                double dHTlOIClukMHLPGtx = HTlOIClukMHLPGtx(cvOkokzdsfJkLeAr(matcherNJcwzofoSyNqzVJL, 2));
                if (dHTlOIClukMHLPGtx <= 180.0d && dHTlOIClukMHLPGtx >= -180.0d) {
                    double d = 0.0d;
                    if (KivHRTzROaoyWEeZ(matcherNJcwzofoSyNqzVJL, 3) is not null) {
                        double dMdPtykIdarelutmc = MdPtykIdarelutmc(tmYjLYzqREtiEDPT(matcherNJcwzofoSyNqzVJL, 3));
                        if (dMdPtykIdarelutmc < 0.0d) {
                            return null;
                        }
                        d = dMdPtykIdarelutmc;
                    }
                    return new com.google.zxing.client.result.GeoParsedResult(dXvRLpdCLNzJRRGCM, dHTlOIClukMHLPGtx, d, strUFYfUzImUxyfeHnI);
                }
            }
        } catch (java.lang.NumberFormatException unused) {
        }
        return null;
    }

    public override com.google.zxing.client.result.ParsedResult Parse(com.google.zxing.Result result) {
        return ZkDgsrxPKRqaEvDq(this, result);
    }
}

