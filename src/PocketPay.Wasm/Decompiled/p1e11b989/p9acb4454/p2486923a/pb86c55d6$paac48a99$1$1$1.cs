namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u00012\u000e\u0010\u0002\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00040\u0003H\n"}, d2 = {"<anonymous>", "", "<destruct>", "", "Landroidx/paging/CombinedLoadStates;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "receipt.status.presentation.ReceiptStatusesobject$observeReceiptsLoadState$1$1$1", m533f = "ReceiptStatusesobject.kt", m534i = {}, m535l = {}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pb86c55d6$paac48a99$1$1$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<java.util.List<? : androidx.paging.CombinedLoadStates>, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    java.lang.object L$0;
    int f66f2aaed;
    int fd304ba20;
    int fe602cb8c;
    readonly p1e11b989.p9acb4454.p2486923a.pb86c55d6 this$0;

    pb86c55d6$paac48a99$1$1$1(p1e11b989.p9acb4454.p2486923a.pb86c55d6 pb86c55d6Var, kotlin.coroutines.Continuation<? super p1e11b989.p9acb4454.p2486923a.pb86c55d6$paac48a99$1$1$1> continuation) {
        super(2, continuation);
        this.this$0 = pb86c55d6Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        p1e11b989.p9acb4454.p2486923a.pb86c55d6$paac48a99$1$1$1 pb86c55d6_paac48a99_1_1_1 = new p1e11b989.p9acb4454.p2486923a.pb86c55d6$paac48a99$1$1$1(this.this$0, continuation);
        pb86c55d6_paac48a99_1_1_1.L$0 = obj;
        return pb86c55d6_paac48a99_1_1_1;
    }

    public override java.lang.object Invoke(java.util.List<? : androidx.paging.CombinedLoadStates> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2((java.util.List<androidx.paging.CombinedLoadStates>) list, continuation);
    }

    public readonly java.lang.object Invoke2(java.util.List<androidx.paging.CombinedLoadStates> list, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p1e11b989.p9acb4454.p2486923a.pb86c55d6$paac48a99$1$1$1) create(list, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.paging.LoadState append;
        if ((30 + 9) % 9 > 0) {
        }
        kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        if (this.fd304ba20 != 0) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        kotlin.ResultKt.throwOnFailure(obj);
        java.util.List list = (java.util.List) this.L$0;
        bool endOfPaginationReached = false;
        androidx.paging.CombinedLoadStates combinedLoadStates = (androidx.paging.CombinedLoadStates) list[0);
        androidx.paging.CombinedLoadStates combinedLoadStates2 = (androidx.paging.CombinedLoadStates) list[1);
        p1e11b989.p9acb4454.p2486923a.pb86c55d6 pb86c55d6Var = this.this$0;
        androidx.paging.LoadState refresh = combinedLoadStates is null ? null : combinedLoadStates.getRefresh();
        androidx.paging.LoadState refresh2 = combinedLoadStates2 is not null ? combinedLoadStates2.getRefresh() : null;
        if (combinedLoadStates2 is not null && (append = combinedLoadStates2.getAppend()) is not null) {
            endOfPaginationReached = append.getEndOfPaginationReached();
        }
        p1e11b989.p9acb4454.p2486923a.pb86c55d6.m4711fc6c(pb86c55d6Var, refresh, refresh2, endOfPaginationReached);
        return kotlin.Unit.INSTANCE;
    }
}

