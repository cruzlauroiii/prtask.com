namespace WillowMaze.Wasm.Decompiled;


readonly enum Predicates$objectPredicate$1 : com.google.common.base.Predicates$objectPredicate {
    Predicates$objectPredicate$1(java.lang.string str, int i) {
        super(str, i, null);
    }

    public override bool Apply(@javax.annotation.CheckForNull java.lang.object obj) {
        return true;
    }

    public override java.lang.string Tostring() {
        return "Predicates.alwaysTrue()";
    }
}

