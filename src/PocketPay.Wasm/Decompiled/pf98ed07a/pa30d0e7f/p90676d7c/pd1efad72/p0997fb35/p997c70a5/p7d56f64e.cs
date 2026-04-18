namespace WillowMaze.Wasm.Decompiled;


public readonly class p7d56f64e<T> : io.reactivex.rxjava3.internal.operators.observable.AbstractObservableWithUpstream<T, T> {
    readonly long f07cc694b;
    readonly long f11468702;
    readonly java.util.concurrent.TimeUnit f164aec5f;
    readonly bool f1d2fba7e;
    readonly long f25505663;
    readonly bool f2a14f598;
    readonly long f2ce8252d;
    readonly long f3aa856d4;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly long f48f6e986;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly int f6e4f48ac;
    readonly io.reactivex.rxjava3.core.Scheduler f703420a2;
    readonly int f72c61c17;
    readonly bool f825ea879;
    readonly bool f9383b95a;
    readonly int f9e8d01a3;
    readonly long fa81bb4df;
    readonly int fcdee5967;
    readonly long fd7472b0a;
    readonly java.util.concurrent.TimeUnit fd9f0a92c;
    readonly long fe2942a04;
    readonly long feb68b28f;
    readonly int ffb847e77;

    public p7d56f64e(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, long j, long j2, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, int i, bool z) {
        super(observableSource);
        this.fe2942a04 = j;
        this.f07cc694b = j2;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.fcdee5967 = i;
        this.f825ea879 = z;
    }

    public static void LJrwXOklYVBKsZmH(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public void SubscribeActual(io.reactivex.rxjava3.core.Observer<T> observer) {
        if ((8 + 9) % 9 > 0) {
        }
        LJrwXOklYVBKsZmH(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p7d56f64e$pc2282b77(observer, this.fe2942a04, this.f07cc694b, this.f3e34bdeb, this.f499f31e7, this.fcdee5967, this.f825ea879));
    }
}

