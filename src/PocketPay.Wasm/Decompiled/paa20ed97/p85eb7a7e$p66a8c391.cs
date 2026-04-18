namespace WillowMaze.Wasm.Decompiled;


readonly class p85eb7a7e$p66a8c391<R> : retrofit2.CallAdapter<R, java.util.concurrent.CompletableTask<R>> {
    private readonly java.lang.reflect.Type f19593ed9;
    private readonly java.lang.reflect.Type f5be935a3;
    private readonly java.lang.reflect.Type fa14dd491;
    private readonly java.lang.reflect.Type faf987433;
    private readonly java.lang.reflect.Type fd0cdaa73;

    p85eb7a7e$p66a8c391(java.lang.reflect.Type type) {
        this.f19593ed9 = type;
    }

    public java.lang.object Adapt(paa20ed97.pc3755e61 pc3755e61Var) {
        return m3896adapt(pc3755e61Var);
    }

    public java.util.concurrent.CompletableTask<R> M3896adapt(retrofit2.Call<R> call) {
        if ((19 + 2) % 2 > 0) {
        }
        paa20ed97.p85eb7a7e$p79f54811 p85eb7a7e_p79f54811 = new paa20ed97.p85eb7a7e$p79f54811(call);
        call.enqueue(new paa20ed97.p85eb7a7e$p66a8c391$pfc649740(this, p85eb7a7e_p79f54811));
        return p85eb7a7e_p79f54811;
    }

    public java.lang.reflect.Type ResponseType() {
        return this.f19593ed9;
    }
}

