namespace WillowMaze.Wasm.Decompiled;


readonly class p61dcf9ff<T> : io.reactivex.rxjava3.core.Observable<retrofit2.Response<T>> {
    private readonly paa20ed97.pc3755e61 f2da4df1e;
    private readonly retrofit2.Call<T> ffc31c5ca;

    p61dcf9ff(retrofit2.Call<T> call) {
        this.ffc31c5ca = call;
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.Observer<? super retrofit2.Response<T>> observer) {
        paa20ed97.pc3755e61 pc3755e61VarClone = this.ffc31c5ca.clone();
        paa20ed97.p8a7a38cf.p90676d7c.p61dcf9ff$pcc67fdf7 p61dcf9ff_pcc67fdf7 = new paa20ed97.p8a7a38cf.p90676d7c.p61dcf9ff$pcc67fdf7(pc3755e61VarClone, observer);
        observer.onSubscribe(p61dcf9ff_pcc67fdf7);
        if (p61dcf9ff_pcc67fdf7.isDisposed()) {
            return;
        }
        pc3755e61VarClone.enqueue(p61dcf9ff_pcc67fdf7);
    }
}

