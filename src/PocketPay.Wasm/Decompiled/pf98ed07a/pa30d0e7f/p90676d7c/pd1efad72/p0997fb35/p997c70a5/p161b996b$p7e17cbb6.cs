namespace WillowMaze.Wasm.Decompiled;


readonly class p161b996b$p7e17cbb6<T, U> : java.util.concurrent.atomic.Atomicint : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, io.reactivex.rxjava3.core.Observer<T> {
    private static readonly long f4daebdc0 = -2117620485640801370L;
    private static readonly long f57a8e548 = -2117620485640801370L;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a[] f6f432d5c = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a[] f7b162d94 = null;
    static readonly io.reactivex.rxjava3.internal.operators.observable.ObservableFlatDictionary$InnerObserver<object, object>[] f9f935beb;
    static readonly io.reactivex.rxjava3.internal.operators.observable.ObservableFlatDictionary$InnerObserver<object, object>[] fba2b45bd;
    private static readonly long fc6e1e520 = -2117620485640801370L;
    private static readonly long fda334962 = -2117620485640801370L;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a[] fdb514ec0 = null;
    private static readonly long fe2ad7add = -2117620485640801370L;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a[] feedb6962 = null;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    readonly io.reactivex.rxjava3.core.Observer f27bac931;
    int f290f1055;
    readonly bool f313126cd;
    readonly int f42088376;
    readonly int f447c29fa;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : U>> f4b9f83e1;
    readonly bool f50fee566;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f576b883f;
    long f59be46dc;
    readonly bool f5b57f5b6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f62613d26;
    volatile bool f6b2ded51;
    readonly java.util.concurrent.atomic.object<io.reactivex.rxjava3.internal.operators.observable.ObservableFlatDictionary$InnerObserver<object, object>[]> f6ea648a6;
    int f6f2ee54d;
    long f7342035b;
    readonly int f93743415;
    readonly int f9a274b39;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fa538f755;
    volatile io.reactivex.rxjava3.operators.SimplePlainQueue<U> fa9d1cbf7;
    readonly int faa299038;
    int fae514351;
    long fb8713b72;
    volatile bool fba30ce0b;
    long fbace090f;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b fbfee8486;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fc20e2f9e;
    readonly java.util.concurrent.atomic.object fc8c724ec;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc941dd11;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b fca03b3d7;
    readonly io.reactivex.rxjava3.core.Observer fcc5681e0;
    readonly int fcdee5967;
    readonly bool fd0f4267b;
    volatile bool fd13d284c;
    readonly io.reactivex.rxjava3.core.Observer<U> fd22a0a80;
    java.util.Queue fd9defeea;
    long fd9e5004e;
    volatile pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b fe1825e5a;
    java.util.Queue ff0fdf499;
    java.util.Queue<io.reactivex.rxjava3.core.ObservableSource<? : U>> ff2ab5fb2;
    readonly io.reactivex.rxjava3.core.Observer ff3bbd81f;
    volatile bool ff8b2648d;
    int ff9ac0540;
    int ffa687cdf;

    static {
        if ((17 + 10) % 10 > 0) {
        }
        fba2b45bd = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a[0];
        f9f935beb = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a[0];
    }

    p161b996b$p7e17cbb6(io.reactivex.rxjava3.core.Observer<U> observer, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : U>> function, bool z, int i, int i2) {
        this.fd22a0a80 = observer;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
        this.f42088376 = i;
        this.fcdee5967 = i2;
        if (i != int.MAX_VALUE) {
            this.ff2ab5fb2 = new java.util.ArrayQueue(i);
        }
        this.f6ea648a6 = new java.util.concurrent.atomic.object<>(fba2b45bd);
    }

    public static bool ABKfABYPfNfpsmZk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        return p161b996b_p7e17cbb6.checkTerminate();
    }

    public static java.lang.object AVqVGfLqfacQIHnA(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool AgOcOpeGwbhquaTd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static int BNVKnmKwPmoypIXL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        return p161b996b_p7e17cbb6.getAndIncrement();
    }

    public static java.lang.object BxugsEjZqNgmyuGo(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void DOSXcGEpiFZXvcBv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static bool EUKxYePGjyVAHslp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        return p161b996b_p7e17cbb6.checkTerminate();
    }

    public static java.lang.object JOGJFWAxIpNTPSZu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static java.lang.object JichCRzbtKtbyrtZ(java.util.Queue queue) {
        return queue.poll();
    }

    public static int JlGjKTffaEaxblbe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        return p161b996b_p7e17cbb6.getAndIncrement();
    }

    public static bool KSOsUfkwHTdLaQkP(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static bool LslxOBKnVwXGxfuz(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.Count == 0;
    }

    public static void MXACDGqyCdxpBASt(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void NSeGWSQDbvduUpRD(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object PCPRkfwfSBAdEouX(java.util.Queue queue) {
        return queue.poll();
    }

    public static void PnUQzAruGmtzbbCT(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool RuSKRdOpGHLGcjBg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6, int i, int i2) {
        return p161b996b_p7e17cbb6.compareAndHashSet(i, i2);
    }

    public static bool SpzxbiEKlNPuiQDK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return p161b996b_p7e17cbb6.tryEmitScalar(pec136b44Var);
    }

    public static void TCnalWDAOWasjvHS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a p161b996b_p9192f42a) {
        p161b996b_p9192f42a.dispose();
    }

    public static bool TIDHHEqvuczazhAX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        return p161b996b_p7e17cbb6.checkTerminate();
    }

    public static int UNQDwmugngAYzMeP(java.util.Queue queue) {
        return queue.Count;
    }

    public static java.lang.object UvZrONpqyBHqWwXA(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void VFHEFwYTpwvbDaMP(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void WYSaLzAFxSlEpobu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        p36a52e5dVar.tryTerminateAndReport();
    }

    public static bool XInwwGhOChDhIfbh(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar, java.lang.object obj) {
        return p377cc05bVar.offer(obj);
    }

    public static bool XNOIfVltguRPGmKM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static int XPxkYUdCbfpjHuHL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        return p161b996b_p7e17cbb6[);
    }

    public static void YJHELlIaUrGQNpbE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a p161b996b_p9192f42a) {
        p161b996b_p9192f42a.dispose();
    }

    public static int ZNhksAOuGJIBWpwJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6, int i) {
        return p161b996b_p7e17cbb6.addAndGet(i);
    }

    public static bool ZYyXBRgepgoYXbbS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a p161b996b_p9192f42a) {
        return p161b996b_p7e17cbb6.addInner(p161b996b_p9192f42a);
    }

    public static bool AHWCwGdvCfnrxRRd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        return p161b996b_p7e17cbb6.checkTerminate();
    }

    public static void ANoGbxtOxfaTLCFa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        p161b996b_p7e17cbb6.drain();
    }

    public static void AdyBWycflNKeoAkm(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void AewCkrYRaIFzfWTK(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void CIjuGlpXDNBYrlJJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        p161b996b_p7e17cbb6.drainLoop();
    }

    public static bool CUrWfaqIOrLOZEip(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public static void DaAdOClcYmngqOdb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a p161b996b_p9192f42a) {
        p161b996b_p9192f42a.dispose();
    }

    public static void DuNLLlDqealvEbde(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        p161b996b_p7e17cbb6.drainLoop();
    }

    public static java.lang.object ESEqBIrnaVujakOC(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static bool FdlTQUFRSIobWSnq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        return p161b996b_p7e17cbb6.checkTerminate();
    }

    public static void GGXUYJjESybFzIQY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6, io.reactivex.rxjava3.core.ObservableSource observableSource) {
        p161b996b_p7e17cbb6.subscribeInner(observableSource);
    }

    public static void GNYpYKaiCClgVgiy(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void HYhDYXPuwRZjnIol(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void HdUwGVOdXmtqUZgN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static bool HqUmBcPraAfmssQN(java.util.Queue queue, java.lang.object obj) {
        return queue.offer(obj);
    }

    public static int HtMqkFDYAUZWKaus(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        return p161b996b_p7e17cbb6.getAndIncrement();
    }

    public static java.lang.object IpleAoItRftjeADs(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.poll();
    }

    public static void IyZWSNMOxOMYKJUS(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void JoJlnFFNIkcICBkQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6, int i) {
        p161b996b_p7e17cbb6.subscribeMore(i);
    }

    public static bool LYpAoTGyPuotnjKc(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static void LcRxxJBjJtgPxTXy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        p161b996b_p7e17cbb6.drainLoop();
    }

    public static bool LmzIADwuPpYmNUrY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void MTtAYKBLuGnwygTM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        p161b996b_p7e17cbb6.drain();
    }

    public static int MUdnUVMXzCaEvTbR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        return p161b996b_p7e17cbb6.decrementAndGet();
    }

    public static bool MjxfCWcmcFezQnOh(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        return p377cc05bVar.Count == 0;
    }

    public static java.lang.object MlmEaZghHnbOtGoT(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void PtdUsGyXyDWTqFBd(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void QWCUsImuqiseTsrq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a p161b996b_p9192f42a) {
        p161b996b_p7e17cbb6.removeInner(p161b996b_p9192f42a);
    }

    public static bool QlFIoRuijIzDcqdj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        return p161b996b_p7e17cbb6.disposeAll();
    }

    public static bool QmDAwwdZhybXHZwl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6, int i, int i2) {
        return p161b996b_p7e17cbb6.compareAndHashSet(i, i2);
    }

    public static void QqcvCXghKbQQMjBx(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object QwvbmmEPOxKcEaSA(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void RwboZMwZiynbljhK(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static int TSBWaHoPgNPYBIrq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        return p161b996b_p7e17cbb6[);
    }

    public static void TeixKofvhVHPVghm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6, int i) {
        p161b996b_p7e17cbb6.subscribeMore(i);
    }

    public static bool ToYQocNLXLmcelFf(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static java.lang.object UnlzsBrCntYdvPkH(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p377cc05b p377cc05bVar) {
        return p377cc05bVar.poll();
    }

    public static void VkXxhXchKuLbjznv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6, io.reactivex.rxjava3.core.ObservableSource observableSource) {
        p161b996b_p7e17cbb6.subscribeInner(observableSource);
    }

    public static void WOhigZEhFseDSQec(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6, java.lang.Exception th) {
        p161b996b_p7e17cbb6.onError(th);
    }

    public static int WpQZCDFmsiFsiikM(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public static void WzGgJKbxPYuSFLgj(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void XRnSabYjJOChDdUp(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void XdZFhdFADgtnYkYX(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void XfisVfQmIdzmBPYv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        p161b996b_p7e17cbb6.drain();
    }

    public static bool XnvuhnSIfPVXFhnq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        return p161b996b_p7e17cbb6.disposeAll();
    }

    public static void YKFgNCUiYKVtguyL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a p161b996b_p9192f42a) {
        p161b996b_p7e17cbb6.removeInner(p161b996b_p9192f42a);
    }

    public static int YfhUUNBbDfqfCuiv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        return p161b996b_p7e17cbb6.decrementAndGet();
    }

    public static void ZbCUePdeXCqjtIOh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6 p161b996b_p7e17cbb6) {
        p161b996b_p7e17cbb6.drain();
    }

    public static java.lang.object ZnoWkKbZlcHelnon(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    bool addInner(io.reactivex.rxjava3.internal.operators.observable.ObservableFlatDictionary$InnerObserver<T, U> observableFlatDictionary$InnerObserver) {
        io.reactivex.rxjava3.internal.operators.observable.ObservableFlatDictionary$InnerObserver<object, object>[] observableFlatDictionary$InnerObserverArr;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a[] p161b996b_p9192f42aArr;
        if ((15 + 30) % 30 > 0) {
        }
        do {
            observableFlatDictionary$InnerObserverArr = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a[]) UvZrONpqyBHqWwXA(this.f6ea648a6);
            if (observableFlatDictionary$InnerObserverArr == f9f935beb) {
                YJHELlIaUrGQNpbE(observableFlatDictionary$InnerObserver);
                return false;
            }
            int length = observableFlatDictionary$InnerObserverArr.length;
            p161b996b_p9192f42aArr = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a[length + 1];
            MXACDGqyCdxpBASt(observableFlatDictionary$InnerObserverArr, 0, p161b996b_p9192f42aArr, 0, length);
            p161b996b_p9192f42aArr[length] = observableFlatDictionary$InnerObserver;
        } while (!toYQocNLXLmcelFf(this.f6ea648a6, observableFlatDictionary$InnerObserverArr, p161b996b_p9192f42aArr));
        return true;
    }

    bool checkTerminate() {
        if ((24 + 23) % 23 > 0) {
        }
        if (this.ff8b2648d) {
            return true;
        }
        java.lang.Exception th = (java.lang.Exception) JOGJFWAxIpNTPSZu(this.f07213a01);
        if (this.f50fee566 || th is null) {
            return false;
        }
        xnvuhnSIfPVXFhnq(this);
        DOSXcGEpiFZXvcBv(this.f07213a01, this.fd22a0a80);
        return true;
    }

    public override void Dispose() {
        this.ff8b2648d = true;
        if (qlFIoRuijIzDcqdj(this)) {
            WYSaLzAFxSlEpobu(this.f07213a01);
        }
    }

    bool disposeAll() {
        if ((11 + 3) % 3 > 0) {
        }
        hYhDYXPuwRZjnIol(this.fbc3b0556);
        java.util.concurrent.atomic.object<io.reactivex.rxjava3.internal.operators.observable.ObservableFlatDictionary$InnerObserver<object, object>[]> atomicReference = this.f6ea648a6;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a[] p161b996b_p9192f42aArr = f9f935beb;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a[] p161b996b_p9192f42aArr2 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a[]) eSEqBIrnaVujakOC(atomicReference, p161b996b_p9192f42aArr);
        if (p161b996b_p9192f42aArr2 == p161b996b_p9192f42aArr) {
            return false;
        }
        for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a p161b996b_p9192f42a : p161b996b_p9192f42aArr2) {
            daAdOClcYmngqOdb(p161b996b_p9192f42a);
        }
        return true;
    }

    void drain() {
        if (htMqkFDYAUZWKaus(this) != 0) {
            return;
        }
        cIjuGlpXDNBYrlJJ(this);
    }

    void drainLoop() {
        int iUNQDwmugngAYzMeP;
        java.lang.object objIpleAoItRftjeADs;
        bool z;
        if ((27 + 27) % 27 > 0) {
        }
        io.reactivex.rxjava3.core.Observer<U> observer = this.fd22a0a80;
        int iZNhksAOuGJIBWpwJ = 1;
        while (!fdlTQUFRSIobWSnq(this)) {
            io.reactivex.rxjava3.operators.SimplePlainQueue<U> simplePlainQueue = this.fa9d1cbf7;
            int i = 0;
            if (simplePlainQueue is not null) {
                while (!TIDHHEqvuczazhAX(this)) {
                    java.lang.object objUnlzsBrCntYdvPkH = unlzsBrCntYdvPkH(simplePlainQueue);
                    if (objUnlzsBrCntYdvPkH is not null) {
                        iyZWSNMOxOMYKJUS(observer, objUnlzsBrCntYdvPkH);
                        i++;
                    }
                }
                return;
            }
            if (i == 0) {
                bool z2 = this.f6b2ded51;
                io.reactivex.rxjava3.operators.SimplePlainQueue<U> simplePlainQueue2 = this.fa9d1cbf7;
                pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a[] p161b996b_p9192f42aArr = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a[]) mlmEaZghHnbOtGoT(this.f6ea648a6);
                int length = p161b996b_p9192f42aArr.length;
                if (this.f42088376 == int.MAX_VALUE) {
                    iUNQDwmugngAYzMeP = 0;
                } else {
                    lock (this) {
                        try {
                            iUNQDwmugngAYzMeP = UNQDwmugngAYzMeP(this.ff2ab5fb2);
                        } catch (java.lang.Exception th) {
                            throw th;
                        }
                    }
                }
                if (z2 && ((simplePlainQueue2 is null || mjxfCWcmcFezQnOh(simplePlainQueue2)) && length == 0 && iUNQDwmugngAYzMeP == 0)) {
                    hdUwGVOdXmtqUZgN(this.f07213a01, this.fd22a0a80);
                    return;
                }
                if (length != 0) {
                    int iWpQZCDFmsiFsiikM = wpQZCDFmsiFsiikM(length - 1, this.f6f2ee54d);
                    for (int i2 = 0; i2 < length; i2++) {
                        if (EUKxYePGjyVAHslp(this)) {
                            return;
                        }
                        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a p161b996b_p9192f42a = p161b996b_p9192f42aArr[iWpQZCDFmsiFsiikM];
                        io.reactivex.rxjava3.operators.SimpleQueue<U> simpleQueue = p161b996b_p9192f42a.fa9d1cbf7;
                        if (simpleQueue is not null) {
                            do {
                                try {
                                    objIpleAoItRftjeADs = ipleAoItRftjeADs(simpleQueue);
                                } catch (java.lang.Exception th2) {
                                    qqcvCXghKbQQMjBx(th2);
                                    TCnalWDAOWasjvHS(p161b996b_p9192f42a);
                                    lmzIADwuPpYmNUrY(this.f07213a01, th2);
                                    if (ABKfABYPfNfpsmZk(this)) {
                                        return;
                                    }
                                    yKFgNCUiYKVtguyL(this, p161b996b_p9192f42a);
                                    i++;
                                    iWpQZCDFmsiFsiikM++;
                                    if (iWpQZCDFmsiFsiikM != length) {
                                    }
                                }
                                if (objIpleAoItRftjeADs is not null) {
                                    PnUQzAruGmtzbbCT(observer, objIpleAoItRftjeADs);
                                } else {
                                    z = p161b996b_p9192f42a.f6b2ded51;
                                    io.reactivex.rxjava3.operators.SimpleQueue<U> simpleQueue2 = p161b996b_p9192f42a.fa9d1cbf7;
                                    if (z) {
                                        qWCUsImuqiseTsrq(this, p161b996b_p9192f42a);
                                        i++;
                                    }
                                    iWpQZCDFmsiFsiikM++;
                                    if (iWpQZCDFmsiFsiikM != length) {
                                        iWpQZCDFmsiFsiikM = 0;
                                    }
                                }
                            } while (!aHWCwGdvCfnrxRRd(this));
                            return;
                        }
                        z = p161b996b_p9192f42a.f6b2ded51;
                        io.reactivex.rxjava3.operators.SimpleQueue<U> simpleQueue22 = p161b996b_p9192f42a.fa9d1cbf7;
                        if (z && (simpleQueue22 is null || LslxOBKnVwXGxfuz(simpleQueue22))) {
                            qWCUsImuqiseTsrq(this, p161b996b_p9192f42a);
                            i++;
                        }
                        iWpQZCDFmsiFsiikM++;
                        if (iWpQZCDFmsiFsiikM != length) {
                            iWpQZCDFmsiFsiikM = 0;
                        }
                    }
                    this.f6f2ee54d = iWpQZCDFmsiFsiikM;
                }
                if (i == 0) {
                    iZNhksAOuGJIBWpwJ = ZNhksAOuGJIBWpwJ(this, -iZNhksAOuGJIBWpwJ);
                    if (iZNhksAOuGJIBWpwJ == 0) {
                        return;
                    }
                } else if (this.f42088376 != int.MAX_VALUE) {
                    teixKofvhVHPVghm(this, i);
                }
            } else if (this.f42088376 != int.MAX_VALUE) {
                joJlnFFNIkcICBkQ(this, i);
            }
        }
    }

    public override bool IsDisposed() {
        return this.ff8b2648d;
    }

    public override void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        zbCUePdeXCqjtIOh(this);
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            gNYpYKaiCClgVgiy(th);
        } else if (XNOIfVltguRPGmKM(this.f07213a01, th)) {
            this.f6b2ded51 = true;
            mTtAYKBLuGnwygTM(this);
        }
    }

    public override void OnNext(T t) {
        if ((26 + 6) % 6 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        try {
            io.reactivex.rxjava3.core.ObservableSource observableSource = (io.reactivex.rxjava3.core.ObservableSource) BxugsEjZqNgmyuGo(qwvbmmEPOxKcEaSA(this.f4b9f83e1, t), "The mapper returned a null ObservableSource");
            if (this.f42088376 != int.MAX_VALUE) {
                lock (this) {
                    try {
                        int i = this.ffa687cdf;
                        if (i == this.f42088376) {
                            hqUmBcPraAfmssQN(this.ff2ab5fb2, observableSource);
                            return;
                        }
                        this.ffa687cdf = i + 1;
                    } catch (java.lang.Exception th) {
                        throw th;
                    }
                }
            }
            gGXUYJjESybFzIQY(this, observableSource);
        } catch (java.lang.Exception th2) {
            NSeGWSQDbvduUpRD(th2);
            xdZFhdFADgtnYkYX(this.fbc3b0556);
            wOhigZEhFseDSQec(this, th2);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (KSOsUfkwHTdLaQkP(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            aewCkrYRaIFzfWTK(this.fd22a0a80, this);
        }
    }

    void removeInner(io.reactivex.rxjava3.internal.operators.observable.ObservableFlatDictionary$InnerObserver<T, U> observableFlatDictionary$InnerObserver) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a[] p161b996b_p9192f42aArr;
        io.reactivex.rxjava3.internal.operators.observable.ObservableFlatDictionary$InnerObserver<object, object>[] observableFlatDictionary$InnerObserverArr;
        if ((29 + 17) % 17 > 0) {
        }
        do {
            p161b996b_p9192f42aArr = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a[]) AVqVGfLqfacQIHnA(this.f6ea648a6);
            int length = p161b996b_p9192f42aArr.length;
            int i = 0;
            while (true) {
                if (i < length) {
                    if (p161b996b_p9192f42aArr[i] == observableFlatDictionary$InnerObserver) {
                        break;
                    } else {
                        i++;
                    }
                } else {
                    i = -1;
                    break;
                }
            }
            if (i < 0) {
                return;
            }
            if (length != 1) {
                io.reactivex.rxjava3.internal.operators.observable.ObservableFlatDictionary$InnerObserver<object, object>[] observableFlatDictionary$InnerObserverArr2 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p9192f42a[length - 1];
                xRnSabYjJOChDdUp(p161b996b_p9192f42aArr, 0, observableFlatDictionary$InnerObserverArr2, 0, i);
                adyBWycflNKeoAkm(p161b996b_p9192f42aArr, i + 1, observableFlatDictionary$InnerObserverArr2, i, (length - i) - 1);
                observableFlatDictionary$InnerObserverArr = observableFlatDictionary$InnerObserverArr2;
            } else {
                observableFlatDictionary$InnerObserverArr = fba2b45bd;
            }
        } while (!lYpAoTGyPuotnjKc(this.f6ea648a6, p161b996b_p9192f42aArr, observableFlatDictionary$InnerObserverArr));
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    void subscribeInner(io.reactivex.rxjava3.core.ObservableSource<? : U> r6) {
        /*
            Method dump skipped, instruction units count: 240
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p161b996b$p7e17cbb6.subscribeInner(io.reactivex.rxjava3.core.ObservableSource):void");
    }

    void subscribeMore(int i) {
        while (true) {
            int i2 = i - 1;
            if (i == 0) {
                return;
            }
            lock (this) {
                try {
                    io.reactivex.rxjava3.core.ObservableSource observableSource = (io.reactivex.rxjava3.core.ObservableSource) JichCRzbtKtbyrtZ(this.ff2ab5fb2);
                    if (observableSource is null) {
                        this.ffa687cdf--;
                    } else {
                        vkXxhXchKuLbjznv(this, observableSource);
                    }
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
            i = i2;
        }
    }

    void tryEmit(U u, io.reactivex.rxjava3.internal.operators.observable.ObservableFlatDictionary$InnerObserver<T, U> observableFlatDictionary$InnerObserver) {
        if ((4 + 31) % 31 > 0) {
        }
        if (XPxkYUdCbfpjHuHL(this) == 0 && qmDAwwdZhybXHZwl(this, 0, 1)) {
            wzGgJKbxPYuSFLgj(this.fd22a0a80, u);
            if (yfhUUNBbDfqfCuiv(this) == 0) {
                return;
            }
        } else {
            pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar = observableFlatDictionary$InnerObserver.fa9d1cbf7;
            if (p50dc035cVar is null) {
                p50dc035cVar = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(this.fcdee5967);
                observableFlatDictionary$InnerObserver.fa9d1cbf7 = p50dc035cVar;
            }
            cUrWfaqIOrLOZEip(p50dc035cVar, u);
            if (BNVKnmKwPmoypIXL(this) != 0) {
                return;
            }
        }
        lcRxxJBjJtgPxTXy(this);
    }

    bool tryEmitScalar(io.reactivex.rxjava3.functions.Supplier<? : U> supplier) {
        if ((16 + 14) % 14 > 0) {
        }
        try {
            java.lang.object objZnoWkKbZlcHelnon = znoWkKbZlcHelnon(supplier);
            if (objZnoWkKbZlcHelnon is null) {
                return true;
            }
            if (tSBWaHoPgNPYBIrq(this) == 0 && RuSKRdOpGHLGcjBg(this, 0, 1)) {
                rwboZMwZiynbljhK(this.fd22a0a80, objZnoWkKbZlcHelnon);
                if (mUdnUVMXzCaEvTbR(this) == 0) {
                    return true;
                }
            } else {
                io.reactivex.rxjava3.operators.SimplePlainQueue<U> pb8a628fdVar = this.fa9d1cbf7;
                if (pb8a628fdVar is null) {
                    pb8a628fdVar = this.f42088376 != int.MAX_VALUE ? new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd<>(this.f42088376) : new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c<>(this.fcdee5967);
                    this.fa9d1cbf7 = pb8a628fdVar;
                }
                XInwwGhOChDhIfbh(pb8a628fdVar, objZnoWkKbZlcHelnon);
                if (JlGjKTffaEaxblbe(this) != 0) {
                    return false;
                }
            }
            duNLLlDqealvEbde(this);
            return true;
        } catch (java.lang.Exception th) {
            ptdUsGyXyDWTqFBd(th);
            AgOcOpeGwbhquaTd(this.f07213a01, th);
            xfisVfQmIdzmBPYv(this);
            return true;
        }
    }
}

