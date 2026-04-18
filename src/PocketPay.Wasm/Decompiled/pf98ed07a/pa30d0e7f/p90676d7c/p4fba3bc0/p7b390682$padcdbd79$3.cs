namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\f\n\u0002\b\u0004\n\u0002\u0010\u0000\n\u0002\b\u0007\u0010\u0000\u001a\n \u0002*\u0004\u0018\u0001H\u0001H\u0001\"\b\b\u0000\u0010\u0003*\u00020\u0004\"\b\b\u0001\u0010\u0005*\u00020\u0004\"\b\b\u0002\u0010\u0006*\u00020\u0004\"\b\b\u0003\u0010\u0001*\u00020\u00042\u0006\u0010\u0007\u001a\u0002H\u00032\u0006\u0010\b\u001a\u0002H\u00052\u0006\u0010\t\u001a\u0002H\u0006H\n¢\u0006\u0004\b\n\u0010\u000b"}, d2 = {"<anonymous>", "R", "kotlin.jvm.PlatformType", "T1", "", "T2", "T3", "t1", "t2", "t3", "apply", "(Ljava/lang/object;Ljava/lang/object;Ljava/lang/object;)Ljava/lang/object;"}, m527k = 3, mv = {1, 4, 0})
public readonly class p7b390682$padcdbd79$3<T1, T2, T3, R> : io.reactivex.rxjava3.functions.Function3<T1, T2, T3, R> {
    readonly kotlin.jvm.functions.Function3 $combineFunction;

    public p7b390682$padcdbd79$3(kotlin.jvm.functions.Function3 function3) {
        this.$combineFunction = function3;
    }

    public static void GvmSrKNKfBQCgaWt(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object JEkoMdhsNuepzNNB(kotlin.jvm.functions.Function3 function3, java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        return function3.invoke(obj, obj2, obj3);
    }

    public static void OmhcQuRpcjPyFwHy(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void VBYDLKTxWXFbXSmx(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public readonly R Apply(T1 t1, T2 t2, T3 t3) {
        omhcQuRpcjPyFwHy(t1, "t1");
        GvmSrKNKfBQCgaWt(t2, "t2");
        vBYDLKTxWXFbXSmx(t3, "t3");
        return (R) jEkoMdhsNuepzNNB(this.$combineFunction, t1, t2, t3);
    }
}

