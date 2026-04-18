namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inventorization.presentation.inventorization.InventorizationobjectModel$getPositions$1", m533f = "InventorizationobjectModel.kt", m534i = {}, m535l = {32}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p102fa2c3$pb694da19$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f2afbf49f;
    int fc5e8792c;
    int fd304ba20;
    readonly p10348936.p2486923a.p10348936.p102fa2c3 this$0;

    p102fa2c3$pb694da19$1(p10348936.p2486923a.p10348936.p102fa2c3 p102fa2c3Var, kotlin.coroutines.Continuation<? super p10348936.p2486923a.p10348936.p102fa2c3$pb694da19$1> continuation) {
        super(2, continuation);
        this.this$0 = p102fa2c3Var;
    }

    public static p10348936.pac143fb7.pd47d680b GpVmuSuZZTuWpaUv(p10348936.p2486923a.p10348936.p102fa2c3 p102fa2c3Var) {
        return p10348936.p2486923a.p10348936.p102fa2c3.ma0e3f333(p102fa2c3Var);
    }

    public static androidx.lifecycle.MutableLiveData NZKBLGRdtPdQEObA(p10348936.p2486923a.p10348936.p102fa2c3 p102fa2c3Var) {
        return p10348936.p2486923a.p10348936.p102fa2c3.m0cb146b5(p102fa2c3Var);
    }

    public static java.lang.object RMwhLxBICVVUCFUG(p10348936.p2486923a.p10348936.p102fa2c3$pb694da19$1 p102fa2c3_pb694da19_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return p102fa2c3_pb694da19_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static java.lang.object RNjRWPaQBnRhBBsU(p10348936.pac143fb7.pd47d680b pd47d680bVar, kotlin.coroutines.Continuation continuation) {
        return pd47d680bVar.getCurrentInventorizationPositions(continuation);
    }

    public static java.lang.object SeoxCHMSTYIhzesX() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static kotlin.coroutines.Continuation VqLjYefDIsbBsYRA(p10348936.p2486923a.p10348936.p102fa2c3$pb694da19$1 p102fa2c3_pb694da19_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return p102fa2c3_pb694da19_1.create(obj, continuation);
    }

    public static void WPECEUvScyRqszxj(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void EafjfAIPHhRoGBCL(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void FqiKdeEfAUCTXXEC(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.setValue(obj);
    }

    public static java.lang.object LnbkBQrFzTlCpdvn(p10348936.p2486923a.p10348936.p102fa2c3$pb694da19$1 p102fa2c3_pb694da19_1, java.lang.object obj) {
        return p102fa2c3_pb694da19_1.invokeSuspend(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p10348936.p2486923a.p10348936.p102fa2c3$pb694da19$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return RMwhLxBICVVUCFUG(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return lnbkBQrFzTlCpdvn((p10348936.p2486923a.p10348936.p102fa2c3$pb694da19$1) VqLjYefDIsbBsYRA(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((22 + 14) % 14 > 0) {
        }
        java.lang.object objSeoxCHMSTYIhzesX = SeoxCHMSTYIhzesX();
        int i = this.fd304ba20;
        if (i == 0) {
            eafjfAIPHhRoGBCL(obj);
            p10348936.pac143fb7.pd47d680b pd47d680bVarGpVmuSuZZTuWpaUv = GpVmuSuZZTuWpaUv(this.this$0);
            p10348936.p2486923a.p10348936.p102fa2c3$pb694da19$1 p102fa2c3_pb694da19_1 = this;
            this.fd304ba20 = 1;
            obj = RNjRWPaQBnRhBBsU(pd47d680bVarGpVmuSuZZTuWpaUv, p102fa2c3_pb694da19_1);
            if (obj == objSeoxCHMSTYIhzesX) {
                return objSeoxCHMSTYIhzesX;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            WPECEUvScyRqszxj(obj);
        }
        fqiKdeEfAUCTXXEC(NZKBLGRdtPdQEObA(this.this$0), (java.util.List) obj);
        return kotlin.Unit.INSTANCE;
    }
}

