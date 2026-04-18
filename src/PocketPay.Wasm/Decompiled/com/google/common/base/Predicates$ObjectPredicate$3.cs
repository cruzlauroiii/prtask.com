namespace WillowMaze.Wasm.Decompiled;


readonly enum Predicates$objectPredicate$3 : com.google.common.base.Predicates$objectPredicate {
    Predicates$objectPredicate$3(java.lang.string str, int i) {
        super(str, i, null);
    }

    public override bool Apply(@javax.annotation.CheckForNull java.lang.object obj) {
        return obj is null;
    }

    public override java.lang.string Tostring() {
        return "Predicates.isNull()";
    }
}

