namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "sell.presentation.fast_sell.FastSellChoosePaySystemobjectModel$preparePaymentsTypes$1", m533f = "FastSellChoosePaySystemobjectModel.kt", m534i = {}, m535l = {62}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p46c2fc5f$pee1daf82$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f48a1e79d;
    int fd304ba20;
    int ff07971b9;
    readonly p8325324b.p2486923a.p37982c62.p46c2fc5f this$0;

    p46c2fc5f$pee1daf82$1(p8325324b.p2486923a.p37982c62.p46c2fc5f p46c2fc5fVar, kotlin.coroutines.Continuation<? super p8325324b.p2486923a.p37982c62.p46c2fc5f$pee1daf82$1> continuation) {
        super(2, continuation);
        this.this$0 = p46c2fc5fVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p8325324b.p2486923a.p37982c62.p46c2fc5f$pee1daf82$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p8325324b.p2486923a.p37982c62.p46c2fc5f$pee1daf82$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((4 + 3) % 3 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.fd304ba20 = 1;
                obj = p8325324b.p2486923a.p37982c62.p46c2fc5f.mb272891c(this.this$0).getDevicePaymentHashSettings(this);
                if (obj == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            p8325324b.p2486923a.p37982c62.p46c2fc5f.ma6dd2715(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.success((java.util.List) obj));
        } catch (java.lang.Exception e) {
            p8325324b.p2486923a.p37982c62.p46c2fc5f.ma6dd2715(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.error(e));
        }
        return kotlin.Unit.INSTANCE;
    }
}

