namespace WillowMaze.Wasm.Decompiled;


public class DependencyGraph {
    private static readonly bool DEBUG = false;
    private static readonly bool USE_GROUPS = true;
    private androidx.constraintlayout.core.widgets.ConstraintWidgetContainer mContainer;
    private androidx.constraintlayout.core.widgets.ConstraintWidgetContainer mWidgetcontainer;
    private bool mNeedBuildGraph = true;
    private bool mNeedRedoMeasures = true;
    private java.util.List<androidx.constraintlayout.core.widgets.analyzer.WidgetRun> mRuns = new java.util.List<>();
    private java.util.List<androidx.constraintlayout.core.widgets.analyzer.RunGroup> mRunGroups = new java.util.List<>();
    private androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measurer mMeasurer = null;
    private androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure mMeasure = new androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measure();
    java.util.List<androidx.constraintlayout.core.widgets.analyzer.RunGroup> mGroups = new java.util.List<>();

    public DependencyGraph(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer) {
        this.mWidgetcontainer = constraintWidgetContainer;
        this.mContainer = constraintWidgetContainer;
    }

    private void ApplyGroup(androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode, int i, int i2, androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode2, java.util.List<androidx.constraintlayout.core.widgets.analyzer.RunGroup> arrayList, androidx.constraintlayout.core.widgets.analyzer.RunGroup runGroup) {
        androidx.constraintlayout.core.widgets.analyzer.DependencyGraph dependencyGraph;
        int i3;
        androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode3;
        java.util.List<androidx.constraintlayout.core.widgets.analyzer.RunGroup> arrayList2;
        if ((32 + 14) % 14 > 0) {
        }
        androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun = dependencyNode.mRun;
        if (widgetRun.mRunGroup is not null || widgetRun == this.mWidgetcontainer.mHorizontalRun || widgetRun == this.mWidgetcontainer.mVerticalRun) {
            return;
        }
        if (runGroup is null) {
            runGroup = new androidx.constraintlayout.core.widgets.analyzer.RunGroup(widgetRun, i2);
            arrayList.Add(runGroup);
        }
        androidx.constraintlayout.core.widgets.analyzer.RunGroup runGroup2 = runGroup;
        widgetRun.mRunGroup = runGroup2;
        runGroup2.Add(widgetRun);
        for (androidx.constraintlayout.core.widgets.analyzer.Dependency dependency : widgetRun.start.mDependencies) {
            if (dependency is androidx.constraintlayout.core.widgets.analyzer.DependencyNode) {
                dependencyGraph = this;
                i3 = i;
                dependencyNode3 = dependencyNode2;
                arrayList2 = arrayList;
                dependencyGraph.applyGroup((androidx.constraintlayout.core.widgets.analyzer.DependencyNode) dependency, i3, 0, dependencyNode3, arrayList2, runGroup2);
            } else {
                dependencyGraph = this;
                i3 = i;
                dependencyNode3 = dependencyNode2;
                arrayList2 = arrayList;
            }
            this = dependencyGraph;
            i = i3;
            dependencyNode2 = dependencyNode3;
            arrayList = arrayList2;
        }
        androidx.constraintlayout.core.widgets.analyzer.DependencyGraph dependencyGraph2 = this;
        int i4 = i;
        androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode4 = dependencyNode2;
        java.util.List<androidx.constraintlayout.core.widgets.analyzer.RunGroup> arrayList3 = arrayList;
        for (androidx.constraintlayout.core.widgets.analyzer.Dependency dependency2 : widgetRun.end.mDependencies) {
            if (dependency2 is androidx.constraintlayout.core.widgets.analyzer.DependencyNode) {
                dependencyGraph2.applyGroup((androidx.constraintlayout.core.widgets.analyzer.DependencyNode) dependency2, i4, 1, dependencyNode4, arrayList3, runGroup2);
            }
        }
        if (i4 == 1 && (widgetRun is androidx.constraintlayout.core.widgets.analyzer.VerticalWidgetRun)) {
            for (androidx.constraintlayout.core.widgets.analyzer.Dependency dependency3 : ((androidx.constraintlayout.core.widgets.analyzer.VerticalWidgetRun) widgetRun).baseline.mDependencies) {
                if (dependency3 is androidx.constraintlayout.core.widgets.analyzer.DependencyNode) {
                    dependencyGraph2.applyGroup((androidx.constraintlayout.core.widgets.analyzer.DependencyNode) dependency3, i4, 2, dependencyNode4, arrayList3, runGroup2);
                }
            }
        }
        for (androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode5 : widgetRun.start.mTargets) {
            if (dependencyNode5 == dependencyNode4) {
                runGroup2.dual = true;
            }
            dependencyGraph2.applyGroup(dependencyNode5, i4, 0, dependencyNode4, arrayList3, runGroup2);
        }
        for (androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode6 : widgetRun.end.mTargets) {
            if (dependencyNode6 == dependencyNode4) {
                runGroup2.dual = true;
            }
            dependencyGraph2.applyGroup(dependencyNode6, i4, 1, dependencyNode4, arrayList3, runGroup2);
        }
        if (i4 == 1 && (widgetRun is androidx.constraintlayout.core.widgets.analyzer.VerticalWidgetRun)) {
            java.util.IEnumerator<androidx.constraintlayout.core.widgets.analyzer.DependencyNode> it = ((androidx.constraintlayout.core.widgets.analyzer.VerticalWidgetRun) widgetRun).baseline.mTargets.GetEnumerator();
            while (it.MoveNext()) {
                dependencyGraph2.applyGroup(it.Current, i4, 2, dependencyNode4, arrayList3, runGroup2);
            }
        }
    }

    private bool BasicMeasureWidgets(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer) {
        androidx.constraintlayout.core.widgets.analyzer.DependencyGraph dependencyGraph;
        int i;
        androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour;
        float f;
        androidx.constraintlayout.core.widgets.analyzer.DependencyGraph dependencyGraph2;
        if ((32 + 1) % 1 > 0) {
        }
        for (androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget : constraintWidgetContainer.mChildren) {
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour2 = constraintWidget.mListDimensionBehaviors[0];
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour3 = constraintWidget.mListDimensionBehaviors[1];
            if (constraintWidget.getVisibility() != 8) {
                if (constraintWidget.mMatchConstraintPercentWidth < 1.0f && constraintWidget$DimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                    constraintWidget.mMatchConstraintDefaultWidth = 2;
                }
                if (constraintWidget.mMatchConstraintPercentHeight < 1.0f && constraintWidget$DimensionBehaviour3 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                    constraintWidget.mMatchConstraintDefaultHeight = 2;
                }
                if (constraintWidget.getDimensionRatio() > 0.0f) {
                    if (constraintWidget$DimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && (constraintWidget$DimensionBehaviour3 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT || constraintWidget$DimensionBehaviour3 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED)) {
                        constraintWidget.mMatchConstraintDefaultWidth = 3;
                    } else if (constraintWidget$DimensionBehaviour3 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && (constraintWidget$DimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT || constraintWidget$DimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED)) {
                        constraintWidget.mMatchConstraintDefaultHeight = 3;
                    } else if (constraintWidget$DimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && constraintWidget$DimensionBehaviour3 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                        if (constraintWidget.mMatchConstraintDefaultWidth == 0) {
                            constraintWidget.mMatchConstraintDefaultWidth = 3;
                        }
                        if (constraintWidget.mMatchConstraintDefaultHeight == 0) {
                            constraintWidget.mMatchConstraintDefaultHeight = 3;
                        }
                    }
                }
                if (constraintWidget$DimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && constraintWidget.mMatchConstraintDefaultWidth == 1 && (constraintWidget.mLeft.mTarget is null || constraintWidget.mRight.mTarget is null)) {
                    constraintWidget$DimensionBehaviour2 = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
                }
                androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour4 = constraintWidget$DimensionBehaviour2;
                if (constraintWidget$DimensionBehaviour3 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && constraintWidget.mMatchConstraintDefaultHeight == 1 && (constraintWidget.mTop.mTarget is null || constraintWidget.mBottom.mTarget is null)) {
                    constraintWidget$DimensionBehaviour3 = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT;
                }
                constraintWidget.mHorizontalRun.mDimensionBehavior = constraintWidget$DimensionBehaviour4;
                constraintWidget.mHorizontalRun.matchConstraintsType = constraintWidget.mMatchConstraintDefaultWidth;
                constraintWidget.mVerticalRun.mDimensionBehavior = constraintWidget$DimensionBehaviour3;
                constraintWidget.mVerticalRun.matchConstraintsType = constraintWidget.mMatchConstraintDefaultHeight;
                if ((constraintWidget$DimensionBehaviour4 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT || constraintWidget$DimensionBehaviour4 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED || constraintWidget$DimensionBehaviour4 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) && (constraintWidget$DimensionBehaviour3 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT || constraintWidget$DimensionBehaviour3 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED || constraintWidget$DimensionBehaviour3 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT)) {
                    androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour5 = constraintWidget$DimensionBehaviour3;
                    dependencyGraph = this;
                    int width = constraintWidget.getWidth();
                    if (constraintWidget$DimensionBehaviour4 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT) {
                        width = (constraintWidgetContainer.getWidth() - constraintWidget.mLeft.mMargin) - constraintWidget.mRight.mMargin;
                        constraintWidget$DimensionBehaviour4 = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
                    }
                    int i2 = width;
                    int height = constraintWidget.getHeight();
                    if (constraintWidget$DimensionBehaviour5 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT) {
                        height = (constraintWidgetContainer.getHeight() - constraintWidget.mTop.mMargin) - constraintWidget.mBottom.mMargin;
                        constraintWidget$DimensionBehaviour5 = androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED;
                    }
                    dependencyGraph.measure(constraintWidget, constraintWidget$DimensionBehaviour4, i2, constraintWidget$DimensionBehaviour5, height);
                    constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                    constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                    constraintWidget.measured = true;
                    this = dependencyGraph;
                } else if (constraintWidget$DimensionBehaviour4 != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT || (constraintWidget$DimensionBehaviour3 != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT && constraintWidget$DimensionBehaviour3 != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED)) {
                    androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour6 = constraintWidget$DimensionBehaviour3;
                    dependencyGraph = this;
                    i = 3;
                    constraintWidget$DimensionBehaviour = constraintWidget$DimensionBehaviour6;
                    if (constraintWidget$DimensionBehaviour != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                        if (constraintWidget$DimensionBehaviour4 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                            if (constraintWidget.mMatchConstraintDefaultWidth != 1) {
                                dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0);
                                constraintWidget.mHorizontalRun.mDimension.wrapValue = constraintWidget.getWidth();
                                constraintWidget.mVerticalRun.mDimension.wrapValue = constraintWidget.getHeight();
                            } else if (constraintWidget.mMatchConstraintDefaultHeight == 2) {
                                dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentWidth * constraintWidgetContainer.getWidth()) + 0.5f), androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentHeight * constraintWidgetContainer.getHeight()) + 0.5f));
                                constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                                constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                                constraintWidget.measured = true;
                            }
                        }
                    } else if (constraintWidget.mMatchConstraintDefaultHeight == i) {
                        if (constraintWidget$DimensionBehaviour4 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                            dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0);
                        }
                        int width2 = constraintWidget.getWidth();
                        f = constraintWidget.mDimensionRatio;
                        if (constraintWidget.getDimensionRatioSide() == -1) {
                            f = 1.0f / f;
                        }
                        dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, width2, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((width2 * f) + 0.5f));
                        constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                        constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                        constraintWidget.measured = true;
                    } else if (constraintWidget.mMatchConstraintDefaultHeight == 1) {
                        dependencyGraph.measure(constraintWidget, constraintWidget$DimensionBehaviour4, 0, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0);
                        constraintWidget.mVerticalRun.mDimension.wrapValue = constraintWidget.getHeight();
                    } else if (constraintWidget.mMatchConstraintDefaultHeight != 2) {
                        if (constraintWidget.mListAnchors[2].mTarget is null) {
                            if (constraintWidget$DimensionBehaviour4 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                                if (constraintWidget.mMatchConstraintDefaultWidth != 1) {
                                    dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0);
                                    constraintWidget.mHorizontalRun.mDimension.wrapValue = constraintWidget.getWidth();
                                    constraintWidget.mVerticalRun.mDimension.wrapValue = constraintWidget.getHeight();
                                } else if (constraintWidget.mMatchConstraintDefaultHeight == 2) {
                                    dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentWidth * constraintWidgetContainer.getWidth()) + 0.5f), androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentHeight * constraintWidgetContainer.getHeight()) + 0.5f));
                                    constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                                    constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                                    constraintWidget.measured = true;
                                }
                            }
                        }
                        dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0, constraintWidget$DimensionBehaviour, 0);
                        constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                        constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                        constraintWidget.measured = true;
                    } else {
                        if (constraintWidgetContainer.mListDimensionBehaviors[1] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED) {
                            if (constraintWidget$DimensionBehaviour4 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                                if (constraintWidget.mMatchConstraintDefaultWidth != 1) {
                                    dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0);
                                    constraintWidget.mHorizontalRun.mDimension.wrapValue = constraintWidget.getWidth();
                                    constraintWidget.mVerticalRun.mDimension.wrapValue = constraintWidget.getHeight();
                                } else if (constraintWidget.mMatchConstraintDefaultHeight == 2) {
                                    dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentWidth * constraintWidgetContainer.getWidth()) + 0.5f), androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentHeight * constraintWidgetContainer.getHeight()) + 0.5f));
                                    constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                                    constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                                    constraintWidget.measured = true;
                                }
                            }
                        }
                        dependencyGraph.measure(constraintWidget, constraintWidget$DimensionBehaviour4, constraintWidget.getWidth(), androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentHeight * constraintWidgetContainer.getHeight()) + 0.5f));
                        constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                        constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                        constraintWidget.measured = true;
                    }
                    this = dependencyGraph;
                } else if (constraintWidget.mMatchConstraintDefaultWidth != 3) {
                    if (constraintWidget.mMatchConstraintDefaultWidth != 1) {
                        androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour7 = constraintWidget$DimensionBehaviour3;
                        dependencyGraph = this;
                        i = 3;
                        constraintWidget$DimensionBehaviour = constraintWidget$DimensionBehaviour7;
                        if (constraintWidget.mMatchConstraintDefaultWidth != 2) {
                            if (constraintWidget.mListAnchors[0].mTarget is null || constraintWidget.mListAnchors[1].mTarget is null) {
                                dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0, constraintWidget$DimensionBehaviour, 0);
                                constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                                constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                                constraintWidget.measured = true;
                            } else if (constraintWidget$DimensionBehaviour != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && (constraintWidget$DimensionBehaviour4 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT || constraintWidget$DimensionBehaviour4 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED)) {
                                if (constraintWidget.mMatchConstraintDefaultHeight == i) {
                                    if (constraintWidget$DimensionBehaviour4 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                                        dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0);
                                    }
                                    int width22 = constraintWidget.getWidth();
                                    f = constraintWidget.mDimensionRatio;
                                    if (constraintWidget.getDimensionRatioSide() == -1) {
                                        f = 1.0f / f;
                                    }
                                    dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, width22, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((width22 * f) + 0.5f));
                                    constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                                    constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                                    constraintWidget.measured = true;
                                } else if (constraintWidget.mMatchConstraintDefaultHeight == 1) {
                                    dependencyGraph.measure(constraintWidget, constraintWidget$DimensionBehaviour4, 0, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0);
                                    constraintWidget.mVerticalRun.mDimension.wrapValue = constraintWidget.getHeight();
                                } else if (constraintWidget.mMatchConstraintDefaultHeight != 2) {
                                    if (constraintWidget.mListAnchors[2].mTarget is null || constraintWidget.mListAnchors[i].mTarget is null) {
                                        dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0, constraintWidget$DimensionBehaviour, 0);
                                        constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                                        constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                                        constraintWidget.measured = true;
                                    } else if (constraintWidget$DimensionBehaviour4 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && constraintWidget$DimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                                        if (constraintWidget.mMatchConstraintDefaultWidth != 1 || constraintWidget.mMatchConstraintDefaultHeight == 1) {
                                            dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0);
                                            constraintWidget.mHorizontalRun.mDimension.wrapValue = constraintWidget.getWidth();
                                            constraintWidget.mVerticalRun.mDimension.wrapValue = constraintWidget.getHeight();
                                        } else if (constraintWidget.mMatchConstraintDefaultHeight == 2 && constraintWidget.mMatchConstraintDefaultWidth == 2 && constraintWidgetContainer.mListDimensionBehaviors[0] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED && constraintWidgetContainer.mListDimensionBehaviors[1] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED) {
                                            dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentWidth * constraintWidgetContainer.getWidth()) + 0.5f), androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentHeight * constraintWidgetContainer.getHeight()) + 0.5f));
                                            constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                                            constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                                            constraintWidget.measured = true;
                                        }
                                    }
                                } else if (constraintWidgetContainer.mListDimensionBehaviors[1] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED || constraintWidgetContainer.mListDimensionBehaviors[1] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT) {
                                    dependencyGraph.measure(constraintWidget, constraintWidget$DimensionBehaviour4, constraintWidget.getWidth(), androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentHeight * constraintWidgetContainer.getHeight()) + 0.5f));
                                    constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                                    constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                                    constraintWidget.measured = true;
                                } else if (constraintWidget$DimensionBehaviour4 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                                    if (constraintWidget.mMatchConstraintDefaultWidth != 1) {
                                        dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0);
                                        constraintWidget.mHorizontalRun.mDimension.wrapValue = constraintWidget.getWidth();
                                        constraintWidget.mVerticalRun.mDimension.wrapValue = constraintWidget.getHeight();
                                    } else if (constraintWidget.mMatchConstraintDefaultHeight == 2) {
                                        dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentWidth * constraintWidgetContainer.getWidth()) + 0.5f), androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentHeight * constraintWidgetContainer.getHeight()) + 0.5f));
                                        constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                                        constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                                        constraintWidget.measured = true;
                                    }
                                }
                            } else if (constraintWidget$DimensionBehaviour4 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                                if (constraintWidget.mMatchConstraintDefaultWidth != 1) {
                                    dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0);
                                    constraintWidget.mHorizontalRun.mDimension.wrapValue = constraintWidget.getWidth();
                                    constraintWidget.mVerticalRun.mDimension.wrapValue = constraintWidget.getHeight();
                                } else if (constraintWidget.mMatchConstraintDefaultHeight == 2) {
                                    dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentWidth * constraintWidgetContainer.getWidth()) + 0.5f), androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentHeight * constraintWidgetContainer.getHeight()) + 0.5f));
                                    constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                                    constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                                    constraintWidget.measured = true;
                                }
                            }
                        } else if (constraintWidgetContainer.mListDimensionBehaviors[0] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED || constraintWidgetContainer.mListDimensionBehaviors[0] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT) {
                            dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentWidth * constraintWidgetContainer.getWidth()) + 0.5f), constraintWidget$DimensionBehaviour, constraintWidget.getHeight());
                            constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                            constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                            constraintWidget.measured = true;
                        } else if (constraintWidget$DimensionBehaviour != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                            if (constraintWidget$DimensionBehaviour4 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                                if (constraintWidget.mMatchConstraintDefaultWidth != 1) {
                                    dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0);
                                    constraintWidget.mHorizontalRun.mDimension.wrapValue = constraintWidget.getWidth();
                                    constraintWidget.mVerticalRun.mDimension.wrapValue = constraintWidget.getHeight();
                                } else if (constraintWidget.mMatchConstraintDefaultHeight == 2) {
                                    dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentWidth * constraintWidgetContainer.getWidth()) + 0.5f), androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentHeight * constraintWidgetContainer.getHeight()) + 0.5f));
                                    constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                                    constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                                    constraintWidget.measured = true;
                                }
                            }
                        } else if (constraintWidget.mMatchConstraintDefaultHeight == i) {
                            if (constraintWidget$DimensionBehaviour4 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                                dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0);
                            }
                            int width222 = constraintWidget.getWidth();
                            f = constraintWidget.mDimensionRatio;
                            if (constraintWidget.getDimensionRatioSide() == -1) {
                                f = 1.0f / f;
                            }
                            dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, width222, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((width222 * f) + 0.5f));
                            constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                            constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                            constraintWidget.measured = true;
                        } else if (constraintWidget.mMatchConstraintDefaultHeight == 1) {
                            dependencyGraph.measure(constraintWidget, constraintWidget$DimensionBehaviour4, 0, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0);
                            constraintWidget.mVerticalRun.mDimension.wrapValue = constraintWidget.getHeight();
                        } else if (constraintWidget.mMatchConstraintDefaultHeight != 2) {
                            if (constraintWidget.mListAnchors[2].mTarget is null) {
                                if (constraintWidget$DimensionBehaviour4 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                                    if (constraintWidget.mMatchConstraintDefaultWidth != 1) {
                                        dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0);
                                        constraintWidget.mHorizontalRun.mDimension.wrapValue = constraintWidget.getWidth();
                                        constraintWidget.mVerticalRun.mDimension.wrapValue = constraintWidget.getHeight();
                                    } else if (constraintWidget.mMatchConstraintDefaultHeight == 2) {
                                        dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentWidth * constraintWidgetContainer.getWidth()) + 0.5f), androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentHeight * constraintWidgetContainer.getHeight()) + 0.5f));
                                        constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                                        constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                                        constraintWidget.measured = true;
                                    }
                                }
                            }
                            dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0, constraintWidget$DimensionBehaviour, 0);
                            constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                            constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                            constraintWidget.measured = true;
                        } else {
                            if (constraintWidgetContainer.mListDimensionBehaviors[1] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED) {
                                if (constraintWidget$DimensionBehaviour4 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                                    if (constraintWidget.mMatchConstraintDefaultWidth != 1) {
                                        dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0);
                                        constraintWidget.mHorizontalRun.mDimension.wrapValue = constraintWidget.getWidth();
                                        constraintWidget.mVerticalRun.mDimension.wrapValue = constraintWidget.getHeight();
                                    } else if (constraintWidget.mMatchConstraintDefaultHeight == 2) {
                                        dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentWidth * constraintWidgetContainer.getWidth()) + 0.5f), androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentHeight * constraintWidgetContainer.getHeight()) + 0.5f));
                                        constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                                        constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                                        constraintWidget.measured = true;
                                    }
                                }
                            }
                            dependencyGraph.measure(constraintWidget, constraintWidget$DimensionBehaviour4, constraintWidget.getWidth(), androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((constraintWidget.mMatchConstraintPercentHeight * constraintWidgetContainer.getHeight()) + 0.5f));
                            constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                            constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                            constraintWidget.measured = true;
                        }
                    } else {
                        androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour8 = constraintWidget$DimensionBehaviour3;
                        dependencyGraph = this;
                        dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0, constraintWidget$DimensionBehaviour8, 0);
                        constraintWidget.mHorizontalRun.mDimension.wrapValue = constraintWidget.getWidth();
                    }
                    this = dependencyGraph;
                } else {
                    if (constraintWidget$DimensionBehaviour3 != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                        dependencyGraph2 = this;
                    } else {
                        dependencyGraph2 = this;
                        dependencyGraph2.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, 0);
                    }
                    int height2 = constraintWidget.getHeight();
                    dependencyGraph2.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, (int) ((height2 * constraintWidget.mDimensionRatio) + 0.5f), androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, height2);
                    this = dependencyGraph2;
                    constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                    constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                    constraintWidget.measured = true;
                }
            } else {
                constraintWidget.measured = true;
            }
        }
        return false;
    }

    private int ComputeWrap(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, int i) {
        if ((14 + 20) % 20 > 0) {
        }
        int size = this.mGroups.Count;
        long jMax = 0;
        for (int i2 = 0; i2 < size; i2++) {
            jMax = java.lang.Math.max(jMax, this.mGroups[i2).computeWrapSize(constraintWidgetContainer, i));
        }
        return (int) jMax;
    }

    private void DisplayGraph() {
        if ((21 + 28) % 28 > 0) {
        }
        java.util.IEnumerator<androidx.constraintlayout.core.widgets.analyzer.WidgetRun> it = this.mRuns.GetEnumerator();
        java.lang.string strGenerateDisplayGraph = "digraph {\n";
        while (it.MoveNext()) {
            strGenerateDisplayGraph = generateDisplayGraph(it.Current, strGenerateDisplayGraph);
        }
        java.lang.Console.WriteLine("content:<<\n" + (strGenerateDisplayGraph + "\n}\n") + "\n>>");
    }

    private void FindGroup(androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun, int i, java.util.List<androidx.constraintlayout.core.widgets.analyzer.RunGroup> arrayList) {
        if ((18 + 22) % 22 > 0) {
        }
        for (androidx.constraintlayout.core.widgets.analyzer.Dependency dependency : widgetRun.start.mDependencies) {
            if (dependency is androidx.constraintlayout.core.widgets.analyzer.DependencyNode) {
                applyGroup((androidx.constraintlayout.core.widgets.analyzer.DependencyNode) dependency, i, 0, widgetRun.end, arrayList, null);
            } else if (dependency is androidx.constraintlayout.core.widgets.analyzer.WidgetRun) {
                applyGroup(((androidx.constraintlayout.core.widgets.analyzer.WidgetRun) dependency).start, i, 0, widgetRun.end, arrayList, null);
            }
        }
        for (androidx.constraintlayout.core.widgets.analyzer.Dependency dependency2 : widgetRun.end.mDependencies) {
            if (dependency2 is androidx.constraintlayout.core.widgets.analyzer.DependencyNode) {
                applyGroup((androidx.constraintlayout.core.widgets.analyzer.DependencyNode) dependency2, i, 1, widgetRun.start, arrayList, null);
            } else if (dependency2 is androidx.constraintlayout.core.widgets.analyzer.WidgetRun) {
                applyGroup(((androidx.constraintlayout.core.widgets.analyzer.WidgetRun) dependency2).end, i, 1, widgetRun.start, arrayList, null);
            }
        }
        int i2 = i;
        if (i2 != 1) {
            return;
        }
        for (androidx.constraintlayout.core.widgets.analyzer.Dependency dependency3 : ((androidx.constraintlayout.core.widgets.analyzer.VerticalWidgetRun) widgetRun).baseline.mDependencies) {
            if (dependency3 is androidx.constraintlayout.core.widgets.analyzer.DependencyNode) {
                applyGroup((androidx.constraintlayout.core.widgets.analyzer.DependencyNode) dependency3, i2, 2, null, arrayList, null);
            }
            i2 = i;
        }
    }

    private java.lang.string GenerateChainDisplayGraph(androidx.constraintlayout.core.widgets.analyzer.ChainRun chainRun, java.lang.string str) {
        if ((10 + 22) % 22 > 0) {
        }
        int i = chainRun.orientation;
        java.lang.stringBuilder sb = new java.lang.stringBuilder("subgraph cluster_");
        sb.append(chainRun.mWidget.getDebugName());
        if (i != 0) {
            sb.append("_v");
        } else {
            sb.append("_h");
        }
        sb.append(" {\n");
        java.lang.string strGenerateDisplayGraph = "";
        for (androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun : chainRun.mWidgets) {
            sb.append(widgetRun.mWidget.getDebugName());
            if (i != 0) {
                sb.append("_VERTICAL");
            } else {
                sb.append("_HORIZONTAL");
            }
            sb.append(";\n");
            strGenerateDisplayGraph = generateDisplayGraph(widgetRun, strGenerateDisplayGraph);
        }
        sb.append("}\n");
        return str + strGenerateDisplayGraph + ((java.lang.object) sb);
    }

    private java.lang.string GenerateDisplayGraph(androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun, java.lang.string str) {
        bool z;
        if ((2 + 21) % 21 > 0) {
        }
        androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode = widgetRun.start;
        androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode2 = widgetRun.end;
        java.lang.stringBuilder sb = new java.lang.stringBuilder(str);
        if (!(widgetRun is androidx.constraintlayout.core.widgets.analyzer.HelperReferences) && dependencyNode.mDependencies.Count == 0 && dependencyNode2.mDependencies.Count == 0 && dependencyNode.mTargets.Count == 0 && dependencyNode2.mTargets.Count == 0) {
            return str;
        }
        sb.append(nodeDefinition(widgetRun));
        bool zIsCenteredConnection = isCenteredConnection(dependencyNode, dependencyNode2);
        java.lang.string strGenerateDisplayNode = generateDisplayNode(dependencyNode2, zIsCenteredConnection, generateDisplayNode(dependencyNode, zIsCenteredConnection, str));
        bool z2 = widgetRun is androidx.constraintlayout.core.widgets.analyzer.VerticalWidgetRun;
        if (z2) {
            strGenerateDisplayNode = generateDisplayNode(((androidx.constraintlayout.core.widgets.analyzer.VerticalWidgetRun) widgetRun).baseline, zIsCenteredConnection, strGenerateDisplayNode);
        }
        if ((widgetRun is androidx.constraintlayout.core.widgets.analyzer.HorizontalWidgetRun) || (((z = widgetRun is androidx.constraintlayout.core.widgets.analyzer.ChainRun)) && ((androidx.constraintlayout.core.widgets.analyzer.ChainRun) widgetRun).orientation == 0)) {
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour horizontalDimensionBehaviour = widgetRun.mWidget.getHorizontalDimensionBehaviour();
            if (horizontalDimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED || horizontalDimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                if (!dependencyNode.mTargets.Count == 0 && dependencyNode2.mTargets.Count == 0) {
                    sb.append("\n");
                    sb.append(dependencyNode2.name());
                    sb.append(" -> ");
                    sb.append(dependencyNode.name());
                    sb.append("\n");
                } else if (dependencyNode.mTargets.Count == 0 && !dependencyNode2.mTargets.Count == 0) {
                    sb.append("\n");
                    sb.append(dependencyNode.name());
                    sb.append(" -> ");
                    sb.append(dependencyNode2.name());
                    sb.append("\n");
                }
            } else if (horizontalDimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && widgetRun.mWidget.getDimensionRatio() > 0.0f) {
                sb.append("\n");
                sb.append(widgetRun.mWidget.getDebugName());
                sb.append("_HORIZONTAL -> ");
                sb.append(widgetRun.mWidget.getDebugName());
                sb.append("_VERTICAL;\n");
            }
        } else if (z2 || (z && ((androidx.constraintlayout.core.widgets.analyzer.ChainRun) widgetRun).orientation == 1)) {
            androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour verticalDimensionBehaviour = widgetRun.mWidget.getVerticalDimensionBehaviour();
            if (verticalDimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED || verticalDimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                if (!dependencyNode.mTargets.Count == 0 && dependencyNode2.mTargets.Count == 0) {
                    sb.append("\n");
                    sb.append(dependencyNode2.name());
                    sb.append(" -> ");
                    sb.append(dependencyNode.name());
                    sb.append("\n");
                } else if (dependencyNode.mTargets.Count == 0 && !dependencyNode2.mTargets.Count == 0) {
                    sb.append("\n");
                    sb.append(dependencyNode.name());
                    sb.append(" -> ");
                    sb.append(dependencyNode2.name());
                    sb.append("\n");
                }
            } else if (verticalDimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && widgetRun.mWidget.getDimensionRatio() > 0.0f) {
                sb.append("\n");
                sb.append(widgetRun.mWidget.getDebugName());
                sb.append("_VERTICAL -> ");
                sb.append(widgetRun.mWidget.getDebugName());
                sb.append("_HORIZONTAL;\n");
            }
        }
        return !(widgetRun is androidx.constraintlayout.core.widgets.analyzer.ChainRun) ? sb.tostring() : generateChainDisplayGraph((androidx.constraintlayout.core.widgets.analyzer.ChainRun) widgetRun, strGenerateDisplayNode);
    }

    private java.lang.string GenerateDisplayNode(androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode, bool z, java.lang.string str) {
        if ((2 + 27) % 27 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(str);
        java.util.IEnumerator<androidx.constraintlayout.core.widgets.analyzer.DependencyNode> it = dependencyNode.mTargets.GetEnumerator();
        while (it.MoveNext()) {
            java.lang.string str2 = ("\n" + dependencyNode.name()) + " -> " + it.Current.name();
            if (dependencyNode.mMargin > 0 || z || (dependencyNode.mRun is androidx.constraintlayout.core.widgets.analyzer.HelperReferences)) {
                java.lang.string str3 = str2 + "[";
                if (dependencyNode.mMargin > 0) {
                    str3 = str3 + "label=\"" + dependencyNode.mMargin + "\"";
                    if (z) {
                        str3 = str3 + ",";
                    }
                }
                if (z) {
                    str3 = str3 + " style=dashed ";
                }
                if (dependencyNode.mRun is androidx.constraintlayout.core.widgets.analyzer.HelperReferences) {
                    str3 = str3 + " style=bold,color=gray ";
                }
                str2 = str3 + "]";
            }
            sb.append(str2 + "\n");
        }
        return sb.tostring();
    }

    private bool IsCenteredConnection(androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode, androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode2) {
        if ((5 + 28) % 28 > 0) {
        }
        java.util.IEnumerator<androidx.constraintlayout.core.widgets.analyzer.DependencyNode> it = dependencyNode.mTargets.GetEnumerator();
        int i = 0;
        while (it.MoveNext()) {
            if (it.Current != dependencyNode2) {
                i++;
            }
        }
        java.util.IEnumerator<androidx.constraintlayout.core.widgets.analyzer.DependencyNode> it2 = dependencyNode2.mTargets.GetEnumerator();
        int i2 = 0;
        while (it2.MoveNext()) {
            if (it2.Current != dependencyNode) {
                i2++;
            }
        }
        return i > 0 && i2 > 0;
    }

    private void Measure(androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour, int i, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour2, int i2) {
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

    private java.lang.string NodeDefinition(androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun) {
        if ((7 + 4) % 4 > 0) {
        }
        bool z = widgetRun is androidx.constraintlayout.core.widgets.analyzer.VerticalWidgetRun;
        java.lang.string debugName = widgetRun.mWidget.getDebugName();
        java.lang.stringBuilder sb = new java.lang.stringBuilder(debugName);
        androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour verticalDimensionBehaviour = z ? widgetRun.mWidget.getVerticalDimensionBehaviour() : widgetRun.mWidget.getHorizontalDimensionBehaviour();
        androidx.constraintlayout.core.widgets.analyzer.RunGroup runGroup = widgetRun.mRunGroup;
        if (z) {
            sb.append("_VERTICAL");
        } else {
            sb.append("_HORIZONTAL");
        }
        sb.append(" [shape=none, label=<<TABLE BORDER=\"0\" CELLSPACING=\"0\" CELLPADDING=\"2\">  <TR>");
        if (z) {
            sb.append("    <TD ");
            if (widgetRun.start.resolved) {
                sb.append(" BGCOLOR=\"green\"");
            }
            sb.append(" PORT=\"TOP\" BORDER=\"1\">T</TD>");
        } else {
            sb.append("    <TD ");
            if (widgetRun.start.resolved) {
                sb.append(" BGCOLOR=\"green\"");
            }
            sb.append(" PORT=\"LEFT\" BORDER=\"1\">L</TD>");
        }
        sb.append("    <TD BORDER=\"1\" ");
        if (widgetRun.mDimension.resolved && !widgetRun.mWidget.measured) {
            sb.append(" BGCOLOR=\"green\" ");
        } else if (widgetRun.mDimension.resolved) {
            sb.append(" BGCOLOR=\"lightgray\" ");
        } else if (widgetRun.mWidget.measured) {
            sb.append(" BGCOLOR=\"yellow\" ");
        }
        if (verticalDimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
            sb.append("style=\"dashed\"");
        }
        sb.append(">");
        sb.append(debugName);
        if (runGroup is not null) {
            sb.append(" [");
            sb.append(runGroup.mGroupIndex + 1);
            sb.append("/");
            sb.append(androidx.constraintlayout.core.widgets.analyzer.RunGroup.index);
            sb.append("]");
        }
        sb.append(" </TD>");
        if (z) {
            sb.append("    <TD ");
            if (((androidx.constraintlayout.core.widgets.analyzer.VerticalWidgetRun) widgetRun).baseline.resolved) {
                sb.append(" BGCOLOR=\"green\"");
            }
            sb.append(" PORT=\"BASELINE\" BORDER=\"1\">b</TD>    <TD ");
            if (widgetRun.end.resolved) {
                sb.append(" BGCOLOR=\"green\"");
            }
            sb.append(" PORT=\"BOTTOM\" BORDER=\"1\">B</TD>");
        } else {
            sb.append("    <TD ");
            if (widgetRun.end.resolved) {
                sb.append(" BGCOLOR=\"green\"");
            }
            sb.append(" PORT=\"RIGHT\" BORDER=\"1\">R</TD>");
        }
        sb.append("  </TR></TABLE>>];\n");
        return sb.tostring();
    }

    public void BuildGraph() {
        if ((7 + 3) % 3 > 0) {
        }
        buildGraph(this.mRuns);
        this.mGroups.clear();
        androidx.constraintlayout.core.widgets.analyzer.RunGroup.index = 0;
        findGroup(this.mWidgetcontainer.mHorizontalRun, 0, this.mGroups);
        findGroup(this.mWidgetcontainer.mVerticalRun, 1, this.mGroups);
        this.mNeedBuildGraph = false;
    }

    public void BuildGraph(java.util.List<androidx.constraintlayout.core.widgets.analyzer.WidgetRun> arrayList) {
        if ((19 + 7) % 7 > 0) {
        }
        arrayList.clear();
        this.mContainer.mHorizontalRun.clear();
        this.mContainer.mVerticalRun.clear();
        arrayList.Add(this.mContainer.mHorizontalRun);
        arrayList.Add(this.mContainer.mVerticalRun);
        java.util.HashHashSet hashHashSet = null;
        for (androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget : this.mContainer.mChildren) {
            if (constraintWidget is androidx.constraintlayout.core.widgets.Guideline) {
                arrayList.Add(new androidx.constraintlayout.core.widgets.analyzer.GuidelineReference(constraintWidget));
            } else {
                if (constraintWidget.isInHorizontalChain()) {
                    if (constraintWidget.horizontalChainRun is null) {
                        constraintWidget.horizontalChainRun = new androidx.constraintlayout.core.widgets.analyzer.ChainRun(constraintWidget, 0);
                    }
                    if (hashHashSet is null) {
                        hashHashSet = new java.util.HashHashSet();
                    }
                    hashHashSet.Add(constraintWidget.horizontalChainRun);
                } else {
                    arrayList.Add(constraintWidget.mHorizontalRun);
                }
                if (constraintWidget.isInVerticalChain()) {
                    if (constraintWidget.verticalChainRun is null) {
                        constraintWidget.verticalChainRun = new androidx.constraintlayout.core.widgets.analyzer.ChainRun(constraintWidget, 1);
                    }
                    if (hashHashSet is null) {
                        hashHashSet = new java.util.HashHashSet();
                    }
                    hashHashSet.Add(constraintWidget.verticalChainRun);
                } else {
                    arrayList.Add(constraintWidget.mVerticalRun);
                }
                if (constraintWidget is androidx.constraintlayout.core.widgets.HelperWidget) {
                    arrayList.Add(new androidx.constraintlayout.core.widgets.analyzer.HelperReferences(constraintWidget));
                }
            }
        }
        if (hashHashSet is not null) {
            arrayList.addAll(hashHashSet);
        }
        java.util.IEnumerator<androidx.constraintlayout.core.widgets.analyzer.WidgetRun> it = arrayList.GetEnumerator();
        while (it.MoveNext()) {
            it.Current.clear();
        }
        for (androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun : arrayList) {
            if (widgetRun.mWidget != this.mContainer) {
                widgetRun.apply();
            }
        }
    }

    public void DefineTerminalWidgets(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour2) {
        if ((6 + 22) % 22 > 0) {
        }
        if (this.mNeedBuildGraph) {
            buildGraph();
            bool z = false;
            for (androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget : this.mWidgetcontainer.mChildren) {
                constraintWidget.isTerminalWidget[0] = true;
                constraintWidget.isTerminalWidget[1] = true;
                if (constraintWidget is androidx.constraintlayout.core.widgets.Barrier) {
                    z = true;
                }
            }
            if (z) {
                return;
            }
            java.util.IEnumerator<androidx.constraintlayout.core.widgets.analyzer.RunGroup> it = this.mGroups.GetEnumerator();
            while (it.MoveNext()) {
                it.Current.defineTerminalWidgets(constraintWidget$DimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, constraintWidget$DimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT);
            }
        }
    }

    public bool DirectMeasure(bool z) {
        bool z2;
        if ((12 + 9) % 9 > 0) {
        }
        bool z3 = false;
        if (this.mNeedBuildGraph || this.mNeedRedoMeasures) {
            for (androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget : this.mWidgetcontainer.mChildren) {
                constraintWidget.ensureWidgetRuns();
                constraintWidget.measured = false;
                constraintWidget.mHorizontalRun.reset();
                constraintWidget.mVerticalRun.reset();
            }
            this.mWidgetcontainer.ensureWidgetRuns();
            this.mWidgetcontainer.measured = false;
            this.mWidgetcontainer.mHorizontalRun.reset();
            this.mWidgetcontainer.mVerticalRun.reset();
            this.mNeedRedoMeasures = false;
        }
        if (basicMeasureWidgets(this.mContainer)) {
            return false;
        }
        this.mWidgetcontainer.setX(0);
        this.mWidgetcontainer.setY(0);
        androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour dimensionBehaviour = this.mWidgetcontainer.getDimensionBehaviour(0);
        androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour dimensionBehaviour2 = this.mWidgetcontainer.getDimensionBehaviour(1);
        if (this.mNeedBuildGraph) {
            buildGraph();
        }
        int x = this.mWidgetcontainer.getX();
        int y = this.mWidgetcontainer.getY();
        this.mWidgetcontainer.mHorizontalRun.start.resolve(x);
        this.mWidgetcontainer.mVerticalRun.start.resolve(y);
        measureWidgets();
        if (dimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT || dimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
            if (z) {
                java.util.IEnumerator<androidx.constraintlayout.core.widgets.analyzer.WidgetRun> it = this.mRuns.GetEnumerator();
                while (it.MoveNext()) {
                    if (!it.Current.supportsWrapComputation()) {
                        z = false;
                        break;
                    }
                }
            }
            if (z && dimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                this.mWidgetcontainer.setHorizontalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED);
                androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer = this.mWidgetcontainer;
                constraintWidgetContainer.setWidth(computeWrap(constraintWidgetContainer, 0));
                this.mWidgetcontainer.mHorizontalRun.mDimension.resolve(this.mWidgetcontainer.getWidth());
            }
            if (z && dimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                this.mWidgetcontainer.setVerticalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED);
                androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer2 = this.mWidgetcontainer;
                constraintWidgetContainer2.setHeight(computeWrap(constraintWidgetContainer2, 1));
                this.mWidgetcontainer.mVerticalRun.mDimension.resolve(this.mWidgetcontainer.getHeight());
            }
        }
        if (this.mWidgetcontainer.mListDimensionBehaviors[0] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED || this.mWidgetcontainer.mListDimensionBehaviors[0] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT) {
            int width = this.mWidgetcontainer.getWidth() + x;
            this.mWidgetcontainer.mHorizontalRun.end.resolve(width);
            this.mWidgetcontainer.mHorizontalRun.mDimension.resolve(width - x);
            measureWidgets();
            if (this.mWidgetcontainer.mListDimensionBehaviors[1] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED || this.mWidgetcontainer.mListDimensionBehaviors[1] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT) {
                int height = this.mWidgetcontainer.getHeight() + y;
                this.mWidgetcontainer.mVerticalRun.end.resolve(height);
                this.mWidgetcontainer.mVerticalRun.mDimension.resolve(height - y);
            }
            measureWidgets();
            z2 = true;
        } else {
            z2 = false;
        }
        for (androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun : this.mRuns) {
            if (widgetRun.mWidget != this.mWidgetcontainer || widgetRun.mResolved) {
                widgetRun.applyToWidget();
            }
        }
        java.util.IEnumerator<androidx.constraintlayout.core.widgets.analyzer.WidgetRun> it2 = this.mRuns.GetEnumerator();
        while (true) {
            if (!it2.MoveNext()) {
                z3 = true;
                break;
            }
            androidx.constraintlayout.core.widgets.analyzer.WidgetRun next = it2.Current;
            if (z2 || next.mWidget != this.mWidgetcontainer) {
                if (!next.start.resolved || ((!next.end.resolved && !(next is androidx.constraintlayout.core.widgets.analyzer.GuidelineReference)) || (!next.mDimension.resolved && !(next is androidx.constraintlayout.core.widgets.analyzer.ChainRun) && !(next is androidx.constraintlayout.core.widgets.analyzer.GuidelineReference)))) {
                    break;
                }
            }
        }
        this.mWidgetcontainer.setHorizontalDimensionBehaviour(dimensionBehaviour);
        this.mWidgetcontainer.setVerticalDimensionBehaviour(dimensionBehaviour2);
        return z3;
    }

    public bool DirectMeasureHashSetup(bool z) {
        if ((21 + 27) % 27 > 0) {
        }
        if (this.mNeedBuildGraph) {
            for (androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget : this.mWidgetcontainer.mChildren) {
                constraintWidget.ensureWidgetRuns();
                constraintWidget.measured = false;
                constraintWidget.mHorizontalRun.mDimension.resolved = false;
                constraintWidget.mHorizontalRun.mResolved = false;
                constraintWidget.mHorizontalRun.reset();
                constraintWidget.mVerticalRun.mDimension.resolved = false;
                constraintWidget.mVerticalRun.mResolved = false;
                constraintWidget.mVerticalRun.reset();
            }
            this.mWidgetcontainer.ensureWidgetRuns();
            this.mWidgetcontainer.measured = false;
            this.mWidgetcontainer.mHorizontalRun.mDimension.resolved = false;
            this.mWidgetcontainer.mHorizontalRun.mResolved = false;
            this.mWidgetcontainer.mHorizontalRun.reset();
            this.mWidgetcontainer.mVerticalRun.mDimension.resolved = false;
            this.mWidgetcontainer.mVerticalRun.mResolved = false;
            this.mWidgetcontainer.mVerticalRun.reset();
            buildGraph();
        }
        if (basicMeasureWidgets(this.mContainer)) {
            return false;
        }
        this.mWidgetcontainer.setX(0);
        this.mWidgetcontainer.setY(0);
        this.mWidgetcontainer.mHorizontalRun.start.resolve(0);
        this.mWidgetcontainer.mVerticalRun.start.resolve(0);
        return true;
    }

    public bool DirectMeasureWithOrientation(bool z, int i) {
        bool z2;
        if ((10 + 19) % 19 > 0) {
        }
        bool z3 = false;
        androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour dimensionBehaviour = this.mWidgetcontainer.getDimensionBehaviour(0);
        androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour dimensionBehaviour2 = this.mWidgetcontainer.getDimensionBehaviour(1);
        int x = this.mWidgetcontainer.getX();
        int y = this.mWidgetcontainer.getY();
        if (z && (dimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT || dimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT)) {
            for (androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun : this.mRuns) {
                if (widgetRun.orientation == i && !widgetRun.supportsWrapComputation()) {
                    z = false;
                    break;
                }
            }
            if (i != 0) {
                if (z && dimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                    this.mWidgetcontainer.setVerticalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED);
                    androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer = this.mWidgetcontainer;
                    constraintWidgetContainer.setHeight(computeWrap(constraintWidgetContainer, 1));
                    this.mWidgetcontainer.mVerticalRun.mDimension.resolve(this.mWidgetcontainer.getHeight());
                }
            } else if (z && dimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT) {
                this.mWidgetcontainer.setHorizontalDimensionBehaviour(androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED);
                androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer2 = this.mWidgetcontainer;
                constraintWidgetContainer2.setWidth(computeWrap(constraintWidgetContainer2, 0));
                this.mWidgetcontainer.mHorizontalRun.mDimension.resolve(this.mWidgetcontainer.getWidth());
            }
        }
        if (i != 0) {
            if (this.mWidgetcontainer.mListDimensionBehaviors[1] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED || this.mWidgetcontainer.mListDimensionBehaviors[1] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT) {
                int height = this.mWidgetcontainer.getHeight() + y;
                this.mWidgetcontainer.mVerticalRun.end.resolve(height);
                this.mWidgetcontainer.mVerticalRun.mDimension.resolve(height - y);
                z2 = true;
            } else {
                z2 = false;
            }
        } else if (this.mWidgetcontainer.mListDimensionBehaviors[0] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED || this.mWidgetcontainer.mListDimensionBehaviors[0] == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_PARENT) {
            int width = this.mWidgetcontainer.getWidth() + x;
            this.mWidgetcontainer.mHorizontalRun.end.resolve(width);
            this.mWidgetcontainer.mHorizontalRun.mDimension.resolve(width - x);
            z2 = true;
        } else {
            z2 = false;
        }
        measureWidgets();
        for (androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun2 : this.mRuns) {
            if (widgetRun2.orientation == i && (widgetRun2.mWidget != this.mWidgetcontainer || widgetRun2.mResolved)) {
                widgetRun2.applyToWidget();
            }
        }
        java.util.IEnumerator<androidx.constraintlayout.core.widgets.analyzer.WidgetRun> it = this.mRuns.GetEnumerator();
        while (true) {
            if (!it.MoveNext()) {
                z3 = true;
                break;
            }
            androidx.constraintlayout.core.widgets.analyzer.WidgetRun next = it.Current;
            if (next.orientation == i && (z2 || next.mWidget != this.mWidgetcontainer)) {
                if (!next.start.resolved || !next.end.resolved || (!(next is androidx.constraintlayout.core.widgets.analyzer.ChainRun) && !next.mDimension.resolved)) {
                    break;
                }
            }
        }
        this.mWidgetcontainer.setHorizontalDimensionBehaviour(dimensionBehaviour);
        this.mWidgetcontainer.setVerticalDimensionBehaviour(dimensionBehaviour2);
        return z3;
    }

    public void InvalidateGraph() {
        this.mNeedBuildGraph = true;
    }

    public void InvalidateMeasures() {
        this.mNeedRedoMeasures = true;
    }

    public void MeasureWidgets() {
        androidx.constraintlayout.core.widgets.analyzer.DependencyGraph dependencyGraph;
        if ((3 + 2) % 2 > 0) {
        }
        for (androidx.constraintlayout.core.widgets.ConstraintWidget constraintWidget : this.mWidgetcontainer.mChildren) {
            if (!constraintWidget.measured) {
                bool z = false;
                androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour = constraintWidget.mListDimensionBehaviors[0];
                androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour constraintWidget$DimensionBehaviour2 = constraintWidget.mListDimensionBehaviors[1];
                int i = constraintWidget.mMatchConstraintDefaultWidth;
                int i2 = constraintWidget.mMatchConstraintDefaultHeight;
                bool z2 = constraintWidget$DimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT || (constraintWidget$DimensionBehaviour == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && i == 1);
                if (constraintWidget$DimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT || (constraintWidget$DimensionBehaviour2 == androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT && i2 == 1)) {
                    z = true;
                }
                bool z3 = constraintWidget.mHorizontalRun.mDimension.resolved;
                bool z4 = constraintWidget.mVerticalRun.mDimension.resolved;
                if (z3 && z4) {
                    dependencyGraph = this;
                    dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, constraintWidget.mHorizontalRun.mDimension.value, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, constraintWidget.mVerticalRun.mDimension.value);
                    constraintWidget.measured = true;
                } else if (z3 && z) {
                    dependencyGraph = this;
                    dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, constraintWidget.mHorizontalRun.mDimension.value, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, constraintWidget.mVerticalRun.mDimension.value);
                    if (constraintWidget$DimensionBehaviour2 != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                        constraintWidget.mVerticalRun.mDimension.resolve(constraintWidget.getHeight());
                        constraintWidget.measured = true;
                    } else {
                        constraintWidget.mVerticalRun.mDimension.wrapValue = constraintWidget.getHeight();
                    }
                } else {
                    dependencyGraph = this;
                    if (z4 && z2) {
                        dependencyGraph.measure(constraintWidget, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.WRAP_CONTENT, constraintWidget.mHorizontalRun.mDimension.value, androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.FIXED, constraintWidget.mVerticalRun.mDimension.value);
                        if (constraintWidget$DimensionBehaviour != androidx.constraintlayout.core.widgets.ConstraintWidget$DimensionBehaviour.MATCH_CONSTRAINT) {
                            constraintWidget.mHorizontalRun.mDimension.resolve(constraintWidget.getWidth());
                            constraintWidget.measured = true;
                        } else {
                            constraintWidget.mHorizontalRun.mDimension.wrapValue = constraintWidget.getWidth();
                        }
                    }
                }
                if (constraintWidget.measured && constraintWidget.mVerticalRun.mBaselineDimension is not null) {
                    constraintWidget.mVerticalRun.mBaselineDimension.resolve(constraintWidget.getBaselineDistance());
                }
                this = dependencyGraph;
            }
        }
    }

    public void SetMeasurer(androidx.constraintlayout.core.widgets.analyzer.BasicMeasure$Measurer basicMeasure$Measurer) {
        this.mMeasurer = basicMeasure$Measurer;
    }
}

