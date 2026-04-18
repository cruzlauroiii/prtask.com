namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inventorization.presentation.log.InventorizationConsoleobjectModel$createInventorization$1", m533f = "InventorizationConsoleobjectModel.kt", m534i = {}, m535l = {58}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p05bad716$p922ead73$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f0729932c;
    int f56209846;
    int f88de1802;
    int fadaf9753;
    int fd304ba20;
    readonly p10348936.p2486923a.pdc1d71bb.p05bad716 this$0;

    p05bad716$p922ead73$1(p10348936.p2486923a.pdc1d71bb.p05bad716 p05bad716Var, kotlin.coroutines.Continuation<? super p10348936.p2486923a.pdc1d71bb.p05bad716$p922ead73$1> continuation) {
        super(2, continuation);
        this.this$0 = p05bad716Var;
    }

    public static java.lang.object EnwaShKUOAcEvLgq() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static p10348936.pfd9160bb.pabe3770e GrltxFqtoFkYwVqH(p10348936.p2486923a.pdc1d71bb.p05bad716 p05bad716Var) {
        return p10348936.p2486923a.pdc1d71bb.p05bad716.m74e3994c(p05bad716Var);
    }

    public static java.lang.object NEpJEfCywqGpYyYK(p10348936.p2486923a.pdc1d71bb.p05bad716$p922ead73$1 p05bad716_p922ead73_1, java.lang.object obj) {
        return p05bad716_p922ead73_1.invokeSuspend(obj);
    }

    public static void TvuNeRMGaRzrhUoc(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object WseCvnhYkhZMMifP(p10348936.p2486923a.pdc1d71bb.p05bad716$p922ead73$1 p05bad716_p922ead73_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return p05bad716_p922ead73_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static void YflrvKkwxjgjDfIw(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void ZFBdFqKoBkIcyydH(p10348936.pfd9160bb.pabe3770e pabe3770eVar) {
        pabe3770eVar.openInventorization();
    }

    public static kotlin.coroutines.Continuation LWqFbUtaFJllyFTQ(p10348936.p2486923a.pdc1d71bb.p05bad716$p922ead73$1 p05bad716_p922ead73_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return p05bad716_p922ead73_1.create(obj, continuation);
    }

    public static p10348936.pac143fb7.pd47d680b MizVpVoULVRrVOpI(p10348936.p2486923a.pdc1d71bb.p05bad716 p05bad716Var) {
        return p10348936.p2486923a.pdc1d71bb.p05bad716.ma0e3f333(p05bad716Var);
    }

    public static java.lang.object YohSBjZXGXnKKgiU(p10348936.pac143fb7.pd47d680b pd47d680bVar, kotlin.coroutines.Continuation continuation) {
        return pd47d680bVar.createCurrentInventorization(continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p10348936.p2486923a.pdc1d71bb.p05bad716$p922ead73$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return WseCvnhYkhZMMifP(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return NEpJEfCywqGpYyYK((p10348936.p2486923a.pdc1d71bb.p05bad716$p922ead73$1) lWqFbUtaFJllyFTQ(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((3 + 1) % 1 > 0) {
        }
        java.lang.object objEnwaShKUOAcEvLgq = EnwaShKUOAcEvLgq();
        int i = this.fd304ba20;
        if (i == 0) {
            TvuNeRMGaRzrhUoc(obj);
            p10348936.pac143fb7.pd47d680b pd47d680bVarMizVpVoULVRrVOpI = mizVpVoULVRrVOpI(this.this$0);
            p10348936.p2486923a.pdc1d71bb.p05bad716$p922ead73$1 p05bad716_p922ead73_1 = this;
            this.fd304ba20 = 1;
            if (yohSBjZXGXnKKgiU(pd47d680bVarMizVpVoULVRrVOpI, p05bad716_p922ead73_1) == objEnwaShKUOAcEvLgq) {
                return objEnwaShKUOAcEvLgq;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            YflrvKkwxjgjDfIw(obj);
        }
        ZFBdFqKoBkIcyydH(GrltxFqtoFkYwVqH(this.this$0));
        return kotlin.Unit.INSTANCE;
    }
}

