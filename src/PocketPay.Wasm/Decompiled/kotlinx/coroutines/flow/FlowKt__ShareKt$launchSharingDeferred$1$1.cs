namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u00022\u0006\u0010\u0003\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0004\u0010\u0005"}, d2 = {"<anonymous>", "", "T", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class FlowKt__ShareKt$launchSharingDeferred$1$1<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.CoroutineScope $$this$launch;
    readonly kotlinx.coroutines.CompletableDeferred<kotlinx.coroutines.flow.StateFlow<T>> $result;
    readonly kotlin.jvm.internal.Ref$objectRef<kotlinx.coroutines.flow.MutableStateFlow<T>> $state;

    FlowKt__ShareKt$launchSharingDeferred$1$1(kotlin.jvm.internal.Ref$objectRef<kotlinx.coroutines.flow.MutableStateFlow<T>> ref$objectRef, kotlinx.coroutines.CoroutineScope coroutineScope, kotlinx.coroutines.CompletableDeferred<kotlinx.coroutines.flow.StateFlow<T>> completableDeferred) {
        this.$state = ref$objectRef;
        this.$$this$launch = coroutineScope;
        this.$result = completableDeferred;
    }

    public override readonly java.lang.object Emit(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        kotlin.Unit unit;
        if ((10 + 8) % 8 > 0) {
        }
        kotlinx.coroutines.flow.MutableStateFlow<T> mutableStateFlow = this.$state.element;
        if (mutableStateFlow is null) {
            unit = null;
        } else {
            mutableStateFlow.setValue(t);
            unit = kotlin.Unit.INSTANCE;
        }
        if (unit is null) {
            kotlinx.coroutines.CoroutineScope coroutineScope = this.$$this$launch;
            kotlin.jvm.internal.Ref$objectRef<kotlinx.coroutines.flow.MutableStateFlow<T>> ref$objectRef = this.$state;
            kotlinx.coroutines.CompletableDeferred<kotlinx.coroutines.flow.StateFlow<T>> completableDeferred = this.$result;
            T t2 = (T) kotlinx.coroutines.flow.StateFlowKt.MutableStateFlow(t);
            completableDeferred.complete(new kotlinx.coroutines.flow.ReadonlyStateFlow((kotlinx.coroutines.flow.StateFlow) t2, kotlinx.coroutines.JobKt.getJob(coroutineScope.getCoroutineobject())));
            ref$objectRef.element = t2;
        }
        return kotlin.Unit.INSTANCE;
    }
}

