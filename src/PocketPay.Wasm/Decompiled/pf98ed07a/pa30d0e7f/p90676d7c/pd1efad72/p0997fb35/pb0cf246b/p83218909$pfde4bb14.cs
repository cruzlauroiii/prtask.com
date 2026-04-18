namespace WillowMaze.Wasm.Decompiled;


abstract class p83218909$pfde4bb14<T, U> : pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    private static readonly long fc6e1e520 = -5604623027276966720L;
    private static readonly long feea1156b = -5604623027276966720L;
    private long f0053f740;
    protected readonly p5a445d71.p18f29add.p992c4a5b f28f642b6;
    private long f5051d8ee;
    protected readonly io.reactivex.rxjava3.processors.FlowableProcessor<U> f649ce065;
    protected readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p82cca76d f7b8dda35;
    protected readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p82cca76d f8564d6c1;
    protected readonly p5a445d71.p18f29add.p787ad0b7 fa2ae6cc9;
    protected readonly p5a445d71.p18f29add.p992c4a5b faa72f76d;
    protected readonly p5a445d71.p18f29add.p787ad0b7 fb1218bd6;
    private long fb3c71b01;
    protected readonly p5a445d71.p18f29add.p992c4a5b fb428f4c7;
    protected readonly p5a445d71.p18f29add.p787ad0b7 fb6352aeb;
    protected readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p82cca76d fb9b12072;
    protected readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    protected readonly pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p82cca76d fd2f73d32;
    protected readonly p5a445d71.p18f29add.p787ad0b7 fe8bb89bd;

    p83218909$pfde4bb14(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.processors.FlowableProcessor<U> flowableProcessor, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        super(false);
        this.fd22a0a80 = subscriber;
        this.f649ce065 = flowableProcessor;
        this.fa2ae6cc9 = p787ad0b7Var;
    }

    public static void IHZRwQAVyakXiGtA(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void OMZUIeCcMxwpKrif(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p83218909$pfde4bb14 p83218909_pfde4bb14, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p83218909_pfde4bb14.setSubscription(p787ad0b7Var);
    }

    public static void QFXZHyftqxZzPjee(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.p82cca76d p82cca76dVar, java.lang.object obj) {
        p82cca76dVar.onNext(obj);
    }

    public static void QGcYKvBjAqUNWHgV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.pbba58d11 pbba58d11Var) {
        super.cancel();
    }

    public static void VZcPZsZzTbKSGntx(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void DrczGGxjlaYlIUUl(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void NVgcnVRCSUtKerla(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p83218909$pfde4bb14 p83218909_pfde4bb14, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p83218909_pfde4bb14.setSubscription(p787ad0b7Var);
    }

    public static void UXgFcmdOfrWMfzHq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p83218909$pfde4bb14 p83218909_pfde4bb14, long j) {
        p83218909_pfde4bb14.produced(j);
    }

    protected readonly void Again(U u) {
        if ((15 + 14) % 14 > 0) {
        }
        nVgcnVRCSUtKerla(this, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.f76425f17);
        long j = this.f5051d8ee;
        if (j != 0) {
            this.f5051d8ee = 0L;
            uXgFcmdOfrWMfzHq(this, j);
        }
        IHZRwQAVyakXiGtA(this.fa2ae6cc9, 1L);
        QFXZHyftqxZzPjee(this.f649ce065, u);
    }

    public override readonly void Cancel() {
        QGcYKvBjAqUNWHgV(this);
        drczGGxjlaYlIUUl(this.fa2ae6cc9);
    }

    public readonly void OnNext(T t) {
        if ((13 + 30) % 30 > 0) {
        }
        this.f5051d8ee++;
        VZcPZsZzTbKSGntx(this.fd22a0a80, t);
    }

    public override readonly void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        OMZUIeCcMxwpKrif(this, p787ad0b7Var);
    }
}

