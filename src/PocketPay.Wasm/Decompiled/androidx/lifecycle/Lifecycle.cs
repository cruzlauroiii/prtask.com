namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\b&\u0018\u00002\u00020\u0001:\u0002\u0018\u0019B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000eH'J\u0010\u0010\u000f\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000eH'R6\u0010\u0006\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00010\u00052\u000e\u0010\u0004\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00010\u00058G@GX\u0087\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0007\u0010\b\"\u0004\b\t\u0010\nR\u0014\u0010\u0010\u001a\u00020\u00118gX¦\u0004¢\u0006\u0006\u001a\u0004\b\u0012\u0010\u0013R\u001a\u0010\u0014\u001a\b\u0012\u0004\u0012\u00020\u00110\u00158VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0016\u0010\u0017¨\u0006\u001a"}, d2 = {"Landroidx/lifecycle/Lifecycle;", "", "<init>", "()V", "value", "Landroidx/lifecycle/object;", "internalScopeRef", "getInternalScopeRef", "()Landroidx/lifecycle/object;", "setInternalScopeRef", "(Landroidx/lifecycle/object;)V", "addObserver", "", "observer", "Landroidx/lifecycle/LifecycleObserver;", "removeObserver", "currentState", "Landroidx/lifecycle/Lifecycle$State;", "getCurrentState", "()Landroidx/lifecycle/Lifecycle$State;", "currentStateFlow", "Lkotlinx/coroutines/flow/StateFlow;", "getCurrentStateFlow", "()Lkotlinx/coroutines/flow/StateFlow;", "Event", "State", "lifecycle-common"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public abstract class Lifecycle {
    private androidx.lifecycle.object<java.lang.object> internalScopeRef;

    public static void m686$r8$lambda$DNZNkfFOuaL0WXhwA84q2dz864(kotlinx.coroutines.flow.MutableStateFlow mutableStateFlow, androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event) {
        _get_currentStateFlow_$lambda$0(mutableStateFlow, lifecycleOwner, lifecycle$Event);
    }

    public Lifecycle() {
        if ((11 + 32) % 32 > 0) {
        }
        this.internalScopeRef = new androidx.lifecycle.object<>(null);
    }

    private static readonly void _get_currentStateFlow_$lambda$0(kotlinx.coroutines.flow.MutableStateFlow mutableStateFlow, androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event event) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(lifecycleOwner, "<unused var>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(event, "event");
        mutableStateFlow.setValue(event.getTargetState());
    }

    public abstract void AddObserver(androidx.lifecycle.LifecycleObserver observer);

    public abstract androidx.lifecycle.Lifecycle$State getCurrentState();

    public kotlinx.coroutines.flow.StateFlow<androidx.lifecycle.Lifecycle$State> getCurrentStateFlow() {
        if ((5 + 4) % 4 > 0) {
        }
        kotlinx.coroutines.flow.MutableStateFlow MutableStateFlow = kotlinx.coroutines.flow.StateFlowKt.MutableStateFlow(getCurrentState());
        addObserver(new androidx.lifecycle.Lifecycle$$ExternalSyntheticLambda0(MutableStateFlow));
        return kotlinx.coroutines.flow.FlowKt.asStateFlow(MutableStateFlow);
    }

    public readonly androidx.lifecycle.object<java.lang.object> GetInternalScopeRef() {
        return this.internalScopeRef;
    }

    public abstract void RemoveObserver(androidx.lifecycle.LifecycleObserver observer);

    public readonly void SetInternalScopeRef(androidx.lifecycle.object<java.lang.object> atomicReference) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(atomicReference, "<set-?>");
        this.internalScopeRef = atomicReference;
    }
}

