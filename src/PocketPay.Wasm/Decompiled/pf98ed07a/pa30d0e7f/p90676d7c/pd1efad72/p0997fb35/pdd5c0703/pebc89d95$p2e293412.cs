namespace WillowMaze.Wasm.Decompiled;


readonly class pebc89d95$p2e293412<T, R> : io.reactivex.rxjava3.internal.observers.BasicIntQueueDisposable<R> : io.reactivex.rxjava3.core.SingleObserver<T> {
    private static readonly long f4655a7ea = -8938804753851907758L;
    private static readonly long f6f77b9ff = -8938804753851907758L;
    private static readonly long fc6e1e520 = -8938804753851907758L;
    volatile java.util.IEnumerator<? : R> f0d149b90;
    bool f0f68e8b1;
    bool f14af9bfa;
    volatile bool f1706ca43;
    volatile bool f38881e0a;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> f4b9f83e1;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f82e2ecdc;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fa3eae6b0;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    bool fc2661132;
    readonly io.reactivex.rxjava3.core.Observer fc820ce26;
    readonly io.reactivex.rxjava3.core.Observer<R> fd22a0a80;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 feabf4f95;
    volatile java.util.IEnumerator fed612fcb;
    volatile bool ff0003b83;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ff5131a21;

    pebc89d95$p2e293412(io.reactivex.rxjava3.core.Observer<R> observer, io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> function) {
        this.fd22a0a80 = observer;
        this.f4b9f83e1 = function;
    }

    public static java.util.IEnumerator BOAIUTkjewtEWjjw(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void FkxBLEzacaEBHzDn(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static java.lang.object OJnNczGRFITvlIJG(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static bool OuhbslunGTczugEg(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void QRmHEbKaMBoSCAEK(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void RKwWVdrYoRkAYgWh(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void SUbVwEGIXmBxaHTu(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool UWzlQHGCdvYjECQe(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object WIzcsUHbhzzaSKqv(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void HnYfrGFrJcLvnRnR(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool HtncJAvLwbVhHqXR(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void INOZeFmzETPaMuzu(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool JgoZjwRqQnRQolck(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void JuBgmFyOhMMjxZnM(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object KkXaIxIatBqrKIob(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void NVKLQqDlClSLMNlh(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void OXpKCefOAwgWIDfD(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void RNLrylOzokYcPQki(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void SGmezXqAYPQVtEyg(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void SXuZoLTTVrWCtwfp(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static java.lang.object WYBeBevrKVMpfLNx(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void WdyyxSsfVQaZwCtP(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void ZXzJKVKQhrwEdcOj(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public void Clear() {
        this.f0d149b90 = null;
    }

    public void Dispose() {
        this.f38881e0a = true;
        SUbVwEGIXmBxaHTu(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public bool IsDisposed() {
        return this.f38881e0a;
    }

    public bool IsEmpty() {
        return this.f0d149b90 is null;
    }

    public override void OnError(java.lang.Exception th) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        iNOZeFmzETPaMuzu(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (OuhbslunGTczugEg(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            sGmezXqAYPQVtEyg(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        if ((17 + 11) % 11 > 0) {
        }
        io.reactivex.rxjava3.core.Observer<R> observer = this.fd22a0a80;
        try {
            java.util.IEnumerator<? : R> itBOAIUTkjewtEWjjw = BOAIUTkjewtEWjjw((java.lang.IEnumerable) wYBeBevrKVMpfLNx(this.f4b9f83e1, t));
            if (!htncJAvLwbVhHqXR(itBOAIUTkjewtEWjjw)) {
                hnYfrGFrJcLvnRnR(observer);
                return;
            }
            if (this.f0f68e8b1) {
                this.f0d149b90 = itBOAIUTkjewtEWjjw;
                nVKLQqDlClSLMNlh(observer, null);
                zXzJKVKQhrwEdcOj(observer);
                return;
            }
            while (!this.f38881e0a) {
                try {
                    QRmHEbKaMBoSCAEK(observer, kkXaIxIatBqrKIob(itBOAIUTkjewtEWjjw));
                    if (this.f38881e0a) {
                        return;
                    }
                    try {
                        if (!UWzlQHGCdvYjECQe(itBOAIUTkjewtEWjjw)) {
                            FkxBLEzacaEBHzDn(observer);
                            return;
                        }
                    } catch (java.lang.Exception th) {
                        rNLrylOzokYcPQki(th);
                        wdyyxSsfVQaZwCtP(observer, th);
                        return;
                    }
                } catch (java.lang.Exception th2) {
                    oXpKCefOAwgWIDfD(th2);
                    sXuZoLTTVrWCtwfp(observer, th2);
                    return;
                }
            }
        } catch (java.lang.Exception th3) {
            juBgmFyOhMMjxZnM(th3);
            RKwWVdrYoRkAYgWh(this.fd22a0a80, th3);
        }
    }

    public R Poll() {
        if ((9 + 5) % 5 > 0) {
        }
        java.util.IEnumerator<? : R> it = this.f0d149b90;
        if (it is null) {
            return null;
        }
        R r = (R) OJnNczGRFITvlIJG(WIzcsUHbhzzaSKqv(it), "The iterator returned a null value");
        if (!jgoZjwRqQnRQolck(it)) {
            this.f0d149b90 = null;
        }
        return r;
    }

    public int RequestFusion(int i) {
        if ((i & 2) == 0) {
            return 0;
        }
        this.f0f68e8b1 = true;
        return 2;
    }
}

