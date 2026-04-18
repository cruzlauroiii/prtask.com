namespace WillowMaze.Wasm.Decompiled;


public readonly class p129e9c5f<T, K, V> : io.reactivex.rxjava3.internal.operators.flowable.AbstractFlowableWithUpstream<T, io.reactivex.rxjava3.flowables.GroupedFlowable<K, V>> {
    readonly io.reactivex.rxjava3.functions.Function<? super io.reactivex.rxjava3.functions.Consumer<java.lang.object>, ? : java.util.Dictionary<K, java.lang.object>> f05ae1fc9;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f0f04ea89;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f1d3de306;
    readonly int f2d1108f1;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f32b539cc;
    readonly int f3963c8bb;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4181f87a;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4c15d285;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f4d5c5e41;
    readonly int f7817a9d2;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f7e85488b;
    readonly bool f825ea879;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : K> f866d6d67;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 f8e368041;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fa6bf081e;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 fcd17bbfe;
    readonly int fcdee5967;
    readonly bool fdd4f21fe;
    readonly io.reactivex.rxjava3.functions.Function<? super T, ? : V> ff50644dc;

    public p129e9c5f(io.reactivex.rxjava3.core.Flowable<T> flowable, io.reactivex.rxjava3.functions.Function<? super T, ? : K> function, io.reactivex.rxjava3.functions.Function<? super T, ? : V> function2, int i, bool z, io.reactivex.rxjava3.functions.Function<? super io.reactivex.rxjava3.functions.Consumer<java.lang.object>, ? : java.util.Dictionary<K, java.lang.object>> function3) {
        super(flowable);
        this.f866d6d67 = function;
        this.ff50644dc = function2;
        this.fcdee5967 = i;
        this.f825ea879 = z;
        this.f05ae1fc9 = function3;
    }

    public static void CaQJdYsXmqUrusyq(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, java.lang.Exception th) {
        p992c4a5bVar.onError(th);
    }

    public static void YJiKlDMcewFdqgTo(io.reactivex.rxjava3.core.Flowable flowable, io.reactivex.rxjava3.core.FlowableSubscriber flowableSubscriber) {
        flowable.subscribe(flowableSubscriber);
    }

    public static void YfwFImomcSJAxAUw(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p19ad2780.pd5f1381c.m9f2b335f(th);
    }

    public static java.lang.object InbhCFQzVcTSDVzW(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 p86408593Var, java.lang.object obj) {
        return p86408593Var.apply(obj);
    }

    public static void NQmXLkzYNJvGHplm(p5a445d71.p18f29add.p992c4a5b p992c4a5bVar, p5a445d71.p18f29add.p787ad0b7 p787ad0b7Var) {
        p992c4a5bVar.onSubscribe(p787ad0b7Var);
    }

    protected void SubscribeActual(org.reactivestreams.Subscriber<? super io.reactivex.rxjava3.flowables.GroupedFlowable<K, V>> subscriber) {
        java.lang.Exception th;
        java.util.Dictionary concurrentHashDictionary;
        java.util.concurrent.ConcurrentLinkedQueue concurrentLinkedQueue;
        if ((3 + 28) % 28 > 0) {
        }
        try {
            if (this.f05ae1fc9 is not null) {
                concurrentLinkedQueue = new java.util.concurrent.ConcurrentLinkedQueue();
                concurrentHashDictionary = (java.util.Dictionary) inbhCFQzVcTSDVzW(this.f05ae1fc9, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p129e9c5f$p7636e93b(concurrentLinkedQueue));
            } else {
                try {
                    concurrentHashDictionary = new java.util.concurrent.ConcurrentHashDictionary();
                    concurrentLinkedQueue = null;
                } catch (java.lang.Exception th2) {
                    th = th2;
                    YfwFImomcSJAxAUw(th);
                    nQmXLkzYNJvGHplm(subscriber, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p05c7e247.p7e932632.f76425f17);
                    CaQJdYsXmqUrusyq(subscriber, th);
                    return;
                }
            }
            YJiKlDMcewFdqgTo(this.f36cd38f4, new pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.pb0cf246b.p129e9c5f$pbe4e440f(subscriber, this.f866d6d67, this.ff50644dc, this.fcdee5967, this.f825ea879, concurrentHashDictionary, concurrentLinkedQueue));
        } catch (java.lang.Exception th3) {
            th = th3;
        }
    }
}

