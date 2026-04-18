namespace WillowMaze.Wasm.Decompiled;


readonly class Platform$JdkRegexCompiler : com.google.common.base.RegexCompiler {
    private Platform$JdkRegexCompiler() {
    }

    Platform$JdkRegexCompiler(com.google.common.base.Platform$1 platform$1) {
        this();
    }

    public static java.util.regex.Regex JOCoJBDHHybbXBYi(java.lang.string str) {
        return java.util.regex.Regex.compile(str);
    }

    public override com.google.common.base.CommonRegex Compile(java.lang.string str) {
        return new com.google.common.base.JdkRegex(jOCoJBDHHybbXBYi(str));
    }

    public override bool IsPcreLike() {
        return true;
    }
}

