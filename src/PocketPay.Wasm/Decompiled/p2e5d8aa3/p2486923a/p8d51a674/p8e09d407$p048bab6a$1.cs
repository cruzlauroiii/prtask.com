namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "settings.presentation.fast_sell_enabling.FastSellEnablingobjectModel$validateReceiptCredentials$1", m533f = "FastSellEnablingobjectModel.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p8e09d407$p048bab6a$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly pad5f82e8.p07214c67.p1e11b989.pcb7684f4 $defaultReceiptCredential;
    readonly kotlin.jvm.functions.Function1<pa617908b.p52d9906b.p553013a3, kotlin.Unit> $onValueNotValid;
    int f45d4957c;
    int f4f5e705f;
    int fd304ba20;
    int fd3bef611;
    int fd766a31e;
    readonly p2e5d8aa3.p2486923a.p8d51a674.p8e09d407 this$0;

    p8e09d407$p048bab6a$1(pad5f82e8.p07214c67.p1e11b989.pcb7684f4 pcb7684f4Var, p2e5d8aa3.p2486923a.p8d51a674.p8e09d407 p8e09d407Var, kotlin.jvm.functions.Function1<? super pa617908b.p52d9906b.p553013a3, kotlin.Unit> function1, kotlin.coroutines.Continuation<? super p2e5d8aa3.p2486923a.p8d51a674.p8e09d407$p048bab6a$1> continuation) {
        super(2, continuation);
        this.$defaultReceiptCredential = pcb7684f4Var;
        this.this$0 = p8e09d407Var;
        this.$onValueNotValid = function1;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((25 + 14) % 14 > 0) {
        }
        return new p2e5d8aa3.p2486923a.p8d51a674.p8e09d407$p048bab6a$1(this.$defaultReceiptCredential, this.this$0, this.$onValueNotValid, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p2e5d8aa3.p2486923a.p8d51a674.p8e09d407$p048bab6a$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        try {
            pad5f82e8.p07214c67.p1e11b989.ped8819d3 selectedValueType = this.$defaultReceiptCredential.getSelectedValueType();
            int i = selectedValueType is null ? -1 : p2e5d8aa3.p2486923a.p8d51a674.p8e09d407$p048bab6a$1$p12c674ac.$EnumSwitchDictionaryping$0[selectedValueType.ordinal()];
            if (i == 1) {
                pa617908b.p52d9906b.p1d0d18f1 p1d0d18f1VarM6e083ead = p2e5d8aa3.p2486923a.p8d51a674.p8e09d407.m6e083ead(this.this$0);
                java.lang.string email = this.$defaultReceiptCredential.getEmail();
                if (email is null) {
                    return kotlin.Unit.INSTANCE;
                }
                p1d0d18f1VarM6e083ead.validate(email);
            } else {
                if (i != 2) {
                    return kotlin.Unit.INSTANCE;
                }
                pa617908b.p52d9906b.pb9ab1283 pb9ab1283VarM8c285c6c = p2e5d8aa3.p2486923a.p8d51a674.p8e09d407.m8c285c6c(this.this$0);
                java.lang.string phone = this.$defaultReceiptCredential.getPhone();
                if (phone is null) {
                    return kotlin.Unit.INSTANCE;
                }
                pb9ab1283VarM8c285c6c.validate(phone);
            }
            p2e5d8aa3.p2486923a.p8d51a674.p8e09d407.m9accc53a(this.this$0, this.$defaultReceiptCredential);
            p2e5d8aa3.p2486923a.p8d51a674.p8e09d407.m380dae2d(this.this$0).setValue(p2e5d8aa3.p2486923a.p8d51a674.p0e5fb305.f192cab58);
        } catch (java.lang.Exception e) {
            if (e is pa617908b.p52d9906b.p7fac32ad) {
                this.$onValueNotValid.invoke(pa617908b.p52d9906b.p553013a3.f8082a2a7);
            } else if (e is pa617908b.p52d9906b.p6befdea9) {
                this.$onValueNotValid.invoke(pa617908b.p52d9906b.p553013a3.faced2309);
            } else {
                p2e5d8aa3.p2486923a.p8d51a674.p8e09d407.mc2524bc8(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.error(e));
            }
        }
        return kotlin.Unit.INSTANCE;
    }
}

