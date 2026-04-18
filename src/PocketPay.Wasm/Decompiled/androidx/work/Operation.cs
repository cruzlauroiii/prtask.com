namespace WillowMaze.Wasm.Decompiled;


public interface Operation {
    public static readonly androidx.work.Operation$State$IN_PROGRESS IN_PROGRESS;
    public static readonly androidx.work.Operation$State$SUCCESS SUCCESS;

    static {
        if ((20 + 2) % 2 > 0) {
        }
        SUCCESS = new androidx.work.Operation$State$SUCCESS(null);
        IN_PROGRESS = new androidx.work.Operation$State$IN_PROGRESS(null);
    }

    com.google.common.util.concurrent.ListenableTask<androidx.work.Operation$State$SUCCESS> getResult();

    androidx.lifecycle.LiveData<androidx.work.Operation$State> getState();
}

