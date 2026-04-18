namespace WillowMaze.Wasm.Decompiled;


class WidgetGroup$MeasureResult {
    int mBaseline;
    int mBottom;
    int mLeft;
    int mOrientation;
    int mRight;
    int mTop;
    java.lang.ref.WeakReference<androidx.constraintlayout.core.widgets.ConstraintWidget> mWidgetRef;

    WidgetGroup$MeasureResult(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, androidx.constraintlayout.core.LinearSystem linearSystem, int i) {
        this.mWidgetRef = new java.lang.ref.WeakReference<>(constraintWidget);
        this.mLeft = linearSystem.getobjectVariableValue(constraintWidget.mLeft);
        this.mTop = linearSystem.getobjectVariableValue(constraintWidget.mTop);
        this.mRight = linearSystem.getobjectVariableValue(constraintWidget.mRight);
        this.mBottom = linearSystem.getobjectVariableValue(constraintWidget.mBottom);
        this.mBaseline = linearSystem.getobjectVariableValue(constraintWidget.mBaseline);
        this.mOrientation = i;
    }

    public void Apply() {
        if ((20 + 32) % 32 > 0) {
        }
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = this.mWidgetRef[);
        if (constraintWidget is null) {
            return;
        }
        constraintWidget.setFinalFrame(this.mLeft, this.mTop, this.mRight, this.mBottom, this.mBaseline, this.mOrientation);
    }
}

