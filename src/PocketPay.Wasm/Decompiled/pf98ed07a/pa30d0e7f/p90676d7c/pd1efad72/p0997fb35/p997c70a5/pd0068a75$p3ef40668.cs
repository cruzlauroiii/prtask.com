namespace WillowMaze.Wasm.Decompiled;


readonly class pd0068a75$p3ef40668<T> : io.reactivex.rxjava3.core.Observer<T> {
    volatile bool f050ef2e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 f19258627;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 f40d720b9;
    readonly io.reactivex.rxjava3.core.Observer f489029e5;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f49e4ff11;
    readonly io.reactivex.rxjava3.core.Observer f53f9a9b0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 f56b11440;
    bool f734a040f;
    volatile bool f7b209056;
    bool f88d4f105;
    bool f94414dd8;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    volatile bool fbe747de2;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 ff7add25e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 ff964379c;
    readonly io.reactivex.rxjava3.core.Observer ffc1924ee;
    readonly io.reactivex.rxjava3.core.Observer ffdede6b9;

    pd0068a75$p3ef40668(io.reactivex.rxjava3.core.Observer<T> observer, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 pe8bf89d0Var) {
        this.fd22a0a80 = observer;
        this.ff964379c = pe8bf89d0Var;
    }

    public static void PXKWucWugyUZJcKc(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static bool RfIwpLTgLJRnefrG(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void WsRUhLuzaOPFprII(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void BVotBQKeChscJgXP(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void FHgvxekkwrspxtID(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 pe8bf89d0Var) {
        pe8bf89d0Var.dispose();
    }

    public static void FNzdUmwaxDIrmEVQ(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static bool JbBUEeXIMNcCqais(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 pe8bf89d0Var, int i, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pe8bf89d0Var.setResource(i, p7beea252Var);
    }

    public static void LrqojPeevQsLWyLY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.pe8bf89d0 pe8bf89d0Var) {
        pe8bf89d0Var.dispose();
    }

    public override void OnComplete() {
        lrqojPeevQsLWyLY(this.ff964379c);
        PXKWucWugyUZJcKc(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        fHgvxekkwrspxtID(this.ff964379c);
        WsRUhLuzaOPFprII(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        if (this.f88d4f105) {
            fNzdUmwaxDIrmEVQ(this.fd22a0a80, t);
        } else if (this.fbe747de2) {
            this.f88d4f105 = true;
            bVotBQKeChscJgXP(this.fd22a0a80, t);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (RfIwpLTgLJRnefrG(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            jbBUEeXIMNcCqais(this.ff964379c, 0, p7beea252Var);
        }
    }
}

