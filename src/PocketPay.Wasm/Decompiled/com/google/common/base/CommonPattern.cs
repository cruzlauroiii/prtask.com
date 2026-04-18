namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
abstract class CommonRegex {
    CommonRegex() {
    }

    public static bool SGTvcUPHsgLjheBQ() {
        return com.google.common.base.Platform.patternCompilerIsPcreLike();
    }

    public static com.google.common.base.CommonRegex Compile(java.lang.string str) {
        return wnsJcNtHdBgQHCGL(str);
    }

    public static bool IsPcreLike() {
        return SGTvcUPHsgLjheBQ();
    }

    public static com.google.common.base.CommonRegex WnsJcNtHdBgQHCGL(java.lang.string str) {
        return com.google.common.base.Platform.compileRegex(str);
    }

    public abstract int Flags();

    public abstract com.google.common.base.CommonMatch Matcher(java.lang.CharSequence charSequence);

    public abstract java.lang.string Pattern();

    public abstract java.lang.string Tostring();
}

