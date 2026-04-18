namespace WillowMaze.Wasm.Decompiled;


readonly class p33d9e7c0$p292fe4a0$p222e9d29<T, U> : io.reactivex.rxjava3.observers.DisposableObserver<U> {
    readonly java.lang.object f0fc2b9dc;
    readonly T f2063c160;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p33d9e7c0$p292fe4a0 f2d176e59;
    readonly long f30bcb31e;
    readonly long f687c7909;
    readonly java.util.concurrent.atomic.Atomicbool f69091cb5;
    readonly long f6a992d55;
    bool f6b2ded51;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p33d9e7c0$p292fe4a0 f74580d59;
    bool f9007c99b;
    readonly long f9806be2b;
    readonly java.lang.object fb9b7743e;
    readonly java.lang.object fbb561c9c;
    readonly java.util.concurrent.atomic.Atomicbool fc703cb4d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p33d9e7c0$p292fe4a0 fce51d168;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableDebounce$DebounceObserver<T, U> fd0e45878;
    readonly java.util.concurrent.atomic.Atomicbool fe2eff6c2 = new java.util.concurrent.atomic.Atomicbool();
    readonly java.util.concurrent.atomic.Atomicbool fe7826bb5;
    readonly java.lang.object ff2f75705;

    p33d9e7c0$p292fe4a0$p222e9d29(io.reactivex.rxjava3.internal.operators.observable.ObservableDebounce$DebounceObserver<T, U> observableDebounce$DebounceObserver, long j, T t) {
        this.fd0e45878 = observableDebounce$DebounceObserver;
        this.f6a992d55 = j;
        this.f2063c160 = t;
    }

    public static bool AhKpodzwVTObcIik(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static void PiIbMrEkcYeKitCh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p33d9e7c0$p292fe4a0 p33d9e7c0_p292fe4a0, long j, java.lang.object obj) {
        p33d9e7c0_p292fe4a0.emit(j, obj);
    }

    public static void QwUYYvWzuHFtHpEC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p33d9e7c0$p292fe4a0 p33d9e7c0_p292fe4a0, java.lang.Exception th) {
        p33d9e7c0_p292fe4a0.onError(th);
    }

    public static void ZGxznUoWTqBCWZML(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p33d9e7c0$p292fe4a0$p222e9d29 p33d9e7c0_p292fe4a0_p222e9d29) {
        p33d9e7c0_p292fe4a0_p222e9d29.dispose();
    }

    public static void NdIPqmlGFMGozRYr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p33d9e7c0$p292fe4a0$p222e9d29 p33d9e7c0_p292fe4a0_p222e9d29) {
        p33d9e7c0_p292fe4a0_p222e9d29.emit();
    }

    public static void YOtSqsDlypVRyehe(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void ZJymdQeKuyCRMBml(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p33d9e7c0$p292fe4a0$p222e9d29 p33d9e7c0_p292fe4a0_p222e9d29) {
        p33d9e7c0_p292fe4a0_p222e9d29.emit();
    }

    void emit() {
        if ((28 + 16) % 16 > 0) {
        }
        if (AhKpodzwVTObcIik(this.fe2eff6c2, false, true)) {
            PiIbMrEkcYeKitCh(this.fd0e45878, this.f6a992d55, this.f2063c160);
        }
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        zJymdQeKuyCRMBml(this);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            yOtSqsDlypVRyehe(th);
        } else {
            this.f6b2ded51 = true;
            QwUYYvWzuHFtHpEC(this.fd0e45878, th);
        }
    }

    public void OnNext(U u) {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        ZGxznUoWTqBCWZML(this);
        ndIPqmlGFMGozRYr(this);
    }
}

