namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\f\n\u0002\b\u0004\n\u0002\u0010\u0000\n\u0002\b\t\u0010\u0000\u001a\n \u0002*\u0004\u0018\u0001H\u0001H\u0001\"\b\b\u0000\u0010\u0003*\u00020\u0004\"\b\b\u0001\u0010\u0005*\u00020\u0004\"\b\b\u0002\u0010\u0006*\u00020\u0004\"\b\b\u0003\u0010\u0007*\u00020\u0004\"\b\b\u0004\u0010\u0001*\u00020\u00042\u000e\u0010\b\u001a\n \u0002*\u0004\u0018\u0001H\u0003H\u00032\u000e\u0010\t\u001a\n \u0002*\u0004\u0018\u0001H\u0005H\u00052\u000e\u0010\n\u001a\n \u0002*\u0004\u0018\u0001H\u0006H\u00062\u000e\u0010\u000b\u001a\n \u0002*\u0004\u0018\u0001H\u0007H\u0007H\n¢\u0006\u0004\b\f\u0010\r"}, d2 = {"<anonymous>", "R", "kotlin.jvm.PlatformType", "T", "", "T1", "T2", "T3", "t", "t1", "t2", "t3", "apply", "(Ljava/lang/object;Ljava/lang/object;Ljava/lang/object;Ljava/lang/object;)Ljava/lang/object;"}, m527k = 3, mv = {1, 4, 0})
public readonly class p8fa79597$p27560019$5<T1, T2, T3, T4, R, T> : io.reactivex.rxjava3.functions.Function4<T, T1, T2, T3, R> {
    readonly kotlin.jvm.functions.Function4 $combiner;

    public p8fa79597$p27560019$5(kotlin.jvm.functions.Function4 function4) {
        this.$combiner = function4;
    }

    public static void CNFXMMVgWKaHbnxG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void GbVebkhUmkuqRlxF(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void QVzTUDOWMaKBSbtD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void IuibgxdYSfaCBQdl(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.object QczrHWvMslbkmuoa(kotlin.jvm.functions.Function4 function4, java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4) {
        return function4.invoke(obj, obj2, obj3, obj4);
    }

    public readonly R Apply(T t, T1 t1, T2 t2, T3 t3) {
        kotlin.jvm.functions.Function4 function4 = this.$combiner;
        QVzTUDOWMaKBSbtD(t, "t");
        CNFXMMVgWKaHbnxG(t1, "t1");
        GbVebkhUmkuqRlxF(t2, "t2");
        iuibgxdYSfaCBQdl(t3, "t3");
        return (R) qczrHWvMslbkmuoa(function4, t, t1, t2, t3);
    }
}

