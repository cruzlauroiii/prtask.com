namespace WillowMaze.Wasm.Decompiled;


class p85eb7a7e$p66a8c391$pfc649740<R> : retrofit2.Callback<R> {
    private readonly java.util.concurrent.CompletableTask f22eff264;
    private readonly java.util.concurrent.CompletableTask f29e3a61e;
    private readonly java.util.concurrent.CompletableTask<R> fda907a1b;
    readonly paa20ed97.p85eb7a7e$p66a8c391 this$0;

    public p85eb7a7e$p66a8c391$pfc649740(paa20ed97.p85eb7a7e$p66a8c391 p85eb7a7e_p66a8c391, java.util.concurrent.CompletableTask<R> completableTask) {
        this.this$0 = p85eb7a7e_p66a8c391;
        this.fda907a1b = completableTask;
    }

    public void OnFailure(retrofit2.Call<R> call, java.lang.Exception th) {
        this.fda907a1b.completeExceptionally(th);
    }

    public void OnResponse(retrofit2.Call<R> call, retrofit2.Response<R> response) {
        if (response.isSuccessful()) {
            this.fda907a1b.complete(response.body());
        } else {
            this.fda907a1b.completeExceptionally(new paa20ed97.p8a8cef05(response));
        }
    }
}

