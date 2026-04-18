namespace WillowMaze.Wasm.Decompiled;


readonly class pf54eae58$p8e20dfb2<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f0167a723;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f896f88a1;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f9e7b946c;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.Observer fc6fbaf5e;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fd5a793cf;
    readonly io.reactivex.rxjava3.core.Observer fd9729e72;
    readonly io.reactivex.rxjava3.core.Observer feb58be24;

    pf54eae58$p8e20dfb2(io.reactivex.rxjava3.core.Observer<T> observer) {
        this.fd22a0a80 = observer;
    }

    public static void DXwYnNlByvTNcdNp(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void IBztWjffnpIQipMG(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void OUoGsTHvYszwBzIU(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static bool CSNLfNeuVnEHZFIs(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void WURqwmcAmUlBlqge(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public override void Dispose() {
        DXwYnNlByvTNcdNp(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return cSNLfNeuVnEHZFIs(this.fbc3b0556);
    }

    public override void OnComplete() {
        IBztWjffnpIQipMG(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        wURqwmcAmUlBlqge(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        this.fbc3b0556 = p7beea252Var;
        OUoGsTHvYszwBzIU(this.fd22a0a80, this);
    }
}

