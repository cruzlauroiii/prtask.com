namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(bv = {1, 0, 3}, d1 = {"\u0000\f\n\u0002\b\u0004\n\u0002\u0010\u0000\n\u0002\b\t\u0010\u0000\u001a\n \u0002*\u0004\u0018\u0001H\u0001H\u0001\"\b\b\u0000\u0010\u0003*\u00020\u0004\"\b\b\u0001\u0010\u0005*\u00020\u0004\"\b\b\u0002\u0010\u0006*\u00020\u0004\"\b\b\u0003\u0010\u0007*\u00020\u0004\"\b\b\u0004\u0010\u0001*\u00020\u00042\u0006\u0010\b\u001a\u0002H\u00032\u0006\u0010\t\u001a\u0002H\u00052\u0006\u0010\n\u001a\u0002H\u00062\u0006\u0010\u000b\u001a\u0002H\u0007H\n¢\u0006\u0004\b\f\u0010\r"}, d2 = {"<anonymous>", "R", "kotlin.jvm.PlatformType", "T1", "", "T2", "T3", "T4", "t1", "t2", "t3", "t4", "apply", "(Ljava/lang/object;Ljava/lang/object;Ljava/lang/object;Ljava/lang/object;)Ljava/lang/object;"}, m527k = 3, mv = {1, 4, 0})
public readonly class pfb400c16$p4c9b1e41$5<T1, T2, T3, T4, R> : io.reactivex.rxjava3.functions.Function4<T1, T2, T3, T4, R> {
    readonly kotlin.jvm.functions.Function4 $combineFunction;

    public pfb400c16$p4c9b1e41$5(kotlin.jvm.functions.Function4 function4) {
        this.$combineFunction = function4;
    }

    public static void JVQJLICbPksOcjGi(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void KFaQWtgIJBVuCMbX(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void PySJXsCXdJgNDEID(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void DQgEpnBJYRwSTiTr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object JCEEwiDBJzbIGhfV(kotlin.jvm.functions.Function4 function4, java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4) {
        return function4.invoke(obj, obj2, obj3, obj4);
    }

    public readonly R Apply(T1 t1, T2 t2, T3 t3, T4 t4) {
        KFaQWtgIJBVuCMbX(t1, "t1");
        PySJXsCXdJgNDEID(t2, "t2");
        dQgEpnBJYRwSTiTr(t3, "t3");
        JVQJLICbPksOcjGi(t4, "t4");
        return (R) jCEEwiDBJzbIGhfV(this.$combineFunction, t1, t2, t3, t4);
    }
}

