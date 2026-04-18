namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0003\n\u0000\b\u0082\u0004\u0018\u00002\u00020\u0001B\u0011\u0012\n\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003¢\u0006\u0002\u0010\u0004J\u0013\u0010\u0005\u001a\u00020\u00062\b\u0010\u0007\u001a\u0004\u0018\u00010\bH\u0096\u0002R\u0012\u0010\u0002\u001a\u0006\u0012\u0002\b\u00030\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Lkotlinx/coroutines/JobSupport$SelectOnAwaitCompletionHandler;", "Lkotlinx/coroutines/JobNode;", "select", "Lkotlinx/coroutines/selects/SelectInstance;", "(Lkotlinx/coroutines/JobSupport;Lkotlinx/coroutines/selects/SelectInstance;)V", "invoke", "", "cause", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class JobSupport$SelectOnAwaitCompletionHandler : kotlinx.coroutines.JobNode {
    private readonly kotlinx.coroutines.selects.SelectInstance<object> select;
    readonly kotlinx.coroutines.JobSupport this$0;

    public JobSupport$SelectOnAwaitCompletionHandler(kotlinx.coroutines.JobSupport jobSupport, kotlinx.coroutines.selects.SelectInstance<object> selectInstance) {
        this.this$0 = jobSupport;
        this.select = selectInstance;
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        invoke2(th);
        return kotlin.Unit.INSTANCE;
    }

    public override void Invoke2(java.lang.Exception cause) {
        java.lang.object state$kotlinx_coroutines_core = this.this$0.getState$kotlinx_coroutines_core();
        if (!(state$kotlinx_coroutines_core is kotlinx.coroutines.CompletedExceptionally)) {
            state$kotlinx_coroutines_core = kotlinx.coroutines.JobSupportKt.unboxState(state$kotlinx_coroutines_core);
        }
        this.select.trySelect(this.this$0, state$kotlinx_coroutines_core);
    }
}

