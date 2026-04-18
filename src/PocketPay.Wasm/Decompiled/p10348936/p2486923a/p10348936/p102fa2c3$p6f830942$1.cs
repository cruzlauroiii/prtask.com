namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inventorization.presentation.inventorization.InventorizationobjectModel$sendReceiptWithResetRemainingPositionsQuantity$1", m533f = "InventorizationobjectModel.kt", m534i = {}, m535l = {82}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p102fa2c3$p6f830942$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f7acf8741;
    int fd304ba20;
    readonly p10348936.p2486923a.p10348936.p102fa2c3 this$0;

    p102fa2c3$p6f830942$1(p10348936.p2486923a.p10348936.p102fa2c3 p102fa2c3Var, kotlin.coroutines.Continuation<? super p10348936.p2486923a.p10348936.p102fa2c3$p6f830942$1> continuation) {
        super(2, continuation);
        this.this$0 = p102fa2c3Var;
    }

    public static void CArBWXcXeDIPYpgt(p10348936.pfd9160bb.pabe3770e pabe3770eVar) {
        pabe3770eVar.openInventorizationReceipt();
    }

    public static p10348936.pac143fb7.pd47d680b DuENLswuFRbYMNhC(p10348936.p2486923a.p10348936.p102fa2c3 p102fa2c3Var) {
        return p10348936.p2486923a.p10348936.p102fa2c3.ma0e3f333(p102fa2c3Var);
    }

    public static p10348936.pfd9160bb.pabe3770e FJHGIGOFroESgHUa(p10348936.p2486923a.p10348936.p102fa2c3 p102fa2c3Var) {
        return p10348936.p2486923a.p10348936.p102fa2c3.m74e3994c(p102fa2c3Var);
    }

    public static kotlin.coroutines.Continuation OQJwlYTEKwykxIJb(p10348936.p2486923a.p10348936.p102fa2c3$p6f830942$1 p102fa2c3_p6f830942_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return p102fa2c3_p6f830942_1.create(obj, continuation);
    }

    public static void BIZgLQSlYVjHoESL(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object EJXZJcxbZYKtZcTv(p10348936.p2486923a.p10348936.p102fa2c3$p6f830942$1 p102fa2c3_p6f830942_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return p102fa2c3_p6f830942_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static java.lang.object GJQFBHzbZBFAgSXB(p10348936.p2486923a.p10348936.p102fa2c3$p6f830942$1 p102fa2c3_p6f830942_1, java.lang.object obj) {
        return p102fa2c3_p6f830942_1.invokeSuspend(obj);
    }

    public static java.lang.object PBFVSsaQbUchKQbp() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void QDCuroulaAMjXTsM(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object XyJNFWPjmrPFTsIi(p10348936.pac143fb7.pd47d680b pd47d680bVar, p10348936.pf5e638cc.p14abd389 p14abd389Var, kotlin.coroutines.Continuation continuation) {
        return pd47d680bVar.updateCurrentInventorizationStatus(p14abd389Var, continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p10348936.p2486923a.p10348936.p102fa2c3$p6f830942$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return eJXZJcxbZYKtZcTv(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return gJQFBHzbZBFAgSXB((p10348936.p2486923a.p10348936.p102fa2c3$p6f830942$1) OQJwlYTEKwykxIJb(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((24 + 16) % 16 > 0) {
        }
        java.lang.object objPBFVSsaQbUchKQbp = pBFVSsaQbUchKQbp();
        int i = this.fd304ba20;
        if (i == 0) {
            qDCuroulaAMjXTsM(obj);
            p10348936.pac143fb7.pd47d680b pd47d680bVarDuENLswuFRbYMNhC = DuENLswuFRbYMNhC(this.this$0);
            p10348936.pf5e638cc.p14abd389 p14abd389Var = p10348936.pf5e638cc.p14abd389.fe24a0a67;
            p10348936.p2486923a.p10348936.p102fa2c3$p6f830942$1 p102fa2c3_p6f830942_1 = this;
            this.fd304ba20 = 1;
            if (xyJNFWPjmrPFTsIi(pd47d680bVarDuENLswuFRbYMNhC, p14abd389Var, p102fa2c3_p6f830942_1) == objPBFVSsaQbUchKQbp) {
                return objPBFVSsaQbUchKQbp;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            bIZgLQSlYVjHoESL(obj);
        }
        CArBWXcXeDIPYpgt(FJHGIGOFroESgHUa(this.this$0));
        return kotlin.Unit.INSTANCE;
    }
}

