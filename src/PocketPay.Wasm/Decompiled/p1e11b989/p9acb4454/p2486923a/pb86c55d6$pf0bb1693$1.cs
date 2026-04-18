namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "receipt.status.presentation.ReceiptStatusesobject$observeReceipts$1", m533f = "ReceiptStatusesobject.kt", m534i = {}, m535l = {84}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class pb86c55d6$pf0bb1693$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f874fcd83;
    int fd304ba20;
    int ff8190072;
    readonly p1e11b989.p9acb4454.p2486923a.pb86c55d6 this$0;

    pb86c55d6$pf0bb1693$1(p1e11b989.p9acb4454.p2486923a.pb86c55d6 pb86c55d6Var, kotlin.coroutines.Continuation<? super p1e11b989.p9acb4454.p2486923a.pb86c55d6$pf0bb1693$1> continuation) {
        super(2, continuation);
        this.this$0 = pb86c55d6Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p1e11b989.p9acb4454.p2486923a.pb86c55d6$pf0bb1693$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p1e11b989.p9acb4454.p2486923a.pb86c55d6$pf0bb1693$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((21 + 19) % 19 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p1e11b989.p9acb4454.p2486923a.pb86c55d6 pb86c55d6Var = this.this$0;
            androidx.lifecycle.Lifecycle$State lifecycle$State = androidx.lifecycle.Lifecycle$State.STARTED;
            p1e11b989.p9acb4454.p2486923a.pb86c55d6$pf0bb1693$1$1 pb86c55d6_pf0bb1693_1_1 = new p1e11b989.p9acb4454.p2486923a.pb86c55d6$pf0bb1693$1$1(this.this$0, null);
            p1e11b989.p9acb4454.p2486923a.pb86c55d6$pf0bb1693$1 pb86c55d6_pf0bb1693_1 = this;
            this.fd304ba20 = 1;
            if (androidx.lifecycle.RepeatOnLifecycleKt.repeatOnLifecycle(pb86c55d6Var, lifecycle$State, pb86c55d6_pf0bb1693_1_1, pb86c55d6_pf0bb1693_1) == coroutine_suspended) {
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

