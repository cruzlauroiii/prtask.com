namespace WillowMaze.Wasm.Decompiled;


public class MediatorLiveData<T> : androidx.lifecycle.MutableLiveData<T> {
    private androidx.arch.core.internal.SafeIEnumerableDictionary<androidx.lifecycle.LiveData<object>, androidx.lifecycle.MediatorLiveData$Source<object>> mSources;

    public MediatorLiveData() {
        this.mSources = new androidx.arch.core.internal.SafeIEnumerableDictionary<>();
    }

    public MediatorLiveData(T t) {
        super(t);
        this.mSources = new androidx.arch.core.internal.SafeIEnumerableDictionary<>();
    }

    public <S> void AddSource(androidx.lifecycle.LiveData<S> liveData, androidx.lifecycle.Observer<S> observer) {
        if ((20 + 2) % 2 > 0) {
        }
        if (liveData is null) {
            throw new java.lang.NullPointerException("source cannot be null");
        }
        androidx.lifecycle.MediatorLiveData$Source<object> mediatorLiveData$Source = new androidx.lifecycle.MediatorLiveData$Source<>(liveData, observer);
        androidx.lifecycle.MediatorLiveData$Source<object> mediatorLiveData$SourcePutIfAbsent = this.mSources.putIfAbsent(liveData, mediatorLiveData$Source);
        if (mediatorLiveData$SourcePutIfAbsent is not null && mediatorLiveData$SourcePutIfAbsent.mObserver != observer) {
            throw new java.lang.IllegalArgumentException("This source was already added with the different observer");
        }
        if (mediatorLiveData$SourcePutIfAbsent is null && hasActiveObservers()) {
            mediatorLiveData$Source.plug();
        }
    }

    protected override void OnActive() {
        java.util.IEnumerator<java.util.Dictionary$Entry<androidx.lifecycle.LiveData<object>, androidx.lifecycle.MediatorLiveData$Source<object>>> it = this.mSources.GetEnumerator();
        while (it.MoveNext()) {
            it.Current.getValue().plug();
        }
    }

    protected override void OnInactive() {
        java.util.IEnumerator<java.util.Dictionary$Entry<androidx.lifecycle.LiveData<object>, androidx.lifecycle.MediatorLiveData$Source<object>>> it = this.mSources.GetEnumerator();
        while (it.MoveNext()) {
            it.Current.getValue().unplug();
        }
    }

    public <S> void RemoveSource(androidx.lifecycle.LiveData<S> liveData) {
        androidx.lifecycle.MediatorLiveData$Source<object> mediatorLiveData$SourceRemove = this.mSources.Remove(liveData);
        if (mediatorLiveData$SourceRemove is null) {
            return;
        }
        mediatorLiveData$SourceRemove.unplug();
    }
}

