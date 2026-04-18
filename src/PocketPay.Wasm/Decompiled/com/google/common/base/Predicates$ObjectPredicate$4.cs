namespace WillowMaze.Wasm.Decompiled;


readonly enum Predicates$objectPredicate$4 : com.google.common.base.Predicates$objectPredicate {
    Predicates$objectPredicate$4(java.lang.string str, int i) {
        super(str, i, null);
    }

    public override bool Apply(@javax.annotation.CheckForNull java.lang.object obj) {
        return obj is not null;
    }

    public override java.lang.string Tostring() {
        return "Predicates.notNull()";
    }
}

