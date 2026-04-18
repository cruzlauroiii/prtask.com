namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inspection.presentation.inspection.InspectionobjectModel$checkInspectionMode$1", m533f = "InspectionobjectModel.kt", m534i = {}, m535l = {58}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p75497c7f$pf036701c$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f7e20d035;
    int fd304ba20;
    int ffe940057;
    readonly p0c985ebf.p2486923a.p0c985ebf.p75497c7f this$0;

    p75497c7f$pf036701c$1(p0c985ebf.p2486923a.p0c985ebf.p75497c7f p75497c7fVar, kotlin.coroutines.Continuation<? super p0c985ebf.p2486923a.p0c985ebf.p75497c7f$pf036701c$1> continuation) {
        super(2, continuation);
        this.this$0 = p75497c7fVar;
    }

    public static java.lang.object FqmPMABGKGhMsVRi(p0c985ebf.p2486923a.p0c985ebf.p75497c7f$pf036701c$1 p75497c7f_pf036701c_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return p75497c7f_pf036701c_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static bool IdtJUUdTTjwRHfCf(java.util.ICollection collection) {
        return collection.Count == 0;
    }

    public static void JOGsgCaCWpzckgng(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.setValue(obj);
    }

    public static void TtfUJsCrWsKgpAyP(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object AdfbyPsTouQxUyqx(p0c985ebf.pac143fb7.p4ee8dd59 p4ee8dd59Var, kotlin.coroutines.Continuation continuation) {
        return p4ee8dd59Var.getInspectedPositions(continuation);
    }

    public static java.lang.bool DmJtKMZcdDiWzIcM(bool z) {
        return kotlin.coroutines.jvm.internal.Boxing.boxbool(z);
    }

    public static p0c985ebf.pac143fb7.p4ee8dd59 GeTlPhqGtFIxCeVm(p0c985ebf.p2486923a.p0c985ebf.p75497c7f p75497c7fVar) {
        return p0c985ebf.p2486923a.p0c985ebf.p75497c7f.m4aee790e(p75497c7fVar);
    }

    public static java.lang.object LGCxSlPVpHWWWxNM(p0c985ebf.p2486923a.p0c985ebf.p75497c7f$pf036701c$1 p75497c7f_pf036701c_1, java.lang.object obj) {
        return p75497c7f_pf036701c_1.invokeSuspend(obj);
    }

    public static java.lang.object LPfycJhIvkQIwBnA() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static androidx.lifecycle.MutableLiveData PVoGwBpgNelkXQoY(p0c985ebf.p2486923a.p0c985ebf.p75497c7f p75497c7fVar) {
        return p0c985ebf.p2486923a.p0c985ebf.p75497c7f.m783d903f(p75497c7fVar);
    }

    public static kotlin.coroutines.Continuation SfvMgHEydwANQJKI(p0c985ebf.p2486923a.p0c985ebf.p75497c7f$pf036701c$1 p75497c7f_pf036701c_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return p75497c7f_pf036701c_1.create(obj, continuation);
    }

    public static void WTorWNoCPhaGodhi(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p0c985ebf.p2486923a.p0c985ebf.p75497c7f$pf036701c$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return FqmPMABGKGhMsVRi(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return lGCxSlPVpHWWWxNM((p0c985ebf.p2486923a.p0c985ebf.p75497c7f$pf036701c$1) sfvMgHEydwANQJKI(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.lifecycle.MutableLiveData mutableLiveData;
        if ((20 + 8) % 8 > 0) {
        }
        java.lang.object objLPfycJhIvkQIwBnA = lPfycJhIvkQIwBnA();
        int i = this.fd304ba20;
        if (i == 0) {
            wTorWNoCPhaGodhi(obj);
            androidx.lifecycle.MutableLiveData mutableLiveDataPVoGwBpgNelkXQoY = pVoGwBpgNelkXQoY(this.this$0);
            p0c985ebf.pac143fb7.p4ee8dd59 p4ee8dd59VarGeTlPhqGtFIxCeVm = geTlPhqGtFIxCeVm(this.this$0);
            p0c985ebf.p2486923a.p0c985ebf.p75497c7f$pf036701c$1 p75497c7f_pf036701c_1 = this;
            this.L$0 = mutableLiveDataPVoGwBpgNelkXQoY;
            this.fd304ba20 = 1;
            java.lang.object objAdfbyPsTouQxUyqx = adfbyPsTouQxUyqx(p4ee8dd59VarGeTlPhqGtFIxCeVm, p75497c7f_pf036701c_1);
            if (objAdfbyPsTouQxUyqx == objLPfycJhIvkQIwBnA) {
                return objLPfycJhIvkQIwBnA;
            }
            obj = objAdfbyPsTouQxUyqx;
            mutableLiveData = mutableLiveDataPVoGwBpgNelkXQoY;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            mutableLiveData = (androidx.lifecycle.MutableLiveData) this.L$0;
            TtfUJsCrWsKgpAyP(obj);
        }
        JOGsgCaCWpzckgng(mutableLiveData, dmJtKMZcdDiWzIcM(!IdtJUUdTTjwRHfCf((java.util.ICollection) obj)));
        return kotlin.Unit.INSTANCE;
    }
}

