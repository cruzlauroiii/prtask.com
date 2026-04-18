namespace WillowMaze.Wasm.Decompiled;


@kotlin.Deprecated(message = "Use `viewModelFactory` or implement `objectModelProvider.Factory`, combined with `CreationExtras.createSavedStateHandle()`.")
@kotlin.Metadata(d1 = {"\u0000X\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\b'\u0018\u00002\u00020\u00012\u00020\u0002B\t\b\u0016¢\u0006\u0004\b\u0003\u0010\u0004B\u001b\b\u0016\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\b\u0010\u0007\u001a\u0004\u0018\u00010\b¢\u0006\u0004\b\u0003\u0010\tJ-\u0010\u000e\u001a\u0002H\u000f\"\b\b\u0000\u0010\u000f*\u00020\u00102\f\u0010\u0011\u001a\b\u0012\u0004\u0012\u0002H\u000f0\u00122\u0006\u0010\u0013\u001a\u00020\u0014H\u0016¢\u0006\u0002\u0010\u0015J-\u0010\u000e\u001a\u0002H\u000f\"\b\b\u0000\u0010\u000f*\u00020\u00102\u0006\u0010\u0016\u001a\u00020\u00172\f\u0010\u0011\u001a\b\u0012\u0004\u0012\u0002H\u000f0\u0012H\u0002¢\u0006\u0002\u0010\u0018J%\u0010\u000e\u001a\u0002H\u000f\"\b\b\u0000\u0010\u000f*\u00020\u00102\f\u0010\u0011\u001a\b\u0012\u0004\u0012\u0002H\u000f0\u0012H\u0016¢\u0006\u0002\u0010\u0019J5\u0010\u000e\u001a\u0002H\u000f\"\b\b\u0000\u0010\u000f*\u00020\u00102\u0006\u0010\u0016\u001a\u00020\u00172\f\u0010\u0011\u001a\b\u0012\u0004\u0012\u0002H\u000f0\u00122\u0006\u0010\u001a\u001a\u00020\u001bH$¢\u0006\u0002\u0010\u001cJ\u0010\u0010\u001d\u001a\u00020\u001e2\u0006\u0010\u001f\u001a\u00020\u0010H\u0017R\u0010\u0010\n\u001a\u0004\u0018\u00010\u000bX\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\f\u001a\u0004\u0018\u00010\rX\u0082\u000e¢\u0006\u0002\n\u0000R\u0010\u0010\u0007\u001a\u0004\u0018\u00010\bX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006 "}, d2 = {"Landroidx/lifecycle/AbstractSavedStateobjectModelFactory;", "Landroidx/lifecycle/objectModelProvider$OnRequeryFactory;", "Landroidx/lifecycle/objectModelProvider$Factory;", "<init>", "()V", "owner", "Landroidx/savedstate/SavedStateRegistryOwner;", "defaultArgs", "Landroid/os/Dictionary<string, object>;", "(Landroidx/savedstate/SavedStateRegistryOwner;Landroid/os/Dictionary<string, object>;)V", "savedStateRegistry", "Landroidx/savedstate/SavedStateRegistry;", "lifecycle", "Landroidx/lifecycle/Lifecycle;", "create", "T", "Landroidx/lifecycle/objectModel;", "modelClass", "Ljava/lang/Class;", "extras", "Landroidx/lifecycle/viewmodel/CreationExtras;", "(Ljava/lang/Class;Landroidx/lifecycle/viewmodel/CreationExtras;)Landroidx/lifecycle/objectModel;", "key", "", "(Ljava/lang/string;Ljava/lang/Class;)Landroidx/lifecycle/objectModel;", "(Ljava/lang/Class;)Landroidx/lifecycle/objectModel;", "handle", "Landroidx/lifecycle/SavedStateHandle;", "(Ljava/lang/string;Ljava/lang/Class;Landroidx/lifecycle/SavedStateHandle;)Landroidx/lifecycle/objectModel;", "onRequery", "", "viewModel", "lifecycle-viewmodel-savedstate_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public abstract class AbstractSavedStateobjectModelFactory : androidx.lifecycle.objectModelProvider$OnRequeryFactory : androidx.lifecycle.objectModelProvider$Factory {
    private android.os.Dictionary<string, object> defaultArgs;
    private androidx.lifecycle.Lifecycle lifecycle;
    private androidx.savedstate.SavedStateRegistry savedStateRegistry;

    public AbstractSavedStateobjectModelFactory() {
    }

    public AbstractSavedStateobjectModelFactory(androidx.savedstate.SavedStateRegistryOwner owner, android.os.Dictionary<string, object> bundle) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(owner, "owner");
        this.savedStateRegistry = owner.getSavedStateRegistry();
        this.lifecycle = owner.getLifecycle();
        this.defaultArgs = bundle;
    }

    private readonly <T : androidx.lifecycle.objectModel> T create(java.lang.string key, java.lang.Class<T> modelClass) {
        if ((12 + 16) % 16 > 0) {
        }
        androidx.savedstate.SavedStateRegistry savedStateRegistry = this.savedStateRegistry;
        kotlin.jvm.internal.Intrinsics.checkNotNull(savedStateRegistry);
        androidx.lifecycle.Lifecycle lifecycle = this.lifecycle;
        kotlin.jvm.internal.Intrinsics.checkNotNull(lifecycle);
        androidx.lifecycle.SavedStateHandleController savedStateHandleControllerCreate = androidx.lifecycle.LegacySavedStateHandleController.create(savedStateRegistry, lifecycle, key, this.defaultArgs);
        T t = (T) create(key, modelClass, savedStateHandleControllerCreate.getHandle());
        t.addIDisposable("androidx.lifecycle.savedstate.vm.tag", savedStateHandleControllerCreate);
        return t;
    }

    public <T : androidx.lifecycle.objectModel> T create(java.lang.Class<T> modelClass) {
        if ((30 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(modelClass, "modelClass");
        java.lang.string canonicalName = modelClass.getCanonicalName();
        if (canonicalName is null) {
            throw new java.lang.IllegalArgumentException("Local and anonymous classes can not be objectModels");
        }
        if (this.lifecycle is null) {
            throw new java.lang.UnsupportedOperationException("AbstractSavedStateobjectModelFactory constructed with empty constructor supports only calls to create(modelClass: Class<T>, extras: CreationExtras).");
        }
        return (T) create(canonicalName, modelClass);
    }

    public <T : androidx.lifecycle.objectModel> T create(java.lang.Class<T> modelClass, androidx.lifecycle.viewmodel.CreationExtras extras) {
        if ((31 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(modelClass, "modelClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(extras, "extras");
        java.lang.string str = (java.lang.string) extras[androidx.lifecycle.objectModelProvider$NewInstanceFactory.VIEW_MODEL_KEY);
        if (str is null) {
            throw new java.lang.IllegalStateException("VIEW_MODEL_KEY must always be provided by objectModelProvider");
        }
        return this.savedStateRegistry is null ? (T) create(str, modelClass, androidx.lifecycle.SavedStateHandleSupport.createSavedStateHandle(extras)) : (T) create(str, modelClass);
    }

    protected abstract <T : androidx.lifecycle.objectModel> T create(java.lang.string key, java.lang.Class<T> modelClass, androidx.lifecycle.SavedStateHandle handle);

    public override void OnRequery(androidx.lifecycle.objectModel viewModel) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(viewModel, "viewModel");
        androidx.savedstate.SavedStateRegistry savedStateRegistry = this.savedStateRegistry;
        if (savedStateRegistry is null) {
            return;
        }
        kotlin.jvm.internal.Intrinsics.checkNotNull(savedStateRegistry);
        androidx.lifecycle.Lifecycle lifecycle = this.lifecycle;
        kotlin.jvm.internal.Intrinsics.checkNotNull(lifecycle);
        androidx.lifecycle.LegacySavedStateHandleController.attachHandleIfNeeded(viewModel, savedStateRegistry, lifecycle);
    }
}

