namespace WillowMaze.Wasm.Decompiled;


readonly class pc50c153b$p20b65f80<T, R> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, io.reactivex.rxjava3.internal.observers.InnerQueuedObserverSupport<R> {
    private static readonly long f55d16aa8 = 8080567949447303262L;
    private static readonly long f77116a25 = 8080567949447303262L;
    private static readonly long fc6e1e520 = 8080567949447303262L;
    private static readonly long fcb75aaf5 = 8080567949447303262L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f0f6ea442;
    int f0f880c3e;
    readonly int f1853a385;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 f195cf13d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f1a2f128f;
    readonly io.reactivex.rxjava3.core.Observer f214c8e08;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f2b52ab03;
    volatile bool f2b7e18e1;
    volatile bool f2e289c0f;
    volatile bool f38881e0a;
    readonly int f42088376;
    io.reactivex.rxjava3.internal.observers.InnerQueuedObserver<R> f43b5c917;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> f4b9f83e1;
    readonly int f4c203b76;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f4d1c03e2;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f4fa958f6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f560019e4;
    int f62d44218;
    int f67b0b6eb;
    readonly int f6b0235dd;
    volatile bool f6b2ded51;
    readonly java.util.ArrayQueue f6ef877be;
    int f78f24fd3;
    readonly java.util.ArrayQueue f8262e2f7;
    readonly int f8417c3de;
    volatile bool f8fbc3437;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 f91fe5905;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 f93790f29;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 fa5fe169a;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 fa94e5b29;
    io.reactivex.rxjava3.operators.SimpleQueue<T> fa9d1cbf7;
    readonly int fb70694f7;
    readonly java.util.ArrayQueue fb860f385;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    volatile bool fcc2a357d;
    readonly io.reactivex.rxjava3.core.Observer fcd2d3e3f;
    pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p6a757152 fce296ff5;
    readonly io.reactivex.rxjava3.core.Observer<R> fd22a0a80;
    pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p6a757152 fd7401315;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd8bd4d3d;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fdb7cffb2;
    readonly java.util.ArrayQueue fe0f740fc;
    pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p6a757152 fe1b21dff;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fe22531b6;
    volatile bool fe5a29e81;
    int fe910ccee;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fe9882cfa;
    pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p6a757152 fe989c32d;
    int ff1c5d735;
    readonly int ff1dfe411;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 ff3aa9fb5;
    int ff753a78c;
    readonly io.reactivex.rxjava3.core.Observer ffc5fa655;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    readonly java.util.ArrayQueue<io.reactivex.rxjava3.internal.observers.InnerQueuedObserver<R>> f6ea648a6 = new java.util.ArrayQueue<>();

    pc50c153b$p20b65f80(io.reactivex.rxjava3.core.Observer<R> observer, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> function, int i, int i2, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var) {
        this.fd22a0a80 = observer;
        this.f4b9f83e1 = function;
        this.f42088376 = i;
        this.f4c203b76 = i2;
        this.f560019e4 = pcd04add9Var;
    }

    public static bool AjpXHlLTyaEFrnnt(java.util.ArrayQueue arrayQueue, java.lang.object obj) {
        return arrayQueue.offer(obj);
    }

    public static void BBdZwFLfotuSznpQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80) {
        pc50c153b_p20b65f80.disposeAll();
    }

    public static void COYNqooCUojiURyc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void CburYWTCBnlQuIaC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void DIOHXYqFwQISSLgt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p6a757152 p6a757152Var) {
        p6a757152Var.setDone();
    }

    public static java.lang.object DOlXPymOQbIeTMoC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static java.lang.object DgIYbBPpdrwTeNOU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static void FnSFNjMURTwzSsDD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80) {
        pc50c153b_p20b65f80.drain();
    }

    public static void GBaTQsSJTximYwAK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void GptKQQBzqDOSUEEM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p6a757152 p6a757152Var) {
        p6a757152Var.setDone();
    }

    public static void HFhiMbWRAOdmBita(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80) {
        pc50c153b_p20b65f80.drain();
    }

    public static void IqZyzEkTBgFFkTXP(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static java.lang.object JZcjZwnWRhmNuluu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static void KYUKDLZdQJIakWMR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void KoWQIxmiKWjgYVbe(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static java.lang.object LsYiCBaVVsPoHaxx(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.poll();
    }

    public static void NPrMkObgJjbqAGiQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80) {
        pc50c153b_p20b65f80.disposeAll();
    }

    public static void NZIJmZnLMhsaqmbW(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object NaNBHhdrxOMotbAc(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.poll();
    }

    public static void OAMmNuMhWEwHNdyW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80) {
        pc50c153b_p20b65f80.drain();
    }

    public static void ObqeYqWMFpsStUdm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80) {
        pc50c153b_p20b65f80.disposeAll();
    }

    public static void OuizykhzXpaNavIS(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void PdQKpxMCOUhjeFOZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void PuvWKUudwLcpbGFO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void SKWPjfTdkJFTSsrf(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static bool TUOaEUmLjmEXbUEi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static bool VITWghcQmpunQpKZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static java.lang.object VxoYGoiieHKJGesV(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.poll();
    }

    public static void WHderejOLLnyZJmU(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void WUySUSlFKkeuzHYx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80) {
        pc50c153b_p20b65f80.disposeAll();
    }

    public static void XEyQQVnSJiYsRVKu(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void XVmgtFqPAgfcrZue(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void YslZYtqMrAMuiHft(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static java.lang.object YttvnzIrXjdWHcal(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static void APcXZdmCEKyXPmmQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80) {
        pc50c153b_p20b65f80.drainAndDispose();
    }

    public static void AQltLdEUUPnacYWH(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static bool BPGeFnwyBUHotQTe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p6a757152 p6a757152Var) {
        return p6a757152Var.isDone();
    }

    public static int BfmIaOYhtqrWxiSH(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var, int i) {
        return p8df47e16Var.requestFusion(i);
    }

    public static void CsKUnvhRRouNWoVX(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 DOPCASflJZiAhKhN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p6a757152 p6a757152Var) {
        return p6a757152Var.queue();
    }

    public static bool EFugzLwhavLEDQVO(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void EcSryzoygQKMpRLE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80) {
        pc50c153b_p20b65f80.disposeAll();
    }

    public static void GBpeWesbKZIzyDUc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80) {
        pc50c153b_p20b65f80.drain();
    }

    public static void GLcNddKdPHhFdQZe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        p36a52e5dVar.tryTerminateAndReport();
    }

    public static bool HAOgioGvKvdEbyfs(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public static bool JsUhFLZwThjNzGwz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void JsXnxJrOAXJQjKoI(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void KeICWXWzrblehtRS(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static int LMZJCcUpLbrxxzfZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80) {
        return pc50c153b_p20b65f80.getAndIncrement();
    }

    public static void LNbaeZzLYHHNdgNE(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void LdxkgxSRAgbggLoG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80) {
        pc50c153b_p20b65f80.disposeAll();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 McdHqJUlYxguTZOf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p6a757152 p6a757152Var) {
        return p6a757152Var.queue();
    }

    public static void NDdYpwwvOOKzZKdN(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static java.lang.object NTyDSAQkHsQzAaaF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static void NlkQtliVRoyKYGHu(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void OCRNRpwsaRaCalZI(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void OKDbYhlBFAMllaxe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p6a757152 p6a757152Var) {
        p6a757152Var.dispose();
    }

    public static void OTEAeRZmhQrVJWjo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p6a757152 p6a757152Var) {
        p6a757152Var.dispose();
    }

    public static void OwEukZcDCyGWqOiY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80) {
        pc50c153b_p20b65f80.drain();
    }

    public static java.lang.object PLtfOGfJMSXWreJJ(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void QvFppeZJTYLPcXbL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80) {
        pc50c153b_p20b65f80.drain();
    }

    public static int RviedVrLkCVzyxVb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80, int i) {
        return pc50c153b_p20b65f80.addAndGet(i);
    }

    public static bool SfvfGpnPkdvllOjp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void ShoqIwNvgsCRscVu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80) {
        pc50c153b_p20b65f80.disposeAll();
    }

    public static void TiAOBZrnXcMKJegi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80) {
        pc50c153b_p20b65f80.drain();
    }

    public static int ULTJHkmeVJvMRaiS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80) {
        return pc50c153b_p20b65f80.getAndIncrement();
    }

    public static void VFCbWKvshKYgHEVb(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void VgExOLhJgxbkTGwM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80) {
        pc50c153b_p20b65f80.disposeAll();
    }

    public static java.lang.object WGhkIIxycRzJUUJA(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.poll();
    }

    public static bool WcBXvlwSWyqtBIZr(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public static void XCcTktIwuuTwNSAF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80) {
        pc50c153b_p20b65f80.disposeAll();
    }

    public static void XXvrlDiTRUoNajvT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80) {
        pc50c153b_p20b65f80.disposeAll();
    }

    public static int XdrsmJJxFYobsPJY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc50c153b$p20b65f80 pc50c153b_p20b65f80) {
        return pc50c153b_p20b65f80.decrementAndGet();
    }

    public static void XxKuYmaCdjyWJRGX(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static java.lang.object YEmtVDdxfWLauAaC(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void ZGlvSajNCeLAHTxW(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void ZhEmeKZzxsYMdUtO(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public override void Dispose() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        XVmgtFqPAgfcrZue(this.fbc3b0556);
        gLcNddKdPHhFdQZe(this.f07213a01);
        aPcXZdmCEKyXPmmQ(this);
    }

    void disposeAll() {
        io.reactivex.rxjava3.internal.observers.InnerQueuedObserver<R> innerQueuedObserver = this.f43b5c917;
        if (innerQueuedObserver is not null) {
            oTEAeRZmhQrVJWjo(innerQueuedObserver);
        }
        while (true) {
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p6a757152 p6a757152Var = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p6a757152) VxoYGoiieHKJGesV(this.f6ea648a6);
            if (p6a757152Var is null) {
                return;
            } else {
                oKDbYhlBFAMllaxe(p6a757152Var);
            }
        }
    }

    public void Drain() {
        if ((30 + 8) % 8 > 0) {
        }
        if (uLTJHkmeVJvMRaiS(this) != 0) {
            return;
        }
        io.reactivex.rxjava3.operators.SimpleQueue<T> simpleQueue = this.fa9d1cbf7;
        java.util.ArrayQueue<io.reactivex.rxjava3.internal.observers.InnerQueuedObserver<R>> arrayQueue = this.f6ea648a6;
        io.reactivex.rxjava3.core.Observer<R> observer = this.fd22a0a80;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9 pcd04add9Var = this.f560019e4;
        int iRviedVrLkCVzyxVb = 1;
        while (true) {
            int i = this.ff1c5d735;
            while (i != this.f42088376) {
                if (this.f38881e0a) {
                    aQltLdEUUPnacYWH(simpleQueue);
                    xCcTktIwuuTwNSAF(this);
                    return;
                }
                if (pcd04add9Var == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9.fe35884a2 && ((java.lang.Exception) DgIYbBPpdrwTeNOU(this.f07213a01)) is not null) {
                    KoWQIxmiKWjgYVbe(simpleQueue);
                    shoqIwNvgsCRscVu(this);
                    CburYWTCBnlQuIaC(this.f07213a01, this.fd22a0a80);
                    return;
                }
                try {
                    java.lang.object objLsYiCBaVVsPoHaxx = LsYiCBaVVsPoHaxx(simpleQueue);
                    if (objLsYiCBaVVsPoHaxx is null) {
                        break;
                    }
                    io.reactivex.rxjava3.core.ObservableSource observableSource = (io.reactivex.rxjava3.core.ObservableSource) pLtfOGfJMSXWreJJ(yEmtVDdxfWLauAaC(this.f4b9f83e1, objLsYiCBaVVsPoHaxx), "The mapper returned a null ObservableSource");
                    pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p6a757152 p6a757152Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p6a757152(this, this.f4c203b76);
                    AjpXHlLTyaEFrnnt(arrayQueue, p6a757152Var);
                    nDdYpwwvOOKzZKdN(observableSource, p6a757152Var);
                    i++;
                } catch (java.lang.Exception th) {
                    NZIJmZnLMhsaqmbW(th);
                    YslZYtqMrAMuiHft(this.fbc3b0556);
                    csKUnvhRRouNWoVX(simpleQueue);
                    NPrMkObgJjbqAGiQ(this);
                    VITWghcQmpunQpKZ(this.f07213a01, th);
                    KYUKDLZdQJIakWMR(this.f07213a01, this.fd22a0a80);
                    return;
                }
            }
            this.ff1c5d735 = i;
            if (this.f38881e0a) {
                keICWXWzrblehtRS(simpleQueue);
                BBdZwFLfotuSznpQ(this);
                return;
            }
            if (pcd04add9Var == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9.fe35884a2 && ((java.lang.Exception) nTyDSAQkHsQzAaaF(this.f07213a01)) is not null) {
                zhEmeKZzxsYMdUtO(simpleQueue);
                WUySUSlFKkeuzHYx(this);
                GBaTQsSJTximYwAK(this.f07213a01, this.fd22a0a80);
                return;
            }
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p6a757152 p6a757152Var2 = this.f43b5c917;
            if (p6a757152Var2 is null) {
                if (pcd04add9Var == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9.fa52f733b && ((java.lang.Exception) YttvnzIrXjdWHcal(this.f07213a01)) is not null) {
                    vFCbWKvshKYgHEVb(simpleQueue);
                    xXvrlDiTRUoNajvT(this);
                    PuvWKUudwLcpbGFO(this.f07213a01, observer);
                    return;
                }
                bool z = this.f6b2ded51;
                pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p6a757152 p6a757152Var3 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p6ea648a6.p6a757152) NaNBHhdrxOMotbAc(arrayQueue);
                bool z2 = p6a757152Var3 is null;
                if (z && z2) {
                    if (((java.lang.Exception) DOlXPymOQbIeTMoC(this.f07213a01)) is null) {
                        IqZyzEkTBgFFkTXP(observer);
                        return;
                    }
                    zGlvSajNCeLAHTxW(simpleQueue);
                    vgExOLhJgxbkTGwM(this);
                    COYNqooCUojiURyc(this.f07213a01, observer);
                    return;
                }
                if (!z2) {
                    this.f43b5c917 = p6a757152Var3;
                }
                p6a757152Var2 = p6a757152Var3;
            }
            if (p6a757152Var2 is not null) {
                pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823VarDOPCASflJZiAhKhN = dOPCASflJZiAhKhN(p6a757152Var2);
                while (true) {
                    if (this.f38881e0a) {
                        SKWPjfTdkJFTSsrf(simpleQueue);
                        ldxkgxSRAgbggLoG(this);
                        return;
                    }
                    bool zBPGeFnwyBUHotQTe = bPGeFnwyBUHotQTe(p6a757152Var2);
                    if (pcd04add9Var == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9.fe35884a2 && ((java.lang.Exception) JZcjZwnWRhmNuluu(this.f07213a01)) is not null) {
                        xxKuYmaCdjyWJRGX(simpleQueue);
                        ecSryzoygQKMpRLE(this);
                        PdQKpxMCOUhjeFOZ(this.f07213a01, observer);
                        return;
                    }
                    try {
                        java.lang.object objWGhkIIxycRzJUUJA = wGhkIIxycRzJUUJA(pe1601823VarDOPCASflJZiAhKhN);
                        bool z3 = objWGhkIIxycRzJUUJA is null;
                        if (zBPGeFnwyBUHotQTe && z3) {
                            this.f43b5c917 = null;
                            this.ff1c5d735--;
                        } else if (!z3) {
                            XEyQQVnSJiYsRVKu(observer, objWGhkIIxycRzJUUJA);
                        }
                    } catch (java.lang.Exception th2) {
                        lNbaeZzLYHHNdgNE(th2);
                        jsUhFLZwThjNzGwz(this.f07213a01, th2);
                        this.f43b5c917 = null;
                        this.ff1c5d735--;
                    }
                }
            }
            iRviedVrLkCVzyxVb = rviedVrLkCVzyxVb(this, -iRviedVrLkCVzyxVb);
            if (iRviedVrLkCVzyxVb == 0) {
                return;
            }
        }
    }

    void drainAndDispose() {
        if (lMZJCcUpLbrxxzfZ(this) != 0) {
            return;
        }
        do {
            OuizykhzXpaNavIS(this.fa9d1cbf7);
            ObqeYqWMFpsStUdm(this);
        } while (xdrsmJJxFYobsPJY(this) != 0);
    }

    public void InnerComplete(io.reactivex.rxjava3.internal.observers.InnerQueuedObserver<R> innerQueuedObserver) {
        DIOHXYqFwQISSLgt(innerQueuedObserver);
        owEukZcDCyGWqOiY(this);
    }

    public void InnerError(io.reactivex.rxjava3.internal.observers.InnerQueuedObserver<R> innerQueuedObserver, java.lang.Exception th) {
        if (TUOaEUmLjmEXbUEi(this.f07213a01, th)) {
            if (this.f560019e4 == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcd04add9.fe35884a2) {
                nlkQtliVRoyKYGHu(this.fbc3b0556);
            }
            GptKQQBzqDOSUEEM(innerQueuedObserver);
            tiAOBZrnXcMKJegi(this);
        }
    }

    public void InnerNext(io.reactivex.rxjava3.internal.observers.InnerQueuedObserver<R> innerQueuedObserver, R r) {
        hAOgioGvKvdEbyfs(mcdHqJUlYxguTZOf(innerQueuedObserver), r);
        OAMmNuMhWEwHNdyW(this);
    }

    public override bool IsDisposed() {
        return this.f38881e0a;
    }

    public override void OnComplete() {
        this.f6b2ded51 = true;
        gBpeWesbKZIzyDUc(this);
    }

    public override void OnError(java.lang.Exception th) {
        if (sfvfGpnPkdvllOjp(this.f07213a01, th)) {
            this.f6b2ded51 = true;
            HFhiMbWRAOdmBita(this);
        }
    }

    public override void OnNext(T t) {
        if (this.fe910ccee == 0) {
            wcBXvlwSWyqtBIZr(this.fa9d1cbf7, t);
        }
        FnSFNjMURTwzSsDD(this);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((2 + 13) % 13 > 0) {
        }
        if (eFugzLwhavLEDQVO(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            if (p7beea252Var is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16) {
                pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16) p7beea252Var;
                int iBfmIaOYhtqrWxiSH = bfmIaOYhtqrWxiSH(p8df47e16Var, 3);
                if (iBfmIaOYhtqrWxiSH == 1) {
                    this.fe910ccee = iBfmIaOYhtqrWxiSH;
                    this.fa9d1cbf7 = p8df47e16Var;
                    this.f6b2ded51 = true;
                    WHderejOLLnyZJmU(this.fd22a0a80, this);
                    qvFppeZJTYLPcXbL(this);
                    return;
                }
                if (iBfmIaOYhtqrWxiSH == 2) {
                    this.fe910ccee = iBfmIaOYhtqrWxiSH;
                    this.fa9d1cbf7 = p8df47e16Var;
                    oCRNRpwsaRaCalZI(this.fd22a0a80, this);
                    return;
                }
            }
            this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(this.f4c203b76);
            jsXnxJrOAXJQjKoI(this.fd22a0a80, this);
        }
    }
}

