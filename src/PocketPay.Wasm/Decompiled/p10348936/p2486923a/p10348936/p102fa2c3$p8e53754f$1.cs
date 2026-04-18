namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inventorization.presentation.inventorization.InventorizationobjectModel$removePosition$1", m533f = "InventorizationobjectModel.kt", m534i = {}, m535l = {43}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p102fa2c3$p8e53754f$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly pad5f82e8.p07214c67.p1e11b989.pd031d465 $position;
    int f0b7baaee;
    int fd304ba20;
    int ffe241aef;
    readonly p10348936.p2486923a.p10348936.p102fa2c3 this$0;

    p102fa2c3$p8e53754f$1(p10348936.p2486923a.p10348936.p102fa2c3 p102fa2c3Var, pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation<? super p10348936.p2486923a.p10348936.p102fa2c3$p8e53754f$1> continuation) {
        super(2, continuation);
        this.this$0 = p102fa2c3Var;
        this.$position = pd031d465Var;
    }

    public static java.lang.object AqPBrROKEjFtCYQO(p10348936.p2486923a.p10348936.p102fa2c3$p8e53754f$1 p102fa2c3_p8e53754f_1, java.lang.object obj) {
        return p102fa2c3_p8e53754f_1.invokeSuspend(obj);
    }

    public static void IDSUPnmrQHRPYxxX(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object IfiUkUMUXAdsXRNv(p10348936.pac143fb7.pd47d680b pd47d680bVar, pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation continuation) {
        return pd47d680bVar.removeCurrentInventorizationPosition(pd031d465Var, continuation);
    }

    public static java.lang.object RREYUnuSsPYOQdwZ(p10348936.p2486923a.p10348936.p102fa2c3$p8e53754f$1 p102fa2c3_p8e53754f_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return p102fa2c3_p8e53754f_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static void ViDsbpqqzouqTnak(p10348936.p2486923a.p10348936.p102fa2c3 p102fa2c3Var) {
        p102fa2c3Var.getPositions();
    }

    public static void FrcoGejyiPomeVwC(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static kotlin.coroutines.Continuation VPZXSVRJqKcupeVE(p10348936.p2486923a.p10348936.p102fa2c3$p8e53754f$1 p102fa2c3_p8e53754f_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return p102fa2c3_p8e53754f_1.create(obj, continuation);
    }

    public static p10348936.pac143fb7.pd47d680b YZPLJDvadSBAXCLi(p10348936.p2486923a.p10348936.p102fa2c3 p102fa2c3Var) {
        return p10348936.p2486923a.p10348936.p102fa2c3.ma0e3f333(p102fa2c3Var);
    }

    public static java.lang.object ZnHQLOlMROeXOJdx() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p10348936.p2486923a.p10348936.p102fa2c3$p8e53754f$1(this.this$0, this.$position, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return RREYUnuSsPYOQdwZ(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return AqPBrROKEjFtCYQO((p10348936.p2486923a.p10348936.p102fa2c3$p8e53754f$1) vPZXSVRJqKcupeVE(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((19 + 15) % 15 > 0) {
        }
        java.lang.object objZnHQLOlMROeXOJdx = znHQLOlMROeXOJdx();
        int i = this.fd304ba20;
        if (i == 0) {
            frcoGejyiPomeVwC(obj);
            p10348936.pac143fb7.pd47d680b pd47d680bVarYZPLJDvadSBAXCLi = yZPLJDvadSBAXCLi(this.this$0);
            pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var = this.$position;
            p10348936.p2486923a.p10348936.p102fa2c3$p8e53754f$1 p102fa2c3_p8e53754f_1 = this;
            this.fd304ba20 = 1;
            if (IfiUkUMUXAdsXRNv(pd47d680bVarYZPLJDvadSBAXCLi, pd031d465Var, p102fa2c3_p8e53754f_1) == objZnHQLOlMROeXOJdx) {
                return objZnHQLOlMROeXOJdx;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            IDSUPnmrQHRPYxxX(obj);
        }
        ViDsbpqqzouqTnak(this.this$0);
        return kotlin.Unit.INSTANCE;
    }
}

