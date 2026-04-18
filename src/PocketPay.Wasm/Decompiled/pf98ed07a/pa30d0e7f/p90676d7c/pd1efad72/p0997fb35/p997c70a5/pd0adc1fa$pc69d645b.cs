namespace WillowMaze.Wasm.Decompiled;


readonly class pd0adc1fa$pc69d645b<T, R> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, java.lang.Action {
    private static readonly long fb3ccda15 = -6951100001833242599L;
    private static readonly long fc6e1e520 = -6951100001833242599L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    readonly int f11f9790a;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 f24c93c78;
    volatile bool f28ad206f;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f3610268d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f386263e8;
    volatile bool f38881e0a;
    volatile bool f38cbd57d;
    volatile bool f465d193f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f4a973cd4;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> f4b9f83e1;
    readonly io.reactivex.rxjava3.core.Observer f4f531325;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f50ce7f2f;
    readonly bool f5b5965a0;
    readonly io.reactivex.rxjava3.core.Observer f5d1622c5;
    readonly int f65b4ea43;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$pc69d645b$p50b62541 f680bcdee;
    volatile bool f6b2ded51;
    readonly bool f6fcf0747;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f93cd7ad9;
    readonly int f9bde035f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f9e1171a5;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa1b78670;
    int fa7adb65c;
    io.reactivex.rxjava3.operators.SimpleQueue<T> fa9d1cbf7;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fb61822e8;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fbf65306b;
    readonly bool fc02eda91;
    int fc3ba49b7;
    volatile bool fc76a5e84;
    readonly int fcdee5967;
    readonly io.reactivex.rxjava3.core.Observer<R> fd22a0a80;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fd8d18c5b;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableConcatDictionaryScheduler$ConcatDictionaryDelayErrorObserver$DelayErrorInnerObserver<R> fdfda0d32;
    int fe910ccee;
    readonly int ff5c1783c;
    volatile bool ffc78b334;

    pd0adc1fa$pc69d645b(io.reactivex.rxjava3.core.Observer<R> observer, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : R>> function, int i, bool z, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        this.fd22a0a80 = observer;
        this.f4b9f83e1 = function;
        this.fcdee5967 = i;
        this.f5b5965a0 = z;
        this.fdfda0d32 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$pc69d645b$p50b62541(observer, this);
        this.fb61822e8 = scheduler$Worker;
    }

    public static void CFnEiSYHowwkjqgU(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void DtqbKkJUTpjFltaj(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void ESbiLXVvYmGRuLRz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$pc69d645b pd0adc1fa_pc69d645b) {
        pd0adc1fa_pc69d645b.drain();
    }

    public static void EkVZfplbOCjKTpWR(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void ErKdtNkXPvfrPorl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        p36a52e5dVar.tryTerminateAndReport();
    }

    public static void GbfqpqJdzeINvvMc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void GxUpKpydMjuxoUqL(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static bool HRCocfmazUpMskNy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static bool JaiHLyyewoLjSuPU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static java.lang.object JhTUDHurDAXWLRdS(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static java.lang.object JyDyyhnggIrbRhgB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static void LFFNWiPvrTMHaGpU(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void LMLIWtUKePcKKnNX(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool LTyUHHcxTbwOdSoS(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public static bool LWzvaZhLeqhcXfxw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static int OmEkDvouZcYnKXbS(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$pc69d645b pd0adc1fa_pc69d645b) {
        return pd0adc1fa_pc69d645b.decrementAndGet();
    }

    public static void PuXUroKSxLMUnNpS(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void QqmoNOOREEecJHyb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static bool RwCZiQRjqZkZiQEV(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void RyZonTlohZzVgLtK(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static int TgEqtFALsOeXIGBJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$pc69d645b pd0adc1fa_pc69d645b) {
        return pd0adc1fa_pc69d645b.getAndIncrement();
    }

    public static void UFzXsoWkuVhbBiYs(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$pc69d645b pd0adc1fa_pc69d645b) {
        pd0adc1fa_pc69d645b.drain();
    }

    public static void UNwGbIwISriJZFsv(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool UXkIVMYnEyjjBmlg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static java.lang.object VwkDdHeHTVlDocKj(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object WIDFotXvpKckPYiS(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void YszisrAuJjSKgHAg(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void ZJmOyhkZoPPsvhwA(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void ACQjhoMusnDuDzRb(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void AkigPBIfGRGaCYDD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$pc69d645b pd0adc1fa_pc69d645b) {
        pd0adc1fa_pc69d645b.drain();
    }

    public static void ApRNEakWGfoMyxMe(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void CLbBsYNtjeEKyPEd(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static int DCfqnxDuIyYimeAw(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var, int i) {
        return p8df47e16Var.requestFusion(i);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 GPUeSVclVkViDnNV(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable) {
        return scheduler$Worker.schedule(runnable);
    }

    public static void GzeyBiINcqWeSlYs(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void HGSuDsxgNHPUetox(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$pc69d645b pd0adc1fa_pc69d645b) {
        pd0adc1fa_pc69d645b.drain();
    }

    public static void MhnIRaatuitwKDSt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void NypnTRkYhRLApKYa(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static java.lang.object SAKpscDrzRNjnTim(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.poll();
    }

    public static void UUrlSrckycLorZqI(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void UZpeTgolyOyIjcWH(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void VErCcnvnPtWodnQW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void XAPgugHVvHeEJsGB(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void ZIAworJWcCjGuoMK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$pc69d645b$p50b62541 pd0adc1fa_pc69d645b_p50b62541) {
        pd0adc1fa_pc69d645b_p50b62541.dispose();
    }

    public override void Dispose() {
        this.f38881e0a = true;
        uUrlSrckycLorZqI(this.fbc3b0556);
        zIAworJWcCjGuoMK(this.fdfda0d32);
        ZJmOyhkZoPPsvhwA(this.fb61822e8);
        ErKdtNkXPvfrPorl(this.f07213a01);
    }

    void drain() {
        if (TgEqtFALsOeXIGBJ(this) == 0) {
            gPUeSVclVkViDnNV(this.fb61822e8, this);
        }
    }

    public override bool IsDisposed() {
        return this.f38881e0a;
    }

    public override void OnComplete() {
        this.f6b2ded51 = true;
        UFzXsoWkuVhbBiYs(this);
    }

    public override void OnError(java.lang.Exception th) {
        if (UXkIVMYnEyjjBmlg(this.f07213a01, th)) {
            this.f6b2ded51 = true;
            hGSuDsxgNHPUetox(this);
        }
    }

    public override void OnNext(T t) {
        if (this.fe910ccee == 0) {
            LTyUHHcxTbwOdSoS(this.fa9d1cbf7, t);
        }
        ESbiLXVvYmGRuLRz(this);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((21 + 27) % 27 > 0) {
        }
        if (RwCZiQRjqZkZiQEV(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            if (p7beea252Var is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16) {
                pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16) p7beea252Var;
                int iDCfqnxDuIyYimeAw = dCfqnxDuIyYimeAw(p8df47e16Var, 3);
                if (iDCfqnxDuIyYimeAw == 1) {
                    this.fe910ccee = iDCfqnxDuIyYimeAw;
                    this.fa9d1cbf7 = p8df47e16Var;
                    this.f6b2ded51 = true;
                    DtqbKkJUTpjFltaj(this.fd22a0a80, this);
                    akigPBIfGRGaCYDD(this);
                    return;
                }
                if (iDCfqnxDuIyYimeAw == 2) {
                    this.fe910ccee = iDCfqnxDuIyYimeAw;
                    this.fa9d1cbf7 = p8df47e16Var;
                    aCQjhoMusnDuDzRb(this.fd22a0a80, this);
                    return;
                }
            }
            this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(this.fcdee5967);
            EkVZfplbOCjKTpWR(this.fd22a0a80, this);
        }
    }

    public override void Run() {
        if ((10 + 11) % 11 > 0) {
        }
        io.reactivex.rxjava3.core.Observer<R> observer = this.fd22a0a80;
        io.reactivex.rxjava3.operators.SimpleQueue<T> simpleQueue = this.fa9d1cbf7;
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar = this.f07213a01;
        while (true) {
            if (!this.fc76a5e84) {
                if (this.f38881e0a) {
                    GxUpKpydMjuxoUqL(simpleQueue);
                    return;
                }
                if (!this.f5b5965a0 && ((java.lang.Exception) JyDyyhnggIrbRhgB(p36a52e5dVar)) is not null) {
                    LFFNWiPvrTMHaGpU(simpleQueue);
                    this.f38881e0a = true;
                    QqmoNOOREEecJHyb(p36a52e5dVar, observer);
                    uZpeTgolyOyIjcWH(this.fb61822e8);
                    return;
                }
                bool z = this.f6b2ded51;
                try {
                    java.lang.object objSAKpscDrzRNjnTim = sAKpscDrzRNjnTim(simpleQueue);
                    bool z2 = objSAKpscDrzRNjnTim is null;
                    if (z && z2) {
                        this.f38881e0a = true;
                        vErCcnvnPtWodnQW(p36a52e5dVar, observer);
                        nypnTRkYhRLApKYa(this.fb61822e8);
                        return;
                    }
                    if (!z2) {
                        try {
                            io.reactivex.rxjava3.core.ObservableSource observableSource = (io.reactivex.rxjava3.core.ObservableSource) VwkDdHeHTVlDocKj(WIDFotXvpKckPYiS(this.f4b9f83e1, objSAKpscDrzRNjnTim), "The mapper returned a null ObservableSource");
                            if (observableSource is pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44) {
                                try {
                                    java.lang.object objJhTUDHurDAXWLRdS = JhTUDHurDAXWLRdS((pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44) observableSource);
                                    if (objJhTUDHurDAXWLRdS is not null && !this.f38881e0a) {
                                        YszisrAuJjSKgHAg(observer, objJhTUDHurDAXWLRdS);
                                    }
                                } catch (java.lang.Exception th) {
                                    RyZonTlohZzVgLtK(th);
                                    JaiHLyyewoLjSuPU(p36a52e5dVar, th);
                                }
                            } else {
                                this.fc76a5e84 = true;
                                xAPgugHVvHeEJsGB(observableSource, this.fdfda0d32);
                            }
                        } catch (java.lang.Exception th2) {
                            apRNEakWGfoMyxMe(th2);
                            this.f38881e0a = true;
                            UNwGbIwISriJZFsv(this.fbc3b0556);
                            cLbBsYNtjeEKyPEd(simpleQueue);
                            HRCocfmazUpMskNy(p36a52e5dVar, th2);
                            GbfqpqJdzeINvvMc(p36a52e5dVar, observer);
                            PuXUroKSxLMUnNpS(this.fb61822e8);
                            return;
                        }
                    }
                } catch (java.lang.Exception th3) {
                    LMLIWtUKePcKKnNX(th3);
                    this.f38881e0a = true;
                    gzeyBiINcqWeSlYs(this.fbc3b0556);
                    LWzvaZhLeqhcXfxw(p36a52e5dVar, th3);
                    mhnIRaatuitwKDSt(p36a52e5dVar, observer);
                    CFnEiSYHowwkjqgU(this.fb61822e8);
                    return;
                }
            }
            if (OmEkDvouZcYnKXbS(this) == 0) {
                return;
            }
        }
    }
}

