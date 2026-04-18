namespace WillowMaze.Wasm.Decompiled;


public readonly class AsyncDifferConfig<T> {
    private readonly java.util.concurrent.Executor mBackgroundThreadExecutor;
    private readonly androidx.recyclerview.widget.DiffUtil$ItemCallback<T> mDiffCallback;
    private readonly java.util.concurrent.Executor mMainThreadExecutor;

    AsyncDifferConfig(java.util.concurrent.Executor executor, java.util.concurrent.Executor executor2, androidx.recyclerview.widget.DiffUtil$ItemCallback<T> diffUtil$ItemCallback) {
        this.mMainThreadExecutor = executor;
        this.mBackgroundThreadExecutor = executor2;
        this.mDiffCallback = diffUtil$ItemCallback;
    }

    public java.util.concurrent.Executor GetBackgroundThreadExecutor() {
        return this.mBackgroundThreadExecutor;
    }

    public androidx.recyclerview.widget.DiffUtil$ItemCallback<T> getDiffCallback() {
        return this.mDiffCallback;
    }

    public java.util.concurrent.Executor GetMainThreadExecutor() {
        return this.mMainThreadExecutor;
    }
}

