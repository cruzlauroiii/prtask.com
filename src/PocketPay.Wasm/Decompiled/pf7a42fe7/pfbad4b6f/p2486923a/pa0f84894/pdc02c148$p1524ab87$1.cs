namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "phone.verification.presentation.setup.HashSetupobjectModel$getGCashUrl$1", m533f = "HashSetupobjectModel.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pdc02c148$p1524ab87$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f0e2b50ef;
    int fd304ba20;
    readonly pf7a42fe7.pfbad4b6f.p2486923a.pa0f84894.pdc02c148 this$0;

    pdc02c148$p1524ab87$1(pf7a42fe7.pfbad4b6f.p2486923a.pa0f84894.pdc02c148 pdc02c148Var, kotlin.coroutines.Continuation<? super pf7a42fe7.pfbad4b6f.p2486923a.pa0f84894.pdc02c148$p1524ab87$1> continuation) {
        super(2, continuation);
        this.this$0 = pdc02c148Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new pf7a42fe7.pfbad4b6f.p2486923a.pa0f84894.pdc02c148$p1524ab87$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((pf7a42fe7.pfbad4b6f.p2486923a.pa0f84894.pdc02c148$p1524ab87$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        try {
            pf7a42fe7.pfbad4b6f.p2486923a.pa0f84894.pdc02c148.mc1803245(this.this$0).setValue(pf7a42fe7.pfbad4b6f.p2486923a.pa0f84894.pdc02c148.m0d4818a9(this.this$0).getGCashUrl());
        } catch (java.lang.Exception e) {
            com.google.firebase.crashlytics.FirebaseCrashlytics.getInstance().recordException(e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

