namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 176)
public readonly class SafeCollector_commonKt$unsafeFlow$1$collect$1 : kotlin.coroutines.jvm.internal.ContinuationImpl {
    int label;
    java.lang.object result;
    readonly kotlinx.coroutines.flow.internal.SafeCollector_commonKt$unsafeFlow$1<T> this$0;

    public SafeCollector_commonKt$unsafeFlow$1$collect$1(kotlinx.coroutines.flow.internal.SafeCollector_commonKt$unsafeFlow$1<T> safeCollector_commonKt$unsafeFlow$1, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.internal.SafeCollector_commonKt$unsafeFlow$1$collect$1> continuation) {
        super(continuation);
        this.this$0 = safeCollector_commonKt$unsafeFlow$1;
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) {
        this.result = obj;
        this.label |= int.MIN_VALUE;
        return this.this$0.collect(null, this);
    }
}

