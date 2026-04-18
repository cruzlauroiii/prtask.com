namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\f\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0003H\n"}, d2 = {"<anonymous>", "", "loadState", "Landroidx/paging/LoadState;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "payback.presentation.list.SellReceiptListForPaybackobject$observeSellReceiptsLoadState$1$1$2", m533f = "SellReceiptListForPaybackobject.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p6cfee645$p839de228$1$1$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.paging.LoadState, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f0eac8f9d;
    int fd304ba20;
    readonly p4670093c.p2486923a.p10ae9fc7.p6cfee645 this$0;

    p6cfee645$p839de228$1$1$2(p4670093c.p2486923a.p10ae9fc7.p6cfee645 p6cfee645Var, kotlin.coroutines.Continuation<? super p4670093c.p2486923a.p10ae9fc7.p6cfee645$p839de228$1$1$2> continuation) {
        super(2, continuation);
        this.this$0 = p6cfee645Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        p4670093c.p2486923a.p10ae9fc7.p6cfee645$p839de228$1$1$2 p6cfee645_p839de228_1_1_2 = new p4670093c.p2486923a.p10ae9fc7.p6cfee645$p839de228$1$1$2(this.this$0, continuation);
        p6cfee645_p839de228_1_1_2.L$0 = obj;
        return p6cfee645_p839de228_1_1_2;
    }

    public readonly java.lang.object Invoke2(androidx.paging.LoadState loadState, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p4670093c.p2486923a.p10ae9fc7.p6cfee645$p839de228$1$1$2) create(loadState, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(androidx.paging.LoadState loadState, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(loadState, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        androidx.paging.LoadState loadState = (androidx.paging.LoadState) this.L$0;
        if ((loadState is androidx.paging.LoadState$Error) && (((androidx.paging.LoadState$Error) loadState).getError() instanceof p2b3583e6.p19ad2780.p1e021f83)) {
            p4670093c.p2486923a.p10ae9fc7.p6cfee645.m3cf59762(this.this$0).fa649495b.setVisibility(0);
        }
        return kotlin.Unit.INSTANCE;
    }
}

