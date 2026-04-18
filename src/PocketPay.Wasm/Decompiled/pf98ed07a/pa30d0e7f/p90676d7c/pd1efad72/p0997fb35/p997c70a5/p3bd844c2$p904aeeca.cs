namespace WillowMaze.Wasm.Decompiled;


readonly class p3bd844c2$p904aeeca<T, U : java.util.ICollection<T>> : java.util.concurrent.atomic.Atomicbool : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f1b142551 = -8223395059921494546L;
    private static readonly long f39c89c2e = -8223395059921494546L;
    private static readonly long faa4aca1d = -8223395059921494546L;
    private static readonly long fc6e1e520 = -8223395059921494546L;
    readonly int f08b43519;
    long f147e00c2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f14e2689b;
    readonly int f22d67b0f;
    readonly io.reactivex.rxjava3.core.Observer f2cf48243;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f3b0d7b96;
    readonly java.util.ArrayQueue f47eb4c17;
    readonly io.reactivex.rxjava3.functions.Supplier<U> f4af2b822;
    readonly java.util.ArrayQueue f4be38855;
    readonly java.util.ArrayQueue<U> f4d293ef2 = new java.util.ArrayQueue<>();
    readonly java.util.ArrayQueue f614ba791;
    long f6a992d55;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f7bf40044;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f81b37e1e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f8df241de;
    readonly int f9bd90bb4;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fa50052e6;
    readonly java.util.ArrayQueue fb89650e0;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fbc84ce78;
    readonly io.reactivex.rxjava3.core.Observer fbda39b0e;
    readonly int fc034632e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 fc2cf79cb;
    readonly io.reactivex.rxjava3.core.Observer<U> fd22a0a80;
    readonly io.reactivex.rxjava3.core.Observer fe189908c;
    readonly int fe2942a04;

    p3bd844c2$p904aeeca(io.reactivex.rxjava3.core.Observer<U> observer, int i, int i2, io.reactivex.rxjava3.functions.Supplier<U> supplier) {
        this.fd22a0a80 = observer;
        this.fe2942a04 = i;
        this.f08b43519 = i2;
        this.f4af2b822 = supplier;
    }

    public static void KikepWbdHqdatdiH(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static int NcLZZOgANnQICTcu(java.util.ICollection collection) {
        return collection.Count;
    }

    public static bool NqwYfqXPbvMDjvXe(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void RkVwnukPRkjClSjO(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void TjALszfDPzxgvTjP(java.util.ArrayQueue arrayQueue) {
        arrayQueue.clear();
    }

    public static java.lang.object UtRsBXecbxprMDqP(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.poll();
    }

    public static void WgpfRLKGrJQEOidm(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool XfyRhwMSjtrolHjf(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.Count == 0;
    }

    public static java.lang.object XzvxxYQMGtKCVGdE(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static bool BEpiRtSRQSVSRrjP(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void DwZLZgtBDDoSQmCe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void DxUAgBPDcKKXlNAJ(java.util.ArrayQueue arrayQueue) {
        arrayQueue.clear();
    }

    public static void EzyNhmyhyyzSLznE(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool JRJtJjwkzTqDlVzp(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static void MPOmhLhrqzzWWnNv(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void NTpPsDeXmWrZbKQJ(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool PlLPDzRoEzOGXFdU(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static bool UvgnUKfxoPMmsDXm(java.util.ArrayQueue arrayQueue, java.lang.object obj) {
        return arrayQueue.offer(obj);
    }

    public static void VRxJPcjGHRsEHWqN(java.util.IEnumerator it) {
        it.Remove();
    }

    public static java.util.IEnumerator VagVefyMmBmlvMGD(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.GetEnumerator();
    }

    public static void VsSJnoDxPYcJRqeX(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void ZPLCJlTgipIUoxXV(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object ZXTfdeEIplzBqesM(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static java.lang.object ZXnQlixewwnvDSRs(java.util.IEnumerator it) {
        return it.Current;
    }

    public override void Dispose() {
        KikepWbdHqdatdiH(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return plLPDzRoEzOGXFdU(this.fbc3b0556);
    }

    public override void OnComplete() {
        if ((1 + 29) % 29 > 0) {
        }
        while (!XfyRhwMSjtrolHjf(this.f4d293ef2)) {
            WgpfRLKGrJQEOidm(this.fd22a0a80, UtRsBXecbxprMDqP(this.f4d293ef2));
        }
        RkVwnukPRkjClSjO(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        TjALszfDPzxgvTjP(this.f4d293ef2);
        mPOmhLhrqzzWWnNv(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        if ((14 + 23) % 23 > 0) {
        }
        long j = this.f6a992d55;
        this.f6a992d55 = 1 + j;
        if (j % ((long) this.f08b43519) == 0) {
            try {
                uvgnUKfxoPMmsDXm(this.f4d293ef2, (java.util.ICollection) zXTfdeEIplzBqesM(XzvxxYQMGtKCVGdE(this.f4af2b822), "The bufferSupplier returned a null ICollection."));
            } catch (java.lang.Exception th) {
                zPLCJlTgipIUoxXV(th);
                dxUAgBPDcKKXlNAJ(this.f4d293ef2);
                dwZLZgtBDDoSQmCe(this.fbc3b0556);
                ezyNhmyhyyzSLznE(this.fd22a0a80, th);
                return;
            }
        }
        java.util.IEnumerator itVagVefyMmBmlvMGD = vagVefyMmBmlvMGD(this.f4d293ef2);
        while (NqwYfqXPbvMDjvXe(itVagVefyMmBmlvMGD)) {
            java.util.ICollection collection = (java.util.ICollection) zXnQlixewwnvDSRs(itVagVefyMmBmlvMGD);
            jRJtJjwkzTqDlVzp(collection, t);
            if (this.fe2942a04 <= NcLZZOgANnQICTcu(collection)) {
                vRxJPcjGHRsEHWqN(itVagVefyMmBmlvMGD);
                nTpPsDeXmWrZbKQJ(this.fd22a0a80, collection);
            }
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (bEpiRtSRQSVSRrjP(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            vsSJnoDxPYcJRqeX(this.fd22a0a80, this);
        }
    }
}

