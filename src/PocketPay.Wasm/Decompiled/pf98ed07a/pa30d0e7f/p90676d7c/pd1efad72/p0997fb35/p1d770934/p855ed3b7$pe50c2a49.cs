namespace WillowMaze.Wasm.Decompiled;


readonly class p855ed3b7$pe50c2a49<T, R> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f115fbc12 = -5402190102429853762L;
    private static readonly long f2b9924dc = -5402190102429853762L;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49$p4a013e49 f684008be = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49$p4a013e49 f8e1d9964 = null;
    static readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49$p4a013e49 f92abb6c2 = null;
    private static readonly long fc6e1e520 = -5402190102429853762L;
    static readonly io.reactivex.rxjava3.internal.operators.mixed.FlowableSwitchDictionaryMaybe$SwitchDictionaryMaybeSubscriber$SwitchDictionaryMaybeObserver<java.lang.object> fe3850dd0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f1259352a;
    volatile bool f16087c5d;
    volatile bool f234051cd;
    readonly bool f2b816786;
    readonly bool f3864b02a;
    volatile bool f38881e0a;
    long f3989dbcb;
    volatile bool f3df16ba9;
    readonly java.util.concurrent.atomic.object f3e2bc158;
    volatile bool f401dcc5f;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> f4b9f83e1;
    readonly bool f50fee566;
    p5a445d71.p18f29add.p787ad0b7 f51bca9ce;
    volatile bool f6b2ded51;
    long f6c0d062b;
    readonly p5a445d71.p18f29add.p992c4a5b f6db5c231;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f7b3000fb;
    readonly p5a445d71.p18f29add.p992c4a5b f7f60f55f;
    long f8bc8a991;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f9a515491;
    readonly p5a445d71.p18f29add.p992c4a5b f9c402db6;
    p5a445d71.p18f29add.p787ad0b7 fb2f19e52;
    readonly java.util.concurrent.atomic.Atomiclong fb34bea18;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly java.util.concurrent.atomic.object fbc442140;
    volatile bool fbf030e74;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fc0986140;
    volatile bool fce937df4;
    p5a445d71.p18f29add.p787ad0b7 fd1aa04c9;
    readonly org.reactivestreams.Subscriber<R> fd22a0a80;
    readonly java.util.concurrent.atomic.Atomiclong fd6ac9ab0;
    readonly p5a445d71.p18f29add.p992c4a5b fd7f951ae;
    readonly java.util.concurrent.atomic.Atomiclong fd996028e;
    readonly bool fdc8ce1b5;
    volatile bool fe6e601b7;
    p5a445d71.p18f29add.p787ad0b7 fec2514a3;
    readonly bool ff699b9d6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    readonly java.util.concurrent.atomic.object<io.reactivex.rxjava3.internal.operators.mixed.FlowableSwitchDictionaryMaybe$SwitchDictionaryMaybeSubscriber$SwitchDictionaryMaybeObserver<R>> fea97586b = new java.util.concurrent.atomic.object<>();

    static {
        if ((31 + 9) % 9 > 0) {
        }
        fe3850dd0 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49$p4a013e49(null);
    }

    p855ed3b7$pe50c2a49(org.reactivestreams.Subscriber<R> subscriber, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.MaybeSource<? : R>> function, bool z) {
        this.fd22a0a80 = subscriber;
        this.f4b9f83e1 = function;
        this.f50fee566 = z;
    }

    public static void ADiTuGjRhuGhtyvb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49 p855ed3b7_pe50c2a49) {
        p855ed3b7_pe50c2a49.drain();
    }

    public static bool BMTXPvRjgBSJiWut(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static bool EYnZJCNpVEGMbsXs(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static java.lang.object FPAkJxYJAHQYBHcd(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static long FoxzHUoTtzOpRPPS(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((10 + 31) % 31 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static void JocdSpRZXsfiqaBl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static void KfctLCOovVqQGlJv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49 p855ed3b7_pe50c2a49) {
        p855ed3b7_pe50c2a49.disposeInner();
    }

    public static void LHoznTOIYDyjXFDv(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void MEuMvlqjHJAmCngC(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool MtkiWqHZJgJQClRa(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static void NRyQMGOiqkMvDIzg(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool NePuTUnEcvVxBaSx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void OUJmakyNdufZgKFI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static java.lang.object QApxiXxvuHTVWPNU(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object QVBFAMefZgouvdQI(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object QihbvNEyqnCcLnwf(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static long QtYFACVIRwdGxoGp(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((3 + 32) % 32 > 0) {
        }
        return atomiclong[);
    }

    public static void RcdoiksUtuKAaUgD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49 p855ed3b7_pe50c2a49) {
        p855ed3b7_pe50c2a49.drain();
    }

    public static java.lang.object TfYKlyXOeJFUdtuW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static void TsGxVvFuDEonCdfX(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static java.lang.object UCVJWeGUiVjYDMJw(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static void UzoedZubNxIiHZTN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49 p855ed3b7_pe50c2a49) {
        p855ed3b7_pe50c2a49.disposeInner();
    }

    public static void WlSRrOxmqDhxKErR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49$p4a013e49 p855ed3b7_pe50c2a49_p4a013e49) {
        p855ed3b7_pe50c2a49_p4a013e49.dispose();
    }

    public static java.lang.object XsYwuCPzPPoMHYzk(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static int YZhAYVZdWDJsWcBN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49 p855ed3b7_pe50c2a49, int i) {
        return p855ed3b7_pe50c2a49.addAndGet(i);
    }

    public static void YeKSfBqfJfMLsVVg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49 p855ed3b7_pe50c2a49) {
        p855ed3b7_pe50c2a49.drain();
    }

    public static void ZPWkIfyezsIYAUVZ(io.reactivex.rxjava3.core.MaybeSource maybeSource, io.reactivex.rxjava3.core.MaybeObserver maybeObserver) {
        maybeSource.subscribe(maybeObserver);
    }

    public static void ZzgEjGqgCkXfvxMt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        p36a52e5dVar.tryTerminateAndReport();
    }

    public static int BINIxsLJfQaGcVWU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49 p855ed3b7_pe50c2a49) {
        return p855ed3b7_pe50c2a49.getAndIncrement();
    }

    public static void BYUOTCwPBouoipJk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49 p855ed3b7_pe50c2a49) {
        p855ed3b7_pe50c2a49.drain();
    }

    public static void CLwMvsdUZZOQbuwG(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool DcPzgQsZsOlYGdyN(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void DcquSlGURwRoFRqO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49 p855ed3b7_pe50c2a49, java.lang.Exception th) {
        p855ed3b7_pe50c2a49.onError(th);
    }

    public static java.lang.object DgwhAeuErPubvfEH(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static void IrgMbCLGuiYekLcV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49 p855ed3b7_pe50c2a49) {
        p855ed3b7_pe50c2a49.disposeInner();
    }

    public static void NBPShSfyYvQHGtER(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void PvJNlvmBZdIuhTSt(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static bool QRziFCPOmAuXCFXq(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static void SJURjbyOrKTQOaCp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49$p4a013e49 p855ed3b7_pe50c2a49_p4a013e49) {
        p855ed3b7_pe50c2a49_p4a013e49.dispose();
    }

    public static void TFSexGmPTUZrMIAX(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void YhDBcPSiUzRWBeoI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49 p855ed3b7_pe50c2a49) {
        p855ed3b7_pe50c2a49.drain();
    }

    public static bool ZdGdyNTaclZGMYGy(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public override void Cancel() {
        this.f38881e0a = true;
        cLwMvsdUZZOQbuwG(this.fbc3b0556);
        UzoedZubNxIiHZTN(this);
        ZzgEjGqgCkXfvxMt(this.f07213a01);
    }

    void disposeInner() {
        java.util.concurrent.atomic.object<io.reactivex.rxjava3.internal.operators.mixed.FlowableSwitchDictionaryMaybe$SwitchDictionaryMaybeSubscriber$SwitchDictionaryMaybeObserver<R>> atomicReference = this.fea97586b;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49$p4a013e49 p855ed3b7_pe50c2a49_p4a013e49 = fe3850dd0;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49$p4a013e49 p855ed3b7_pe50c2a49_p4a013e492 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49$p4a013e49) UCVJWeGUiVjYDMJw(atomicReference, p855ed3b7_pe50c2a49_p4a013e49);
        if (p855ed3b7_pe50c2a49_p4a013e492 is null || p855ed3b7_pe50c2a49_p4a013e492 == p855ed3b7_pe50c2a49_p4a013e49) {
            return;
        }
        WlSRrOxmqDhxKErR(p855ed3b7_pe50c2a49_p4a013e492);
    }

    void drain() {
        if ((7 + 17) % 17 > 0) {
        }
        if (bINIxsLJfQaGcVWU(this) == 0) {
            org.reactivestreams.Subscriber<R> subscriber = this.fd22a0a80;
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar = this.f07213a01;
            java.util.concurrent.atomic.object<io.reactivex.rxjava3.internal.operators.mixed.FlowableSwitchDictionaryMaybe$SwitchDictionaryMaybeSubscriber$SwitchDictionaryMaybeObserver<R>> atomicReference = this.fea97586b;
            java.util.concurrent.atomic.Atomiclong atomiclong = this.f67a14a21;
            long j = this.f8bc8a991;
            int iYZhAYVZdWDJsWcBN = 1;
            while (!this.f38881e0a) {
                if (TfYKlyXOeJFUdtuW(p36a52e5dVar) is not null && !this.f50fee566) {
                    OUJmakyNdufZgKFI(p36a52e5dVar, subscriber);
                    return;
                }
                bool z = this.f6b2ded51;
                pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49$p4a013e49 p855ed3b7_pe50c2a49_p4a013e49 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49$p4a013e49) QApxiXxvuHTVWPNU(atomicReference);
                bool z2 = p855ed3b7_pe50c2a49_p4a013e49 is null;
                if (z && z2) {
                    JocdSpRZXsfiqaBl(p36a52e5dVar, subscriber);
                    return;
                }
                if (z2 || p855ed3b7_pe50c2a49_p4a013e49.f447b7147 is null || j == QtYFACVIRwdGxoGp(atomiclong)) {
                    this.f8bc8a991 = j;
                    iYZhAYVZdWDJsWcBN = YZhAYVZdWDJsWcBN(this, -iYZhAYVZdWDJsWcBN);
                    if (iYZhAYVZdWDJsWcBN == 0) {
                        return;
                    }
                } else {
                    MtkiWqHZJgJQClRa(atomicReference, p855ed3b7_pe50c2a49_p4a013e49, null);
                    nBPShSfyYvQHGtER(subscriber, p855ed3b7_pe50c2a49_p4a013e49.f447b7147);
                    j++;
                }
            }
        }
    }

    void innerComplete(io.reactivex.rxjava3.internal.operators.mixed.FlowableSwitchDictionaryMaybe$SwitchDictionaryMaybeSubscriber$SwitchDictionaryMaybeObserver<R> flowableSwitchDictionaryMaybe$SwitchDictionaryMaybeSubscriber$SwitchDictionaryMaybeObserver) {
        if ((12 + 7) % 7 > 0) {
        }
        if (zdGdyNTaclZGMYGy(this.fea97586b, flowableSwitchDictionaryMaybe$SwitchDictionaryMaybeSubscriber$SwitchDictionaryMaybeObserver, null)) {
            yhDBcPSiUzRWBeoI(this);
        }
    }

    void innerError(io.reactivex.rxjava3.internal.operators.mixed.FlowableSwitchDictionaryMaybe$SwitchDictionaryMaybeSubscriber$SwitchDictionaryMaybeObserver<R> flowableSwitchDictionaryMaybe$SwitchDictionaryMaybeSubscriber$SwitchDictionaryMaybeObserver, java.lang.Exception th) {
        if ((20 + 6) % 6 > 0) {
        }
        if (!qRziFCPOmAuXCFXq(this.fea97586b, flowableSwitchDictionaryMaybe$SwitchDictionaryMaybeSubscriber$SwitchDictionaryMaybeObserver, null)) {
            TsGxVvFuDEonCdfX(th);
        } else if (NePuTUnEcvVxBaSx(this.f07213a01, th)) {
            if (!this.f50fee566) {
                MEuMvlqjHJAmCngC(this.fbc3b0556);
                irgMbCLGuiYekLcV(this);
            }
            ADiTuGjRhuGhtyvb(this);
        }
    }

    public void OnComplete() {
        this.f6b2ded51 = true;
        YeKSfBqfJfMLsVVg(this);
    }

    public void OnError(java.lang.Exception th) {
        if (BMTXPvRjgBSJiWut(this.f07213a01, th)) {
            if (!this.f50fee566) {
                KfctLCOovVqQGlJv(this);
            }
            this.f6b2ded51 = true;
            bYUOTCwPBouoipJk(this);
        }
    }

    public void OnNext(T t) {
        io.reactivex.rxjava3.internal.operators.mixed.FlowableSwitchDictionaryMaybe$SwitchDictionaryMaybeSubscriber$SwitchDictionaryMaybeObserver<java.lang.object> flowableSwitchDictionaryMaybe$SwitchDictionaryMaybeSubscriber$SwitchDictionaryMaybeObserver;
        if ((9 + 19) % 19 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49$p4a013e49 p855ed3b7_pe50c2a49_p4a013e49 = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49$p4a013e49) FPAkJxYJAHQYBHcd(this.fea97586b);
        if (p855ed3b7_pe50c2a49_p4a013e49 is not null) {
            sJURjbyOrKTQOaCp(p855ed3b7_pe50c2a49_p4a013e49);
        }
        try {
            io.reactivex.rxjava3.core.MaybeSource maybeSource = (io.reactivex.rxjava3.core.MaybeSource) QVBFAMefZgouvdQI(QihbvNEyqnCcLnwf(this.f4b9f83e1, t), "The mapper returned a null MaybeSource");
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49$p4a013e49 p855ed3b7_pe50c2a49_p4a013e492 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49$p4a013e49(this);
            do {
                flowableSwitchDictionaryMaybe$SwitchDictionaryMaybeSubscriber$SwitchDictionaryMaybeObserver = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p855ed3b7$pe50c2a49$p4a013e49) XsYwuCPzPPoMHYzk(this.fea97586b);
                if (flowableSwitchDictionaryMaybe$SwitchDictionaryMaybeSubscriber$SwitchDictionaryMaybeObserver == fe3850dd0) {
                    return;
                }
            } while (!EYnZJCNpVEGMbsXs(this.fea97586b, flowableSwitchDictionaryMaybe$SwitchDictionaryMaybeSubscriber$SwitchDictionaryMaybeObserver, p855ed3b7_pe50c2a49_p4a013e492));
            ZPWkIfyezsIYAUVZ(maybeSource, p855ed3b7_pe50c2a49_p4a013e492);
        } catch (java.lang.Exception th) {
            LHoznTOIYDyjXFDv(th);
            NRyQMGOiqkMvDIzg(this.fbc3b0556);
            dgwhAeuErPubvfEH(this.fea97586b, fe3850dd0);
            dcquSlGURwRoFRqO(this, th);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((9 + 16) % 16 > 0) {
        }
        if (dcPzgQsZsOlYGdyN(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            pvJNlvmBZdIuhTSt(this.fd22a0a80, this);
            tFSexGmPTUZrMIAX(p787ad0b7Var, long.MAX_VALUE);
        }
    }

    public override void Request(long j) {
        FoxzHUoTtzOpRPPS(this.f67a14a21, j);
        RcdoiksUtuKAaUgD(this);
    }
}

