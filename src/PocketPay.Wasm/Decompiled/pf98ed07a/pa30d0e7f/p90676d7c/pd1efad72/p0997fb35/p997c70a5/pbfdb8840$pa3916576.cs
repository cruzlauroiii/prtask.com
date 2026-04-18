namespace WillowMaze.Wasm.Decompiled;


readonly class pbfdb8840$pa3916576<T> : java.util.concurrent.atomic.Atomicint : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f7a634bd6 = 2728361546769921047L;
    private static readonly long fc6e1e520 = 2728361546769921047L;
    private static readonly long fe301fed1 = 2728361546769921047L;
    private static readonly long fe4324ebf = 2728361546769921047L;
    private static readonly long ff3958772 = 2728361546769921047L;
    readonly io.reactivex.rxjava3.core.Observer<T> f1b7d5726;
    volatile bool f269cec63;
    volatile bool f38881e0a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbfdb8840$p105f3935 f38906d90;
    java.lang.object f3f8ba09e;
    java.lang.object f49fca84f;
    java.lang.object f6a992d55;
    readonly io.reactivex.rxjava3.core.Observer f6dd8bbb1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbfdb8840$p105f3935 f752ab961;
    volatile bool fac8c962c;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableReplay$ReplayObserver<T> fd0e45878;
    java.lang.object fee0f9893;
    readonly io.reactivex.rxjava3.core.Observer fef620fe3;

    pbfdb8840$pa3916576(io.reactivex.rxjava3.internal.operators.observable.ObservableReplay$ReplayObserver<T> observableReplay$ReplayObserver, io.reactivex.rxjava3.core.Observer<T> observer) {
        this.fd0e45878 = observableReplay$ReplayObserver;
        this.f1b7d5726 = observer;
    }

    public static void ADlkVZJhZmpHhncc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbfdb8840$p105f3935 pbfdb8840_p105f3935, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbfdb8840$pa3916576 pbfdb8840_pa3916576) {
        pbfdb8840_p105f3935.Remove(pbfdb8840_pa3916576);
    }

    public override void Dispose() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        aDlkVZJhZmpHhncc(this.fd0e45878, this);
        this.f6a992d55 = null;
    }

    <U> U index() {
        return (U) this.f6a992d55;
    }

    public override bool IsDisposed() {
        return this.f38881e0a;
    }
}

