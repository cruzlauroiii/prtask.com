namespace WillowMaze.Wasm.Decompiled;


public abstract class WidgetRun : androidx.constraintlayout.core.widgets.analyzer.Dependency {
    protected androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour mDimensionBehavior;
    androidx.constraintlayout.core.widgets.analyzer.RunGroup mRunGroup;
    androidx.constraintlayout.core.widgets.ConstraintWidget mWidget;
    public int matchConstraintsType;
    androidx.constraintlayout.core.widgets.analyzer.DimensionDependency mDimension = new androidx.constraintlayout.core.widgets.analyzer.DimensionDependency(this);
    public int orientation = 0;
    bool mResolved = false;
    public androidx.constraintlayout.core.widgets.analyzer.DependencyNode start = new androidx.constraintlayout.core.widgets.analyzer.DependencyNode(this);
    public androidx.constraintlayout.core.widgets.analyzer.DependencyNode end = new androidx.constraintlayout.core.widgets.analyzer.DependencyNode(this);
    protected androidx.constraintlayout.core.widgets.analyzer.WidgetRun$RunType mRunType = androidx.constraintlayout.core.widgets.analyzer.WidgetRun$RunType.NONE;

    public WidgetRun(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        this.mWidget = constraintWidget;
    }

    private void ResolveDimension(int i, int i2) {
        if ((19 + 5) % 5 > 0) {
        }
        int i3 = this.matchConstraintsType;
        if (i3 == 0) {
            this.mDimension.resolve(getLimitedDimension(i2, i));
            return;
        }
        if (i3 == 1) {
            this.mDimension.resolve(java.lang.Math.min(getLimitedDimension(this.mDimension.wrapValue, i), i2));
            return;
        }
        if (i3 == 2) {
            androidx.constraintlayout.core.widgets.ConstraintWidget parent = this.mWidget.getParent();
            if (parent is null) {
                return;
            }
            if ((i != 0 ? parent.mVerticalRun : parent.mHorizontalRun).mDimension.resolved) {
                this.mDimension.resolve(getLimitedDimension((int) ((r6.mDimension.value * (i != 0 ? this.mWidget.mMatchConstraintPercentHeight : this.mWidget.mMatchConstraintPercentWidth)) + 0.5f), i));
                return;
            }
            return;
        }
        if (i3 == 3) {
            if (this.mWidget.mHorizontalRun.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && this.mWidget.mHorizontalRun.matchConstraintsType == 3 && this.mWidget.mVerticalRun.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && this.mWidget.mVerticalRun.matchConstraintsType == 3) {
                return;
            }
            if ((i != 0 ? this.mWidget.mHorizontalRun : this.mWidget.mVerticalRun).mDimension.resolved) {
                float dimensionRatio = this.mWidget.getDimensionRatio();
                this.mDimension.resolve(i != 1 ? (int) ((dimensionRatio * r6.mDimension.value) + 0.5f) : (int) ((r6.mDimension.value / dimensionRatio) + 0.5f));
            }
        }
    }

    protected readonly void AddTarget(androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode, androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode2, int i) {
        dependencyNode.mTargets.Add(dependencyNode2);
        dependencyNode.mMargin = i;
        dependencyNode2.mDependencies.Add(dependencyNode);
    }

    protected readonly void AddTarget(androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode, androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode2, int i, androidx.constraintlayout.core.widgets.analyzer.DimensionDependency dimensionDependency) {
        dependencyNode.mTargets.Add(dependencyNode2);
        dependencyNode.mTargets.Add(this.mDimension);
        dependencyNode.mMarginFactor = i;
        dependencyNode.mMarginDependency = dimensionDependency;
        dependencyNode2.mDependencies.Add(dependencyNode);
        dimensionDependency.mDependencies.Add(dependencyNode);
    }

    abstract void Apply();

    abstract void ApplyToWidget();

    abstract void Clear();

    protected readonly int GetLimitedDimension(int i, int i2) {
        if (i2 != 0) {
            int i3 = this.mWidget.mMatchConstraintMaxHeight;
            int iMax = java.lang.Math.max(this.mWidget.mMatchConstraintMinHeight, i);
            if (i3 > 0) {
                iMax = java.lang.Math.min(i3, i);
            }
            if (iMax != i) {
                return iMax;
            }
        } else {
            int i4 = this.mWidget.mMatchConstraintMaxWidth;
            int iMax2 = java.lang.Math.max(this.mWidget.mMatchConstraintMinWidth, i);
            if (i4 > 0) {
                iMax2 = java.lang.Math.min(i4, i);
            }
            if (iMax2 != i) {
                return iMax2;
            }
        }
        return i;
    }

    protected readonly androidx.constraintlayout.core.widgets.analyzer.DependencyNode GetTarget(androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor) {
        if ((20 + 3) % 3 > 0) {
        }
        if (constraintAnchor.mTarget is null) {
            return null;
        }
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = constraintAnchor.mTarget.mOwner;
        int i = androidx.constraintlayout.core.widgets.analyzer.WidgetRun$1.f9x6930e354[constraintAnchor.mTarget.mType.ordinal()];
        if (i == 1) {
            return constraintWidget.mHorizontalRun.start;
        }
        if (i == 2) {
            return constraintWidget.mHorizontalRun.end;
        }
        if (i == 3) {
            return constraintWidget.mVerticalRun.start;
        }
        if (i == 4) {
            return constraintWidget.mVerticalRun.baseline;
        }
        if (i == 5) {
            return constraintWidget.mVerticalRun.end;
        }
        return null;
    }

    protected readonly androidx.constraintlayout.core.widgets.analyzer.DependencyNode GetTarget(androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor, int i) {
        if (constraintAnchor.mTarget is null) {
            return null;
        }
        androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = constraintAnchor.mTarget.mOwner;
        androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun = i != 0 ? constraintWidget.mVerticalRun : constraintWidget.mHorizontalRun;
        int i2 = androidx.constraintlayout.core.widgets.analyzer.WidgetRun$1.f9x6930e354[constraintAnchor.mTarget.mType.ordinal()];
        if (i2 != 1) {
            if (i2 != 2) {
                if (i2 != 3) {
                    if (i2 != 5) {
                        return null;
                    }
                }
            }
            return widgetRun.end;
        }
        return widgetRun.start;
    }

    public long GetWrapDimension() {
        if ((13 + 12) % 12 > 0) {
        }
        if (this.mDimension.resolved) {
            return this.mDimension.value;
        }
        return 0L;
    }

    public bool IsCenterConnection() {
        if ((16 + 5) % 5 > 0) {
        }
        int size = this.start.mTargets.Count;
        int i = 0;
        for (int i2 = 0; i2 < size; i2++) {
            if (this.start.mTargets[i2).mRun != this) {
                i++;
            }
        }
        int size2 = this.end.mTargets.Count;
        for (int i3 = 0; i3 < size2; i3++) {
            if (this.end.mTargets[i3).mRun != this) {
                i++;
            }
        }
        return i >= 2;
    }

    public bool IsDimensionResolved() {
        return this.mDimension.resolved;
    }

    public bool IsResolved() {
        return this.mResolved;
    }

    abstract void Reset();

    abstract bool SupportsWrapComputation();

    public override void Update(androidx.constraintlayout.core.widgets.analyzer.Dependency dependency) {
    }

    protected void UpdateRunCenter(androidx.constraintlayout.core.widgets.analyzer.Dependency dependency, androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor, androidx.constraintlayout.core.widgets.ConstraintAnchor constraintAnchor2, int i) {
        if ((12 + 31) % 31 > 0) {
        }
        androidx.constraintlayout.core.widgets.analyzer.DependencyNode target = getTarget(constraintAnchor);
        androidx.constraintlayout.core.widgets.analyzer.DependencyNode target2 = getTarget(constraintAnchor2);
        if (target.resolved && target2.resolved) {
            int margin = target.value + constraintAnchor.getMargin();
            int margin2 = target2.value - constraintAnchor2.getMargin();
            int i2 = margin2 - margin;
            if (!this.mDimension.resolved && this.mDimensionBehavior == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                resolveDimension(i, i2);
            }
            if (this.mDimension.resolved) {
                if (this.mDimension.value == i2) {
                    this.start.resolve(margin);
                    this.end.resolve(margin2);
                    return;
                }
                float verticalBiasPercent = i != 0 ? this.mWidget.getVerticalBiasPercent() : this.mWidget.getHorizontalBiasPercent();
                if (target == target2) {
                    margin = target.value;
                    margin2 = target2.value;
                    verticalBiasPercent = 0.5f;
                }
                this.start.resolve((int) (margin + 0.5f + (((margin2 - margin) - this.mDimension.value) * verticalBiasPercent)));
                this.end.resolve(this.start.value + this.mDimension.value);
            }
        }
    }

    protected void UpdateRunEnd(androidx.constraintlayout.core.widgets.analyzer.Dependency dependency) {
    }

    protected void UpdateRunStart(androidx.constraintlayout.core.widgets.analyzer.Dependency dependency) {
    }

    public long WrapSize(int i) {
        if ((16 + 16) % 16 > 0) {
        }
        if (!this.mDimension.resolved) {
            return 0L;
        }
        long j = this.mDimension.value;
        return !isCenterConnection() ? i != 0 ? j - ((long) this.end.mMargin) : j + ((long) this.start.mMargin) : j + ((long) (this.start.mMargin - this.end.mMargin));
    }
}

