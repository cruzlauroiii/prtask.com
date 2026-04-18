namespace WillowMaze.Wasm.Decompiled;


readonly class p1500091d$pcfdeef2e<T, U, V> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    readonly p5a445d71.p18f29add.p992c4a5b f08f51ca6;
    readonly java.util.IEnumerator f0c2f2c44;
    bool f0c46c000;
    p5a445d71.p18f29add.p787ad0b7 f2600e93a;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : V> f3298b476;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f3875297d;
    p5a445d71.p18f29add.p787ad0b7 f3b3fddf2;
    readonly java.util.IEnumerator<U> f420cec00;
    bool f69f1970f;
    bool f6b2ded51;
    bool f8b5447e0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f996122dc;
    p5a445d71.p18f29add.p787ad0b7 fbb1272a1;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fc57a8b90;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fc73ae804;
    p5a445d71.p18f29add.p787ad0b7 fd126acd4;
    readonly org.reactivestreams.Subscriber<V> fd22a0a80;

    p1500091d$pcfdeef2e(org.reactivestreams.Subscriber<V> subscriber, java.util.IEnumerator<U> it, io.reactivex.rxjava3.functions.BiFunction<? super T, ? super U, ? : V> biFunction) {
        this.fd22a0a80 = subscriber;
        this.f420cec00 = it;
        this.f3298b476 = biFunction;
    }

    public static void AOsjZIVxACsNpggc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1500091d$pcfdeef2e p1500091d_pcfdeef2e, java.lang.Exception th) {
        p1500091d_pcfdeef2e.fail(th);
    }

    public static void EGmnKIbTlCCJocBV(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void FZPlkHHLNwjyjrzX(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void GtpGRCDXzAjCDMmi(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool IIQRgAGVSqtdjKWT(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object JbxtYvCjqUvhvxUu(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void NFLsmKIrpmTgtcyR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1500091d$pcfdeef2e p1500091d_pcfdeef2e, java.lang.Exception th) {
        p1500091d_pcfdeef2e.fail(th);
    }

    public static java.lang.object QTEbqCIrVVNMkUOS(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void RYTcxxnhtRtJwJmE(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void SfiIbyWnGhRwdpuN(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void UHGTmaIHwelCHQpH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p1500091d$pcfdeef2e p1500091d_pcfdeef2e, java.lang.Exception th) {
        p1500091d_pcfdeef2e.fail(th);
    }

    public static void BOglgfzrHYovZQBU(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void BtusNIvutSZfVVXA(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void CBwCTFDbaJAIrjuC(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static java.lang.object IfFduZJeNWqTbzPm(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static void MJrOWFRyWBpkCFYJ(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void ORBidwtkArgxptrp(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static bool SXQdVOxYzeYnQUZi(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void UAJPWsPlgenEDDIk(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static java.lang.object YtUcMFGujJtANsEK(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void ZGivglJVLMttyKGS(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public override void Cancel() {
        GtpGRCDXzAjCDMmi(this.fbc3b0556);
    }

    void fail(java.lang.Exception th) {
        mJrOWFRyWBpkCFYJ(th);
        this.f6b2ded51 = true;
        cBwCTFDbaJAIrjuC(this.fbc3b0556);
        FZPlkHHLNwjyjrzX(this.fd22a0a80, th);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        EGmnKIbTlCCJocBV(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            SfiIbyWnGhRwdpuN(th);
        } else {
            this.f6b2ded51 = true;
            bOglgfzrHYovZQBU(this.fd22a0a80, th);
        }
    }

    public void OnNext(T t) {
        if ((12 + 22) % 22 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        try {
            try {
                btusNIvutSZfVVXA(this.fd22a0a80, QTEbqCIrVVNMkUOS(ifFduZJeNWqTbzPm(this.f3298b476, t, ytUcMFGujJtANsEK(JbxtYvCjqUvhvxUu(this.f420cec00), "The iterator returned a null value")), "The zipper function returned a null value"));
                try {
                    if (IIQRgAGVSqtdjKWT(this.f420cec00)) {
                        return;
                    }
                    this.f6b2ded51 = true;
                    RYTcxxnhtRtJwJmE(this.fbc3b0556);
                    zGivglJVLMttyKGS(this.fd22a0a80);
                } catch (java.lang.Exception th) {
                    UHGTmaIHwelCHQpH(this, th);
                }
            } catch (java.lang.Exception th2) {
                NFLsmKIrpmTgtcyR(this, th2);
            }
        } catch (java.lang.Exception th3) {
            AOsjZIVxACsNpggc(this, th3);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (sXQdVOxYzeYnQUZi(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            oRBidwtkArgxptrp(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        uAJPWsPlgenEDDIk(this.fbc3b0556, j);
    }
}

