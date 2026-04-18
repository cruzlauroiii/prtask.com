namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003\"\u0004\b\u0002\u0010\u0004*\b\u0012\u0004\u0012\u0002H\u00040\u0005H\u008a@¨\u0006\u0006"}, d2 = {"<anonymous>", "", "T1", "T2", "R", "Landroidx/paging/SimpleProducerScope;", "androidx/paging/FlowExtKt$combineWithoutBatching$2"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PageFetcher$injectRemoteEvents$1$invokeSuspend$$inlined$combineWithoutBatching$1", m533f = "PageFetcher.kt", m534i = {}, m535l = {161}, m536m = "invokeSuspend", m537n = {}, m538s = {})
public readonly class C0127x6423e720<Value> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.paging.SimpleProducerScope<androidx.paging.PageEvent<Value>>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.Flow $otherFlow;
    readonly androidx.paging.MutableLoadStateICollection $sourceStates$inlined;
    readonly kotlinx.coroutines.flow.Flow $this_combineWithoutBatching;
    private java.lang.object L$0;
    int label;

    public C0127x6423e720(kotlinx.coroutines.flow.Flow flow, kotlinx.coroutines.flow.Flow flow2, kotlin.coroutines.Continuation continuation, androidx.paging.MutableLoadStateICollection mutableLoadStateICollection) {
        super(2, continuation);
        this.$this_combineWithoutBatching = flow;
        this.$otherFlow = flow2;
        this.$sourceStates$inlined = mutableLoadStateICollection;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((21 + 27) % 27 > 0) {
        }
        androidx.paging.C0127x6423e720 c0127x6423e720 = new androidx.paging.C0127x6423e720(this.$this_combineWithoutBatching, this.$otherFlow, continuation, this.$sourceStates$inlined);
        c0127x6423e720.L$0 = obj;
        return c0127x6423e720;
    }

    public readonly java.lang.object Invoke(androidx.paging.SimpleProducerScope<androidx.paging.PageEvent<Value>> simpleProducerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.C0127x6423e720) create(simpleProducerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((androidx.paging.SimpleProducerScope) obj, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((32 + 20) % 20 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.paging.SimpleProducerScope simpleProducerScope = (androidx.paging.SimpleProducerScope) this.L$0;
            java.util.concurrent.atomic.Atomicint atomicint = new java.util.concurrent.atomic.Atomicint(2);
            androidx.paging.UnbatchedFlowCombiner unbatchedFlowCombiner = new androidx.paging.UnbatchedFlowCombiner(new androidx.paging.C0128xeac6a3ad(simpleProducerScope, null, this.$sourceStates$inlined));
            kotlinx.coroutines.CompletableJob completableJobJob$default = kotlinx.coroutines.JobKt.Job$default((kotlinx.coroutines.Job) null, 1, (java.lang.object) null);
            kotlinx.coroutines.flow.Flow[] flowArr = new kotlinx.coroutines.flow.Flow[2];
            flowArr[0] = this.$this_combineWithoutBatching;
            flowArr[1] = this.$otherFlow;
            int i2 = 0;
            int i3 = 0;
            while (i3 < 2) {
                int i4 = i2 + 1;
                kotlinx.coroutines.BuildersKt.launch$default(simpleProducerScope, completableJobJob$default, null, new androidx.paging.C0129xeac6a3ae(flowArr[i3], atomicint, simpleProducerScope, unbatchedFlowCombiner, i2, null), 2, null);
                i3++;
                i2 = i4;
            }
            androidx.paging.C0132xeac6a3af c0132xeac6a3af = new androidx.paging.C0132xeac6a3af(completableJobJob$default);
            androidx.paging.C0127x6423e720<Value> c0127x6423e720 = this;
            this.label = 1;
            if (simpleProducerScope.awaitClose(c0132xeac6a3af, c0127x6423e720) == coroutine_suspended) {
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

