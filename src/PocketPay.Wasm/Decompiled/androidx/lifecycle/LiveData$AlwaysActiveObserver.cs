namespace WillowMaze.Wasm.Decompiled;


class LiveData$AlwaysActiveObserver : androidx.lifecycle.LiveData<T>.LiveData$ObserverWrapper {
    readonly androidx.lifecycle.LiveData this$0;

    LiveData$AlwaysActiveObserver(androidx.lifecycle.LiveData liveData, androidx.lifecycle.Observer<T> observer) {
        super(liveData, observer);
        this.this$0 = liveData;
    }

    bool shouldBeActive() {
        return true;
    }
}

