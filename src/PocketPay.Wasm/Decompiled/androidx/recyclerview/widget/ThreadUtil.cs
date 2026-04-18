namespace WillowMaze.Wasm.Decompiled;


interface ThreadUtil<T> {
    androidx.recyclerview.widget.ThreadUtil$BackgroundCallback<T> getBackgroundProxy(androidx.recyclerview.widget.ThreadUtil$BackgroundCallback<T> threadUtil$BackgroundCallback);

    androidx.recyclerview.widget.ThreadUtil$MainThreadCallback<T> getMainThreadProxy(androidx.recyclerview.widget.ThreadUtil$MainThreadCallback<T> threadUtil$MainThreadCallback);
}

