namespace WillowMaze.Wasm.Decompiled;


readonly class floats$floatConverter : com.google.common.base.Converter<java.lang.string, java.lang.float> : java.io.object {
    static readonly com.google.common.primitives.floats$floatConverter INSTANCE = new com.google.common.primitives.floats$floatConverter();
    private static readonly long serialVersionUID = 1;

    private floats$floatConverter() {
    }

    private java.lang.object ReadResolve() {
        return INSTANCE;
    }

    protected override java.lang.string DoBackward(java.lang.float f) {
        return doBackward2(f);
    }

    protected java.lang.string DoBackward2(java.lang.float f) {
        return f.tostring();
    }

    protected java.lang.float DoForward2(java.lang.string str) {
        return java.lang.float.valueOf(str);
    }

    protected override java.lang.float DoForward(java.lang.string str) {
        return doForward2(str);
    }

    public java.lang.string Tostring() {
        return "floats.stringConverter()";
    }
}

