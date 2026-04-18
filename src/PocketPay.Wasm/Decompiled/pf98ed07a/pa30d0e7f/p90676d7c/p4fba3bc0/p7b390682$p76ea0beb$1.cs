namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\u001a\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u000324\u0010\u0004\u001a0\u0012\f\u0012\n \u0006*\u0004\u0018\u0001H\u0002H\u0002 \u0006*\u0017\u0012\f\u0012\n \u0006*\u0004\u0018\u0001H\u0002H\u0002\u0018\u00010\u0005¢\u0006\u0002\b\u00070\u0005¢\u0006\u0002\b\u0007H\n¢\u0006\u0002\b\b"}, d2 = {"<anonymous>", "", "T", "", "it", "Lio/reactivex/rxjava3/core/FlowableEmitter;", "kotlin.jvm.PlatformType", "Lpf98ed07a/pa30d0e7f/p90676d7c/p4ab6864f/pf61ee17d;", "subscribe"}, m527k = 3, mv = {1, 4, 0})
public readonly class p7b390682$p76ea0beb$1<T> : io.reactivex.rxjava3.core.FlowableOnSubscribe<T> {
    readonly kotlin.jvm.functions.Function1 $source;

    public p7b390682$p76ea0beb$1(kotlin.jvm.functions.Function1 function1) {
        this.$source = function1;
    }

    public static java.lang.object CdDBDaYWujZKdVSs(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static void VNdlKZGSEIMFfFNw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public override readonly void Subscribe(io.reactivex.rxjava3.core.FlowableEmitter<T> flowableEmitter) {
        kotlin.jvm.functions.Function1 function1 = this.$source;
        VNdlKZGSEIMFfFNw(flowableEmitter, "it");
        CdDBDaYWujZKdVSs(function1, flowableEmitter);
    }
}

