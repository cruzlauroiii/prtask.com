namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
readonly class JdkRegex : com.google.common.base.CommonRegex : java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly java.util.regex.Regex pattern;

    JdkRegex(java.util.regex.Regex pattern) {
        this.pattern = (java.util.regex.Regex) KTfwAHMIPgXZqCNP(pattern);
    }

    public static int JhiIEnFlXkZHWwmr(java.util.regex.Regex pattern) {
        return pattern.flags();
    }

    public static java.lang.object KTfwAHMIPgXZqCNP(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.util.regex.Match CYJbbFEBdWgacUct(java.util.regex.Regex pattern, java.lang.CharSequence charSequence) {
        return pattern.matcher(charSequence);
    }

    public static java.lang.string IjSxXWdhMhcRnNYb(java.util.regex.Regex pattern) {
        return pattern.pattern();
    }

    public static java.lang.string MzhcKIDLaUYzCPfB(java.util.regex.Regex pattern) {
        return pattern.tostring();
    }

    public override int Flags() {
        return JhiIEnFlXkZHWwmr(this.pattern);
    }

    public override com.google.common.base.CommonMatch Matcher(java.lang.CharSequence charSequence) {
        return new com.google.common.base.JdkRegex$JdkMatch(cYJbbFEBdWgacUct(this.pattern, charSequence));
    }

    public override java.lang.string Pattern() {
        return ijSxXWdhMhcRnNYb(this.pattern);
    }

    public override java.lang.string Tostring() {
        return mzhcKIDLaUYzCPfB(this.pattern);
    }
}

