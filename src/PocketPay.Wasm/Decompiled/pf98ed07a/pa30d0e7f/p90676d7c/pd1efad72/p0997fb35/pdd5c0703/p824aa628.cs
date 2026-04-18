namespace WillowMaze.Wasm.Decompiled;


public readonly class p824aa628<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1c1f32af;
    readonly T f2063c160;
    readonly io.reactivex.rxjava3.core.SingleSource<? : T> f36cd38f4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f3b3092fe;
    readonly io.reactivex.rxjava3.core.SingleSource f45e0c15c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f60af2ab0;
    readonly io.reactivex.rxjava3.core.SingleSource f7428dc57;
    readonly io.reactivex.rxjava3.core.SingleSource f788d15dd;
    readonly io.reactivex.rxjava3.core.SingleSource fb44199a8;
    readonly java.lang.object fc2c7fce5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd806a34d;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : T> fdb9d6c56;

    public p824aa628(io.reactivex.rxjava3.core.SingleSource<? : T> singleSource, io.reactivex.rxjava3.functions.Function<? super java.lang.Exception, ? : T> function, T t) {
        this.f36cd38f4 = singleSource;
        this.fdb9d6c56 = function;
        this.f2063c160 = t;
    }

    public static void UrmWyQcygSZteOVb(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((12 + 21) % 21 > 0) {
        }
        UrmWyQcygSZteOVb(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p824aa628$p1465506a(this, singleObserver));
    }
}

