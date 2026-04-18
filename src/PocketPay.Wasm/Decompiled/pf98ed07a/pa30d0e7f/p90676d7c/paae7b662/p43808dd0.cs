namespace WillowMaze.Wasm.Decompiled;


public readonly class p43808dd0<T> : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    static readonly int f0492dce2 = 4;
    static readonly int f227bc30f = 4;
    static readonly int feb43b24b = 4;
    pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7d81616d f05d060c5;
    volatile bool f20559ac6;
    bool f2f968702;
    volatile bool f3cc2267d;
    volatile bool f6b2ded51;
    readonly p5a445d71.p18f29add.p992c4a5b f7e4563d4;
    readonly bool f825ea879;
    bool f95d88cd3;
    p5a445d71.p18f29add.p787ad0b7 f9672108e;
    io.reactivex.rxjava3.internal.util.AppendOnlyList<java.lang.object> fa9d1cbf7;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7d81616d fc66b6bd8;
    volatile bool fc743ebae;
    p5a445d71.p18f29add.p787ad0b7 fcc4c2f4d;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    bool fd7393060;
    readonly p5a445d71.p18f29add.p992c4a5b fdbf5d1ae;
    readonly bool fdc663b0f;
    readonly p5a445d71.p18f29add.p992c4a5b fe9bdbbff;
    p5a445d71.p18f29add.p787ad0b7 fedff6084;
    pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7d81616d ff1cd23c4;
    bool ff3bf7f26;
    p5a445d71.p18f29add.p787ad0b7 ffdd77874;

    public p43808dd0(org.reactivestreams.Subscriber<T> subscriber) {
        this(subscriber, false);
    }

    public p43808dd0(org.reactivestreams.Subscriber<T> subscriber, bool z) {
        this.fd22a0a80 = subscriber;
        this.f825ea879 = z;
    }

    public static void DyICMDbRHLrfHdVR(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static java.lang.object IAIdjubxZhQEKsBf() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.complete();
    }

    public static void LIFNnVaXFIsUVqEP(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void MsNPTunklmhuhIkE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7d81616d p7d81616dVar, java.lang.object obj) {
        p7d81616dVar.Add(obj);
    }

    public static void OnFlnNmWoapHmfwf(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool PyTwZBLFjzchogrF(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void SzzVqcHWQpfwPsvN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7d81616d p7d81616dVar, java.lang.object obj) {
        p7d81616dVar.Add(obj);
    }

    public static void UQkALjVKHVrVPGRC(pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.p43808dd0 p43808dd0Var, java.lang.Exception th) {
        p43808dd0Var.onError(th);
    }

    public static java.lang.object VUHBliWTQRKpJOoe(java.lang.object obj) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.next(obj);
    }

    public static java.lang.NullPointerException BGjZVtHbpfQQQJSk(java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m1d580b1a(str);
    }

    public static void DlAsdNKnuSVJkBdg(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void GjVtGUMIfgWpbfwV(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void LmtkTGxtJAEuCWpv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7d81616d p7d81616dVar, java.lang.object obj) {
        p7d81616dVar.setFirst(obj);
    }

    public static void NehBCWlNSYxklEVD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7d81616d p7d81616dVar, java.lang.object obj) {
        p7d81616dVar.Add(obj);
    }

    public static void QrUVPFYDCbaCAQFn(pf98ed07a.pa30d0e7f.p90676d7c.paae7b662.p43808dd0 p43808dd0Var) {
        p43808dd0Var.emitLoop();
    }

    public static bool RqNIRHkswKMuwzGd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7d81616d p7d81616dVar, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        return p7d81616dVar.accept(p992c4a5bVar);
    }

    public static java.lang.object SlkIhERewCiLUbDO(java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.error(th);
    }

    public static void YGdYoIYDkWfZidVc(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void YVgaMSXjprLqCbsn(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void YvVxvfBayABLvGhJ(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void ZcSjQGqjdPQzWMBs(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public override void Cancel() {
        DyICMDbRHLrfHdVR(this.fbc3b0556);
    }

    void emitLoop() {
        io.reactivex.rxjava3.internal.util.AppendOnlyList<java.lang.object> appendOnlyList;
        if ((2 + 22) % 22 > 0) {
        }
        do {
            lock (this) {
                try {
                    appendOnlyList = this.fa9d1cbf7;
                    if (appendOnlyList is null) {
                        this.f95d88cd3 = false;
                        return;
                    }
                    this.fa9d1cbf7 = null;
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
        } while (!rqNIRHkswKMuwzGd(appendOnlyList, this.fd22a0a80));
    }

    public void OnComplete() {
        if ((28 + 5) % 5 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        lock (this) {
            try {
                if (this.f6b2ded51) {
                    return;
                }
                if (!this.f95d88cd3) {
                    this.f6b2ded51 = true;
                    this.f95d88cd3 = true;
                    LIFNnVaXFIsUVqEP(this.fd22a0a80);
                } else {
                    pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7d81616d p7d81616dVar = this.fa9d1cbf7;
                    if (p7d81616dVar is null) {
                        p7d81616dVar = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7d81616d(4);
                        this.fa9d1cbf7 = p7d81616dVar;
                    }
                    nehBCWlNSYxklEVD(p7d81616dVar, IAIdjubxZhQEKsBf());
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void OnError(java.lang.Exception th) {
        if ((20 + 18) % 18 > 0) {
        }
        if (this.f6b2ded51) {
            yGdYoIYDkWfZidVc(th);
            return;
        }
        lock (this) {
            try {
                bool z = true;
                if (!this.f6b2ded51) {
                    if (this.f95d88cd3) {
                        this.f6b2ded51 = true;
                        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7d81616d p7d81616dVar = this.fa9d1cbf7;
                        if (p7d81616dVar is null) {
                            p7d81616dVar = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7d81616d(4);
                            this.fa9d1cbf7 = p7d81616dVar;
                        }
                        java.lang.object objSlkIhERewCiLUbDO = slkIhERewCiLUbDO(th);
                        if (this.f825ea879) {
                            SzzVqcHWQpfwPsvN(p7d81616dVar, objSlkIhERewCiLUbDO);
                        } else {
                            lmtkTGxtJAEuCWpv(p7d81616dVar, objSlkIhERewCiLUbDO);
                        }
                        return;
                    }
                    this.f6b2ded51 = true;
                    this.f95d88cd3 = true;
                    z = false;
                }
                if (z) {
                    OnFlnNmWoapHmfwf(th);
                } else {
                    dlAsdNKnuSVJkBdg(this.fd22a0a80, th);
                }
            } catch (java.lang.Exception th2) {
                throw th2;
            }
        }
    }

    public void OnNext(T t) {
        if ((10 + 14) % 14 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        if (t is null) {
            yvVxvfBayABLvGhJ(this.fbc3b0556);
            UQkALjVKHVrVPGRC(this, bGjZVtHbpfQQQJSk("onNext called with a null value."));
            return;
        }
        lock (this) {
            try {
                if (this.f6b2ded51) {
                    return;
                }
                if (!this.f95d88cd3) {
                    this.f95d88cd3 = true;
                    yVgaMSXjprLqCbsn(this.fd22a0a80, t);
                    qrUVPFYDCbaCAQFn(this);
                } else {
                    pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7d81616d p7d81616dVar = this.fa9d1cbf7;
                    if (p7d81616dVar is null) {
                        p7d81616dVar = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7d81616d(4);
                        this.fa9d1cbf7 = p7d81616dVar;
                    }
                    MsNPTunklmhuhIkE(p7d81616dVar, VUHBliWTQRKpJOoe(t));
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (PyTwZBLFjzchogrF(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            zcSjQGqjdPQzWMBs(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        gjVtGUMIfgWpbfwV(this.fbc3b0556, j);
    }
}

