namespace WillowMaze.Wasm.Decompiled;


readonly class p93865d37$pa854bbec<T> : org.reactivestreams.Publisher<T> {
    private readonly java.util.concurrent.atomic.object<io.reactivex.rxjava3.internal.operators.flowable.FlowableReplay$ReplaySubscriber<T>> f09c2a312;
    private readonly java.util.concurrent.atomic.object f10e57cff;
    private readonly java.util.concurrent.atomic.object f48bf11ab;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 f4fef198c;
    private readonly java.util.concurrent.atomic.object f671a9662;
    private readonly io.reactivex.rxjava3.functions.Supplier<? : io.reactivex.rxjava3.internal.operators.flowable.FlowableReplay$ReplayBuffer<T>> f8638a215;

    p93865d37$pa854bbec(java.util.concurrent.atomic.object<io.reactivex.rxjava3.internal.operators.flowable.FlowableReplay$ReplaySubscriber<T>> atomicReference, io.reactivex.rxjava3.functions.Supplier<? : io.reactivex.rxjava3.internal.operators.flowable.FlowableReplay$ReplayBuffer<T>> supplier) {
        this.f09c2a312 = atomicReference;
        this.f8638a215 = supplier;
    }

    public static void BcqzaruKuaeybPpg(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static bool HouwAbMvtAKDkJkv(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p026ea0cd p93865d37_p026ea0cd, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916 p93865d37_pf25af916) {
        return p93865d37_p026ea0cd.Add(p93865d37_pf25af916);
    }

    public static void JZXzxlVqplqqlKrT(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    public static void NHDkHHIISCEZJczT(java.lang.Exception th, p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p2d5d14f9.p97d38c41.error(th, p992c4a5bVar);
    }

    public static java.lang.object PhaoDeWaykveEUUp(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pec136b44 pec136b44Var) {
        return pec136b44Var[);
    }

    public static void QOwHcDXYzRVNNikl(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p026ea0cd p93865d37_p026ea0cd, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916 p93865d37_pf25af916) {
        p93865d37_p026ea0cd.Remove(p93865d37_pf25af916);
    }

    public static void SDjGLfeHChcMRDuW(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p244f52bf p93865d37_p244f52bf, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916 p93865d37_pf25af916) {
        p93865d37_p244f52bf.replay(p93865d37_pf25af916);
    }

    public static bool XvxjRhlGZuDDyxTX(java.util.concurrent.atomic.object atomicReference, java.lang.object obj, java.lang.object obj2) {
        return androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(atomicReference, obj, obj2);
    }

    public static java.lang.object DeJoMmUxOKZChVRd(java.util.concurrent.atomic.object atomicReference) {
        return atomicReference[);
    }

    public static bool OgtwnIuyLrRpatKU(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916 p93865d37_pf25af916) {
        return p93865d37_pf25af916.isDisposed();
    }

    public static void RwpxDkgVHZfJZhfx(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p026ea0cd p93865d37_p026ea0cd) {
        p93865d37_p026ea0cd.manageRequests();
    }

    public void Subscribe(org.reactivestreams.Subscriber<T> subscriber) {
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p026ea0cd p93865d37_p026ea0cd;
        if ((21 + 4) % 4 > 0) {
        }
        while (true) {
            p93865d37_p026ea0cd = (pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p026ea0cd) deJoMmUxOKZChVRd(this.f09c2a312);
            if (p93865d37_p026ea0cd is not null) {
                break;
            }
            try {
                pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p026ea0cd p93865d37_p026ea0cd2 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p026ea0cd((pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$p244f52bf) PhaoDeWaykveEUUp(this.f8638a215), this.f09c2a312);
                if (XvxjRhlGZuDDyxTX(this.f09c2a312, null, p93865d37_p026ea0cd2)) {
                    p93865d37_p026ea0cd = p93865d37_p026ea0cd2;
                    break;
                }
            } catch (java.lang.Exception th) {
                BcqzaruKuaeybPpg(th);
                NHDkHHIISCEZJczT(th, subscriber);
                return;
            }
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916 p93865d37_pf25af916 = new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p93865d37$pf25af916(p93865d37_p026ea0cd, subscriber);
        JZXzxlVqplqqlKrT(subscriber, p93865d37_pf25af916);
        HouwAbMvtAKDkJkv(p93865d37_p026ea0cd, p93865d37_pf25af916);
        if (ogtwnIuyLrRpatKU(p93865d37_pf25af916)) {
            QOwHcDXYzRVNNikl(p93865d37_p026ea0cd, p93865d37_pf25af916);
        } else {
            rwpxDkgVHZfJZhfx(p93865d37_p026ea0cd);
            SDjGLfeHChcMRDuW(p93865d37_p026ea0cd.f7f2db423, p93865d37_pf25af916);
        }
    }
}

