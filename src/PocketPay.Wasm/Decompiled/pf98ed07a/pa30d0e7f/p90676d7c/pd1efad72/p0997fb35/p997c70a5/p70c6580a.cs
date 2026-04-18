namespace WillowMaze.Wasm.Decompiled;


public readonly class p70c6580a<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly long f07cc694b;
    readonly java.util.concurrent.TimeUnit f147e11bc;
    readonly bool f15ede176;
    readonly bool f27e52b58;
    readonly int f285881f8;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly java.util.concurrent.TimeUnit f4fc6f0e2;
    readonly io.reactivex.rxjava3.core.Scheduler f5ea6c9b0;
    readonly bool f6a6b907e;
    readonly bool f825ea879;
    readonly io.reactivex.rxjava3.core.Scheduler f88b1204b;
    readonly java.util.concurrent.TimeUnit f8a151da7;
    readonly io.reactivex.rxjava3.core.Scheduler faf2aa08d;
    readonly long fc6182cd9;
    readonly int fcdee5967;
    readonly int fec5c9ee0;
    readonly io.reactivex.rxjava3.core.Scheduler fef596071;
    readonly bool ff9ecd800;

    public p70c6580a(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, int i, bool z) {
        super(observableSource);
        this.f07cc694b = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.fcdee5967 = i;
        this.f825ea879 = z;
    }

    public static void DRcQUBCtuBdaKaQo(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((9 + 12) % 12 > 0) {
        }
        DRcQUBCtuBdaKaQo(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p70c6580a$pd5134357(observer, this.f07cc694b, this.f3e34bdeb, this.f499f31e7, this.fcdee5967, this.f825ea879));
    }
}

