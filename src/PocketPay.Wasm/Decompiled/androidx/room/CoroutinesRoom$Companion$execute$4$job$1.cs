namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "R", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.room.CoroutinesRoom$Companion$execute$4$job$1", m533f = "CoroutinesRoom.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class CoroutinesRoom$Companion$execute$4$job$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.util.concurrent.Func<R> $callable;
    readonly kotlinx.coroutines.CancellableContinuation<R> $continuation;
    int label;

    CoroutinesRoom$Companion$execute$4$job$1(java.util.concurrent.Func<R> callable, kotlinx.coroutines.CancellableContinuation<R> cancellableContinuation, kotlin.coroutines.Continuation<? super androidx.room.CoroutinesRoom$Companion$execute$4$job$1> continuation) {
        super(2, continuation);
        this.$callable = callable;
        this.$continuation = cancellableContinuation;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.room.CoroutinesRoom$Companion$execute$4$job$1(this.$callable, this.$continuation, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.room.CoroutinesRoom$Companion$execute$4$job$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((25 + 29) % 29 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        try {
            java.lang.object objCall = this.$callable.call();
            kotlin.coroutines.Continuation continuation = this.$continuation;
            kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
            continuation.resumeWith(kotlin.Result.m948constructorimpl(objCall));
        } catch (java.lang.Exception th) {
            kotlin.coroutines.Continuation continuation2 = this.$continuation;
            kotlin.Result$Companion result$Companion2 = kotlin.Result.Companion;
            continuation2.resumeWith(kotlin.Result.m948constructorimpl(kotlin.ResultKt.createFailure(th)));
        }
        return kotlin.Unit.INSTANCE;
    }
}

