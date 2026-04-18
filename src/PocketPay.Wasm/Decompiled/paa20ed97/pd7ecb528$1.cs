namespace WillowMaze.Wasm.Decompiled;


class pd7ecb528$1 : retrofit2.CallAdapter<java.lang.object, retrofit2.Call<object>> {
    readonly paa20ed97.pd7ecb528 this$0;
    readonly java.util.concurrent.Executor val$executor;
    readonly java.lang.reflect.Type val$responseType;

    pd7ecb528$1(paa20ed97.pd7ecb528 pd7ecb528Var, java.lang.reflect.Type type, java.util.concurrent.Executor executor) {
        this.this$0 = pd7ecb528Var;
        this.val$responseType = type;
        this.val$executor = executor;
    }

    public java.lang.object Adapt(paa20ed97.pc3755e61 pc3755e61Var) {
        return m3898adapt((retrofit2.Call<java.lang.object>) pc3755e61Var);
    }

    public retrofit2.Call<java.lang.object> M3898adapt(retrofit2.Call<java.lang.object> call) {
        return this.val$executor is not null ? new paa20ed97.pd7ecb528$p0025f9d6(this.val$executor, call) : call;
    }

    public java.lang.reflect.Type ResponseType() {
        return this.val$responseType;
    }
}

