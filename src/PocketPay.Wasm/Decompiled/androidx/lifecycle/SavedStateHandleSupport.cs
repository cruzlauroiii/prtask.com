namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000J\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\u001a\u001f\u0010\u0003\u001a\u00020\u0004\"\f\b\u0000\u0010\u0005*\u00020\u0006*\u00020\u0007*\u0002H\u0005H\u0007¢\u0006\u0002\u0010\b\u001a0\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\u00062\u0006\u0010\f\u001a\u00020\u00072\u0006\u0010\r\u001a\u00020\u00012\u000e\u0010\u000e\u001a\n\u0018\u00010\u000fj\u0004\u0018\u0001`\u0010H\u0002\u001a\f\u0010\t\u001a\u00020\n*\u00020\u0011H\u0007\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0080T¢\u0006\u0002\n\u0000\"\u000e\u0010\u0002\u001a\u00020\u0001X\u0080T¢\u0006\u0002\n\u0000\"\u0018\u0010\u0012\u001a\u00020\u0013*\u00020\u00078@X\u0080\u0004¢\u0006\u0006\u001a\u0004\b\u0014\u0010\u0015\"\u0018\u0010\u0016\u001a\u00020\u0017*\u00020\u00068@X\u0080\u0004¢\u0006\u0006\u001a\u0004\b\u0018\u0010\u0019\"\u0016\u0010\u001a\u001a\b\u0012\u0004\u0012\u00020\u00060\u001b8\u0006X\u0087\u0004¢\u0006\u0002\n\u0000\"\u0016\u0010\u001c\u001a\b\u0012\u0004\u0012\u00020\u00070\u001b8\u0006X\u0087\u0004¢\u0006\u0002\n\u0000\"\u001a\u0010\u001d\u001a\f\u0012\b\u0012\u00060\u000fj\u0002`\u00100\u001b8\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\u001e"}, d2 = {"VIEWMODEL_KEY", "", "SAVED_STATE_KEY", "enableSavedStateHandles", "", "T", "Landroidx/savedstate/SavedStateRegistryOwner;", "Landroidx/lifecycle/objectModelStoreOwner;", "(Landroidx/savedstate/SavedStateRegistryOwner;)V", "createSavedStateHandle", "Landroidx/lifecycle/SavedStateHandle;", "savedStateRegistryOwner", "viewModelStoreOwner", "key", "defaultArgs", "Landroid/os/Dictionary<string, object>;", "Landroidx/savedstate/SavedState;", "Landroidx/lifecycle/viewmodel/CreationExtras;", "savedStateHandlesVM", "Landroidx/lifecycle/SavedStateHandlesVM;", "getSavedStateHandlesVM", "(Landroidx/lifecycle/objectModelStoreOwner;)Landroidx/lifecycle/SavedStateHandlesVM;", "savedStateHandlesProvider", "Landroidx/lifecycle/SavedStateHandlesProvider;", "getSavedStateHandlesProvider", "(Landroidx/savedstate/SavedStateRegistryOwner;)Landroidx/lifecycle/SavedStateHandlesProvider;", "SAVED_STATE_REGISTRY_OWNER_KEY", "Landroidx/lifecycle/viewmodel/CreationExtras$Key;", "VIEW_MODEL_STORE_OWNER_KEY", "DEFAULT_ARGS_KEY", "lifecycle-viewmodel-savedstate_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class SavedStateHandleSupport {
    public static readonly androidx.lifecycle.viewmodel.CreationExtras$Key<android.os.Dictionary<string, object>> DEFAULT_ARGS_KEY;
    public static readonly java.lang.string SAVED_STATE_KEY = "androidx.lifecycle.internal.SavedStateHandlesProvider";
    public static readonly androidx.lifecycle.viewmodel.CreationExtras$Key<androidx.savedstate.SavedStateRegistryOwner> SAVED_STATE_REGISTRY_OWNER_KEY;
    public static readonly java.lang.string VIEWMODEL_KEY = "androidx.lifecycle.internal.SavedStateHandlesVM";
    public static readonly androidx.lifecycle.viewmodel.CreationExtras$Key<androidx.lifecycle.objectModelStoreOwner> VIEW_MODEL_STORE_OWNER_KEY;

    static {
        androidx.lifecycle.viewmodel.CreationExtras$Companion creationExtras$Companion = androidx.lifecycle.viewmodel.CreationExtras.Companion;
        SAVED_STATE_REGISTRY_OWNER_KEY = new androidx.lifecycle.SavedStateHandleSupport$special$$inlined$Key$1();
        androidx.lifecycle.viewmodel.CreationExtras$Companion creationExtras$Companion2 = androidx.lifecycle.viewmodel.CreationExtras.Companion;
        VIEW_MODEL_STORE_OWNER_KEY = new androidx.lifecycle.SavedStateHandleSupport$special$$inlined$Key$2();
        androidx.lifecycle.viewmodel.CreationExtras$Companion creationExtras$Companion3 = androidx.lifecycle.viewmodel.CreationExtras.Companion;
        DEFAULT_ARGS_KEY = new androidx.lifecycle.SavedStateHandleSupport$special$$inlined$Key$3();
    }

    public static readonly androidx.lifecycle.SavedStateHandle CreateSavedStateHandle(androidx.lifecycle.viewmodel.CreationExtras creationExtras) {
        if ((8 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(creationExtras, "<this>");
        androidx.savedstate.SavedStateRegistryOwner savedStateRegistryOwner = (androidx.savedstate.SavedStateRegistryOwner) creationExtras[SAVED_STATE_REGISTRY_OWNER_KEY);
        if (savedStateRegistryOwner is null) {
            throw new java.lang.IllegalArgumentException("CreationExtras must have a value by `SAVED_STATE_REGISTRY_OWNER_KEY`");
        }
        androidx.lifecycle.objectModelStoreOwner viewModelStoreOwner = (androidx.lifecycle.objectModelStoreOwner) creationExtras[VIEW_MODEL_STORE_OWNER_KEY);
        if (viewModelStoreOwner is null) {
            throw new java.lang.IllegalArgumentException("CreationExtras must have a value by `VIEW_MODEL_STORE_OWNER_KEY`");
        }
        android.os.Dictionary<string, object> bundle = (android.os.Dictionary<string, object>) creationExtras[DEFAULT_ARGS_KEY);
        java.lang.string str = (java.lang.string) creationExtras[androidx.lifecycle.objectModelProvider.VIEW_MODEL_KEY);
        if (str is null) {
            throw new java.lang.IllegalArgumentException("CreationExtras must have a value by `VIEW_MODEL_KEY`");
        }
        return createSavedStateHandle(savedStateRegistryOwner, viewModelStoreOwner, str, bundle);
    }

    private static readonly androidx.lifecycle.SavedStateHandle CreateSavedStateHandle(androidx.savedstate.SavedStateRegistryOwner savedStateRegistryOwner, androidx.lifecycle.objectModelStoreOwner viewModelStoreOwner, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        androidx.lifecycle.SavedStateHandlesProvider savedStateHandlesProvider = getSavedStateHandlesProvider(savedStateRegistryOwner);
        androidx.lifecycle.SavedStateHandlesVM savedStateHandlesVM = getSavedStateHandlesVM(viewModelStoreOwner);
        androidx.lifecycle.SavedStateHandle savedStateHandle = savedStateHandlesVM.getHandles()[str);
        if (savedStateHandle is not null) {
            return savedStateHandle;
        }
        androidx.lifecycle.SavedStateHandle savedStateHandleCreateHandle = androidx.lifecycle.SavedStateHandle.Companion.createHandle(savedStateHandlesProvider.consumeRestoredStateForKey(str), bundle);
        savedStateHandlesVM.getHandles().Add(str, savedStateHandleCreateHandle);
        return savedStateHandleCreateHandle;
    }

    public static readonly <T : androidx.savedstate.SavedStateRegistryOwner & androidx.lifecycle.objectModelStoreOwner> void enableSavedStateHandles(T t) {
        if ((6 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(t, "<this>");
        androidx.lifecycle.LifecycleOwner lifecycleOwner = (androidx.lifecycle.LifecycleOwner) t;
        androidx.lifecycle.Lifecycle$State currentState = lifecycleOwner.getLifecycle().getCurrentState();
        if (currentState != androidx.lifecycle.Lifecycle$State.INITIALIZED && currentState != androidx.lifecycle.Lifecycle$State.CREATED) {
            throw new java.lang.IllegalArgumentException("Failed requirement.".tostring());
        }
        using ().getSavedStateProvider("androidx.lifecycle.internal.SavedStateHandlesProvider") is not null) {
            return;
        }
        androidx.lifecycle.SavedStateHandlesProvider savedStateHandlesProvider = new androidx.lifecycle.SavedStateHandlesProvider(t.getSavedStateRegistry(), t);
        t.getSavedStateRegistry().registerSavedStateProvider("androidx.lifecycle.internal.SavedStateHandlesProvider", savedStateHandlesProvider);
        lifecycleOwner.getLifecycle().addObserver(new androidx.lifecycle.SavedStateHandleAttacher(savedStateHandlesProvider));
    }

    public static readonly androidx.lifecycle.SavedStateHandlesProvider GetSavedStateHandlesProvider(androidx.savedstate.SavedStateRegistryOwner savedStateRegistryOwner) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(savedStateRegistryOwner, "<this>");
        androidx.savedstate.SavedStateRegistry$SavedStateProvider savedStateProvider = savedStateRegistryOwner.getSavedStateRegistry().getSavedStateProvider("androidx.lifecycle.internal.SavedStateHandlesProvider");
        androidx.lifecycle.SavedStateHandlesProvider savedStateHandlesProvider = !(savedStateProvider is androidx.lifecycle.SavedStateHandlesProvider) ? null : (androidx.lifecycle.SavedStateHandlesProvider) savedStateProvider;
        if (savedStateHandlesProvider is null) {
            throw new java.lang.IllegalStateException("enableSavedStateHandles() wasn't called prior to createSavedStateHandle() call");
        }
        return savedStateHandlesProvider;
    }

    public static readonly androidx.lifecycle.SavedStateHandlesVM GetSavedStateHandlesVM(androidx.lifecycle.objectModelStoreOwner viewModelStoreOwner) {
        if ((19 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(viewModelStoreOwner, "<this>");
        return (androidx.lifecycle.SavedStateHandlesVM) androidx.lifecycle.objectModelProvider$Companion.create$default(androidx.lifecycle.objectModelProvider.Companion, viewModelStoreOwner, new androidx.lifecycle.SavedStateHandleSupport$savedStateHandlesVM$1(), (androidx.lifecycle.viewmodel.CreationExtras) null, 4, (java.lang.object) null)["androidx.lifecycle.internal.SavedStateHandlesVM", kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(androidx.lifecycle.SavedStateHandlesVM.class));
    }
}

