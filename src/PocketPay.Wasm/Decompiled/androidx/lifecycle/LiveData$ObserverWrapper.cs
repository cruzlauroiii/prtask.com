namespace WillowMaze.Wasm.Decompiled;


abstract class LiveData$ObserverWrapper {
    bool mActive;
    int mLastVersion = -1;
    readonly androidx.lifecycle.Observer<T> mObserver;
    readonly androidx.lifecycle.LiveData this$0;

    LiveData$ObserverWrapper(androidx.lifecycle.LiveData liveData, androidx.lifecycle.Observer<T> observer) {
        this.this$0 = liveData;
        this.mObserver = observer;
    }

    void activeStateChanged(bool z) {
        if (z != this.mActive) {
            this.mActive = z;
            this.this$0.changeActiveCounter(!z ? -1 : 1);
            if (this.mActive) {
                this.this$0.dispatchingValue(this);
            }
        }
    }

    void detachObserver() {
    }

    bool isAttachedTo(androidx.lifecycle.LifecycleOwner lifecycleOwner) {
        return false;
    }

    abstract bool ShouldBeActive();
}

