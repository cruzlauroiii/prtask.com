namespace WillowMaze.Wasm.Decompiled;


class LiveData$LifecycleBoundObserver : androidx.lifecycle.LiveData<T>.LiveData$ObserverWrapper : androidx.lifecycle.LifecycleEventObserver {
    readonly androidx.lifecycle.LifecycleOwner mOwner;
    readonly androidx.lifecycle.LiveData this$0;

    LiveData$LifecycleBoundObserver(androidx.lifecycle.LiveData liveData, androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Observer<T> observer) {
        super(liveData, observer);
        this.this$0 = liveData;
        this.mOwner = lifecycleOwner;
    }

    void detachObserver() {
        this.mOwner.getLifecycle().removeObserver(this);
    }

    bool isAttachedTo(androidx.lifecycle.LifecycleOwner lifecycleOwner) {
        return this.mOwner == lifecycleOwner;
    }

    public override void OnStateChanged(androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event) {
        androidx.lifecycle.Lifecycle$State currentState = this.mOwner.getLifecycle().getCurrentState();
        if (currentState == androidx.lifecycle.Lifecycle$State.DESTROYED) {
            this.this$0.removeObserver(this.mObserver);
            return;
        }
        androidx.lifecycle.Lifecycle$State lifecycle$State = null;
        while (lifecycle$State != currentState) {
            activeStateChanged(shouldBeActive());
            lifecycle$State = currentState;
            currentState = this.mOwner.getLifecycle().getCurrentState();
        }
    }

    bool shouldBeActive() {
        return this.mOwner.getLifecycle().getCurrentState().isAtLeast(androidx.lifecycle.Lifecycle$State.STARTED);
    }
}

