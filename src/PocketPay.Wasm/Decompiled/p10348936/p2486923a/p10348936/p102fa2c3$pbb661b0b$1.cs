namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inventorization.presentation.inventorization.InventorizationobjectModel$clearInventorizations$1", m533f = "InventorizationobjectModel.kt", m534i = {}, m535l = {99}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p102fa2c3$pbb661b0b$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f8f490fbf;
    int fd304ba20;
    int fdd6cd423;
    readonly p10348936.p2486923a.p10348936.p102fa2c3 this$0;

    p102fa2c3$pbb661b0b$1(p10348936.p2486923a.p10348936.p102fa2c3 p102fa2c3Var, kotlin.coroutines.Continuation<? super p10348936.p2486923a.p10348936.p102fa2c3$pbb661b0b$1> continuation) {
        super(2, continuation);
        this.this$0 = p102fa2c3Var;
    }

    public static java.lang.object CaHCTbMWmSSyAGlz(p10348936.pac143fb7.pd47d680b pd47d680bVar, kotlin.coroutines.Continuation continuation) {
        return pd47d680bVar.clearCurrentInventorizations(continuation);
    }

    public static void OlCtUuZATtVRrdSc(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object RhWycWLJWbFlmxvT(p10348936.p2486923a.p10348936.p102fa2c3$pbb661b0b$1 p102fa2c3_pbb661b0b_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return p102fa2c3_pbb661b0b_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static kotlin.coroutines.Continuation ScVhFUhhzWQyfBXg(p10348936.p2486923a.p10348936.p102fa2c3$pbb661b0b$1 p102fa2c3_pbb661b0b_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return p102fa2c3_pbb661b0b_1.create(obj, continuation);
    }

    public static void EFsDLaghGESgpgnh(p10348936.p2486923a.p10348936.p102fa2c3 p102fa2c3Var) {
        p102fa2c3Var.openPreviousScreen();
    }

    public static void JIKOdDtWlRCMEXGu(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object OnXBhiNFBwtZEIUD() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static p10348936.pac143fb7.pd47d680b SZtyxTYUhCXmOMMl(p10348936.p2486923a.p10348936.p102fa2c3 p102fa2c3Var) {
        return p10348936.p2486923a.p10348936.p102fa2c3.ma0e3f333(p102fa2c3Var);
    }

    public static java.lang.object ZyOJUywDqDLiGcYU(p10348936.p2486923a.p10348936.p102fa2c3$pbb661b0b$1 p102fa2c3_pbb661b0b_1, java.lang.object obj) {
        return p102fa2c3_pbb661b0b_1.invokeSuspend(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p10348936.p2486923a.p10348936.p102fa2c3$pbb661b0b$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return RhWycWLJWbFlmxvT(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return zyOJUywDqDLiGcYU((p10348936.p2486923a.p10348936.p102fa2c3$pbb661b0b$1) ScVhFUhhzWQyfBXg(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((29 + 24) % 24 > 0) {
        }
        java.lang.object objOnXBhiNFBwtZEIUD = onXBhiNFBwtZEIUD();
        int i = this.fd304ba20;
        if (i == 0) {
            OlCtUuZATtVRrdSc(obj);
            p10348936.pac143fb7.pd47d680b pd47d680bVarSZtyxTYUhCXmOMMl = sZtyxTYUhCXmOMMl(this.this$0);
            p10348936.p2486923a.p10348936.p102fa2c3$pbb661b0b$1 p102fa2c3_pbb661b0b_1 = this;
            this.fd304ba20 = 1;
            if (CaHCTbMWmSSyAGlz(pd47d680bVarSZtyxTYUhCXmOMMl, p102fa2c3_pbb661b0b_1) == objOnXBhiNFBwtZEIUD) {
                return objOnXBhiNFBwtZEIUD;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            jIKOdDtWlRCMEXGu(obj);
        }
        eFsDLaghGESgpgnh(this.this$0);
        return kotlin.Unit.INSTANCE;
    }
}

