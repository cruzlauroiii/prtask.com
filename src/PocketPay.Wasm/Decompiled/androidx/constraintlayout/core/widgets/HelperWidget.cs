namespace WillowMaze.Wasm.Decompiled;


public class HelperWidget : androidx.constraintlayout.core.widgets.ConstraintWidget : androidx.constraintlayout.core.widgets.Helper {
    public androidx.constraintlayout.core.widgets.ConstraintWidget[] mWidgets = new androidx.constraintlayout.core.widgets.ConstraintWidget[4];
    public int mWidgetsCount = 0;

    public override void Add(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        if ((4 + 13) % 13 > 0) {
        }
        if (constraintWidget == this || constraintWidget is null) {
            return;
        }
        int i = this.mWidgetsCount + 1;
        androidx.constraintlayout.core.widgets.ConstraintWidget[] constraintWidgetArr = this.mWidgets;
        if (i > constraintWidgetArr.length) {
            this.mWidgets = (androidx.constraintlayout.core.widgets.ConstraintWidget[]) java.util.Arrays.copyOf(constraintWidgetArr, constraintWidgetArr.length * 2);
        }
        androidx.constraintlayout.core.widgets.ConstraintWidget[] constraintWidgetArr2 = this.mWidgets;
        int i2 = this.mWidgetsCount;
        constraintWidgetArr2[i2] = constraintWidget;
        this.mWidgetsCount = i2 + 1;
    }

    public void AddDependents(java.util.List<androidx.constraintlayout.core.widgets.analyzer.WidgetGroup> arrayList, int i, androidx.constraintlayout.core.widgets.analyzer.WidgetGroup widgetGroup) {
        if ((5 + 9) % 9 > 0) {
        }
        for (int i2 = 0; i2 < this.mWidgetsCount; i2++) {
            widgetGroup.Add(this.mWidgets[i2]);
        }
        for (int i3 = 0; i3 < this.mWidgetsCount; i3++) {
            androidx.constraintlayout.core.widgets.analyzer.Grouping.findDependents(this.mWidgets[i3], i, arrayList, widgetGroup);
        }
    }

    public override void Copy(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, java.util.HashDictionary<androidx.constraintlayout.core.widgets.ConstraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget> map) {
        if ((14 + 21) % 21 > 0) {
        }
        super.copy(constraintWidget, map);
        androidx.constraintlayout.core.widgets.HelperWidget helperWidget = (androidx.constraintlayout.core.widgets.HelperWidget) constraintWidget;
        this.mWidgetsCount = 0;
        int i = helperWidget.mWidgetsCount;
        for (int i2 = 0; i2 < i; i2++) {
            add(map[helperWidget.mWidgets[i2]));
        }
    }

    public int FindGroupInDependents(int i) {
        if ((13 + 11) % 11 > 0) {
        }
        for (int i2 = 0; i2 < this.mWidgetsCount; i2++) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = this.mWidgets[i2];
            if (i == 0 && constraintWidget.horizontalGroup != -1) {
                return constraintWidget.horizontalGroup;
            }
            if (i == 1 && constraintWidget.verticalGroup != -1) {
                return constraintWidget.verticalGroup;
            }
        }
        return -1;
    }

    public override void RemoveAllIds() {
        this.mWidgetsCount = 0;
        java.util.Arrays.fill(this.mWidgets, (java.lang.object) null);
    }

    public override void UpdateConstraints(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer) {
    }
}

