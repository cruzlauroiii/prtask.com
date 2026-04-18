namespace WillowMaze.Wasm.Decompiled;


readonly class p8d8b9bfe$pff32a825<T, R> : java.util.concurrent.atomic.Atomicint : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f6a46de22 = 8567835998786448817L;
    private static readonly long fc6e1e520 = 8567835998786448817L;
    private static readonly long fdba35076 = 8567835998786448817L;
    private static readonly long fe2d98776 = 8567835998786448817L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f07213a01 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d();
    int f09c77896;
    readonly bool f116a0959;
    readonly io.reactivex.rxjava3.core.Observer f2906be77;
    volatile bool f38881e0a;
    int f4ea62344;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f565c12d1;
    readonly io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> f61aaf8fd;
    volatile bool f6b2ded51;
    readonly io.reactivex.rxjava3.internal.operators.observable.ObservableCombineLatest$CombinerObserver<T, R>[] f6ea648a6;
    java.lang.object[] f71ccb7a3;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f7291fdbb;
    readonly bool f7ec16005;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f800e71b0;
    readonly bool f825ea879;
    volatile bool f86b04b33;
    readonly io.reactivex.rxjava3.core.Observer f8b1f9073;
    int f8d015eec;
    int f8e8a369e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$p01ebab87[] f8efdc44a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d f935b53a2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$p01ebab87[] f9a3d545a;
    java.lang.object[] fa58dc459;
    readonly io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object[]> fa9d1cbf7;
    int fafdd9311;
    int fc38de2ac;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d fc5354b1e;
    int fc5ae7650;
    int fc76a5e84;
    java.lang.object[] fcc203e49;
    volatile bool fcd39a48e;
    readonly io.reactivex.rxjava3.core.Observer<R> fd22a0a80;
    java.lang.object[] fd840a941;
    int fd9a22d7a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c ff86152dd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ffa26819e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c fffd819a7;

    p8d8b9bfe$pff32a825(io.reactivex.rxjava3.core.Observer<R> observer, io.reactivex.rxjava3.functions.Function<? super java.lang.object[], ? : R> function, int i, int i2, bool z) {
        this.fd22a0a80 = observer;
        this.f61aaf8fd = function;
        this.f825ea879 = z;
        this.f71ccb7a3 = new java.lang.object[i];
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$p01ebab87[] p8d8b9bfe_p01ebab87Arr = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$p01ebab87[i];
        for (int i3 = 0; i3 < i; i3++) {
            p8d8b9bfe_p01ebab87Arr[i3] = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$p01ebab87(this, i3);
        }
        this.f6ea648a6 = p8d8b9bfe_p01ebab87Arr;
        this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(i2);
    }

    public static void AsIAUTJmjMSaLpXF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 p8d8b9bfe_pff32a825) {
        p8d8b9bfe_pff32a825.cancelSources();
    }

    public static java.lang.object BZyJDmRrmUWdSZgc(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void EpRUSebymdAREFcf(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static void FdPaNfHdpprEAYFk(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void HToBJKDzvipXeIRM(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$p01ebab87 p8d8b9bfe_p01ebab87) {
        p8d8b9bfe_p01ebab87.dispose();
    }

    public static void HtQVKQwWKmznuQah(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static bool IQfplmPJFTfvHZid(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj) {
        return p50dc035cVar.offer(obj);
    }

    public static void KpqDoYlTtnDmiUln(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 p8d8b9bfe_pff32a825) {
        p8d8b9bfe_pff32a825.drain();
    }

    public static int LMssFvtwldkHuHCe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 p8d8b9bfe_pff32a825) {
        return p8d8b9bfe_pff32a825.getAndIncrement();
    }

    public static java.lang.object MxHnmiapmbmEScck(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        return p36a52e5dVar[);
    }

    public static void OOjplQTIzlfcezMn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 p8d8b9bfe_pff32a825) {
        p8d8b9bfe_pff32a825.drain();
    }

    public static java.lang.object OjxhjQuyxCBLzdHv(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void OrOiQWBiwFjkeQzE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 p8d8b9bfe_pff32a825) {
        p8d8b9bfe_pff32a825.cancelSources();
    }

    public static bool OxEnDzvrkGyyhFiR(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void PwrHqEuKFRvCgycu(io.reactivex.rxjava3.core.ObservableSource observableSource, io.reactivex.rxjava3.core.Observer observer) {
        observableSource.subscribe(observer);
    }

    public static bool QHuteJqTaluFntxP(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, java.lang.Exception th) {
        return p36a52e5dVar.tryAddExceptionOrReport(th);
    }

    public static void VvXoVeEBMuaasyrp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 p8d8b9bfe_pff32a825) {
        p8d8b9bfe_pff32a825.drain();
    }

    public static java.lang.object WKMgIINgAKdrKATx(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static void XOGoxBHcfYWcRFpd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 p8d8b9bfe_pff32a825, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p8d8b9bfe_pff32a825.clear(p50dc035cVar);
    }

    public static void YFAjljjVdcLcIPyB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 p8d8b9bfe_pff32a825) {
        p8d8b9bfe_pff32a825.drain();
    }

    public static void AESnGDhhrgGDsuBK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 p8d8b9bfe_pff32a825, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p8d8b9bfe_pff32a825.clear(p50dc035cVar);
    }

    public static java.lang.object AqqgOABbRMydGmCe(java.lang.object[] objArr) {
        return objArr.clone();
    }

    public static void ECbmoUDnvuDbvoHQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 p8d8b9bfe_pff32a825) {
        p8d8b9bfe_pff32a825.cancelSources();
    }

    public static void GwvlpMgxvFRumtkb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 p8d8b9bfe_pff32a825) {
        p8d8b9bfe_pff32a825.cancelSources();
    }

    public static void HhdtyIJCysKjRKvl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar) {
        p36a52e5dVar.tryTerminateAndReport();
    }

    public static void IvZeQAaShrrxcNKK(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void MTIkGhvuEnwNueDE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 p8d8b9bfe_pff32a825) {
        p8d8b9bfe_pff32a825.cancelSources();
    }

    public static void NtagVgDrLzAYafIm(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 p8d8b9bfe_pff32a825, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p8d8b9bfe_pff32a825.clear(p50dc035cVar);
    }

    public static void PRSKudXbEICQarZs(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static int RUhbQpzqzoWuSJOX(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 p8d8b9bfe_pff32a825, int i) {
        return p8d8b9bfe_pff32a825.addAndGet(i);
    }

    public static void TSBFhnXUpTIzXOoh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p36a52e5d p36a52e5dVar, io.reactivex.rxjava3.core.Observer observer) {
        p36a52e5dVar.tryTerminateConsumer((io.reactivex.rxjava3.core.Observer<object>) observer);
    }

    public static void VsrmNgjPwdnLSjaG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825 p8d8b9bfe_pff32a825, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p8d8b9bfe_pff32a825.clear(p50dc035cVar);
    }

    public static void ZdkjnQJSFzGobtJH(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    void cancelSources() {
        if ((5 + 23) % 23 > 0) {
        }
        for (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$p01ebab87 p8d8b9bfe_p01ebab87 : this.f6ea648a6) {
            HToBJKDzvipXeIRM(p8d8b9bfe_p01ebab87);
        }
    }

    void clear(io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<object> spscLinkedArrayQueue) {
        lock (this) {
            try {
                this.f71ccb7a3 = null;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        HtQVKQwWKmznuQah(spscLinkedArrayQueue);
    }

    public override void Dispose() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        mTIkGhvuEnwNueDE(this);
        KpqDoYlTtnDmiUln(this);
    }

    void drain() {
        if ((14 + 11) % 11 > 0) {
        }
        if (LMssFvtwldkHuHCe(this) == 0) {
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object[]> spscLinkedArrayQueue = this.fa9d1cbf7;
            io.reactivex.rxjava3.core.Observer<R> observer = this.fd22a0a80;
            bool z = this.f825ea879;
            int iRUhbQpzqzoWuSJOX = 1;
            while (!this.f38881e0a) {
                if (!z && MxHnmiapmbmEScck(this.f07213a01) is not null) {
                    AsIAUTJmjMSaLpXF(this);
                    XOGoxBHcfYWcRFpd(this, spscLinkedArrayQueue);
                    tSBFhnXUpTIzXOoh(this.f07213a01, observer);
                    return;
                }
                bool z2 = this.f6b2ded51;
                java.lang.object[] objArr = (java.lang.object[]) WKMgIINgAKdrKATx(spscLinkedArrayQueue);
                bool z3 = objArr is null;
                if (z2 && z3) {
                    vsrmNgjPwdnLSjaG(this, spscLinkedArrayQueue);
                    FdPaNfHdpprEAYFk(this.f07213a01, observer);
                    return;
                }
                if (z3) {
                    iRUhbQpzqzoWuSJOX = rUhbQpzqzoWuSJOX(this, -iRUhbQpzqzoWuSJOX);
                    if (iRUhbQpzqzoWuSJOX == 0) {
                        return;
                    }
                } else {
                    try {
                        zdkjnQJSFzGobtJH(observer, OjxhjQuyxCBLzdHv(BZyJDmRrmUWdSZgc(this.f61aaf8fd, objArr), "The combiner returned a null value"));
                    } catch (java.lang.Exception th) {
                        pRSKudXbEICQarZs(th);
                        QHuteJqTaluFntxP(this.f07213a01, th);
                        gwvlpMgxvFRumtkb(this);
                        ntagVgDrLzAYafIm(this, spscLinkedArrayQueue);
                        ivZeQAaShrrxcNKK(this.f07213a01, observer);
                        return;
                    }
                }
            }
            aESnGDhhrgGDsuBK(this, spscLinkedArrayQueue);
            hhdtyIJCysKjRKvl(this.f07213a01);
        }
    }

    void innerComplete(int i) {
        if ((7 + 12) % 12 > 0) {
        }
        lock (this) {
            try {
                java.lang.object[] objArr = this.f71ccb7a3;
                if (objArr is null) {
                    return;
                }
                bool z = objArr[i] is null;
                if (z) {
                    this.f6b2ded51 = true;
                } else {
                    int i2 = this.fd9a22d7a + 1;
                    this.fd9a22d7a = i2;
                    if (i2 == objArr.length) {
                        this.f6b2ded51 = true;
                    }
                }
                if (z) {
                    OrOiQWBiwFjkeQzE(this);
                }
                OOjplQTIzlfcezMn(this);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    void innerError(int i, java.lang.Exception th) {
        if ((11 + 17) % 17 > 0) {
        }
        if (OxEnDzvrkGyyhFiR(this.f07213a01, th)) {
            bool z = true;
            if (this.f825ea879) {
                lock (this) {
                    try {
                        java.lang.object[] objArr = this.f71ccb7a3;
                        if (objArr is null) {
                            return;
                        }
                        bool z2 = objArr[i] is null;
                        if (z2) {
                            this.f6b2ded51 = true;
                        } else {
                            int i2 = this.fd9a22d7a + 1;
                            this.fd9a22d7a = i2;
                            if (i2 == objArr.length) {
                                this.f6b2ded51 = true;
                            }
                        }
                        z = z2;
                    } catch (java.lang.Exception th2) {
                        throw th2;
                    }
                }
            }
            if (z) {
                eCbmoUDnvuDbvoHQ(this);
            }
            YFAjljjVdcLcIPyB(this);
        }
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    void innerNext(int r4, T r5) {
        /*
            r3 = this;
            goto L26
        L4:
            goto L14
        L7:
            goto L7f
        Lb:
            int r0 = r0 % r1
            goto L3b
        L11:
            goto L7b
        L14:
            goto L53
        L18:
            r0 = 21
            goto L1f
        L1f:
            r1 = 24
            goto L4d
        L26:
            goto L7
        L29:
            goto L18
        L2d:
            VvXoVeEBMuaasyrp(r3)
        L30:
            goto L34
        L34:
            return
        L35:
            r4 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L35
            goto L7a
        L3b:
            if (r0 <= 0) goto L40
            goto L14
        L40:
            goto L11
        L44:
            if (r4 != 0) goto L49
            goto L30
        L49:
            goto L2d
        L4d:
            int r0 = r0 + r1
            goto Lb
        L53:
            monitor-enter(r3)
            java.lang.object[] r0 = r3.f71ccb7a3     // Catch: java.lang.Exception -> L35
            if (r0 != 0) goto L5a
            monitor-exit(r3)     // Catch: java.lang.Exception -> L35
            return
        L5a:
            r1 = r0[r4]     // Catch: java.lang.Exception -> L35
            int r2 = r3.fc76a5e84     // Catch: java.lang.Exception -> L35
            if (r1 != 0) goto L64
            int r2 = r2 + 1
            r3.fc76a5e84 = r2     // Catch: java.lang.Exception -> L35
        L64:
            r0[r4] = r5     // Catch: java.lang.Exception -> L35
            int r4 = r0.length     // Catch: java.lang.Exception -> L35
            if (r2 != r4) goto L74
            io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<java.lang.object[]> r4 = r3.fa9d1cbf7     // Catch: java.lang.Exception -> L35
            java.lang.object r5 = aqqgOABbRMydGmCe(r0)     // Catch: java.lang.Exception -> L35
            IQfplmPJFTfvHZid(r4, r5)     // Catch: java.lang.Exception -> L35
            r4 = 1
            goto L75
        L74:
            r4 = 0
        L75:
            monitor-exit(r3)     // Catch: java.lang.Exception -> L35
            goto L44
        L7a:
            throw r4
        L7b:
            goto L4
        L7f:
            goto L29
        */
        throw new UnsupportedOperationException("Method not decompiled: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p8d8b9bfe$pff32a825.innerNext(int, java.lang.object):void");
    }

    public override bool IsDisposed() {
        return this.f38881e0a;
    }

    public void Subscribe(io.reactivex.rxjava3.core.ObservableSource<? : T>[] observableSourceArr) {
        if ((27 + 17) % 17 > 0) {
        }
        io.reactivex.rxjava3.core.Observer[] observerArr = this.f6ea648a6;
        int length = observerArr.length;
        EpRUSebymdAREFcf(this.fd22a0a80, this);
        for (int i = 0; i < length && !this.f6b2ded51 && !this.f38881e0a; i++) {
            PwrHqEuKFRvCgycu(observableSourceArr[i], observerArr[i]);
        }
    }
}

