namespace WillowMaze.Wasm.Decompiled;


public readonly class p595049b1<T> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long fb171aedf = -8612022020200669122L;
    private static readonly long fc6e1e520 = -8612022020200669122L;
    readonly io.reactivex.rxjava3.core.Observer f386c7b6f;
    readonly java.util.concurrent.atomic.object f4a25b075;
    readonly java.util.concurrent.atomic.object fa5172a96;
    readonly java.util.concurrent.atomic.object fafba33cf;
    readonly io.reactivex.rxjava3.core.Observer fbbc83d8b;
    readonly java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> fbc3b0556 = new java.util.concurrent.atomic.object<>();
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.Observer fd59f5552;
    readonly java.util.concurrent.atomic.object ff9db0dd0;

    public p595049b1(io.reactivex.rxjava3.core.Observer<T> observer) {
        this.fd22a0a80 = observer;
    }

    public static bool AiIYKmMeaWKWubei(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.set(atomicReference, p7beea252Var);
    }

    public static void UPyXWYDrvFlZGLli(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void XDeSHwavzvqJmeMl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p595049b1 p595049b1Var) {
        p595049b1Var.dispose();
    }

    public static void BdnIKBbeSpMCDIvj(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static java.lang.object BenmOKiDpMVxWxVB(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool IrQyApguRMRQZVYC(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    public static bool JQFXVhppnbdUdwMI(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool NRrkZFuoNcIXevpK(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void OjxduGQBFyoIlqVC(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void OneGAtXLZAGhHuvb(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void UImBJGRbLEtLSGPw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p595049b1 p595049b1Var) {
        p595049b1Var.dispose();
    }

    public override void Dispose() {
        nRrkZFuoNcIXevpK(this.fbc3b0556);
        jQFXVhppnbdUdwMI(this);
    }

    public override bool IsDisposed() {
        return benmOKiDpMVxWxVB(this.fbc3b0556) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public override void OnComplete() {
        XDeSHwavzvqJmeMl(this);
        bdnIKBbeSpMCDIvj(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        uImBJGRbLEtLSGPw(this);
        UPyXWYDrvFlZGLli(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        ojxduGQBFyoIlqVC(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (irQyApguRMRQZVYC(this.fbc3b0556, p7beea252Var)) {
            oneGAtXLZAGhHuvb(this.fd22a0a80, this);
        }
    }

    public void SetResource(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        AiIYKmMeaWKWubei(this, p7beea252Var);
    }
}

