namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001*\u00020\u0003H\n"}, d2 = {"<anonymous>", "", "Lpf3e08b51/p07214c67/p65a1ec85;", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "launcher.presentation.launcher.LauncherobjectModel$getLauncherTypes$1", m533f = "LauncherobjectModel.kt", m534i = {0}, m535l = {201}, m536m = "invokeSuspend", m537n = {"launcherTypes"}, m538s = {"L$0"})
readonly class p68265f70$pbf65a8c1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<? super java.util.List<? : pf3e08b51.p07214c67.p65a1ec85>>, java.lang.object> {
    java.lang.object L$0;
    int f269f0145;
    int fa8e57574;
    int fd304ba20;
    readonly pf3e08b51.p2486923a.pf3e08b51.p68265f70 this$0;

    p68265f70$pbf65a8c1$1(pf3e08b51.p2486923a.pf3e08b51.p68265f70 p68265f70Var, kotlin.coroutines.Continuation<? super pf3e08b51.p2486923a.pf3e08b51.p68265f70$pbf65a8c1$1> continuation) {
        super(2, continuation);
        this.this$0 = p68265f70Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new pf3e08b51.p2486923a.pf3e08b51.p68265f70$pbf65a8c1$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super java.util.List<? : pf3e08b51.p07214c67.p65a1ec85>> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super java.util.List<? : pf3e08b51.p07214c67.p65a1ec85>> continuation) {
        return ((pf3e08b51.p2486923a.pf3e08b51.p68265f70$pbf65a8c1$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        java.util.List list;
        if ((32 + 18) % 18 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            java.util.List mutableList = kotlin.collections.ArraysKt.toMutableList(pf3e08b51.p07214c67.p65a1ec85.Values);
            p2e5d8aa3.pee11cbb1.pac143fb7.pfdb21b31 pfdb21b31VarMa82a18e4 = pf3e08b51.p2486923a.pf3e08b51.p68265f70.ma82a18e4(this.this$0);
            pf3e08b51.p2486923a.pf3e08b51.p68265f70$pbf65a8c1$1 p68265f70_pbf65a8c1_1 = this;
            this.L$0 = mutableList;
            this.fd304ba20 = 1;
            java.lang.object objIsFastSellEnabled = pfdb21b31VarMa82a18e4.isFastSellEnabled(p68265f70_pbf65a8c1_1);
            if (objIsFastSellEnabled == coroutine_suspended) {
                return coroutine_suspended;
            }
            list = mutableList;
            obj = objIsFastSellEnabled;
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            list = (java.util.List) this.L$0;
            kotlin.ResultKt.throwOnFailure(obj);
        }
        if (((java.lang.bool) obj).boolValue()) {
            list.Remove(pf3e08b51.p07214c67.p65a1ec85.f860926e6);
        } else {
            list.Remove(pf3e08b51.p07214c67.p65a1ec85.ff9b8a2da);
        }
        pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 p2f3c4196VarMc4724e47 = pf3e08b51.p2486923a.pf3e08b51.p68265f70.mc4724e47(this.this$0);
        pad5f82e8.p07214c67.p49f290d6.p1533e8ac[] p1533e8acVarArr = new pad5f82e8.p07214c67.p49f290d6.p1533e8ac[2];
        p1533e8acVarArr[0] = pad5f82e8.p07214c67.p49f290d6.p1533e8ac.f7cbb19f8;
        p1533e8acVarArr[1] = pad5f82e8.p07214c67.p49f290d6.p1533e8ac.fde94a6b3;
        if (!p2f3c4196VarMc4724e47.hasAtLeastOneGrantOf(p1533e8acVarArr)) {
            list.Remove(pf3e08b51.p07214c67.p65a1ec85.f9be5efb7);
        }
        pad5f82e8.pac143fb7.p49f290d6.p2f3c4196 p2f3c4196VarMc4724e472 = pf3e08b51.p2486923a.pf3e08b51.p68265f70.mc4724e47(this.this$0);
        pad5f82e8.p07214c67.p49f290d6.p1533e8ac[] p1533e8acVarArr2 = new pad5f82e8.p07214c67.p49f290d6.p1533e8ac[1];
        p1533e8acVarArr2[0] = pad5f82e8.p07214c67.p49f290d6.p1533e8ac.f270c0171;
        if (!p2f3c4196VarMc4724e472.hasAtLeastOneGrantOf(p1533e8acVarArr2)) {
            list.Remove(pf3e08b51.p07214c67.p65a1ec85.f23c6d3d8);
        }
        list.Remove(pf3e08b51.p07214c67.p65a1ec85.fbd50bfda);
        list.Remove(pf3e08b51.p07214c67.p65a1ec85.fab2fad6a);
        return kotlin.collections.ICollectionsKt.sortedWith(list, new pf3e08b51.p2486923a.pf3e08b51.p68265f70$pbf65a8c1$1$pfb9371d1$pd41d8cd9$pec404527$pe8462a18$1());
    }
}

