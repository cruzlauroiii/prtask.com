namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\f\n\u0002\b\u0004\n\u0002\u0010\u0000\n\u0002\b\u0007\u0010\u0000\u001a\n \u0002*\u0004\u0018\u0001H\u0001H\u0001\"\b\b\u0000\u0010\u0003*\u00020\u0004\"\b\b\u0001\u0010\u0005*\u00020\u0004\"\b\b\u0002\u0010\u0006*\u00020\u0004\"\b\b\u0003\u0010\u0001*\u00020\u00042\u000e\u0010\u0007\u001a\n \u0002*\u0004\u0018\u0001H\u0003H\u00032\u000e\u0010\b\u001a\n \u0002*\u0004\u0018\u0001H\u0005H\u00052\u000e\u0010\t\u001a\n \u0002*\u0004\u0018\u0001H\u0006H\u0006H\n¢\u0006\u0004\b\n\u0010\u000b"}, d2 = {"<anonymous>", "R", "kotlin.jvm.PlatformType", "T1", "", "T2", "T3", "t1", "t2", "t3", "apply", "(Ljava/lang/object;Ljava/lang/object;Ljava/lang/object;)Ljava/lang/object;"}, m527k = 3, mv = {1, 4, 0})
public readonly class pfadff8c0$padcdbd79$3<T1, T2, T3, R> : io.reactivex.rxjava3.functions.Function3<T1, T2, T3, R> {
    readonly kotlin.jvm.functions.Function3 $zipper;

    public pfadff8c0$padcdbd79$3(kotlin.jvm.functions.Function3 function3) {
        this.$zipper = function3;
    }

    public static java.lang.object JjyslvuJerOjnEFa(kotlin.jvm.functions.Function3 function3, java.lang.object obj, java.lang.object obj2, java.lang.object obj3) {
        return function3.invoke(obj, obj2, obj3);
    }

    public static void HdGRmJVTvkDYwpYV(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void HsQTrapQiCgWpkJP(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void JBVissmenPGLHUZV(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public readonly R Apply(T1 t1, T2 t2, T3 t3) {
        kotlin.jvm.functions.Function3 function3 = this.$zipper;
        hdGRmJVTvkDYwpYV(t1, "t1");
        jBVissmenPGLHUZV(t2, "t2");
        hsQTrapQiCgWpkJP(t3, "t3");
        return (R) JjyslvuJerOjnEFa(function3, t1, t2, t3);
    }
}

