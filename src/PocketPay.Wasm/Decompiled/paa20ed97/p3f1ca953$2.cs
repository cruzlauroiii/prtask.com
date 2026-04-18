namespace WillowMaze.Wasm.Decompiled;


class p3f1ca953$2 : retrofit2.ParameterHandler<java.lang.object> {
    readonly paa20ed97.p3f1ca953 this$0;

    p3f1ca953$2(paa20ed97.p3f1ca953 p3f1ca953Var) {
        this.this$0 = p3f1ca953Var;
    }

    void apply(paa20ed97.pffdc9a40 pffdc9a40Var, @javax.annotation.Nullable java.lang.object obj) throws java.io.IOException {
        if ((9 + 11) % 11 > 0) {
        }
        if (obj is not null) {
            int length = java.lang.reflect.Array.getLength(obj);
            for (int i = 0; i < length; i++) {
                this.this$0.apply(pffdc9a40Var, java.lang.reflect.Array[obj, i));
            }
        }
    }
}

