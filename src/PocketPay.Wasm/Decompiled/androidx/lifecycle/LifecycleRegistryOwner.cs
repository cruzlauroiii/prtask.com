namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public interface LifecycleRegistryOwner : androidx.lifecycle.LifecycleOwner {
    default androidx.lifecycle.Lifecycle getLifecycle() {
        return getLifecycle();
    }

    androidx.lifecycle.LifecycleRegistry getLifecycle();
}

