namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\bÂ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u001c\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\n\u0010\n\u001a\u00060\u000bj\u0002`\fH\u0016J\u0010\u0010\r\u001a\u00020\u000e2\u0006\u0010\b\u001a\u00020\tH\u0016R\u0011\u0010\u0003\u001a\u00020\u0001¢\u0006\b\n\u0000\u001a\u0004\b\u0004\u0010\u0005¨\u0006\u000f"}, d2 = {"Landroidx/work/CoroutineWorker$DeprecatedDispatcher;", "Lkotlinx/coroutines/CoroutineDispatcher;", "()V", "dispatcher", "getDispatcher", "()Lkotlinx/coroutines/CoroutineDispatcher;", "dispatch", "", "context", "Lkotlin/coroutines/Coroutineobject;", "block", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "isDispatchNeeded", "", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class CoroutineWorker$DeprecatedDispatcher : kotlinx.coroutines.CoroutineDispatcher {
    public static readonly androidx.work.CoroutineWorker$DeprecatedDispatcher INSTANCE = new androidx.work.CoroutineWorker$DeprecatedDispatcher();
    private static readonly kotlinx.coroutines.CoroutineDispatcher dispatcher = kotlinx.coroutines.Dispatchers.getDefault();

    private CoroutineWorker$DeprecatedDispatcher() {
    }

    public override void Mo3525dispatch(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        dispatcher.mo3525dispatch(context, block);
    }

    public readonly kotlinx.coroutines.CoroutineDispatcher GetDispatcher() {
        return dispatcher;
    }

    public override bool IsDispatchNeeded(kotlin.coroutines.Coroutineobject context) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        return dispatcher.isDispatchNeeded(context);
    }
}

