namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "launcher.presentation.launcher.LauncherobjectModel$getDevice$1", m533f = "LauncherobjectModel.kt", m534i = {}, m535l = {126}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p68265f70$p80a7111c$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f8d977c88;
    int fd304ba20;
    readonly pf3e08b51.p2486923a.pf3e08b51.p68265f70 this$0;

    p68265f70$p80a7111c$1(pf3e08b51.p2486923a.pf3e08b51.p68265f70 p68265f70Var, kotlin.coroutines.Continuation<? super pf3e08b51.p2486923a.pf3e08b51.p68265f70$p80a7111c$1> continuation) {
        super(2, continuation);
        this.this$0 = p68265f70Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new pf3e08b51.p2486923a.pf3e08b51.p68265f70$p80a7111c$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((pf3e08b51.p2486923a.pf3e08b51.p68265f70$p80a7111c$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((27 + 22) % 22 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        try {
            if (i == 0) {
                kotlin.ResultKt.throwOnFailure(obj);
                this.fd304ba20 = 1;
                obj = pf3e08b51.p2486923a.pf3e08b51.p68265f70.m701d8e58(this.this$0).getSelectedDevice(this);
                if (obj == coroutine_suspended) {
                    return coroutine_suspended;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                kotlin.ResultKt.throwOnFailure(obj);
            }
            pad5f82e8.p07214c67.pe0212e54.p4f30e9bd p4f30e9bdVar = (pad5f82e8.p07214c67.pe0212e54.p4f30e9bd) obj;
            pf3e08b51.p2486923a.pf3e08b51.p68265f70.m94927ace(this.this$0, p4f30e9bdVar);
            pf3e08b51.p2486923a.pf3e08b51.p68265f70.m7be5acb3(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.success(pad5f82e8.p07214c67.pe0212e54.p4f30e9bd.m1c1e012b(p4f30e9bdVar, null, null, null, pf3e08b51.p2486923a.pf3e08b51.p68265f70.m5fb81a65(this.this$0).getstring(p4d236d9a.p2df4812c.pf5d7e253.p705f8913.p518a4861.pf3e08b51.p86ccec3d.R$string.terminal_without_fiscalization_mode), null, null, null, false, null, null, 1015, null)));
        } catch (java.lang.Exception e) {
            pf3e08b51.p2486923a.pf3e08b51.p68265f70.m7be5acb3(this.this$0).setValue(pad5f82e8.p07214c67.pa4ecfc70.f910eef8c.error(e));
        }
        return kotlin.Unit.INSTANCE;
    }
}

