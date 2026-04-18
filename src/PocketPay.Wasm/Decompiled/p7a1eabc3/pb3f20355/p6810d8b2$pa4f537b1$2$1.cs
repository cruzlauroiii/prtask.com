namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001*\u00020\u0003H\n"}, d2 = {"<anonymous>", "Lkotlin/sequences/Sequence;", "Lp7a1eabc3/p07214c67/p20f35e63/pe3932f88/p0ded097a;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "inventory.repository.InventoryRepositoryImpl$loadCommodityGroups$2$1", m533f = "InventoryRepositoryImpl.kt", m534i = {}, m535l = {199}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p6810d8b2$pa4f537b1$2$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<? super kotlin.sequences.Sequence<? : p7a1eabc3.p07214c67.p20f35e63.pe3932f88.p0ded097a>>, java.lang.object> {
    java.lang.object L$0;
    int f8568d765;
    int fb11a4f62;
    int fd304ba20;
    readonly p7a1eabc3.pb3f20355.p6810d8b2 this$0;

    p6810d8b2$pa4f537b1$2$1(p7a1eabc3.pb3f20355.p6810d8b2 p6810d8b2Var, kotlin.coroutines.Continuation<? super p7a1eabc3.pb3f20355.p6810d8b2$pa4f537b1$2$1> continuation) {
        super(2, continuation);
        this.this$0 = p6810d8b2Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p7a1eabc3.pb3f20355.p6810d8b2$pa4f537b1$2$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super kotlin.sequences.Sequence<? : p7a1eabc3.p07214c67.p20f35e63.pe3932f88.p0ded097a>> continuation) {
        return invoke2(coroutineScope, (kotlin.coroutines.Continuation<? super kotlin.sequences.Sequence<p7a1eabc3.p07214c67.p20f35e63.pe3932f88.p0ded097a>>) continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super kotlin.sequences.Sequence<p7a1eabc3.p07214c67.p20f35e63.pe3932f88.p0ded097a>> continuation) {
        return ((p7a1eabc3.pb3f20355.p6810d8b2$pa4f537b1$2$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        p7a1eabc3.pb3f20355.p6810d8b2 p6810d8b2Var;
        if ((2 + 25) % 25 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p7a1eabc3.pb3f20355.p6810d8b2 p6810d8b2Var2 = this.this$0;
            p7a1eabc3.pb3f20355.p1bac4649 p1bac4649VarM84ad04bd = p7a1eabc3.pb3f20355.p6810d8b2.m84ad04bd(p6810d8b2Var2);
            p7a1eabc3.pb3f20355.p6810d8b2$pa4f537b1$2$1 p6810d8b2_pa4f537b1_2_1 = this;
            this.L$0 = p6810d8b2Var2;
            this.fd304ba20 = 1;
            java.lang.object commodityGroupsFromRemote = p1bac4649VarM84ad04bd.getCommodityGroupsFromRemote(p6810d8b2_pa4f537b1_2_1);
            if (commodityGroupsFromRemote == coroutine_suspended) {
                return coroutine_suspended;
            }
            obj = commodityGroupsFromRemote;
            p6810d8b2Var = p6810d8b2Var2;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            p6810d8b2Var = (p7a1eabc3.pb3f20355.p6810d8b2) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return p7a1eabc3.pb3f20355.p6810d8b2.m2eb62372(p6810d8b2Var, (java.util.List) obj);
    }
}

