namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inventorization.presentation.inventorization.InventorizationobjectModel$sendReceipt$1", m533f = "InventorizationobjectModel.kt", m534i = {}, m535l = {64}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p102fa2c3$p807ee7c0$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f2b00f083;
    int f46f32163;
    int faeadf2e5;
    int fd304ba20;
    readonly p10348936.p2486923a.p10348936.p102fa2c3 this$0;

    p102fa2c3$p807ee7c0$1(p10348936.p2486923a.p10348936.p102fa2c3 p102fa2c3Var, kotlin.coroutines.Continuation<? super p10348936.p2486923a.p10348936.p102fa2c3$p807ee7c0$1> continuation) {
        super(2, continuation);
        this.this$0 = p102fa2c3Var;
    }

    public static java.lang.object LXhgUDwBlYrckkqk(p10348936.pac143fb7.pd47d680b pd47d680bVar, p10348936.pf5e638cc.p14abd389 p14abd389Var, kotlin.coroutines.Continuation continuation) {
        return pd47d680bVar.updateCurrentInventorizationStatus(p14abd389Var, continuation);
    }

    public static p10348936.pfd9160bb.pabe3770e MSeDXJmRsJSxqPoH(p10348936.p2486923a.p10348936.p102fa2c3 p102fa2c3Var) {
        return p10348936.p2486923a.p10348936.p102fa2c3.m74e3994c(p102fa2c3Var);
    }

    public static java.lang.object RgFmEfSHpbOKxHnw(p10348936.p2486923a.p10348936.p102fa2c3$p807ee7c0$1 p102fa2c3_p807ee7c0_1, java.lang.object obj) {
        return p102fa2c3_p807ee7c0_1.invokeSuspend(obj);
    }

    public static void TpDkxTzUulKhwDHR(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static p10348936.pac143fb7.pd47d680b VJfleDqvCfSAAYmj(p10348936.p2486923a.p10348936.p102fa2c3 p102fa2c3Var) {
        return p10348936.p2486923a.p10348936.p102fa2c3.ma0e3f333(p102fa2c3Var);
    }

    public static java.lang.object WMOyavPXMsexfxvt(p10348936.p2486923a.p10348936.p102fa2c3$p807ee7c0$1 p102fa2c3_p807ee7c0_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return p102fa2c3_p807ee7c0_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static void LuTpEYuslZNEXDKH(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object NbiRJbWWpmJKtUtB() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void WdSTPcXJOndfdsFq(p10348936.pfd9160bb.pabe3770e pabe3770eVar) {
        pabe3770eVar.openInventorizationReceipt();
    }

    public static kotlin.coroutines.Continuation XTbMqhmXhOtXALtP(p10348936.p2486923a.p10348936.p102fa2c3$p807ee7c0$1 p102fa2c3_p807ee7c0_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return p102fa2c3_p807ee7c0_1.create(obj, continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p10348936.p2486923a.p10348936.p102fa2c3$p807ee7c0$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return WMOyavPXMsexfxvt(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return RgFmEfSHpbOKxHnw((p10348936.p2486923a.p10348936.p102fa2c3$p807ee7c0$1) xTbMqhmXhOtXALtP(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((22 + 15) % 15 > 0) {
        }
        java.lang.object objNbiRJbWWpmJKtUtB = nbiRJbWWpmJKtUtB();
        int i = this.fd304ba20;
        if (i == 0) {
            luTpEYuslZNEXDKH(obj);
            p10348936.pac143fb7.pd47d680b pd47d680bVarVJfleDqvCfSAAYmj = VJfleDqvCfSAAYmj(this.this$0);
            p10348936.pf5e638cc.p14abd389 p14abd389Var = p10348936.pf5e638cc.p14abd389.f66f73e50;
            p10348936.p2486923a.p10348936.p102fa2c3$p807ee7c0$1 p102fa2c3_p807ee7c0_1 = this;
            this.fd304ba20 = 1;
            if (LXhgUDwBlYrckkqk(pd47d680bVarVJfleDqvCfSAAYmj, p14abd389Var, p102fa2c3_p807ee7c0_1) == objNbiRJbWWpmJKtUtB) {
                return objNbiRJbWWpmJKtUtB;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            TpDkxTzUulKhwDHR(obj);
        }
        wdSTPcXJOndfdsFq(MSeDXJmRsJSxqPoH(this.this$0));
        return kotlin.Unit.INSTANCE;
    }
}

