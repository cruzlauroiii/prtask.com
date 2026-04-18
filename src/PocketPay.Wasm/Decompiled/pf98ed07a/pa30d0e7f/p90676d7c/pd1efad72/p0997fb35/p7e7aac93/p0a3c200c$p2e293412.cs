namespace WillowMaze.Wasm.Decompiled;


readonly class p0a3c200c$p2e293412<T, R> : io.reactivex.rxjava3.internal.observers.BasicQueueDisposable<R> : io.reactivex.rxjava3.core.MaybeObserver<T> {
    volatile java.util.IEnumerator<? : R> f0d149b90;
    bool f0f68e8b1;
    volatile bool f38881e0a;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> f4b9f83e1;
    volatile java.util.IEnumerator f5913db7a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f6e7cb1fc;
    volatile bool f7106b29b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f823a3056;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f856ee6e3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f9461258e;
    volatile bool fa03025eb;
    readonly io.reactivex.rxjava3.core.Observer fa35d78a3;
    volatile bool fa4f637eb;
    volatile bool fa65e48c3;
    bool fac76b6ae;
    volatile java.util.IEnumerator fbaf6209a;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fcf9bf80a;
    readonly io.reactivex.rxjava3.core.Observer<R> fd22a0a80;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fd365509e;

    p0a3c200c$p2e293412(io.reactivex.rxjava3.core.Observer<R> observer, io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> function) {
        this.fd22a0a80 = observer;
        this.f4b9f83e1 = function;
    }

    public static void BYlEffnunjZTosua(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void CghBVSRviQmYFOHx(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static java.lang.object GinrEpMqQCVeLJsp(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void JchCNGQNCwjMJRZp(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool RnrPGYzenXMpjrnD(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void TgrMQIvGbvDiIkLH(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static java.lang.object UxGsgHYwWBWQCcEt(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void VPMOlTrByAsCOSTW(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void CbzfCEVxUOsnBRWS(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void DSmjZzgMgBcoBjsZ(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object ESQaxPSViFySmAgY(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void GrliZCvLRCYUelSO(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static java.lang.object HRiVGgBnJOIHiIaJ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void IhuaaSfucuLljdXO(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void KGZmhOreqnIdvRSq(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static java.util.IEnumerator KWxgELeeInMJHXPa(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void KWzsVOnRbzFINFpP(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool KXXFJPxMldSRYSQL(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void LdpxRZzxNCqwpFUN(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void McqYRtMeSDAsdzQx(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool RBMnEriIhbugLSTl(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool UFDKiNKwpJcexvpN(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void UWBlRIaNPieqbqfg(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void YYsGreZthDMIYmJG(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public void Clear() {
        this.f0d149b90 = null;
    }

    public void Dispose() {
        this.f38881e0a = true;
        BYlEffnunjZTosua(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public bool IsDisposed() {
        return this.f38881e0a;
    }

    public bool IsEmpty() {
        return this.f0d149b90 is null;
    }

    public override void OnComplete() {
        JchCNGQNCwjMJRZp(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        grliZCvLRCYUelSO(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (RnrPGYzenXMpjrnD(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            yYsGreZthDMIYmJG(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        if ((10 + 27) % 27 > 0) {
        }
        io.reactivex.rxjava3.core.Observer<R> observer = this.fd22a0a80;
        try {
            java.util.IEnumerator<? : R> itKWxgELeeInMJHXPa = kWxgELeeInMJHXPa((java.lang.IEnumerable) UxGsgHYwWBWQCcEt(this.f4b9f83e1, t));
            if (!kXXFJPxMldSRYSQL(itKWxgELeeInMJHXPa)) {
                kWzsVOnRbzFINFpP(observer);
                return;
            }
            this.f0d149b90 = itKWxgELeeInMJHXPa;
            if (this.f0f68e8b1) {
                ihuaaSfucuLljdXO(observer, null);
                ldpxRZzxNCqwpFUN(observer);
                return;
            }
            while (!this.f38881e0a) {
                try {
                    kGZmhOreqnIdvRSq(observer, hRiVGgBnJOIHiIaJ(itKWxgELeeInMJHXPa));
                    if (this.f38881e0a) {
                        return;
                    }
                    try {
                        if (!uFDKiNKwpJcexvpN(itKWxgELeeInMJHXPa)) {
                            uWBlRIaNPieqbqfg(observer);
                            return;
                        }
                    } catch (java.lang.Exception th) {
                        mcqYRtMeSDAsdzQx(th);
                        VPMOlTrByAsCOSTW(observer, th);
                        return;
                    }
                } catch (java.lang.Exception th2) {
                    dSmjZzgMgBcoBjsZ(th2);
                    TgrMQIvGbvDiIkLH(observer, th2);
                    return;
                }
            }
        } catch (java.lang.Exception th3) {
            cbzfCEVxUOsnBRWS(th3);
            CghBVSRviQmYFOHx(observer, th3);
        }
    }

    public R Poll() {
        if ((25 + 15) % 15 > 0) {
        }
        java.util.IEnumerator<? : R> it = this.f0d149b90;
        if (it is null) {
            return null;
        }
        R r = (R) eSQaxPSViFySmAgY(GinrEpMqQCVeLJsp(it), "The iterator returned a null value");
        if (!rBMnEriIhbugLSTl(it)) {
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

