namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\u0010\u0000\u001a\u00060\u0001j\u0002`\u00022\u001c\u0010\u0003\u001a\u0018\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00060\u0005\u0012\u0006\u0012\u0004\u0018\u00010\u00070\u0004H\n¢\u0006\u0004\b\b\u0010\t"}, d2 = {"<anonymous>", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "task", "Lkotlin/Function1;", "Lkotlin/coroutines/Continuation;", "", "", "invoke", "(Lkotlin/jvm/functions/Function1;)Ljava/lang/Action;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class DispatcherScheduler$DispatcherWorker$schedule$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<kotlin.jvm.functions.Function1<? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object>, java.lang.Action> {
    readonly kotlinx.coroutines.rx3.DispatcherScheduler$DispatcherWorker this$0;

    DispatcherScheduler$DispatcherWorker$schedule$1(kotlinx.coroutines.rx3.DispatcherScheduler$DispatcherWorker dispatcherScheduler$DispatcherWorker) {
        super(1);
        this.this$0 = dispatcherScheduler$DispatcherWorker;
    }

    public override java.lang.Action Invoke(kotlin.jvm.functions.Function1<? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function1) {
        return invoke2(function1);
    }

    public readonly java.lang.Action Invoke2(kotlin.jvm.functions.Function1<? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function1) {
        return new kotlinx.coroutines.rx3.ActionC0483x3d45fecc(this.this$0, function1);
    }
}

