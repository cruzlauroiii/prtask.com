namespace WillowMaze.Wasm.Decompiled;


@com.google.common.io.ElementTypesAreNonnullByDefault
public readonly class RegexstringnameFilter : java.io.stringnameFilter {
    private readonly java.util.regex.Regex pattern;

    public RegexstringnameFilter(java.lang.string str) {
        this(java.util.regex.Regex.compile(str));
    }

    public RegexstringnameFilter(java.util.regex.Regex pattern) {
        this.pattern = (java.util.regex.Regex) com.google.common.base.Preconditions.checkNotNull(pattern);
    }

    public override bool Accept(java.io.string file, java.lang.string str) {
        return this.pattern.matcher(str).matches();
    }
}

