namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inventorization.presentation.inventorization.InventorizationobjectModel$sendReceiptWithRemainingPositions$1", m533f = "InventorizationobjectModel.kt", m534i = {}, m535l = {73}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p102fa2c3$p167a3ef2$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f22bb9def;
    int f394397e0;
    int fd304ba20;
    int ff4e36402;
    readonly p10348936.p2486923a.p10348936.p102fa2c3 this$0;

    p102fa2c3$p167a3ef2$1(p10348936.p2486923a.p10348936.p102fa2c3 p102fa2c3Var, kotlin.coroutines.Continuation<? super p10348936.p2486923a.p10348936.p102fa2c3$p167a3ef2$1> continuation) {
        super(2, continuation);
        this.this$0 = p102fa2c3Var;
    }

    public static kotlin.coroutines.Continuation CpvVxJvSnIwQVgUb(p10348936.p2486923a.p10348936.p102fa2c3$p167a3ef2$1 p102fa2c3_p167a3ef2_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return p102fa2c3_p167a3ef2_1.create(obj, continuation);
    }

    public static void GtgvpDDOFUDXlVhX(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object KdCYmDoKJYttWyWA() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object AAkMUrNocjvOtkTn(p10348936.pac143fb7.pd47d680b pd47d680bVar, p10348936.pf5e638cc.p14abd389 p14abd389Var, kotlin.coroutines.Continuation continuation) {
        return pd47d680bVar.updateCurrentInventorizationStatus(p14abd389Var, continuation);
    }

    public static void CUGcuHqkGlHVWLoL(p10348936.pfd9160bb.pabe3770e pabe3770eVar) {
        pabe3770eVar.openInventorizationReceipt();
    }

    public static java.lang.object KTwKuhvIfcKtWjDJ(p10348936.p2486923a.p10348936.p102fa2c3$p167a3ef2$1 p102fa2c3_p167a3ef2_1, java.lang.object obj) {
        return p102fa2c3_p167a3ef2_1.invokeSuspend(obj);
    }

    public static p10348936.pfd9160bb.pabe3770e MGwQIswDictionaryhbRSbG(p10348936.p2486923a.p10348936.p102fa2c3 p102fa2c3Var) {
        return p10348936.p2486923a.p10348936.p102fa2c3.m74e3994c(p102fa2c3Var);
    }

    public static p10348936.pac143fb7.pd47d680b NESsBGXOQPAefsqb(p10348936.p2486923a.p10348936.p102fa2c3 p102fa2c3Var) {
        return p10348936.p2486923a.p10348936.p102fa2c3.ma0e3f333(p102fa2c3Var);
    }

    public static java.lang.object PeKaKhgRIJexfEHC(p10348936.p2486923a.p10348936.p102fa2c3$p167a3ef2$1 p102fa2c3_p167a3ef2_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return p102fa2c3_p167a3ef2_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static void WmfGOXRHOtvkAmkx(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p10348936.p2486923a.p10348936.p102fa2c3$p167a3ef2$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return peKaKhgRIJexfEHC(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return kTwKuhvIfcKtWjDJ((p10348936.p2486923a.p10348936.p102fa2c3$p167a3ef2$1) CpvVxJvSnIwQVgUb(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((1 + 30) % 30 > 0) {
        }
        java.lang.object objKdCYmDoKJYttWyWA = KdCYmDoKJYttWyWA();
        int i = this.fd304ba20;
        if (i == 0) {
            wmfGOXRHOtvkAmkx(obj);
            p10348936.pac143fb7.pd47d680b pd47d680bVarNESsBGXOQPAefsqb = nESsBGXOQPAefsqb(this.this$0);
            p10348936.pf5e638cc.p14abd389 p14abd389Var = p10348936.pf5e638cc.p14abd389.f66f73e50;
            p10348936.p2486923a.p10348936.p102fa2c3$p167a3ef2$1 p102fa2c3_p167a3ef2_1 = this;
            this.fd304ba20 = 1;
            if (aAkMUrNocjvOtkTn(pd47d680bVarNESsBGXOQPAefsqb, p14abd389Var, p102fa2c3_p167a3ef2_1) == objKdCYmDoKJYttWyWA) {
                return objKdCYmDoKJYttWyWA;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            GtgvpDDOFUDXlVhX(obj);
        }
        cUGcuHqkGlHVWLoL(mGwQIswDictionaryhbRSbG(this.this$0));
        return kotlin.Unit.INSTANCE;
    }
}

