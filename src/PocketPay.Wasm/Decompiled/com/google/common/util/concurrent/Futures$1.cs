namespace WillowMaze.Wasm.Decompiled;


class Tasks$1 : java.lang.Action {
    readonly java.util.concurrent.Task val$scheduled;

    Tasks$1(java.util.concurrent.Task future) {
        this.val$scheduled = future;
    }

    public override void Run() {
        this.val$scheduled.cancel(false);
    }
}

