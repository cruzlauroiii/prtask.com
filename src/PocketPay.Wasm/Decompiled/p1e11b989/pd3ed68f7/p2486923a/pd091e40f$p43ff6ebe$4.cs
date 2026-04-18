namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "receipt.credentials.presentation.ReceiptSendingobject$onobjectCreated$4", m533f = "ReceiptSendingobject.kt", m534i = {}, m535l = {73}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pd091e40f$p43ff6ebe$4 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f361456bc;
    int f4770173f;
    int fd304ba20;
    int fe0ad3b77;
    readonly p1e11b989.pd3ed68f7.p2486923a.pd091e40f this$0;

    pd091e40f$p43ff6ebe$4(p1e11b989.pd3ed68f7.p2486923a.pd091e40f pd091e40fVar, kotlin.coroutines.Continuation<? super p1e11b989.pd3ed68f7.p2486923a.pd091e40f$p43ff6ebe$4> continuation) {
        super(2, continuation);
        this.this$0 = pd091e40fVar;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p1e11b989.pd3ed68f7.p2486923a.pd091e40f$p43ff6ebe$4(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p1e11b989.pd3ed68f7.p2486923a.pd091e40f$p43ff6ebe$4) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((13 + 30) % 30 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p1e11b989.pd3ed68f7.p2486923a.pd091e40f$p43ff6ebe$4 pd091e40f_p43ff6ebe_4 = this;
            this.fd304ba20 = 1;
            if (kotlinx.coroutines.DelayKt.delay(150L, pd091e40f_p43ff6ebe_4) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        p59a14a57.pd3ed68f7.p6d8494e4 p6d8494e4Var = p1e11b989.pd3ed68f7.p2486923a.pd091e40f.m3cf59762(this.this$0).f4b43e9b0;
        p1e11b989.pd3ed68f7.p2486923a.pd091e40f pd091e40fVar = this.this$0;
        p1e11b989.pd3ed68f7.p2486923a.pd091e40f.mffb32b27(pd091e40fVar, p1e11b989.pd3ed68f7.p2486923a.pd091e40f.m3cf59762(pd091e40fVar).f4b43e9b0.getDefaultReceiptCredentialsEditText());
        return kotlin.Unit.INSTANCE;
    }
}

