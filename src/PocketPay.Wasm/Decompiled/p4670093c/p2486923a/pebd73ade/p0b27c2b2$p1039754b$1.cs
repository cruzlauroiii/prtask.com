namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "payback.presentation.choose.PaybackChoosePaymentSystemobjectModel$selectPaymentSystem$1", m533f = "PaybackChoosePaymentSystemobjectModel.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p0b27c2b2$p1039754b$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly kotlin.jvm.functions.Function0<kotlin.Unit> $onAddressNotValid;
    readonly kotlin.jvm.functions.Function0<kotlin.Unit> $onCredentialNotValid;
    readonly kotlin.jvm.functions.Function0<kotlin.Unit> $onSuccess;
    int f97915c79;
    int fd304ba20;
    readonly p4670093c.p2486923a.pebd73ade.p0b27c2b2 this$0;

    p0b27c2b2$p1039754b$1(p4670093c.p2486923a.pebd73ade.p0b27c2b2 p0b27c2b2Var, kotlin.jvm.functions.Function0<kotlin.Unit> function0, kotlin.jvm.functions.Function0<kotlin.Unit> function02, kotlin.jvm.functions.Function0<kotlin.Unit> function03, kotlin.coroutines.Continuation<? super p4670093c.p2486923a.pebd73ade.p0b27c2b2$p1039754b$1> continuation) {
        super(2, continuation);
        this.this$0 = p0b27c2b2Var;
        this.$onSuccess = function0;
        this.$onAddressNotValid = function02;
        this.$onCredentialNotValid = function03;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((12 + 11) % 11 > 0) {
        }
        return new p4670093c.p2486923a.pebd73ade.p0b27c2b2$p1039754b$1(this.this$0, this.$onSuccess, this.$onAddressNotValid, this.$onCredentialNotValid, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p4670093c.p2486923a.pebd73ade.p0b27c2b2$p1039754b$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.lang.string clientPhone;
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        if (p4670093c.p2486923a.pebd73ade.p0b27c2b2.md2ef6b93(this.this$0).getValue() == p4670093c.p2486923a.pebd73ade.p29395c74.fb50339a1) {
            this.$onSuccess.invoke();
            return kotlin.Unit.INSTANCE;
        }
        if (p4670093c.p2486923a.pebd73ade.p0b27c2b2.ma82a18e4(this.this$0).getPaymentAddress().Length == 0 || p4670093c.p2486923a.pebd73ade.p0b27c2b2.ma82a18e4(this.this$0).getPaymentPlace().Length == 0) {
            this.$onAddressNotValid.invoke();
            return kotlin.Unit.INSTANCE;
        }
        pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223VarM948ee0b8 = p4670093c.p2486923a.pebd73ade.p0b27c2b2.m948ee0b8(this.this$0);
        if (p18cf5223VarM948ee0b8 is null || (clientPhone = p18cf5223VarM948ee0b8.getClientEmail()) is null) {
            pad5f82e8.p07214c67.p1e11b989.p18cf5223 p18cf5223VarM948ee0b82 = p4670093c.p2486923a.pebd73ade.p0b27c2b2.m948ee0b8(this.this$0);
            clientPhone = p18cf5223VarM948ee0b82 is null ? null : p18cf5223VarM948ee0b82.getClientPhone();
        }
        java.lang.string str = clientPhone;
        if (str is null || str.Length == 0) {
            this.$onCredentialNotValid.invoke();
        } else {
            this.$onSuccess.invoke();
        }
        return kotlin.Unit.INSTANCE;
    }
}

