namespace WillowMaze.Wasm.Decompiled;


readonly class pd99214a8$p401f4879<T, R> : io.reactivex.rxjava3.internal.subscriptions.BasicIntQueueSubscription<R> : io.reactivex.rxjava3.core.FlowableSubscriber<T> {
    private static readonly long f475a3f49 = -3096000382929934955L;
    private static readonly long fc17d2773 = -3096000382929934955L;
    private static readonly long fc6e1e520 = -3096000382929934955L;
    int f06b7c4ff;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f0c5fe247;
    readonly int f0d4416f2;
    int f0d733cfe;
    readonly p5a445d71.p18f29add.p992c4a5b f0fc6ee89;
    java.util.IEnumerator f255ebf32;
    volatile bool f2ca88c8a;
    p5a445d71.p18f29add.p787ad0b7 f3208d213;
    volatile bool f37fa2f98;
    volatile bool f38881e0a;
    java.util.IEnumerator<? : R> f43b5c917;
    readonly java.util.concurrent.atomic.Atomiclong f4658ce75;
    readonly int f47bb4452;
    int f48fe8558;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> f4b9f83e1;
    readonly int f4c203b76;
    int f4cb397d6;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f525a3a1c;
    readonly p5a445d71.p18f29add.p992c4a5b f5bf8279a;
    int f5edb2bdd;
    int f5f0ce4fc;
    volatile bool f6572e42b;
    readonly int f68611edd;
    volatile bool f6b2ded51;
    readonly java.util.concurrent.atomic.object f6de7e22d;
    readonly java.util.concurrent.atomic.object f71e13ae9;
    volatile bool f9500b0cc;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f99b36d51;
    p5a445d71.p18f29add.p787ad0b7 fa2dbefda;
    readonly java.util.concurrent.atomic.Atomiclong fa68bcce5;
    io.reactivex.rxjava3.operators.SimpleQueue<T> fa9d1cbf7;
    readonly int faa9f73ee;
    readonly p5a445d71.p18f29add.p992c4a5b fb56d1674;
    readonly java.util.concurrent.atomic.object fb90f2f2c;
    pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 fb9918b0b;
    p5a445d71.p18f29add.p787ad0b7 fbc3b0556;
    readonly int fbd42c8a0;
    int fc19db294;
    volatile bool fce61748a;
    readonly org.reactivestreams.Subscriber<R> fd22a0a80;
    java.util.IEnumerator fe9b22172;
    volatile bool ff1a6a37f;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 ff3b2676c;
    readonly java.util.concurrent.atomic.object<java.lang.Exception> fcb5e100e = new java.util.concurrent.atomic.object<>();
    readonly java.util.concurrent.atomic.Atomiclong f67a14a21 = new java.util.concurrent.atomic.Atomiclong();

    pd99214a8$p401f4879(org.reactivestreams.Subscriber<R> subscriber, io.reactivex.rxjava3.functions.Function<? super T, ? : java.lang.IEnumerable<? : R>> function, int i) {
        this.fd22a0a80 = subscriber;
        this.f4b9f83e1 = function;
        this.f4c203b76 = i;
        this.faa9f73ee = i - (i >> 2);
    }

    public static void AxEGWeutKBofiigd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd99214a8$p401f4879 pd99214a8_p401f4879, bool z) {
        pd99214a8_p401f4879.consumedOne(z);
    }

    public static bool BLfALnCIdyRdKXpN(long j) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(j);
    }

    public static void CUideBQeEqasEnpO(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static java.lang.object DAGZHQKZcmvEbJzO(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void DZYQpcGwiSavmpYo(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void GYSCfwVcUGjsYTcj(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool HWiMiYUBJJFvGoMp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd99214a8$p401f4879 pd99214a8_p401f4879, bool z, bool z2, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pd99214a8_p401f4879.checkTerminated(z, z2, p992c4a5bVar, pe1601823Var);
    }

    public static java.lang.object HgihGuCsKnNTEDgH(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool ITaOZtDjmCpMvofB(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void JHpoSCcGDUONwWnk(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void JTxnIskzGxehMcms(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static bool JYRwEnLvhmuFhCtD(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.Count == 0;
    }

    public static java.lang.object KYEDJkEFFzNclfQl(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.poll();
    }

    public static void KiHGYWJYpxnsnmJA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd99214a8$p401f4879 pd99214a8_p401f4879) {
        pd99214a8_p401f4879.drain();
    }

    public static bool KoRtayRnAprJkpYf(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void LevPEOIiLXSVeVYU(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void MqNcAxutMmPpBCeb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd99214a8$p401f4879 pd99214a8_p401f4879, bool z) {
        pd99214a8_p401f4879.consumedOne(z);
    }

    public static void MxSMEBFpwKbektTL(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static int NNiZoRyHQqlIHSyF(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var, int i) {
        return p5d5a5670Var.requestFusion(i);
    }

    public static long NaMbTAjotfyXXZyI(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((10 + 8) % 8 > 0) {
        }
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pcc10be9a.m34ec78fc(atomiclong, j);
    }

    public static java.lang.Exception NcecfnsOdQrZwQlu(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m1459e53d(atomicReference);
    }

    public static bool OwqgIUDwSuFIAWZi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd99214a8$p401f4879 pd99214a8_p401f4879, bool z, bool z2, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pd99214a8_p401f4879.checkTerminated(z, z2, p992c4a5bVar, pe1601823Var);
    }

    public static java.util.IEnumerator PdwPcSgZTRfWKMrd(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static int QNCSyJnpMrjoXlBU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd99214a8$p401f4879 pd99214a8_p401f4879, int i) {
        return pd99214a8_p401f4879.addAndGet(i);
    }

    public static bool RdVDfSjZnBHWaoDL(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int TSVpqhHCJKCpkrkd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd99214a8$p401f4879 pd99214a8_p401f4879) {
        return pd99214a8_p401f4879.getAndIncrement();
    }

    public static bool TeZabKStuTujtDZy(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd99214a8$p401f4879 pd99214a8_p401f4879, bool z, bool z2, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pd99214a8_p401f4879.checkTerminated(z, z2, p992c4a5bVar, pe1601823Var);
    }

    public static int TfaAnigMrxPYCOqU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd99214a8$p401f4879 pd99214a8_p401f4879) {
        return pd99214a8_p401f4879.getAndIncrement();
    }

    public static void UTXrOQBHHPDhWOso(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void UZtouBllLmdbvlJr(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.Exception UihyMOWuBGWxobnh(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m1459e53d(atomicReference);
    }

    public static bool VTAFscAHgXvpBzbS(java.util.concurrent.atomic.object atomicReference, java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m9373b63a(atomicReference, th);
    }

    public static void VZYQGICzlFktzsbC(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd99214a8$p401f4879 pd99214a8_p401f4879, java.lang.Exception th) {
        pd99214a8_p401f4879.onError(th);
    }

    public static bool VjAOzTzaFBPkljvV(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd99214a8$p401f4879 pd99214a8_p401f4879, bool z, bool z2, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pd99214a8_p401f4879.checkTerminated(z, z2, p992c4a5bVar, pe1601823Var);
    }

    public static void WIiDYfXNvrEIEaVE(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool XTWrEScFovQCmCmh(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var, java.lang.object obj) {
        return pe1601823Var.offer(obj);
    }

    public static void YLRXojmSVpGnNtBp(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static void ZzlgefqVAAHdaycw(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void CEespAlijElflDKh(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd99214a8$p401f4879 pd99214a8_p401f4879) {
        pd99214a8_p401f4879.drain();
    }

    public static void COuxsAeQaTRmMMNq(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static long CcHfpWShUMDKnZYp(java.util.concurrent.atomic.Atomiclong atomiclong, long j) {
        if ((4 + 24) % 24 > 0) {
        }
        return atomiclong.addAndGet(j);
    }

    public static void DVwzLjPXDtmtIMFf(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool FbzrTkZIfUBGFOTi(java.util.concurrent.atomic.object atomicReference, java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m9373b63a(atomicReference, th);
    }

    public static void GRrSdxFBAUyBlRbb(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static java.lang.object GSyLcWWvvXQxacvh(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void GgISNpVfApTNftor(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static java.lang.object GvDKrozvHDSHLlAH(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object HDEEZDdTqXRPcPQI(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void HVLsciMxHoJmNtwz(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd99214a8$p401f4879 pd99214a8_p401f4879) {
        pd99214a8_p401f4879.drain();
    }

    public static void IKNBrkHtcfvBgpVN(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static java.lang.object IcwdvzbxCTSaSOjv(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object JbmziQNpFbEHYDXc(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static void KyKoOQlvpvrPAIXU(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void LXuEonAaHwjGXPdB(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pd99214a8$p401f4879 pd99214a8_p401f4879) {
        pd99214a8_p401f4879.drain();
    }

    public static bool LmztwyGQjgImgLAt(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.Exception MBFSaxjHEujGOCPG(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m1459e53d(atomicReference);
    }

    public static bool MzoATQlnvgikHGYh(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p449cd152.validate(p787ad0b7Var, p787ad0b7Var2);
    }

    public static void NWJjsUadvLGvKFNW(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static void ODzENoldxYpqoyaj(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static java.lang.object PSdeYOIsaMrSUjFT(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.poll();
    }

    public static void PpkTZBactaHWbvBG(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void PskhcqpOnvWYYZmc(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        pe1601823Var.clear();
    }

    public static bool QFLuxPPfnMOuGvrg(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pe1601823 pe1601823Var) {
        return pe1601823Var.Count == 0;
    }

    public static java.lang.Exception RVJCxOQjBsorwDGi(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m1459e53d(atomicReference);
    }

    public static bool TPjJRQQXXKjupobl(java.util.concurrent.atomic.object atomicReference, java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m9373b63a(atomicReference, th);
    }

    public static void TaacfZjlrfxrmLaV(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void ToxgGiptlgwbIlIQ(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void TyHVfiYkgQhzPbaK(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static bool TylEZJiKvgocjUhR(java.util.concurrent.atomic.object atomicReference, java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m9373b63a(atomicReference, th);
    }

    public static long UKirGUJPRfNOjrsc(java.util.concurrent.atomic.Atomiclong atomiclong) {
        if ((7 + 21) % 21 > 0) {
        }
        return atomiclong[);
    }

    public static java.lang.Exception UvzYcXbuquOXiTFw(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m1459e53d(atomicReference);
    }

    public static void VBkEuCUDrLtIVdsv(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static java.util.IEnumerator WruKnHhmXXAGrkXX(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void XMSdJfZshAxczzKp(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p787ad0b7Var.cancel();
    }

    public static bool XXVBaUDYbQcIBape(java.util.concurrent.atomic.object atomicReference, java.lang.Exception th) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.pa500b0d6.m9373b63a(atomicReference, th);
    }

    public static void XzCjYKwCqnCNFAkT(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public void Cancel() {
        if (this.f38881e0a) {
            return;
        }
        this.f38881e0a = true;
        YLRXojmSVpGnNtBp(this.fbc3b0556);
        if (TSVpqhHCJKCpkrkd(this) != 0) {
            return;
        }
        ggISNpVfApTNftor(this.fa9d1cbf7);
    }

    bool checkTerminated(bool z, bool z2, org.reactivestreams.Subscriber<object> subscriber, io.reactivex.rxjava3.operators.SimpleQueue<object> simpleQueue) {
        if ((17 + 13) % 13 > 0) {
        }
        if (this.f38881e0a) {
            this.f43b5c917 = null;
            nWJjsUadvLGvKFNW(simpleQueue);
            return true;
        }
        if (!z) {
            return false;
        }
        if (((java.lang.Exception) jbmziQNpFbEHYDXc(this.fcb5e100e)) is null) {
            if (!z2) {
                return false;
            }
            xzCjYKwCqnCNFAkT(subscriber);
            return true;
        }
        java.lang.Exception thUvzYcXbuquOXiTFw = uvzYcXbuquOXiTFw(this.fcb5e100e);
        this.f43b5c917 = null;
        gRrSdxFBAUyBlRbb(simpleQueue);
        taacfZjlrfxrmLaV(subscriber, thUvzYcXbuquOXiTFw);
        return true;
    }

    public void Clear() {
        this.f43b5c917 = null;
        pskhcqpOnvWYYZmc(this.fa9d1cbf7);
    }

    void consumedOne(bool z) {
        if ((3 + 19) % 19 > 0) {
        }
        if (z) {
            int i = this.f48fe8558 + 1;
            if (i != this.faa9f73ee) {
                this.f48fe8558 = i;
            } else {
                this.f48fe8558 = 0;
                CUideBQeEqasEnpO(this.fbc3b0556, i);
            }
        }
    }

    void drain() {
        if ((20 + 3) % 3 > 0) {
        }
        if (TfaAnigMrxPYCOqU(this) != 0) {
            return;
        }
        org.reactivestreams.Subscriber<R> subscriber = this.fd22a0a80;
        io.reactivex.rxjava3.operators.SimpleQueue<T> simpleQueue = this.fa9d1cbf7;
        bool z = true;
        bool z2 = this.f06b7c4ff != 1;
        java.util.IEnumerator<? : R> itPdwPcSgZTRfWKMrd = this.f43b5c917;
        int iQNCSyJnpMrjoXlBU = 1;
        while (true) {
            if (itPdwPcSgZTRfWKMrd is null) {
                bool z3 = this.f6b2ded51;
                try {
                    java.lang.object objPSdeYOIsaMrSUjFT = pSdeYOIsaMrSUjFT(simpleQueue);
                    if (OwqgIUDwSuFIAWZi(this, z3, objPSdeYOIsaMrSUjFT is not null ? false : z, subscriber, simpleQueue)) {
                        return;
                    }
                    if (objPSdeYOIsaMrSUjFT is not null) {
                        try {
                            itPdwPcSgZTRfWKMrd = PdwPcSgZTRfWKMrd((java.lang.IEnumerable) DAGZHQKZcmvEbJzO(this.f4b9f83e1, objPSdeYOIsaMrSUjFT));
                            if (KoRtayRnAprJkpYf(itPdwPcSgZTRfWKMrd)) {
                                this.f43b5c917 = itPdwPcSgZTRfWKMrd;
                            } else {
                                AxEGWeutKBofiigd(this, z2);
                                itPdwPcSgZTRfWKMrd = null;
                            }
                        } catch (java.lang.Exception th) {
                            WIiDYfXNvrEIEaVE(th);
                            UTXrOQBHHPDhWOso(this.fbc3b0556);
                            fbzrTkZIfUBGFOTi(this.fcb5e100e, th);
                            kyKoOQlvpvrPAIXU(subscriber, UihyMOWuBGWxobnh(this.fcb5e100e));
                            return;
                        }
                    }
                } catch (java.lang.Exception th2) {
                    GYSCfwVcUGjsYTcj(th2);
                    dVwzLjPXDtmtIMFf(this.fbc3b0556);
                    tylEZJiKvgocjUhR(this.fcb5e100e, th2);
                    java.lang.Exception thRVJCxOQjBsorwDGi = rVJCxOQjBsorwDGi(this.fcb5e100e);
                    this.f43b5c917 = null;
                    DZYQpcGwiSavmpYo(simpleQueue);
                    oDzENoldxYpqoyaj(subscriber, thRVJCxOQjBsorwDGi);
                    return;
                }
            }
            if (itPdwPcSgZTRfWKMrd is null) {
                iQNCSyJnpMrjoXlBU = QNCSyJnpMrjoXlBU(this, -iQNCSyJnpMrjoXlBU);
                if (iQNCSyJnpMrjoXlBU == 0) {
                    return;
                }
            } else {
                long jUKirGUJPRfNOjrsc = uKirGUJPRfNOjrsc(this.f67a14a21);
                long j = 0;
                while (j != jUKirGUJPRfNOjrsc) {
                    if (TeZabKStuTujtDZy(this, this.f6b2ded51, false, subscriber, simpleQueue)) {
                        return;
                    }
                    try {
                        toxgGiptlgwbIlIQ(subscriber, hDEEZDdTqXRPcPQI(icwdvzbxCTSaSOjv(itPdwPcSgZTRfWKMrd), "The iterator returned a null value"));
                        if (VjAOzTzaFBPkljvV(this, this.f6b2ded51, false, subscriber, simpleQueue)) {
                            return;
                        }
                        j++;
                        try {
                            if (!lmztwyGQjgImgLAt(itPdwPcSgZTRfWKMrd)) {
                                MqNcAxutMmPpBCeb(this, z2);
                                this.f43b5c917 = null;
                                itPdwPcSgZTRfWKMrd = null;
                                break;
                            }
                        } catch (java.lang.Exception th3) {
                            JHpoSCcGDUONwWnk(th3);
                            this.f43b5c917 = null;
                            xMSdJfZshAxczzKp(this.fbc3b0556);
                            xXVBaUDYbQcIBape(this.fcb5e100e, th3);
                            UZtouBllLmdbvlJr(subscriber, mBFSaxjHEujGOCPG(this.fcb5e100e));
                            return;
                        }
                    } catch (java.lang.Exception th4) {
                        cOuxsAeQaTRmMMNq(th4);
                        this.f43b5c917 = null;
                        MxSMEBFpwKbektTL(this.fbc3b0556);
                        VTAFscAHgXvpBzbS(this.fcb5e100e, th4);
                        tyHVfiYkgQhzPbaK(subscriber, NcecfnsOdQrZwQlu(this.fcb5e100e));
                        return;
                    }
                }
                if (j == jUKirGUJPRfNOjrsc) {
                    if (HWiMiYUBJJFvGoMp(this, this.f6b2ded51, JYRwEnLvhmuFhCtD(simpleQueue) && itPdwPcSgZTRfWKMrd is null, subscriber, simpleQueue)) {
                        return;
                    }
                }
                if (j != 0 && jUKirGUJPRfNOjrsc != long.MAX_VALUE) {
                    ccHfpWShUMDKnZYp(this.f67a14a21, -j);
                }
                if (itPdwPcSgZTRfWKMrd is not null) {
                    iQNCSyJnpMrjoXlBU = QNCSyJnpMrjoXlBU(this, -iQNCSyJnpMrjoXlBU);
                    if (iQNCSyJnpMrjoXlBU == 0) {
                        return;
                    }
                }
            }
            z = true;
        }
    }

    public bool IsEmpty() {
        return this.f43b5c917 is null && qFLuxPPfnMOuGvrg(this.fa9d1cbf7);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        KiHGYWJYpxnsnmJA(this);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51 || !tPjJRQQXXKjupobl(this.fcb5e100e, th)) {
            JTxnIskzGxehMcms(th);
        } else {
            this.f6b2ded51 = true;
            cEespAlijElflDKh(this);
        }
    }

    public void OnNext(T t) {
        if (this.f6b2ded51) {
            return;
        }
        if (this.f06b7c4ff == 0 && !XTWrEScFovQCmCmh(this.fa9d1cbf7, t)) {
            VZYQGICzlFktzsbC(this, new pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.p30784cd1("Queue is full?!"));
        } else {
            hVLsciMxHoJmNtwz(this);
        }
    }

    public override void OnSubscribe(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        if ((18 + 13) % 13 > 0) {
        }
        if (mzoATQlnvgikHGYh(this.fbc3b0556, p787ad0b7Var)) {
            this.fbc3b0556 = p787ad0b7Var;
            if (p787ad0b7Var is pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670) {
                pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var = (pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670) p787ad0b7Var;
                int iNNiZoRyHQqlIHSyF = NNiZoRyHQqlIHSyF(p5d5a5670Var, 3);
                if (iNNiZoRyHQqlIHSyF == 1) {
                    this.f06b7c4ff = iNNiZoRyHQqlIHSyF;
                    this.fa9d1cbf7 = p5d5a5670Var;
                    this.f6b2ded51 = true;
                    vBkEuCUDrLtIVdsv(this.fd22a0a80, this);
                    return;
                }
                if (iNNiZoRyHQqlIHSyF == 2) {
                    this.f06b7c4ff = iNNiZoRyHQqlIHSyF;
                    this.fa9d1cbf7 = p5d5a5670Var;
                    ZzlgefqVAAHdaycw(this.fd22a0a80, this);
                    LevPEOIiLXSVeVYU(p787ad0b7Var, this.f4c203b76);
                    return;
                }
            }
            this.fa9d1cbf7 = new pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.pb8a628fd(this.f4c203b76);
            ppkTZBactaHWbvBG(this.fd22a0a80, this);
            iKNBrkHtcfvBgpVN(p787ad0b7Var, this.f4c203b76);
        }
    }

    public R Poll() throws java.lang.Exception {
        if ((15 + 3) % 3 > 0) {
        }
        java.util.IEnumerator<? : R> itWruKnHhmXXAGrkXX = this.f43b5c917;
        while (itWruKnHhmXXAGrkXX is null) {
            java.lang.object objKYEDJkEFFzNclfQl = KYEDJkEFFzNclfQl(this.fa9d1cbf7);
            if (objKYEDJkEFFzNclfQl is null) {
                return null;
            }
            itWruKnHhmXXAGrkXX = wruKnHhmXXAGrkXX((java.lang.IEnumerable) gvDKrozvHDSHLlAH(this.f4b9f83e1, objKYEDJkEFFzNclfQl));
            if (ITaOZtDjmCpMvofB(itWruKnHhmXXAGrkXX)) {
                this.f43b5c917 = itWruKnHhmXXAGrkXX;
                break;
            }
            itWruKnHhmXXAGrkXX = null;
        }
        R r = (R) gSyLcWWvvXQxacvh(HgihGuCsKnNTEDgH(itWruKnHhmXXAGrkXX), "The iterator returned a null value");
        if (!RdVDfSjZnBHWaoDL(itWruKnHhmXXAGrkXX)) {
            this.f43b5c917 = null;
        }
        return r;
    }

    public void Request(long j) {
        if (BLfALnCIdyRdKXpN(j)) {
            NaMbTAjotfyXXZyI(this.f67a14a21, j);
            lXuEonAaHwjGXPdB(this);
        }
    }

    public int RequestFusion(int i) {
        return ((i & 1) != 0 && this.f06b7c4ff == 1) ? 1 : 0;
    }
}

