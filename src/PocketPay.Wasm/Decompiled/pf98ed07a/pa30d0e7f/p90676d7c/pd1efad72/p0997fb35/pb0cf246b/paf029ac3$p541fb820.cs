namespace WillowMaze.Wasm.Decompiled;


readonly class paf029ac3$p541fb820<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    java.lang.object f08d2c620;
    readonly T f16830a58;
    p5a445d71.p18f29add.p787ad0b7 f1f5bab1a;
    T f2063c160;
    bool f4ac658ec;
    java.lang.object f56728d5a;
    bool f677ce0de;
    bool f6b2ded51;
    bool f94556836;
    readonly io.reactivex.rxjava3.core.SingleObserver f9fd792bc;
    p5a445d71.p18f29add.p787ad0b7 fa535aa4c;
    bool fb5bccf56;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly java.lang.object fbf547143;
    p5a445d71.p18f29add.p787ad0b7 fc19c94fd;
    readonly io.reactivex.rxjava3.core.SingleObserver<T> fd22a0a80;
    java.lang.object fd66a741a;
    readonly java.lang.object ffffa8f81;

    paf029ac3$p541fb820(io.reactivex.rxjava3.core.SingleObserver<T> singleObserver, T t) {
        this.fd22a0a80 = singleObserver;
        this.f16830a58 = t;
    }

    public static void ElttaFlFBabazOPm(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.object obj) {
        singleObserver.onSuccess(obj);
    }

    public static void HjBGUoKdpPOBzRIe(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static bool JGvWYXeUOZEFVmUn(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void KPdPpFYbQnUOusoi(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void QMnipIIEoTdUwoME(io.reactivex.rxjava3.core.SingleObserver singleObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        singleObserver.onSubscribe(p7beea252Var);
    }

    public static void AAOaqGplBWqmirwj(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void CDZiePuUJPodCRbh(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void HRxMxgCyJTCKyThe(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void MbKJIlNHNMYGDMzm(io.reactivex.rxjava3.core.SingleObserver singleObserver, java.lang.Exception th) {
        singleObserver.onError(th);
    }

    public static void UMjnALoatokgssPW(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public override void Dispose() {
        uMjnALoatokgssPW(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public override bool IsDisposed() {
        return this.fbc3b0556 == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
    }

    public void OnComplete() {
        if ((19 + 16) % 16 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        T t = this.f2063c160;
        this.f2063c160 = null;
        if (t is null) {
            t = this.f16830a58;
        }
        if (t is null) {
            hRxMxgCyJTCKyThe(this.fd22a0a80, new java.util.NoSuchElementException());
        } else {
            ElttaFlFBabazOPm(this.fd22a0a80, t);
        }
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            cDZiePuUJPodCRbh(th);
            return;
        }
        this.f6b2ded51 = true;
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        mbKJIlNHNMYGDMzm(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        if (this.f2063c160 is null) {
            this.f2063c160 = t;
            return;
        }
        this.f6b2ded51 = true;
        KPdPpFYbQnUOusoi(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        HjBGUoKdpPOBzRIe(this.fd22a0a80, new java.lang.IllegalArgumentException("Sequence contains more than one element!"));
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((20 + 29) % 29 > 0) {
        }
        if (JGvWYXeUOZEFVmUn(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            QMnipIIEoTdUwoME(this.fd22a0a80, this);
            aAOaqGplBWqmirwj(p787ad0b7Var, long.MAX_VALUE);
        }
    }
}

