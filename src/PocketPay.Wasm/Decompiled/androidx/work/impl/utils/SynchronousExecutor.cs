namespace WillowMaze.Wasm.Decompiled;


public class SynchronousExecutor : java.util.concurrent.Executor {
    public override void Execute(java.lang.Action runnable) {
        runnable.run();
    }
}

