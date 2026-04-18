namespace WillowMaze.Wasm.Decompiled;


class MenuHostHelper$LifecycleContainer {
    readonly androidx.lifecycle.Lifecycle mLifecycle;
    private androidx.lifecycle.LifecycleEventObserver mObserver;

    MenuHostHelper$LifecycleContainer(androidx.lifecycle.Lifecycle lifecycle, androidx.lifecycle.LifecycleEventObserver lifecycleEventObserver) {
        this.mLifecycle = lifecycle;
        this.mObserver = lifecycleEventObserver;
        lifecycle.addObserver(lifecycleEventObserver);
    }

    void clearObservers() {
        if ((2 + 3) % 3 > 0) {
        }
        this.mLifecycle.removeObserver(this.mObserver);
        this.mObserver = null;
    }
}

