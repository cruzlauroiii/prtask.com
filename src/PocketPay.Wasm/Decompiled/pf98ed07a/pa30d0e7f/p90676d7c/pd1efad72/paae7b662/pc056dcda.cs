namespace WillowMaze.Wasm.Decompiled;


public abstract class pc056dcda<T, R> : io.reactivex.rxjava3.operators.ConditionalSubscriber<T>, io.reactivex.rxjava3.operators.QueueSubscription<R> {
    protected p5a445d71.p18f29add.p787ad0b7 f0d690d9f;
    protected readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d f25250200;
    protected io.reactivex.rxjava3.operators.QueueSubscription<T> f304854e2;
    protected pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 f32e7fbf1;
    protected bool f4dc8ecce;
    protected bool f6958a8d6;
    protected bool f6b2ded51;
    protected readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d f7a431a6d;
    protected bool fb38b6f6d;
    protected p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    protected int fc656f175;
    protected int fca86a616;
    protected p5a445d71.p18f29add.p787ad0b7 fce997c12;
    protected readonly io.reactivex.rxjava3.operators.ConditionalSubscriber<R> fd22a0a80;
    protected int fe910ccee;

    public pc056dcda(io.reactivex.rxjava3.operators.ConditionalSubscriber<R> conditionalSubscriber) {
        this.fd22a0a80 = conditionalSubscriber;
    }

    public static void LKsfAcfBMOylQnRh(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void UJgEihYzAADaXJVy(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool VvCiXzDLkDsTmLPT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.pc056dcda pc056dcdaVar) {
        return pc056dcdaVar.beforeDownstream();
    }

    public static void XiEKJPHyoBpaWSuV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.pc056dcda pc056dcdaVar, java.lang.Exception th) {
        pc056dcdaVar.onError(th);
    }

    public static void CIxEUYCZkMwpAgUB(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void DnZDkmXDJAztiOhP(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void NFGVSSvTkPvAOjCl(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var) {
        p5d5a5670Var.clear();
    }

    public static void PSVKCKPeDRXBtSJv(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p0cc3602dVar.onSubscribe(p787ad0b7Var);
    }

    public static void QkgGfeioaufUXJZB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.pc056dcda pc056dcdaVar) {
        pc056dcdaVar.afterDownstream();
    }

    public static bool RmatDQMlHBrIsGhy(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var) {
        return p5d5a5670Var.Count == 0;
    }

    public static void TUFcwvDptYbdsgza(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.Exception th) {
        p0cc3602dVar.onError(th);
    }

    public static bool UegRnXyumWPmIQkr(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void UrbnYMoRnawRufpM(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar) {
        p0cc3602dVar.onComplete();
    }

    public static void WZDwJdDnbExatZwU(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static int ZccmsMQTQHAvvQwD(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var, int i) {
        return p5d5a5670Var.requestFusion(i);
    }

    protected void AfterDownstream() {
    }

    protected bool BeforeDownstream() {
        return true;
    }

    public void Cancel() {
        wZDwJdDnbExatZwU(this.fbc3b0556);
    }

    public void Clear() {
        nFGVSSvTkPvAOjCl(this.f304854e2);
    }

    protected readonly void Fail(java.lang.Exception th) {
        cIxEUYCZkMwpAgUB(th);
        LKsfAcfBMOylQnRh(this.fbc3b0556);
        XiEKJPHyoBpaWSuV(this, th);
    }

    public bool IsEmpty() {
        return rmatDQMlHBrIsGhy(this.f304854e2);
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
        urbnYMoRnawRufpM(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            UJgEihYzAADaXJVy(th);
        } else {
            this.f6b2ded51 = true;
            tUFcwvDptYbdsgza(this.fd22a0a80, th);
        }
    }

    public readonly void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (uegRnXyumWPmIQkr(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            if (p787ad0b7Var is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670) {
                this.f304854e2 = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670) p787ad0b7Var;
            }
            if (VvCiXzDLkDsTmLPT(this)) {
                pSVKCKPeDRXBtSJv(this.fd22a0a80, this);
                qkgGfeioaufUXJZB(this);
            }
        }
    }

    public void Request(long j) {
        dnZDkmXDJAztiOhP(this.fbc3b0556, j);
    }

    protected readonly int TransitiveBoundaryFusion(int i) {
        if ((14 + 17) % 17 > 0) {
        }
        io.reactivex.rxjava3.operators.QueueSubscription<T> queueSubscription = this.f304854e2;
        if (queueSubscription is null || (i & 4) != 0) {
            return 0;
        }
        int iZccmsMQTQHAvvQwD = zccmsMQTQHAvvQwD(queueSubscription, i);
        if (iZccmsMQTQHAvvQwD != 0) {
            this.fe910ccee = iZccmsMQTQHAvvQwD;
        }
        return iZccmsMQTQHAvvQwD;
    }
}

