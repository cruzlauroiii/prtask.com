namespace WillowMaze.Wasm.Decompiled;


public readonly class p7ded80f6<T> : io.reactivex.rxjava3.core.Single<java.lang.bool> {
    readonly io.reactivex.rxjava3.core.MaybeSource<? : T> f011a0463;
    readonly io.reactivex.rxjava3.core.MaybeSource f12307866;
    readonly io.reactivex.rxjava3.core.MaybeSource<? : T> f27e95496;
    readonly io.reactivex.rxjava3.core.MaybeSource f2db8819e;
    readonly io.reactivex.rxjava3.functions.BiPredicate<T, T> f39e60812;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 f43472c73;
    readonly io.reactivex.rxjava3.core.MaybeSource f580e96c5;
    readonly io.reactivex.rxjava3.core.MaybeSource f6edf4eba;
    readonly io.reactivex.rxjava3.core.MaybeSource f8b11fe82;
    readonly io.reactivex.rxjava3.core.MaybeSource f96288e68;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 fb77a152e;

    public p7ded80f6(io.reactivex.rxjava3.core.MaybeSource<? : T> maybeSource, io.reactivex.rxjava3.core.MaybeSource<? : T> maybeSource2, io.reactivex.rxjava3.functions.BiPredicate<T, T> biPredicate) {
        this.f011a0463 = maybeSource;
        this.f27e95496 = maybeSource2;
        this.f39e60812 = biPredicate;
    }

    public static void PBLHSFTThzDHbdpN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p7ded80f6$pe7a52b77 p7ded80f6_pe7a52b77, io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeSource maybeSource2) {
        p7ded80f6_pe7a52b77.subscribe(maybeSource, maybeSource2);
    }

    public static void OtbKEQloyDxWHxyf(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> singleObserver) {
        if ((7 + 10) % 10 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p7ded80f6$pe7a52b77 p7ded80f6_pe7a52b77 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p7ded80f6$pe7a52b77(singleObserver, this.f39e60812);
        otbKEQloyDxWHxyf(singleObserver, p7ded80f6_pe7a52b77);
        PBLHSFTThzDHbdpN(p7ded80f6_pe7a52b77, this.f011a0463, this.f27e95496);
    }
}

