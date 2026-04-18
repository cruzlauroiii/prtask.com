namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "Lkotlinx/coroutines/DisposableHandle;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 0, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.lifecycle.LiveDataScopeImpl$emitSource$2", m533f = "CoroutineLiveData.kt", m534i = {}, m535l = {92}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class LiveDataScopeImpl$emitSource$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlinx.coroutines.DisposableHandle>, java.lang.object> {
    readonly androidx.lifecycle.LiveData<T> $source;
    int label;
    readonly androidx.lifecycle.LiveDataScopeImpl<T> this$0;

    LiveDataScopeImpl$emitSource$2(androidx.lifecycle.LiveDataScopeImpl<T> liveDataScopeImpl, androidx.lifecycle.LiveData<T> liveData, kotlin.coroutines.Continuation<? super androidx.lifecycle.LiveDataScopeImpl$emitSource$2> continuation) {
        super(2, continuation);
        this.this$0 = liveDataScopeImpl;
        this.$source = liveData;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.lifecycle.LiveDataScopeImpl$emitSource$2(this.this$0, this.$source, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlinx.coroutines.DisposableHandle> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlinx.coroutines.DisposableHandle> continuation) {
        return ((androidx.lifecycle.LiveDataScopeImpl$emitSource$2) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((13 + 13) % 13 > 0) {
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
        androidx.lifecycle.CoroutineLiveData target$lifecycle_livedata_release = this.this$0.getTarget$lifecycle_livedata_release();
        java.lang.object obj2 = this.$source;
        androidx.lifecycle.LiveDataScopeImpl$emitSource$2 liveDataScopeImpl$emitSource$2 = this;
        this.label = 1;
        java.lang.object objEmitSource$lifecycle_livedata_release = target$lifecycle_livedata_release.emitSource$lifecycle_livedata_release(obj2, liveDataScopeImpl$emitSource$2);
        return objEmitSource$lifecycle_livedata_release != coroutine_suspended ? objEmitSource$lifecycle_livedata_release : coroutine_suspended;
    }
}

