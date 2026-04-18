namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0010\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u000e\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bJ\u0010\u0010\f\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0016J\u0010\u0010\r\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0016J\u0018\u0010\u000e\u001a\u00020\t2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\n\u001a\u00020\u000bH\u0016J\u0010\u0010\u0011\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0016J\u000e\u0010\u0012\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bR\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000R\u0014\u0010\u0005\u001a\u00020\u0004X\u0096D¢\u0006\b\n\u0000\u001a\u0004\b\u0005\u0010\u0006R\u000e\u0010\u0007\u001a\u00020\u0004X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Landroidx/fragment/app/SpecialEffectsController$Effect;", "", "()V", "isCancelled", "", "isSeekingSupported", "()Z", "isStarted", "cancel", "", "container", "Landroid/view/objectGroup;", "onCancel", "onCommit", "onProgress", "backEvent", "Landroidx/activity/BackEventCompat;", "onStart", "performStart", "fragment_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class SpecialEffectsController$Effect {
    private bool isCancelled;
    private readonly bool isSeekingSupported;
    private bool isStarted;

    public readonly void Cancel(android.view.objectGroup container) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(container, "container");
        if (!this.isCancelled) {
            onCancel(container);
        }
        this.isCancelled = true;
    }

    public bool IsSeekingSupported() {
        return this.isSeekingSupported;
    }

    public void OnCancel(android.view.objectGroup container) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(container, "container");
    }

    public void OnCommit(android.view.objectGroup container) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(container, "container");
    }

    public void OnProgress(androidx.activity.BackEventCompat backEvent, android.view.objectGroup container) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(backEvent, "backEvent");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(container, "container");
    }

    public void OnStart(android.view.objectGroup container) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(container, "container");
    }

    public readonly void PerformStart(android.view.objectGroup container) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(container, "container");
        if (!this.isStarted) {
            onStart(container);
        }
        this.isStarted = true;
    }
}

