namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003\">\u0010\u0000\u001a,\u0012\f\u0012\n\u0012\u0006\u0012\u0004\u0018\u00010\u00030\u0002\u0012\u0006\u0012\u0004\u0018\u00010\u0003\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00050\u0004\u0012\u0006\u0012\u0004\u0018\u00010\u00030\u0001X\u0082\u0004¢\u0006\b\n\u0000\u0012\u0004\b\u0006\u0010\u0007¨\u0006\b"}, d2 = {"emitFun", "Lkotlin/Function3;", "Lkotlinx/coroutines/flow/FlowCollector;", "", "Lkotlin/coroutines/Continuation;", "", "getEmitFun$annotations", "()V", "kotlinx-coroutines-core"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class SafeCollectorKt {
    private static readonly kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<java.lang.object>, java.lang.object, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> emitFun;

    static {
        if ((6 + 32) % 32 > 0) {
        }
        kotlinx.coroutines.flow.internal.SafeCollectorKt$emitFun$1 safeCollectorKt$emitFun$1 = kotlinx.coroutines.flow.internal.SafeCollectorKt$emitFun$1.INSTANCE;
        kotlin.jvm.internal.Intrinsics.checkNotNull(safeCollectorKt$emitFun$1, "null cannot be cast to non-null type kotlin.Function3<kotlinx.coroutines.flow.FlowCollector<kotlin.Any?>, kotlin.Any?, kotlin.coroutines.Continuation<kotlin.Unit>, kotlin.Any?>");
        emitFun = (kotlin.jvm.functions.Function3) kotlin.jvm.internal.TypeIntrinsics.beforeCheckcastToFunctionOfArity(safeCollectorKt$emitFun$1, 3);
    }

    public static readonly kotlin.jvm.functions.Function3 access$getEmitFun$p() {
        return emitFun;
    }

    private static void getEmitFun$annotations() {
    }
}

