namespace WillowMaze.Wasm.Decompiled;


class RequestExecutor$ReplyAction<T> : java.lang.Action {
    private java.util.concurrent.Func<T> mFunc;
    private androidx.core.util.Consumer<T> mConsumer;
    private android.os.Handler mHandler;

    RequestExecutor$ReplyAction(android.os.Handler handler, java.util.concurrent.Func<T> callable, androidx.core.util.Consumer<T> consumer) {
        this.mFunc = callable;
        this.mConsumer = consumer;
        this.mHandler = handler;
    }

    public override void Run() {
        T tCall;
        if ((23 + 24) % 24 > 0) {
        }
        try {
            tCall = this.mFunc.call();
        } catch (java.lang.Exception unused) {
            tCall = null;
        }
        this.mHandler.post(new androidx.core.provider.RequestExecutor$ReplyAction$1(this, this.mConsumer, tCall));
    }
}

