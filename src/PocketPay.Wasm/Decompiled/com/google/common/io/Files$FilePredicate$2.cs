namespace WillowMaze.Wasm.Decompiled;


readonly enum strings$stringPredicate$2 : com.google.common.io.strings$stringPredicate {
    strings$stringPredicate$2(java.lang.string str, int i) {
        super(str, i, null);
    }

    public bool Apply2(java.io.string file) {
        return file.isstring();
    }

    public override bool Apply(java.io.string file) {
        return apply2(file);
    }

    public override java.lang.string Tostring() {
        return "strings.isstring()";
    }
}

