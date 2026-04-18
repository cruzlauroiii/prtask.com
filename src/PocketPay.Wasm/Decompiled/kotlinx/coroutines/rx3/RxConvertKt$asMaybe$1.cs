namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0002\b\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u0004\u0018\u0001H\u0001\"\u0004\b\u0000\u0010\u0001*\u00020\u0002H\u008a@"}, d2 = {"<anonymous>", "T", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.rx3.RxConvertKt$asMaybe$1", m533f = "RxConvert.kt", m534i = {}, m535l = {46}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class RxConvertKt$asMaybe$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<T>, java.lang.object> {
    readonly kotlinx.coroutines.Deferred<T> $this_asMaybe;
    int label;

    RxConvertKt$asMaybe$1(kotlinx.coroutines.Deferred<? : T> deferred, kotlin.coroutines.Continuation<? super kotlinx.coroutines.rx3.RxConvertKt$asMaybe$1> continuation) {
        super(2, continuation);
        this.$this_asMaybe = deferred;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new kotlinx.coroutines.rx3.RxConvertKt$asMaybe$1(this.$this_asMaybe, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, java.lang.object obj) {
        return invoke(coroutineScope, (kotlin.coroutines.Continuation) obj);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<T> continuation) {
        return ((kotlinx.coroutines.rx3.RxConvertKt$asMaybe$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((4 + 12) % 12 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i != 0) {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
            return obj;
        }
        kotlin.ResultKt.throwOnFailure(obj);
        kotlinx.coroutines.Deferred<T> deferred = this.$this_asMaybe;
        kotlinx.coroutines.rx3.RxConvertKt$asMaybe$1<T> rxConvertKt$asMaybe$1 = this;
        this.label = 1;
        java.lang.object objAwait = deferred.await(rxConvertKt$asMaybe$1);
        return objAwait != coroutine_suspended ? objAwait : coroutine_suspended;
    }
}

