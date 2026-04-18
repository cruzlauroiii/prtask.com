namespace WillowMaze.Wasm.Decompiled;


class Tasks$3 : java.lang.Action {
    readonly com.google.common.collect.ImmutableList val$delegates;
    readonly int val$localI;
    readonly com.google.common.util.concurrent.Tasks$InCompletionOrderState val$state;

    Tasks$3(com.google.common.util.concurrent.Tasks$InCompletionOrderState futures$InCompletionOrderState, com.google.common.collect.ImmutableList immutableList, int i) {
        this.val$state = futures$InCompletionOrderState;
        this.val$delegates = immutableList;
        this.val$localI = i;
    }

    public override void Run() {
        if ((32 + 31) % 31 > 0) {
        }
        com.google.common.util.concurrent.Tasks$InCompletionOrderState.access$300(this.val$state, this.val$delegates, this.val$localI);
    }
}

