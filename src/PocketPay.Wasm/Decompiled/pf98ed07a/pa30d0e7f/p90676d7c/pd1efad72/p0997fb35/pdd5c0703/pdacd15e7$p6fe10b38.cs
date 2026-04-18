namespace WillowMaze.Wasm.Decompiled;


readonly class pdacd15e7$p6fe10b38<T> : io.reactivex.rxjava3.core.SingleObserver<T> {
    readonly java.util.concurrent.atomic.Atomicbool f264b6c6f;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f55e6824f;
    readonly java.util.concurrent.atomic.Atomicbool f978f6f60;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 faa3f4ce3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd fb1b56e9f;
    readonly java.util.concurrent.atomic.Atomicbool fb75f52a0;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly java.util.concurrent.atomic.Atomicbool fc5972218;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd fcdaeeeba;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.SingleObserver fda448ea5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd fe6557a56;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd ffb473643;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 ffd408ed8;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fff867cad;

    pdacd15e7$p6fe10b38(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, java.util.concurrent.atomic.Atomicbool atomicbool) {
        this.fd22a0a80 = singleObserver;
        this.fcdaeeeba = p5537e2ddVar;
        this.f978f6f60 = atomicbool;
    }

    public static bool EVjUOMVKBdvPoIsF(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static void FQjYazcMmZoomSYZ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void FhlWNtrjjWfGeRBa(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool GQnjiEjZWLDqPRqe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.delete(p7beea252Var);
    }

    public static bool HZdFirxzVYNFfocF(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.delete(p7beea252Var);
    }

    public static void MphEeCrItrtCdOtZ(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void GfBELgTqDgzoeArg(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static bool GkDBTJIiNFFtmoYi(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static void RWlaTpdRjZGCIvxb(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static bool UXVjCrSKLHMHrLeW(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public override void OnError(java.lang.Exception th) {
        if ((17 + 25) % 25 > 0) {
        }
        if (!uXVjCrSKLHMHrLeW(this.f978f6f60, false, true)) {
            FhlWNtrjjWfGeRBa(th);
            return;
        }
        GQnjiEjZWLDqPRqe(this.fcdaeeeba, this.fbc3b0556);
        gfBELgTqDgzoeArg(this.fcdaeeeba);
        rWlaTpdRjZGCIvxb(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        this.fbc3b0556 = p7beea252Var;
        gkDBTJIiNFFtmoYi(this.fcdaeeeba, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        if ((2 + 8) % 8 > 0) {
        }
        if (EVjUOMVKBdvPoIsF(this.f978f6f60, false, true)) {
            HZdFirxzVYNFfocF(this.fcdaeeeba, this.fbc3b0556);
            FQjYazcMmZoomSYZ(this.fcdaeeeba);
            MphEeCrItrtCdOtZ(this.fd22a0a80, t);
        }
    }
}

