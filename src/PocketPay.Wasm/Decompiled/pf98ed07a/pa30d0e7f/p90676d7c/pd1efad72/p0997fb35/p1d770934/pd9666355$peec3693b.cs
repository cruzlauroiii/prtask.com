namespace WillowMaze.Wasm.Decompiled;


readonly class pd9666355$peec3693b<T, R> : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.Observer<R>, io.reactivex.rxjava3.core.MaybeObserver<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f77ec9996 = -8948264376121066672L;
    private static readonly long f7b9b2a8d = -8948264376121066672L;
    private static readonly long fb55f961f = -8948264376121066672L;
    private static readonly long fc6e1e520 = -8948264376121066672L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f100d397f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f167129f6;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f72bcc5fb;
    readonly io.reactivex.rxjava3.core.Observer f9334caab;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc3f4c29d;
    readonly io.reactivex.rxjava3.core.Observer<R> fd22a0a80;

    pd9666355$peec3693b(io.reactivex.rxjava3.core.Observer<R> observer, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> function) {
        this.fd22a0a80 = observer;
        this.f4b9f83e1 = function;
    }

    public static void CkYMCCWAjCxwZgUX(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void EAEmegttstsQFJuY(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool EGVsclgXqPzbiuvZ(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static bool EMjwGhTFUcCvJkzw(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void EWhquGzbodTzgBTh(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static java.lang.object FvjXThQfTdGGfTgi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pd9666355$peec3693b pd9666355_peec3693b) {
        return pd9666355_peec3693b[);
    }

    public static void MgmuzwAxrpBKhKPk(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void PgzItRlYoWmmKtKn(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static bool XdmOfxnWAEXuKkEF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.pd9666355$peec3693b pd9666355_peec3693b) {
        return pd9666355_peec3693b.isDisposed();
    }

    public static bool DhfmAlruhlNpyGnF(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.Replace(atomicReference, p7beea252Var);
    }

    public static void OpgIhIWQOjjfmjsV(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object RPPZKKihqgThbGCv(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object TVYJIPcZSMjaBBvX(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public override void Dispose() {
        EGVsclgXqPzbiuvZ(this);
    }

    public override bool IsDisposed() {
        return EMjwGhTFUcCvJkzw((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) FvjXThQfTdGGfTgi(this));
    }

    public override void OnComplete() {
        MgmuzwAxrpBKhKPk(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        EAEmegttstsQFJuY(this.fd22a0a80, th);
    }

    public override void OnNext(R r) {
        CkYMCCWAjCxwZgUX(this.fd22a0a80, r);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        dhfmAlruhlNpyGnF(this, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        try {
            io.reactivex.rxjava3.core.ObservableSource observableSource = (io.reactivex.rxjava3.core.ObservableSource) rPPZKKihqgThbGCv(tVYJIPcZSMjaBBvX(this.f4b9f83e1, t), "The mapper returned a null Publisher");
            if (XdmOfxnWAEXuKkEF(this)) {
                return;
            }
            PgzItRlYoWmmKtKn(observableSource, this);
        } catch (java.lang.Exception th) {
            opgIhIWQOjjfmjsV(th);
            EWhquGzbodTzgBTh(this.fd22a0a80, th);
        }
    }
}

