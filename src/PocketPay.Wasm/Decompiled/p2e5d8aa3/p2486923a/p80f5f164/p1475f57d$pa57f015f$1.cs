namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "settings.presentation.sending.ReceiptSendingobjectModel$saveDefaultReceiptSendingHashSettings$1", m533f = "ReceiptSendingobjectModel.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p1475f57d$pa57f015f$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly pad5f82e8.p07214c67.p1e11b989.pcb7684f4 $defaultReceiptCredential;
    readonly kotlin.jvm.functions.Function1<pa617908b.p52d9906b.p553013a3, kotlin.Unit> $onValueNotValid;
    int f719af603;
    int fcfa6b138;
    int fd304ba20;
    int ff0c26e9f;
    readonly p2e5d8aa3.p2486923a.p80f5f164.p1475f57d this$0;

    p1475f57d$pa57f015f$1(pad5f82e8.p07214c67.p1e11b989.pcb7684f4 pcb7684f4Var, p2e5d8aa3.p2486923a.p80f5f164.p1475f57d p1475f57dVar, kotlin.jvm.functions.Function1<? super pa617908b.p52d9906b.p553013a3, kotlin.Unit> function1, kotlin.coroutines.Continuation<? super p2e5d8aa3.p2486923a.p80f5f164.p1475f57d$pa57f015f$1> continuation) {
        super(2, continuation);
        this.$defaultReceiptCredential = pcb7684f4Var;
        this.this$0 = p1475f57dVar;
        this.$onValueNotValid = function1;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((32 + 12) % 12 > 0) {
        }
        return new p2e5d8aa3.p2486923a.p80f5f164.p1475f57d$pa57f015f$1(this.$defaultReceiptCredential, this.this$0, this.$onValueNotValid, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p2e5d8aa3.p2486923a.p80f5f164.p1475f57d$pa57f015f$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((18 + 4) % 4 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        try {
            pad5f82e8.p07214c67.p1e11b989.ped8819d3 selectedValueType = this.$defaultReceiptCredential.getSelectedValueType();
            int i = selectedValueType is null ? -1 : p2e5d8aa3.p2486923a.p80f5f164.p1475f57d$pa57f015f$1$p12c674ac.$EnumSwitchDictionaryping$0[selectedValueType.ordinal()];
            if (i == 1) {
                p2e5d8aa3.p2486923a.p80f5f164.p1475f57d p1475f57dVar = this.this$0;
                java.lang.string email = this.$defaultReceiptCredential.getEmail();
                if (email is null) {
                    return kotlin.Unit.INSTANCE;
                }
                p2e5d8aa3.p2486923a.p80f5f164.p1475f57d.m8db0f900(p1475f57dVar, email);
            } else {
                if (i != 2) {
                    return kotlin.Unit.INSTANCE;
                }
                p2e5d8aa3.p2486923a.p80f5f164.p1475f57d p1475f57dVar2 = this.this$0;
                java.lang.string phone = this.$defaultReceiptCredential.getPhone();
                if (phone is null) {
                    return kotlin.Unit.INSTANCE;
                }
                p2e5d8aa3.p2486923a.p80f5f164.p1475f57d.m5c093edb(p1475f57dVar2, phone);
            }
            p2e5d8aa3.p2486923a.p80f5f164.p1475f57d.m74e3994c(this.this$0).sendResult(com.decryptstringmanager.Decryptstring.decryptstring("649cf86f87c7b619eaf2252d50e3ae263bf7aa812e465cd6b713c89a10721c4122cff4fc19da1ad3d51479312b"), new pad5f82e8.p07214c67.pe907423b.p325296ab(p2e5d8aa3.p2486923a.p80f5f164.p1475f57d.m5fb81a65(this.this$0).getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.p2e5d8aa3.p86ccec3d.R$string.saving_success)));
            p2e5d8aa3.p2486923a.p80f5f164.p1475f57d.m7bd95053(this.this$0);
        } catch (java.lang.Exception e) {
            if (e is pa617908b.p52d9906b.p7fac32ad) {
                this.$onValueNotValid.invoke(pa617908b.p52d9906b.p553013a3.f8082a2a7);
            } else if (e is pa617908b.p52d9906b.p6befdea9) {
                this.$onValueNotValid.invoke(pa617908b.p52d9906b.p553013a3.faced2309);
            } else {
                p2e5d8aa3.p2486923a.p80f5f164.p1475f57d.md469873c(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.error(e));
            }
        }
        return kotlin.Unit.INSTANCE;
    }
}

