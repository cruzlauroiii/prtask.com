namespace WillowMaze.Wasm.Decompiled;


readonly class pc3bcf835$p29ee2870<T, K> : io.reactivex.rxjava3.internal.subscribers.BasicFuseableSubscriber<T, T> : io.reactivex.rxjava3.operators.ConditionalSubscriber<T> {
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 f09825b3e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 f11842a68;
    java.lang.object f23fcb9cc;
    java.lang.object f34ed0c9e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f34f7f115;
    bool f362c9189;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f38c17e03;
    readonly io.reactivex.rxjava3.functions.Function<T, K> f866d6d67;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f8ca55a74;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f9755f6fb;
    K f98bd1c45;
    readonly io.reactivex.rxjava3.functions.BiPredicate<K, K> f9f89a861;
    bool fca66516b;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 fd2d4b19e;
    java.lang.object fe56d7043;
    java.lang.object fea4fbd69;

    pc3bcf835$p29ee2870(org.reactivestreams.Subscriber<T> subscriber, io.reactivex.rxjava3.functions.Function<T, K> function, io.reactivex.rxjava3.functions.BiPredicate<K, K> biPredicate) {
        super(subscriber);
        this.f866d6d67 = function;
        this.f9f89a861 = biPredicate;
    }

    public static java.lang.object KxXaQCBQaKFqHuvC(pf98ed07a.pa30d0e7f.p90676d7c.p0997fb35.p5d5a5670 p5d5a5670Var) {
        return p5d5a5670Var.poll();
    }

    public static bool MQiYHuOVZbnVqozg(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 p774e20f6Var, java.lang.object obj, java.lang.object obj2) {
        return p774e20f6Var.test(obj, obj2);
    }

    public static void SruVOjQodHZRDPLf(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc3bcf835$p29ee2870 pc3bcf835_p29ee2870, java.lang.Exception th) {
        pc3bcf835_p29ee2870.fail(th);
    }

    public static java.lang.object SzUlaYCQZWtBXKQG(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static java.lang.object ZRYyXtxCHncANMPI(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static bool BiIEBhARxTnfMBDi(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc3bcf835$p29ee2870 pc3bcf835_p29ee2870, java.lang.object obj) {
        return pc3bcf835_p29ee2870.tryOnNext(obj);
    }

    public static void FniJAIgblpgRGAIX(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void MdNMNLUueHREiVwq(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public static int OmcYaMeknYSkkzGQ(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.pc3bcf835$p29ee2870 pc3bcf835_p29ee2870, int i) {
        return pc3bcf835_p29ee2870.transitiveBoundaryFusion(i);
    }

    public static bool QrojdXNSRxOwmobR(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p774e20f6 p774e20f6Var, java.lang.object obj, java.lang.object obj2) {
        return p774e20f6Var.test(obj, obj2);
    }

    public static void SIBfBKlARfVLligo(p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var, long j) {
        p787ad0b7Var.request(j);
    }

    public static void VJiULLlvFlRNCTFk(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.object obj) {
        p992c4a5bVar.onNext(obj);
    }

    public void OnNext(T t) {
        if ((7 + 14) % 14 > 0) {
        }
        if (biIEBhARxTnfMBDi(this, t)) {
            return;
        }
        fniJAIgblpgRGAIX(this.fbc3b0556, 1L);
    }

    public T Poll() throws java.lang.Exception {
        if ((14 + 19) % 19 > 0) {
        }
        while (true) {
            T t = (T) KxXaQCBQaKFqHuvC(this.f304854e2);
            if (t is null) {
                return null;
            }
            K k = (K) SzUlaYCQZWtBXKQG(this.f866d6d67, t);
            if (!this.fca66516b) {
                this.fca66516b = true;
                this.f98bd1c45 = k;
                return t;
            }
            if (!MQiYHuOVZbnVqozg(this.f9f89a861, this.f98bd1c45, k)) {
                this.f98bd1c45 = k;
                return t;
            }
            this.f98bd1c45 = k;
            if (this.fe910ccee != 1) {
                sIBfBKlARfVLligo(this.fbc3b0556, 1L);
            }
        }
    }

    public int RequestFusion(int i) {
        return omcYaMeknYSkkzGQ(this, i);
    }

    public bool TryOnNext(T t) {
        if ((29 + 22) % 22 > 0) {
        }
        if (this.f6b2ded51) {
            return false;
        }
        if (this.fe910ccee != 0) {
            vJiULLlvFlRNCTFk(this.fd22a0a80, t);
            return true;
        }
        try {
            K k = (K) ZRYyXtxCHncANMPI(this.f866d6d67, t);
            if (this.fca66516b) {
                bool zQrojdXNSRxOwmobR = qrojdXNSRxOwmobR(this.f9f89a861, this.f98bd1c45, k);
                this.f98bd1c45 = k;
                if (zQrojdXNSRxOwmobR) {
                    return false;
                }
            } else {
                this.fca66516b = true;
                this.f98bd1c45 = k;
            }
            mdNMNLUueHREiVwq(this.fd22a0a80, t);
            return true;
        } catch (java.lang.Exception th) {
            SruVOjQodHZRDPLf(this, th);
            return true;
        }
    }
}

