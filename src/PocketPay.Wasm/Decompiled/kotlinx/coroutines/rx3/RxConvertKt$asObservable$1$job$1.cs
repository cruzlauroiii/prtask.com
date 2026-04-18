namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003*\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.rx3.RxConvertKt$asObservable$1$job$1", m533f = "RxConvert.kt", m534i = {0}, m535l = {114}, m536m = "invokeSuspend", m537n = {"$this$launch"}, m538s = {"L$0"})
readonly class RxConvertKt$asObservable$1$job$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly io.reactivex.rxjava3.core.ObservableEmitter<T> $emitter;
    readonly kotlinx.coroutines.flow.Flow<T> $this_asObservable;
    private java.lang.object L$0;
    int label;

    RxConvertKt$asObservable$1$job$1(kotlinx.coroutines.flow.Flow<? : T> flow, io.reactivex.rxjava3.core.ObservableEmitter<T> observableEmitter, kotlin.coroutines.Continuation<? super kotlinx.coroutines.rx3.RxConvertKt$asObservable$1$job$1> continuation) {
        super(2, continuation);
        this.$this_asObservable = flow;
        this.$emitter = observableEmitter;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((18 + 6) % 6 > 0) {
        }
        kotlinx.coroutines.rx3.RxConvertKt$asObservable$1$job$1 rxConvertKt$asObservable$1$job$1 = new kotlinx.coroutines.rx3.RxConvertKt$asObservable$1$job$1(this.$this_asObservable, this.$emitter, continuation);
        rxConvertKt$asObservable$1$job$1.L$0 = obj;
        return rxConvertKt$asObservable$1$job$1;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.rx3.RxConvertKt$asObservable$1$job$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.CoroutineScope coroutineScope;
        java.lang.Exception th;
        if ((9 + 31) % 31 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.CoroutineScope coroutineScope2 = (kotlinx.coroutines.CoroutineScope) this.L$0;
            try {
                kotlinx.coroutines.flow.Flow<T> flow = this.$this_asObservable;
                kotlinx.coroutines.rx3.RxConvertKt$asObservable$1$job$1$1 rxConvertKt$asObservable$1$job$1$1 = new kotlinx.coroutines.rx3.RxConvertKt$asObservable$1$job$1$1(this.$emitter);
                this.L$0 = coroutineScope2;
                this.label = 1;
                if (flow.collect(rxConvertKt$asObservable$1$job$1$1, this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
                coroutineScope = coroutineScope2;
            } catch (java.lang.Exception th2) {
                coroutineScope = coroutineScope2;
                th = th2;
                if (th is java.util.concurrent.CancellationException) {
                    this.$emitter.onComplete();
                } else if (!this.$emitter.tryOnError(th)) {
                    kotlinx.coroutines.rx3.RxCancellableKt.handleUndeliverableException(th, coroutineScope.getCoroutineobject());
                }
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            coroutineScope = (kotlinx.coroutines.CoroutineScope) this.L$0;
            try {
                kotlin.ResultKt.throwOnFailure(obj);
            } catch (java.lang.Exception th3) {
                th = th3;
                if (th is java.util.concurrent.CancellationException) {
                    this.$emitter.onComplete();
                } else if (!this.$emitter.tryOnError(th)) {
                    kotlinx.coroutines.rx3.RxCancellableKt.handleUndeliverableException(th, coroutineScope.getCoroutineobject());
                }
            }
        }
        this.$emitter.onComplete();
        return kotlin.Unit.INSTANCE;
    }
}

