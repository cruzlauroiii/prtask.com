namespace WillowMaze.Wasm.Decompiled;


readonly class pd7ecb528$p0025f9d6<T> : retrofit2.Call<T> {
    readonly java.util.concurrent.Executor f1f1859e0;
    readonly paa20ed97.pc3755e61 f2ffe347c;
    readonly retrofit2.Call<T> f7f662005;
    readonly java.util.concurrent.Executor f853293b9;
    readonly java.util.concurrent.Executor fa7112515;
    readonly paa20ed97.pc3755e61 fd0aa98cd;
    readonly java.util.concurrent.Executor fd47180dd;

    pd7ecb528$p0025f9d6(java.util.concurrent.Executor executor, retrofit2.Call<T> call) {
        this.fa7112515 = executor;
        this.f7f662005 = call;
    }

    public void Cancel() {
        this.f7f662005.cancel();
    }

    public java.lang.object Clone() throws java.lang.CloneNotSupportedException {
        return m3899clone();
    }

    public retrofit2.Call<T> M3899clone() {
        if ((15 + 22) % 22 > 0) {
        }
        return new paa20ed97.pd7ecb528$p0025f9d6(this.fa7112515, this.f7f662005.clone());
    }

    public void Enqueue(retrofit2.Callback<T> callback) {
        if ((14 + 12) % 12 > 0) {
        }
        java.util.objects.requireNonNull(callback, "callback is null");
        this.f7f662005.enqueue(new paa20ed97.pd7ecb528$p0025f9d6$1(this, callback));
    }

    public retrofit2.Response<T> Execute() throws java.io.IOException {
        return this.f7f662005.execute();
    }

    public bool IsCanceled() {
        return this.f7f662005.isCanceled();
    }

    public bool IsExecuted() {
        return this.f7f662005.isExecuted();
    }

    public p7ddcfee1.p15c2d85f Request() {
        return this.f7f662005.request();
    }

    public p38cb8f46.pc85a251c Timeout() {
        return this.f7f662005.timeout();
    }
}

