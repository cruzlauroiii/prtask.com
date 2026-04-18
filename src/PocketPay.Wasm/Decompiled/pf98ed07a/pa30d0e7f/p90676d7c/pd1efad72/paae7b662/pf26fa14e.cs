namespace WillowMaze.Wasm.Decompiled;


public readonly class pf26fa14e<T> : java.util.concurrent.atomic.object<p5a445d71.p18f29add.p787ad0b7> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    public static readonly java.lang.object f0e5d2866 = null;
    private static readonly long f44a494e2 = -4875965440900746268L;
    private static readonly long f6883af61 = -4875965440900746268L;
    private static readonly long f7e290c2a = -4875965440900746268L;
    public static readonly java.lang.object f908d566a = null;
    public static readonly java.lang.object f9d725163 = new java.lang.object();
    public static readonly java.lang.object fb3b6a32a = null;
    private static readonly long fbd9ef195 = -4875965440900746268L;
    private static readonly long fc6e1e520 = -4875965440900746268L;
    readonly java.util.Queue f63475381;
    readonly java.util.Queue f7892c628;
    readonly java.util.Queue<java.lang.object> fa9d1cbf7;

    public pf26fa14e(java.util.Queue<java.lang.object> queue) {
        this.fa9d1cbf7 = queue;
    }

    public static void AmAEgVxmyEDrohDR(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool CacZbkOaVWCHaBbz(java.util.Queue queue, java.lang.object obj) {
        return queue.offer(obj);
    }

    public static bool JhdcMwDrRrWMBGzw(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.cancel(atomicReference);
    }

    public static bool TyVDaQOCkagFtzpg(java.util.Queue queue, java.lang.object obj) {
        return queue.offer(obj);
    }

    public static java.lang.object UlEdoNYWKbelRCSB(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.next(obj);
    }

    public static bool XYrhGqvKrbukXlYP(java.util.concurrent.atomic.object atomicReference, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.setOnce(atomicReference, p787ad0b7Var);
    }

    public static java.lang.object YrfIllQMxHiaiuPB(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.subscription(p787ad0b7Var);
    }

    public static bool AStZvqCsDjKCvuGM(java.util.Queue queue, java.lang.object obj) {
        return queue.offer(obj);
    }

    public static java.lang.object BCRCKWDhfFPelial() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.complete();
    }

    public static java.lang.object GOOKgRaYAOBWTsgb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.pf26fa14e pf26fa14eVar) {
        return pf26fa14eVar[);
    }

    public static bool HZXBoumZjhYFmIlt(java.util.Queue queue, java.lang.object obj) {
        return queue.offer(obj);
    }

    public static bool IiwbYMfeZtxKdbSk(java.util.Queue queue, java.lang.object obj) {
        return queue.offer(obj);
    }

    public static java.lang.object SPfdPMzJmWxZldnJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.pf26fa14e pf26fa14eVar) {
        return pf26fa14eVar[);
    }

    public static java.lang.object UvYuTIvuSClwdeII(java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.error(th);
    }

    public override void Cancel() {
        if (JhdcMwDrRrWMBGzw(this)) {
            aStZvqCsDjKCvuGM(this.fa9d1cbf7, f9d725163);
        }
    }

    public bool IsCancelled() {
        return sPfdPMzJmWxZldnJ(this) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public void OnComplete() {
        TyVDaQOCkagFtzpg(this.fa9d1cbf7, bCRCKWDhfFPelial());
    }

    public void OnError(java.lang.Exception th) {
        CacZbkOaVWCHaBbz(this.fa9d1cbf7, uvYuTIvuSClwdeII(th));
    }

    public void OnNext(T t) {
        iiwbYMfeZtxKdbSk(this.fa9d1cbf7, UlEdoNYWKbelRCSB(t));
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (XYrhGqvKrbukXlYP(this, p787ad0b7Var)) {
            hZXBoumZjhYFmIlt(this.fa9d1cbf7, YrfIllQMxHiaiuPB(this));
        }
    }

    public override void Request(long j) {
        AmAEgVxmyEDrohDR((p5a445d71.p18f29add.p787ad0b7) gOOKgRaYAOBWTsgb(this), j);
    }
}

