namespace WillowMaze.Wasm.Decompiled;


class MessageThreadUtil<T> : androidx.recyclerview.widget.ThreadUtil<T> {
    MessageThreadUtil() {
    }

    public androidx.recyclerview.widget.ThreadUtil$BackgroundCallback<T> getBackgroundProxy(androidx.recyclerview.widget.ThreadUtil$BackgroundCallback<T> threadUtil$BackgroundCallback) {
        return new androidx.recyclerview.widget.MessageThreadUtil$2(this, threadUtil$BackgroundCallback);
    }

    public androidx.recyclerview.widget.ThreadUtil$MainThreadCallback<T> getMainThreadProxy(androidx.recyclerview.widget.ThreadUtil$MainThreadCallback<T> threadUtil$MainThreadCallback) {
        return new androidx.recyclerview.widget.MessageThreadUtil$1(this, threadUtil$MainThreadCallback);
    }
}

