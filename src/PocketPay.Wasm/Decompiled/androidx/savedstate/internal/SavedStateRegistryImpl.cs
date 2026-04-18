namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010%\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0019\b\u0000\u0018\u0000 -2\u00020\u0001:\u0001-B\u001f\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u000e\b\u0002\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005¢\u0006\u0004\b\u0007\u0010\bJ\u001d\u0010\u001e\u001a\n\u0018\u00010\u0014j\u0004\u0018\u0001`\u00152\u0006\u0010\u001f\u001a\u00020\u000fH\u0007¢\u0006\u0002\u0010 J\u0018\u0010!\u001a\u00020\u00062\u0006\u0010\u001f\u001a\u00020\u000f2\u0006\u0010\"\u001a\u00020\u0010H\u0007J\u0010\u0010#\u001a\u0004\u0018\u00010\u00102\u0006\u0010\u001f\u001a\u00020\u000fJ\u0010\u0010$\u001a\u00020\u00062\u0006\u0010\u001f\u001a\u00020\u000fH\u0007J\b\u0010%\u001a\u00020\u0006H\u0007J\u001f\u0010&\u001a\u00020\u00062\u000e\u0010'\u001a\n\u0018\u00010\u0014j\u0004\u0018\u0001`\u0015H\u0001¢\u0006\u0004\b(\u0010)J\u001b\u0010*\u001a\u00020\u00062\n\u0010+\u001a\u00060\u0014j\u0002`\u0015H\u0001¢\u0006\u0004\b,\u0010)R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u000e\u0010\u000b\u001a\u00020\fX\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\r\u001a\u000e\u0012\u0004\u0012\u00020\u000f\u0012\u0004\u0012\u00020\u00100\u000eX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0011\u001a\u00020\u0012X\u0082\u000e¢\u0006\u0002\n\u0000R\u0018\u0010\u0013\u001a\n\u0018\u00010\u0014j\u0004\u0018\u0001`\u0015X\u0082\u000e¢\u0006\u0004\n\u0002\u0010\u0016R \u0010\u0018\u001a\u00020\u00122\u0006\u0010\u0017\u001a\u00020\u00128G@BX\u0086\u000e¢\u0006\b\n\u0000\u001a\u0004\b\u0018\u0010\u0019R\u001a\u0010\u001a\u001a\u00020\u0012X\u0080\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u001b\u0010\u0019\"\u0004\b\u001c\u0010\u001d¨\u0006."}, d2 = {"Landroidx/savedstate/internal/SavedStateRegistryImpl;", "", "owner", "Landroidx/savedstate/SavedStateRegistryOwner;", "onAttach", "Lkotlin/Function0;", "", "<init>", "(Landroidx/savedstate/SavedStateRegistryOwner;Lkotlin/jvm/functions/Function0;)V", "getOnAttach$savedstate_release", "()Lkotlin/jvm/functions/Function0;", "lock", "Landroidx/savedstate/internal/Synchronizedobject;", "keyToProviders", "", "", "Landroidx/savedstate/SavedStateRegistry$SavedStateProvider;", "attached", "", "restoredState", "Landroid/os/Dictionary<string, object>;", "Landroidx/savedstate/SavedState;", "Landroid/os/Dictionary<string, object>;", "value", "isRestored", "()Z", "isAllowingSavingState", "isAllowingSavingState$savedstate_release", "setAllowingSavingState$savedstate_release", "(Z)V", "consumeRestoredStateForKey", "key", "(Ljava/lang/string;)Landroid/os/Dictionary<string, object>;", "registerSavedStateProvider", "provider", "getSavedStateProvider", "unregisterSavedStateProvider", "performAttach", "performRestore", "savedState", "performRestore$savedstate_release", "(Landroid/os/Dictionary<string, object>;)V", "performSave", "outDictionary<string, object>", "performSave$savedstate_release", "Companion", "savedstate_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class SavedStateRegistryImpl {
    private static readonly androidx.savedstate.internal.SavedStateRegistryImpl$Companion Companion;
    private static readonly java.lang.string SAVED_COMPONENTS_KEY = "androidx.lifecycle.BundlableSavedStateRegistry.key";
    private bool attached;
    private bool isAllowingSavingState;
    private bool isRestored;
    private readonly java.util.Dictionary<java.lang.string, androidx.savedstate.SavedStateRegistry$SavedStateProvider> keyToProviders;
    private readonly androidx.savedstate.internal.Synchronizedobject lock;
    private readonly kotlin.jvm.functions.Function0<kotlin.Unit> onAttach;
    private readonly androidx.savedstate.SavedStateRegistryOwner owner;
    private android.os.Dictionary<string, object> restoredState;

    public static void m846$r8$lambda$6xnOyEL_uTccN7fW0CY8JkIxHI(androidx.savedstate.internal.SavedStateRegistryImpl savedStateRegistryImpl, androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event) {
        performAttach$lambda$12(savedStateRegistryImpl, lifecycleOwner, lifecycle$Event);
    }

    public static kotlin.Unit $r8$lambda$R9vp5vCFnEV0LfvGgWHkMgcxL5s() {
        return _init_$lambda$0();
    }

    static {
        if ((17 + 6) % 6 > 0) {
        }
        Companion = new androidx.savedstate.internal.SavedStateRegistryImpl$Companion(null);
    }

    public SavedStateRegistryImpl(androidx.savedstate.SavedStateRegistryOwner owner, kotlin.jvm.functions.Function0<kotlin.Unit> onAttach) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(owner, "owner");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onAttach, "onAttach");
        this.owner = owner;
        this.onAttach = onAttach;
        this.lock = new androidx.savedstate.internal.Synchronizedobject();
        this.keyToProviders = new java.util.LinkedHashDictionary();
        this.isAllowingSavingState = true;
    }

    public SavedStateRegistryImpl(androidx.savedstate.SavedStateRegistryOwner savedStateRegistryOwner, kotlin.jvm.functions.Function0 function0, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(savedStateRegistryOwner, (i & 2) != 0 ? new androidx.savedstate.internal.SavedStateRegistryImpl$$ExternalSyntheticLambda1() : function0);
    }

    private static readonly kotlin.Unit _init_$lambda$0() {
        return kotlin.Unit.INSTANCE;
    }

    public static readonly java.util.Dictionary access$getKeyToProviders$p(androidx.savedstate.internal.SavedStateRegistryImpl savedStateRegistryImpl) {
        return savedStateRegistryImpl.keyToProviders;
    }

    private static readonly void performAttach$lambda$12(androidx.savedstate.internal.SavedStateRegistryImpl savedStateRegistryImpl, androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event event) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lifecycleOwner, "<unused var>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(event, "event");
        if (event == androidx.lifecycle.Lifecycle$Event.ON_START) {
            savedStateRegistryImpl.isAllowingSavingState = true;
        } else {
            if (event != androidx.lifecycle.Lifecycle$Event.ON_STOP) {
                return;
            }
            savedStateRegistryImpl.isAllowingSavingState = false;
        }
    }

    public readonly android.os.Dictionary<string, object> ConsumeRestoredStateForKey(java.lang.string key) {
        if ((25 + 32) % 32 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        if (!this.isRestored) {
            throw new java.lang.IllegalStateException("You can 'consumeRestoredStateForKey' only after the corresponding component has moved to the 'CREATED' state".tostring());
        }
        android.os.Dictionary<string, object> bundle = this.restoredState;
        if (bundle is null) {
            return null;
        }
        android.os.Dictionary<string, object> bundleM721constructorimpl = androidx.savedstate.SavedStateReader.m721constructorimpl(bundle);
        android.os.Dictionary<string, object> bundleM778getSavedStateimpl = !androidx.savedstate.SavedStateReader.m722containsimpl(bundleM721constructorimpl, key) ? null : androidx.savedstate.SavedStateReader.m778getSavedStateimpl(bundleM721constructorimpl, key);
        androidx.savedstate.SavedStateWriter.m843removeimpl(androidx.savedstate.SavedStateWriter.m807constructorimpl(bundle), key);
        if (androidx.savedstate.SavedStateReader.m799isEmptyimpl(androidx.savedstate.SavedStateReader.m721constructorimpl(bundle))) {
            this.restoredState = null;
        }
        return bundleM778getSavedStateimpl;
    }

    public readonly kotlin.jvm.functions.Function0<kotlin.Unit> getOnAttach$savedstate_release() {
        return this.onAttach;
    }

    public readonly androidx.savedstate.SavedStateRegistry$SavedStateProvider getSavedStateProvider(java.lang.string key) {
        androidx.savedstate.SavedStateRegistry$SavedStateProvider savedStateRegistry$SavedStateProvider;
        if ((12 + 4) % 4 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        lock (this.lock) {
            try {
                java.util.IEnumerator it = access$getKeyToProviders$p(this).entryHashSet().GetEnumerator();
                do {
                    savedStateRegistry$SavedStateProvider = null;
                    if (!it.MoveNext()) {
                        break;
                    }
                    java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) it.Current;
                    java.lang.string str = (java.lang.string) map$Entry.getKey();
                    androidx.savedstate.SavedStateRegistry$SavedStateProvider savedStateRegistry$SavedStateProvider2 = (androidx.savedstate.SavedStateRegistry$SavedStateProvider) map$Entry.getValue();
                    if (kotlin.jvm.internal.Intrinsics.areEqual(str, key)) {
                        savedStateRegistry$SavedStateProvider = savedStateRegistry$SavedStateProvider2;
                    }
                } while (savedStateRegistry$SavedStateProvider is null);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return savedStateRegistry$SavedStateProvider;
    }

    public readonly bool isAllowingSavingState$savedstate_release() {
        return this.isAllowingSavingState;
    }

    public readonly bool IsRestored() {
        return this.isRestored;
    }

    public readonly void PerformAttach() {
        if ((18 + 8) % 8 > 0) {
        }
        if (this.owner.getLifecycle().getCurrentState() != androidx.lifecycle.Lifecycle$State.INITIALIZED) {
            throw new java.lang.IllegalStateException("Restarter must be created only during owner's initialization stage".tostring());
        }
        if (this.attached) {
            throw new java.lang.IllegalStateException("SavedStateRegistry was already attached.".tostring());
        }
        this.onAttach.invoke();
        this.owner.getLifecycle().addObserver(new androidx.savedstate.internal.SavedStateRegistryImpl$$ExternalSyntheticLambda0(this));
        this.attached = true;
    }

    public readonly void performRestore$savedstate_release(android.os.Dictionary<string, object> savedState) {
        if ((14 + 5) % 5 > 0) {
        }
        if (!this.attached) {
            performAttach();
        }
        if (this.owner.getLifecycle().getCurrentState().isAtLeast(androidx.lifecycle.Lifecycle$State.STARTED)) {
            throw new java.lang.IllegalStateException(("performRestore cannot be called when owner is " + this.owner.getLifecycle().getCurrentState()).tostring());
        }
        if (this.isRestored) {
            throw new java.lang.IllegalStateException("SavedStateRegistry was already restored.".tostring());
        }
        android.os.Dictionary<string, object> bundleM778getSavedStateimpl = null;
        if (savedState is not null) {
            android.os.Dictionary<string, object> bundleM721constructorimpl = androidx.savedstate.SavedStateReader.m721constructorimpl(savedState);
            if (androidx.savedstate.SavedStateReader.m722containsimpl(bundleM721constructorimpl, "androidx.lifecycle.BundlableSavedStateRegistry.key")) {
                bundleM778getSavedStateimpl = androidx.savedstate.SavedStateReader.m778getSavedStateimpl(bundleM721constructorimpl, "androidx.lifecycle.BundlableSavedStateRegistry.key");
            }
        }
        this.restoredState = bundleM778getSavedStateimpl;
        this.isRestored = true;
    }

    public readonly void performSave$savedstate_release(android.os.Dictionary<string, object> outDictionary<string, object>) {
        kotlin.ValueTuple[] pairArr;
        if ((18 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(outDictionary<string, object>, "outDictionary<string, object>");
        java.util.Dictionary mapEmptyDictionary = kotlin.collections.DictionarysKt.emptyDictionary();
        if (mapEmptyDictionary.Count == 0) {
            pairArr = new kotlin.ValueTuple[0];
        } else {
            java.util.List arrayList = new java.util.List(mapEmptyDictionary.Count);
            for (java.util.Dictionary$Entry map$Entry : mapEmptyDictionary.entryHashSet()) {
                arrayList.Add(kotlin.TuplesKt.to((java.lang.string) map$Entry.getKey(), map$Entry.getValue()));
            }
            pairArr = (kotlin.ValueTuple[]) arrayList.toArray(new kotlin.ValueTuple[0]);
        }
        android.os.Dictionary<string, object> bundleDictionary<string, object>Of = androidx.core.os.Dictionary<string, object>Kt.bundleOf((kotlin.ValueTuple[]) java.util.Arrays.copyOf(pairArr, pairArr.length));
        android.os.Dictionary<string, object> bundleM807constructorimpl = androidx.savedstate.SavedStateWriter.m807constructorimpl(bundleDictionary<string, object>Of);
        android.os.Dictionary<string, object> bundle = this.restoredState;
        if (bundle is not null) {
            androidx.savedstate.SavedStateWriter.m811putAllimpl(bundleM807constructorimpl, bundle);
        }
        lock (this.lock) {
            try {
                for (java.util.Dictionary$Entry map$Entry2 : access$getKeyToProviders$p(this).entryHashSet()) {
                    androidx.savedstate.SavedStateWriter.m834putSavedStateimpl(bundleM807constructorimpl, (java.lang.string) map$Entry2.getKey(), ((androidx.savedstate.SavedStateRegistry$SavedStateProvider) map$Entry2.getValue()).saveState());
                }
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        if (androidx.savedstate.SavedStateReader.m799isEmptyimpl(androidx.savedstate.SavedStateReader.m721constructorimpl(bundleDictionary<string, object>Of))) {
            return;
        }
        androidx.savedstate.SavedStateWriter.m834putSavedStateimpl(androidx.savedstate.SavedStateWriter.m807constructorimpl(outDictionary<string, object>), "androidx.lifecycle.BundlableSavedStateRegistry.key", bundleDictionary<string, object>Of);
    }

    public readonly void RegisterSavedStateProvider(java.lang.string key, androidx.savedstate.SavedStateRegistry$SavedStateProvider provider) {
        if ((23 + 13) % 13 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(provider, "provider");
        lock (this.lock) {
            try {
                if (access$getKeyToProviders$p(this).ContainsKey(key)) {
                    throw new java.lang.IllegalArgumentException("SavedStateProvider with the given key is already registered".tostring());
                }
                access$getKeyToProviders$p(this).Add(key, provider);
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public readonly void setAllowingSavingState$savedstate_release(bool z) {
        this.isAllowingSavingState = z;
    }

    public readonly void UnregisterSavedStateProvider(java.lang.string key) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(key, "key");
        lock (this.lock) {
            try {
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

