namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inspection.presentation.inspection.InspectionobjectModel$removePosition$1", m533f = "InspectionobjectModel.kt", m534i = {}, m535l = {39}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p75497c7f$p8e53754f$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly pad5f82e8.p07214c67.p1e11b989.pd031d465 $position;
    int f7a3687d4;
    int fa37eaf81;
    int fbb97152d;
    int fd304ba20;
    int fe7b1bf51;
    readonly p0c985ebf.p2486923a.p0c985ebf.p75497c7f this$0;

    p75497c7f$p8e53754f$1(p0c985ebf.p2486923a.p0c985ebf.p75497c7f p75497c7fVar, pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation<? super p0c985ebf.p2486923a.p0c985ebf.p75497c7f$p8e53754f$1> continuation) {
        super(2, continuation);
        this.this$0 = p75497c7fVar;
        this.$position = pd031d465Var;
    }

    public static void EVTtIRwGCtSgLKVk(p0c985ebf.p2486923a.p0c985ebf.p75497c7f p75497c7fVar) {
        p75497c7fVar.updateInspectionPositions();
    }

    public static java.lang.object GGcFwfKKrOnEOama(p0c985ebf.pac143fb7.p4ee8dd59 p4ee8dd59Var, pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var, kotlin.coroutines.Continuation continuation) {
        return p4ee8dd59Var.removeInspectedPosition(pd031d465Var, continuation);
    }

    public static java.lang.object HXDaVSlXedEfhbLb() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void IzBPuKTovsruHKab(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object RgYEAiskTYHvrxcC(p0c985ebf.p2486923a.p0c985ebf.p75497c7f$p8e53754f$1 p75497c7f_p8e53754f_1, java.lang.object obj) {
        return p75497c7f_p8e53754f_1.invokeSuspend(obj);
    }

    public static java.lang.object YCxDRxcRsXLgeYHh(p0c985ebf.p2486923a.p0c985ebf.p75497c7f$p8e53754f$1 p75497c7f_p8e53754f_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return p75497c7f_p8e53754f_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static p0c985ebf.pac143fb7.p4ee8dd59 IcbKlvxnCiQHFEBw(p0c985ebf.p2486923a.p0c985ebf.p75497c7f p75497c7fVar) {
        return p0c985ebf.p2486923a.p0c985ebf.p75497c7f.m4aee790e(p75497c7fVar);
    }

    public static kotlin.coroutines.Continuation XgXKBrCTJiLNnitd(p0c985ebf.p2486923a.p0c985ebf.p75497c7f$p8e53754f$1 p75497c7f_p8e53754f_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return p75497c7f_p8e53754f_1.create(obj, continuation);
    }

    public static void ZVTFOVVhMjBYjNlq(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p0c985ebf.p2486923a.p0c985ebf.p75497c7f$p8e53754f$1(this.this$0, this.$position, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return YCxDRxcRsXLgeYHh(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return RgYEAiskTYHvrxcC((p0c985ebf.p2486923a.p0c985ebf.p75497c7f$p8e53754f$1) xgXKBrCTJiLNnitd(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((32 + 18) % 18 > 0) {
        }
        java.lang.object objHXDaVSlXedEfhbLb = HXDaVSlXedEfhbLb();
        int i = this.fd304ba20;
        if (i == 0) {
            zVTFOVVhMjBYjNlq(obj);
            p0c985ebf.pac143fb7.p4ee8dd59 p4ee8dd59VarIcbKlvxnCiQHFEBw = icbKlvxnCiQHFEBw(this.this$0);
            pad5f82e8.p07214c67.p1e11b989.pd031d465 pd031d465Var = this.$position;
            p0c985ebf.p2486923a.p0c985ebf.p75497c7f$p8e53754f$1 p75497c7f_p8e53754f_1 = this;
            this.fd304ba20 = 1;
            if (GGcFwfKKrOnEOama(p4ee8dd59VarIcbKlvxnCiQHFEBw, pd031d465Var, p75497c7f_p8e53754f_1) == objHXDaVSlXedEfhbLb) {
                return objHXDaVSlXedEfhbLb;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            IzBPuKTovsruHKab(obj);
        }
        EVTtIRwGCtSgLKVk(this.this$0);
        return kotlin.Unit.INSTANCE;
    }
}

