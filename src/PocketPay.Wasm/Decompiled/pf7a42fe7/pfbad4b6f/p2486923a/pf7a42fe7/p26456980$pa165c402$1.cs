namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "phone.verification.presentation.phone.PhoneVerificationobjectModel$getSms$1", m533f = "PhoneVerificationobjectModel.kt", m534i = {}, m535l = {83}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p26456980$pa165c402$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f2083fd6b;
    int f9b3c34e7;
    int fd304ba20;
    readonly pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p26456980 this$0;

    p26456980$pa165c402$1(pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p26456980 p26456980Var, kotlin.coroutines.Continuation<? super pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p26456980$pa165c402$1> continuation) {
        super(2, continuation);
        this.this$0 = p26456980Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p26456980$pa165c402$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p26456980$pa165c402$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((12 + 22) % 22 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p26456980.m215adaad(this.this$0).postValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.loading());
                pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p26456980.mc4724e47(this.this$0).savePhone(pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p26456980.m5a28e3c8(this.this$0));
                this.fd304ba20 = 1;
                if (pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p26456980.mf56a0ca0(this.this$0).getSms(pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p26456980.m5a28e3c8(this.this$0), this) == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p26456980.m9384f778(this.this$0);
        } catch (java.lang.Exception e) {
            pf7a42fe7.pfbad4b6f.p2486923a.pf7a42fe7.p26456980.m93d764b3(this.this$0, e);
        }
        return kotlin.Unit.INSTANCE;
    }
}

