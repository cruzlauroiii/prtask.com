namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\u0012\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0000\n\u0002\b\u0003\u0010\u0000\u001a*\u0012\u000e\b\u0001\u0012\n \u0003*\u0004\u0018\u0001H\u0002H\u0002 \u0003*\u0014\u0012\u000e\b\u0001\u0012\n \u0003*\u0004\u0018\u0001H\u0002H\u0002\u0018\u00010\u00010\u0001\"\b\b\u0000\u0010\u0004*\u00020\u0005\"\b\b\u0001\u0010\u0002*\u00020\u00052\u000e\u0010\u0006\u001a\n \u0003*\u0004\u0018\u0001H\u0004H\u0004H\n¢\u0006\u0004\b\u0007\u0010\b"}, d2 = {"<anonymous>", "Lp5a445d71/p18f29add/p32c73be0;", "R", "kotlin.jvm.PlatformType", "T", "", "it", "apply", "(Ljava/lang/object;)Lp5a445d71/p18f29add/p32c73be0;"}, m527k = 3, mv = {1, 4, 0})
public readonly class pc488b965$pcbea5da5$1<T, R> : io.reactivex.rxjava3.functions.Function<T, org.reactivestreams.Publisher<? : R>> {
    readonly kotlin.jvm.functions.Function1 $body;

    public pc488b965$pcbea5da5$1(kotlin.jvm.functions.Function1 function1) {
        this.$body = function1;
    }

    public static void GSjEntiObdkGSQtq(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static p5a445d71.p18f29add.p32c73be0 ZJCdqUNLpxeZxIWB(pf98ed07a.pa30d0e7f.p90676d7c.p4fba3bc0.pc488b965$pcbea5da5$1 pc488b965_pcbea5da5_1, java.lang.object obj) {
        return pc488b965_pcbea5da5_1.m3917apply(obj);
    }

    public static io.reactivex.rxjava3.core.Flowable LEDLLxBCzdBADsun(kotlin.sequences.Sequence sequence) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p4fba3bc0.pc488b965.m56dd5681(sequence);
    }

    public static java.lang.object OOyBNaJZGALhGKTG(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public java.lang.object Apply(java.lang.object obj) {
        return ZJCdqUNLpxeZxIWB(this, obj);
    }

    public readonly org.reactivestreams.Publisher<? : R> m3917apply(T t) {
        kotlin.jvm.functions.Function1 function1 = this.$body;
        GSjEntiObdkGSQtq(t, "it");
        return lEDLLxBCzdBADsun((kotlin.sequences.Sequence) oOyBNaJZGALhGKTG(function1, t));
    }
}

