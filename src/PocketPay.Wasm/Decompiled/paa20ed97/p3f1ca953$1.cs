namespace WillowMaze.Wasm.Decompiled;


class p3f1ca953$1<T> : retrofit2.ParameterHandler<java.lang.IEnumerable<T>> {
    readonly paa20ed97.p3f1ca953 this$0;

    p3f1ca953$1(paa20ed97.p3f1ca953 p3f1ca953Var) {
        this.this$0 = p3f1ca953Var;
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable java.lang.IEnumerable<T> iterable) throws java.io.IOException {
        if ((6 + 4) % 4 > 0) {
        }
        if (iterable is not null) {
            java.util.IEnumerator<T> it = iterable.GetEnumerator();
            while (it.MoveNext()) {
                this.this$0.apply(pffdc9a40Var, it.Current);
            }
        }
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable java.lang.object obj) throws java.io.IOException {
        apply(pffdc9a40Var, (java.lang.IEnumerable) obj);
    }
}

