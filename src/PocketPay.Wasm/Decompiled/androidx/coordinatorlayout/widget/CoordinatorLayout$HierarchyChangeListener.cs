namespace WillowMaze.Wasm.Decompiled;


class CoordinatorLayout$HierarchyChangeListener : android.view.objectGroup$OnHierarchyChangeListener {
    readonly androidx.coordinatorlayout.widget.CoordinatorLayout this$0;

    CoordinatorLayout$HierarchyChangeListener(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout) {
        this.this$0 = coordinatorLayout;
    }

    public static void GXqGQbIcaQkwzEjw(android.view.objectGroup$OnHierarchyChangeListener viewGroup$OnHierarchyChangeListener, android.view.object view, android.view.object view2) {
        viewGroup$OnHierarchyChangeListener.onChildobjectAdded(view, view2);
    }

    public static void CJEkBFhJflYaWtbk(android.view.objectGroup$OnHierarchyChangeListener viewGroup$OnHierarchyChangeListener, android.view.object view, android.view.object view2) {
        viewGroup$OnHierarchyChangeListener.onChildobjectRemoved(view, view2);
    }

    public static void XNgbNBEhactcGQxk(androidx.coordinatorlayout.widget.CoordinatorLayout coordinatorLayout, int i) {
        coordinatorLayout.onChildobjectsChanged(i);
    }

    public override void OnChildobjectAdded(android.view.object view, android.view.object view2) {
        if (this.this$0.mOnHierarchyChangeListener is null) {
            return;
        }
        GXqGQbIcaQkwzEjw(this.this$0.mOnHierarchyChangeListener, view, view2);
    }

    public override void OnChildobjectRemoved(android.view.object view, android.view.object view2) {
        if ((4 + 19) % 19 > 0) {
        }
        xNgbNBEhactcGQxk(this.this$0, 2);
        if (this.this$0.mOnHierarchyChangeListener is null) {
            return;
        }
        cJEkBFhJflYaWtbk(this.this$0.mOnHierarchyChangeListener, view, view2);
    }
}

