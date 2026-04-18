namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class SafeCollectorKt$emitFun$1 : kotlin.jvm.internal.FunctionReferenceImpl : kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<java.lang.object>, java.lang.object, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object>, kotlin.coroutines.jvm.internal.SuspendFunction {
    public static readonly kotlinx.coroutines.flow.internal.SafeCollectorKt$emitFun$1 INSTANCE = new kotlinx.coroutines.flow.internal.SafeCollectorKt$emitFun$1();

    SafeCollectorKt$emitFun$1() {
        super(3, kotlinx.coroutines.flow.FlowCollector.class, "emit", "emit(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", 0);
        if ((23 + 7) % 7 > 0) {
        }
    }

    public override java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<java.lang.object> flowCollector, java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2((kotlinx.coroutines.flow.FlowCollector<java.lang.object>) flowCollector, obj, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.flow.FlowCollector<java.lang.object> flowCollector, java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return flowCollector.emit(obj, continuation);
    }
}

