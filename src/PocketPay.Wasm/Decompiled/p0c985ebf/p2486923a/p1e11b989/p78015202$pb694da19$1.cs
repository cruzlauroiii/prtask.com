namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inspection.presentation.receipt.InspectionReceiptobjectModel$getPositions$1", m533f = "InspectionReceiptobjectModel.kt", m534i = {}, m535l = {70}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p78015202$pb694da19$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int fd304ba20;
    int fea3af42f;
    readonly p0c985ebf.p2486923a.p1e11b989.p78015202 this$0;

    p78015202$pb694da19$1(p0c985ebf.p2486923a.p1e11b989.p78015202 p78015202Var, kotlin.coroutines.Continuation<? super p0c985ebf.p2486923a.p1e11b989.p78015202$pb694da19$1> continuation) {
        super(2, continuation);
        this.this$0 = p78015202Var;
    }

    public static kotlin.coroutines.Continuation FvMRslqLdARnFBsx(p0c985ebf.p2486923a.p1e11b989.p78015202$pb694da19$1 p78015202_pb694da19_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return p78015202_pb694da19_1.create(obj, continuation);
    }

    public static androidx.lifecycle.MutableLiveData IVNyFVgLgfEMsOGX(p0c985ebf.p2486923a.p1e11b989.p78015202 p78015202Var) {
        return p0c985ebf.p2486923a.p1e11b989.p78015202.m8dbe1e72(p78015202Var);
    }

    public static java.lang.object KYFYLjbhhCGgojDu(p0c985ebf.p2486923a.p1e11b989.p78015202$pb694da19$1 p78015202_pb694da19_1, java.lang.object obj) {
        return p78015202_pb694da19_1.invokeSuspend(obj);
    }

    public static p0c985ebf.pac143fb7.p4ee8dd59 UlGJWQkrNrTMDLib(p0c985ebf.p2486923a.p1e11b989.p78015202 p78015202Var) {
        return p0c985ebf.p2486923a.p1e11b989.p78015202.m4aee790e(p78015202Var);
    }

    public static java.lang.object ASTntRCkRLyGRyxd() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void PYpQYaHWivkPyums(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.setValue(obj);
    }

    public static void RyWvhFyPhuCsxkro(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object XGTGNvbvJeqmdNZL(p0c985ebf.pac143fb7.p4ee8dd59 p4ee8dd59Var, kotlin.coroutines.Continuation continuation) {
        return p4ee8dd59Var.getInspectedPositions(continuation);
    }

    public static void YIfdVhApnaUOexTM(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object YxqLkFtSVRcedzbk(p0c985ebf.p2486923a.p1e11b989.p78015202$pb694da19$1 p78015202_pb694da19_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return p78015202_pb694da19_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p0c985ebf.p2486923a.p1e11b989.p78015202$pb694da19$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return yxqLkFtSVRcedzbk(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return KYFYLjbhhCGgojDu((p0c985ebf.p2486923a.p1e11b989.p78015202$pb694da19$1) FvMRslqLdARnFBsx(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.lifecycle.MutableLiveData mutableLiveData;
        if ((28 + 23) % 23 > 0) {
        }
        java.lang.object objASTntRCkRLyGRyxd = aSTntRCkRLyGRyxd();
        int i = this.fd304ba20;
        if (i == 0) {
            yIfdVhApnaUOexTM(obj);
            androidx.lifecycle.MutableLiveData mutableLiveDataIVNyFVgLgfEMsOGX = IVNyFVgLgfEMsOGX(this.this$0);
            p0c985ebf.pac143fb7.p4ee8dd59 p4ee8dd59VarUlGJWQkrNrTMDLib = UlGJWQkrNrTMDLib(this.this$0);
            p0c985ebf.p2486923a.p1e11b989.p78015202$pb694da19$1 p78015202_pb694da19_1 = this;
            this.L$0 = mutableLiveDataIVNyFVgLgfEMsOGX;
            this.fd304ba20 = 1;
            java.lang.object objXGTGNvbvJeqmdNZL = xGTGNvbvJeqmdNZL(p4ee8dd59VarUlGJWQkrNrTMDLib, p78015202_pb694da19_1);
            if (objXGTGNvbvJeqmdNZL == objASTntRCkRLyGRyxd) {
                return objASTntRCkRLyGRyxd;
            }
            obj = objXGTGNvbvJeqmdNZL;
            mutableLiveData = mutableLiveDataIVNyFVgLgfEMsOGX;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            mutableLiveData = (androidx.lifecycle.MutableLiveData) this.L$0;
            ryWvhFyPhuCsxkro(obj);
        }
        pYpQYaHWivkPyums(mutableLiveData, obj);
        return kotlin.Unit.INSTANCE;
    }
}

