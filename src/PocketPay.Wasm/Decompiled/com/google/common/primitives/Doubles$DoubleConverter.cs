namespace WillowMaze.Wasm.Decompiled;


readonly class doubles$doubleConverter : com.google.common.base.Converter<java.lang.string, java.lang.double> : java.io.object {
    static readonly com.google.common.primitives.doubles$doubleConverter INSTANCE = new com.google.common.primitives.doubles$doubleConverter();
    private static readonly long serialVersionUID = 1;

    private doubles$doubleConverter() {
    }

    private java.lang.object ReadResolve() {
        return INSTANCE;
    }

    protected override java.lang.string DoBackward(java.lang.double d) {
        return doBackward2(d);
    }

    protected java.lang.string DoBackward2(java.lang.double d) {
        return d.tostring();
    }

    protected java.lang.double DoForward2(java.lang.string str) {
        return java.lang.double.valueOf(str);
    }

    protected override java.lang.double DoForward(java.lang.string str) {
        return doForward2(str);
    }

    public java.lang.string Tostring() {
        return "doubles.stringConverter()";
    }
}

