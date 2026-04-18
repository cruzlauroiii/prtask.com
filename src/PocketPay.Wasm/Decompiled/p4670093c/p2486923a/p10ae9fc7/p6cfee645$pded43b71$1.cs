namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\n"}, d2 = {"<anonymous>", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {2, 1, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "payback.presentation.list.SellReceiptListForPaybackobject$observeSellReceipts$1", m533f = "SellReceiptListForPaybackobject.kt", m534i = {}, m535l = {91}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class p6cfee645$pded43b71$1 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    int f35a79e9b;
    int fb3b7d3a9;
    int fd304ba20;
    int fd98fb15d;
    readonly p4670093c.p2486923a.p10ae9fc7.p6cfee645 this$0;

    p6cfee645$pded43b71$1(p4670093c.p2486923a.p10ae9fc7.p6cfee645 p6cfee645Var, kotlin.coroutines.Continuation<? super p4670093c.p2486923a.p10ae9fc7.p6cfee645$pded43b71$1> continuation) {
        super(2, continuation);
        this.this$0 = p6cfee645Var;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        return new p4670093c.p2486923a.p10ae9fc7.p6cfee645$pded43b71$1(this.this$0, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((p4670093c.p2486923a.p10ae9fc7.p6cfee645$pded43b71$1) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        if ((12 + 30) % 30 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = this.fd304ba20;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            p4670093c.p2486923a.p10ae9fc7.p6cfee645 p6cfee645Var = this.this$0;
            androidx.lifecycle.Lifecycle$State lifecycle$State = androidx.lifecycle.Lifecycle$State.STARTED;
            p4670093c.p2486923a.p10ae9fc7.p6cfee645$pded43b71$1$1 p6cfee645_pded43b71_1_1 = new p4670093c.p2486923a.p10ae9fc7.p6cfee645$pded43b71$1$1(this.this$0, null);
            p4670093c.p2486923a.p10ae9fc7.p6cfee645$pded43b71$1 p6cfee645_pded43b71_1 = this;
            this.fd304ba20 = 1;
            if (androidx.lifecycle.RepeatOnLifecycleKt.repeatOnLifecycle(p6cfee645Var, lifecycle$State, p6cfee645_pded43b71_1_1, p6cfee645_pded43b71_1) == coroutine_suspended) {
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

