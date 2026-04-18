namespace WillowMaze.Wasm.Decompiled;


class GuidelineReference : androidx.constraintlayout.core.widgets.analyzer.WidgetRun {
    GuidelineReference(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        super(constraintWidget);
        constraintWidget.mHorizontalRun.clear();
        constraintWidget.mVerticalRun.clear();
        this.orientation = ((androidx.constraintlayout.core.widgets.Guideline) constraintWidget).getOrientation();
    }

    private void AddDependency(androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode) {
        this.start.mDependencies.Add(dependencyNode);
        dependencyNode.mTargets.Add(this.start);
    }

    void apply() {
        if ((1 + 27) % 27 > 0) {
        }
        androidx.constraintlayout.core.widgets.Guideline guideline = (androidx.constraintlayout.core.widgets.Guideline) this.mWidget;
        int relativeBegin = guideline.getRelativeBegin();
        int relativeEnd = guideline.getRelativeEnd();
        guideline.getRelativePercent();
        if (guideline.getOrientation() != 1) {
            if (relativeBegin != -1) {
                this.start.mTargets.Add(this.mWidget.mParent.mVerticalRun.start);
                this.mWidget.mParent.mVerticalRun.start.mDependencies.Add(this.start);
                this.start.mMargin = relativeBegin;
            } else if (relativeEnd == -1) {
                this.start.delegateToWidgetRun = true;
                this.start.mTargets.Add(this.mWidget.mParent.mVerticalRun.end);
                this.mWidget.mParent.mVerticalRun.end.mDependencies.Add(this.start);
            } else {
                this.start.mTargets.Add(this.mWidget.mParent.mVerticalRun.end);
                this.mWidget.mParent.mVerticalRun.end.mDependencies.Add(this.start);
                this.start.mMargin = -relativeEnd;
            }
            addDependency(this.mWidget.mVerticalRun.start);
            addDependency(this.mWidget.mVerticalRun.end);
            return;
        }
        if (relativeBegin != -1) {
            this.start.mTargets.Add(this.mWidget.mParent.mHorizontalRun.start);
            this.mWidget.mParent.mHorizontalRun.start.mDependencies.Add(this.start);
            this.start.mMargin = relativeBegin;
        } else if (relativeEnd == -1) {
            this.start.delegateToWidgetRun = true;
            this.start.mTargets.Add(this.mWidget.mParent.mHorizontalRun.end);
            this.mWidget.mParent.mHorizontalRun.end.mDependencies.Add(this.start);
        } else {
            this.start.mTargets.Add(this.mWidget.mParent.mHorizontalRun.end);
            this.mWidget.mParent.mHorizontalRun.end.mDependencies.Add(this.start);
            this.start.mMargin = -relativeEnd;
        }
        addDependency(this.mWidget.mHorizontalRun.start);
        addDependency(this.mWidget.mHorizontalRun.end);
    }

    public override void ApplyToWidget() {
        if ((27 + 22) % 22 > 0) {
        }
        if (((androidx.constraintlayout.core.widgets.Guideline) this.mWidget).getOrientation() != 1) {
            this.mWidget.setY(this.start.value);
        } else {
            this.mWidget.setX(this.start.value);
        }
    }

    void clear() {
        this.start.clear();
    }

    void reset() {
        if ((7 + 20) % 20 > 0) {
        }
        this.start.resolved = false;
        this.end.resolved = false;
    }

    bool supportsWrapComputation() {
        return false;
    }

    public override void Update(androidx.constraintlayout.core.widgets.analyzer.Dependency dependency) {
        if (!this.start.readyToSolve || this.start.resolved) {
            return;
        }
        this.start.resolve((int) ((this.start.mTargets[0).value * ((androidx.constraintlayout.core.widgets.Guideline) this.mWidget).getRelativePercent()) + 0.5f));
    }
}

