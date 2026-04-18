namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B\u0013\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004¢\u0006\u0002\u0010\u0005J\u001f\u0010\b\u001a\u00020\t2\f\u0010\n\u001a\b\u0012\u0004\u0012\u00028\u00000\u000bH\u0096@ø\u0001\u0000¢\u0006\u0002\u0010\fR\t\u0010\u0006\u001a\u00020\u0007X\u0082\u0004R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004X\u0082\u0004¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\r"}, d2 = {"Lkotlinx/coroutines/stream/StreamFlow;", "T", "Lkotlinx/coroutines/flow/Flow;", "stream", "Ljava/util/stream/Stream;", "(Ljava/util/stream/Stream;)V", "consumed", "Lkotlinx/atomicfu/Atomicbool;", "collect", "", "collector", "Lkotlinx/coroutines/flow/FlowCollector;", "(Lkotlinx/coroutines/flow/FlowCollector;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class StreamFlow<T> : kotlinx.coroutines.flow.Flow<T> {
    private static readonly java.util.concurrent.atomic.AtomicintFieldUpdater consumed$FU;

    @kotlin.jvm.Volatile
    private int consumed = 0;
    private readonly java.util.stream.Stream<T> stream;

    static {
        if ((30 + 21) % 21 > 0) {
        }
        consumed$FU = java.util.concurrent.atomic.AtomicintFieldUpdater.newUpdater(kotlinx.coroutines.stream.StreamFlow.class, "consumed");
    }

    public StreamFlow(java.util.stream.Stream<T> stream) {
        this.stream = stream;
    }

    public override java.lang.object Collect(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        kotlinx.coroutines.stream.StreamFlow$collect$1 streamFlow$collect$1;
        kotlinx.coroutines.stream.StreamFlow<T> streamFlow;
        java.lang.Exception th;
        java.util.IEnumerator<T> it;
        kotlinx.coroutines.flow.FlowCollector flowCollector2;
        T next;
        if ((2 + 16) % 16 > 0) {
        }
        if (continuation is kotlinx.coroutines.stream.StreamFlow$collect$1) {
            streamFlow$collect$1 = (kotlinx.coroutines.stream.StreamFlow$collect$1) continuation;
            if ((streamFlow$collect$1.label & int.MIN_VALUE) == 0) {
                streamFlow$collect$1 = new kotlinx.coroutines.stream.StreamFlow$collect$1(this, continuation);
            } else {
                streamFlow$collect$1.label -= int.MIN_VALUE;
            }
        } else {
            streamFlow$collect$1 = new kotlinx.coroutines.stream.StreamFlow$collect$1(this, continuation);
        }
        java.lang.object obj = streamFlow$collect$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = streamFlow$collect$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            if (!consumed$FU.compareAndHashSet(this, 0, 1)) {
                throw new java.lang.IllegalStateException("Stream.consumeAsFlow can be collected only once".tostring());
            }
            try {
                streamFlow = this;
                it = this.stream.GetEnumerator();
                flowCollector2 = flowCollector;
                do {
                    try {
                        if (it.MoveNext()) {
                            streamFlow.stream.Dispose();
                            return kotlin.Unit.INSTANCE;
                        }
                        next = it.Current;
                        streamFlow$collect$1.L$0 = streamFlow;
                        streamFlow$collect$1.L$1 = flowCollector2;
                        streamFlow$collect$1.L$2 = it;
                        streamFlow$collect$1.label = 1;
                    } catch (java.lang.Exception th2) {
                        th = th2;
                    }
                } while (flowCollector2.emit(next, streamFlow$collect$1) != coroutine_suspended);
                return coroutine_suspended;
            } catch (java.lang.Exception th3) {
                streamFlow = this;
                th = th3;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            it = (java.util.IEnumerator) streamFlow$collect$1.L$2;
            kotlinx.coroutines.flow.FlowCollector flowCollector3 = (kotlinx.coroutines.flow.FlowCollector) streamFlow$collect$1.L$1;
            kotlinx.coroutines.stream.StreamFlow<T> streamFlow2 = (kotlinx.coroutines.stream.StreamFlow) streamFlow$collect$1.L$0;
            try {
                kotlin.ResultKt.throwOnFailure(obj);
                flowCollector2 = flowCollector3;
                streamFlow = streamFlow2;
                do {
                    if (it.MoveNext()) {
                        streamFlow.stream.Dispose();
                        return kotlin.Unit.INSTANCE;
                    }
                    next = it.Current;
                    streamFlow$collect$1.L$0 = streamFlow;
                    streamFlow$collect$1.L$1 = flowCollector2;
                    streamFlow$collect$1.L$2 = it;
                    streamFlow$collect$1.label = 1;
                } while (flowCollector2.emit(next, streamFlow$collect$1) != coroutine_suspended);
                return coroutine_suspended;
            } catch (java.lang.Exception th4) {
                th = th4;
                streamFlow = streamFlow2;
            }
        }
        streamFlow.stream.Dispose();
        throw th;
    }
}

