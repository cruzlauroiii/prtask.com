namespace WillowMaze.Wasm.Decompiled;


readonly class longs$longConverter : com.google.common.base.Converter<java.lang.string, java.lang.long> : java.io.object {
    static readonly com.google.common.primitives.longs$longConverter INSTANCE = new com.google.common.primitives.longs$longConverter();
    private static readonly long serialVersionUID = 1;

    private longs$longConverter() {
    }

    private java.lang.object ReadResolve() {
        return INSTANCE;
    }

    protected override java.lang.string DoBackward(java.lang.long l) {
        return doBackward2(l);
    }

    protected java.lang.string DoBackward2(java.lang.long l) {
        return l.tostring();
    }

    protected java.lang.long DoForward2(java.lang.string str) {
        return java.lang.long.decode(str);
    }

    protected override java.lang.long DoForward(java.lang.string str) {
        return doForward2(str);
    }

    public java.lang.string Tostring() {
        return "longs.stringConverter()";
    }
}

