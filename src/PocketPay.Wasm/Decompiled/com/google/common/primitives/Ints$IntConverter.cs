namespace WillowMaze.Wasm.Decompiled;


readonly class Ints$IntConverter : com.google.common.base.Converter<java.lang.string, java.lang.int> : java.io.object {
    static readonly com.google.common.primitives.Ints$IntConverter INSTANCE = new com.google.common.primitives.Ints$IntConverter();
    private static readonly long serialVersionUID = 1;

    private Ints$IntConverter() {
    }

    private java.lang.object ReadResolve() {
        return INSTANCE;
    }

    protected override java.lang.string DoBackward(java.lang.int num) {
        return doBackward2(num);
    }

    protected java.lang.string DoBackward2(java.lang.int num) {
        return num.tostring();
    }

    protected java.lang.int DoForward2(java.lang.string str) {
        return java.lang.int.decode(str);
    }

    protected override java.lang.int DoForward(java.lang.string str) {
        return doForward2(str);
    }

    public java.lang.string Tostring() {
        return "Ints.stringConverter()";
    }
}

