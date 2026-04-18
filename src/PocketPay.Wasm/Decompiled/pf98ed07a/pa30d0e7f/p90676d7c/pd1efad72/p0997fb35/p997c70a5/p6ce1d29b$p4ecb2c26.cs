namespace WillowMaze.Wasm.Decompiled;


readonly class p6ce1d29b$p4ecb2c26<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f00ab47e9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 f021dced4;
    readonly io.reactivex.rxjava3.core.Observer f2044c209;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f40a9f346;
    bool f4ac5c4fb;
    bool f6b2ded51;
    readonly io.reactivex.rxjava3.core.Observer f9ece3453;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    bool fcac7a640;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 feba6585a;
    readonly io.reactivex.rxjava3.functions.Predicate<T> ff670ef68;
    readonly io.reactivex.rxjava3.core.Observer fff9d4365;

    p6ce1d29b$p4ecb2c26(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.functions.Predicate<T> predicate) {
        this.fd22a0a80 = observer;
        this.ff670ef68 = predicate;
    }

    public static void AuLKEfzLkncusmRr(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void FkVtjkrBiFeCwSWc(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void KgBCLyWFBQwguaEZ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void OvfcTIDejHVofHrL(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool PZqLobPRRPOSYUtC(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p3b1b1a93 p3b1b1a93Var, java.lang.object obj) {
        return p3b1b1a93Var.test(obj);
    }

    public static void PsiEMZRAGHTjugSe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool QUhIoccjQArvNMLN(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void ZQUzvggWBKJnPJxv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p6ce1d29b$p4ecb2c26 p6ce1d29b_p4ecb2c26, java.lang.Exception th) {
        p6ce1d29b_p4ecb2c26.onError(th);
    }

    public static void FwRsKxfMsUNzISxu(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void JoBoqSJFbvYzkUkY(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void MHHjXaVlBPDbZxTu(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool NsWmouOqqVYjhDNf(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void QFUStOgcYbQXrMuc(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void WyveuphbOMsSBsiD(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public override void Dispose() {
        KgBCLyWFBQwguaEZ(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return QUhIoccjQArvNMLN(this.fbc3b0556);
    }

    public override void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        OvfcTIDejHVofHrL(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            joBoqSJFbvYzkUkY(th);
        } else {
            this.f6b2ded51 = true;
            mHHjXaVlBPDbZxTu(this.fd22a0a80, th);
        }
    }

    public override void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        fwRsKxfMsUNzISxu(this.fd22a0a80, t);
        try {
            if (PZqLobPRRPOSYUtC(this.ff670ef68, t)) {
                this.f6b2ded51 = true;
                wyveuphbOMsSBsiD(this.fbc3b0556);
                qFUStOgcYbQXrMuc(this.fd22a0a80);
            }
        } catch (java.lang.Exception th) {
            AuLKEfzLkncusmRr(th);
            PsiEMZRAGHTjugSe(this.fbc3b0556);
            ZQUzvggWBKJnPJxv(this, th);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (nsWmouOqqVYjhDNf(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            FkVtjkrBiFeCwSWc(this.fd22a0a80, this);
        }
    }
}

