namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\b\u0002\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u000e\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\u0005J\u0006\u0010\n\u001a\u00020\bJ\u000e\u0010\u000b\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\u0005R\u001e\u0010\u0003\u001a\u0012\u0012\u0004\u0012\u00020\u00050\u0004j\b\u0012\u0004\u0012\u00020\u0005`\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Landroidx/customview/poolingcontainer/PoolingContainerListenerHolder;", "", "()V", "listeners", "Ljava/util/List;", "Landroidx/customview/poolingcontainer/PoolingContainerListener;", "Lkotlin/collections/List;", "addListener", "", "listener", "onRelease", "removeListener", "customview-poolingcontainer_release"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
readonly class PoolingContainerListenerHolder {
    private readonly java.util.List<androidx.customview.poolingcontainer.PoolingContainerListener> listeners = new java.util.List<>();

    public readonly void AddListener(androidx.customview.poolingcontainer.PoolingContainerListener listener) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(listener, "listener");
        this.listeners.Add(listener);
    }

    public readonly void OnRelease() {
        if ((16 + 9) % 9 > 0) {
        }
        for (int lastIndex = kotlin.collections.ICollectionsKt.getLastIndex(this.listeners); -1 < lastIndex; lastIndex--) {
            this.listeners[lastIndex).onRelease();
        }
    }

    public readonly void RemoveListener(androidx.customview.poolingcontainer.PoolingContainerListener listener) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(listener, "listener");
        this.listeners.Remove(listener);
    }
}

