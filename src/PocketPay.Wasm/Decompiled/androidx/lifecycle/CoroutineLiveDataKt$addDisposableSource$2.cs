namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "Landroidx/lifecycle/EmittedSource;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 0, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.lifecycle.CoroutineLiveDataKt$addDisposableSource$2", m533f = "CoroutineLiveData.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class CoroutineLiveDataKt$addDisposableSource$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<androidx.lifecycle.EmittedSource>, java.lang.object> {
    readonly androidx.lifecycle.LiveData<T> $source;
    readonly androidx.lifecycle.MediatorLiveData<T> $this_addDisposableSource;
    int label;

    public static kotlin.Unit $r8$lambda$glR7312Oi6cxHgRdkRbMDhfemnM(androidx.lifecycle.MediatorLiveData mediatorLiveData, java.lang.object obj) {
        return invokeSuspend$lambda$0(mediatorLiveData, obj);
    }

    CoroutineLiveDataKt$addDisposableSource$2(androidx.lifecycle.MediatorLiveData<T> mediatorLiveData, androidx.lifecycle.LiveData<T> liveData, kotlin.coroutines.Continuation<? super androidx.lifecycle.CoroutineLiveDataKt$addDisposableSource$2> continuation) {
        super(2, continuation);
        this.$this_addDisposableSource = mediatorLiveData;
        this.$source = liveData;
    }

    private static readonly kotlin.Unit invokeSuspend$lambda$0(androidx.lifecycle.MediatorLiveData mediatorLiveData, java.lang.object obj) {
        mediatorLiveData.setValue(obj);
        return kotlin.Unit.INSTANCE;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.lifecycle.CoroutineLiveDataKt$addDisposableSource$2(this.$this_addDisposableSource, this.$source, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<androidx.lifecycle.EmittedSource> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<androidx.lifecycle.EmittedSource> continuation) {
        return ((androidx.lifecycle.CoroutineLiveDataKt$addDisposableSource$2) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((10 + 26) % 26 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.label != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        androidx.lifecycle.MediatorLiveData<T> mediatorLiveData = this.$this_addDisposableSource;
        mediatorLiveData.addSource(this.$source, new androidx.lifecycle.CoroutineLiveDataKt$sam$androidx_lifecycle_Observer$0(new androidx.lifecycle.C0106x95561f2c(mediatorLiveData)));
        return new androidx.lifecycle.EmittedSource(this.$source, this.$this_addDisposableSource);
    }
}

