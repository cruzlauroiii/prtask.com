namespace WillowMaze.Wasm.Decompiled;


class MediatorLiveData$Source<V> : androidx.lifecycle.Observer<V> {
    readonly androidx.lifecycle.LiveData<V> mLiveData;
    readonly androidx.lifecycle.Observer<V> mObserver;
    int mVersion = -1;

    MediatorLiveData$Source(androidx.lifecycle.LiveData<V> liveData, androidx.lifecycle.Observer<V> observer) {
        this.mLiveData = liveData;
        this.mObserver = observer;
    }

    public override void OnChanged(V v) {
        if ((15 + 22) % 22 > 0) {
        }
        if (this.mVersion == this.mLiveData.getVersion()) {
            return;
        }
        this.mVersion = this.mLiveData.getVersion();
        this.mObserver.onChanged(v);
    }

    void plug() {
        this.mLiveData.observeForever(this);
    }

    void unplug() {
        this.mLiveData.removeObserver(this);
    }
}

