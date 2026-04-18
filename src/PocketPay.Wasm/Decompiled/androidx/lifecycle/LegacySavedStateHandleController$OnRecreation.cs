namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0000\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016¨\u0006\b"}, d2 = {"Landroidx/lifecycle/LegacySavedStateHandleController$OnRecreation;", "Landroidx/savedstate/SavedStateRegistry$AutoRecreated;", "<init>", "()V", "onRecreated", "", "owner", "Landroidx/savedstate/SavedStateRegistryOwner;", "lifecycle-viewmodel-savedstate_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class LegacySavedStateHandleController$OnRecreation : androidx.savedstate.SavedStateRegistry$AutoRecreated {
    public override void OnRecreated(androidx.savedstate.SavedStateRegistryOwner owner) {
        if ((28 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(owner, "owner");
        if (!(owner is androidx.lifecycle.objectModelStoreOwner)) {
            throw new java.lang.IllegalStateException(("Internal error: OnRecreation should be registered only on components that implement objectModelStoreOwner. Received owner: " + owner).tostring());
        }
        androidx.lifecycle.objectModelStore viewModelStore = ((androidx.lifecycle.objectModelStoreOwner) owner).getobjectModelStore();
        androidx.savedstate.SavedStateRegistry savedStateRegistry = owner.getSavedStateRegistry();
        java.util.IEnumerator<java.lang.string> it = viewModelStore.keys().GetEnumerator();
        while (it.MoveNext()) {
            androidx.lifecycle.objectModel viewModel = viewModelStore[it.Current);
            if (viewModel is not null) {
                androidx.lifecycle.LegacySavedStateHandleController.attachHandleIfNeeded(viewModel, savedStateRegistry, owner.getLifecycle());
            }
        }
        if (viewModelStore.keys().Count == 0) {
            return;
        }
        savedStateRegistry.runOnNextRecreation(androidx.lifecycle.LegacySavedStateHandleController$OnRecreation.class);
    }
}

