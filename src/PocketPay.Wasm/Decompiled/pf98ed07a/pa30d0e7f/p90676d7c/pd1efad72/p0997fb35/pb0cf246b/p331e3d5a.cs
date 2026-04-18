namespace WillowMaze.Wasm.Decompiled;


public readonly class p331e3d5a<T, R> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, R> {
    readonly io.reactivex.rxjava3.core.Scheduler f24f2eec0;
    readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f4b2298fc;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : R>> f4b9f83e1;
    readonly int f4c203b76;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f560019e4;
    readonly int f6d3b6ef9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f839906a3;
    readonly int f8d52e1cd;
    readonly io.reactivex.rxjava3.core.Scheduler f970dcb9c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fbc4cd698;
    readonly int fd6738dba;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 fe726b806;

    public p331e3d5a(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super T, ? : org.reactivestreams.Publisher<? : R>> function, int i, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var, io.reactivex.rxjava3.core.Scheduler scheduler) {
        super(flowable);
        this.f4b9f83e1 = function;
        this.f4c203b76 = i;
        this.f560019e4 = pcd04add9Var;
        this.f499f31e7 = scheduler;
    }

    public static void AqHlMrMoDyfNXzpa(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker QdAhakSradpjjOMK(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static void RXifKkqPUVEmUuAr(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker SImiNrpcCoVocvEr(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static io.reactivex.rxjava3.core.Scheduler$Worker WcvUgYMonsZKseuT(io.reactivex.rxjava3.core.Scheduler scheduler) {
        return scheduler.createWorker();
    }

    public static int ASLfKJAJTaFRPRLk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var) {
        return pcd04add9Var.ordinal();
    }

    public static void PqFOWQPEFrSZHjDx(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<R> subscriber) {
        if ((29 + 16) % 16 > 0) {
        }
        int i = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p331e3d5a$1.$SwitchDictionary$io$reactivex$rxjava3$internal$util$ErrorMode[aSLfKJAJTaFRPRLk(this.f560019e4)];
        if (i == 1) {
            pqFOWQPEFrSZHjDx(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p331e3d5a$p67839be3(subscriber, this.f4b9f83e1, this.f4c203b76, false, SImiNrpcCoVocvEr(this.f499f31e7)));
        } else if (i == 2) {
            AqHlMrMoDyfNXzpa(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p331e3d5a$p67839be3(subscriber, this.f4b9f83e1, this.f4c203b76, true, WcvUgYMonsZKseuT(this.f499f31e7)));
        } else {
            RXifKkqPUVEmUuAr(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p331e3d5a$pabbe040b(subscriber, this.f4b9f83e1, this.f4c203b76, QdAhakSradpjjOMK(this.f499f31e7)));
        }
    }
}

