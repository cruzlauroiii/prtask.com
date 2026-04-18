namespace WillowMaze.Wasm.Decompiled;


public readonly class p5e964be4<T> : io.reactivex.rxjava3.core.Single<java.lang.bool> : io.reactivex.rxjava3.internal.fuseable.FuseToObservable<java.lang.bool> {
    readonly io.reactivex.rxjava3.core.ObservableSource f09c42dcf;
    readonly io.reactivex.rxjava3.core.ObservableSource f0a7ca4f2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 f10bb003c;
    readonly io.reactivex.rxjava3.core.ObservableSource f19b366a6;
    readonly io.reactivex.rxjava3.core.ObservableSource f1c51d298;
    readonly io.reactivex.rxjava3.core.ObservableSource f3a23ca70;
    readonly io.reactivex.rxjava3.core.ObservableSource f45b4bfb2;
    readonly int f59093cdd;
    readonly io.reactivex.rxjava3.core.ObservableSource f62be5a36;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T> f8b04d5e3;
    readonly int f9eefc8a9;
    readonly io.reactivex.rxjava3.functions.BiPredicate<T, T> f9f89a861;
    readonly io.reactivex.rxjava3.core.ObservableSource<? : T> fa9f0e61a;
    readonly int fcdee5967;
    readonly int fdbaffe25;

    public p5e964be4(io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource, io.reactivex.rxjava3.core.ObservableSource<? : T> observableSource2, io.reactivex.rxjava3.functions.BiPredicate<T, T> biPredicate, int i) {
        this.f8b04d5e3 = observableSource;
        this.fa9f0e61a = observableSource2;
        this.f9f89a861 = biPredicate;
        this.fcdee5967 = i;
    }

    public static void BbyVMAxlEdUZASRP(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static io.reactivex.rxjava3.core.Observable PHnVuIQzoUzJNKaV(io.reactivex.rxjava3.core.Observable observable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(observable);
    }

    public static void RvGLssqqUFrLRApr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pe7a52b77 p5e964be4_pe7a52b77) {
        p5e964be4_pe7a52b77.subscribe();
    }

    public io.reactivex.rxjava3.core.Observable<java.lang.bool> FuseToObservable() {
        if ((26 + 18) % 18 > 0) {
        }
        return PHnVuIQzoUzJNKaV(new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p0887ad6e(this.f8b04d5e3, this.fa9f0e61a, this.f9f89a861, this.fcdee5967));
    }

    public override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<java.lang.bool> singleObserver) {
        if ((17 + 10) % 10 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pe7a52b77 p5e964be4_pe7a52b77 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p5e964be4$pe7a52b77(singleObserver, this.fcdee5967, this.f8b04d5e3, this.fa9f0e61a, this.f9f89a861);
        BbyVMAxlEdUZASRP(singleObserver, p5e964be4_pe7a52b77);
        rvGLssqqUFrLRApr(p5e964be4_pe7a52b77);
    }
}

