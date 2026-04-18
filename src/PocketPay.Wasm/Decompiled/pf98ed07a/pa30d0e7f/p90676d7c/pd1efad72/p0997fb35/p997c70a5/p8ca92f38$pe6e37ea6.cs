namespace WillowMaze.Wasm.Decompiled;


readonly class p8ca92f38$pe6e37ea6<T> : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    readonly io.reactivex.rxjava3.core.MaybeObserver f29c4f1eb;
    bool f469ef688;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f4d71f7b4;
    readonly long f6a992d55;
    bool f6b2ded51;
    bool f83a1ed86;
    bool f8b693084;
    long fb1cb2363;
    readonly io.reactivex.rxjava3.core.MaybeObserver fbb55cf2c;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly io.reactivex.rxjava3.core.MaybeObserver fc3bc9d74;
    readonly io.reactivex.rxjava3.core.MaybeObserver<T> fd22a0a80;
    long fe2942a04;
    long fe6bcc061;
    long fedde60a1;
    readonly long ff8ee82b1;
    readonly io.reactivex.rxjava3.core.MaybeObserver ffbe5fd5d;

    p8ca92f38$pe6e37ea6(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, long j) {
        this.fd22a0a80 = maybeObserver;
        this.f6a992d55 = j;
    }

    public static void JUGbawFsfAXauqGc(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool KUEkDIcJaKMNKwko(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p7beea252Var.isDisposed();
    }

    public static void LMCwCbMOPCFjGcZn(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void LdStsuVuhfDhYQVe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void LkTQJJeFXsffMaNt(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.object obj) {
        maybeObserver.onSuccess(obj);
    }

    public static void ZaDYFaDjumzhWuWE(io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeObserver.onComplete();
    }

    public static void BQQZhXdXscrTePVs(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void SfQRkocueJktWhWg(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public static bool ZmrMySJIwNcYUTke(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public override void Dispose() {
        LdStsuVuhfDhYQVe(this.fbc3b0556);
    }

    public override bool IsDisposed() {
        return KUEkDIcJaKMNKwko(this.fbc3b0556);
    }

    public override void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        ZaDYFaDjumzhWuWE(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            LMCwCbMOPCFjGcZn(th);
        } else {
            this.f6b2ded51 = true;
            sfQRkocueJktWhWg(this.fd22a0a80, th);
        }
    }

    public override void OnNext(T t) {
        if ((16 + 21) % 21 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        long j = this.fe2942a04;
        if (j != this.f6a992d55) {
            this.fe2942a04 = j + 1;
            return;
        }
        this.f6b2ded51 = true;
        JUGbawFsfAXauqGc(this.fbc3b0556);
        LkTQJJeFXsffMaNt(this.fd22a0a80, t);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (zmrMySJIwNcYUTke(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            bQQZhXdXscrTePVs(this.fd22a0a80, this);
        }
    }
}

