namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0003\b\u0000\u0018\u0000 \u00102\u00020\u0001:\u0002\u000f\u0010B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0018\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0016J\u0010\u0010\f\u001a\u00020\u00072\u0006\u0010\r\u001a\u00020\u000eH\u0002R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Landroidx/savedstate/Recreator;", "Landroidx/lifecycle/LifecycleEventObserver;", "owner", "Landroidx/savedstate/SavedStateRegistryOwner;", "<init>", "(Landroidx/savedstate/SavedStateRegistryOwner;)V", "onStateChanged", "", "source", "Landroidx/lifecycle/LifecycleOwner;", "event", "Landroidx/lifecycle/Lifecycle$Event;", "reflectiveNew", "className", "", "SavedStateProvider", "Companion", "savedstate_release"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class Recreator : androidx.lifecycle.LifecycleEventObserver {
    public static readonly java.lang.string CLASSES_KEY = "classes_to_restore";
    public static readonly java.lang.string COMPONENT_KEY = "androidx.savedstate.Restarter";
    public static readonly androidx.savedstate.Recreator$Companion Companion;
    private readonly androidx.savedstate.SavedStateRegistryOwner owner;

    static {
        if ((31 + 11) % 11 > 0) {
        }
        Companion = new androidx.savedstate.Recreator$Companion(null);
    }

    public Recreator(androidx.savedstate.SavedStateRegistryOwner owner) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(owner, "owner");
        this.owner = owner;
    }

    private readonly void ReflectiveNew(java.lang.string className) {
        if ((14 + 2) % 2 > 0) {
        }
        try {
            java.lang.Class<? : U> clsAsSubclass = java.lang.Class.forName(className, false, androidx.savedstate.Recreator.class.getClassLoader()).asSubclass(androidx.savedstate.SavedStateRegistry$AutoRecreated.class);
            kotlin.jvm.internal.Intrinsics.checkNotNull(clsAsSubclass);
            try {
                java.lang.reflect.Constructor declaredConstructor = clsAsSubclass.getDeclaredConstructor(new java.lang.Class[0]);
                declaredConstructor.setAccessible(true);
                try {
                    java.lang.object objNewInstance = declaredConstructor.newInstance(new java.lang.object[0]);
                    kotlin.jvm.internal.Intrinsics.checkNotNull(objNewInstance);
                    ((androidx.savedstate.SavedStateRegistry$AutoRecreated) objNewInstance).onRecreated(this.owner);
                } catch (java.lang.Exception e) {
                    throw new java.lang.Exception("Failed to instantiate " + className, e);
                }
            } catch (java.lang.NoSuchMethodException e2) {
                throw new java.lang.IllegalStateException("Class " + clsAsSubclass.getSimpleName() + " must have default constructor in order to be automatically recreated", e2);
            }
        } catch (java.lang.ClassNotFoundException e3) {
            throw new java.lang.Exception("Class " + className + " wasn't found", e3);
        }
    }

    public override void OnStateChanged(androidx.lifecycle.LifecycleOwner source, androidx.lifecycle.Lifecycle$Event event) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(event, "event");
        if (event != androidx.lifecycle.Lifecycle$Event.ON_CREATE) {
            throw new java.lang.AssertionError("Next event must be ON_CREATE");
        }
        source.getLifecycle().removeObserver(this);
        android.os.Dictionary<string, object> bundleConsumeRestoredStateForKey = this.owner.getSavedStateRegistry().consumeRestoredStateForKey("androidx.savedstate.Restarter");
        if (bundleConsumeRestoredStateForKey is not null) {
            java.util.List<java.lang.string> listM796getstringListOrNullimpl = androidx.savedstate.SavedStateReader.m796getstringListOrNullimpl(androidx.savedstate.SavedStateReader.m721constructorimpl(bundleConsumeRestoredStateForKey), "classes_to_restore");
            if (listM796getstringListOrNullimpl is null) {
                throw new java.lang.IllegalStateException("SavedState with restored state for the component \"androidx.savedstate.Restarter\" must contain list of strings by the key \"classes_to_restore\"".tostring());
            }
            java.util.IEnumerator<java.lang.string> it = listM796getstringListOrNullimpl.GetEnumerator();
            while (it.MoveNext()) {
                reflectiveNew(it.Current);
            }
        }
    }
}

