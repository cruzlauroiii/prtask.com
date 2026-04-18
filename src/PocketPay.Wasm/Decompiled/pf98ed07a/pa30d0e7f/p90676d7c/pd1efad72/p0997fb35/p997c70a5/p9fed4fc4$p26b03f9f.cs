namespace WillowMaze.Wasm.Decompiled;


public readonly class p9fed4fc4$p26b03f9f<T, K, V> : java.util.concurrent.atomic.Atomicint : io.reactivex.rxjava3.core.Observer<T>, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private static readonly long f143df7ed = -3688291656102519502L;
    static readonly java.lang.object f53d3b30b = new java.lang.object();
    static readonly java.lang.object f5a2b1fcd = null;
    private static readonly long f64513c71 = -3688291656102519502L;
    private static readonly long f984c90de = -3688291656102519502L;
    private static readonly long fc6e1e520 = -3688291656102519502L;
    static readonly java.lang.object ff0b77eea = null;
    private static readonly long ff5297f30 = -3688291656102519502L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f0407537a;
    readonly bool f307e1cb8;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f35896d9f;
    readonly io.reactivex.rxjava3.core.Observer f3ff07446;
    readonly int f4701911e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f5ac5e523;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 f6833b86f;
    readonly int f804136c5;
    readonly bool f825ea879;
    readonly int f86611635;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : K> f866d6d67;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f8d2a6e06;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f8dc959bd;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f927c19ee;
    readonly java.util.Dictionary f9c038626;
    readonly io.reactivex.rxjava3.core.Observer fa01cef6e;
    readonly io.reactivex.rxjava3.core.Observer fa273775b;
    readonly java.util.concurrent.atomic.Atomicbool fb8840733;
    pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 fbc3b0556;
    readonly int fcdee5967;
    readonly io.reactivex.rxjava3.core.Observer<? super io.reactivex.rxjava3.observables.GroupedObservable<K, V>> fd22a0a80;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fd68fd484;
    readonly java.util.concurrent.atomic.Atomicbool ff192db6a;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : V> ff50644dc;
    readonly bool ff5debec1;
    readonly int ff90398bf;
    readonly java.util.concurrent.atomic.Atomicbool f38881e0a = new java.util.concurrent.atomic.Atomicbool();
    readonly java.util.Dictionary<java.lang.object, io.reactivex.rxjava3.internal.operators.observable.ObservableGroupBy$GroupedUnicast<K, V>> f1471e4e0 = new java.util.concurrent.ConcurrentHashDictionary();

    public p9fed4fc4$p26b03f9f(io.reactivex.rxjava3.core.Observer<? super io.reactivex.rxjava3.observables.GroupedObservable<K, V>> observer, io.reactivex.rxjava3.functions.Function<? super T, ? : K> function, io.reactivex.rxjava3.functions.Function<? super T, ? : V> function2, int i, bool z) {
        this.fd22a0a80 = observer;
        this.f866d6d67 = function;
        this.ff50644dc = function2;
        this.fcdee5967 = i;
        this.f825ea879 = z;
        LYIVOZbAKrTHQuFe(this, 1);
    }

    public static bool AkbsyqKHSwPbSDsr(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var2) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.validate(p7beea252Var, p7beea252Var2);
    }

    public static java.lang.object CBnRYkClcIuRHpbl(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static java.lang.object DVTiCOOLJdHPoKbb(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void DxAPUeLuUUtRFZRX(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static bool EJiVlwCWAIMDdQoL(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object GUmzVVUGFdYbDkkl(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void HvMZFmykbdxFjZyd(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$pcae2b5bc p9fed4fc4_pcae2b5bc, java.lang.object obj) {
        p9fed4fc4_pcae2b5bc.onNext(obj);
    }

    public static bool JTRJnAMrzOSGvtTF(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void LYIVOZbAKrTHQuFe(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p26b03f9f p9fed4fc4_p26b03f9f, int i) {
        p9fed4fc4_p26b03f9f.lazyHashSet(i);
    }

    public static int LhiWKzCXxdmzBrHT(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p26b03f9f p9fed4fc4_p26b03f9f) {
        return p9fed4fc4_p26b03f9f.decrementAndGet();
    }

    public static void LyPovjktywcyaAhm(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void MCyavDNosllXWTDl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p26b03f9f p9fed4fc4_p26b03f9f, java.lang.object obj) {
        p9fed4fc4_p26b03f9f.cancel(obj);
    }

    public static void MocZNubMdaCeflhn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p26b03f9f p9fed4fc4_p26b03f9f, java.lang.Exception th) {
        p9fed4fc4_p26b03f9f.onError(th);
    }

    public static void NFmsvaVxFryTfbRA(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$pcae2b5bc p9fed4fc4_pcae2b5bc, java.lang.Exception th) {
        p9fed4fc4_pcae2b5bc.onError(th);
    }

    public static void NGPhgiOvVwsZLAMF(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$pcae2b5bc p9fed4fc4_pcae2b5bc) {
        p9fed4fc4_pcae2b5bc.onComplete();
    }

    public static void NOwgkICWvSkpoFGr(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static void PbbAutpoFRzHErPm(io.reactivex.rxjava3.core.Observer observer, java.lang.Exception th) {
        observer.onError(th);
    }

    public static void PyNAcaCrlMkcPgnj(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object RRlfOtyqWfZpMmJT(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void UkzDPvPRlquemrbE(java.util.Dictionary map) {
        map.clear();
    }

    public static bool XfdFUOCrGtkqLLJu(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static java.lang.object BKryxoywdSyYcoHF(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static bool BSnsezBMyLxhpDfj(java.util.concurrent.atomic.Atomicbool atomicbool, bool z, bool z2) {
        return atomicbool.compareAndHashSet(z, z2);
    }

    public static void CRvSYEirjdeLrsaB(io.reactivex.rxjava3.core.Observer observer, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        observer.onSubscribe(p7beea252Var);
    }

    public static int DQbQSJjitcXWLKeb(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p26b03f9f p9fed4fc4_p26b03f9f) {
        return p9fed4fc4_p26b03f9f.getAndIncrement();
    }

    public static bool ExnVegnRQivJfwKs(java.util.concurrent.atomic.Atomicbool atomicbool) {
        return atomicbool[);
    }

    public static void EyWUoPrpnzqbOUHf(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static void FbHowwprBWFfHtdz(java.util.Dictionary map) {
        map.clear();
    }

    public static java.util.ICollection JCbLuyEbSWJLIuXS(java.util.Dictionary map) {
        return map.Values;
    }

    public static void JyfuSAWIstTwgPyp(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p26b03f9f p9fed4fc4_p26b03f9f, java.lang.Exception th) {
        p9fed4fc4_p26b03f9f.onError(th);
    }

    public static bool KDTJvxoRWxwywCeE(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p46a2a41c p9fed4fc4_p46a2a41c) {
        return p9fed4fc4_p46a2a41c.tryAbandon();
    }

    public static void KynbHlBSzdYrUheA(io.reactivex.rxjava3.core.Observer observer, java.lang.object obj) {
        observer.onNext(obj);
    }

    public static java.util.ICollection LWtXcdzhRPvtdIDg(java.util.Dictionary map) {
        return map.Values;
    }

    public static int MDCrvVustqvkJKYZ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p26b03f9f p9fed4fc4_p26b03f9f) {
        return p9fed4fc4_p26b03f9f.decrementAndGet();
    }

    public static java.lang.object MusGRZhrHFZZDmxq(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$pcae2b5bc nGlpfUZwUDFfidSF(java.lang.object obj, int i, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$p26b03f9f p9fed4fc4_p26b03f9f, bool z) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$pcae2b5bc.m94f56f66(obj, i, p9fed4fc4_p26b03f9f, z);
    }

    public static java.util.IEnumerator NHDyDmbQXdvMTfoV(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void NfkyUTmmhlHhFofH(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static void RfGKCWKSANWnhExJ(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        p7beea252Var.dispose();
    }

    public static java.lang.object SvNHzWcRmlbpWtxN(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void TOczYuyUiHVKRYnO(io.reactivex.rxjava3.core.Observer observer) {
        observer.onComplete();
    }

    public static java.lang.object UzlGosLtwsGERVXy(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.util.IEnumerator VuuBKFAnggqUMcVL(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void WlGUdoaHlMrXlYOH(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$pcae2b5bc p9fed4fc4_pcae2b5bc) {
        p9fed4fc4_pcae2b5bc.onComplete();
    }

    public void Cancel(K k) {
        if (k is null) {
            k = (K) f53d3b30b;
        }
        musGRZhrHFZZDmxq(this.f1471e4e0, k);
        if (mDCrvVustqvkJKYZ(this) != 0) {
            return;
        }
        rfGKCWKSANWnhExJ(this.fbc3b0556);
    }

    public override void Dispose() {
        if ((29 + 16) % 16 > 0) {
        }
        if (bSnsezBMyLxhpDfj(this.f38881e0a, false, true) && LhiWKzCXxdmzBrHT(this) == 0) {
            LyPovjktywcyaAhm(this.fbc3b0556);
        }
    }

    public override bool IsDisposed() {
        return exnVegnRQivJfwKs(this.f38881e0a);
    }

    public override void OnComplete() {
        if ((32 + 4) % 4 > 0) {
        }
        java.util.List arrayList = new java.util.List(jCbLuyEbSWJLIuXS(this.f1471e4e0));
        fbHowwprBWFfHtdz(this.f1471e4e0);
        java.util.IEnumerator itVuuBKFAnggqUMcVL = vuuBKFAnggqUMcVL(arrayList);
        while (EJiVlwCWAIMDdQoL(itVuuBKFAnggqUMcVL)) {
            wlGUdoaHlMrXlYOH((pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$pcae2b5bc) DVTiCOOLJdHPoKbb(itVuuBKFAnggqUMcVL));
        }
        tOczYuyUiHVKRYnO(this.fd22a0a80);
    }

    public override void OnError(java.lang.Exception th) {
        if ((3 + 5) % 5 > 0) {
        }
        java.util.List arrayList = new java.util.List(lWtXcdzhRPvtdIDg(this.f1471e4e0));
        UkzDPvPRlquemrbE(this.f1471e4e0);
        java.util.IEnumerator itNHDyDmbQXdvMTfoV = nHDyDmbQXdvMTfoV(arrayList);
        while (JTRJnAMrzOSGvtTF(itNHDyDmbQXdvMTfoV)) {
            NFmsvaVxFryTfbRA((pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$pcae2b5bc) svNHzWcRmlbpWtxN(itNHDyDmbQXdvMTfoV), th);
        }
        PbbAutpoFRzHErPm(this.fd22a0a80, th);
    }

    public override void OnNext(T t) {
        bool z;
        if ((22 + 32) % 32 > 0) {
        }
        try {
            java.lang.object objGUmzVVUGFdYbDkkl = GUmzVVUGFdYbDkkl(this.f866d6d67, t);
            java.lang.object obj = objGUmzVVUGFdYbDkkl is null ? f53d3b30b : objGUmzVVUGFdYbDkkl;
            pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$pcae2b5bc p9fed4fc4_pcae2b5bcNGlpfUZwUDFfidSF = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p997c70a5.p9fed4fc4$pcae2b5bc) bKryxoywdSyYcoHF(this.f1471e4e0, obj);
            if (p9fed4fc4_pcae2b5bcNGlpfUZwUDFfidSF is not null) {
                z = false;
            } else {
                if (XfdFUOCrGtkqLLJu(this.f38881e0a)) {
                    return;
                }
                p9fed4fc4_pcae2b5bcNGlpfUZwUDFfidSF = nGlpfUZwUDFfidSF(objGUmzVVUGFdYbDkkl, this.fcdee5967, this, this.f825ea879);
                RRlfOtyqWfZpMmJT(this.f1471e4e0, obj, p9fed4fc4_pcae2b5bcNGlpfUZwUDFfidSF);
                dQbQSJjitcXWLKeb(this);
                z = true;
            }
            try {
                HvMZFmykbdxFjZyd(p9fed4fc4_pcae2b5bcNGlpfUZwUDFfidSF, CBnRYkClcIuRHpbl(uzlGosLtwsGERVXy(this.ff50644dc, t), "The value supplied is null"));
                if (z) {
                    kynbHlBSzdYrUheA(this.fd22a0a80, p9fed4fc4_pcae2b5bcNGlpfUZwUDFfidSF);
                    if (kDTJvxoRWxwywCeE(p9fed4fc4_pcae2b5bcNGlpfUZwUDFfidSF.f9ed39e2e)) {
                        MCyavDNosllXWTDl(this, objGUmzVVUGFdYbDkkl);
                        NGPhgiOvVwsZLAMF(p9fed4fc4_pcae2b5bcNGlpfUZwUDFfidSF);
                    }
                }
            } catch (java.lang.Exception th) {
                nfkyUTmmhlHhFofH(th);
                NOwgkICWvSkpoFGr(this.fbc3b0556);
                if (z) {
                    eyWUoPrpnzqbOUHf(this.fd22a0a80, p9fed4fc4_pcae2b5bcNGlpfUZwUDFfidSF);
                }
                MocZNubMdaCeflhn(this, th);
            }
        } catch (java.lang.Exception th2) {
            PyNAcaCrlMkcPgnj(th2);
            DxAPUeLuUUtRFZRX(this.fbc3b0556);
            jyfuSAWIstTwgPyp(this, th2);
        }
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        if (AkbsyqKHSwPbSDsr(this.fbc3b0556, p7beea252Var)) {
            this.fbc3b0556 = p7beea252Var;
            cRvSYEirjdeLrsaB(this.fd22a0a80, this);
        }
    }
}

