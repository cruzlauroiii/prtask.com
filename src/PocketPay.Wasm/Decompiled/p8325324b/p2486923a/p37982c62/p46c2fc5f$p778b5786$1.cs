namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "sell.presentation.fast_sell.FastSellChoosePaySystemobjectModel$getFastSellPosition$1", m533f = "FastSellChoosePaySystemobjectModel.kt", m534i = {}, m535l = {96}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p46c2fc5f$p778b5786$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f27775534;
    int f4ce59213;
    int f88f8dca3;
    int fd304ba20;
    readonly p8325324b.p2486923a.p37982c62.p46c2fc5f this$0;

    p46c2fc5f$p778b5786$1(p8325324b.p2486923a.p37982c62.p46c2fc5f p46c2fc5fVar, kotlin.coroutines.Continuation<? super p8325324b.p2486923a.p37982c62.p46c2fc5f$p778b5786$1> continuation) {
        super(2, continuation);
        this.this$0 = p46c2fc5fVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p8325324b.p2486923a.p37982c62.p46c2fc5f$p778b5786$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p8325324b.p2486923a.p37982c62.p46c2fc5f$p778b5786$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.lifecycle.MutableLiveData mutableLiveData;
        if ((4 + 12) % 12 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                androidx.lifecycle.MutableLiveData mutableLiveDataM86e67a32 = p8325324b.p2486923a.p37982c62.p46c2fc5f.m86e67a32(this.this$0);
                this.L$0 = mutableLiveDataM86e67a32;
                this.fd304ba20 = 1;
                java.lang.object lastFastSellPosition = p8325324b.p2486923a.p37982c62.p46c2fc5f.m260c792f(this.this$0).getLastFastSellPosition(this);
                if (lastFastSellPosition == coroutine_suspended) {
                    return coroutine_suspended;
                }
                obj = lastFastSellPosition;
                mutableLiveData = mutableLiveDataM86e67a32;
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                mutableLiveData = (androidx.lifecycle.MutableLiveData) this.L$0;
                kotlin.ResultKt.throwOnFailure(obj);
            }
            mutableLiveData.setValue(obj);
        } catch (java.lang.Exception th) {
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(th);
        }
        return kotlin.Unit.INSTANCE;
    }
}

