namespace WillowMaze.Wasm.Decompiled;


readonly class p00fed11e$p6860313c<T> : io.reactivex.rxjava3.internal.subscriptions.DeferredScalarSubscription<T> {
    private static readonly long f2980dcd2 = 5629876084736248016L;
    private static readonly long f52b27ff5 = 5629876084736248016L;
    private static readonly long fc6e1e520 = 5629876084736248016L;
    private static readonly long feb6979bb = 5629876084736248016L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p00fed11e f671c0db0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p00fed11e f854cf7b2;
    readonly io.reactivex.rxjava3.processors.AsyncProcessor<T> fd0e45878;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p00fed11e fea8d333d;

    p00fed11e$p6860313c(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.processors.AsyncProcessor<T> asyncProcessor) {
        super(subscriber);
        this.fd0e45878 = asyncProcessor;
    }

    public static bool EgFVQyFJlARkQWWa(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p00fed11e$p6860313c p00fed11e_p6860313c) {
        return p00fed11e_p6860313c.isCancelled();
    }

    public static void MKiaYPVXwsPrXafG(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool UJtOaalaYdENoOam(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pb7d2cb4c pb7d2cb4cVar) {
        return super.tryCancel();
    }

    public static void UfEGlnpaQSXHSjyJ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void PFCJhuPdqsdRNpuR(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void TARqJIEibsZfofpd(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p00fed11e p00fed11eVar, pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p00fed11e$p6860313c p00fed11e_p6860313c) {
        p00fed11eVar.Remove(p00fed11e_p6860313c);
    }

    public static bool YzHuWRoggOQHCaff(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p00fed11e$p6860313c p00fed11e_p6860313c) {
        return p00fed11e_p6860313c.isCancelled();
    }

    public void Cancel() {
        if (UJtOaalaYdENoOam(this)) {
            tARqJIEibsZfofpd(this.fd0e45878, this);
        }
    }

    void onComplete() {
        if (EgFVQyFJlARkQWWa(this)) {
            return;
        }
        UfEGlnpaQSXHSjyJ(this.fd22a0a80);
    }

    void onError(java.lang.Exception th) {
        if (yzHuWRoggOQHCaff(this)) {
            MKiaYPVXwsPrXafG(th);
        } else {
            pFCJhuPdqsdRNpuR(this.fd22a0a80, th);
        }
    }
}

