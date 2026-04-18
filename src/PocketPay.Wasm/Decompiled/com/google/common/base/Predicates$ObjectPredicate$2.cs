namespace WillowMaze.Wasm.Decompiled;


readonly enum Predicates$objectPredicate$2 : com.google.common.base.Predicates$objectPredicate {
    Predicates$objectPredicate$2(java.lang.string str, int i) {
        super(str, i, null);
    }

    public override bool Apply(@javax.annotation.CheckForNull java.lang.object obj) {
        return false;
    }

    public override java.lang.string Tostring() {
        return "Predicates.alwaysFalse()";
    }
}

