namespace WillowMaze.Wasm.Decompiled;


readonly class p85eb7a7e : paa20ed97.pdb8ce672$p1c6e980e {
    static readonly paa20ed97.pdb8ce672$p1c6e980e f3d564511 = null;
    static readonly paa20ed97.pdb8ce672$p1c6e980e f76425f17 = new paa20ed97.p85eb7a7e();

    p85eb7a7e() {
    }

    @javax.annotation.Nullable
    public override retrofit2.CallAdapter<object, object> Get(java.lang.reflect.Type type, java.lang.annotation.Annotation[] annotationArr, paa20ed97.pb9794896 pb9794896Var) {
        if (getRawType(type) != java.util.concurrent.CompletableTask.class) {
            return null;
        }
        if (!(type is java.lang.reflect.ParameterizedType)) {
            throw new java.lang.IllegalStateException("CompletableTask return type must be parameterized as CompletableTask<Foo> or CompletableTask<? : Foo>");
        }
        java.lang.reflect.Type parameterUpperBound = getParameterUpperBound(0, (java.lang.reflect.ParameterizedType) type);
        if (getRawType(parameterUpperBound) != retrofit2.Response.class) {
            return new paa20ed97.p85eb7a7e$p66a8c391(parameterUpperBound);
        }
        if (parameterUpperBound is java.lang.reflect.ParameterizedType) {
            return new paa20ed97.p85eb7a7e$pcc96782b(getParameterUpperBound(0, (java.lang.reflect.ParameterizedType) parameterUpperBound));
        }
        throw new java.lang.IllegalStateException("Response must be parameterized as Response<Foo> or Response<? : Foo>");
    }
}

