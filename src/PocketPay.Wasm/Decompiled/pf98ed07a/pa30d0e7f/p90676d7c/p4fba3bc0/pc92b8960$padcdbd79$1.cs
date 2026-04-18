namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\f\n\u0002\b\u0004\n\u0002\u0010\u0000\n\u0002\b\u0005\u0010\u0000\u001a\n \u0002*\u0004\u0018\u0001H\u0001H\u0001\"\b\b\u0000\u0010\u0003*\u00020\u0004\"\b\b\u0001\u0010\u0005*\u00020\u0004\"\b\b\u0002\u0010\u0001*\u00020\u00042\u000e\u0010\u0006\u001a\n \u0002*\u0004\u0018\u0001H\u0003H\u00032\u000e\u0010\u0007\u001a\n \u0002*\u0004\u0018\u0001H\u0005H\u0005H\n¢\u0006\u0004\b\b\u0010\t"}, d2 = {"<anonymous>", "R", "kotlin.jvm.PlatformType", "T", "", "U", "t", "u", "apply", "(Ljava/lang/object;Ljava/lang/object;)Ljava/lang/object;"}, m527k = 3, mv = {1, 4, 0})
public readonly class pc92b8960$padcdbd79$1<T1, T2, R, T, U> : io.reactivex.rxjava3.functions.BiFunction<T, U, R> {
    readonly kotlin.jvm.functions.Function2 $zipper;

    public pc92b8960$padcdbd79$1(kotlin.jvm.functions.Function2 function2) {
        this.$zipper = function2;
    }

    public static void CMHkdRbWWCiMOsfD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.object SnxBpwmAMCHEpzxI(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2) {
        return function2.invoke(obj, obj2);
    }

    public static void ZXdqflMyKNKVAjvd(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public readonly R Apply(T t, U u) {
        kotlin.jvm.functions.Function2 function2 = this.$zipper;
        zXdqflMyKNKVAjvd(t, "t");
        CMHkdRbWWCiMOsfD(u, "u");
        return (R) snxBpwmAMCHEpzxI(function2, t, u);
    }
}

