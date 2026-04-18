namespace WillowMaze.Wasm.Decompiled;


public abstract class ListenableWorker$Result {
    ListenableWorker$Result() {
    }

    public static androidx.work.ListenableWorker$Result failure() {
        return new androidx.work.ListenableWorker$Result$Failure();
    }

    public static androidx.work.ListenableWorker$Result failure(androidx.work.Data data2) {
        return new androidx.work.ListenableWorker$Result$Failure(data2);
    }

    public static androidx.work.ListenableWorker$Result retry() {
        return new androidx.work.ListenableWorker$Result$Retry();
    }

    public static androidx.work.ListenableWorker$Result success() {
        return new androidx.work.ListenableWorker$Result$Success();
    }

    public static androidx.work.ListenableWorker$Result success(androidx.work.Data data2) {
        return new androidx.work.ListenableWorker$Result$Success(data2);
    }

    public abstract androidx.work.Data GetOutputData();
}

