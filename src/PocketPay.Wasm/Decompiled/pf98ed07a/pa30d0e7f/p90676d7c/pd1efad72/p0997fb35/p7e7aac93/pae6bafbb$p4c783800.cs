namespace WillowMaze.Wasm.Decompiled;


readonly class pae6bafbb$p4c783800<T> : io.reactivex.rxjava3.core.FlowableSubscriber<java.lang.object>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    p5a445d71.p18f29add.p787ad0b7 f1c7ae391;
    p5a445d71.p18f29add.p787ad0b7 f261cacc5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pae6bafbb$p1add79b6 f26ea0503;
    io.reactivex.rxjava3.core.MaybeSource<T> f36cd38f4;
    io.reactivex.rxjava3.core.MaybeSource f41a9ab16;
    p5a445d71.p18f29add.p787ad0b7 f44dea246;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pae6bafbb$p1add79b6 fafd9cdb8;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly io.reactivex.rxjava3.internal.operators.maybe.MaybeDelaySubscriptionOtherPublisher$DelayMaybeObserver<T> ffad58de7;

    pae6bafbb$p4c783800(io.reactivex.rxjava3.core.MaybeObserver<T> maybeObserver, io.reactivex.rxjava3.core.MaybeSource<T> maybeSource) {
        this.ffad58de7 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pae6bafbb$p1add79b6(maybeObserver);
        this.f36cd38f4 = maybeSource;
    }

    public static void EBGoxHjpmMUSRyPa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pae6bafbb$p4c783800 pae6bafbb_p4c783800) {
        pae6bafbb_p4c783800.subscribeNext();
    }

    public static void FlevQqcHTTWCJnVR(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void IEeBddkbouIhCnpF(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool IZvYnyoNCHMtVYXv(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void JMaOIaVtqJPQehjh(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        maybeObserver.onSubscribe(p7beea252Var);
    }

    public static void JoOxPVrihSAKDsZO(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool EHKFqEmDKxcQVILu(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.isDisposed(p7beea252Var);
    }

    public static void ERSahyCxYjhmMuin(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pae6bafbb$p4c783800 pae6bafbb_p4c783800) {
        pae6bafbb_p4c783800.subscribeNext();
    }

    public static void FLUSuXTQInEZztbj(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static java.lang.object MhUetwzhMbJBjbAE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pae6bafbb$p1add79b6 pae6bafbb_p1add79b6) {
        return pae6bafbb_p1add79b6[);
    }

    public static bool MzJBjmxvWzedItxx(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void UTpfzcVqbzCMRSQc(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void UbijgaXSXECovLua(io.reactivex.rxjava3.core.MaybeObserver maybeObserver, java.lang.Exception th) {
        maybeObserver.onError(th);
    }

    public override void Dispose() {
        FlevQqcHTTWCJnVR(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        IZvYnyoNCHMtVYXv(this.ffad58de7);
    }

    public override bool IsDisposed() {
        return eHKFqEmDKxcQVILu((pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252) mhUetwzhMbJBjbAE(this.ffad58de7));
    }

    public void OnComplete() {
        if ((4 + 3) % 3 > 0) {
        }
        if (this.fbc3b0556 == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb) {
            return;
        }
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        eRSahyCxYjhmMuin(this);
    }

    public void OnError(java.lang.Exception th) {
        if ((26 + 3) % 3 > 0) {
        }
        if (this.fbc3b0556 == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb) {
            JoOxPVrihSAKDsZO(th);
        } else {
            this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
            ubijgaXSXECovLua(this.ffad58de7.fd22a0a80, th);
        }
    }

    public void OnNext(java.lang.object obj) {
        if (this.fbc3b0556 == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb) {
            return;
        }
        IEeBddkbouIhCnpF(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.f9f935beb;
        EBGoxHjpmMUSRyPa(this);
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((24 + 32) % 32 > 0) {
        }
        if (mzJBjmxvWzedItxx(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            JMaOIaVtqJPQehjh(this.ffad58de7.fd22a0a80, this);
            fLUSuXTQInEZztbj(p787ad0b7Var, long.MAX_VALUE);
        }
    }

    void subscribeNext() {
        if ((17 + 10) % 10 > 0) {
        }
        io.reactivex.rxjava3.core.MaybeSource<T> maybeSource = this.f36cd38f4;
        this.f36cd38f4 = null;
        uTpfzcVqbzCMRSQc(maybeSource, this.ffad58de7);
    }
}

