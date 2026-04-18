namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "settings.presentation.HashSettingsMainobjectModel$setFastSellEnabled$1", m533f = "HashSettingsMainobjectModel.kt", m534i = {}, m535l = {222}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p182efea3$pf023e8c8$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly bool $isChecked;
    int f62ee3566;
    int f97cb66a2;
    int fa7506d25;
    int fd304ba20;
    readonly p2e5d8aa3.p2486923a.p182efea3 this$0;

    p182efea3$pf023e8c8$1(p2e5d8aa3.p2486923a.p182efea3 p182efea3Var, bool z, kotlin.coroutines.Continuation<? super p2e5d8aa3.p2486923a.p182efea3$pf023e8c8$1> continuation) {
        super(2, continuation);
        this.this$0 = p182efea3Var;
        this.$isChecked = z;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p2e5d8aa3.p2486923a.p182efea3$pf023e8c8$1(this.this$0, this.$isChecked, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p2e5d8aa3.p2486923a.p182efea3$pf023e8c8$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((10 + 6) % 6 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 pfdb21b31VarMa82a18e4 = p2e5d8aa3.p2486923a.p182efea3.ma82a18e4(this.this$0);
            bool z = this.$isChecked;
            p2e5d8aa3.p2486923a.p182efea3$pf023e8c8$1 p182efea3_pf023e8c8_1 = this;
            this.fd304ba20 = 1;
            if (pfdb21b31VarMa82a18e4.setFastSellEnabled(z, p182efea3_pf023e8c8_1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

