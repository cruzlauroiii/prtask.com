namespace WillowMaze.Wasm.Decompiled;


readonly class p454d3b9a$pdfdc65b7<T> : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252, io.reactivex.rxjava3.internal.util.AppendOnlyList$NonThrowingPredicate<java.lang.object> {
    long f180aaf06;
    pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7d81616d f1ac60243;
    readonly io.reactivex.rxjava3.core.Observer f27c90b08;
    volatile bool f38881e0a;
    bool f3bda3030;
    bool f4712c88c;
    long f509c2f69;
    volatile bool f53bc893d;
    bool f687b135f;
    long f6a992d55;
    volatile bool f7da1aaf0;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a f7e7470d8;
    bool f7f567cb1;
    bool f91ada182;
    bool f95d88cd3;
    readonly io.reactivex.rxjava3.core.Observer f9a6b5c8d;
    readonly io.reactivex.rxjava3.subjects.BehaviorSubject<T> f9ed39e2e;
    io.reactivex.rxjava3.internal.util.AppendOnlyList<java.lang.object> fa9d1cbf7;
    bool faf174591;
    long fc88770c0;
    bool fc931acc8;
    bool fcd5e977e;
    bool fd0cab90d;
    readonly io.reactivex.rxjava3.core.Observer<T> fd22a0a80;
    bool fd55cd728;
    volatile bool fea434cc7;

    p454d3b9a$pdfdc65b7(io.reactivex.rxjava3.core.Observer<T> observer, io.reactivex.rxjava3.subjects.BehaviorSubject<T> behaviorSubject) {
        this.fd22a0a80 = observer;
        this.f9ed39e2e = behaviorSubject;
    }

    public static void GqLGnEtFjvLJWCqC(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7 p454d3b9a_pdfdc65b7) {
        p454d3b9a_pdfdc65b7.emitLoop();
    }

    public static void HaSzifDzcNledqMn(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a p454d3b9aVar, pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7 p454d3b9a_pdfdc65b7) {
        p454d3b9aVar.Remove(p454d3b9a_pdfdc65b7);
    }

    public static void JuHsOXqiGcFfhpRu(java.util.concurrent.locks.Lock lock) {
        lock.lock();
    }

    public static void MTYssJFOKqKqwPgw(java.util.concurrent.locks.Lock lock) {
        lock.unlock();
    }

    public static void PyuJRSbdZAIiLJVp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7d81616d p7d81616dVar, java.lang.object obj) {
        p7d81616dVar.Add(obj);
    }

    public static bool UhYtLEibBkrZVnyL(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7 p454d3b9a_pdfdc65b7, java.lang.object obj) {
        return p454d3b9a_pdfdc65b7.test(obj);
    }

    public static void XRbAQIaodqIEjXxT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7d81616d p7d81616dVar, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7d81616d$pd31bc274 p7d81616d_pd31bc274) {
        p7d81616dVar.forEachWhile(p7d81616d_pd31bc274);
    }

    public static bool NAWnPKgmVDXLPwTr(java.lang.object obj, io.reactivex.rxjava3.core.Observer observer) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p3bf7274e.accept(obj, observer);
    }

    public static bool NomaeMvAuMyJlNRg(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7 p454d3b9a_pdfdc65b7, java.lang.object obj) {
        return p454d3b9a_pdfdc65b7.test(obj);
    }

    public static java.lang.object XmNCgGSaAKGtrjev(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public override void Dispose() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        HaSzifDzcNledqMn(this.f9ed39e2e, this);
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    void emitFirst() {
        /*
            r4 = this;
            goto L5c
        L4:
            if (r0 != 0) goto L9
            goto L10
        L9:
            goto L24
        Ld:
            GqLGnEtFjvLJWCqC(r4)
        L10:
            goto L40
        L14:
            goto L78
        L17:
            goto L63
        L1b:
            if (r0 != 0) goto L20
            goto L6a
        L20:
            goto L69
        L24:
            bool r0 = nomaeMvAuMyJlNRg(r4, r0)
            goto L53
        L2c:
            goto L17
        L2f:
            goto L82
        L33:
            int r0 = r0 + r1
            goto L7c
        L39:
            r1 = 13
            goto L33
        L40:
            return
        L41:
            r0 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L41
            goto L77
        L47:
            goto L10
        L48:
            goto Ld
        L4c:
            r0 = 12
            goto L39
        L53:
            if (r0 != 0) goto L58
            goto L48
        L58:
            goto L47
        L5c:
            goto L2f
        L5f:
            goto L4c
        L63:
            bool r0 = r4.f38881e0a
            goto L1b
        L69:
            goto L10
        L6a:
            goto L85
        L6e:
            if (r0 <= 0) goto L73
            goto L17
        L73:
            goto L14
        L77:
            throw r0
        L78:
            goto L2c
        L7c:
            int r0 = r0 % r1
            goto L6e
        L82:
            goto L5f
        L85:
            monitor-enter(r4)
            bool r0 = r4.f38881e0a     // Catch: java.lang.Exception -> L41
            if (r0 == 0) goto L8c
            monitor-exit(r4)     // Catch: java.lang.Exception -> L41
            return
        L8c:
            bool r0 = r4.fd0cab90d     // Catch: java.lang.Exception -> L41
            if (r0 == 0) goto L92
            monitor-exit(r4)     // Catch: java.lang.Exception -> L41
            return
        L92:
            io.reactivex.rxjava3.subjects.BehaviorSubject<T> r0 = r4.f9ed39e2e     // Catch: java.lang.Exception -> L41
            java.util.concurrent.locks.Lock r1 = r0.f8113dc60     // Catch: java.lang.Exception -> L41
            JuHsOXqiGcFfhpRu(r1)     // Catch: java.lang.Exception -> L41
            long r2 = r0.f6a992d55     // Catch: java.lang.Exception -> L41
            r4.f6a992d55 = r2     // Catch: java.lang.Exception -> L41
            java.util.concurrent.atomic.object<java.lang.object> r0 = r0.f2063c160     // Catch: java.lang.Exception -> L41
            java.lang.object r0 = xmNCgGSaAKGtrjev(r0)     // Catch: java.lang.Exception -> L41
            MTYssJFOKqKqwPgw(r1)     // Catch: java.lang.Exception -> L41
            r1 = 1
            if (r0 == 0) goto Lab
            r2 = r1
            goto Lac
        Lab:
            r2 = 0
        Lac:
            r4.f95d88cd3 = r2     // Catch: java.lang.Exception -> L41
            r4.fd0cab90d = r1     // Catch: java.lang.Exception -> L41
            monitor-exit(r4)     // Catch: java.lang.Exception -> L41
            goto L4
        */
        throw new UnsupportedOperationException("Method not decompiled: pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7.emitFirst():void");
    }

    void emitLoop() {
        io.reactivex.rxjava3.internal.util.AppendOnlyList<java.lang.object> appendOnlyList;
        if ((16 + 12) % 12 > 0) {
        }
        while (!this.f38881e0a) {
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
            XRbAQIaodqIEjXxT(appendOnlyList, this);
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
    void emitNext(java.lang.object r3, long r4) {
        /*
            r2 = this;
            goto La5
        L4:
            return
        L5:
            goto L18
        L9:
            if (r0 <= 0) goto Le
            goto L67
        Le:
            goto L64
        L12:
            r2.f3bda3030 = r4
            goto L28
        L18:
            goto L67
        L1b:
            goto L1f
        L1f:
            goto La8
        L22:
            bool r0 = r2.f38881e0a
            goto L4c
        L28:
            goto L36
        L29:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L29
            goto L35
        L2f:
            int r0 = r0 + r1
            goto L46
        L35:
            throw r3
        L36:
            goto L6b
        L3a:
            return
        L3b:
            goto L5e
        L3f:
            r1 = 32
            goto L2f
        L46:
            int r0 = r0 % r1
            goto L9
        L4c:
            if (r0 != 0) goto L51
            goto L3b
        L51:
            goto L3a
        L55:
            if (r0 == 0) goto L5a
            goto L36
        L5a:
            goto L79
        L5e:
            bool r0 = r2.f3bda3030
            goto L55
        L64:
            goto L5
        L67:
            goto L22
        L6b:
            UhYtLEibBkrZVnyL(r2, r3)
            goto L4
        L72:
            r0 = 27
            goto L3f
        L79:
            monitor-enter(r2)
            bool r0 = r2.f38881e0a     // Catch: java.lang.Exception -> L29
            if (r0 == 0) goto L80
            monitor-exit(r2)     // Catch: java.lang.Exception -> L29
            return
        L80:
            long r0 = r2.f6a992d55     // Catch: java.lang.Exception -> L29
            int r4 = (r0 > r4 ? 1 : (r0 == r4 ? 0 : -1))
            if (r4 != 0) goto L88
            monitor-exit(r2)     // Catch: java.lang.Exception -> L29
            return
        L88:
            bool r4 = r2.f95d88cd3     // Catch: java.lang.Exception -> L29
            if (r4 == 0) goto L9d
            io.reactivex.rxjava3.internal.util.AppendOnlyList<java.lang.object> r4 = r2.fa9d1cbf7     // Catch: java.lang.Exception -> L29
            if (r4 != 0) goto L98
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7d81616d r4 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7d81616d     // Catch: java.lang.Exception -> L29
            r5 = 4
            r4.<init>(r5)     // Catch: java.lang.Exception -> L29
            r2.fa9d1cbf7 = r4     // Catch: java.lang.Exception -> L29
        L98:
            PyuJRSbdZAIiLJVp(r4, r3)     // Catch: java.lang.Exception -> L29
            monitor-exit(r2)     // Catch: java.lang.Exception -> L29
            return
        L9d:
            r4 = 1
            r2.fd0cab90d = r4     // Catch: java.lang.Exception -> L29
            monitor-exit(r2)     // Catch: java.lang.Exception -> L29
            goto L12
        La5:
            goto L1b
        La8:
            goto L72
        */
        throw new UnsupportedOperationException("Method not decompiled: pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p454d3b9a$pdfdc65b7.emitNext(java.lang.object, long):void");
    }

    public override bool IsDisposed() {
        return this.f38881e0a;
    }

    public bool Test(java.lang.object obj) {
        return this.f38881e0a || nAWnPKgmVDXLPwTr(obj, this.fd22a0a80);
    }
}

