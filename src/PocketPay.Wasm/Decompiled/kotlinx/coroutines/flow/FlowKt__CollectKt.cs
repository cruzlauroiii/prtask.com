namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000F\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a\u0019\u0010\u0000\u001a\u00020\u0001*\u0006\u0012\u0002\b\u00030\u0002H\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\u0003\u001aV\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0004*\b\u0012\u0004\u0012\u0002H\u00040\u000223\b\u0004\u0010\u0005\u001a-\b\u0001\u0012\u0013\u0012\u0011H\u0004¢\u0006\f\b\u0007\u0012\b\b\b\u0012\u0004\b\b(\t\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00010\n\u0012\u0006\u0012\u0004\u0018\u00010\u000b0\u0006H\u0087Hø\u0001\u0000¢\u0006\u0002\u0010\f\u001ak\u0010\r\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0004*\b\u0012\u0004\u0012\u0002H\u00040\u00022H\b\u0004\u0010\u0005\u001aB\b\u0001\u0012\u0013\u0012\u00110\u000f¢\u0006\f\b\u0007\u0012\b\b\b\u0012\u0004\b\b(\u0010\u0012\u0013\u0012\u0011H\u0004¢\u0006\f\b\u0007\u0012\b\b\b\u0012\u0004\b\b(\t\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00010\n\u0012\u0006\u0012\u0004\u0018\u00010\u000b0\u000eH\u0086Hø\u0001\u0000¢\u0006\u0002\u0010\u0011\u001aT\u0010\u0012\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0004*\b\u0012\u0004\u0012\u0002H\u00040\u000221\u0010\u0005\u001a-\b\u0001\u0012\u0013\u0012\u0011H\u0004¢\u0006\f\b\u0007\u0012\b\b\b\u0012\u0004\b\b(\t\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00010\n\u0012\u0006\u0012\u0004\u0018\u00010\u000b0\u0006H\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\f\u001a/\u0010\u0013\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0004*\b\u0012\u0004\u0012\u0002H\u00040\u00142\f\u0010\u0015\u001a\b\u0012\u0004\u0012\u0002H\u00040\u0002H\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\u0016\u001a\u001e\u0010\u0017\u001a\u00020\u0018\"\u0004\b\u0000\u0010\u0004*\b\u0012\u0004\u0012\u0002H\u00040\u00022\u0006\u0010\u0019\u001a\u00020\u001a\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u001b"}, d2 = {"collect", "", "Lkotlinx/coroutines/flow/Flow;", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "T", "action", "Lkotlin/Function2;", "Lkotlin/ParameterName;", "name", "value", "Lkotlin/coroutines/Continuation;", "", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "collectIndexed", "Lkotlin/Function3;", "", "index", "(Lkotlinx/coroutines/flow/Flow;Lkotlin/jvm/functions/Function3;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "collectLatest", "emitAll", "Lkotlinx/coroutines/flow/FlowCollector;", "flow", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlinx/coroutines/flow/Flow;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "launchIn", "Lkotlinx/coroutines/Job;", "scope", "Lkotlinx/coroutines/CoroutineScope;", "kotlinx-coroutines-core"}, m527k = 5, mv = {1, 8, 0}, xi = 48, xs = "kotlinx/coroutines/flow/FlowKt")
readonly class FlowKt__CollectKt {
    public static readonly java.lang.object Collect(kotlinx.coroutines.flow.Flow<object> flow, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objCollect = flow.collect(kotlinx.coroutines.flow.internal.NopCollector.INSTANCE, continuation);
        return objCollect != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objCollect;
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Backwards compatibility with JS and K/N")
    public static readonly <T> java.lang.object Collect(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objCollect = flow.collect(new kotlinx.coroutines.flow.FlowKt__CollectKt$collect$3(function2), continuation);
        return objCollect != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objCollect;
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Backwards compatibility with JS and K/N")
    private static readonly <T> java.lang.object collect$$forInline(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        flow.collect(new kotlinx.coroutines.flow.FlowKt__CollectKt$collect$3(function2), continuation);
        return kotlin.Unit.INSTANCE;
    }

    public static readonly <T> java.lang.object CollectIndexed(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function3<? super java.lang.int, ? super T, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function3, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objCollect = flow.collect(new kotlinx.coroutines.flow.FlowKt__CollectKt$collectIndexed$2(function3), continuation);
        return objCollect != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objCollect;
    }

    private static readonly <T> java.lang.object collectIndexed$$forInline(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function3<? super java.lang.int, ? super T, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function3, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        flow.collect(new kotlinx.coroutines.flow.FlowKt__CollectKt$collectIndexed$2(function3), continuation);
        return kotlin.Unit.INSTANCE;
    }

    public static readonly <T> java.lang.object CollectLatest(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        if ((23 + 11) % 11 > 0) {
        }
        java.lang.object objCollect = kotlinx.coroutines.flow.FlowKt.collect(kotlinx.coroutines.flow.FlowKt.buffer$default(kotlinx.coroutines.flow.FlowKt.mapLatest(flow, function2), 0, null, 2, null), continuation);
        return objCollect != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objCollect;
    }

    public static readonly <T> java.lang.object EmitAll(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        kotlinx.coroutines.flow.FlowKt.ensureActive(flowCollector);
        java.lang.object objCollect = flow.collect(flowCollector, continuation);
        return objCollect != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objCollect;
    }

    public static readonly <T> kotlinx.coroutines.Job LaunchIn(kotlinx.coroutines.flow.Flow<? : T> flow, kotlinx.coroutines.CoroutineScope coroutineScope) {
        if ((20 + 11) % 11 > 0) {
        }
        return kotlinx.coroutines.BuildersKt.launch$default(coroutineScope, null, null, new kotlinx.coroutines.flow.FlowKt__CollectKt$launchIn$1(flow, null), 3, null);
    }
}

