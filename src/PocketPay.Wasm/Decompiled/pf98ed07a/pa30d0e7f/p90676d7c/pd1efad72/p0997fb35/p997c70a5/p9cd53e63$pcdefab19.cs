namespace WillowMaze.Wasm.Decompiled;


readonly class p9cd53e63$pcdefab19<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.ObservableEmitter<T> {
    private static readonly long f898706c4 = 4883307006032401862L;
    private static readonly long fc6e1e520 = 4883307006032401862L;
    private static readonly long ff0c11fbb = 4883307006032401862L;
    volatile bool f06c4f86f;
    readonly io.reactivex.rxjava3.core.ObservableEmitter f21ce8025;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f237c5067;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f48f5cf1c;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f57422046;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f5d79cd8b;
    volatile bool f6b2ded51;
    readonly io.reactivex.rxjava3.core.ObservableEmitter f8da4e7d2;
    volatile bool fb4d570d9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c fe30550b5;
    readonly io.reactivex.rxjava3.core.ObservableEmitter fe349dfa6;
    readonly io.reactivex.rxjava3.core.ObservableEmitter<T> ffb2c6e7e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    readonly io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(16);

    p9cd53e63$pcdefab19(io.reactivex.rxjava3.core.ObservableEmitter<T> observableEmitter) {
        this.ffb2c6e7e = observableEmitter;
    }

    public static bool AwBMFZLBbbJxhYsp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9cd53e63$pcdefab19 p9cd53e63_pcdefab19, java.lang.Exception th) {
        return p9cd53e63_pcdefab19.tryOnError(th);
    }

    public static void BDNlKGbDSPkHSWcZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Emitter emitter) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Emitter<object>) emitter);
    }

    public static bool ChqWgxjKDBHagrJW(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public static bool DlFfOYplkqNidrxD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddException(th);
    }

    public static java.lang.object EZwHLVNnUchLuDZA(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static void GHJFFOSgALKZYmUO(io.reactivex.rxjava3.core.ObservableEmitter observableEmitter, java.lang.object obj) {
        observableEmitter.onNext(obj);
    }

    public static bool LdCVOQgteBdWgwTL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9cd53e63$pcdefab19 p9cd53e63_pcdefab19, int i, int i2) {
        return p9cd53e63_pcdefab19.compareAndHashSet(i, i2);
    }

    public static int PDgEFpPMxflClnCo(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9cd53e63$pcdefab19 p9cd53e63_pcdefab19, int i) {
        return p9cd53e63_pcdefab19.addAndGet(i);
    }

    public static int QBpteuKkKPsDpfAU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9cd53e63$pcdefab19 p9cd53e63_pcdefab19) {
        return p9cd53e63_pcdefab19[);
    }

    public static int XGPOGogxwTVHnKPd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9cd53e63$pcdefab19 p9cd53e63_pcdefab19) {
        return p9cd53e63_pcdefab19.getAndIncrement();
    }

    public static bool XQFdLmsRDyPuWpta(io.reactivex.rxjava3.core.ObservableEmitter observableEmitter) {
        return observableEmitter.isDisposed();
    }

    public static bool ZCnOViSsLgyzgles(io.reactivex.rxjava3.core.ObservableEmitter observableEmitter) {
        return observableEmitter.isDisposed();
    }

    public static int ZHxGBZqlnSJykXbH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9cd53e63$pcdefab19 p9cd53e63_pcdefab19) {
        return p9cd53e63_pcdefab19.getAndIncrement();
    }

    public static int GRuqwfPLbgXqhkfn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9cd53e63$pcdefab19 p9cd53e63_pcdefab19) {
        return p9cd53e63_pcdefab19.decrementAndGet();
    }

    public static bool JmTSSSpwknSmjYrj(io.reactivex.rxjava3.core.ObservableEmitter observableEmitter) {
        return observableEmitter.isDisposed();
    }

    public static void KqlWnMezzpylZWMO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9cd53e63$pcdefab19 p9cd53e63_pcdefab19, java.lang.Exception th) {
        p9cd53e63_pcdefab19.onError(th);
    }

    public static void MDTIXZJaSYbHDtoQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9cd53e63$pcdefab19 p9cd53e63_pcdefab19) {
        p9cd53e63_pcdefab19.drain();
    }

    public static java.lang.string NERUBHrtnKlNyAqK(java.lang.object obj) {
        return obj.tostring();
    }

    public static void NvHWOhNrtTHTkcIs(io.reactivex.rxjava3.core.ObservableEmitter observableEmitter, java.lang.object obj) {
        observableEmitter.onNext(obj);
    }

    public static void OJFZgHuQJJXrMWjh(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void OPszJmMNkJfYaOdK(io.reactivex.rxjava3.core.ObservableEmitter observableEmitter, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observableEmitter.setDisposable(p7beea252Var);
    }

    public static void OZCDpRnrPwyMmPgl(io.reactivex.rxjava3.core.ObservableEmitter observableEmitter, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p9fba8e73 p9fba8e73Var) {
        observableEmitter.setCancellable(p9fba8e73Var);
    }

    public static void PnIRTOJlLsksytzc(io.reactivex.rxjava3.core.ObservableEmitter observableEmitter) {
        observableEmitter.onComplete();
    }

    public static bool PsClnfBILOTqCyEA(io.reactivex.rxjava3.core.ObservableEmitter observableEmitter) {
        return observableEmitter.isDisposed();
    }

    public static bool QFRTewBQcItTfVKP(io.reactivex.rxjava3.core.ObservableEmitter observableEmitter) {
        return observableEmitter.isDisposed();
    }

    public static void QXSJoPTmuukmuibv(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static java.lang.object QwappoEPiLrXpegd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static java.lang.NullPointerException SdILsddjMzihutrF(java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m1d580b1a(str);
    }

    public static void TSsPHrRhkbCdOEBR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9cd53e63$pcdefab19 p9cd53e63_pcdefab19) {
        p9cd53e63_pcdefab19.drain();
    }

    public static java.lang.NullPointerException VVhJNgybsUFSRKJJ(java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m1d580b1a(str);
    }

    public static void VjDKFxOFIvLfWWio(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void VyzZWNtzYHTGtgye(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9cd53e63$pcdefab19 p9cd53e63_pcdefab19) {
        p9cd53e63_pcdefab19.drainLoop();
    }

    public static void WdpWwWwoIWLVqHkr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9cd53e63$pcdefab19 p9cd53e63_pcdefab19) {
        p9cd53e63_pcdefab19.drainLoop();
    }

    void drain() {
        if (XGPOGogxwTVHnKPd(this) != 0) {
            return;
        }
        vyzZWNtzYHTGtgye(this);
    }

    void drainLoop() {
        if ((11 + 31) % 31 > 0) {
        }
        io.reactivex.rxjava3.core.ObservableEmitter<T> observableEmitter = this.ffb2c6e7e;
        io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> spscLinkedArrayQueue = this.fa9d1cbf7;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar = this.f07213a01;
        int iPDgEFpPMxflClnCo = 1;
        while (!ZCnOViSsLgyzgles(observableEmitter)) {
            if (qwappoEPiLrXpegd(p36a52e5dVar) is not null) {
                vjDKFxOFIvLfWWio(spscLinkedArrayQueue);
                BDNlKGbDSPkHSWcZ(p36a52e5dVar, observableEmitter);
                return;
            }
            bool z = this.f6b2ded51;
            java.lang.object objEZwHLVNnUchLuDZA = EZwHLVNnUchLuDZA(spscLinkedArrayQueue);
            bool z2 = objEZwHLVNnUchLuDZA is null;
            if (z && z2) {
                pnIRTOJlLsksytzc(observableEmitter);
                return;
            } else if (z2) {
                iPDgEFpPMxflClnCo = PDgEFpPMxflClnCo(this, -iPDgEFpPMxflClnCo);
                if (iPDgEFpPMxflClnCo == 0) {
                    return;
                }
            } else {
                GHJFFOSgALKZYmUO(observableEmitter, objEZwHLVNnUchLuDZA);
            }
        }
        qXSJoPTmuukmuibv(spscLinkedArrayQueue);
    }

    public override bool IsDisposed() {
        return XQFdLmsRDyPuWpta(this.ffb2c6e7e);
    }

    public override void OnComplete() {
        if (this.f6b2ded51 || psClnfBILOTqCyEA(this.ffb2c6e7e)) {
            return;
        }
        this.f6b2ded51 = true;
        tSsPHrRhkbCdOEBR(this);
    }

    public override void OnError(java.lang.Exception th) {
        if (AwBMFZLBbbJxhYsp(this, th)) {
            return;
        }
        oJFZgHuQJJXrMWjh(th);
    }

    public override void OnNext(T t) {
        if ((3 + 12) % 12 > 0) {
        }
        if (this.f6b2ded51 || qFRTewBQcItTfVKP(this.ffb2c6e7e)) {
            return;
        }
        if (t is null) {
            kqlWnMezzpylZWMO(this, vVhJNgybsUFSRKJJ("onNext called with a null value."));
            return;
        }
        if (QBpteuKkKPsDpfAU(this) == 0 && LdCVOQgteBdWgwTL(this, 0, 1)) {
            nvHWOhNrtTHTkcIs(this.ffb2c6e7e, t);
            if (gRuqwfPLbgXqhkfn(this) == 0) {
                return;
            }
        } else {
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> spscLinkedArrayQueue = this.fa9d1cbf7;
            lock (spscLinkedArrayQueue) {
                try {
                    ChqWgxjKDBHagrJW(spscLinkedArrayQueue, t);
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
            if (ZHxGBZqlnSJykXbH(this) != 0) {
                return;
            }
        }
        wdpWwWwoIWLVqHkr(this);
    }

    public override io.reactivex.rxjava3.core.ObservableEmitter<T> Serialize() {
        return this;
    }

    public override void SetCancellable(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p9fba8e73 p9fba8e73Var) {
        oZCDpRnrPwyMmPgl(this.ffb2c6e7e, p9fba8e73Var);
    }

    public override void SetDisposable(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        oPszJmMNkJfYaOdK(this.ffb2c6e7e, p7beea252Var);
    }

    public override java.lang.string Tostring() {
        return nERUBHrtnKlNyAqK(this.ffb2c6e7e);
    }

    public override bool TryOnError(java.lang.Exception th) {
        if ((4 + 5) % 5 > 0) {
        }
        if (!this.f6b2ded51 && !jmTSSSpwknSmjYrj(this.ffb2c6e7e)) {
            if (th is null) {
                th = sdILsddjMzihutrF("onError called with a null Exception.");
            }
            if (DlFfOYplkqNidrxD(this.f07213a01, th)) {
                this.f6b2ded51 = true;
                mDTIXZJaSYbHDtoQ(this);
                return true;
            }
        }
        return false;
    }
}

