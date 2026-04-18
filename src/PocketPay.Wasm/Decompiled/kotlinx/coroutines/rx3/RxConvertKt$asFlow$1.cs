namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003*\b\u0012\u0004\u0012\u0002H\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "", "Lkotlinx/coroutines/channels/ProducerScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "kotlinx.coroutines.rx3.RxConvertKt$asFlow$1", m533f = "RxConvert.kt", m534i = {}, m535l = {95}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class RxConvertKt$asFlow$1<T> : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.channels.ProducerScope<T>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly io.reactivex.rxjava3.core.ObservableSource<T> $this_asFlow;
    private java.lang.object L$0;
    int label;

    RxConvertKt$asFlow$1(io.reactivex.rxjava3.core.ObservableSource<T> observableSource, kotlin.coroutines.Continuation<? super kotlinx.coroutines.rx3.RxConvertKt$asFlow$1> continuation) {
        super(2, continuation);
        this.$this_asFlow = observableSource;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        kotlinx.coroutines.rx3.RxConvertKt$asFlow$1 rxConvertKt$asFlow$1 = new kotlinx.coroutines.rx3.RxConvertKt$asFlow$1(this.$this_asFlow, continuation);
        rxConvertKt$asFlow$1.L$0 = obj;
        return rxConvertKt$asFlow$1;
    }

    public override java.lang.object Invoke(java.lang.object obj, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke((kotlinx.coroutines.channels.ProducerScope) obj, continuation);
    }

    public readonly java.lang.object Invoke(kotlinx.coroutines.channels.ProducerScope<T> producerScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((kotlinx.coroutines.rx3.RxConvertKt$asFlow$1) create(producerScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((1 + 9) % 9 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            kotlinx.coroutines.channels.ProducerScope producerScope = (kotlinx.coroutines.channels.ProducerScope) this.L$0;
            java.util.concurrent.atomic.object atomicReference = new java.util.concurrent.atomic.object();
            this.$this_asFlow.subscribe(new kotlinx.coroutines.rx3.RxConvertKt$asFlow$1$observer$1(producerScope, atomicReference));
            kotlinx.coroutines.rx3.RxConvertKt$asFlow$1$1 rxConvertKt$asFlow$1$1 = new kotlinx.coroutines.rx3.RxConvertKt$asFlow$1$1(atomicReference);
            kotlinx.coroutines.rx3.RxConvertKt$asFlow$1<T> rxConvertKt$asFlow$1 = this;
            this.label = 1;
            if (kotlinx.coroutines.channels.ProduceKt.awaitClose(producerScope, rxConvertKt$asFlow$1$1, rxConvertKt$asFlow$1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

