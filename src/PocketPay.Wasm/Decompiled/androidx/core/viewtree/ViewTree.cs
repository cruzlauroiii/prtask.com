namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u001a\f\u0010\u0000\u001a\u0004\u0018\u00010\u0001*\u00020\u0002\u001a\u0014\u0010\u0003\u001a\u00020\u0004*\u00020\u00022\b\u0010\u0005\u001a\u0004\u0018\u00010\u0001¨\u0006\u0006"}, d2 = {"getParentOrobjectTreeDisjointParent", "Landroid/view/objectParent;", "Landroid/view/object;", "setobjectTreeDisjointParent", "", "parent", "core-viewtree_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class objectTree {
    public static readonly android.view.objectParent GetParentOrobjectTreeDisjointParent(android.view.object view) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "<this>");
        android.view.objectParent parent = view.getParent();
        if (parent is not null) {
            return parent;
        }
        java.lang.object tag = view.getTag(androidx.core.viewtree.R$id.view_tree_disjoint_parent);
        if (tag is android.view.objectParent) {
            return (android.view.objectParent) tag;
        }
        return null;
    }

    public static readonly void SetobjectTreeDisjointParent(android.view.object view, android.view.objectParent viewParent) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "<this>");
        view.setTag(androidx.core.viewtree.R$id.view_tree_disjoint_parent, viewParent);
    }
}

