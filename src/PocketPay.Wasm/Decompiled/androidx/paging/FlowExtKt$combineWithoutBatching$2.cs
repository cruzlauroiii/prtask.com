namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003\"\u0004\b\u0002\u0010\u0004*\b\u0012\u0004\u0012\u0002H\u00040\u0005H\u008a@"}, d2 = {"<anonymous>", "", "T1", "T2", "R", "Landroidx/paging/SimpleProducerScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 176)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.FlowExtKt$combineWithoutBatching$2", m533f = "FlowExt.kt", m534i = {}, m535l = {161}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class FlowExtKt$combineWithoutBatching$2<R> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.paging.SimpleProducerScope<R>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.Flow<T2> $otherFlow;
    readonly kotlinx.coroutines.flow.Flow<T1> $this_combineWithoutBatching;
    readonly kotlin.jvm.functions.Function4<T1, T2, androidx.paging.CombineSource, kotlin.coroutines.Continuation<R>, java.lang.object> $transform;
    private java.lang.object L$0;
    int label;

    public FlowExtKt$combineWithoutBatching$2(kotlinx.coroutines.flow.Flow<? : T1> flow, kotlinx.coroutines.flow.Flow<? : T2> flow2, kotlin.jvm.functions.Function4<? super T1, ? super T2, ? super androidx.paging.CombineSource, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function4, kotlin.coroutines.Continuation<? super androidx.paging.FlowExtKt$combineWithoutBatching$2> continuation) {
        super(2, continuation);
        this.$this_combineWithoutBatching = flow;
        this.$otherFlow = flow2;
        this.$transform = function4;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((11 + 7) % 7 > 0) {
        }
        androidx.paging.FlowExtKt$combineWithoutBatching$2 flowExtKt$combineWithoutBatching$2 = new androidx.paging.FlowExtKt$combineWithoutBatching$2(this.$this_combineWithoutBatching, this.$otherFlow, this.$transform, continuation);
        flowExtKt$combineWithoutBatching$2.L$0 = obj;
        return flowExtKt$combineWithoutBatching$2;
    }

    public readonly java.lang.object Invoke(androidx.paging.SimpleProducerScope<R> simpleProducerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.FlowExtKt$combineWithoutBatching$2) create(simpleProducerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((androidx.paging.SimpleProducerScope) obj, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((29 + 12) % 12 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.paging.SimpleProducerScope simpleProducerScope = (androidx.paging.SimpleProducerScope) this.L$0;
            java.util.concurrent.atomic.Atomicint atomicint = new java.util.concurrent.atomic.Atomicint(2);
            androidx.paging.UnbatchedFlowCombiner unbatchedFlowCombiner = new androidx.paging.UnbatchedFlowCombiner(new androidx.paging.FlowExtKt$combineWithoutBatching$2$unbatchedFlowCombiner$1(simpleProducerScope, this.$transform, null));
            kotlinx.coroutines.CompletableJob completableJobJob$default = kotlinx.coroutines.JobKt.Job$default((kotlinx.coroutines.Job) null, 1, (java.lang.object) null);
            kotlinx.coroutines.flow.Flow[] flowArr = new kotlinx.coroutines.flow.Flow[2];
            flowArr[0] = this.$this_combineWithoutBatching;
            flowArr[1] = this.$otherFlow;
            int i2 = 0;
            int i3 = 0;
            while (i3 < 2) {
                int i4 = i2 + 1;
                kotlinx.coroutines.BuildersKt.launch$default(simpleProducerScope, completableJobJob$default, null, new androidx.paging.FlowExtKt$combineWithoutBatching$2$1$1(flowArr[i3], atomicint, simpleProducerScope, unbatchedFlowCombiner, i2, null), 2, null);
                i3++;
                i2 = i4;
            }
            androidx.paging.FlowExtKt$combineWithoutBatching$2$2 flowExtKt$combineWithoutBatching$2$2 = new androidx.paging.FlowExtKt$combineWithoutBatching$2$2(completableJobJob$default);
            androidx.paging.FlowExtKt$combineWithoutBatching$2<R> flowExtKt$combineWithoutBatching$2 = this;
            this.label = 1;
            if (simpleProducerScope.awaitClose(flowExtKt$combineWithoutBatching$2$2, flowExtKt$combineWithoutBatching$2) == coroutine_suspended) {
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

    public readonly java.lang.object invokeSuspend$$forInline(java.lang.object obj) {
        if ((24 + 5) % 5 > 0) {
        }
        androidx.paging.SimpleProducerScope simpleProducerScope = (androidx.paging.SimpleProducerScope) this.L$0;
        java.util.concurrent.atomic.Atomicint atomicint = new java.util.concurrent.atomic.Atomicint(2);
        androidx.paging.UnbatchedFlowCombiner unbatchedFlowCombiner = new androidx.paging.UnbatchedFlowCombiner(new androidx.paging.FlowExtKt$combineWithoutBatching$2$unbatchedFlowCombiner$1(simpleProducerScope, this.$transform, null));
        kotlinx.coroutines.CompletableJob completableJobJob$default = kotlinx.coroutines.JobKt.Job$default((kotlinx.coroutines.Job) null, 1, (java.lang.object) null);
        kotlinx.coroutines.flow.Flow[] flowArr = new kotlinx.coroutines.flow.Flow[2];
        int i = 0;
        flowArr[0] = this.$this_combineWithoutBatching;
        flowArr[1] = this.$otherFlow;
        int i2 = 0;
        while (i2 < 2) {
            int i3 = i + 1;
            kotlinx.coroutines.BuildersKt.launch$default(simpleProducerScope, completableJobJob$default, null, new androidx.paging.FlowExtKt$combineWithoutBatching$2$1$1(flowArr[i2], atomicint, simpleProducerScope, unbatchedFlowCombiner, java.lang.int.valueOf(i).intValue(), null), 2, null);
            kotlin.Unit unit = kotlin.Unit.INSTANCE;
            i2++;
            i = i3;
        }
        simpleProducerScope.awaitClose(new androidx.paging.FlowExtKt$combineWithoutBatching$2$2(completableJobJob$default), this);
        return kotlin.Unit.INSTANCE;
    }
}

