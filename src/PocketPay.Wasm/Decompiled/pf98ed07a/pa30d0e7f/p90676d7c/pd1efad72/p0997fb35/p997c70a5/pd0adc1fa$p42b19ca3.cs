namespace WillowMaze.Wasm.Decompiled;


readonly class pd0adc1fa$p42b19ca3<T, U> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, java.lang.Action {
    private static readonly long f292386cf = 8828587559905699186L;
    private static readonly long fc6e1e520 = 8828587559905699186L;
    private static readonly long fe99d2e08 = 8828587559905699186L;
    int f06b7c4ff;
    volatile bool f11edcd35;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$p42b19ca3$p9192f42a f242fb9cd;
    int f2a5ff183;
    int f2c11399a;
    volatile bool f2c4ec590;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f31123f3d;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f34412c7a;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : U>> f4b9f83e1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$p42b19ca3$p9192f42a f52232310;
    int f54e67e34;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker f66aa925c;
    volatile bool f6b2ded51;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 f73b50f06;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 f81d666a5;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f8e6223e0;
    volatile bool f8ec57f6d;
    volatile bool f9a8b577b;
    volatile bool fa676420e;
    io.reactivex.rxjava3.operators.SimpleQueue<T> fa9d1cbf7;
    readonly io.reactivex.rxjava3.core.Observer faefeeda8;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fb45bf60e;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker fb61822e8;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 fbb9da6a5;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly int fc068ef1a;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 fc221002e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc4c514ae;
    volatile bool fc76a5e84;
    readonly int fcdee5967;
    readonly io.reactivex.rxjava3.core.Observer<U> fd22a0a80;
    volatile bool fd46d07aa;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$p42b19ca3$p9192f42a fdf1cd625;
    int fe48cacac;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableConcatDictionaryScheduler$ConcatDictionaryObserver$InnerObserver<U> fea97586b;
    readonly io.reactivex.rxjava3.core.Scheduler$Worker feb6ab25b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ff482d874;
    volatile bool ff8b2648d;
    volatile bool fff24e12f;

    pd0adc1fa$p42b19ca3(io.reactivex.rxjava3.core.Observer<U> observer, io.reactivex.rxjava3.functions.Function<? super T, ? : io.reactivex.rxjava3.core.ObservableSource<? : U>> function, int i, io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        this.fd22a0a80 = observer;
        this.f4b9f83e1 = function;
        this.fcdee5967 = i;
        this.fea97586b = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$p42b19ca3$p9192f42a(observer, this);
        this.fb61822e8 = scheduler$Worker;
    }

    public static void BawYntmhJhLjvbxI(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void BxPgUhdskmGxGKqZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$p42b19ca3 pd0adc1fa_p42b19ca3) {
        pd0adc1fa_p42b19ca3.drain();
    }

    public static void DafboIlFRigpDyEv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$p42b19ca3 pd0adc1fa_p42b19ca3) {
        pd0adc1fa_p42b19ca3.drain();
    }

    public static void FCYlKVXsJFZOagar(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void FIZvGnSMdKdBDoFx(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void IrKOPhqFMpzvatKI(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$p42b19ca3 pd0adc1fa_p42b19ca3) {
        pd0adc1fa_p42b19ca3.dispose();
    }

    public static int IyAYuVMyNsBraBwG(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var, int i) {
        return p8df47e16Var.requestFusion(i);
    }

    public static bool MPZSpHtDwkHGnzoB(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static void MkECpdviHHxgzENT(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void MsZPAgFmdEaSdFsq(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void OwOXmfXCpzRoCYvH(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void PgcPYFUsIWoWqOAW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$p42b19ca3 pd0adc1fa_p42b19ca3) {
        pd0adc1fa_p42b19ca3.drain();
    }

    public static void PkAAEejiznvtrCJV(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static void PoPmWMZsQYUwHIwL(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static void SqQxuAmVQDjhjhhC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$p42b19ca3 pd0adc1fa_p42b19ca3) {
        pd0adc1fa_p42b19ca3.dispose();
    }

    public static bool TAfLsCxksQWyaZpY(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public static void XmTYchZvHHMYzvqi(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void YNcWvrZApdOivhPH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$p42b19ca3 pd0adc1fa_p42b19ca3) {
        pd0adc1fa_p42b19ca3.drain();
    }

    public static int ZGjwHRnFQsvowHAc(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$p42b19ca3 pd0adc1fa_p42b19ca3) {
        return pd0adc1fa_p42b19ca3.decrementAndGet();
    }

    public static void GVOuvqhodpaVcIDx(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static void HeUGCHuHAPgNGRoF(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void JEauFYcjZimJKWsh(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 KzHgtKzNKbjyQzee(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker, java.lang.Action runnable) {
        return scheduler$Worker.schedule(runnable);
    }

    public static int MIVFsaoKyEtgNcGV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$p42b19ca3 pd0adc1fa_p42b19ca3) {
        return pd0adc1fa_p42b19ca3.getAndIncrement();
    }

    public static void OcTUSnHpDjCcmfjj(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void PMfJyvmPBreZFCMU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$p42b19ca3$p9192f42a pd0adc1fa_p42b19ca3_p9192f42a) {
        pd0adc1fa_p42b19ca3_p9192f42a.dispose();
    }

    public static void PxgwGksgwkHizciJ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static int QmUoYwMGkWnMKFtJ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$p42b19ca3 pd0adc1fa_p42b19ca3) {
        return pd0adc1fa_p42b19ca3.getAndIncrement();
    }

    public static java.lang.object QmoYbRrlNWytPduo(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.poll();
    }

    public static void SBxePNsmtfWUFTqa(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void SuQeQdhBaJgicvND(io.reactivex.rxjava3.core.Scheduler$Worker scheduler$Worker) {
        scheduler$Worker.dispose();
    }

    public static java.lang.object VgEwEgfpVhkEJeQz(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void VkhtOAuefSnrlJct(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void WIaFHvPVNugNlYXh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.pd0adc1fa$p42b19ca3 pd0adc1fa_p42b19ca3) {
        pd0adc1fa_p42b19ca3.dispose();
    }

    public static void WUFBnkFOTlmFTEho(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static java.lang.object XKuHfZKKEUaXLXbZ(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void XPuAkuYWNxJZUfOc(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void ZeBIQBGJSnDSbsxY(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public override void Dispose() {
        this.ff8b2648d = true;
        pMfJyvmPBreZFCMU(this.fea97586b);
        pxgwGksgwkHizciJ(this.fbc3b0556);
        FIZvGnSMdKdBDoFx(this.fb61822e8);
        if (qmUoYwMGkWnMKFtJ(this) != 0) {
            return;
        }
        heUGCHuHAPgNGRoF(this.fa9d1cbf7);
    }

    void drain() {
        if (mIVFsaoKyEtgNcGV(this) == 0) {
            kzHgtKzNKbjyQzee(this.fb61822e8, this);
        }
    }

    void innerComplete() {
        this.fc76a5e84 = false;
        YNcWvrZApdOivhPH(this);
    }

    public override bool IsDisposed() {
        return this.ff8b2648d;
    }

    public override void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        BxPgUhdskmGxGKqZ(this);
    }

    public override void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            wUFBnkFOTlmFTEho(th);
            return;
        }
        this.f6b2ded51 = true;
        IrKOPhqFMpzvatKI(this);
        jEauFYcjZimJKWsh(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        if (this.f06b7c4ff == 0) {
            TAfLsCxksQWyaZpY(this.fa9d1cbf7, t);
        }
        PgcPYFUsIWoWqOAW(this);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if ((7 + 11) % 11 > 0) {
        }
        if (MPZSpHtDwkHGnzoB(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            if (p7beea252Var is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16) {
                pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16 p8df47e16Var = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p8df47e16) p7beea252Var;
                int iIyAYuVMyNsBraBwG = IyAYuVMyNsBraBwG(p8df47e16Var, 3);
                if (iIyAYuVMyNsBraBwG == 1) {
                    this.f06b7c4ff = iIyAYuVMyNsBraBwG;
                    this.fa9d1cbf7 = p8df47e16Var;
                    this.f6b2ded51 = true;
                    MkECpdviHHxgzENT(this.fd22a0a80, this);
                    DafboIlFRigpDyEv(this);
                    return;
                }
                if (iIyAYuVMyNsBraBwG == 2) {
                    this.f06b7c4ff = iIyAYuVMyNsBraBwG;
                    this.fa9d1cbf7 = p8df47e16Var;
                    xPuAkuYWNxJZUfOc(this.fd22a0a80, this);
                    return;
                }
            }
            this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(this.fcdee5967);
            FCYlKVXsJFZOagar(this.fd22a0a80, this);
        }
    }

    public override void Run() {
        if ((8 + 2) % 2 > 0) {
        }
        while (!this.ff8b2648d) {
            if (!this.fc76a5e84) {
                bool z = this.f6b2ded51;
                try {
                    java.lang.object objQmoYbRrlNWytPduo = qmoYbRrlNWytPduo(this.fa9d1cbf7);
                    bool z2 = objQmoYbRrlNWytPduo is null;
                    if (z && z2) {
                        this.ff8b2648d = true;
                        PkAAEejiznvtrCJV(this.fd22a0a80);
                        XmTYchZvHHMYzvqi(this.fb61822e8);
                        return;
                    } else if (!z2) {
                        try {
                            io.reactivex.rxjava3.core.ObservableSource observableSource = (io.reactivex.rxjava3.core.ObservableSource) xKuHfZKKEUaXLXbZ(vgEwEgfpVhkEJeQz(this.f4b9f83e1, objQmoYbRrlNWytPduo), "The mapper returned a null ObservableSource");
                            this.fc76a5e84 = true;
                            PoPmWMZsQYUwHIwL(observableSource, this.fea97586b);
                        } catch (java.lang.Exception th) {
                            ocTUSnHpDjCcmfjj(th);
                            SqQxuAmVQDjhjhhC(this);
                            vkhtOAuefSnrlJct(this.fa9d1cbf7);
                            sBxePNsmtfWUFTqa(this.fd22a0a80, th);
                            gVOuvqhodpaVcIDx(this.fb61822e8);
                            return;
                        }
                    }
                } catch (java.lang.Exception th2) {
                    BawYntmhJhLjvbxI(th2);
                    wIaFHvPVNugNlYXh(this);
                    MsZPAgFmdEaSdFsq(this.fa9d1cbf7);
                    OwOXmfXCpzRoCYvH(this.fd22a0a80, th2);
                    suQeQdhBaJgicvND(this.fb61822e8);
                    return;
                }
            }
            if (ZGjwHRnFQsvowHAc(this) == 0) {
                return;
            }
        }
        zeBIQBGJSnDSbsxY(this.fa9d1cbf7);
    }
}

