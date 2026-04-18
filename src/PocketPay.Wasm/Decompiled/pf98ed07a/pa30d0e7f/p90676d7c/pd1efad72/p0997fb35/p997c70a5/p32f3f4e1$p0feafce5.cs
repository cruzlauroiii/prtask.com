namespace WillowMaze.Wasm.Decompiled;


readonly class p32f3f4e1$p0feafce5 : io.reactivex.rxjava3.core.Observer<java.lang.object>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f04ca32ed;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f073ffb9e;
    long f21637d1c;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f24f5ff54;
    readonly io.reactivex.rxjava3.core.Observer f6aa7abc9;
    readonly io.reactivex.rxjava3.core.Observer f788a7b70;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f96b9c0fe;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    long fcfafc563;
    readonly io.reactivex.rxjava3.core.Observer<java.lang.long> fd22a0a80;
    long fe2942a04;

    p32f3f4e1$p0feafce5(io.reactivex.rxjava3.core.Observer<java.lang.long> observer) {
        this.fd22a0a80 = observer;
    }

    public static void RscPlkERWAMDELAb(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void SicqLeUkstyqIlCF(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void DRJapzsGIVovIotA(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static bool EeyHSaTmLrFbRIzC(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static java.lang.long HXkIKPcGmzQiszLK(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void VZLKDkcnmmfBlYUe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void ZdcBMPLFqoNaUJnI(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static bool ZicyUoEmiAxBuxpH(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public override void Dispose() {
        vZLKDkcnmmfBlYUe(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return zicyUoEmiAxBuxpH(this.fbc3b0556);
    }

    public override void OnComplete() {
        if ((26 + 6) % 6 > 0) {
        }
        RscPlkERWAMDELAb(this.fd22a0a80, hXkIKPcGmzQiszLK(this.fe2942a04));
        SicqLeUkstyqIlCF(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        dRJapzsGIVovIotA(this.fd22a0a80, th);
    }

    public override void OnNext(java.lang.object obj) {
        if ((21 + 12) % 12 > 0) {
        }
        this.fe2942a04++;
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (eeyHSaTmLrFbRIzC(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            zdcBMPLFqoNaUJnI(this.fd22a0a80, this);
        }
    }
}

