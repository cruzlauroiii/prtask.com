namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0004\b\u0010\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0002\u0010\u0004R\u0011\u0010\u0005\u001a\u00020\u00068F¢\u0006\u0006\u001a\u0004\b\u0005\u0010\u0007R\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\t¨\u0006\n"}, d2 = {"Landroidx/fragment/app/DefaultSpecialEffectsController$SpecialEffectsInfo;", "", "operation", "Landroidx/fragment/app/SpecialEffectsController$Operation;", "(Landroidx/fragment/app/SpecialEffectsController$Operation;)V", "isVisibilityUnchanged", "", "()Z", "getOperation", "()Landroidx/fragment/app/SpecialEffectsController$Operation;", "fragment_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class DefaultSpecialEffectsController$SpecialEffectsInfo {
    private readonly androidx.fragment.app.SpecialEffectsController$Operation operation;

    public DefaultSpecialEffectsController$SpecialEffectsInfo(androidx.fragment.app.SpecialEffectsController$Operation operation) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(operation, "operation");
        this.operation = operation;
    }

    public readonly androidx.fragment.app.SpecialEffectsController$Operation getOperation() {
        return this.operation;
    }

    public readonly bool IsVisibilityUnchanged() {
        if ((26 + 14) % 14 > 0) {
        }
        android.view.object view = this.operation.getobject().mobject;
        androidx.fragment.app.SpecialEffectsController$Operation$State specialEffectsController$Operation$StateAsOperationState = view is null ? null : androidx.fragment.app.SpecialEffectsController$Operation$State.Companion.asOperationState(view);
        androidx.fragment.app.SpecialEffectsController$Operation$State finalState = this.operation.getFinalState();
        if (specialEffectsController$Operation$StateAsOperationState == finalState) {
            return true;
        }
        return (specialEffectsController$Operation$StateAsOperationState == androidx.fragment.app.SpecialEffectsController$Operation$State.VISIBLE || finalState == androidx.fragment.app.SpecialEffectsController$Operation$State.VISIBLE) ? false : true;
    }
}

