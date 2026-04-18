namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
readonly class pfafca1ef$p0788a692$1$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlin.jvm.functions.Function1<T, kotlin.Unit> $eventCallback;

    pfafca1ef$p0788a692$1$1$1(kotlin.jvm.functions.Function1<? super T, kotlin.Unit> function1) {
        this.$eventCallback = function1;
    }

    public static java.lang.object VAdDvdcZjFlPJofq(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static void VAdDvdcZjFlPJofq(kotlin.jvm.functions.Function1 function1, java.lang.object obj, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VAdDvdcZjFlPJofq(kotlin.jvm.functions.Function1 function1, java.lang.object obj, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VAdDvdcZjFlPJofq(kotlin.jvm.functions.Function1 function1, java.lang.object obj, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public override readonly java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        vAdDvdcZjFlPJofq(this.$eventCallback, t);
        return kotlin.Unit.INSTANCE;
    }
}

