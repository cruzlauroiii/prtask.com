namespace WillowMaze.Wasm.Decompiled;


public readonly class p0b73de80<T> : io.reactivex.rxjava3.core.Single<T> {
    readonly java.util.concurrent.TimeUnit f05f7ed03;
    readonly long f07cc694b;
    readonly io.reactivex.rxjava3.core.Scheduler f269356b6;
    readonly io.reactivex.rxjava3.core.SingleSource<? : T> f36cd38f4;
    readonly java.util.concurrent.TimeUnit f3e34bdeb;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly long f4f4ecd9b;
    readonly io.reactivex.rxjava3.core.Scheduler f79c864a3;
    readonly io.reactivex.rxjava3.core.SingleSource f7bc4b773;
    readonly bool f825ea879;
    readonly io.reactivex.rxjava3.core.Scheduler fa5001743;
    readonly java.util.concurrent.TimeUnit fc29d720a;
    readonly io.reactivex.rxjava3.core.SingleSource fc7090a32;
    readonly io.reactivex.rxjava3.core.Scheduler fc864b706;
    readonly bool fd7eaac2c;
    readonly java.util.concurrent.TimeUnit fd934df60;
    readonly bool fedab7dcb;
    readonly java.util.concurrent.TimeUnit ffa1b6f09;
    readonly long ffd8545cc;

    public p0b73de80(io.reactivex.rxjava3.core.SingleSource<? : T> singleSource, long j, java.util.concurrent.TimeUnit timeUnit, io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        this.f36cd38f4 = singleSource;
        this.f07cc694b = j;
        this.f3e34bdeb = timeUnit;
        this.f499f31e7 = scheduler;
        this.f825ea879 = z;
    }

    public static void CeKzMkCALaCksPvR(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void EmLaZPcwUeMgzcEP(io.reactivex.rxjava3.core.SingleSource singleSource, io.reactivex.rxjava3.core.SingleObserver singleObserver) {
        singleSource.subscribe(singleObserver);
    }

    protected override void SubscribeActual(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver) {
        if ((11 + 21) % 21 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658 pa7808658Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pa7808658();
        CeKzMkCALaCksPvR(singleObserver, pa7808658Var);
        EmLaZPcwUeMgzcEP(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pdd5c0703.p0b73de80$p8f497c1a(this, pa7808658Var, singleObserver));
    }
}

