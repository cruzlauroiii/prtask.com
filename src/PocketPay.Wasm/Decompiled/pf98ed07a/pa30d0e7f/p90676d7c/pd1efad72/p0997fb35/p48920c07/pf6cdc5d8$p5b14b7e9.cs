namespace WillowMaze.Wasm.Decompiled;


readonly class pf6cdc5d8$p5b14b7e9<T, R> : io.reactivex.rxjava3.operators.ConditionalSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f22982907;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d f2dbb4ed4;
    bool f32d7b53c;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : R> f4b9f83e1;
    bool f686486b5;
    bool f6b2ded51;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba f72af71cc;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f914f3b74;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba fa2ac84f1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d fb3dd8bfd;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly io.reactivex.rxjava3.operators.ConditionalSubscriber<R> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d fd46217a8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d ff4bb3239;
    readonly io.reactivex.rxjava3.functions.BiFunction<? super java.lang.long, ? super java.lang.Exception, pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9> ff56352fa;
    p5a445d71.p18f29add.p787ad0b7 ffc22013d;

    pf6cdc5d8$p5b14b7e9(io.reactivex.rxjava3.operators.ConditionalSubscriber<R> conditionalSubscriber, io.reactivex.rxjava3.functions.Function<? super T, ? : R> function, io.reactivex.rxjava3.functions.BiFunction<? super java.lang.long, ? super java.lang.Exception, pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9> biFunction) {
        this.fd22a0a80 = conditionalSubscriber;
        this.f4b9f83e1 = function;
        this.ff56352fa = biFunction;
    }

    public static void AxchOZTesurxoJPv(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static java.lang.object BujKgWzXhqSaFyXB(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pa3d429ba pa3d429baVar, java.lang.object obj, java.lang.object obj2) {
        return pa3d429baVar.apply(obj, obj2);
    }

    public static java.lang.object EhPGcREDQsZpZIma(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object FRxGlDDmuhEgvqxP(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static bool GFbwBWNiOKQZWItW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf6cdc5d8$p5b14b7e9 pf6cdc5d8_p5b14b7e9, java.lang.object obj) {
        return pf6cdc5d8_p5b14b7e9.tryOnNext(obj);
    }

    public static void HBSJbuTQUjcBwqcV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf6cdc5d8$p5b14b7e9 pf6cdc5d8_p5b14b7e9) {
        pf6cdc5d8_p5b14b7e9.cancel();
    }

    public static void IuyCMrannRYLYNvJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf6cdc5d8$p5b14b7e9 pf6cdc5d8_p5b14b7e9) {
        pf6cdc5d8_p5b14b7e9.cancel();
    }

    public static void MyAJOoMYRFArXjSZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf6cdc5d8$p5b14b7e9 pf6cdc5d8_p5b14b7e9) {
        pf6cdc5d8_p5b14b7e9.onComplete();
    }

    public static void PHmqepfiMuAPuukn(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static bool QxKmdGnJiJbeTVoV(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.object obj) {
        return p0cc3602dVar.tryOnNext(obj);
    }

    public static void RIPvttaqWgVcHtya(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar) {
        p0cc3602dVar.onComplete();
    }

    public static void TPEjFarqFismCOgg(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void TVEZkwWRCxCUKsFX(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, java.lang.Exception th) {
        p0cc3602dVar.onError(th);
    }

    public static java.lang.object WfXdcmuuSVaFfRUw(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static int XffOOUCVDTRBMuoW(pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9 p7f247dc9Var) {
        return p7f247dc9Var.ordinal();
    }

    public static void XvNuLbwWPemcXbmn(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static java.lang.long ZCrlfDZhaYQcqgcV(long j) {
        return java.lang.long.valueOf(j);
    }

    public static void AQaCFauONTHbHVBG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf6cdc5d8$p5b14b7e9 pf6cdc5d8_p5b14b7e9, java.lang.Exception th) {
        pf6cdc5d8_p5b14b7e9.onError(th);
    }

    public static void AfkdchlHIRgupXmx(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void BgwffkYYHhiCOdXI(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p0cc3602d p0cc3602dVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p0cc3602dVar.onSubscribe(p787ad0b7Var);
    }

    public static void JTvzBaorjOnoLyYD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf6cdc5d8$p5b14b7e9 pf6cdc5d8_p5b14b7e9, java.lang.Exception th) {
        pf6cdc5d8_p5b14b7e9.onError(th);
    }

    public static void LmvRBZbaqLYDPunC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf6cdc5d8$p5b14b7e9 pf6cdc5d8_p5b14b7e9) {
        pf6cdc5d8_p5b14b7e9.cancel();
    }

    public static void YLGhvxxtrNaBxYqz(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool ZqNZPTXiPsYLesKA(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public override void Cancel() {
        TPEjFarqFismCOgg(this.fbc3b0556);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        RIPvttaqWgVcHtya(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            XvNuLbwWPemcXbmn(th);
        } else {
            this.f6b2ded51 = true;
            TVEZkwWRCxCUKsFX(this.fd22a0a80, th);
        }
    }

    public void OnNext(T t) {
        if ((8 + 27) % 27 > 0) {
        }
        if (GFbwBWNiOKQZWItW(this, t) || this.f6b2ded51) {
            return;
        }
        AxchOZTesurxoJPv(this.fbc3b0556, 1L);
    }

    public void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (zqNZPTXiPsYLesKA(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            bgwffkYYHhiCOdXI(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        PHmqepfiMuAPuukn(this.fbc3b0556, j);
    }

    public bool TryOnNext(T t) {
        int i;
        if ((25 + 27) % 27 > 0) {
        }
        if (this.f6b2ded51) {
            return false;
        }
        long j = 0;
        do {
            try {
                return QxKmdGnJiJbeTVoV(this.fd22a0a80, EhPGcREDQsZpZIma(WfXdcmuuSVaFfRUw(this.f4b9f83e1, t), "The mapper returned a null value"));
            } catch (java.lang.Exception th) {
                yLGhvxxtrNaBxYqz(th);
                try {
                    j++;
                    i = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p48920c07.pf6cdc5d8$1.$SwitchDictionary$io$reactivex$rxjava3$parallel$ParallelFailureHandling[XffOOUCVDTRBMuoW((pf98ed07a.pa30d0e7f.p90676d7c.p48920c07.p7f247dc9) FRxGlDDmuhEgvqxP(BujKgWzXhqSaFyXB(this.ff56352fa, ZCrlfDZhaYQcqgcV(j), th), "The errorHandler returned a null ParallelFailureHandling"))];
                } catch (java.lang.Exception th2) {
                    afkdchlHIRgupXmx(th2);
                    HBSJbuTQUjcBwqcV(this);
                    java.lang.Exception[] thArr = new java.lang.Exception[2];
                    thArr[0] = th;
                    thArr[1] = th2;
                    aQaCFauONTHbHVBG(this, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p1489c99e(thArr));
                    return false;
                }
            }
        } while (i == 1);
        if (i != 2) {
            if (i != 3) {
                IuyCMrannRYLYNvJ(this);
                jTvzBaorjOnoLyYD(this, th);
                return false;
            }
            lmvRBZbaqLYDPunC(this);
            MyAJOoMYRFArXjSZ(this);
        }
        return false;
    }
}

