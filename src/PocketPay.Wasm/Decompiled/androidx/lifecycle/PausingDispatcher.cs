namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\b\u0000\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0016J\u001c\u0010\n\u001a\u00020\u000b2\u0006\u0010\b\u001a\u00020\t2\n\u0010\f\u001a\u00060\rj\u0002`\u000eH\u0016R\u0010\u0010\u0004\u001a\u00020\u00058\u0000X\u0081\u0004¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Landroidx/lifecycle/PausingDispatcher;", "Lkotlinx/coroutines/CoroutineDispatcher;", "<init>", "()V", "dispatchQueue", "Landroidx/lifecycle/DispatchQueue;", "isDispatchNeeded", "", "context", "Lkotlin/coroutines/Coroutineobject;", "dispatch", "", "block", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "lifecycle-common"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class PausingDispatcher : kotlinx.coroutines.CoroutineDispatcher {
    public readonly androidx.lifecycle.DispatchQueue dispatchQueue = new androidx.lifecycle.DispatchQueue();

    public override void Mo3525dispatch(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        this.dispatchQueue.dispatchAndEnqueue(context, block);
    }

    public override bool IsDispatchNeeded(kotlin.coroutines.Coroutineobject context) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        if (kotlinx.coroutines.Dispatchers.getMain().getImmediate().isDispatchNeeded(context)) {
            return true;
        }
        return !this.dispatchQueue.canRun();
    }
}

