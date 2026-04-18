namespace WillowMaze.Wasm.Decompiled;


public readonly class p5c8d3e67<T> : io.reactivex.rxjava3.core.Single<java.lang.bool> {
    readonly io.reactivex.rxjava3.core.SingleSource f5cc83870;
    readonly io.reactivex.rxjava3.core.SingleSource f5db6f16e;
    readonly io.reactivex.rxjava3.core.SingleSource<? : T> f8b04d5e3;
    readonly io.reactivex.rxjava3.core.SingleSource<? : T> fa9f0e61a;
    readonly io.reactivex.rxjava3.core.SingleSource ff03992b1;

    public p5c8d3e67(io.reactivex.rxjava3.core.SingleSource<? : T> singleSource, io.reactivex.rxjava3.core.SingleSource<? : T> singleSource2) {
        this.f8b04d5e3 = singleSource;
        this.fa9f0e61a = singleSource2;
    }

    public static void LGiuKMuxxfpjmeni(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static void XuPKSBkbZvODWcIe(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    public static void PdmJaodmzTOVdWoW(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> singleObserver) {
        if ((2 + 16) % 16 > 0) {
        }
        java.util.concurrent.atomic.Atomicint atomicint = new java.util.concurrent.atomic.Atomicint();
        java.lang.object[] objArr = {null, null};
        pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar = new pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd();
        pdmJaodmzTOVdWoW(singleObserver, p5537e2ddVar);
        XuPKSBkbZvODWcIe(this.f8b04d5e3, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p5c8d3e67$p9192f42a(0, p5537e2ddVar, objArr, singleObserver, atomicint));
        LGiuKMuxxfpjmeni(this.fa9f0e61a, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p5c8d3e67$p9192f42a(1, p5537e2ddVar, objArr, singleObserver, atomicint));
    }
}

