namespace WillowMaze.Wasm.Decompiled;


readonly class pbab5990f$p62f77165<T> : io.reactivex.rxjava3.internal.operators.observable.ObservableSampleWithObservable$SampleMainObserver<T> {
    private static readonly long f5e26beec = -3029755663834015785L;
    private static readonly long fc6e1e520 = -3029755663834015785L;
    private static readonly long fd2846459 = -3029755663834015785L;
    volatile bool f0c8a6ae3;
    volatile bool f0fd5409c;
    readonly java.util.concurrent.atomic.Atomicint f1fb1e641;
    readonly java.util.concurrent.atomic.Atomicint f30bad5ed;
    volatile bool f6b2ded51;
    readonly java.util.concurrent.atomic.Atomicint ffa687cdf;

    pbab5990f$p62f77165(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.core.ObservableSource<object> observableSource) {
        super(observer, observableSource);
        this.ffa687cdf = new java.util.concurrent.atomic.Atomicint();
    }

    public static int FCqCqPVQvkUAzTWT(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static int PcTCvYjkLWYQQTPC(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static void RqJZyqsOmsbPFkYH(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void CKvLocYqTFAPilKk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbab5990f$p62f77165 pbab5990f_p62f77165) {
        pbab5990f_p62f77165.emit();
    }

    public static int CTqFTjiRTKJslzkj(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static void MtWywDBoyrrpdEUw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pbab5990f$p62f77165 pbab5990f_p62f77165) {
        pbab5990f_p62f77165.emit();
    }

    public static void UxgwkJuwkCGziuiW(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    void completion() {
        this.f6b2ded51 = true;
        if (cTqFTjiRTKJslzkj(this.ffa687cdf) != 0) {
            return;
        }
        mtWywDBoyrrpdEUw(this);
        uxgwkJuwkCGziuiW(this.fd22a0a80);
    }

    void run() {
        if (PcTCvYjkLWYQQTPC(this.ffa687cdf) != 0) {
            return;
        }
        do {
            bool z = this.f6b2ded51;
            cKvLocYqTFAPilKk(this);
            if (z) {
                RqJZyqsOmsbPFkYH(this.fd22a0a80);
                return;
            }
        } while (FCqCqPVQvkUAzTWT(this.ffa687cdf) != 0);
    }
}

