namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "sell.presentation.fast_sell.FastSellChoosePaySystemobjectModel$onFastSellPositionChanged$1", m533f = "FastSellChoosePaySystemobjectModel.kt", m534i = {}, m535l = {86}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p46c2fc5f$p309d12c1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.lang.string $name;
    readonly java.math.decimal $price;
    int f370302ca;
    int fbe84d065;
    int fd304ba20;
    readonly p8325324b.p2486923a.p37982c62.p46c2fc5f this$0;

    p46c2fc5f$p309d12c1$1(p8325324b.p2486923a.p37982c62.p46c2fc5f p46c2fc5fVar, java.lang.string str, java.math.decimal bigDecimal, kotlin.coroutines.Continuation<? super p8325324b.p2486923a.p37982c62.p46c2fc5f$p309d12c1$1> continuation) {
        super(2, continuation);
        this.this$0 = p46c2fc5fVar;
        this.$name = str;
        this.$price = bigDecimal;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((21 + 22) % 22 > 0) {
        }
        return new p8325324b.p2486923a.p37982c62.p46c2fc5f$p309d12c1$1(this.this$0, this.$name, this.$price, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p8325324b.p2486923a.p37982c62.p46c2fc5f$p309d12c1$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((24 + 29) % 29 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.fd304ba20 = 1;
                if (p8325324b.p2486923a.p37982c62.p46c2fc5f.m260c792f(this.this$0).setLastFastSellPosition(this.$name, this.$price, this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
        } catch (java.lang.Exception th) {
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(th);
        }
        return kotlin.Unit.INSTANCE;
    }
}

