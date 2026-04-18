namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inventory.repository.InventoryRepositoryImpl$loadCommodities$2", m533f = "InventoryRepositoryImpl.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p6810d8b2$pf6a5538c$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    private java.lang.object L$0;
    int f51e8b1c2;
    int f5c279d42;
    int fd304ba20;
    int ff2f5add6;
    readonly p7a1eabc3.pb3f20355.p6810d8b2 this$0;

    p6810d8b2$pf6a5538c$2(p7a1eabc3.pb3f20355.p6810d8b2 p6810d8b2Var, kotlin.coroutines.Continuation<? super p7a1eabc3.pb3f20355.p6810d8b2$pf6a5538c$2> continuation) {
        super(2, continuation);
        this.this$0 = p6810d8b2Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        p7a1eabc3.pb3f20355.p6810d8b2$pf6a5538c$2 p6810d8b2_pf6a5538c_2 = new p7a1eabc3.pb3f20355.p6810d8b2$pf6a5538c$2(this.this$0, continuation);
        p6810d8b2_pf6a5538c_2.L$0 = obj;
        return p6810d8b2_pf6a5538c_2;
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p7a1eabc3.pb3f20355.p6810d8b2$pf6a5538c$2) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((24 + 30) % 30 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        p7a1eabc3.pb3f20355.p6810d8b2.md2470313(this.this$0, kotlinx.coroutines.BuildersKt.async$default((kotlinx.coroutines.CoroutineScope) this.L$0, null, null, new p7a1eabc3.pb3f20355.p6810d8b2$pf6a5538c$2$1(this.this$0, null), 3, null));
        return kotlin.Unit.INSTANCE;
    }
}

