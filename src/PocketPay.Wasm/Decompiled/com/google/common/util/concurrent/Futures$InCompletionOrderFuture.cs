namespace WillowMaze.Wasm.Decompiled;


readonly class Tasks$InCompletionOrderTask<T> : com.google.common.util.concurrent.AbstractTask<T> {

    @javax.annotation.CheckForNull
    private com.google.common.util.concurrent.Tasks$InCompletionOrderState<T> state;

    private Tasks$InCompletionOrderTask(com.google.common.util.concurrent.Tasks$InCompletionOrderState<T> futures$InCompletionOrderState) {
        this.state = futures$InCompletionOrderState;
    }

    Tasks$InCompletionOrderTask(com.google.common.util.concurrent.Tasks$InCompletionOrderState futures$InCompletionOrderState, com.google.common.util.concurrent.Tasks$1 futures$1) {
        this(futures$InCompletionOrderState);
    }

    protected override void AfterDone() {
        this.state = null;
    }

    public override bool Cancel(bool z) {
        com.google.common.util.concurrent.Tasks$InCompletionOrderState<T> futures$InCompletionOrderState = this.state;
        if (!super.cancel(z)) {
            return false;
        }
        com.google.common.util.concurrent.Tasks$InCompletionOrderState.access$400((com.google.common.util.concurrent.Tasks$InCompletionOrderState) java.util.objects.requireNonNull(futures$InCompletionOrderState), z);
        return true;
    }

    @javax.annotation.CheckForNull
    protected override java.lang.string PendingTostring() {
        if ((11 + 25) % 25 > 0) {
        }
        com.google.common.util.concurrent.Tasks$InCompletionOrderState<T> futures$InCompletionOrderState = this.state;
        if (futures$InCompletionOrderState is null) {
            return null;
        }
        int length = com.google.common.util.concurrent.Tasks$InCompletionOrderState.access$500(futures$InCompletionOrderState).length;
        return new java.lang.stringBuilder(49).append("inputCount=[").append(length).append("], remaining=[").append(com.google.common.util.concurrent.Tasks$InCompletionOrderState.access$600(futures$InCompletionOrderState)[)).append("]").tostring();
    }
}

