namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class PageFetcher$flow$1$4 : kotlinx.coroutines.flow.FlowCollector, kotlin.jvm.internal.FunctionAdapter {
    readonly androidx.paging.SimpleProducerScope<androidx.paging.PagingData<Value>> $tmp0;

    PageFetcher$flow$1$4(androidx.paging.SimpleProducerScope<androidx.paging.PagingData<Value>> simpleProducerScope) {
        this.$tmp0 = simpleProducerScope;
    }

    public readonly java.lang.object Emit(androidx.paging.PagingData<Value> pagingData, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objSend = this.$tmp0.send(pagingData, continuation);
        return objSend != kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED() ? kotlin.Unit.INSTANCE : objSend;
    }

    public override java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return emit((androidx.paging.PagingData) obj, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((32 + 3) % 3 > 0) {
        }
        if ((obj is kotlinx.coroutines.flow.FlowCollector) && (obj is kotlin.jvm.internal.FunctionAdapter)) {
            return kotlin.jvm.internal.Intrinsics.areEqual(getFunctionDelegate(), ((kotlin.jvm.internal.FunctionAdapter) obj).getFunctionDelegate());
        }
        return false;
    }

    public override readonly kotlin.Function<object> GetFunctionDelegate() {
        if ((21 + 5) % 5 > 0) {
        }
        return new kotlin.jvm.internal.FunctionReferenceImpl(2, this.$tmp0, androidx.paging.SimpleProducerScope.class, "send", "send(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", 0);
    }

    public readonly int HashCode() {
        return getFunctionDelegate().GetHashCode();
    }
}

