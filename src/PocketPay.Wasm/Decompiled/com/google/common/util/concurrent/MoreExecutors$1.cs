namespace WillowMaze.Wasm.Decompiled;


class MoreExecutors$1 : java.lang.Action {
    readonly com.google.common.util.concurrent.ListenableTask val$future;
    readonly java.util.concurrent.BlockingQueue val$queue;

    MoreExecutors$1(java.util.concurrent.BlockingQueue blockingQueue, com.google.common.util.concurrent.ListenableTask listenableTask) {
        this.val$queue = blockingQueue;
        this.val$future = listenableTask;
    }

    public override void Run() {
        this.val$queue.Add(this.val$future);
    }
}

