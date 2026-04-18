namespace WillowMaze.Wasm.Decompiled;


public abstract class p02303ebe<T, R> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, io.reactivex.rxjava3.operators.QueueSubscription<R> {
    protected bool f2aa0d275;
    protected io.reactivex.rxjava3.operators.QueueSubscription<T> f304854e2;
    protected p5a445d71.p18f29add.p787ad0b7 f33df54c5;
    protected readonly p5a445d71.p18f29add.p992c4a5b f3f461ad2;
    protected pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 f4120ea54;
    protected bool f6b2ded51;
    protected p5a445d71.p18f29add.p787ad0b7 f710e6722;
    protected p5a445d71.p18f29add.p787ad0b7 f8e9d216c;
    protected p5a445d71.p18f29add.p787ad0b7 fb8410313;
    protected p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    protected bool fc3de74b8;
    protected int fcaab7643;
    protected readonly org.reactivestreams.Subscriber<R> fd22a0a80;
    protected bool fde69c67f;
    protected readonly p5a445d71.p18f29add.p992c4a5b fe1025fee;
    protected int fe910ccee;
    protected bool feed367bb;

    public p02303ebe(org.reactivestreams.Subscriber<R> subscriber) {
        this.fd22a0a80 = subscriber;
    }

    public static void APNFkpctfBJNWLcH(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static int FZPfHAwzADUTorVM(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var, int i) {
        return p5d5a5670Var.requestFusion(i);
    }

    public static void PsLfsomqURiEqFUI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p02303ebe p02303ebeVar, java.lang.Exception th) {
        p02303ebeVar.onError(th);
    }

    public static void TVpsHYdAcFOQEjFc(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var) {
        p5d5a5670Var.clear();
    }

    public static bool WlGQOsjcIjvTrnDw(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var) {
        return p5d5a5670Var.Count == 0;
    }

    public static bool XKAkjZnlcjZTGiEp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p02303ebe p02303ebeVar) {
        return p02303ebeVar.beforeDownstream();
    }

    public static void CooWFukZrDoxuMrD(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool HGbmHtNskhfNQHYS(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void HWUYvZKvHHNkYHQh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p02303ebe p02303ebeVar) {
        p02303ebeVar.afterDownstream();
    }

    public static void ICrbyUROukkmweII(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void IgRUGBvEuMopPbfF(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void ItYCaxBlUUUbeUcp(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void JEGXqTulmJpHsbvk(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void LIZsAETQTXlfXPsc(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void WQtotahnmZtlihjn(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    protected void AfterDownstream() {
    }

    protected bool BeforeDownstream() {
        return true;
    }

    public void Cancel() {
        cooWFukZrDoxuMrD(this.fbc3b0556);
    }

    public void Clear() {
        TVpsHYdAcFOQEjFc(this.f304854e2);
    }

    protected readonly void Fail(java.lang.Exception th) {
        itYCaxBlUUUbeUcp(th);
        igRUGBvEuMopPbfF(this.fbc3b0556);
        PsLfsomqURiEqFUI(this, th);
    }

    public bool IsEmpty() {
        return WlGQOsjcIjvTrnDw(this.f304854e2);
    }

    public readonly bool Offer(R r) {
        throw new java.lang.UnsupportedOperationException("Should not be called!");
    }

    public readonly bool Offer(R r, R r2) {
        throw new java.lang.UnsupportedOperationException("Should not be called!");
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        iCrbyUROukkmweII(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            jEGXqTulmJpHsbvk(th);
        } else {
            this.f6b2ded51 = true;
            wQtotahnmZtlihjn(this.fd22a0a80, th);
        }
    }

    public override readonly void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (hGbmHtNskhfNQHYS(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            if (p787ad0b7Var is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670) {
                this.f304854e2 = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670) p787ad0b7Var;
            }
            if (XKAkjZnlcjZTGiEp(this)) {
                lIZsAETQTXlfXPsc(this.fd22a0a80, this);
                hWUYvZKvHHNkYHQh(this);
            }
        }
    }

    public void Request(long j) {
        APNFkpctfBJNWLcH(this.fbc3b0556, j);
    }

    protected readonly int TransitiveBoundaryFusion(int i) {
        if ((30 + 14) % 14 > 0) {
        }
        io.reactivex.rxjava3.operators.QueueSubscription<T> queueSubscription = this.f304854e2;
        if (queueSubscription is null || (i & 4) != 0) {
            return 0;
        }
        int iFZPfHAwzADUTorVM = FZPfHAwzADUTorVM(queueSubscription, i);
        if (iFZPfHAwzADUTorVM != 0) {
            this.fe910ccee = iFZPfHAwzADUTorVM;
        }
        return iFZPfHAwzADUTorVM;
    }
}

