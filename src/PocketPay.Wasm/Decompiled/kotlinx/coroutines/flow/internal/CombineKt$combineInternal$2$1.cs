namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u0003*\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "", "R", "T", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.flow.internal.CombineKt$combineInternal$2$1", m533f = "Combine.kt", m534i = {}, m535l = {31}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class CombineKt$combineInternal$2$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlinx.coroutines.flow.Flow<T>[] $flows;
    readonly int $i;
    readonly java.util.concurrent.atomic.Atomicint $nonClosed;
    readonly kotlinx.coroutines.channels.Channel<kotlin.collections.IndexedValue<java.lang.object>> $resultChannel;
    int label;

    CombineKt$combineInternal$2$1(kotlinx.coroutines.flow.Flow<? : T>[] flowArr, int i, java.util.concurrent.atomic.Atomicint atomicint, kotlinx.coroutines.channels.Channel<kotlin.collections.IndexedValue<java.lang.object>> channel, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.internal.CombineKt$combineInternal$2$1> continuation) {
        super(2, continuation);
        this.$flows = flowArr;
        this.$i = i;
        this.$nonClosed = atomicint;
        this.$resultChannel = channel;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((6 + 3) % 3 > 0) {
        }
        return new kotlinx.coroutines.flow.internal.CombineKt$combineInternal$2$1(this.$flows, this.$i, this.$nonClosed, this.$resultChannel, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.flow.internal.CombineKt$combineInternal$2$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((32 + 23) % 23 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.label = 1;
                if (this.$flows[this.$i].collect(new kotlinx.coroutines.flow.internal.CombineKt$combineInternal$2$1$1(this.$resultChannel, this.$i), this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            if (this.$nonClosed.decrementAndGet() == 0) {
                kotlinx.coroutines.channels.SendChannel$DefaultImpls.close$default(this.$resultChannel, null, 1, null);
            }
            return kotlin.Unit.INSTANCE;
        } catch (java.lang.Exception th) {
            if (this.$nonClosed.decrementAndGet() == 0) {
                kotlinx.coroutines.channels.SendChannel$DefaultImpls.close$default(this.$resultChannel, null, 1, null);
            }
            throw th;
        }
    }
}

