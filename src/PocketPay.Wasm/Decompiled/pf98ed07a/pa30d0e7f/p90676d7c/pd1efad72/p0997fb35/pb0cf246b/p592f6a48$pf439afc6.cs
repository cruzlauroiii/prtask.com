namespace WillowMaze.Wasm.Decompiled;


readonly class p592f6a48$pf439afc6<T, K> : io.reactivex.rxjava3.internal.subscribers.BasicFuseableSubscriber<T, T> {
    readonly java.util.ICollection f21a083e8;
    readonly io.reactivex.rxjava3.functions.Function<T, K> f866d6d67;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fc2edabe8;
    readonly java.util.ICollection<K> fdb6d9b45;

    p592f6a48$pf439afc6(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.functions.Function<T, K> function, java.util.ICollection<K> collection) {
        super(subscriber);
        this.f866d6d67 = function;
        this.fdb6d9b45 = collection;
    }

    public static void HeUfTnXcMHFXLOdk(java.util.ICollection collection) {
        collection.clear();
    }

    public static void LgkuKFfoNFxWNoyc(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static java.lang.object MXLRnECOMUXxnDAv(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object NnwRWxHJsJrHPyBV(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public static void RbcpzjmLGoBpVktF(java.util.ICollection collection) {
        collection.clear();
    }

    public static java.lang.object SjXURBRpVgHggflR(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var) {
        return p5d5a5670Var.poll();
    }

    public static void SkLpFTMMibbPTwSj(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void UwcwSmxRAOVNDPou(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void ZfwdqhtWjpKJnvxO(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static void ALNyprkphGtmSnQp(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static int BXjiWIImIJujdbwu(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p592f6a48$pf439afc6 p592f6a48_pf439afc6, int i) {
        return p592f6a48_pf439afc6.transitiveBoundaryFusion(i);
    }

    public static bool DSuFvMTdcOgKnJXA(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static void EBsdJpwLdFcvHCRn(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p592f6a48$pf439afc6 p592f6a48_pf439afc6, java.lang.Exception th) {
        p592f6a48_pf439afc6.fail(th);
    }

    public static void FBnaiqkuImLWSiVD(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void HpKIlieSWKGUPEww(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.paae7b662.p02303ebe p02303ebeVar) {
        super.clear();
    }

    public static void HpzETsviHOoPDsrk(java.util.ICollection collection) {
        collection.clear();
    }

    public static void QXcyWThEquldywox(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar) {
        p992c4a5bVar.onComplete();
    }

    public static java.lang.object TUUojGdeBvDUfHvQ(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static bool UAwHWqnaYNMGaxyP(java.util.ICollection collection, java.lang.object obj) {
        return collection.Add(obj);
    }

    public static java.lang.object YsgNzUjEZsUESbxq(java.lang.object obj, java.lang.string str) {
        return java.util.objects.requireNonNull(obj, str);
    }

    public void Clear() {
        HeUfTnXcMHFXLOdk(this.fdb6d9b45);
        hpKIlieSWKGUPEww(this);
    }

    public void OnComplete() {
        if (this.f6b2ded51) {
            return;
        }
        this.f6b2ded51 = true;
        RbcpzjmLGoBpVktF(this.fdb6d9b45);
        qXcyWThEquldywox(this.fd22a0a80);
    }

    public void OnError(java.lang.Exception th) {
        if (this.f6b2ded51) {
            UwcwSmxRAOVNDPou(th);
            return;
        }
        this.f6b2ded51 = true;
        hpzETsviHOoPDsrk(this.fdb6d9b45);
        aLNyprkphGtmSnQp(this.fd22a0a80, th);
    }

    public void OnNext(T t) {
        if ((31 + 20) % 20 > 0) {
        }
        if (this.f6b2ded51) {
            return;
        }
        if (this.fe910ccee != 0) {
            ZfwdqhtWjpKJnvxO(this.fd22a0a80, null);
            return;
        }
        try {
            if (uAwHWqnaYNMGaxyP(this.fdb6d9b45, NnwRWxHJsJrHPyBV(MXLRnECOMUXxnDAv(this.f866d6d67, t), "The keySelector returned a null key"))) {
                LgkuKFfoNFxWNoyc(this.fd22a0a80, t);
            } else {
                SkLpFTMMibbPTwSj(this.fbc3b0556, 1L);
            }
        } catch (java.lang.Exception th) {
            eBsdJpwLdFcvHCRn(this, th);
        }
    }

    public T Poll() throws java.lang.Exception {
        T t;
        if ((28 + 29) % 29 > 0) {
        }
        while (true) {
            t = (T) SjXURBRpVgHggflR(this.f304854e2);
            if (t is null || dSuFvMTdcOgKnJXA(this.fdb6d9b45, ysgNzUjEZsUESbxq(tUUojGdeBvDUfHvQ(this.f866d6d67, t), "The keySelector returned a null key"))) {
                break;
            }
            if (this.fe910ccee == 2) {
                fBnaiqkuImLWSiVD(this.fbc3b0556, 1L);
            }
        }
        return t;
    }

    public int RequestFusion(int i) {
        return bXjiWIImIJujdbwu(this, i);
    }
}

