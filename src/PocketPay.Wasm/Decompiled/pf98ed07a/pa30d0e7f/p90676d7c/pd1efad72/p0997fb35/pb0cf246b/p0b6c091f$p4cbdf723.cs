namespace WillowMaze.Wasm.Decompiled;


readonly class p0b6c091f$p4cbdf723<T> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.FlowableSubscriber<T>, p5a445d71.p18f29add.p787ad0b7, java.lang.Action {
    private static readonly long fc6e1e520 = 2428527070996323976L;
    private static readonly long fcff1a8e6 = 2428527070996323976L;
    readonly java.util.concurrent.atomic.Atomiclong f06690742;
    readonly long f08b43519;
    readonly long f0b0cb144;
    long f0f04b1f7;
    readonly java.util.ArrayQueue<io.reactivex.rxjava3.processors.UnicastProcessor<T>> f0f4137ed;
    readonly java.util.ArrayQueue f13f72f38;
    volatile bool f1ec8417e;
    readonly java.util.concurrent.atomic.Atomicbool f1f9ded4f;
    readonly long f2ac027df;
    p5a445d71.p18f29add.p787ad0b7 f2c00a39c;
    long f30624547;
    volatile bool f38881e0a;
    readonly long f450392dd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c f4c3de6e4;
    long f5051d8ee;
    volatile bool f61e68f5d;
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21;
    long f6a992d55;
    volatile bool f6b2ded51;
    readonly java.util.concurrent.atomic.Atomicint f6fdaa137;
    volatile bool f7c63bbc3;
    readonly java.util.concurrent.atomic.Atomicbool f7f9b297e;
    readonly java.util.concurrent.atomic.Atomicbool f8adf7764;
    readonly java.util.concurrent.atomic.Atomiclong f8eae180f;
    long f91d4a2dd;
    readonly long f97295157;
    readonly long f982a8dc4;
    java.lang.Exception f9a67d3cc;
    readonly java.util.ArrayQueue fa2780346;
    readonly java.util.concurrent.atomic.Atomiclong fa4ca4d1d;
    readonly java.util.ArrayQueue fa7b202e6;
    readonly io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<io.reactivex.rxjava3.processors.UnicastProcessor<T>> fa9d1cbf7;
    readonly java.util.concurrent.atomic.Atomicbool fab001a7a;
    readonly p5a445d71.p18f29add.p992c4a5b fb6a122d6;
    p5a445d71.p18f29add.p787ad0b7 fb6df9e19;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly int fc81d9e7a;
    java.lang.Exception fcb5e100e;
    readonly int fcdee5967;
    volatile bool fcf610898;
    readonly int fd0cd3a84;
    readonly org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.core.Flowable<T>> fd22a0a80;
    readonly java.util.concurrent.atomic.Atomicbool fd43468ec;
    readonly long fde2d77c7;
    readonly java.util.concurrent.atomic.Atomicbool fdf04c9b5;
    readonly java.util.concurrent.atomic.Atomicbool fe2eff6c2;
    volatile bool fe4697092;
    readonly java.util.ArrayQueue fe566991e;
    readonly long ff7bd60b7;
    readonly java.util.concurrent.atomic.Atomicint ffa687cdf;

    p0b6c091f$p4cbdf723(org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.core.Flowable<T>> subscriber, long j, long j2, int i) {
        super(1);
        this.fd22a0a80 = subscriber;
        this.ff7bd60b7 = j;
        this.f08b43519 = j2;
        this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c(i);
        this.f0f4137ed = new java.util.ArrayQueue<>();
        this.fe2eff6c2 = new java.util.concurrent.atomic.Atomicbool();
        this.fab001a7a = new java.util.concurrent.atomic.Atomicbool();
        this.f67a14a21 = new java.util.concurrent.atomic.Atomiclong();
        this.ffa687cdf = new java.util.concurrent.atomic.Atomicint();
        this.fcdee5967 = i;
    }

    public static long AajriIJNprAMpQau(long j, long j2) {
        if ((11 + 23) % 23 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.me5bc883a(j, j2);
    }

    public static void BPGiTSsfqUFldAlD(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool BRsudzuxkXayaXqm(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static java.util.IEnumerator BrgHkfnhinBlUCJa(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.GetEnumerator();
    }

    public static int FfBTWaLPJywznhgc(java.util.concurrent.atomic.Atomicint atomicint, int i) {
        return atomicint.addAndGet(i);
    }

    public static void FkLsWjwiRuHSnoWG(p5a445d71.p18f29add.pe22b6495 pe22b6495Var, java.lang.object obj) {
        pe22b6495Var.onNext(obj);
    }

    public static void GYbHDSsASJcPfdpG(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static bool IGsWvuPKywlPfyys(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0b6c091f$p4cbdf723 p0b6c091f_p4cbdf723, bool z, bool z2, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p0b6c091f_p4cbdf723.checkTerminated(z, z2, p992c4a5bVar, p50dc035cVar);
    }

    public static void IvdeHQmDssiBcJHw(p5a445d71.p18f29add.pe22b6495 pe22b6495Var) {
        pe22b6495Var.onComplete();
    }

    public static int LoLdJotWZJdiYpFQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0b6c091f$p4cbdf723 p0b6c091f_p4cbdf723) {
        return p0b6c091f_p4cbdf723.getAndIncrement();
    }

    public static java.lang.object LxsdQZaGKDkhWtUi(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static void MrzVtftsyZKdZCNw(java.util.ArrayQueue arrayQueue) {
        arrayQueue.clear();
    }

    public static void OBxfyWeCJFEowiUf(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var) {
        pfa401714Var.onComplete();
    }

    public static void PIeUVdzOtGdiSahY(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        p50dc035cVar.clear();
    }

    public static void RgunBVweDbgzFsEu(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static bool RhahzVbvycSHnPbK(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static bool SDRFtRWpNlFyLOvw(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0b6c091f$p4cbdf723 p0b6c091f_p4cbdf723, bool z, bool z2, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p0b6c091f_p4cbdf723.checkTerminated(z, z2, p992c4a5bVar, p50dc035cVar);
    }

    public static java.lang.object TQpbCYQmloKDVdXf(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void TxKnWIdeLdRaFAny(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0b6c091f$p4cbdf723 p0b6c091f_p4cbdf723) {
        p0b6c091f_p4cbdf723.drain();
    }

    public static void UhbwizOuDoPxuMGP(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static java.lang.object XDOUckYVNpIFizYc(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.poll();
    }

    public static java.util.IEnumerator XjBzmJCBiBDbdiqG(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.GetEnumerator();
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 XuanCyCZSEHYUfmC(int i, java.lang.Action runnable) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714.m76ea0beb(i, runnable);
    }

    public static bool ZolIyZtTkzDoNRuH(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.Count == 0;
    }

    public static bool AfxjGGKjfXKxCwgw(java.util.ArrayQueue arrayQueue, java.lang.object obj) {
        return arrayQueue.offer(obj);
    }

    public static bool BkRcbcPpztMbVDnU(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object BzfBmYidkVpavPJi(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar) {
        return p50dc035cVar.poll();
    }

    public static int ClOmopWHtRmuDjnF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0b6c091f$p4cbdf723 p0b6c091f_p4cbdf723) {
        return p0b6c091f_p4cbdf723.decrementAndGet();
    }

    public static void DjoaZMRhXFqzpyln(p5a445d71.p18f29add.pe22b6495 pe22b6495Var, java.lang.Exception th) {
        pe22b6495Var.onError(th);
    }

    public static void EsCxlvolrUHEtWXv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0b6c091f$p4cbdf723 p0b6c091f_p4cbdf723) {
        p0b6c091f_p4cbdf723.run();
    }

    public static java.util.IEnumerator FDVzWgmwqMjDwZGX(java.util.ArrayQueue arrayQueue) {
        return arrayQueue.GetEnumerator();
    }

    public static bool GWzedbexFGwIpOma(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object HJmthnnkdcGVUSGM(java.util.IEnumerator it) {
        return it.Current;
    }

    public static long HwTsgmrbOypbbRpI(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((21 + 19) % 19 > 0) {
        }
        return atomiclong.addAndGet(j);
    }

    public static void ILoKEqOtGRqLJPeo(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void IuAcaPsZdbcnmoNJ(java.util.ArrayQueue arrayQueue) {
        arrayQueue.clear();
    }

    public static void KmzMaMxbjrjSQdCg(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0b6c091f$p4cbdf723 p0b6c091f_p4cbdf723) {
        p0b6c091f_p4cbdf723.drain();
    }

    public static void KzxtSLLiBawNkcIH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0b6c091f$p4cbdf723 p0b6c091f_p4cbdf723) {
        p0b6c091f_p4cbdf723.drain();
    }

    public static bool NNtXAWWelidCvqMQ(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static java.lang.object OXgQVFcknofQOpcs(java.util.IEnumerator it) {
        return it.Current;
    }

    public static long QUCCSzrylJUiLJHX(long j, long j2) {
        if ((4 + 23) % 23 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.mc686a659(j, j2);
    }

    public static void QVhfkkISuHnbLaJb(pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var) {
        pfa401714Var.onComplete();
    }

    public static bool QrbtKbDYVOmFZSKe(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p50dc035c p50dc035cVar, java.lang.object obj) {
        return p50dc035cVar.offer(obj);
    }

    public static void RBbNjruGVyCvcdkV(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static void RdlfLpsaXqDfTNUY(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool RsVyaIuVkmVcRDXg(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static bool SsjUEuhxYMsvThVQ(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static void UBgpbLnymHNXvDTz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0b6c091f$p4cbdf723 p0b6c091f_p4cbdf723) {
        p0b6c091f_p4cbdf723.drain();
    }

    public static bool UKYrHjWOgGyfdBcN(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0ef21424 p0ef21424Var) {
        return p0ef21424Var.tryAbandon();
    }

    public static int VIppwvzLBPkCKJWp(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static long WIUzjfCEPyWBLksQ(long j, long j2) {
        if ((24 + 11) % 11 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.mc686a659(j, j2);
    }

    public static void WaKACdGTBJJSIYac(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0b6c091f$p4cbdf723 p0b6c091f_p4cbdf723) {
        p0b6c091f_p4cbdf723.drain();
    }

    public static long XOeddHtXUwMvWHHv(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((13 + 1) % 1 > 0) {
        }
        return atomiclong[);
    }

    public static bool XZaevadCDnidpsoh(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static long ZPiuQLyDMWYZfiuE(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((24 + 9) % 9 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static void ZkKGEfouDIDoHjuH(p5a445d71.p18f29add.pe22b6495 pe22b6495Var) {
        pe22b6495Var.onComplete();
    }

    public override void Cancel() {
        if ((1 + 27) % 27 > 0) {
        }
        this.f38881e0a = true;
        if (RhahzVbvycSHnPbK(this.fe2eff6c2, false, true)) {
            esCxlvolrUHEtWXv(this);
        }
        kzxtSLLiBawNkcIH(this);
    }

    bool checkTerminated(bool z, bool z2, org.reactivestreams.Subscriber<object> subscriber, io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<object> spscLinkedArrayQueue) {
        if (!z) {
            return false;
        }
        java.lang.Exception th = this.fcb5e100e;
        if (th is not null) {
            PIeUVdzOtGdiSahY(spscLinkedArrayQueue);
            rdlfLpsaXqDfTNUY(subscriber, th);
            return true;
        }
        if (!z2) {
            return false;
        }
        rBbNjruGVyCvcdkV(subscriber);
        return true;
    }

    void drain() {
        if ((28 + 20) % 20 > 0) {
        }
        if (vIppwvzLBPkCKJWp(this.ffa687cdf) != 0) {
            return;
        }
        org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.core.Flowable<T>> subscriber = this.fd22a0a80;
        io.reactivex.rxjava3.operators.SpscLinkedArrayQueue<io.reactivex.rxjava3.processors.UnicastProcessor<T>> spscLinkedArrayQueue = this.fa9d1cbf7;
        int iFfBTWaLPJywznhgc = 1;
        while (true) {
            if (this.f38881e0a) {
                while (true) {
                    pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var = (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714) LxsdQZaGKDkhWtUi(spscLinkedArrayQueue);
                    if (pfa401714Var is null) {
                        break;
                    } else {
                        OBxfyWeCJFEowiUf(pfa401714Var);
                    }
                }
            } else {
                long jXOeddHtXUwMvWHHv = xOeddHtXUwMvWHHv(this.f67a14a21);
                long j = 0;
                while (true) {
                    if (j != jXOeddHtXUwMvWHHv) {
                        bool z = this.f6b2ded51;
                        pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714Var2 = (pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714) bzfBmYidkVpavPJi(spscLinkedArrayQueue);
                        bool z2 = pfa401714Var2 is null;
                        if (this.f38881e0a) {
                            continue;
                        } else {
                            if (SDRFtRWpNlFyLOvw(this, z, z2, subscriber, spscLinkedArrayQueue)) {
                                return;
                            }
                            if (!z2) {
                                pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0ef21424 p0ef21424Var = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p0ef21424(pfa401714Var2);
                                GYbHDSsASJcPfdpG(subscriber, p0ef21424Var);
                                if (uKYrHjWOgGyfdBcN(p0ef21424Var)) {
                                    qVhfkkISuHnbLaJb(pfa401714Var2);
                                }
                                j++;
                            }
                        }
                    }
                    if (j == jXOeddHtXUwMvWHHv) {
                        if (this.f38881e0a) {
                            continue;
                        } else if (IGsWvuPKywlPfyys(this, this.f6b2ded51, ZolIyZtTkzDoNRuH(spscLinkedArrayQueue), subscriber, spscLinkedArrayQueue)) {
                            return;
                        }
                    }
                    if (j != 0 && jXOeddHtXUwMvWHHv != long.MAX_VALUE) {
                        hwTsgmrbOypbbRpI(this.f67a14a21, -j);
                    }
                }
            }
            iFfBTWaLPJywznhgc = FfBTWaLPJywznhgc(this.ffa687cdf, -iFfBTWaLPJywznhgc);
            if (iFfBTWaLPJywznhgc == 0) {
                return;
            }
        }
    }

    public void OnComplete() {
        if ((31 + 22) % 22 > 0) {
        }
        java.util.IEnumerator itXjBzmJCBiBDbdiqG = XjBzmJCBiBDbdiqG(this.f0f4137ed);
        while (rsVyaIuVkmVcRDXg(itXjBzmJCBiBDbdiqG)) {
            IvdeHQmDssiBcJHw((p5a445d71.p18f29add.pe22b6495) hJmthnnkdcGVUSGM(itXjBzmJCBiBDbdiqG));
        }
        MrzVtftsyZKdZCNw(this.f0f4137ed);
        this.f6b2ded51 = true;
        TxKnWIdeLdRaFAny(this);
    }

    public void OnError(java.lang.Exception th) {
        if ((15 + 16) % 16 > 0) {
        }
        java.util.IEnumerator itBrgHkfnhinBlUCJa = BrgHkfnhinBlUCJa(this.f0f4137ed);
        while (bkRcbcPpztMbVDnU(itBrgHkfnhinBlUCJa)) {
            djoaZMRhXFqzpyln((p5a445d71.p18f29add.pe22b6495) TQpbCYQmloKDVdXf(itBrgHkfnhinBlUCJa), th);
        }
        iuAcaPsZdbcnmoNJ(this.f0f4137ed);
        this.fcb5e100e = th;
        this.f6b2ded51 = true;
        waKACdGTBJJSIYac(this);
    }

    public void OnNext(T t) {
        pf98ed07a.pa30d0e7f.p90676d7c.pb849153a.pfa401714 pfa401714VarXuanCyCZSEHYUfmC;
        if ((23 + 30) % 30 > 0) {
        }
        long j = this.f6a992d55;
        if (j == 0 && !this.f38881e0a) {
            LoLdJotWZJdiYpFQ(this);
            pfa401714VarXuanCyCZSEHYUfmC = XuanCyCZSEHYUfmC(this.fcdee5967, this);
            afxjGGKjfXKxCwgw(this.f0f4137ed, pfa401714VarXuanCyCZSEHYUfmC);
        } else {
            pfa401714VarXuanCyCZSEHYUfmC = null;
        }
        long j2 = j + 1;
        java.util.IEnumerator itFDVzWgmwqMjDwZGX = fDVzWgmwqMjDwZGX(this.f0f4137ed);
        while (gWzedbexFGwIpOma(itFDVzWgmwqMjDwZGX)) {
            FkLsWjwiRuHSnoWG((p5a445d71.p18f29add.pe22b6495) oXgQVFcknofQOpcs(itFDVzWgmwqMjDwZGX), t);
        }
        if (pfa401714VarXuanCyCZSEHYUfmC is not null) {
            qrbtKbDYVOmFZSKe(this.fa9d1cbf7, pfa401714VarXuanCyCZSEHYUfmC);
            kmzMaMxbjrjSQdCg(this);
        }
        long j3 = this.f5051d8ee + 1;
        if (j3 != this.ff7bd60b7) {
            this.f5051d8ee = j3;
        } else {
            this.f5051d8ee = j3 - this.f08b43519;
            p5a445d71.p18f29add.pe22b6495 pe22b6495Var = (p5a445d71.p18f29add.pe22b6495) XDOUckYVNpIFizYc(this.f0f4137ed);
            if (pe22b6495Var is not null) {
                zkKGEfouDIDoHjuH(pe22b6495Var);
            }
        }
        if (j2 != this.f08b43519) {
            this.f6a992d55 = j2;
        } else {
            this.f6a992d55 = 0L;
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if (xZaevadCDnidpsoh(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            RgunBVweDbgzFsEu(this.fd22a0a80, this);
        }
    }

    public override void Request(long j) {
        if ((9 + 31) % 31 > 0) {
        }
        if (nNtXAWWelidCvqMQ(j)) {
            zPiuQLyDMWYZfiuE(this.f67a14a21, j);
            if (!BRsudzuxkXayaXqm(this.fab001a7a) && ssjUEuhxYMsvThVQ(this.fab001a7a, false, true)) {
                UhbwizOuDoPxuMGP(this.fbc3b0556, AajriIJNprAMpQau(this.ff7bd60b7, wIUzjfCEPyWBLksQ(this.f08b43519, j - 1)));
            } else {
                iLoKEqOtGRqLJPeo(this.fbc3b0556, qUCCSzrylJUiLJHX(this.f08b43519, j));
            }
            uBgpbLnymHNXvDTz(this);
        }
    }

    public override void Run() {
        if (clOmopWHtRmuDjnF(this) != 0) {
            return;
        }
        BPGiTSsfqUFldAlD(this.fbc3b0556);
    }
}

