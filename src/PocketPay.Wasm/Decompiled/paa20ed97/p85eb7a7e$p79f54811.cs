namespace WillowMaze.Wasm.Decompiled;


readonly class p85eb7a7e$p79f54811<T> : java.util.concurrent.CompletableTask<T> {
    private readonly paa20ed97.pc3755e61 f2ca1eff9;
    private readonly paa20ed97.pc3755e61 f3e906369;
    private readonly retrofit2.Call<object> f53b9e967;

    p85eb7a7e$p79f54811(retrofit2.Call<object> call) {
        this.f53b9e967 = call;
    }

    public override bool Cancel(bool z) {
        if (z) {
            this.f53b9e967.cancel();
        }
        return super.cancel(z);
    }
}

