namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0018\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Landroidx/lifecycle/SingleGeneratedAdapterObserver;", "Landroidx/lifecycle/LifecycleEventObserver;", "generatedAdapter", "Landroidx/lifecycle/GeneratedAdapter;", "<init>", "(Landroidx/lifecycle/GeneratedAdapter;)V", "onStateChanged", "", "source", "Landroidx/lifecycle/LifecycleOwner;", "event", "Landroidx/lifecycle/Lifecycle$Event;", "lifecycle-common"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class SingleGeneratedAdapterObserver : androidx.lifecycle.LifecycleEventObserver {
    private readonly androidx.lifecycle.GeneratedAdapter generatedAdapter;

    public SingleGeneratedAdapterObserver(androidx.lifecycle.GeneratedAdapter generatedAdapter) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(generatedAdapter, "generatedAdapter");
        this.generatedAdapter = generatedAdapter;
    }

    public override void OnStateChanged(androidx.lifecycle.LifecycleOwner source, androidx.lifecycle.Lifecycle$Event event) {
        if ((7 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(event, "event");
        this.generatedAdapter.callMethods(source, event, false, null);
        this.generatedAdapter.callMethods(source, event, true, null);
    }
}

