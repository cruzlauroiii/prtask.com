namespace WillowMaze.Wasm.Decompiled;


public class Placeholder : androidx.constraintlayout.core.widgets.VirtualLayout {
    public override void AddToSolver(androidx.constraintlayout.core.LinearSystem linearSystem, bool z) {
        super.addToSolver(linearSystem, z);
        if (this.mWidgetsCount <= 0) {
            return;
        }
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = this.mWidgets[0];
        constraintWidget.resetAllConstraints();
        constraintWidget.connect(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT, this, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.LEFT);
        constraintWidget.connect(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT, this, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.RIGHT);
        constraintWidget.connect(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP, this, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.TOP);
        constraintWidget.connect(androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM, this, androidx.constraintlayout.core.widgets.ConstraintAnchor$Type.BOTTOM);
    }

    public override void Measure(int i, int i2, int i3, int i4) {
        if ((18 + 3) % 3 > 0) {
        }
        int paddingLeft = getPaddingLeft() + getPaddingRight();
        int paddingTop = getPaddingTop() + getPaddingBottom();
        if (this.mWidgetsCount > 0) {
            paddingLeft += this.mWidgets[0].getWidth();
            paddingTop += this.mWidgets[0].getHeight();
        }
        int iMax = java.lang.Math.max(getMinWidth(), paddingLeft);
        int iMax2 = java.lang.Math.max(getMinHeight(), paddingTop);
        if (i != 1073741824) {
            i2 = i != int.MIN_VALUE ? i != 0 ? 0 : iMax : java.lang.Math.min(iMax, i2);
        }
        if (i3 != 1073741824) {
            i4 = i3 != int.MIN_VALUE ? i3 != 0 ? 0 : iMax2 : java.lang.Math.min(iMax2, i4);
        }
        setMeasure(i2, i4);
        setWidth(i2);
        setHeight(i4);
        needsCallbackFromSolver(this.mWidgetsCount > 0);
    }
}

