namespace WillowMaze.Wasm.Decompiled;


class SequentialExecutor$1 : java.lang.Action {
    readonly java.lang.Action val$task;

    SequentialExecutor$1(com.google.common.util.concurrent.SequentialExecutor sequentialExecutor, java.lang.Action runnable) {
        this.val$task = runnable;
    }

    public override void Run() {
        this.val$task.run();
    }

    public java.lang.string Tostring() {
        return this.val$task.tostring();
    }
}

