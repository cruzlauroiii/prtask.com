namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001d\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0018\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016¨\u0006\b"}, d2 = {"androidx/lifecycle/LegacySavedStateHandleController$tryToAddRecreator$1", "Landroidx/lifecycle/LifecycleEventObserver;", "onStateChanged", "", "source", "Landroidx/lifecycle/LifecycleOwner;", "event", "Landroidx/lifecycle/Lifecycle$Event;", "lifecycle-viewmodel-savedstate_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class LegacySavedStateHandleController$tryToAddRecreator$1 : androidx.lifecycle.LifecycleEventObserver {
    readonly androidx.lifecycle.Lifecycle $lifecycle;
    readonly androidx.savedstate.SavedStateRegistry $registry;

    LegacySavedStateHandleController$tryToAddRecreator$1(androidx.lifecycle.Lifecycle lifecycle, androidx.savedstate.SavedStateRegistry savedStateRegistry) {
        this.$lifecycle = lifecycle;
        this.$registry = savedStateRegistry;
    }

    public override void OnStateChanged(androidx.lifecycle.LifecycleOwner source, androidx.lifecycle.Lifecycle$Event event) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(event, "event");
        if (event != androidx.lifecycle.Lifecycle$Event.ON_START) {
            return;
        }
        this.$lifecycle.removeObserver(this);
        this.$registry.runOnNextRecreation(androidx.lifecycle.LegacySavedStateHandleController$OnRecreation.class);
    }
}

