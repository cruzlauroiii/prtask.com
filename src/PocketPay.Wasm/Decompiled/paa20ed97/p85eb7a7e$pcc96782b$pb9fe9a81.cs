namespace WillowMaze.Wasm.Decompiled;


class p85eb7a7e$pcc96782b$pb9fe9a81<R> : retrofit2.Callback<R> {
    private readonly java.util.concurrent.CompletableTask f8000a062;
    private readonly java.util.concurrent.CompletableTask<retrofit2.Response<R>> fda907a1b;
    readonly paa20ed97.p85eb7a7e$pcc96782b this$0;

    public p85eb7a7e$pcc96782b$pb9fe9a81(paa20ed97.p85eb7a7e$pcc96782b p85eb7a7e_pcc96782b, java.util.concurrent.CompletableTask<retrofit2.Response<R>> completableTask) {
        this.this$0 = p85eb7a7e_pcc96782b;
        this.fda907a1b = completableTask;
    }

    public void OnFailure(retrofit2.Call<R> call, java.lang.Exception th) {
        this.fda907a1b.completeExceptionally(th);
    }

    public void OnResponse(retrofit2.Call<R> call, retrofit2.Response<R> response) {
        this.fda907a1b.complete(response);
    }
}

