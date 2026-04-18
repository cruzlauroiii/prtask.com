namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u00012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003H\n"}, d2 = {"<anonymous>", "", "sellReceipts", "Landroidx/paging/PagingData;", "Lpad5f82e8/p07214c67/p1e11b989/p55f8d305;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "receipt.status.presentation.ReceiptStatusesobject$observeReceipts$1$1$1", m533f = "ReceiptStatusesobject.kt", m534i = {}, m535l = {87}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pb86c55d6$pf0bb1693$1$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<androidx.paging.PagingData<pad5f82e8.p07214c67.p1e11b989.p55f8d305>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f43129435;
    int f4babc1d3;
    int f8ee3685f;
    int fd304ba20;
    int fe2da8a58;
    readonly p1e11b989.p9acb4454.p2486923a.pb86c55d6 this$0;

    pb86c55d6$pf0bb1693$1$1$1(p1e11b989.p9acb4454.p2486923a.pb86c55d6 pb86c55d6Var, kotlin.coroutines.Continuation<? super p1e11b989.p9acb4454.p2486923a.pb86c55d6$pf0bb1693$1$1$1> continuation) {
        super(2, continuation);
        this.this$0 = pb86c55d6Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        p1e11b989.p9acb4454.p2486923a.pb86c55d6$pf0bb1693$1$1$1 pb86c55d6_pf0bb1693_1_1_1 = new p1e11b989.p9acb4454.p2486923a.pb86c55d6$pf0bb1693$1$1$1(this.this$0, continuation);
        pb86c55d6_pf0bb1693_1_1_1.L$0 = obj;
        return pb86c55d6_pf0bb1693_1_1_1;
    }

    public readonly java.lang.object Invoke2(androidx.paging.PagingData<pad5f82e8.p07214c67.p1e11b989.p55f8d305> pagingData, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p1e11b989.p9acb4454.p2486923a.pb86c55d6$pf0bb1693$1$1$1) create(pagingData, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override java.lang.object Invoke(androidx.paging.PagingData<pad5f82e8.p07214c67.p1e11b989.p55f8d305> pagingData, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(pagingData, continuation);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((22 + 28) % 28 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            androidx.paging.PagingData pagingData = (androidx.paging.PagingData) this.L$0;
            p1e11b989.p9acb4454.p2486923a.pb86c55d6.mc8beb2c6(this.this$0).setCurrency(p1e11b989.p9acb4454.p2486923a.pb86c55d6.m21fe4019(this.this$0));
            p1e11b989.p9acb4454.p2486923a.p8a7a38cf.p025c44a5 p025c44a5VarMc8beb2c6 = p1e11b989.p9acb4454.p2486923a.pb86c55d6.mc8beb2c6(this.this$0);
            p1e11b989.p9acb4454.p2486923a.pb86c55d6$pf0bb1693$1$1$1 pb86c55d6_pf0bb1693_1_1_1 = this;
            this.fd304ba20 = 1;
            if (p025c44a5VarMc8beb2c6.submitData(pagingData, pb86c55d6_pf0bb1693_1_1_1) == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            kotlin.ResultKt.throwOnFailure(obj);
        }
        return kotlin.Unit.INSTANCE;
    }
}

