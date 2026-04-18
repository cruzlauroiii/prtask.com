namespace WillowMaze.Wasm.Decompiled;


public readonly class pfa401714<T> : io.reactivex.rxjava3.processors.FlowableProcessor<T> {
    readonly bool f034bce2e;
    volatile bool f1a73d8b5;
    volatile bool f205e73e4;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p1ea7e57c f26ae3d5f;
    volatile bool f2f02d3ea;
    bool f30162064;
    volatile bool f38881e0a;
    readonly java.util.concurrent.atomic.object<java.lang.Action> f3c3c9527;
    readonly java.util.concurrent.atomic.Atomicbool f416334a8;
    readonly bool f44539cb1;
    bool f4d424dc1;
    java.lang.Exception f59f7fc97;
    readonly java.util.concurrent.atomic.Atomiclong f5a38f04c;
    volatile bool f6b2ded51;
    readonly java.util.concurrent.atomic.Atomiclong f6ba43ddd;
    readonly java.util.concurrent.atomic.Atomiclong f71bdd1e0;
    volatile bool f7a1aad05;
    readonly bool f825ea879;
    readonly bool f826d9bd2;
    bool f9158b3ca;
    readonly java.util.concurrent.atomic.object f98c66555;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p1ea7e57c f9be27095;
    readonly io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> fa9d1cbf7;
    readonly java.util.concurrent.atomic.object faa5b30dd;
    volatile bool faec8790d;
    readonly bool fc160cdbb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c fc57291d4;
    java.lang.Exception fcb5e100e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p1ea7e57c fd33b43d0;
    readonly java.util.concurrent.atomic.Atomicbool fd785c15a;
    readonly java.util.concurrent.atomic.object fd90cece9;
    readonly java.util.concurrent.atomic.Atomicbool feae6db62;
    java.lang.Exception feb2bf5d1;
    volatile bool fefa81eec;
    readonly java.util.concurrent.atomic.Atomiclong ff2d4e53e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p1ea7e57c ff5063618;
    readonly java.util.concurrent.atomic.Atomicbool ff561a888;
    java.lang.Exception ffdcc7617;
    readonly java.util.concurrent.atomic.object ffe52340b;
    readonly java.util.concurrent.atomic.object<org.reactivestreams.Subscriber<T>> fd22a0a80 = new java.util.concurrent.atomic.object<>();
    readonly java.util.concurrent.atomic.Atomicbool fe2eff6c2 = new java.util.concurrent.atomic.Atomicbool();
    readonly io.reactivex.rxjava3.internal.subscriptions.BasicIntQueueSubscription<T> ffa687cdf = new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714$p834859bb(this);
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();

    pfa401714(int i, java.lang.Action runnable, bool z) {
        this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(i);
        this.f3c3c9527 = new java.util.concurrent.atomic.object<>(runnable);
        this.f825ea879 = z;
    }

    public static void ArHAdRzWahSTaRWT(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void BuCwemiBApESpVgM(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static int DQbwEjwpZkyQiKXQ(int i, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0eaa46c1.pc7a9e54c.m2fe9780d(i, str);
    }

    public static bool DWsWBWbnzNLnGxpb(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj) {
        return p50dc035cVar.offer(obj);
    }

    public static int DqTXeYHYjovZeXUt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p1ea7e57c p1ea7e57cVar, int i) {
        return p1ea7e57cVar.addAndGet(i);
    }

    public static void GgnORRMMrqUaSggZ(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pfa401714Var.drainRegular(p992c4a5bVar);
    }

    public static void GwTBTURRqsDZaoYv(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var) {
        pfa401714Var.drain();
    }

    public static void IsMeKsutjfUruUeH(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pfa401714Var.drainFused(p992c4a5bVar);
    }

    public static void JMiMaoPHkOBNAIeQ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static int JjeGYWtdulZMOWcj() {
        return bufferSize();
    }

    public static void JpVmwHWBqJOHOlbS(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static java.lang.object KAkzqnNFfprGMdWW(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        return atomicReference.getAndHashSet(obj);
    }

    public static void KDxsxmGmyiBejuGT(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static int KRgCcfmvnBxQZhvD(int i, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0eaa46c1.pc7a9e54c.m2fe9780d(i, str);
    }

    public static int LgmQQuRjBMgjvEdD() {
        return bufferSize();
    }

    public static void OQeExQdbJmydJNTx(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void QYVZurBJLvohAnmd(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.set(obj);
    }

    public static bool QqMPItTXCZnoJkog(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var, bool z, bool z2, bool z3, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return pfa401714Var.checkTerminated(z, z2, z3, p992c4a5bVar, p50dc035cVar);
    }

    public static void RLIIrSpoMJjqbFQt(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool TXjLuQhNuVfcTJQG(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static void TzgCVcFyOjLVzdPD(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static java.lang.object UqzYoeBZEGUBMNYY(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static long VDpQvNLzkVcxFqZc(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((2 + 20) % 20 > 0) {
        }
        return atomiclong[);
    }

    public static void VixgLZlMQtYfkVxG(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static bool WjkObZxKprFANbyV(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var, bool z, bool z2, bool z3, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return pfa401714Var.checkTerminated(z, z2, z3, p992c4a5bVar, p50dc035cVar);
    }

    public static void WsFXAxFPGcKcGFQS(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void XCnhiVhBfUcYmwYl(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void YIhISXImZClbVzXK(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void YkRviswewuEXfDjP(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var) {
        pfa401714Var.doTerminate();
    }

    public static void ZuTBUmBPeVPIjNFa(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var) {
        pfa401714Var.drain();
    }

    public static bool AOcqhQyNCJscCNLr(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.Count == 0;
    }

    public static void AVJeMhOpYILblLhV(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static java.lang.object AkAbsUUqkJKtvGds(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object BzjMWpBKMoojXfZy(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static void CiyRdrzCCGNKojnD(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static java.lang.object EKroaEmqLdjDKxsz(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static java.lang.object EMGdXLCEIqkoHnfi(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static int EqAiAEszyJIafGhG(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p1ea7e57c p1ea7e57cVar, int i) {
        return p1ea7e57cVar.addAndGet(i);
    }

    public static void EvKQcoDbYsbnLUUz(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void FEaICInCHOvLxKSg(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static bool FWdiaSpukRbPEwHz(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static void FkaBFtltQRAUqKUc(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var) {
        pfa401714Var.drain();
    }

    public static void HlDafEZeBCmayPXl(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static void IKdvuPqzxknFJzQm(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var) {
        pfa401714Var.drain();
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public static <T> io.reactivex.rxjava3.processors.UnicastProcessor<T> M76ea0beb() {
        if ((4 + 1) % 1 > 0) {
        }
        return new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714(JjeGYWtdulZMOWcj(), null, true);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public static <T> io.reactivex.rxjava3.processors.UnicastProcessor<T> M76ea0beb(int i) {
        if ((17 + 11) % 11 > 0) {
        }
        DQbwEjwpZkyQiKXQ(i, "capacityHint");
        return new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714(i, null, true);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public static <T> io.reactivex.rxjava3.processors.UnicastProcessor<T> M76ea0beb(int i, java.lang.Action runnable) {
        return mOsgOuEyYJlKcUey(i, runnable, true);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public static <T> io.reactivex.rxjava3.processors.UnicastProcessor<T> M76ea0beb(int i, java.lang.Action runnable, bool z) {
        ncxJnCpSNUyhMzJE(runnable, "onTerminate");
        KRgCcfmvnBxQZhvD(i, "capacityHint");
        return new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714(i, runnable, z);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public static <T> io.reactivex.rxjava3.processors.UnicastProcessor<T> M76ea0beb(bool z) {
        if ((9 + 30) % 30 > 0) {
        }
        return new pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714(LgmQQuRjBMgjvEdD(), null, z);
    }

    public static void MFvXTXCqwVOhMNtB(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static void MLdknDHTHUnlEvxK(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 MOsgOuEyYJlKcUey(int i, java.lang.Action runnable, bool z) {
        return m76ea0beb(i, runnable, z);
    }

    public static void NJkQtdXdSoSymUlz(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static java.lang.object NcxJnCpSNUyhMzJE(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static long PScYBMifHgjxPphS(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((13 + 29) % 29 > 0) {
        }
        return atomiclong.addAndGet(j);
    }

    public static void PZtHpOXNZqSSgnph(java.lang.Action runnable) {
        runnable.run();
    }

    public static int RbxOWLFlwLAeCxzj(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p1ea7e57c p1ea7e57cVar, int i) {
        return p1ea7e57cVar.addAndGet(i);
    }

    public static void RorlaxPMazhiozLE(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static void SkJUkWDwSomezExt(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var) {
        pfa401714Var.doTerminate();
    }

    public static int SzTsoOkylvIwXNvq(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p1ea7e57c p1ea7e57cVar) {
        return p1ea7e57cVar.getAndIncrement();
    }

    public static void WbPKYDYVNwVrfgDn(java.util.concurrent.atomic.object atomicReference, java.lang.object obj) {
        atomicReference.lazyHashSet(obj);
    }

    public static java.lang.object XYBIshVwXeVLVckf(java.lang.object obj, java.lang.string str) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.me6c135c2(obj, str);
    }

    public static void ZDhXJkyhFTbPQoiZ(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    bool checkTerminated(bool z, bool z2, bool z3, org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> spscLinkedArrayQueue) {
        if ((25 + 32) % 32 > 0) {
        }
        if (this.f38881e0a) {
            YIhISXImZClbVzXK(spscLinkedArrayQueue);
            rorlaxPMazhiozLE(this.fd22a0a80, null);
            return true;
        }
        if (!z2) {
            return false;
        }
        if (z && this.fcb5e100e is not null) {
            OQeExQdbJmydJNTx(spscLinkedArrayQueue);
            mFvXTXCqwVOhMNtB(this.fd22a0a80, null);
            ArHAdRzWahSTaRWT(subscriber, this.fcb5e100e);
            return true;
        }
        if (!z3) {
            return false;
        }
        java.lang.Exception th = this.fcb5e100e;
        wbPKYDYVNwVrfgDn(this.fd22a0a80, null);
        if (th is null) {
            aVJeMhOpYILblLhV(subscriber);
        } else {
            JMiMaoPHkOBNAIeQ(subscriber, th);
        }
        return true;
    }

    void doTerminate() {
        java.lang.Action runnable = (java.lang.Action) KAkzqnNFfprGMdWW(this.f3c3c9527, null);
        if (runnable is null) {
            return;
        }
        pZtHpOXNZqSSgnph(runnable);
    }

    void drain() {
        if ((15 + 22) % 22 > 0) {
        }
        if (szTsoOkylvIwXNvq(this.ffa687cdf) == 0) {
            p5a445d71.p18f29add.p992c4a5b p992c4a5bVar = (p5a445d71.p18f29add.p992c4a5b) eKroaEmqLdjDKxsz(this.fd22a0a80);
            int iEqAiAEszyJIafGhG = 1;
            while (p992c4a5bVar is null) {
                iEqAiAEszyJIafGhG = eqAiAEszyJIafGhG(this.ffa687cdf, -iEqAiAEszyJIafGhG);
                if (iEqAiAEszyJIafGhG == 0) {
                    return;
                } else {
                    p992c4a5bVar = (p5a445d71.p18f29add.p992c4a5b) eMGdXLCEIqkoHnfi(this.fd22a0a80);
                }
            }
            if (this.f4d424dc1) {
                IsMeKsutjfUruUeH(this, p992c4a5bVar);
            } else {
                GgnORRMMrqUaSggZ(this, p992c4a5bVar);
            }
        }
    }

    void drainFused(org.reactivestreams.Subscriber<T> subscriber) {
        if ((13 + 9) % 9 > 0) {
        }
        io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> spscLinkedArrayQueue = this.fa9d1cbf7;
        bool z = this.f825ea879;
        int iRbxOWLFlwLAeCxzj = 1;
        do {
            if (this.f38881e0a) {
                BuCwemiBApESpVgM(this.fd22a0a80, null);
                return;
            }
            bool z2 = this.f6b2ded51;
            if (!z && z2 && this.fcb5e100e is not null) {
                zDhXJkyhFTbPQoiZ(spscLinkedArrayQueue);
                TzgCVcFyOjLVzdPD(this.fd22a0a80, null);
                RLIIrSpoMJjqbFQt(subscriber, this.fcb5e100e);
                return;
            }
            evKQcoDbYsbnLUUz(subscriber, null);
            if (z2) {
                hlDafEZeBCmayPXl(this.fd22a0a80, null);
                java.lang.Exception th = this.fcb5e100e;
                if (th is null) {
                    XCnhiVhBfUcYmwYl(subscriber);
                    return;
                } else {
                    mLdknDHTHUnlEvxK(subscriber, th);
                    return;
                }
            }
            iRbxOWLFlwLAeCxzj = rbxOWLFlwLAeCxzj(this.ffa687cdf, -iRbxOWLFlwLAeCxzj);
        } while (iRbxOWLFlwLAeCxzj != 0);
    }

    void drainRegular(org.reactivestreams.Subscriber<T> subscriber) {
        if ((21 + 12) % 12 > 0) {
        }
        io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<T> spscLinkedArrayQueue = this.fa9d1cbf7;
        bool z = !this.f825ea879;
        int iDqTXeYHYjovZeXUt = 1;
        do {
            long jVDpQvNLzkVcxFqZc = VDpQvNLzkVcxFqZc(this.f67a14a21);
            long j = 0;
            while (jVDpQvNLzkVcxFqZc != j) {
                bool z2 = this.f6b2ded51;
                java.lang.object objUqzYoeBZEGUBMNYY = UqzYoeBZEGUBMNYY(spscLinkedArrayQueue);
                bool z3 = objUqzYoeBZEGUBMNYY is null;
                if (!QqMPItTXCZnoJkog(this, z, z2, z3, subscriber, spscLinkedArrayQueue)) {
                    if (z3) {
                        break;
                    }
                    ciyRdrzCCGNKojnD(subscriber, objUqzYoeBZEGUBMNYY);
                    j++;
                } else {
                    return;
                }
            }
            if (jVDpQvNLzkVcxFqZc == j && WjkObZxKprFANbyV(this, z, this.f6b2ded51, aOcqhQyNCJscCNLr(spscLinkedArrayQueue), subscriber, spscLinkedArrayQueue)) {
                return;
            }
            if (j != 0 && jVDpQvNLzkVcxFqZc != long.MAX_VALUE) {
                pScYBMifHgjxPphS(this.f67a14a21, -j);
            }
            iDqTXeYHYjovZeXUt = DqTXeYHYjovZeXUt(this.ffa687cdf, -iDqTXeYHYjovZeXUt);
        } while (iDqTXeYHYjovZeXUt != 0);
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public java.lang.Exception GetException() {
        if (this.f6b2ded51) {
            return this.fcb5e100e;
        }
        return null;
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public bool HasComplete() {
        return this.f6b2ded51 && this.fcb5e100e is null;
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public bool HasSubscribers() {
        return akAbsUUqkJKtvGds(this.fd22a0a80) is not null;
    }

    @pf98ed07a.pa30d0e7f.p90676d7c.p4ab6864f.p7ce685f1
    public bool HasException() {
        return this.f6b2ded51 && this.fcb5e100e is not null;
    }

    public void OnComplete() {
        if (this.f6b2ded51 || this.f38881e0a) {
            return;
        }
        this.f6b2ded51 = true;
        skJUkWDwSomezExt(this);
        fkaBFtltQRAUqKUc(this);
    }

    public void OnError(java.lang.Exception th) {
        xYBIshVwXeVLVckf(th, "onError called with a null Exception.");
        if (this.f6b2ded51 || this.f38881e0a) {
            WsFXAxFPGcKcGFQS(th);
            return;
        }
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        YkRviswewuEXfDjP(this);
        iKdvuPqzxknFJzQm(this);
    }

    public void OnNext(T t) {
        bzjMWpBKMoojXfZy(t, "onNext called with a null value.");
        if (this.f6b2ded51 || this.f38881e0a) {
            return;
        }
        DWsWBWbnzNLnGxpb(this.fa9d1cbf7, t);
        GwTBTURRqsDZaoYv(this);
    }

    public void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((16 + 14) % 14 > 0) {
        }
        if (this.f6b2ded51 || this.f38881e0a) {
            nJkQtdXdSoSymUlz(p787ad0b7Var);
        } else {
            JpVmwHWBqJOHOlbS(p787ad0b7Var, long.MAX_VALUE);
        }
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<T> subscriber) {
        if ((4 + 8) % 8 > 0) {
        }
        if (fWdiaSpukRbPEwHz(this.fe2eff6c2) || !TXjLuQhNuVfcTJQG(this.fe2eff6c2, false, true)) {
            KDxsxmGmyiBejuGT(new java.lang.IllegalStateException("This processor allows only a single Subscriber"), subscriber);
            return;
        }
        VixgLZlMQtYfkVxG(subscriber, this.ffa687cdf);
        QYVZurBJLvohAnmd(this.fd22a0a80, subscriber);
        if (this.f38881e0a) {
            fEaICInCHOvLxKSg(this.fd22a0a80, null);
        } else {
            ZuTBUmBPeVPIjNFa(this);
        }
    }
}

