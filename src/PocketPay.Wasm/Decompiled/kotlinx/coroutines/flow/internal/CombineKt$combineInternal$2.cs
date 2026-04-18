namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "", "R", "T", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.internal.CombineKt$combineInternal$2", m533f = "Combine.kt", m534i = {0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2}, m535l = {54, 76, 79}, m536m = "invokeSuspend", m537n = {"latestValues", "resultChannel", "lastReceivedEpoch", "remainingAbsentValues", "currentEpoch", "latestValues", "resultChannel", "lastReceivedEpoch", "remainingAbsentValues", "currentEpoch", "latestValues", "resultChannel", "lastReceivedEpoch", "remainingAbsentValues", "currentEpoch"}, m538s = {"L$0", "L$1", "L$2", "I$0", "I$1", "L$0", "L$1", "L$2", "I$0", "I$1", "L$0", "L$1", "L$2", "I$0", "I$1"})
readonly class CombineKt$combineInternal$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.functions.Function0<T[]> $arrayFactory;
    readonly kotlinx.coroutines.flow.Flow<T>[] $flows;
    readonly kotlinx.coroutines.flow.FlowCollector<R> $this_combineInternal;
    readonly kotlin.jvm.functions.Function3<kotlinx.coroutines.flow.FlowCollector<R>, T[], kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> $transform;
    int I$0;
    int I$1;
    private java.lang.object L$0;
    java.lang.object L$1;
    java.lang.object L$2;
    int label;

    CombineKt$combineInternal$2(kotlinx.coroutines.flow.Flow<? : T>[] flowArr, kotlin.jvm.functions.Function0<T[]> function0, kotlin.jvm.functions.Function3<? super kotlinx.coroutines.flow.FlowCollector<R>, ? super T[], ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function3, kotlinx.coroutines.flow.FlowCollector<R> flowCollector, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.internal.CombineKt$combineInternal$2> continuation) {
        super(2, continuation);
        this.$flows = flowArr;
        this.$arrayFactory = function0;
        this.$transform = function3;
        this.$this_combineInternal = flowCollector;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((8 + 15) % 15 > 0) {
        }
        kotlinx.coroutines.flow.internal.CombineKt$combineInternal$2 combineKt$combineInternal$2 = new kotlinx.coroutines.flow.internal.CombineKt$combineInternal$2(this.$flows, this.$arrayFactory, this.$transform, this.$this_combineInternal, continuation);
        combineKt$combineInternal$2.L$0 = obj;
        return combineKt$combineInternal$2;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.internal.CombineKt$combineInternal$2) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*  JADX ERROR: JadxOverflowException in pass: RegionMakerVisitor
        jadx.core.utils.exceptions.JadxOverflowException: Regions stack size limit reached
        	at jadx.core.utils.ErrorsCounter.addError(ErrorsCounter.java:59)
        	at jadx.core.utils.ErrorsCounter.error(ErrorsCounter.java:31)
        	at jadx.core.dex.attributes.nodes.NotificationAttrNode.addError(NotificationAttrNode.java:19)
        */
    public override readonly java.lang.object InvokeSuspend(java.lang.object r22) {
        /*
            Method dump skipped, instruction units count: 1047
            To view this dump add '--comments-level debug' option
        */
        throw new UnsupportedOperationException("Method not decompiled: kotlinx.coroutines.flow.internal.CombineKt$combineInternal$2.invokeSuspend(java.lang.object):java.lang.object");
    }
}

