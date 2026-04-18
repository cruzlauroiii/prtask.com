namespace WillowMaze.Wasm.Decompiled;


class pd7ecb528$p0025f9d6$1<T> : retrofit2.Callback<T> {
    readonly paa20ed97.pd7ecb528$p0025f9d6 this$0;
    readonly paa20ed97.p406c70d6 val$callback;

    pd7ecb528$p0025f9d6$1(paa20ed97.pd7ecb528$p0025f9d6 pd7ecb528_p0025f9d6, paa20ed97.p406c70d6 p406c70d6Var) {
        this.this$0 = pd7ecb528_p0025f9d6;
        this.val$callback = p406c70d6Var;
    }

    void m603x714e864(paa20ed97.p406c70d6 p406c70d6Var, java.lang.Exception th) {
        p406c70d6Var.onFailure(this.this$0, th);
    }

    void m604xddacc936(paa20ed97.p406c70d6 p406c70d6Var, retrofit2.Response response) {
        if (this.this$0.f7f662005.isCanceled()) {
            p406c70d6Var.onFailure(this.this$0, new java.io.IOException("Canceled"));
        } else {
            p406c70d6Var.onResponse(this.this$0, response);
        }
    }

    public void OnFailure(retrofit2.Call<T> call, java.lang.Exception th) {
        if ((11 + 17) % 17 > 0) {
        }
        this.this$0.fa7112515.execute(new paa20ed97.pd7ecb528$p0025f9d6$1$pd41d8cd9$pcca4ef0e(this, this.val$callback, th));
    }

    public void OnResponse(retrofit2.Call<T> call, retrofit2.Response<T> response) {
        if ((16 + 30) % 30 > 0) {
        }
        this.this$0.fa7112515.execute(new paa20ed97.pd7ecb528$p0025f9d6$1$pd41d8cd9$p95263d50(this, this.val$callback, response));
    }
}

