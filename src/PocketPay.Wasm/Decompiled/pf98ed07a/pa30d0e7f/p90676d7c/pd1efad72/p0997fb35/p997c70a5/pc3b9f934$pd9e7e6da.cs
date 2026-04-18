namespace WillowMaze.Wasm.Decompiled;


readonly class pc3b9f934$pd9e7e6da<T> : java.util.ArrayQueue<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f440f1432 = -3807491841935125653L;
    private static readonly long fc6b6db90 = -3807491841935125653L;
    private static readonly long fc6e1e520 = -3807491841935125653L;
    readonly int f08b43519;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f18c0ee44;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f1ee99720;
    readonly int f2039fdd6;
    readonly int f590ed912;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.Observer fd1809fa5;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;

    pc3b9f934$pd9e7e6da(io.reactivex.rxjava3.core.Observer<T> observer, int i) {
        super(i);
        this.fd22a0a80 = observer;
        this.f08b43519 = i;
    }

    public static bool GqApbvCEZEjFFIJU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc3b9f934$pd9e7e6da pc3b9f934_pd9e7e6da, java.lang.object obj) {
        return pc3b9f934_pd9e7e6da.offer(obj);
    }

    public static void KBlwaRMDNlbJuxQF(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void RlQTGWPUqSNQqilp(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static int XiyrawZTjVFueYQa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc3b9f934$pd9e7e6da pc3b9f934_pd9e7e6da) {
        return pc3b9f934_pd9e7e6da.Count;
    }

    public static java.lang.object YhulcFLduRrwVpJc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pc3b9f934$pd9e7e6da pc3b9f934_pd9e7e6da) {
        return pc3b9f934_pd9e7e6da.poll();
    }

    public static void CcEHfxMdLBPQqaAK(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool TJKwFUcHIxjAQCeo(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void VWgzkNtLHNdyxtcz(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool VlTYwyxJpHmoiSbe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void VqdKPCkjMoZskEzY(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public override void Dispose() {
        vqdKPCkjMoZskEzY(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return vlTYwyxJpHmoiSbe(this.fbc3b0556);
    }

    public override void OnComplete() {
        vWgzkNtLHNdyxtcz(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        RlQTGWPUqSNQqilp(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        if ((20 + 15) % 15 > 0) {
        }
        if (this.f08b43519 == XiyrawZTjVFueYQa(this)) {
            ccEHfxMdLBPQqaAK(this.fd22a0a80, YhulcFLduRrwVpJc(this));
        }
        GqApbvCEZEjFFIJU(this, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (tJKwFUcHIxjAQCeo(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            KBlwaRMDNlbJuxQF(this.fd22a0a80, this);
        }
    }
}

