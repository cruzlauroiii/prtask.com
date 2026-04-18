namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inspection.presentation.inspection.InspectionobjectModel$updateInspectionPositions$1", m533f = "InspectionobjectModel.kt", m534i = {}, m535l = {29}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p75497c7f$pbe30eed4$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f2d3478c9;
    int fd304ba20;
    readonly p0c985ebf.p2486923a.p0c985ebf.p75497c7f this$0;

    p75497c7f$pbe30eed4$1(p0c985ebf.p2486923a.p0c985ebf.p75497c7f p75497c7fVar, kotlin.coroutines.Continuation<? super p0c985ebf.p2486923a.p0c985ebf.p75497c7f$pbe30eed4$1> continuation) {
        super(2, continuation);
        this.this$0 = p75497c7fVar;
    }

    public static java.lang.object BqavcMWAEsXVtvRb() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object PXVVwZsZgKwIcJQQ(p0c985ebf.p2486923a.p0c985ebf.p75497c7f$pbe30eed4$1 p75497c7f_pbe30eed4_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return p75497c7f_pbe30eed4_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static androidx.lifecycle.MutableLiveData RvapNPcdayXRtyvZ(p0c985ebf.p2486923a.p0c985ebf.p75497c7f p75497c7fVar) {
        return p0c985ebf.p2486923a.p0c985ebf.p75497c7f.m8dbe1e72(p75497c7fVar);
    }

    public static void RyxLmxEaVqtmXvSU(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.setValue(obj);
    }

    public static p0c985ebf.pac143fb7.p4ee8dd59 SGGTeAjskgORUPee(p0c985ebf.p2486923a.p0c985ebf.p75497c7f p75497c7fVar) {
        return p0c985ebf.p2486923a.p0c985ebf.p75497c7f.m4aee790e(p75497c7fVar);
    }

    public static java.lang.object WjRkHAiKvxjSiCuc(p0c985ebf.p2486923a.p0c985ebf.p75497c7f$pbe30eed4$1 p75497c7f_pbe30eed4_1, java.lang.object obj) {
        return p75497c7f_pbe30eed4_1.invokeSuspend(obj);
    }

    public static void DXqNMIwOtfNzZqnO(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static kotlin.coroutines.Continuation HKZyiQORrHiqUWiU(p0c985ebf.p2486923a.p0c985ebf.p75497c7f$pbe30eed4$1 p75497c7f_pbe30eed4_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return p75497c7f_pbe30eed4_1.create(obj, continuation);
    }

    public static void PLYLeVkAeWmNpgig(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object VssppzqBCdeivQMc(p0c985ebf.pac143fb7.p4ee8dd59 p4ee8dd59Var, kotlin.coroutines.Continuation continuation) {
        return p4ee8dd59Var.getInspectedPositions(continuation);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p0c985ebf.p2486923a.p0c985ebf.p75497c7f$pbe30eed4$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return PXVVwZsZgKwIcJQQ(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return WjRkHAiKvxjSiCuc((p0c985ebf.p2486923a.p0c985ebf.p75497c7f$pbe30eed4$1) hKZyiQORrHiqUWiU(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.lifecycle.MutableLiveData mutableLiveData;
        if ((2 + 15) % 15 > 0) {
        }
        java.lang.object objBqavcMWAEsXVtvRb = BqavcMWAEsXVtvRb();
        int i = this.fd304ba20;
        if (i == 0) {
            pLYLeVkAeWmNpgig(obj);
            androidx.lifecycle.MutableLiveData mutableLiveDataRvapNPcdayXRtyvZ = RvapNPcdayXRtyvZ(this.this$0);
            p0c985ebf.pac143fb7.p4ee8dd59 p4ee8dd59VarSGGTeAjskgORUPee = SGGTeAjskgORUPee(this.this$0);
            p0c985ebf.p2486923a.p0c985ebf.p75497c7f$pbe30eed4$1 p75497c7f_pbe30eed4_1 = this;
            this.L$0 = mutableLiveDataRvapNPcdayXRtyvZ;
            this.fd304ba20 = 1;
            java.lang.object objVssppzqBCdeivQMc = vssppzqBCdeivQMc(p4ee8dd59VarSGGTeAjskgORUPee, p75497c7f_pbe30eed4_1);
            if (objVssppzqBCdeivQMc == objBqavcMWAEsXVtvRb) {
                return objBqavcMWAEsXVtvRb;
            }
            obj = objVssppzqBCdeivQMc;
            mutableLiveData = mutableLiveDataRvapNPcdayXRtyvZ;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            mutableLiveData = (androidx.lifecycle.MutableLiveData) this.L$0;
            dXqNMIwOtfNzZqnO(obj);
        }
        RyxLmxEaVqtmXvSU(mutableLiveData, obj);
        return kotlin.Unit.INSTANCE;
    }
}

