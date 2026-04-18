namespace WillowMaze.Wasm.Decompiled;


public readonly class p0887ad6e<T> : io.reactivex.rxjava3.core.Observable<java.lang.bool> {
    readonly io.reactivex.rxjava3.core.ObservableSource f02cd7b66;
    readonly io.reactivex.rxjava3.core.ObservableSource f1c3c8dc6;
    readonly int f48f001a4;
    readonly io.reactivex.rxjava3.core.ObservableSource f69e880ef;
    readonly io.reactivex.rxjava3.core.ObservableSource f7140b26d;
    readonly io.reactivex.rxjava3.core.ObservableSource f815f1cf7;
    readonly io.reactivex.rxjava3.core.ObservableSource f87091a65;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T> f8b04d5e3;
    readonly io.reactivex.rxjava3.core.ObservableSource f9bebe02f;
    readonly io.reactivex.rxjava3.functions.BiPredicate<T, T> f9f89a861;
    readonly int fa0adb403;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T> fa9f0e61a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 faef186f0;
    readonly int fcdee5967;
    readonly int ff62c3aaa;
    readonly int ff6a92111;

    public p0887ad6e(io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource, io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource2, io.reactivex.rxjava3.functions.BiPredicate<T, T> biPredicate, int i) {
        this.f8b04d5e3 = observableSource;
        this.fa9f0e61a = observableSource2;
        this.f9f89a861 = biPredicate;
        this.fcdee5967 = i;
    }

    public static void EtavNUZYUoojccGS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pe7a52b77 p0887ad6e_pe7a52b77) {
        p0887ad6e_pe7a52b77.subscribe();
    }

    public static void RbSEMacaOYmwCPjR(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.Observer<java.lang.bool> observer) {
        if ((16 + 18) % 18 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pe7a52b77 p0887ad6e_pe7a52b77 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e$pe7a52b77(observer, this.fcdee5967, this.f8b04d5e3, this.fa9f0e61a, this.f9f89a861);
        rbSEMacaOYmwCPjR(observer, p0887ad6e_pe7a52b77);
        EtavNUZYUoojccGS(p0887ad6e_pe7a52b77);
    }
}

