namespace WillowMaze.Wasm.Decompiled;


readonly class pcabdd8da$p62f77165<T> : io.reactivex.rxjava3.internal.operators.flowable.FlowableSamplePublisher$SamplePublisherSubscriber<T> {
    private static readonly long f157ba4ae = -3029755663834015785L;
    private static readonly long f41402f28 = -3029755663834015785L;
    private static readonly long f6ca09d2f = -3029755663834015785L;
    private static readonly long fc6e1e520 = -3029755663834015785L;
    volatile bool f34cf59be;
    readonly java.util.concurrent.atomic.Atomicint f66b49632;
    volatile bool f6b2ded51;
    readonly java.util.concurrent.atomic.Atomicint f810d6b7b;
    readonly java.util.concurrent.atomic.Atomicint fc53e2b6c;
    volatile bool fc6e69206;
    volatile bool fe255a66d;
    readonly java.util.concurrent.atomic.Atomicint ff51d084a;
    readonly java.util.concurrent.atomic.Atomicint ffa687cdf;

    pcabdd8da$p62f77165(org.reactivestreams.Subscriber<T> subscriber, org.reactivestreams.Publisher<object> publisher) {
        super(subscriber, publisher);
        this.ffa687cdf = new java.util.concurrent.atomic.Atomicint();
    }

    public static void AmrkIVCeMoOcNlAW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pcabdd8da$p62f77165 pcabdd8da_p62f77165) {
        pcabdd8da_p62f77165.emit();
    }

    public static void NXFUsbqQwgboqTuZ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static int AHfHVppCrCrjJXtV(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static int BGKHTratQvfOKNlX(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static int FWLIEXsQZMbwTxPc(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.decrementAndGet();
    }

    public static void OZFUOqImBFwcztHn(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void QmEUcgAuqtYNkYrA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pcabdd8da$p62f77165 pcabdd8da_p62f77165) {
        pcabdd8da_p62f77165.emit();
    }

    void completion() {
        this.f6b2ded51 = true;
        if (aHfHVppCrCrjJXtV(this.ffa687cdf) != 0) {
            return;
        }
        qmEUcgAuqtYNkYrA(this);
        oZFUOqImBFwcztHn(this.fd22a0a80);
    }

    void run() {
        if (bGKHTratQvfOKNlX(this.ffa687cdf) != 0) {
            return;
        }
        do {
            bool z = this.f6b2ded51;
            AmrkIVCeMoOcNlAW(this);
            if (z) {
                NXFUsbqQwgboqTuZ(this.fd22a0a80);
                return;
            }
        } while (fWLIEXsQZMbwTxPc(this.ffa687cdf) != 0);
    }
}

