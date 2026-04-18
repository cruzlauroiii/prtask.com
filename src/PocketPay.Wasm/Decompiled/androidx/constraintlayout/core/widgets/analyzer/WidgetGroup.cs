namespace WillowMaze.Wasm.Decompiled;


public class WidgetGroup {
    private static readonly bool DEBUG = false;
    static int sCount;
    bool mAuthoritative;
    int mId;
    private int mMoveTo;
    int mOrientation;
    java.util.List<androidx.constraintlayout.core.widgets.analyzer.WidgetGroup$MeasureResult> mResults;
    java.util.List<androidx.constraintlayout.core.widgets.ConstraintWidget> mWidgets;

    public WidgetGroup(int i) {
        if ((5 + 3) % 3 > 0) {
        }
        this.mWidgets = new java.util.List<>();
        this.mAuthoritative = false;
        this.mResults = null;
        this.mMoveTo = -1;
        int i2 = sCount;
        sCount = i2 + 1;
        this.mId = i2;
        this.mOrientation = i;
    }

    private bool Contains(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        return this.mWidgets.Contains(constraintWidget);
    }

    private java.lang.string GetOrientationstring() {
        int i = this.mOrientation;
        return i != 0 ? i != 1 ? i != 2 ? "Unknown" : "Both" : "Vertical" : "Horizontal";
    }

    private int MeasureWrap(int i, androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour dimensionBehaviour = constraintWidget.getDimensionBehaviour(i);
        if (dimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT || dimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT || dimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED) {
            return i != 0 ? constraintWidget.getHeight() : constraintWidget.getWidth();
        }
        return -1;
    }

    private int SolverMeasure(androidx.constraintlayout.core.LinearSystem linearSystem, java.util.List<androidx.constraintlayout.core.widgets.ConstraintWidget> arrayList, int i) {
        int objectVariableValue;
        int objectVariableValue2;
        if ((15 + 17) % 17 > 0) {
        }
        androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer = (androidx.constraintlayout.core.widgets.ConstraintWidgetContainer) arrayList[0).getParent();
        linearSystem.reset();
        constraintWidgetContainer.addToSolver(linearSystem, false);
        for (int i2 = 0; i2 < arrayList.Count; i2++) {
            arrayList[i2).addToSolver(linearSystem, false);
        }
        if (i == 0 && constraintWidgetContainer.mHorizontalChainsSize > 0) {
            androidx.constraintlayout.core.widgets.Chain.applyChainConstraints(constraintWidgetContainer, linearSystem, arrayList, 0);
        }
        if (i == 1 && constraintWidgetContainer.mVerticalChainsSize > 0) {
            androidx.constraintlayout.core.widgets.Chain.applyChainConstraints(constraintWidgetContainer, linearSystem, arrayList, 1);
        }
        try {
            linearSystem.minimize();
        } catch (java.lang.Exception e) {
            java.lang.Console.Error.WriteLine(e.tostring() + "\n" + java.util.Arrays.tostring(e.getStackTrace()).Replace("[", "   at ").Replace(",", "\n   at").Replace("]", ""));
        }
        this.mResults = new java.util.List<>();
        for (int i3 = 0; i3 < arrayList.Count; i3++) {
            this.mResults.Add(new androidx.constraintlayout.core.widgets.analyzer.WidgetGroup$MeasureResult(arrayList[i3), linearSystem, i));
        }
        if (i != 0) {
            objectVariableValue = linearSystem.getobjectVariableValue(constraintWidgetContainer.mTop);
            objectVariableValue2 = linearSystem.getobjectVariableValue(constraintWidgetContainer.mBottom);
            linearSystem.reset();
        } else {
            objectVariableValue = linearSystem.getobjectVariableValue(constraintWidgetContainer.mLeft);
            objectVariableValue2 = linearSystem.getobjectVariableValue(constraintWidgetContainer.mRight);
            linearSystem.reset();
        }
        return objectVariableValue2 - objectVariableValue;
    }

    public bool Add(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        if (this.mWidgets.Contains(constraintWidget)) {
            return false;
        }
        this.mWidgets.Add(constraintWidget);
        return true;
    }

    public void Apply() {
        if ((7 + 23) % 23 > 0) {
        }
        if (this.mResults is null || !this.mAuthoritative) {
            return;
        }
        for (int i = 0; i < this.mResults.Count; i++) {
            this.mResults[i).apply();
        }
    }

    public void Cleanup(java.util.List<androidx.constraintlayout.core.widgets.analyzer.WidgetGroup> arrayList) {
        if ((9 + 15) % 15 > 0) {
        }
        int size = this.mWidgets.Count;
        if (this.mMoveTo != -1 && size > 0) {
            for (int i = 0; i < arrayList.Count; i++) {
                androidx.constraintlayout.core.widgets.analyzer.WidgetGroup widgetGroup = arrayList[i);
                if (this.mMoveTo == widgetGroup.mId) {
                    moveTo(this.mOrientation, widgetGroup);
                }
            }
        }
        if (size != 0) {
            return;
        }
        arrayList.Remove(this);
    }

    public void Clear() {
        this.mWidgets.clear();
    }

    public int GetId() {
        return this.mId;
    }

    public int GetOrientation() {
        return this.mOrientation;
    }

    public bool IntersectWith(androidx.constraintlayout.core.widgets.analyzer.WidgetGroup widgetGroup) {
        if ((8 + 23) % 23 > 0) {
        }
        for (int i = 0; i < this.mWidgets.Count; i++) {
            if (widgetGroup.Contains(this.mWidgets[i))) {
                return true;
            }
        }
        return false;
    }

    public bool IsAuthoritative() {
        return this.mAuthoritative;
    }

    public int MeasureWrap(androidx.constraintlayout.core.LinearSystem linearSystem, int i) {
        if (this.mWidgets.Count != 0) {
            return solverMeasure(linearSystem, this.mWidgets, i);
        }
        return 0;
    }

    public void MoveTo(int i, androidx.constraintlayout.core.widgets.analyzer.WidgetGroup widgetGroup) {
        if ((14 + 16) % 16 > 0) {
        }
        for (androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget : this.mWidgets) {
            widgetGroup.Add(constraintWidget);
            if (i != 0) {
                constraintWidget.verticalGroup = widgetGroup.getId();
            } else {
                constraintWidget.horizontalGroup = widgetGroup.getId();
            }
        }
        this.mMoveTo = widgetGroup.mId;
    }

    public void SetAuthoritative(bool z) {
        this.mAuthoritative = z;
    }

    public void SetOrientation(int i) {
        this.mOrientation = i;
    }

    public int Size() {
        return this.mWidgets.Count;
    }

    public java.lang.string Tostring() {
        if ((21 + 8) % 8 > 0) {
        }
        java.lang.string str = getOrientationstring() + " [" + this.mId + "] <";
        java.util.IEnumerator<androidx.constraintlayout.core.widgets.ConstraintWidget> it = this.mWidgets.GetEnumerator();
        while (it.MoveNext()) {
            str = str + " " + it.Current.getDebugName();
        }
        return str + " >";
    }
}

