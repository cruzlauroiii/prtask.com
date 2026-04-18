namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inspection.presentation.inspection.InspectionobjectModel$clearUnfinishedInspection$1", m533f = "InspectionobjectModel.kt", m534i = {}, m535l = {64}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p75497c7f$p6677ee0f$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f85dd60d8;
    int fbf01985f;
    int fd304ba20;
    int fd48c8262;
    readonly p0c985ebf.p2486923a.p0c985ebf.p75497c7f this$0;

    p75497c7f$p6677ee0f$1(p0c985ebf.p2486923a.p0c985ebf.p75497c7f p75497c7fVar, kotlin.coroutines.Continuation<? super p0c985ebf.p2486923a.p0c985ebf.p75497c7f$p6677ee0f$1> continuation) {
        super(2, continuation);
        this.this$0 = p75497c7fVar;
    }

    public static java.lang.object AXadhAsXSboYvrbF(p0c985ebf.p2486923a.p0c985ebf.p75497c7f$p6677ee0f$1 p75497c7f_p6677ee0f_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return p75497c7f_p6677ee0f_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static java.lang.object DgneioQCWcEFEKls(p0c985ebf.p2486923a.p0c985ebf.p75497c7f$p6677ee0f$1 p75497c7f_p6677ee0f_1, java.lang.object obj) {
        return p75497c7f_p6677ee0f_1.invokeSuspend(obj);
    }

    public static java.lang.object JLtRbJQfgmubkovq(p0c985ebf.pac143fb7.p4ee8dd59 p4ee8dd59Var, kotlin.coroutines.Continuation continuation) {
        return p4ee8dd59Var.clearInspectedPositions(continuation);
    }

    public static void QmYjpcqjBxHnguHY(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static p0c985ebf.pac143fb7.p4ee8dd59 YFumaAPxMVOvOWos(p0c985ebf.p2486923a.p0c985ebf.p75497c7f p75497c7fVar) {
        return p0c985ebf.p2486923a.p0c985ebf.p75497c7f.m4aee790e(p75497c7fVar);
    }

    public static kotlin.coroutines.Continuation ZcreVemrhtzSNTqk(p0c985ebf.p2486923a.p0c985ebf.p75497c7f$p6677ee0f$1 p75497c7f_p6677ee0f_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return p75497c7f_p6677ee0f_1.create(obj, continuation);
    }

    public static void KajvGKQrOZThZhcJ(p0c985ebf.p2486923a.p0c985ebf.p75497c7f p75497c7fVar) {
        p75497c7fVar.openPreviousScreen();
    }

    public static void POjRzCvHADLCrAcR(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object VSmaRYXhKFeOUzQD() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p0c985ebf.p2486923a.p0c985ebf.p75497c7f$p6677ee0f$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return AXadhAsXSboYvrbF(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return DgneioQCWcEFEKls((p0c985ebf.p2486923a.p0c985ebf.p75497c7f$p6677ee0f$1) ZcreVemrhtzSNTqk(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((30 + 27) % 27 > 0) {
        }
        java.lang.object objVSmaRYXhKFeOUzQD = vSmaRYXhKFeOUzQD();
        int i = this.fd304ba20;
        if (i == 0) {
            QmYjpcqjBxHnguHY(obj);
            p0c985ebf.pac143fb7.p4ee8dd59 p4ee8dd59VarYFumaAPxMVOvOWos = YFumaAPxMVOvOWos(this.this$0);
            p0c985ebf.p2486923a.p0c985ebf.p75497c7f$p6677ee0f$1 p75497c7f_p6677ee0f_1 = this;
            this.fd304ba20 = 1;
            if (JLtRbJQfgmubkovq(p4ee8dd59VarYFumaAPxMVOvOWos, p75497c7f_p6677ee0f_1) == objVSmaRYXhKFeOUzQD) {
                return objVSmaRYXhKFeOUzQD;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            pOjRzCvHADLCrAcR(obj);
        }
        kajvGKQrOZThZhcJ(this.this$0);
        return kotlin.Unit.INSTANCE;
    }
}

