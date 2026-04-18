namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0006\b\u0002\u0018\u00002\u00020\u0001B\u0015\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\bR\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\n¨\u0006\u000b"}, d2 = {"Landroidx/fragment/app/objectLifecycleCallbacksDispatcher$objectLifecycleCallbacksHolder;", "", "callback", "Landroidx/fragment/app/objectManager$objectLifecycleCallbacks;", "recursive", "", "(Landroidx/fragment/app/objectManager$objectLifecycleCallbacks;Z)V", "getCallback", "()Landroidx/fragment/app/objectManager$objectLifecycleCallbacks;", "getRecursive", "()Z", "fragment_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class C0100x7c22a489 {
    private readonly androidx.fragment.app.objectManager$objectLifecycleCallbacks callback;
    private readonly bool recursive;

    public C0100x7c22a489(androidx.fragment.app.objectManager$objectLifecycleCallbacks callback, bool z) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(callback, "callback");
        this.callback = callback;
        this.recursive = z;
    }

    public readonly androidx.fragment.app.objectManager$objectLifecycleCallbacks getCallback() {
        return this.callback;
    }

    public readonly bool GetRecursive() {
        return this.recursive;
    }
}

