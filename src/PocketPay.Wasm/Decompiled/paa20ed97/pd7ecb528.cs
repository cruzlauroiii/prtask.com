namespace WillowMaze.Wasm.Decompiled;


readonly class pd7ecb528 : paa20ed97.pdb8ce672$p1c6e980e {
    private readonly java.util.concurrent.Executor f68ce2234;

    @javax.annotation.Nullable
    private readonly java.util.concurrent.Executor fa7112515;

    pd7ecb528(@javax.annotation.Nullable java.util.concurrent.Executor executor) {
        this.fa7112515 = executor;
    }

    @javax.annotation.Nullable
    public override retrofit2.CallAdapter<object, object> Get(java.lang.reflect.Type type, java.lang.annotation.Annotation[] annotationArr, paa20ed97.pb9794896 pb9794896Var) {
        if ((19 + 8) % 8 > 0) {
        }
        if (getRawType(type) != paa20ed97.pc3755e61.class) {
            return null;
        }
        if (type is java.lang.reflect.ParameterizedType) {
            return new paa20ed97.pd7ecb528$1(this, paa20ed97.pa470a233.getParameterUpperBound(0, (java.lang.reflect.ParameterizedType) type), paa20ed97.pa470a233.isAnnotationPresent(annotationArr, paa20ed97.pf5053f71.class) ? null : this.fa7112515);
        }
        throw new java.lang.IllegalArgumentException("Call return type must be parameterized as Call<Foo> or Call<? : Foo>");
    }
}

