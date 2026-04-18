namespace WillowMaze.Wasm.Decompiled;


readonly class p93ccfea4$p0a799db7<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7 {
    private static readonly long f74c661be = 3240706908776709697L;
    private static readonly long f7c819197 = 3240706908776709697L;
    private static readonly long fc6e1e520 = 3240706908776709697L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f07eec475;
    volatile bool f0fb431e9;
    readonly java.util.Queue f13373e12;
    p5a445d71.p18f29add.p787ad0b7 f13740834;
    volatile bool f1c91d204;
    java.lang.Exception f32a1b5b0;
    volatile bool f38881e0a;
    readonly long f630f502f;
    p5a445d71.p18f29add.p787ad0b7 f683bc7b2;
    volatile bool f6b2ded51;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 f6bcf53d4;
    volatile bool f84f03799;
    readonly p5a445d71.p18f29add.p992c4a5b f8547d38d;
    readonly io.reactivex.rxjava3.core.BackpressureOverflowStrategy f8ed6fb92;
    readonly java.util.concurrent.atomic.Atomiclong fa02fb27a;
    p5a445d71.p18f29add.p787ad0b7 fa42ecca2;
    readonly p5a445d71.p18f29add.p992c4a5b fb0c803f6;
    p5a445d71.p18f29add.p787ad0b7 fb14bfd6b;
    volatile bool fb60db24f;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly io.reactivex.rxjava3.core.BackpressureOverflowStrategy fc0089e65;
    java.lang.Exception fcb5e100e;
    readonly long fcdee5967;
    readonly org.reactivestreams.Subscriber<T> fd22a0a80;
    readonly io.reactivex.rxjava3.core.BackpressureOverflowStrategy fde7b0f70;
    readonly java.util.concurrent.atomic.Atomiclong fdfad1597;
    readonly java.util.concurrent.atomic.Atomiclong fe4da718b;
    readonly java.util.Queue fec72d58b;
    readonly long ff1ccd555;
    volatile bool ff54c1086;
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
    readonly java.util.Queue<T> feb30267a = new java.util.ArrayQueue();

    p93ccfea4$p0a799db7(org.reactivestreams.Subscriber<T> subscriber, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var, io.reactivex.rxjava3.core.BackpressureOverflowStrategy backpressureOverflowStrategy, long j) {
        this.fd22a0a80 = subscriber;
        this.f07eec475 = p004bf6c9Var;
        this.fc0089e65 = backpressureOverflowStrategy;
        this.fcdee5967 = j;
    }

    public static bool CmRjokzYTegUsyus(java.util.Queue deque, java.lang.object obj) {
        return deque.offer(obj);
    }

    public static bool HnudIpMtvFlXGwpS(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static long JiNwhVpOBmoTqPEz(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((18 + 28) % 28 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static java.lang.object LABqXBkUgBfTnUAh(java.util.Queue deque) {
        return deque.pollLast();
    }

    public static bool LfCGdrvgoGaKvkBM(java.util.Queue deque) {
        return deque.Count == 0;
    }

    public static void LxohcxmYKPxKWsmH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93ccfea4$p0a799db7 p93ccfea4_p0a799db7) {
        p93ccfea4_p0a799db7.drain();
    }

    public static void MCAmoyeyFaxPzVWW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93ccfea4$p0a799db7 p93ccfea4_p0a799db7, java.lang.Exception th) {
        p93ccfea4_p0a799db7.onError(th);
    }

    public static void MxqMXjMSYzclOSLb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93ccfea4$p0a799db7 p93ccfea4_p0a799db7, java.lang.Exception th) {
        p93ccfea4_p0a799db7.onError(th);
    }

    public static long OYbfGbgOnzJuoTkk(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((5 + 15) % 15 > 0) {
        }
        return atomiclong[);
    }

    public static void PNnWgCcnXVPBDnNt(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static java.lang.object QTPaYMrhmebiXQQY(java.util.Queue deque) {
        return deque.poll();
    }

    public static int SRcNFVDebkGlLbeU(io.reactivex.rxjava3.core.BackpressureOverflowStrategy backpressureOverflowStrategy) {
        return backpressureOverflowStrategy.ordinal();
    }

    public static void STkQwvkbKWCpBNDo(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void VHReAtmNpdNfhBMZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93ccfea4$p0a799db7 p93ccfea4_p0a799db7, java.util.Queue deque) {
        p93ccfea4_p0a799db7.clear(deque);
    }

    public static void XIJXOqbPUOeZRbJD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93ccfea4$p0a799db7 p93ccfea4_p0a799db7) {
        p93ccfea4_p0a799db7.drain();
    }

    public static void XRoKkKEioSfHVXCN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93ccfea4$p0a799db7 p93ccfea4_p0a799db7) {
        p93ccfea4_p0a799db7.drain();
    }

    public static void YwIAaQkrCSUwHXmX(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void ASiVnwMOwycoKqSi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93ccfea4$p0a799db7 p93ccfea4_p0a799db7, java.util.Queue deque) {
        p93ccfea4_p0a799db7.clear(deque);
    }

    public static void ArdWifHJzcsjvIHU(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static java.lang.object AyNSknMffibrmraF(java.util.Queue deque) {
        return deque.poll();
    }

    public static void BctLePDfGgPYENTB(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void CVIbGAbaQEJiHYjc(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var) throws java.lang.Exception {
        p004bf6c9Var.run();
    }

    public static bool DSXnPKDVZZMpeImH(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static int EnlKPxELyMOoViJN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93ccfea4$p0a799db7 p93ccfea4_p0a799db7, int i) {
        return p93ccfea4_p0a799db7.addAndGet(i);
    }

    public static void EvgdSUgqRTizZJGH(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static int FRPOSShsldmUGSDt(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93ccfea4$p0a799db7 p93ccfea4_p0a799db7) {
        return p93ccfea4_p0a799db7.getAndIncrement();
    }

    public static void GVYJxsOKjbqkxFVr(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void HKQjJxiTKJmloict(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93ccfea4$p0a799db7 p93ccfea4_p0a799db7, java.util.Queue deque) {
        p93ccfea4_p0a799db7.clear(deque);
    }

    public static void KLtOwMdbLKDmMUza(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void LkdvyjbOPwYTKBNT(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void MCjPKmbhdxiRftzY(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93ccfea4$p0a799db7 p93ccfea4_p0a799db7) {
        p93ccfea4_p0a799db7.drain();
    }

    public static void PEJOykLhUlUwICKa(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static int PlxoIQdiyMWMualL(java.util.Queue deque) {
        return deque.Count;
    }

    public static int PomJoFRavtmDujXW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93ccfea4$p0a799db7 p93ccfea4_p0a799db7) {
        return p93ccfea4_p0a799db7.getAndIncrement();
    }

    public static void RLnAyKWFldcIUNXr(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93ccfea4$p0a799db7 p93ccfea4_p0a799db7, java.util.Queue deque) {
        p93ccfea4_p0a799db7.clear(deque);
    }

    public static bool TLOcjTWqMfgMVSEf(java.util.Queue deque, java.lang.object obj) {
        return deque.offer(obj);
    }

    public static void TWxittfutduoNvQZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93ccfea4$p0a799db7 p93ccfea4_p0a799db7, java.util.Queue deque) {
        p93ccfea4_p0a799db7.clear(deque);
    }

    public static bool UNDZwzkvzwozQeCU(java.util.Queue deque, java.lang.object obj) {
        return deque.offer(obj);
    }

    public static long UmYdXaLPVsFbJCiH(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((31 + 14) % 14 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m5051d8ee(atomiclong, j);
    }

    public static void VbgNQwGkKMuwnnVx(java.util.Queue deque) {
        deque.clear();
    }

    public static void XfwPNjYXmdxhJYXO(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void YpIQKQcoyXnmLVTR(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public override void Cancel() {
        this.f38881e0a = true;
        evgdSUgqRTizZJGH(this.fbc3b0556);
        if (pomJoFRavtmDujXW(this) != 0) {
            return;
        }
        VHReAtmNpdNfhBMZ(this, this.feb30267a);
    }

    void clear(java.util.Queue<T> deque) {
        lock (deque) {
            try {
                vbgNQwGkKMuwnnVx(deque);
            } catch (java.lang.Exception th) {
                throw th;
            }
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
    void drain() {
        /*
            Method dump skipped, instruction units count: 503
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93ccfea4$p0a799db7.drain():void");
    }

    public void OnComplete() {
        this.f6b2ded51 = true;
        XRoKkKEioSfHVXCN(this);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            bctLePDfGgPYENTB(th);
            return;
        }
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        LxohcxmYKPxKWsmH(this);
    }

    public void OnNext(T t) {
        bool z;
        bool z2;
        if ((20 + 32) % 32 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        java.util.Queue<T> deque = this.feb30267a;
        lock (deque) {
            try {
                z = false;
                if (plxoIQdiyMWMualL(deque) == this.fcdee5967) {
                    int i = pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93ccfea4$1.f2764x8ef22ea[SRcNFVDebkGlLbeU(this.fc0089e65)];
                    z2 = true;
                    if (i == 1) {
                        LABqXBkUgBfTnUAh(deque);
                        CmRjokzYTegUsyus(deque, t);
                    } else if (i == 2) {
                        QTPaYMrhmebiXQQY(deque);
                        tLOcjTWqMfgMVSEf(deque, t);
                    }
                    z2 = false;
                    z = true;
                } else {
                    uNDZwzkvzwozQeCU(deque, t);
                    z2 = false;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        if (!z) {
            if (!z2) {
                XIJXOqbPUOeZRbJD(this);
                return;
            } else {
                lkdvyjbOPwYTKBNT(this.fbc3b0556);
                MCAmoyeyFaxPzVWW(this, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1());
                return;
            }
        }
        pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p004bf6c9 p004bf6c9Var = this.f07eec475;
        if (p004bf6c9Var is null) {
            return;
        }
        try {
            cVIbGAbaQEJiHYjc(p004bf6c9Var);
        } catch (java.lang.Exception th2) {
            pEJOykLhUlUwICKa(th2);
            kLtOwMdbLKDmMUza(this.fbc3b0556);
            MxqMXjMSYzclOSLb(this, th2);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((18 + 30) % 30 > 0) {
        }
        if (dSXnPKDVZZMpeImH(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            PNnWgCcnXVPBDnNt(this.fd22a0a80, this);
            ardWifHJzcsjvIHU(p787ad0b7Var, long.MAX_VALUE);
        }
    }

    public override void Request(long j) {
        if (HnudIpMtvFlXGwpS(j)) {
            JiNwhVpOBmoTqPEz(this.f67a14a21, j);
            mCjPKmbhdxiRftzY(this);
        }
    }
}

