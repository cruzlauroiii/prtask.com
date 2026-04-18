namespace WillowMaze.Wasm.Decompiled;


public readonly class pc781e393<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly io.reactivex.rxjava3.core.SingleSource<T> f36cd38f4;
    readonly io.reactivex.rxjava3.core.SingleSource f6699abab;
    readonly io.reactivex.rxjava3.core.CompletableSource f795f3202;
    readonly io.reactivex.rxjava3.core.CompletableSource f903c2db4;
    readonly io.reactivex.rxjava3.core.CompletableSource f93238f56;
    readonly io.reactivex.rxjava3.core.CompletableSource f9d60a783;
    readonly io.reactivex.rxjava3.core.SingleSource fb5d70c48;
    readonly io.reactivex.rxjava3.core.CompletableSource fcd12d1b2;
    readonly io.reactivex.rxjava3.core.SingleSource ff7d468bf;

    public pc781e393(io.reactivex.rxjava3.core.SingleSource<T> singleSource, io.reactivex.rxjava3.core.CompletableSource completableSource) {
        this.f36cd38f4 = singleSource;
        this.f795f3202 = completableSource;
    }

    public static void FXfuWxvIZwrFBVKB(io.reactivex.rxjava3.core.CompletableSource completableSource, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableSource.subscribe(completableObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((21 + 8) % 8 > 0) {
        }
        FXfuWxvIZwrFBVKB(this.f795f3202, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.pc781e393$pe0acc004(singleObserver, this.f36cd38f4));
    }
}

