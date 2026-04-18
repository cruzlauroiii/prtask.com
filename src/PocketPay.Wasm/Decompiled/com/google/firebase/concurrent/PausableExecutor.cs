namespace WillowMaze.Wasm.Decompiled;


public interface PausableExecutor : java.util.concurrent.Executor {
    bool isPaused();

    void pause();

    void resume();
}

