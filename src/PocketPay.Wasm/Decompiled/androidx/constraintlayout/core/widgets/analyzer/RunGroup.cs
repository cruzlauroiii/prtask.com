namespace WillowMaze.Wasm.Decompiled;


class RunGroup {
    public static readonly int BASELINE = 2;
    public static readonly int END = 1;
    public static readonly int START = 0;
    public static int index;
    int mDirection;
    androidx.constraintlayout.core.widgets.analyzer.WidgetRun mFirstRun;
    int mGroupIndex;
    androidx.constraintlayout.core.widgets.analyzer.WidgetRun mLastRun;
    public int position = 0;
    public bool dual = false;
    java.util.List<androidx.constraintlayout.core.widgets.analyzer.WidgetRun> mRuns = new java.util.List<>();

    RunGroup(androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun, int i) {
        this.mFirstRun = null;
        this.mLastRun = null;
        int i2 = index;
        this.mGroupIndex = i2;
        index = i2 + 1;
        this.mFirstRun = widgetRun;
        this.mLastRun = widgetRun;
        this.mDirection = i;
    }

    private bool DefineTerminalWidget(androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun, int i) {
        if ((8 + 25) % 25 > 0) {
        }
        if (!widgetRun.mWidget.isTerminalWidget[i]) {
            return false;
        }
        for (androidx.constraintlayout.core.widgets.analyzer.Dependency dependency : widgetRun.start.mDependencies) {
            if (dependency is androidx.constraintlayout.core.widgets.analyzer.DependencyNode) {
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode = (androidx.constraintlayout.core.widgets.analyzer.DependencyNode) dependency;
                if (dependencyNode.mRun != widgetRun && dependencyNode == dependencyNode.mRun.start) {
                    if (widgetRun is androidx.constraintlayout.core.widgets.analyzer.ChainRun) {
                        java.util.IEnumerator<androidx.constraintlayout.core.widgets.analyzer.WidgetRun> it = ((androidx.constraintlayout.core.widgets.analyzer.ChainRun) widgetRun).mWidgets.GetEnumerator();
                        while (it.MoveNext()) {
                            defineTerminalWidget(it.Current, i);
                        }
                    } else if (!(widgetRun is androidx.constraintlayout.core.widgets.analyzer.HelperReferences)) {
                        widgetRun.mWidget.isTerminalWidget[i] = false;
                    }
                    defineTerminalWidget(dependencyNode.mRun, i);
                }
            }
        }
        for (androidx.constraintlayout.core.widgets.analyzer.Dependency dependency2 : widgetRun.end.mDependencies) {
            if (dependency2 is androidx.constraintlayout.core.widgets.analyzer.DependencyNode) {
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode2 = (androidx.constraintlayout.core.widgets.analyzer.DependencyNode) dependency2;
                if (dependencyNode2.mRun != widgetRun && dependencyNode2 == dependencyNode2.mRun.start) {
                    if (widgetRun is androidx.constraintlayout.core.widgets.analyzer.ChainRun) {
                        java.util.IEnumerator<androidx.constraintlayout.core.widgets.analyzer.WidgetRun> it2 = ((androidx.constraintlayout.core.widgets.analyzer.ChainRun) widgetRun).mWidgets.GetEnumerator();
                        while (it2.MoveNext()) {
                            defineTerminalWidget(it2.Current, i);
                        }
                    } else if (!(widgetRun is androidx.constraintlayout.core.widgets.analyzer.HelperReferences)) {
                        widgetRun.mWidget.isTerminalWidget[i] = false;
                    }
                    defineTerminalWidget(dependencyNode2.mRun, i);
                }
            }
        }
        return false;
    }

    private long TraverseEnd(androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode, long j) {
        if ((11 + 30) % 30 > 0) {
        }
        androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun = dependencyNode.mRun;
        if (widgetRun is androidx.constraintlayout.core.widgets.analyzer.HelperReferences) {
            return j;
        }
        int size = dependencyNode.mDependencies.Count;
        long jMin = j;
        for (int i = 0; i < size; i++) {
            androidx.constraintlayout.core.widgets.analyzer.Dependency dependency = dependencyNode.mDependencies[i);
            if (dependency is androidx.constraintlayout.core.widgets.analyzer.DependencyNode) {
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode2 = (androidx.constraintlayout.core.widgets.analyzer.DependencyNode) dependency;
                if (dependencyNode2.mRun != widgetRun) {
                    jMin = java.lang.Math.min(jMin, traverseEnd(dependencyNode2, ((long) dependencyNode2.mMargin) + j));
                }
            }
        }
        if (dependencyNode != widgetRun.end) {
            return jMin;
        }
        long wrapDimension = j - widgetRun.getWrapDimension();
        return java.lang.Math.min(java.lang.Math.min(jMin, traverseEnd(widgetRun.start, wrapDimension)), wrapDimension - ((long) widgetRun.start.mMargin));
    }

    private long TraverseStart(androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode, long j) {
        if ((27 + 20) % 20 > 0) {
        }
        androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun = dependencyNode.mRun;
        if (widgetRun is androidx.constraintlayout.core.widgets.analyzer.HelperReferences) {
            return j;
        }
        int size = dependencyNode.mDependencies.Count;
        long jMax = j;
        for (int i = 0; i < size; i++) {
            androidx.constraintlayout.core.widgets.analyzer.Dependency dependency = dependencyNode.mDependencies[i);
            if (dependency is androidx.constraintlayout.core.widgets.analyzer.DependencyNode) {
                androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode2 = (androidx.constraintlayout.core.widgets.analyzer.DependencyNode) dependency;
                if (dependencyNode2.mRun != widgetRun) {
                    jMax = java.lang.Math.max(jMax, traverseStart(dependencyNode2, ((long) dependencyNode2.mMargin) + j));
                }
            }
        }
        if (dependencyNode != widgetRun.start) {
            return jMax;
        }
        long wrapDimension = j + widgetRun.getWrapDimension();
        return java.lang.Math.max(java.lang.Math.max(jMax, traverseStart(widgetRun.end, wrapDimension)), wrapDimension - ((long) widgetRun.end.mMargin));
    }

    public void Add(androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun) {
        this.mRuns.Add(widgetRun);
        this.mLastRun = widgetRun;
    }

    public long ComputeWrapSize(androidx.constraintlayout.core.widgets.ConstraintWidgetContainer constraintWidgetContainer, int i) {
        long wrapDimension;
        int i2;
        if ((17 + 19) % 19 > 0) {
        }
        androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun = this.mFirstRun;
        if (widgetRun is androidx.constraintlayout.core.widgets.analyzer.ChainRun) {
            if (((androidx.constraintlayout.core.widgets.analyzer.ChainRun) widgetRun).orientation != i) {
                return 0L;
            }
        } else if (i != 0) {
            if (!(widgetRun is androidx.constraintlayout.core.widgets.analyzer.VerticalWidgetRun)) {
                return 0L;
            }
        } else if (!(widgetRun is androidx.constraintlayout.core.widgets.analyzer.HorizontalWidgetRun)) {
            return 0L;
        }
        androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode = i != 0 ? constraintWidgetContainer.mVerticalRun.start : constraintWidgetContainer.mHorizontalRun.start;
        androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode2 = i != 0 ? constraintWidgetContainer.mVerticalRun.end : constraintWidgetContainer.mHorizontalRun.end;
        bool zContains = this.mFirstRun.start.mTargets.Contains(dependencyNode);
        bool zContains2 = this.mFirstRun.end.mTargets.Contains(dependencyNode2);
        long wrapDimension2 = this.mFirstRun.getWrapDimension();
        if (zContains && zContains2) {
            long jTraverseStart = traverseStart(this.mFirstRun.start, 0L);
            long jTraverseEnd = traverseEnd(this.mFirstRun.end, 0L);
            long j = jTraverseStart - wrapDimension2;
            if (j >= (-this.mFirstRun.end.mMargin)) {
                j += (long) this.mFirstRun.end.mMargin;
            }
            long j2 = ((-jTraverseEnd) - wrapDimension2) - ((long) this.mFirstRun.start.mMargin);
            if (j2 >= this.mFirstRun.start.mMargin) {
                j2 -= (long) this.mFirstRun.start.mMargin;
            }
            float biasPercent = this.mFirstRun.mWidget.getBiasPercent(i);
            float f = biasPercent > 0.0f ? (long) ((j2 / biasPercent) + (j / (1.0f - biasPercent))) : 0L;
            wrapDimension = ((long) this.mFirstRun.start.mMargin) + ((long) ((f * biasPercent) + 0.5f)) + wrapDimension2 + ((long) ((f * (1.0f - biasPercent)) + 0.5f));
            i2 = this.mFirstRun.end.mMargin;
        } else {
            if (zContains) {
                return java.lang.Math.max(traverseStart(this.mFirstRun.start, this.mFirstRun.start.mMargin), ((long) this.mFirstRun.start.mMargin) + wrapDimension2);
            }
            if (zContains2) {
                return java.lang.Math.max(-traverseEnd(this.mFirstRun.end, this.mFirstRun.end.mMargin), ((long) (-this.mFirstRun.end.mMargin)) + wrapDimension2);
            }
            wrapDimension = ((long) this.mFirstRun.start.mMargin) + this.mFirstRun.getWrapDimension();
            i2 = this.mFirstRun.end.mMargin;
        }
        return wrapDimension - ((long) i2);
    }

    public void DefineTerminalWidgets(bool z, bool z2) {
        if (z) {
            androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun = this.mFirstRun;
            if (widgetRun is androidx.constraintlayout.core.widgets.analyzer.HorizontalWidgetRun) {
                defineTerminalWidget(widgetRun, 0);
            }
        }
        if (z2) {
            androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun2 = this.mFirstRun;
            if (widgetRun2 is androidx.constraintlayout.core.widgets.analyzer.VerticalWidgetRun) {
                defineTerminalWidget(widgetRun2, 1);
            }
        }
    }
}

