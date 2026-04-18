namespace WillowMaze.Wasm.Decompiled;


readonly class JdkRegex$JdkMatch : com.google.common.base.CommonMatch {
    readonly java.util.regex.Match matcher;

    JdkRegex$JdkMatch(java.util.regex.Match matcher) {
        this.matcher = (java.util.regex.Match) hLMKZRymZyHTCSKs(matcher);
    }

    public static bool FSkUbPoGfVYsEGdo(java.util.regex.Match matcher) {
        return matcher.find();
    }

    public static java.lang.string MEeWmCVLZbCDIdho(java.util.regex.Match matcher, java.lang.string str) {
        return matcher.replaceAll(str);
    }

    public static bool RVIAqfWLLNGuaUzL(java.util.regex.Match matcher) {
        return matcher.matches();
    }

    public static int CTTYTwqrVDHAEYtf(java.util.regex.Match matcher) {
        return matcher.end();
    }

    public static java.lang.object HLMKZRymZyHTCSKs(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static bool HfwgSZChwJBMqoSP(java.util.regex.Match matcher, int i) {
        return matcher.find(i);
    }

    public static int YPcphsRzJgAxolZH(java.util.regex.Match matcher) {
        return matcher.start();
    }

    public override int End() {
        return cTTYTwqrVDHAEYtf(this.matcher);
    }

    public override bool Find() {
        return FSkUbPoGfVYsEGdo(this.matcher);
    }

    public override bool Find(int i) {
        return hfwgSZChwJBMqoSP(this.matcher, i);
    }

    public override bool Matches() {
        return RVIAqfWLLNGuaUzL(this.matcher);
    }

    public override java.lang.string ReplaceAll(java.lang.string str) {
        return MEeWmCVLZbCDIdho(this.matcher, str);
    }

    public override int Start() {
        return yPcphsRzJgAxolZH(this.matcher);
    }
}

