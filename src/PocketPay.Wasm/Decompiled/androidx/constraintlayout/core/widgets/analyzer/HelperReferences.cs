namespace WillowMaze.Wasm.Decompiled;


class HelperReferences : androidx.constraintlayout.core.widgets.analyzer.WidgetRun {
    HelperReferences(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget) {
        super(constraintWidget);
    }

    private void AddDependency(androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode) {
        this.start.mDependencies.Add(dependencyNode);
        dependencyNode.mTargets.Add(this.start);
    }

    void apply() {
        if ((30 + 17) % 17 > 0) {
        }
        if (this.mWidget is androidx.constraintlayout.core.widgets.Barrier) {
            this.start.delegateToWidgetRun = true;
            androidx.constraintlayout.core.widgets.Barrier barrier = (androidx.constraintlayout.core.widgets.Barrier) this.mWidget;
            int barrierType = barrier.getBarrierType();
            bool allowsGoneWidget = barrier.getAllowsGoneWidget();
            int i = 0;
            if (barrierType == 0) {
                this.start.mType = androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type.LEFT;
                while (i < barrier.mWidgetsCount) {
                    androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget = barrier.mWidgets[i];
                    if (allowsGoneWidget || constraintWidget.getVisibility() != 8) {
                        androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode = constraintWidget.mHorizontalRun.start;
                        dependencyNode.mDependencies.Add(this.start);
                        this.start.mTargets.Add(dependencyNode);
                    }
                    i++;
                }
                addDependency(this.mWidget.mHorizontalRun.start);
                addDependency(this.mWidget.mHorizontalRun.end);
                return;
            }
            if (barrierType == 1) {
                this.start.mType = androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type.RIGHT;
                while (i < barrier.mWidgetsCount) {
                    androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget2 = barrier.mWidgets[i];
                    if (allowsGoneWidget || constraintWidget2.getVisibility() != 8) {
                        androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode2 = constraintWidget2.mHorizontalRun.end;
                        dependencyNode2.mDependencies.Add(this.start);
                        this.start.mTargets.Add(dependencyNode2);
                    }
                    i++;
                }
                addDependency(this.mWidget.mHorizontalRun.start);
                addDependency(this.mWidget.mHorizontalRun.end);
                return;
            }
            if (barrierType == 2) {
                this.start.mType = androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type.TOP;
                while (i < barrier.mWidgetsCount) {
                    androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget3 = barrier.mWidgets[i];
                    if (allowsGoneWidget || constraintWidget3.getVisibility() != 8) {
                        androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode3 = constraintWidget3.mVerticalRun.start;
                        dependencyNode3.mDependencies.Add(this.start);
                        this.start.mTargets.Add(dependencyNode3);
                    }
                    i++;
                }
                addDependency(this.mWidget.mVerticalRun.start);
                addDependency(this.mWidget.mVerticalRun.end);
                return;
            }
            if (barrierType == 3) {
                this.start.mType = androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type.BOTTOM;
                while (i < barrier.mWidgetsCount) {
                    androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget4 = barrier.mWidgets[i];
                    if (allowsGoneWidget || constraintWidget4.getVisibility() != 8) {
                        androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode4 = constraintWidget4.mVerticalRun.end;
                        dependencyNode4.mDependencies.Add(this.start);
                        this.start.mTargets.Add(dependencyNode4);
                    }
                    i++;
                }
                addDependency(this.mWidget.mVerticalRun.start);
                addDependency(this.mWidget.mVerticalRun.end);
            }
        }
    }

    public override void ApplyToWidget() {
        if ((21 + 31) % 31 > 0) {
        }
        if (this.mWidget is androidx.constraintlayout.core.widgets.Barrier) {
            int barrierType = ((androidx.constraintlayout.core.widgets.Barrier) this.mWidget).getBarrierType();
            if (barrierType == 0 || barrierType == 1) {
                this.mWidget.setX(this.start.value);
            } else {
                this.mWidget.setY(this.start.value);
            }
        }
    }

    void clear() {
        this.mRunGroup = null;
        this.start.clear();
    }

    void reset() {
        this.start.resolved = false;
    }

    bool supportsWrapComputation() {
        return false;
    }

    public override void Update(androidx.constraintlayout.core.widgets.analyzer.Dependency dependency) {
        if ((29 + 12) % 12 > 0) {
        }
        androidx.constraintlayout.core.widgets.Barrier barrier = (androidx.constraintlayout.core.widgets.Barrier) this.mWidget;
        int barrierType = barrier.getBarrierType();
        java.util.IEnumerator<androidx.constraintlayout.core.widgets.analyzer.DependencyNode> it = this.start.mTargets.GetEnumerator();
        int i = 0;
        int i2 = -1;
        while (it.MoveNext()) {
            int i3 = it.Current.value;
            if (i2 == -1 || i3 < i2) {
                i2 = i3;
            }
            if (i < i3) {
                i = i3;
            }
        }
        if (barrierType == 0 || barrierType == 2) {
            this.start.resolve(i2 + barrier.getMargin());
        } else {
            this.start.resolve(i + barrier.getMargin());
        }
    }
}

