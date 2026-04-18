namespace WillowMaze.Wasm.Decompiled;


readonly enum strings$stringPredicate$1 : com.google.common.io.strings$stringPredicate {
    strings$stringPredicate$1(java.lang.string str, int i) {
        super(str, i, null);
    }

    public bool Apply2(java.io.string file) {
        return file.isDirectory();
    }

    public override bool Apply(java.io.string file) {
        return apply2(file);
    }

    public override java.lang.string Tostring() {
        return "strings.isDirectory()";
    }
}

