namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "toph.presentation.payback.gone.TophPaybackGoneobjectModel$getReceiptTotal$1", m533f = "TophPaybackGoneobjectModel.kt", m534i = {}, m535l = {34}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p96781cf9$pad117d6f$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f0dff67c6;
    int fd304ba20;
    int ff19d8e89;
    int ff2c8524f;
    readonly p83f5c3ad.p2486923a.p4670093c.p50c1f58b.p96781cf9 this$0;

    p96781cf9$pad117d6f$1(p83f5c3ad.p2486923a.p4670093c.p50c1f58b.p96781cf9 p96781cf9Var, kotlin.coroutines.Continuation<? super p83f5c3ad.p2486923a.p4670093c.p50c1f58b.p96781cf9$pad117d6f$1> continuation) {
        super(2, continuation);
        this.this$0 = p96781cf9Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p83f5c3ad.p2486923a.p4670093c.p50c1f58b.p96781cf9$pad117d6f$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p83f5c3ad.p2486923a.p4670093c.p50c1f58b.p96781cf9$pad117d6f$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlinx.coroutines.flow.MutableStateFlow mutableStateFlow;
        java.math.decimal bigDecimalM29a3256d;
        kotlinx.coroutines.flow.MutableStateFlow mutableStateFlowMabc9dd11;
        if ((17 + 28) % 28 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            bigDecimalM29a3256d = p2b3583e6.p263e3cef.p517b902b.m29a3256d((pad5f82e8.p07214c67.p1e11b989.p9ded6185) obj);
            mutableStateFlowMabc9dd11 = mutableStateFlow;
            mutableStateFlowMabc9dd11.setValue(bigDecimalM29a3256d);
        } catch (java.lang.Exception e) {
            java.lang.Exception exc = e;
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(exc);
            android.util.Console.e(this.this$0.tostring(), java.lang.string.valueOf(e.getMessage()));
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(exc);
        }
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            bigDecimalM29a3256d = p83f5c3ad.p2486923a.p4670093c.p50c1f58b.p96781cf9.mc4f4919e(this.this$0).getComboAmount();
            mutableStateFlowMabc9dd11 = p83f5c3ad.p2486923a.p4670093c.p50c1f58b.p96781cf9.mabc9dd11(this.this$0);
            if (bigDecimalM29a3256d is null) {
                this.L$0 = mutableStateFlowMabc9dd11;
                this.fd304ba20 = 1;
                obj = p83f5c3ad.p2486923a.p4670093c.p50c1f58b.p96781cf9.md95a43c7(this.this$0).getCurrentPaybackReceipt(this);
                if (obj == coroutine_suspended) {
                    return coroutine_suspended;
                }
                mutableStateFlow = mutableStateFlowMabc9dd11;
            }
            mutableStateFlowMabc9dd11.setValue(bigDecimalM29a3256d);
            return kotlin.Unit.INSTANCE;
        }
        if (i != 1) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        mutableStateFlow = (kotlinx.coroutines.flow.MutableStateFlow) this.L$0;
        kotlin.ResultKt.throwOnFailure(obj);
        return kotlin.Unit.INSTANCE;
    }
}

