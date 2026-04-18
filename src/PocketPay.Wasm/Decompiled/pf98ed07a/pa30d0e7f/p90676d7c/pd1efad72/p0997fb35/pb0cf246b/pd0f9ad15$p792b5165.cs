namespace WillowMaze.Wasm.Decompiled;


readonly class pd0f9ad15$p792b5165 : pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd0f9ad15$p80c4f5d8 {
    private static readonly long f6ac358ee = 2587302975077663557L;
    private static readonly long fc6e1e520 = 2587302975077663557L;
    readonly p5a445d71.p18f29add.p992c4a5b fb29d1104;
    readonly org.reactivestreams.Subscriber<java.lang.int> fd22a0a80;

    pd0f9ad15$p792b5165(org.reactivestreams.Subscriber<java.lang.int> subscriber, int i, int i2) {
        super(i, i2);
        this.fd22a0a80 = subscriber;
    }

    public static java.lang.int IVCbQkusVZdMoNka(int i) {
        return java.lang.int.valueOf(i);
    }

    public static long QxmhTXJKUMubwIpa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd0f9ad15$p792b5165 pd0f9ad15_p792b5165, long j) {
        if ((5 + 12) % 12 > 0) {
        }
        return pd0f9ad15_p792b5165.addAndGet(j);
    }

    public static void WZhRdBSAzWVldwdk(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static java.lang.int ZAZTTpfaZHsyXKoE(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void AEjtOVbIttbAXpHB(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void AsawuIbImRRBzCNG(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static long IphnCbzJdvYkODqi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd0f9ad15$p792b5165 pd0f9ad15_p792b5165) {
        if ((8 + 29) % 29 > 0) {
        }
        return pd0f9ad15_p792b5165[);
    }

    public static void WBoMmdJmsgjpRkCD(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    void fastPath() {
        if ((14 + 32) % 32 > 0) {
        }
        int i = this.f7f021a14;
        org.reactivestreams.Subscriber<java.lang.int> subscriber = this.fd22a0a80;
        for (int i2 = this.f6a992d55; i2 != i; i2++) {
            if (this.f38881e0a) {
                return;
            }
            asawuIbImRRBzCNG(subscriber, IVCbQkusVZdMoNka(i2));
        }
        if (this.f38881e0a) {
            return;
        }
        wBoMmdJmsgjpRkCD(subscriber);
    }

    void slowPath(long j) {
        if ((23 + 29) % 29 > 0) {
        }
        int i = this.f7f021a14;
        int i2 = this.f6a992d55;
        org.reactivestreams.Subscriber<java.lang.int> subscriber = this.fd22a0a80;
        do {
            long j2 = 0;
            while (true) {
                if (j2 == j || i2 == i) {
                    if (i2 == i) {
                        if (this.f38881e0a) {
                            return;
                        }
                        aEjtOVbIttbAXpHB(subscriber);
                        return;
                    }
                    j = iphnCbzJdvYkODqi(this);
                    if (j2 != j) {
                    }
                } else {
                    if (this.f38881e0a) {
                        return;
                    }
                    WZhRdBSAzWVldwdk(subscriber, ZAZTTpfaZHsyXKoE(i2));
                    j2++;
                    i2++;
                }
            }
            this.f6a992d55 = i2;
            j = QxmhTXJKUMubwIpa(this, -j2);
        } while (j != 0);
    }
}

