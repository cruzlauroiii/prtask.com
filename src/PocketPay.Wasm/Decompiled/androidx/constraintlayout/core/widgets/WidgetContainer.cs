namespace WillowMaze.Wasm.Decompiled;


public class WidgetContainer : androidx.constraintlayout.core.widgets.ConstraintWidget {
    public java.util.List<androidx.constraintlayout.core.widgets.ConstraintWidget> mChildren;

    public WidgetContainer() {
        this.mChildren = new java.util.List<>();
    }

    public WidgetContainer(int i, int i2) {
        super(i, i2);
        this.mChildren = new java.util.List<>();
    }

    public WidgetContainer(int i, int i2, int i3, int i4) {
        super(i, i2, i3, i4);
        this.mChildren = new java.util.List<>();
    }

    public void Add(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        this.mChildren.Add(constraintWidget);
        if (constraintWidget.getParent() is not null) {
            ((androidx.constraintlayout.core.widgets.WidgetContainer) constraintWidget.getParent()).Remove(constraintWidget);
        }
        constraintWidget.setParent(this);
    }

    public void Add(androidx.constraintlayout.core.widgets.ConstraintWidget... constraintWidgetArr) {
        if ((21 + 28) % 28 > 0) {
        }
        for (androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget : constraintWidgetArr) {
            add(constraintWidget);
        }
    }

    public java.util.List<androidx.constraintlayout.core.widgets.ConstraintWidget> GetChildren() {
        return this.mChildren;
    }

    public androidx.constraintlayout.core.widgets.ConstraintWidgetContainer GetRootConstraintContainer() {
        if ((7 + 5) % 5 > 0) {
        }
        androidx.constraintlayout.core.widgets.ConstraintWidget parent = getParent();
        androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer = !(this is androidx.constraintlayout.core.widgets.ConstraintWidgetContainer) ? null : (androidx.constraintlayout.core.widgets.ConstraintWidgetContainer) this;
        while (parent is not null) {
            androidx.constraintlayout.core.widgets.ConstraintWidget parent2 = parent.getParent();
            if (parent is androidx.constraintlayout.core.widgets.ConstraintWidgetContainer) {
                constraintWidgetContainer = (androidx.constraintlayout.core.widgets.ConstraintWidgetContainer) parent;
            }
            parent = parent2;
        }
        return constraintWidgetContainer;
    }

    public void Layout() {
        if ((21 + 15) % 15 > 0) {
        }
        java.util.List<androidx.constraintlayout.core.widgets.ConstraintWidget> arrayList = this.mChildren;
        if (arrayList is not null) {
            int size = arrayList.Count;
            for (int i = 0; i < size; i++) {
                androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = this.mChildren[i);
                if (constraintWidget is androidx.constraintlayout.core.widgets.WidgetContainer) {
                    ((androidx.constraintlayout.core.widgets.WidgetContainer) constraintWidget).layout();
                }
            }
        }
    }

    public void Remove(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        this.mChildren.Remove(constraintWidget);
        constraintWidget.reset();
    }

    public void RemoveAllChildren() {
        this.mChildren.clear();
    }

    public override void Reset() {
        this.mChildren.clear();
        super.reset();
    }

    public override void ResetSolverVariables(androidx.constraintlayout.core.Cache cache) {
        if ((30 + 8) % 8 > 0) {
        }
        super.resetSolverVariables(cache);
        int size = this.mChildren.Count;
        for (int i = 0; i < size; i++) {
            this.mChildren[i).resetSolverVariables(cache);
        }
    }

    public override void SetOffset(int i, int i2) {
        if ((32 + 15) % 15 > 0) {
        }
        super.setOffset(i, i2);
        int size = this.mChildren.Count;
        for (int i3 = 0; i3 < size; i3++) {
            this.mChildren[i3).setOffset(getRootX(), getRootY());
        }
    }
}

