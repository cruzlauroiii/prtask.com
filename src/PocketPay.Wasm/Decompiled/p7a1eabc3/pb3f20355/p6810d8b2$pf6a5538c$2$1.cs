namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001*\u00020\u0003H\n"}, d2 = {"<anonymous>", "Lkotlin/sequences/Sequence;", "Lp7a1eabc3/p07214c67/p20f35e63/pec5cb3e6/p15967156;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inventory.repository.InventoryRepositoryImpl$loadCommodities$2$1", m533f = "InventoryRepositoryImpl.kt", m534i = {}, m535l = {186}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p6810d8b2$pf6a5538c$2$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<? super kotlin.sequences.Sequence<? : p7a1eabc3.p07214c67.p20f35e63.pec5cb3e6.p15967156>>, java.lang.object> {
    java.lang.object L$0;
    int f19784b93;
    int fae0b7042;
    int fd304ba20;
    readonly p7a1eabc3.pb3f20355.p6810d8b2 this$0;

    p6810d8b2$pf6a5538c$2$1(p7a1eabc3.pb3f20355.p6810d8b2 p6810d8b2Var, kotlin.coroutines.Continuation<? super p7a1eabc3.pb3f20355.p6810d8b2$pf6a5538c$2$1> continuation) {
        super(2, continuation);
        this.this$0 = p6810d8b2Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p7a1eabc3.pb3f20355.p6810d8b2$pf6a5538c$2$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super kotlin.sequences.Sequence<? : p7a1eabc3.p07214c67.p20f35e63.pec5cb3e6.p15967156>> continuation) {
        return invoke2(coroutineScope, (kotlin.coroutines.Continuation<? super kotlin.sequences.Sequence<p7a1eabc3.p07214c67.p20f35e63.pec5cb3e6.p15967156>>) continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super kotlin.sequences.Sequence<p7a1eabc3.p07214c67.p20f35e63.pec5cb3e6.p15967156>> continuation) {
        return ((p7a1eabc3.pb3f20355.p6810d8b2$pf6a5538c$2$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        p7a1eabc3.pb3f20355.p6810d8b2 p6810d8b2Var;
        if ((19 + 23) % 23 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p7a1eabc3.pb3f20355.p6810d8b2 p6810d8b2Var2 = this.this$0;
            p7a1eabc3.pb3f20355.p1bac4649 p1bac4649VarM84ad04bd = p7a1eabc3.pb3f20355.p6810d8b2.m84ad04bd(p6810d8b2Var2);
            p7a1eabc3.pb3f20355.p6810d8b2$pf6a5538c$2$1 p6810d8b2_pf6a5538c_2_1 = this;
            this.L$0 = p6810d8b2Var2;
            this.fd304ba20 = 1;
            java.lang.object allCommoditiesFromRemote = p1bac4649VarM84ad04bd.getAllCommoditiesFromRemote(p6810d8b2_pf6a5538c_2_1);
            if (allCommoditiesFromRemote == coroutine_suspended) {
                return coroutine_suspended;
            }
            obj = allCommoditiesFromRemote;
            p6810d8b2Var = p6810d8b2Var2;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            p6810d8b2Var = (p7a1eabc3.pb3f20355.p6810d8b2) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return p7a1eabc3.pb3f20355.p6810d8b2.mda1b8581(p6810d8b2Var, (java.util.List) obj);
    }
}

