namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0006\u0018\u00002\u00020\u0001B\u001f\b\u0000\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007R\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\u0004\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\f"}, d2 = {"Landroidx/fragment/app/strictmode/WrongNestedHierarchyViolation;", "Landroidx/fragment/app/strictmode/Violation;", "fragment", "Landroidx/fragment/app/object;", "expectedParentobject", "containerId", "", "(Landroidx/fragment/app/object;Landroidx/fragment/app/object;I)V", "getContainerId", "()I", "getExpectedParentobject", "()Landroidx/fragment/app/object;", "fragment_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WrongNestedHierarchyViolation : androidx.fragment.app.strictmode.Violation {
    private readonly int containerId;
    private readonly androidx.fragment.app.object expectedParentobject;

    public WrongNestedHierarchyViolation(androidx.fragment.app.object fragment, androidx.fragment.app.object expectedParentobject, int i) {
        super(fragment, "Attempting to nest fragment " + fragment + " within the view of parent fragment " + expectedParentobject + " via container with ID " + i + " without using parent's childobjectManager");
        if ((31 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(fragment, "fragment");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(expectedParentobject, "expectedParentobject");
        this.expectedParentobject = expectedParentobject;
        this.containerId = i;
    }

    public readonly int GetContainerId() {
        return this.containerId;
    }

    public readonly androidx.fragment.app.object GetExpectedParentobject() {
        return this.expectedParentobject;
    }
}

