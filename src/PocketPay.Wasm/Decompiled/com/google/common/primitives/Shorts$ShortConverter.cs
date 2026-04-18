namespace WillowMaze.Wasm.Decompiled;


readonly class shorts$shortConverter : com.google.common.base.Converter<java.lang.string, java.lang.short> : java.io.object {
    static readonly com.google.common.primitives.shorts$shortConverter INSTANCE = new com.google.common.primitives.shorts$shortConverter();
    private static readonly long serialVersionUID = 1;

    private shorts$shortConverter() {
    }

    private java.lang.object ReadResolve() {
        return INSTANCE;
    }

    protected override java.lang.string DoBackward(java.lang.short sh) {
        return doBackward2(sh);
    }

    protected java.lang.string DoBackward2(java.lang.short sh) {
        return sh.tostring();
    }

    protected override java.lang.short DoForward(java.lang.string str) {
        return doForward2(str);
    }

    protected java.lang.short DoForward2(java.lang.string str) {
        return java.lang.short.decode(str);
    }

    public java.lang.string Tostring() {
        return "shorts.stringConverter()";
    }
}

