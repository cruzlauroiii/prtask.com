namespace WillowMaze.Wasm.Decompiled;


class Tasks$TaskCombiner$1 : java.util.concurrent.Func<java.lang.void> {
    readonly java.lang.Action val$combiner;

    Tasks$TaskCombiner$1(com.google.common.util.concurrent.Tasks$TaskCombiner futures$TaskCombiner, java.lang.Action runnable) {
        this.val$combiner = runnable;
    }

    @javax.annotation.CheckForNull
    public override java.lang.void Call() throws java.lang.Exception {
        return call2();
    }

    @javax.annotation.CheckForNull
    public override java.lang.void Call2() throws java.lang.Exception {
        this.val$combiner.run();
        return null;
    }
}

