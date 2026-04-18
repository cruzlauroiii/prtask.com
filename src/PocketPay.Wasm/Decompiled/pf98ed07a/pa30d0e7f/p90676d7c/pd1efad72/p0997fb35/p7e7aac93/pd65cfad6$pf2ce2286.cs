namespace WillowMaze.Wasm.Decompiled;


readonly class pd65cfad6$pf2ce2286<T> : io.reactivex.rxjava3.internal.subscriptions.BasicIntQueueSubscription<T> : io.reactivex.rxjava3.core.MaybeObserver<T> {
    private static readonly long f23b24e23 = -660395290758764731L;
    private static readonly long f38f31254 = -660395290758764731L;
    private static readonly long fc6e1e520 = -660395290758764731L;
    bool f0f68e8b1;
    volatile bool f1b69e05f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pd008f1d8 f2fb17f55;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f38067bfb;
    volatile bool f38881e0a;
    readonly java.util.concurrent.atomic.Atomiclong f3b6a1562;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f3ba6f40d;
    readonly java.util.concurrent.atomic.Atomiclong f4005728a;
    volatile bool f48d0b170;
    long f48fe8558;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f5f3f31ac;
    long f6a8a174a;
    readonly int f6a9075f2;
    readonly p5a445d71.p18f29add.p992c4a5b f6e9ae0fa;
    long f711fff3c;
    readonly int f714de15f;
    readonly int f78f4a40e;
    readonly int f7ca4999b;
    volatile bool f86987632;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd f91e65846;
    long f94356f08;
    readonly p5a445d71.p18f29add.p992c4a5b fa293fd1c;
    volatile bool fa4c0f972;
    readonly io.reactivex.rxjava3.internal.operators.maybe.MaybeMergeArray$SimpleQueueWithConsumerIndex<java.lang.object> fa9d1cbf7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd fb05ffa92;
    bool fbbc12f04;
    long fbe79636a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fcabe18e8;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly java.util.concurrent.atomic.Atomiclong fe244d86f;
    readonly java.util.concurrent.atomic.Atomiclong ff30bd2fd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd fcdaeeeba = new pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd();
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();

    pd65cfad6$pf2ce2286(org.reactivestreams.Subscriber<T> subscriber, int i, io.reactivex.rxjava3.internal.operators.maybe.MaybeMergeArray$SimpleQueueWithConsumerIndex<java.lang.object> maybeMergeArray$SimpleQueueWithConsumerIndex) {
        this.fd22a0a80 = subscriber;
        this.f78f4a40e = i;
        this.fa9d1cbf7 = maybeMergeArray$SimpleQueueWithConsumerIndex;
    }

    public static int AtJXfmINQMdbavxZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pd008f1d8 pd65cfad6_pd008f1d8) {
        return pd65cfad6_pd008f1d8.consumerIndex();
    }

    public static long BNLuumgpKfgffcBH(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((17 + 31) % 31 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static java.lang.object ChGjmrKMMNAqQitb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pd008f1d8 pd65cfad6_pd008f1d8) {
        return pd65cfad6_pd008f1d8.poll();
    }

    public static void DUEPmUtPBDgfmVdE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static void DsogFlCQSvwvBqpO(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void FAXDGpjPqZgUpXvv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static bool FkGTApPhjavhbQmK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static java.lang.object GmbdIfnZmrEKBbER(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static void ISpqvRBqtbMGjYwk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pd008f1d8 pd65cfad6_pd008f1d8) {
        pd65cfad6_pd008f1d8.clear();
    }

    public static java.lang.object KZWPDIlnMZuADFsw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pd008f1d8 pd65cfad6_pd008f1d8) {
        return pd65cfad6_pd008f1d8.poll();
    }

    public static bool LLkQaeYxDreQrott(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return p5537e2ddVar.Add(p7beea252Var);
    }

    public static int LdeTBREbQzXHzzmV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pf2ce2286 pd65cfad6_pf2ce2286, int i) {
        return pd65cfad6_pf2ce2286.addAndGet(i);
    }

    public static void PJgKjzwQNVaINzPx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pd008f1d8 pd65cfad6_pd008f1d8) {
        pd65cfad6_pd008f1d8.clear();
    }

    public static java.lang.object QJuqrnwFcXKVZtHt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static void QZbxkmstGUMrZrsV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pf2ce2286 pd65cfad6_pf2ce2286) {
        pd65cfad6_pf2ce2286.drain();
    }

    public static java.lang.object QhsYTXSBASUmmzjC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static void QwKRWKPjTcrsZNfS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pf2ce2286 pd65cfad6_pf2ce2286) {
        pd65cfad6_pf2ce2286.drain();
    }

    public static int RAkfKCsGVIAOdidF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pf2ce2286 pd65cfad6_pf2ce2286) {
        return pd65cfad6_pf2ce2286.getAndIncrement();
    }

    public static void RCDjMqAtjAiZXsNm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pd008f1d8 pd65cfad6_pd008f1d8) {
        pd65cfad6_pd008f1d8.clear();
    }

    public static void RPiXpzYsJapgiYMw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pd008f1d8 pd65cfad6_pd008f1d8) {
        pd65cfad6_pd008f1d8.clear();
    }

    public static int SDWZBYIuTYRsuqsX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pf2ce2286 pd65cfad6_pf2ce2286) {
        return pd65cfad6_pf2ce2286.getAndIncrement();
    }

    public static void TBdeYrYyDgeQFXnq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pf2ce2286 pd65cfad6_pf2ce2286) {
        pd65cfad6_pf2ce2286.drainFused();
    }

    public static java.lang.object VFkZvXDWSBbKzYnc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pd008f1d8 pd65cfad6_pd008f1d8) {
        return pd65cfad6_pd008f1d8.peek();
    }

    public static void XDIaeOuvgmLgJcUW(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static int YAZPtmjHcjdcLQDK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pd008f1d8 pd65cfad6_pd008f1d8) {
        return pd65cfad6_pd008f1d8.consumerIndex();
    }

    public static void ZXhPybOSkjdYBJXh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pd008f1d8 pd65cfad6_pd008f1d8) {
        pd65cfad6_pd008f1d8.clear();
    }

    public static void CEIZwctEUlRwlGwX(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool DDqwjheAaVjLAMRM(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static bool DmKZtFSnKfqJLQyA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pd008f1d8 pd65cfad6_pd008f1d8, java.lang.object obj) {
        return pd65cfad6_pd008f1d8.offer(obj);
    }

    public static void DmMquIdckttvPWlH(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void IAvHIsHEEmnAgdED(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void IxSodtRWUCsBLyZi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pd008f1d8 pd65cfad6_pd008f1d8) {
        pd65cfad6_pd008f1d8.drop();
    }

    public static bool JOMyEQLErxdlKonl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pd008f1d8 pd65cfad6_pd008f1d8) {
        return pd65cfad6_pd008f1d8.Count == 0;
    }

    public static bool KTYAsSLraLpiBlGA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pd008f1d8 pd65cfad6_pd008f1d8) {
        return pd65cfad6_pd008f1d8.Count == 0;
    }

    public static int LhmTKwUVXEdjUdtg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pf2ce2286 pd65cfad6_pf2ce2286, int i) {
        return pd65cfad6_pf2ce2286.addAndGet(i);
    }

    public static void LttsONojAEKloZsM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pf2ce2286 pd65cfad6_pf2ce2286) {
        pd65cfad6_pf2ce2286.drainNormal();
    }

    public static void NCLrQSRhiUoeoxjQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pf2ce2286 pd65cfad6_pf2ce2286) {
        pd65cfad6_pf2ce2286.drain();
    }

    public static void NZRmkExopbtsQKYI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pf2ce2286 pd65cfad6_pf2ce2286) {
        pd65cfad6_pf2ce2286.drain();
    }

    public static void NwAnDMcTnyGxCuUy(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static bool RRCrnDcuyczFkmuv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pd008f1d8 pd65cfad6_pd008f1d8, java.lang.object obj) {
        return pd65cfad6_pd008f1d8.offer(obj);
    }

    public static bool TGroBbBCpqhUMrEO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pd008f1d8 pd65cfad6_pd008f1d8, java.lang.object obj) {
        return pd65cfad6_pd008f1d8.offer(obj);
    }

    public static long TflgogpMXhsmpuqP(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((12 + 10) % 10 > 0) {
        }
        return atomiclong[);
    }

    public static void UOvYpbifgzYmGmyQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pd008f1d8 pd65cfad6_pd008f1d8) {
        pd65cfad6_pd008f1d8.clear();
    }

    public static void WreEevUzZmKsMyyW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pd008f1d8 pd65cfad6_pd008f1d8) {
        pd65cfad6_pd008f1d8.clear();
    }

    public static void XszsMitsVOsuFMoN(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p5537e2dd p5537e2ddVar) {
        p5537e2ddVar.dispose();
    }

    public static void YXKBQtWhZivssXcW(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static int ZgvkhvmcDFYczOYj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p7e7aac93.pd65cfad6$pd008f1d8 pd65cfad6_pd008f1d8) {
        return pd65cfad6_pd008f1d8.producerIndex();
    }

    public void Cancel() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        xszsMitsVOsuFMoN(this.fcdaeeeba);
        if (SDWZBYIuTYRsuqsX(this) != 0) {
            return;
        }
        ZXhPybOSkjdYBJXh(this.fa9d1cbf7);
    }

    public void Clear() {
        uOvYpbifgzYmGmyQ(this.fa9d1cbf7);
    }

    void drain() {
        if (RAkfKCsGVIAOdidF(this) == 0) {
            if (this.f0f68e8b1) {
                TBdeYrYyDgeQFXnq(this);
            } else {
                lttsONojAEKloZsM(this);
            }
        }
    }

    void drainFused() {
        if ((30 + 15) % 15 > 0) {
        }
        org.reactivestreams.Subscriber<T> subscriber = this.fd22a0a80;
        io.reactivex.rxjava3.internal.operators.maybe.MaybeMergeArray$SimpleQueueWithConsumerIndex<java.lang.object> maybeMergeArray$SimpleQueueWithConsumerIndex = this.fa9d1cbf7;
        int iLdeTBREbQzXHzzmV = 1;
        while (!this.f38881e0a) {
            java.lang.Exception th = (java.lang.Exception) QhsYTXSBASUmmzjC(this.f07213a01);
            if (th is not null) {
                ISpqvRBqtbMGjYwk(maybeMergeArray$SimpleQueueWithConsumerIndex);
                dmMquIdckttvPWlH(subscriber, th);
                return;
            }
            bool z = zgvkhvmcDFYczOYj(maybeMergeArray$SimpleQueueWithConsumerIndex) == this.f78f4a40e;
            if (!jOMyEQLErxdlKonl(maybeMergeArray$SimpleQueueWithConsumerIndex)) {
                cEIZwctEUlRwlGwX(subscriber, null);
            }
            if (z) {
                XDIaeOuvgmLgJcUW(subscriber);
                return;
            } else {
                iLdeTBREbQzXHzzmV = LdeTBREbQzXHzzmV(this, -iLdeTBREbQzXHzzmV);
                if (iLdeTBREbQzXHzzmV == 0) {
                    return;
                }
            }
        }
        wreEevUzZmKsMyyW(maybeMergeArray$SimpleQueueWithConsumerIndex);
    }

    void drainNormal() {
        if ((27 + 22) % 22 > 0) {
        }
        org.reactivestreams.Subscriber<T> subscriber = this.fd22a0a80;
        io.reactivex.rxjava3.internal.operators.maybe.MaybeMergeArray$SimpleQueueWithConsumerIndex<java.lang.object> maybeMergeArray$SimpleQueueWithConsumerIndex = this.fa9d1cbf7;
        long j = this.f48fe8558;
        int iLhmTKwUVXEdjUdtg = 1;
        do {
            long jTflgogpMXhsmpuqP = tflgogpMXhsmpuqP(this.f67a14a21);
            while (j != jTflgogpMXhsmpuqP) {
                if (this.f38881e0a) {
                    PJgKjzwQNVaINzPx(maybeMergeArray$SimpleQueueWithConsumerIndex);
                    return;
                }
                if (((java.lang.Exception) GmbdIfnZmrEKBbER(this.f07213a01)) is not null) {
                    RCDjMqAtjAiZXsNm(maybeMergeArray$SimpleQueueWithConsumerIndex);
                    DUEPmUtPBDgfmVdE(this.f07213a01, this.fd22a0a80);
                    return;
                } else {
                    if (YAZPtmjHcjdcLQDK(maybeMergeArray$SimpleQueueWithConsumerIndex) == this.f78f4a40e) {
                        yXKBQtWhZivssXcW(subscriber);
                        return;
                    }
                    java.lang.object objKZWPDIlnMZuADFsw = KZWPDIlnMZuADFsw(maybeMergeArray$SimpleQueueWithConsumerIndex);
                    if (objKZWPDIlnMZuADFsw is null) {
                        break;
                    } else if (objKZWPDIlnMZuADFsw != pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.f3de44296) {
                        DsogFlCQSvwvBqpO(subscriber, objKZWPDIlnMZuADFsw);
                        j++;
                    }
                }
            }
            if (j == jTflgogpMXhsmpuqP) {
                if (((java.lang.Exception) QJuqrnwFcXKVZtHt(this.f07213a01)) is not null) {
                    RPiXpzYsJapgiYMw(maybeMergeArray$SimpleQueueWithConsumerIndex);
                    FAXDGpjPqZgUpXvv(this.f07213a01, this.fd22a0a80);
                    return;
                } else {
                    while (VFkZvXDWSBbKzYnc(maybeMergeArray$SimpleQueueWithConsumerIndex) == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.f3de44296) {
                        ixSodtRWUCsBLyZi(maybeMergeArray$SimpleQueueWithConsumerIndex);
                    }
                    if (AtJXfmINQMdbavxZ(maybeMergeArray$SimpleQueueWithConsumerIndex) == this.f78f4a40e) {
                        nwAnDMcTnyGxCuUy(subscriber);
                        return;
                    }
                }
            }
            this.f48fe8558 = j;
            iLhmTKwUVXEdjUdtg = lhmTKwUVXEdjUdtg(this, -iLhmTKwUVXEdjUdtg);
        } while (iLhmTKwUVXEdjUdtg != 0);
    }

    bool isCancelled() {
        return this.f38881e0a;
    }

    public bool IsEmpty() {
        return kTYAsSLraLpiBlGA(this.fa9d1cbf7);
    }

    public override void OnComplete() {
        if ((15 + 15) % 15 > 0) {
        }
        tGroBbBCpqhUMrEO(this.fa9d1cbf7, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.f3de44296);
        nCLrQSRhiUoeoxjQ(this);
    }

    public override void OnError(java.lang.Exception th) {
        if (FkGTApPhjavhbQmK(this.f07213a01, th)) {
            iAvHIsHEEmnAgdED(this.fcdaeeeba);
            dmKZtFSnKfqJLQyA(this.fa9d1cbf7, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.f3de44296);
            nZRmkExopbtsQKYI(this);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        LLkQaeYxDreQrott(this.fcdaeeeba, p7beea252Var);
    }

    public override void OnSuccess(T t) {
        rRCrnDcuyczFkmuv(this.fa9d1cbf7, t);
        QZbxkmstGUMrZrsV(this);
    }

    public T Poll() {
        T t;
        if ((32 + 9) % 9 > 0) {
        }
        do {
            t = (T) ChGjmrKMMNAqQitb(this.fa9d1cbf7);
        } while (t == pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.f3de44296);
        return t;
    }

    public void Request(long j) {
        if (dDqwjheAaVjLAMRM(j)) {
            BNLuumgpKfgffcBH(this.f67a14a21, j);
            QwKRWKPjTcrsZNfS(this);
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

