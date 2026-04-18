namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\u00020\u0003H\u008a@"}, d2 = {"<anonymous>", "", "T", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.datastore.core.SimpleActor$offer$2", m533f = "SimpleActor.kt", m534i = {}, m535l = {121, 121}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class SimpleActor$offer$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int label;
    readonly androidx.datastore.core.SimpleActor<T> this$0;

    SimpleActor$offer$2(androidx.datastore.core.SimpleActor<T> simpleActor, kotlin.coroutines.Continuation<? super androidx.datastore.core.SimpleActor$offer$2> continuation) {
        super(2, continuation);
        this.this$0 = simpleActor;
    }

    public static kotlinx.coroutines.CoroutineScope ATiyRSRAvbVYhEym(androidx.datastore.core.SimpleActor simpleActor) {
        return androidx.datastore.core.SimpleActor.access$getScope$p(simpleActor);
    }

    public static androidx.datastore.core.AtomicInt BZDzfhjZJdJbQfaI(androidx.datastore.core.SimpleActor simpleActor) {
        return androidx.datastore.core.SimpleActor.access$getRemainingMessages$p(simpleActor);
    }

    public static int CLJcmSXQYJTYxSAZ(androidx.datastore.core.AtomicInt atomicInt) {
        return atomicInt[);
    }

    public static void DALINOXuyDMdbYRo(kotlinx.coroutines.CoroutineScope coroutineScope) {
        kotlinx.coroutines.CoroutineScopeKt.ensureActive(coroutineScope);
    }

    public static java.lang.string DnMCcIKcNmFivDay(java.lang.object obj) {
        return obj.tostring();
    }

    public static int JUPHBWBgvQBhJSxK(androidx.datastore.core.AtomicInt atomicInt) {
        return atomicInt.decrementAndGet();
    }

    public static void LFqJPiNzLnMpJhvH(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static kotlinx.coroutines.channels.Channel OUhWufSVJtcZckhA(androidx.datastore.core.SimpleActor simpleActor) {
        return androidx.datastore.core.SimpleActor.access$getMessageQueue$p(simpleActor);
    }

    public static void PlISoiGwtKoRLyYd(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static kotlin.coroutines.Continuation SbiwPzeEcpzKOcti(androidx.datastore.core.SimpleActor$offer$2 simpleActor$offer$2, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return simpleActor$offer$2.create(obj, continuation);
    }

    public static java.lang.object YpdUakblDtIygxAi() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object AGSdAkaxhxpmlAkE(kotlinx.coroutines.channels.Channel channel, kotlin.coroutines.Continuation continuation) {
        return channel.receive(continuation);
    }

    public static kotlin.jvm.functions.Function2 BSvPQUxWrtRQRVze(androidx.datastore.core.SimpleActor simpleActor) {
        return androidx.datastore.core.SimpleActor.access$getConsumeMessage$p(simpleActor);
    }

    public static void DnfWOOoyCUhwpHWU(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object ETdNCMYpooSbWgcm(androidx.datastore.core.SimpleActor$offer$2 simpleActor$offer$2, java.lang.object obj) {
        return simpleActor$offer$2.invokeSuspend(obj);
    }

    public static java.lang.object NkcOecnRvorRzOVL(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2) {
        return function2.invoke(obj, obj2);
    }

    public static java.lang.object NnhRIHbdEVUYiBFA(androidx.datastore.core.SimpleActor$offer$2 simpleActor$offer$2, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation continuation) {
        return simpleActor$offer$2.invoke2(coroutineScope, (kotlin.coroutines.Continuation<kotlin.Unit>) continuation);
    }

    public static androidx.datastore.core.AtomicInt ZZXgzssaAOecljXr(androidx.datastore.core.SimpleActor simpleActor) {
        return androidx.datastore.core.SimpleActor.access$getRemainingMessages$p(simpleActor);
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new androidx.datastore.core.SimpleActor$offer$2(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return nnhRIHbdEVUYiBFA(this, coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return eTdNCMYpooSbWgcm((androidx.datastore.core.SimpleActor$offer$2) SbiwPzeEcpzKOcti(this, coroutineScope, continuation), kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.jvm.functions.Function2 function2BSvPQUxWrtRQRVze;
        if ((2 + 19) % 19 > 0) {
        }
        java.lang.object objYpdUakblDtIygxAi = YpdUakblDtIygxAi();
        int i = this.label;
        if (i == 0) {
            PlISoiGwtKoRLyYd(obj);
            if (CLJcmSXQYJTYxSAZ(BZDzfhjZJdJbQfaI(this.this$0)) <= 0) {
                throw new java.lang.IllegalStateException(DnMCcIKcNmFivDay("Check failed."));
            }
            DALINOXuyDMdbYRo(ATiyRSRAvbVYhEym(this.this$0));
            function2BSvPQUxWrtRQRVze = bSvPQUxWrtRQRVze(this.this$0);
            kotlinx.coroutines.channels.Channel channelOUhWufSVJtcZckhA = OUhWufSVJtcZckhA(this.this$0);
            androidx.datastore.core.SimpleActor$offer$2 simpleActor$offer$2 = this;
            this.L$0 = function2BSvPQUxWrtRQRVze;
            this.label = 1;
            obj = aGSdAkaxhxpmlAkE(channelOUhWufSVJtcZckhA, simpleActor$offer$2);
            if (obj != objYpdUakblDtIygxAi) {
            }
            return objYpdUakblDtIygxAi;
        }
        if (i != 1) {
            if (i != 2) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            dnfWOOoyCUhwpHWU(obj);
            if (JUPHBWBgvQBhJSxK(zZXgzssaAOecljXr(this.this$0)) == 0) {
                return kotlin.Unit.INSTANCE;
            }
            DALINOXuyDMdbYRo(ATiyRSRAvbVYhEym(this.this$0));
            function2BSvPQUxWrtRQRVze = bSvPQUxWrtRQRVze(this.this$0);
            kotlinx.coroutines.channels.Channel channelOUhWufSVJtcZckhA2 = OUhWufSVJtcZckhA(this.this$0);
            androidx.datastore.core.SimpleActor$offer$2 simpleActor$offer$22 = this;
            this.L$0 = function2BSvPQUxWrtRQRVze;
            this.label = 1;
            obj = aGSdAkaxhxpmlAkE(channelOUhWufSVJtcZckhA2, simpleActor$offer$22);
            if (obj != objYpdUakblDtIygxAi) {
            }
            return objYpdUakblDtIygxAi;
        }
        function2BSvPQUxWrtRQRVze = (kotlin.jvm.functions.Function2) this.L$0;
        LFqJPiNzLnMpJhvH(obj);
        this.L$0 = null;
        this.label = 2;
    }
}

