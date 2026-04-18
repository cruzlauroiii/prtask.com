namespace WillowMaze.Wasm.Decompiled;


readonly class p015cb7b3$p2e293412<T, R> : io.reactivex.rxjava3.internal.subscriptions.BasicIntQueueSubscription<R> : io.reactivex.rxjava3.core.MaybeObserver<T> {
    private static readonly long f5e0d2e75 = -8938804753851907758L;
    private static readonly long fc6e1e520 = -8938804753851907758L;
    volatile java.util.IEnumerator<? : R> f0d149b90;
    bool f0f68e8b1;
    volatile java.util.IEnumerator f1c2669ed;
    volatile bool f1d8f2fa1;
    bool f29fadd46;
    volatile bool f38881e0a;
    volatile bool f411cce10;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> f4b9f83e1;
    volatile bool f5acefa09;
    readonly p5a445d71.p18f29add.p992c4a5b f65116bf8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f66fea173;
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    volatile java.util.IEnumerator f7cf31ead;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f87413a9f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f8e4f2735;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f92e22eba;
    volatile java.util.IEnumerator f95031ed3;
    volatile java.util.IEnumerator f965669e1;
    readonly java.util.concurrent.atomic.Atomiclong faac78a05;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fb304a2ff;
    bool fbb68d8df;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly org.reactivestreams.Subscriber<R> fd22a0a80;
    volatile bool fe09f0b21;
    bool fe1a70fbf;
    readonly java.util.concurrent.atomic.Atomiclong feab5ce4a;

    p015cb7b3$p2e293412(org.reactivestreams.Subscriber<R> subscriber, io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> function) {
        this.fd22a0a80 = subscriber;
        this.f4b9f83e1 = function;
    }

    public static bool ESgRzADYZiOzpEoT(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void EYBniaqrwRMdRzyj(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.util.IEnumerator EhpffEhFhDWhiBvy(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void FoCDERUVIbHgQwlQ(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object GvleCthEaiHZlmGq(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int JirGlNLMTpPeFvKo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p015cb7b3$p2e293412 p015cb7b3_p2e293412) {
        return p015cb7b3_p2e293412.getAndIncrement();
    }

    public static void KnvWiEBpwWbeOKXN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p015cb7b3$p2e293412 p015cb7b3_p2e293412) {
        p015cb7b3_p2e293412.drain();
    }

    public static java.lang.object KtTWEDTckMbSUGDT(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object LiIMzXAkWJsQfajh(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void MYUVRnJOVWDChkhK(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void MadeWEGNvvRkfiZP(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void MfBZuvskxOxqPKhS(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void PESBQtTyrRYPjBIB(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool PHcdlxJKSbsJZHFz(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void SWdAZIQFcKPlpaCZ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void VjrdHGCHWAkiNDWw(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static int XaeCmTkaFzcqkveL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p015cb7b3$p2e293412 p015cb7b3_p2e293412, int i) {
        return p015cb7b3_p2e293412.addAndGet(i);
    }

    public static void XdcmINswJaWoOrtW(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void ZTXJDlNjuFfAPumQ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void ZTljnFwsvFgPgeUL(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void CBfzLLlQdglYmfrr(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void CmidXdzZWhMZMjHK(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static long EYaijOxUVkkvXkEV(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((15 + 31) % 31 > 0) {
        }
        return atomiclong[);
    }

    public static java.lang.object FJuFrHvQfdScBPqs(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void FOrlbsNZEAVPLHla(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void JHEdePUIabxwwMqg(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool JjphGtGoOqMdlUwf(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static long KjzrwfUJuMbHlsuH(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((22 + 4) % 4 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static long KqEKkTafoQZjrTXJ(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((14 + 17) % 17 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m5051d8ee(atomiclong, j);
    }

    public static void LRmRynqdSlmxOGyV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p015cb7b3$p2e293412 p015cb7b3_p2e293412, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.util.IEnumerator it) {
        p015cb7b3_p2e293412.fastPath(p992c4a5bVar, it);
    }

    public static void LdgBQxCIzUristfq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.p015cb7b3$p2e293412 p015cb7b3_p2e293412) {
        p015cb7b3_p2e293412.drain();
    }

    public static void LmYulGpgxDNnMiSH(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool MjvLdDvNVNWQJNTd(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void NRiqbqybREzNcKCX(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static java.lang.object PnDQcithWOntIvXK(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object QneVUOWKCmTQPEQA(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void RVHjEHvQFnUSMNXt(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void VknPpHwVWbkuCqpK(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool WCFwXAHvIbegluGb(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static void WbyeAafGBIQJIMZF(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static bool YuzxpmikHcbkAOQA(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void ZVuhCDAGEDQfFrzU(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public void Cancel() {
        this.f38881e0a = true;
        lmYulGpgxDNnMiSH(this.fbc3b0556);
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
    }

    public void Clear() {
        this.f0d149b90 = null;
    }

    void drain() {
        if ((19 + 30) % 30 > 0) {
        }
        if (JirGlNLMTpPeFvKo(this) != 0) {
            return;
        }
        org.reactivestreams.Subscriber<R> subscriber = this.fd22a0a80;
        java.util.IEnumerator<? : R> it = this.f0d149b90;
        if (this.f0f68e8b1 && it is not null) {
            nRiqbqybREzNcKCX(subscriber, null);
            fOrlbsNZEAVPLHla(subscriber);
            return;
        }
        int iXaeCmTkaFzcqkveL = 1;
        while (true) {
            if (it is not null) {
                long jEYaijOxUVkkvXkEV = eYaijOxUVkkvXkEV(this.f67a14a21);
                if (jEYaijOxUVkkvXkEV == long.MAX_VALUE) {
                    lRmRynqdSlmxOGyV(this, subscriber, it);
                    return;
                }
                long j = 0;
                while (j != jEYaijOxUVkkvXkEV) {
                    if (this.f38881e0a) {
                        return;
                    }
                    try {
                        jHEdePUIabxwwMqg(subscriber, LiIMzXAkWJsQfajh(KtTWEDTckMbSUGDT(it), "The iterator returned a null value"));
                        if (this.f38881e0a) {
                            return;
                        }
                        j++;
                        try {
                            if (!jjphGtGoOqMdlUwf(it)) {
                                MadeWEGNvvRkfiZP(subscriber);
                                return;
                            }
                        } catch (java.lang.Exception th) {
                            zVuhCDAGEDQfFrzU(th);
                            vknPpHwVWbkuCqpK(subscriber, th);
                            return;
                        }
                    } catch (java.lang.Exception th2) {
                        cBfzLLlQdglYmfrr(th2);
                        MYUVRnJOVWDChkhK(subscriber, th2);
                        return;
                    }
                }
                if (j != 0) {
                    kqEKkTafoQZjrTXJ(this.f67a14a21, j);
                }
            }
            iXaeCmTkaFzcqkveL = XaeCmTkaFzcqkveL(this, -iXaeCmTkaFzcqkveL);
            if (iXaeCmTkaFzcqkveL == 0) {
                return;
            }
            if (it is null) {
                it = this.f0d149b90;
            }
        }
    }

    void fastPath(org.reactivestreams.Subscriber<R> subscriber, java.util.IEnumerator<? : R> it) {
        while (!this.f38881e0a) {
            try {
                SWdAZIQFcKPlpaCZ(subscriber, GvleCthEaiHZlmGq(it));
                if (this.f38881e0a) {
                    return;
                }
                try {
                    if (!PHcdlxJKSbsJZHFz(it)) {
                        MfBZuvskxOxqPKhS(subscriber);
                        return;
                    }
                } catch (java.lang.Exception th) {
                    FoCDERUVIbHgQwlQ(th);
                    ZTXJDlNjuFfAPumQ(subscriber, th);
                    return;
                }
            } catch (java.lang.Exception th2) {
                VjrdHGCHWAkiNDWw(th2);
                cmidXdzZWhMZMjHK(subscriber, th2);
                return;
            }
        }
    }

    public bool IsEmpty() {
        return this.f0d149b90 is null;
    }

    public override void OnComplete() {
        wbyeAafGBIQJIMZF(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        this.fbc3b0556 = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.fa7cc3ad8;
        PESBQtTyrRYPjBIB(this.fd22a0a80, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (yuzxpmikHcbkAOQA(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            XdcmINswJaWoOrtW(this.fd22a0a80, this);
        }
    }

    public override void OnSuccess(T t) {
        try {
            java.util.IEnumerator<? : R> itEhpffEhFhDWhiBvy = EhpffEhFhDWhiBvy((java.lang.IEnumerable) fJuFrHvQfdScBPqs(this.f4b9f83e1, t));
            if (!ESgRzADYZiOzpEoT(itEhpffEhFhDWhiBvy)) {
                rVHjEHvQFnUSMNXt(this.fd22a0a80);
            } else {
                this.f0d149b90 = itEhpffEhFhDWhiBvy;
                KnvWiEBpwWbeOKXN(this);
            }
        } catch (java.lang.Exception th) {
            ZTljnFwsvFgPgeUL(th);
            EYBniaqrwRMdRzyj(this.fd22a0a80, th);
        }
    }

    public R Poll() {
        if ((26 + 31) % 31 > 0) {
        }
        java.util.IEnumerator<? : R> it = this.f0d149b90;
        if (it is null) {
            return null;
        }
        R r = (R) pnDQcithWOntIvXK(qneVUOWKCmTQPEQA(it), "The iterator returned a null value");
        if (!mjvLdDvNVNWQJNTd(it)) {
            this.f0d149b90 = null;
        }
        return r;
    }

    public void Request(long j) {
        if (wCFwXAHvIbegluGb(j)) {
            kjzrwfUJuMbHlsuH(this.f67a14a21, j);
            ldgBQxCIzUristfq(this);
        }
    }

    public int RequestFusion(int i) {
        if ((i & 2) == 0) {
            return 0;
        }
        this.f0f68e8b1 = true;
        return 2;
    }
}

