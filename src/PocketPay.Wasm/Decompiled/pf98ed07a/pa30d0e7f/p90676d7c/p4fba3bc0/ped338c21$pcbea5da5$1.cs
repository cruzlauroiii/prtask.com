namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\u0012\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0000\n\u0002\b\u0003\u0010\u0000\u001a*\u0012\u000e\b\u0001\u0012\n \u0003*\u0004\u0018\u0001H\u0002H\u0002 \u0003*\u0014\u0012\u000e\b\u0001\u0012\n \u0003*\u0004\u0018\u0001H\u0002H\u0002\u0018\u00010\u00010\u0001\"\b\b\u0000\u0010\u0004*\u00020\u0005\"\b\b\u0001\u0010\u0002*\u00020\u00052\u000e\u0010\u0006\u001a\n \u0003*\u0004\u0018\u0001H\u0004H\u0004H\n¢\u0006\u0004\b\u0007\u0010\b"}, d2 = {"<anonymous>", "Lio/reactivex/rxjava3/core/ObservableSource;", "R", "kotlin.jvm.PlatformType", "T", "", "it", "apply", "(Ljava/lang/object;)Lio/reactivex/rxjava3/core/ObservableSource;"}, m527k = 3, mv = {1, 4, 0})
public readonly class ped338c21$pcbea5da5$1<T, R> : io.reactivex.rxjava3.functions.Function<T, io.reactivex.rxjava3.core.ObservableSource<? : R>> {
    readonly kotlin.jvm.functions.Function1 $body;

    public ped338c21$pcbea5da5$1(kotlin.jvm.functions.Function1 function1) {
        this.$body = function1;
    }

    public static void EGAHcpyPZHyhLowY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static io.reactivex.rxjava3.core.Observable VogxNDdkUHEIsSsf(kotlin.sequences.Sequence sequence) {
        return pf98ed07a.pa30d0e7f.p90676d7c.p4fba3bc0.ped338c21.m03bc3a85(sequence);
    }

    public static io.reactivex.rxjava3.core.ObservableSource ZIWZKzJECAtsLEUi(pf98ed07a.pa30d0e7f.p90676d7c.p4fba3bc0.ped338c21$pcbea5da5$1 ped338c21_pcbea5da5_1, java.lang.object obj) {
        return ped338c21_pcbea5da5_1.apply(obj);
    }

    public static java.lang.object TvdBFyKvBPNhIaWt(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public readonly io.reactivex.rxjava3.core.ObservableSource<? : R> apply(T t) {
        kotlin.jvm.functions.Function1 function1 = this.$body;
        EGAHcpyPZHyhLowY(t, "it");
        return VogxNDdkUHEIsSsf((kotlin.sequences.Sequence) tvdBFyKvBPNhIaWt(function1, t));
    }

    public java.lang.object M3920apply(java.lang.object obj) {
        return ZIWZKzJECAtsLEUi(this, obj);
    }
}

