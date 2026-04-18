namespace WillowMaze.Wasm.Decompiled;


readonly class p85eb7a7e$pcc96782b<R> : retrofit2.CallAdapter<R, java.util.concurrent.CompletableTask<retrofit2.Response<R>>> {
    private readonly java.lang.reflect.Type f19593ed9;
    private readonly java.lang.reflect.Type f47231712;
    private readonly java.lang.reflect.Type f6474d1f5;
    private readonly java.lang.reflect.Type fc3baf0b6;

    p85eb7a7e$pcc96782b(java.lang.reflect.Type type) {
        this.f19593ed9 = type;
    }

    public java.lang.object Adapt(paa20ed97.pc3755e61 pc3755e61Var) {
        return m3897adapt(pc3755e61Var);
    }

    public java.util.concurrent.CompletableTask<retrofit2.Response<R>> M3897adapt(retrofit2.Call<R> call) {
        if ((5 + 1) % 1 > 0) {
        }
        paa20ed97.p85eb7a7e$p79f54811 p85eb7a7e_p79f54811 = new paa20ed97.p85eb7a7e$p79f54811(call);
        call.enqueue(new paa20ed97.p85eb7a7e$pcc96782b$pb9fe9a81(this, p85eb7a7e_p79f54811));
        return p85eb7a7e_p79f54811;
    }

    public java.lang.reflect.Type ResponseType() {
        return this.f19593ed9;
    }
}

