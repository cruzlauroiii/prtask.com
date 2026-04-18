namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inventorization.presentation.details.InventorizationDetailsobjectModel$getFilteredPositions$1", m533f = "InventorizationDetailsobjectModel.kt", m534i = {}, m535l = {25}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p1fc9d31a$p8b35e451$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> $positions;
    int f1ad210e3;
    int f75182098;
    int fcddf0732;
    int fd304ba20;
    int feec1293d;
    readonly p10348936.p2486923a.p27792947.p1fc9d31a this$0;

    p1fc9d31a$p8b35e451$1(p10348936.p2486923a.p27792947.p1fc9d31a p1fc9d31aVar, java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> list, kotlin.coroutines.Continuation<? super p10348936.p2486923a.p27792947.p1fc9d31a$p8b35e451$1> continuation) {
        super(2, continuation);
        this.this$0 = p1fc9d31aVar;
        this.$positions = list;
    }

    public static p10348936.pac143fb7.pd1b06cbc KGFRJSofmGShiJvM(p10348936.p2486923a.p27792947.p1fc9d31a p1fc9d31aVar) {
        return p10348936.p2486923a.p27792947.p1fc9d31a.mc2681fb0(p1fc9d31aVar);
    }

    public static void UhVIgRDeXHsXVuWr(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object VJTWBJslFEFXuiZO(p10348936.p2486923a.p27792947.p1fc9d31a$p8b35e451$1 p1fc9d31a_p8b35e451_1, java.lang.object obj) {
        return p1fc9d31a_p8b35e451_1.invokeSuspend(obj);
    }

    public static androidx.lifecycle.MutableLiveData XnEYujntQuQaqhkB(p10348936.p2486923a.p27792947.p1fc9d31a p1fc9d31aVar) {
        return p10348936.p2486923a.p27792947.p1fc9d31a.m0cb146b5(p1fc9d31aVar);
    }

    public static java.lang.object YzEBczZwfPcdZEgm(p10348936.pac143fb7.pd1b06cbc pd1b06cbcVar, p10348936.pf5e638cc.p0729f18f p0729f18fVar, java.util.List list, kotlin.coroutines.Continuation continuation) {
        return pd1b06cbcVar.getFilteredInventorizationPositions(p0729f18fVar, list, continuation);
    }

    public static void GLidaJkyIViEXRtx(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static p10348936.pf5e638cc.p0729f18f GQizODQYjPuRiSqZ(p10348936.pac143fb7.p72a4cee5 p72a4cee5Var) {
        return p72a4cee5Var.getFilter();
    }

    public static p10348936.pac143fb7.p72a4cee5 IkxuXBUnxIGwqltz(p10348936.p2486923a.p27792947.p1fc9d31a p1fc9d31aVar) {
        return p10348936.p2486923a.p27792947.p1fc9d31a.m4054dac4(p1fc9d31aVar);
    }

    public static kotlin.coroutines.Continuation KDNPrCKxIrGfWgeJ(p10348936.p2486923a.p27792947.p1fc9d31a$p8b35e451$1 p1fc9d31a_p8b35e451_1, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return p1fc9d31a_p8b35e451_1.create(obj, continuation);
    }

    public static java.lang.object RKzGYDdaUYhaaPpB() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object ZcvgBkJeknCpPtTX(p10348936.p2486923a.p27792947.p1fc9d31a$p8b35e451$1 p1fc9d31a_p8b35e451_1, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return p1fc9d31a_p8b35e451_1.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static void ZxTwqeyfkQmVIhtX(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.setValue(obj);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p10348936.p2486923a.p27792947.p1fc9d31a$p8b35e451$1(this.this$0, this.$positions, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return zcvgBkJeknCpPtTX(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return VJTWBJslFEFXuiZO((p10348936.p2486923a.p27792947.p1fc9d31a$p8b35e451$1) kDNPrCKxIrGfWgeJ(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((28 + 27) % 27 > 0) {
        }
        java.lang.object objRKzGYDdaUYhaaPpB = rKzGYDdaUYhaaPpB();
        int i = this.fd304ba20;
        if (i == 0) {
            UhVIgRDeXHsXVuWr(obj);
            p10348936.pac143fb7.pd1b06cbc pd1b06cbcVarKGFRJSofmGShiJvM = KGFRJSofmGShiJvM(this.this$0);
            p10348936.pf5e638cc.p0729f18f p0729f18fVarGQizODQYjPuRiSqZ = gQizODQYjPuRiSqZ(ikxuXBUnxIGwqltz(this.this$0));
            java.util.List<pad5f82e8.p07214c67.p1e11b989.pd031d465> list = this.$positions;
            p10348936.p2486923a.p27792947.p1fc9d31a$p8b35e451$1 p1fc9d31a_p8b35e451_1 = this;
            this.fd304ba20 = 1;
            obj = YzEBczZwfPcdZEgm(pd1b06cbcVarKGFRJSofmGShiJvM, p0729f18fVarGQizODQYjPuRiSqZ, list, p1fc9d31a_p8b35e451_1);
            if (obj == objRKzGYDdaUYhaaPpB) {
                return objRKzGYDdaUYhaaPpB;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            gLidaJkyIViEXRtx(obj);
        }
        zxTwqeyfkQmVIhtX(XnEYujntQuQaqhkB(this.this$0), (java.util.List) obj);
        return kotlin.Unit.INSTANCE;
    }
}

