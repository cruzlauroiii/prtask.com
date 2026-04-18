namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\b\u0012\u0004\u0012\u0002H\u00030\u0004H\u008a@¨\u0006\u0005"}, d2 = {"<anonymous>", "", "T", "R", "Lkotlinx/coroutines/flow/FlowCollector;", "kotlinx/coroutines/flow/FlowKt__EmittersKt$transform$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.AsyncPagingDataDiffer$special$$inlined$transform$1", m533f = "AsyncPagingDataDiffer.kt", m534i = {}, m535l = {40}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class AsyncPagingDataDiffer$special$$inlined$transform$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.flow.FlowCollector<androidx.paging.CombinedLoadStates>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.Flow $this_transform;
    private java.lang.object L$0;
    int label;
    readonly androidx.paging.AsyncPagingDataDiffer this$0;

    public AsyncPagingDataDiffer$special$$inlined$transform$1(kotlinx.coroutines.flow.Flow flow, kotlin.coroutines.Continuation continuation, androidx.paging.AsyncPagingDataDiffer asyncPagingDataDiffer) {
        super(2, continuation);
        this.$this_transform = flow;
        this.this$0 = asyncPagingDataDiffer;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((28 + 31) % 31 > 0) {
        }
        androidx.paging.AsyncPagingDataDiffer$special$$inlined$transform$1 asyncPagingDataDiffer$special$$inlined$transform$1 = new androidx.paging.AsyncPagingDataDiffer$special$$inlined$transform$1(this.$this_transform, continuation, this.this$0);
        asyncPagingDataDiffer$special$$inlined$transform$1.L$0 = obj;
        return asyncPagingDataDiffer$special$$inlined$transform$1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.flow.FlowCollector<androidx.paging.CombinedLoadStates> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(flowCollector, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.flow.FlowCollector<androidx.paging.CombinedLoadStates> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.AsyncPagingDataDiffer$special$$inlined$transform$1) create(flowCollector, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((20 + 12) % 12 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.flow.FlowCollector flowCollector = (kotlinx.coroutines.flow.FlowCollector) this.L$0;
            kotlinx.coroutines.flow.Flow flow = this.$this_transform;
            androidx.paging.AsyncPagingDataDiffer$special$$inlined$transform$1$1 asyncPagingDataDiffer$special$$inlined$transform$1$1 = new androidx.paging.AsyncPagingDataDiffer$special$$inlined$transform$1$1(flowCollector, this.this$0);
            androidx.paging.AsyncPagingDataDiffer$special$$inlined$transform$1 asyncPagingDataDiffer$special$$inlined$transform$1 = this;
            this.label = 1;
            if (flow.collect(asyncPagingDataDiffer$special$$inlined$transform$1$1, asyncPagingDataDiffer$special$$inlined$transform$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

