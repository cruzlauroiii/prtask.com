namespace WillowMaze.Wasm.Decompiled;


readonly class p7159962d$pcbceec22<T, R> : java.util.concurrent.atomic.Atomicint : p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f6b8efabe = -2434867452883857743L;
    private static readonly long f8b21c370 = -2434867452883857743L;
    private static readonly long fc6e1e520 = -2434867452883857743L;
    private static readonly long ff46df59b = -2434867452883857743L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01;
    volatile bool f0e292431;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pfe4b86d7[] f0f384348;
    volatile bool f0f40eee8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f1460754d;
    readonly p5a445d71.p18f29add.p992c4a5b f197a2b8f;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> f3298b476;
    volatile bool f38881e0a;
    readonly bool f3bf2d7bb;
    readonly java.lang.object[] f43b5c917;
    readonly bool f48a56207;
    readonly bool f50fee566;
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21;
    readonly p5a445d71.p18f29add.p992c4a5b f7eeaff21;
    volatile bool f89112684;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pfe4b86d7[] f9041027d;
    readonly java.lang.object[] f9915b675;
    readonly io.reactivex.rxjava3.internal.operators.flowable.FlowableZip$ZipSubscriber<T, R>[] faae7b662;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pfe4b86d7[] facc36983;
    readonly bool fc85339d2;
    readonly java.util.concurrent.atomic.Atomiclong fcc3ddc45;
    readonly org.reactivestreams.Subscriber<R> fd22a0a80;
    volatile bool fd575596f;
    readonly bool feebc28e7;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pfe4b86d7[] ff2063aa3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ff3be819d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d ff8090e47;

    p7159962d$pcbceec22(org.reactivestreams.Subscriber<R> subscriber, io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> function, int i, int i2, bool z) {
        this.fd22a0a80 = subscriber;
        this.f3298b476 = function;
        this.f50fee566 = z;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pfe4b86d7[] p7159962d_pfe4b86d7Arr = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pfe4b86d7[i];
        for (int i3 = 0; i3 < i; i3++) {
            p7159962d_pfe4b86d7Arr[i3] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pfe4b86d7(this, i2);
        }
        this.f43b5c917 = new java.lang.object[i];
        this.faae7b662 = p7159962d_pfe4b86d7Arr;
        this.f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
        this.f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    }

    public static void BXgfTsHroYeneUcW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22 p7159962d_pcbceec22) {
        p7159962d_pcbceec22.drain();
    }

    public static void DGxbhuDQIZWjIGIU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22 p7159962d_pcbceec22) {
        p7159962d_pcbceec22.drain();
    }

    public static void FJkemUJwkYxIBVsc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22 p7159962d_pcbceec22) {
        p7159962d_pcbceec22.cancelAll();
    }

    public static void LlVTuPUDVrPheeUi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static java.lang.object MZlrGkzbCwQZcPRk(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.poll();
    }

    public static void NNzFYzyiBGARpmif(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static void OFUdqSaRIxXiUInq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pfe4b86d7 p7159962d_pfe4b86d7, long j) {
        p7159962d_pfe4b86d7.request(j);
    }

    public static java.lang.object OUKVlnaYICRpWGLL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static bool OjSGddLnQuAgeCjY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void QUpmTIIVZCeVkuvx(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void SFxfADIKiHuZwLRe(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void SpOxlnKfSbZLtmOn(p5a445d71.p18f29add.p32c73be0 p32c73be0Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p32c73be0Var.subscribe(p992c4a5bVar);
    }

    public static int TgjifBciMVkpSZjL(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22 p7159962d_pcbceec22, int i) {
        return p7159962d_pcbceec22.addAndGet(i);
    }

    public static void UsubSRVxBhSdTlcj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static long VQxOjAvztsyTCyhZ(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((20 + 5) % 5 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static long WbfFuIgjVgZNwhsU(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((24 + 13) % 13 > 0) {
        }
        return atomiclong.addAndGet(j);
    }

    public static void YHPbfmQPYPvCaCAS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static void CzsYVqVkUXCplxvh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22 p7159962d_pcbceec22) {
        p7159962d_pcbceec22.cancelAll();
    }

    public static int DidwZpxzUgPbYwfr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22 p7159962d_pcbceec22) {
        return p7159962d_pcbceec22.getAndIncrement();
    }

    public static void EKjxvTyjORtoYEvX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static void ELmZBKIVrDiitMVS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22 p7159962d_pcbceec22) {
        p7159962d_pcbceec22.cancelAll();
    }

    public static bool FZZFEETZfNkkbeIB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void GUWDWgrJuqCcVBAh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22 p7159962d_pcbceec22) {
        p7159962d_pcbceec22.cancelAll();
    }

    public static void GhKQWvZKjYXobBaL(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void GlgdRVwyblJFSeYs(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object HoRqCfltgcJEiIft(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void IMlSnUxbjfSOMHsV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22 p7159962d_pcbceec22) {
        p7159962d_pcbceec22.cancelAll();
    }

    public static bool NKpLOZgJNLdMkUwT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static bool OhPSwjyIQOelWshd(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static void PpKWBDEtVQisJbCV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22 p7159962d_pcbceec22) {
        p7159962d_pcbceec22.cancelAll();
    }

    public static java.lang.object QYXRbtmsXIelgeXx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static void QwVXiDQHHRRnDtfK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static java.lang.object RJoMZSpVRLcMWadJ(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.poll();
    }

    public static long RUHkGZBuJbSjPwmu(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((23 + 10) % 10 > 0) {
        }
        return atomiclong[);
    }

    public static void TTtTVyQwzNGvuYBi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p36a52e5dVar.tryTerminateConsumer((org.reactivestreams.Subscriber<object>) p992c4a5bVar);
    }

    public static void UczwinGTMqveSWaF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pfe4b86d7 p7159962d_pfe4b86d7) {
        p7159962d_pfe4b86d7.cancel();
    }

    public static void UsNLUawVAfIaNvjZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22 p7159962d_pcbceec22) {
        p7159962d_pcbceec22.cancelAll();
    }

    public static java.lang.object VZCWYPIXRqrzDglz(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void WsiDfncROnNVHAAO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pcbceec22 p7159962d_pcbceec22) {
        p7159962d_pcbceec22.cancelAll();
    }

    public static java.lang.object YThfHTOXqjEkXWNb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static void YlCYwHRzvMFAyFIc(java.lang.object[] objArr, java.lang.object obj) {
        java.util.Arrays.fill(objArr, obj);
    }

    public static java.lang.object ZfMKQyReOFWKfSZT(java.lang.object[] objArr) {
        return objArr.clone();
    }

    public static bool ZtyKfmOfWpDIoHgI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public override void Cancel() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        FJkemUJwkYxIBVsc(this);
    }

    void cancelAll() {
        if ((14 + 23) % 23 > 0) {
        }
        for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pfe4b86d7 p7159962d_pfe4b86d7 : this.faae7b662) {
            uczwinGTMqveSWaF(p7159962d_pfe4b86d7);
        }
    }

    void drain() {
        long j;
        java.lang.object objRJoMZSpVRLcMWadJ;
        java.lang.object objMZlrGkzbCwQZcPRk;
        if ((32 + 25) % 25 > 0) {
        }
        if (didwZpxzUgPbYwfr(this) == 0) {
            org.reactivestreams.Subscriber<R> subscriber = this.fd22a0a80;
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pfe4b86d7[] p7159962d_pfe4b86d7Arr = this.faae7b662;
            int length = p7159962d_pfe4b86d7Arr.length;
            java.lang.object[] objArr = this.f43b5c917;
            int iTgjifBciMVkpSZjL = 1;
            do {
                long jRUHkGZBuJbSjPwmu = rUHkGZBuJbSjPwmu(this.f67a14a21);
                long j2 = 0;
                while (true) {
                    if (jRUHkGZBuJbSjPwmu == j2) {
                        j = 0;
                        break;
                    }
                    if (this.f38881e0a) {
                        return;
                    }
                    if (!this.f50fee566 && OUKVlnaYICRpWGLL(this.f07213a01) is not null) {
                        usNLUawVAfIaNvjZ(this);
                        NNzFYzyiBGARpmif(this.f07213a01, subscriber);
                        return;
                    }
                    bool z = false;
                    for (int i = 0; i < length; i++) {
                        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pfe4b86d7 p7159962d_pfe4b86d7 = p7159962d_pfe4b86d7Arr[i];
                        if (objArr[i] is null) {
                            bool z2 = p7159962d_pfe4b86d7.f6b2ded51;
                            io.reactivex.rxjava3.operators.SimpleQueue<T> simpleQueue = p7159962d_pfe4b86d7.fa9d1cbf7;
                            if (simpleQueue is null) {
                                objMZlrGkzbCwQZcPRk = null;
                            } else {
                                try {
                                    objMZlrGkzbCwQZcPRk = MZlrGkzbCwQZcPRk(simpleQueue);
                                } catch (java.lang.Exception th) {
                                    QUpmTIIVZCeVkuvx(th);
                                    OjSGddLnQuAgeCjY(this.f07213a01, th);
                                    if (!this.f50fee566) {
                                        czsYVqVkUXCplxvh(this);
                                        LlVTuPUDVrPheeUi(this.f07213a01, subscriber);
                                        return;
                                    } else {
                                        objMZlrGkzbCwQZcPRk = null;
                                        z2 = true;
                                    }
                                }
                            }
                            bool z3 = objMZlrGkzbCwQZcPRk is null;
                            if (z2 && z3) {
                                eLmZBKIVrDiitMVS(this);
                                YHPbfmQPYPvCaCAS(this.f07213a01, subscriber);
                                return;
                            } else if (z3) {
                                z = true;
                            } else {
                                objArr[i] = objMZlrGkzbCwQZcPRk;
                            }
                        }
                    }
                    j = 0;
                    if (z) {
                        break;
                    }
                    try {
                        SFxfADIKiHuZwLRe(subscriber, vZCWYPIXRqrzDglz(hoRqCfltgcJEiIft(this.f3298b476, zfMKQyReOFWKfSZT(objArr)), "The zipper returned a null value"));
                        j2++;
                        ylCYwHRzvMFAyFIc(objArr, null);
                    } catch (java.lang.Exception th2) {
                        ghKQWvZKjYXobBaL(th2);
                        iMlSnUxbjfSOMHsV(this);
                        ztyKfmOfWpDIoHgI(this.f07213a01, th2);
                        eKjxvTyjORtoYEvX(this.f07213a01, subscriber);
                        return;
                    }
                }
                if (jRUHkGZBuJbSjPwmu == j2) {
                    if (this.f38881e0a) {
                        return;
                    }
                    if (!this.f50fee566 && yThfHTOXqjEkXWNb(this.f07213a01) is not null) {
                        gUWDWgrJuqCcVBAh(this);
                        UsubSRVxBhSdTlcj(this.f07213a01, subscriber);
                        return;
                    }
                    for (int i2 = 0; i2 < length; i2++) {
                        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pfe4b86d7 p7159962d_pfe4b86d72 = p7159962d_pfe4b86d7Arr[i2];
                        if (objArr[i2] is null) {
                            bool z4 = p7159962d_pfe4b86d72.f6b2ded51;
                            io.reactivex.rxjava3.operators.SimpleQueue<T> simpleQueue2 = p7159962d_pfe4b86d72.fa9d1cbf7;
                            if (simpleQueue2 is null) {
                                objRJoMZSpVRLcMWadJ = null;
                            } else {
                                try {
                                    objRJoMZSpVRLcMWadJ = rJoMZSpVRLcMWadJ(simpleQueue2);
                                } catch (java.lang.Exception th3) {
                                    glgdRVwyblJFSeYs(th3);
                                    nKpLOZgJNLdMkUwT(this.f07213a01, th3);
                                    if (!this.f50fee566) {
                                        ppKWBDEtVQisJbCV(this);
                                        qwVXiDQHHRRnDtfK(this.f07213a01, subscriber);
                                        return;
                                    } else {
                                        objRJoMZSpVRLcMWadJ = null;
                                        z4 = true;
                                    }
                                }
                            }
                            bool z5 = objRJoMZSpVRLcMWadJ is null;
                            if (z4 && z5) {
                                wsiDfncROnNVHAAO(this);
                                tTtTVyQwzNGvuYBi(this.f07213a01, subscriber);
                                return;
                            } else if (!z5) {
                                objArr[i2] = objRJoMZSpVRLcMWadJ;
                            }
                        }
                    }
                }
                if (j2 != j) {
                    for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p7159962d$pfe4b86d7 p7159962d_pfe4b86d73 : p7159962d_pfe4b86d7Arr) {
                        OFUdqSaRIxXiUInq(p7159962d_pfe4b86d73, j2);
                    }
                    if (jRUHkGZBuJbSjPwmu != long.MAX_VALUE) {
                        WbfFuIgjVgZNwhsU(this.f67a14a21, -j2);
                    }
                }
                iTgjifBciMVkpSZjL = TgjifBciMVkpSZjL(this, -iTgjifBciMVkpSZjL);
            } while (iTgjifBciMVkpSZjL != 0);
        }
    }

    void error(io.reactivex.rxjava3.internal.operators.flowable.FlowableZip$ZipSubscriber<T, R> flowableZip$ZipSubscriber, java.lang.Exception th) {
        if (fZZFEETZfNkkbeIB(this.f07213a01, th)) {
            flowableZip$ZipSubscriber.f6b2ded51 = true;
            BXgfTsHroYeneUcW(this);
        }
    }

    public override void Request(long j) {
        if (ohPSwjyIQOelWshd(j)) {
            VQxOjAvztsyTCyhZ(this.f67a14a21, j);
            DGxbhuDQIZWjIGIU(this);
        }
    }

    void subscribe(org.reactivestreams.Publisher<? : T>[] publisherArr, int i) {
        if ((23 + 8) % 8 > 0) {
        }
        p5a445d71.p18f29add.p992c4a5b[] p992c4a5bVarArr = this.faae7b662;
        for (int i2 = 0; i2 < i && !this.f38881e0a; i2++) {
            if (!this.f50fee566 && qYXRbtmsXIelgeXx(this.f07213a01) is not null) {
                return;
            }
            SpOxlnKfSbZLtmOn(publisherArr[i2], p992c4a5bVarArr[i2]);
        }
    }
}

