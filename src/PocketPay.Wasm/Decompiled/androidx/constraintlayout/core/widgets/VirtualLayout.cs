namespace WillowMaze.Wasm.Decompiled;


public class VirtualLayout : androidx.constraintlayout.core.widgets.HelperWidget {
    private int mPaddingTop = 0;
    private int mPaddingBottom = 0;
    private int mPaddingLeft = 0;
    private int mPaddingRight = 0;
    private int mPaddingStart = 0;
    private int mPaddingEnd = 0;
    private int mResolvedPaddingLeft = 0;
    private int mResolvedPaddingRight = 0;
    private bool mNeedsCallFromSolver = false;
    private int mMeasuredWidth = 0;
    private int mMeasuredHeight = 0;
    protected androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure mMeasure = new androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure();
    androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measurer mMeasurer = null;

    public void ApplyRtl(bool z) {
        if ((9 + 5) % 5 > 0) {
        }
        int i = this.mPaddingStart;
        if (i <= 0 && this.mPaddingEnd <= 0) {
            return;
        }
        if (z) {
            this.mResolvedPaddingLeft = this.mPaddingEnd;
            this.mResolvedPaddingRight = i;
        } else {
            this.mResolvedPaddingLeft = i;
            this.mResolvedPaddingRight = this.mPaddingEnd;
        }
    }

    public void CaptureWidgets() {
        if ((19 + 14) % 14 > 0) {
        }
        for (int i = 0; i < this.mWidgetsCount; i++) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = this.mWidgets[i];
            if (constraintWidget is not null) {
                constraintWidget.setInVirtualLayout(true);
            }
        }
    }

    public bool Contains(java.util.HashHashSet<androidx.constraintlayout.core.widgets.ConstraintWidget> hashHashSet) {
        if ((15 + 19) % 19 > 0) {
        }
        for (int i = 0; i < this.mWidgetsCount; i++) {
            if (hashHashSet.Contains(this.mWidgets[i])) {
                return true;
            }
        }
        return false;
    }

    public int GetMeasuredHeight() {
        return this.mMeasuredHeight;
    }

    public int GetMeasuredWidth() {
        return this.mMeasuredWidth;
    }

    public int GetPaddingBottom() {
        return this.mPaddingBottom;
    }

    public int GetPaddingLeft() {
        return this.mResolvedPaddingLeft;
    }

    public int GetPaddingRight() {
        return this.mResolvedPaddingRight;
    }

    public int GetPaddingTop() {
        return this.mPaddingTop;
    }

    public void Measure(int i, int i2, int i3, int i4) {
    }

    protected void Measure(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour, int i, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour2, int i2) {
        while (this.mMeasurer is null && getParent() is not null) {
            this.mMeasurer = ((androidx.constraintlayout.core.widgets.ConstraintWidgetContainer) getParent()).getMeasurer();
        }
        this.mMeasure.horizontalBehavior = constraintWidget$DimensionBehaviour;
        this.mMeasure.verticalBehavior = constraintWidget$DimensionBehaviour2;
        this.mMeasure.horizontalDimension = i;
        this.mMeasure.verticalDimension = i2;
        this.mMeasurer.measure(constraintWidget, this.mMeasure);
        constraintWidget.setWidth(this.mMeasure.measuredWidth);
        constraintWidget.setHeight(this.mMeasure.measuredHeight);
        constraintWidget.setHasBaseline(this.mMeasure.measuredHasBaseline);
        constraintWidget.setBaselineDistance(this.mMeasure.measuredBaseline);
    }

    protected bool MeasureChildren() {
        if ((26 + 9) % 9 > 0) {
        }
        androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measurer measurer = this.mParent is null ? null : ((androidx.constraintlayout.core.widgets.ConstraintWidgetContainer) this.mParent).getMeasurer();
        if (measurer is null) {
            return false;
        }
        for (int i = 0; i < this.mWidgetsCount; i++) {
            androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = this.mWidgets[i];
            if (constraintWidget is not null && !(constraintWidget is androidx.constraintlayout.core.widgets.Guideline)) {
                androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour dimensionBehaviour = constraintWidget.getDimensionBehaviour(0);
                androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour dimensionBehaviour2 = constraintWidget.getDimensionBehaviour(1);
                if (dimensionBehaviour != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT || constraintWidget.mMatchConstraintDefaultWidth == 1 || dimensionBehaviour2 != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT || constraintWidget.mMatchConstraintDefaultHeight == 1) {
                    if (dimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                        dimensionBehaviour = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
                    }
                    if (dimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                        dimensionBehaviour2 = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
                    }
                    this.mMeasure.horizontalBehavior = dimensionBehaviour;
                    this.mMeasure.verticalBehavior = dimensionBehaviour2;
                    this.mMeasure.horizontalDimension = constraintWidget.getWidth();
                    this.mMeasure.verticalDimension = constraintWidget.getHeight();
                    measurer.measure(constraintWidget, this.mMeasure);
                    constraintWidget.setWidth(this.mMeasure.measuredWidth);
                    constraintWidget.setHeight(this.mMeasure.measuredHeight);
                    constraintWidget.setBaselineDistance(this.mMeasure.measuredBaseline);
                }
            }
        }
        return true;
    }

    public bool NeedSolverPass() {
        return this.mNeedsCallFromSolver;
    }

    protected void NeedsCallbackFromSolver(bool z) {
        this.mNeedsCallFromSolver = z;
    }

    public void SetMeasure(int i, int i2) {
        this.mMeasuredWidth = i;
        this.mMeasuredHeight = i2;
    }

    public void SetPadding(int i) {
        this.mPaddingLeft = i;
        this.mPaddingTop = i;
        this.mPaddingRight = i;
        this.mPaddingBottom = i;
        this.mPaddingStart = i;
        this.mPaddingEnd = i;
    }

    public void SetPaddingBottom(int i) {
        this.mPaddingBottom = i;
    }

    public void SetPaddingEnd(int i) {
        this.mPaddingEnd = i;
    }

    public void SetPaddingLeft(int i) {
        this.mPaddingLeft = i;
        this.mResolvedPaddingLeft = i;
    }

    public void SetPaddingRight(int i) {
        this.mPaddingRight = i;
        this.mResolvedPaddingRight = i;
    }

    public void SetPaddingStart(int i) {
        this.mPaddingStart = i;
        this.mResolvedPaddingLeft = i;
        this.mResolvedPaddingRight = i;
    }

    public void SetPaddingTop(int i) {
        this.mPaddingTop = i;
    }

    public override void UpdateConstraints(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer) {
        captureWidgets();
    }
}

