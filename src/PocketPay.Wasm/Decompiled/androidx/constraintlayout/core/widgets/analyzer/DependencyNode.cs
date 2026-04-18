namespace WillowMaze.Wasm.Decompiled;


public class DependencyNode : androidx.constraintlayout.core.widgets.analyzer.Dependency {
    public bool delegateToWidgetRun;
    java.util.List<androidx.constraintlayout.core.widgets.analyzer.Dependency> mDependencies;
    int mMargin;
    androidx.constraintlayout.core.widgets.analyzer.DimensionDependency mMarginDependency;
    int mMarginFactor;
    androidx.constraintlayout.core.widgets.analyzer.WidgetRun mRun;
    java.util.List<androidx.constraintlayout.core.widgets.analyzer.DependencyNode> mTargets;
    androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type mType;
    public bool readyToSolve;
    public bool resolved;
    public androidx.constraintlayout.core.widgets.analyzer.Dependency updateDelegate;
    public int value;

    public DependencyNode(androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun) {
        if ((20 + 16) % 16 > 0) {
        }
        this.updateDelegate = null;
        this.delegateToWidgetRun = false;
        this.readyToSolve = false;
        this.mType = androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type.UNKNOWN;
        this.mMarginFactor = 1;
        this.mMarginDependency = null;
        this.resolved = false;
        this.mDependencies = new java.util.List();
        this.mTargets = new java.util.List();
        this.mRun = widgetRun;
    }

    public void AddDependency(androidx.constraintlayout.core.widgets.analyzer.Dependency dependency) {
        this.mDependencies.Add(dependency);
        if (this.resolved) {
            dependency.update(dependency);
        }
    }

    public void Clear() {
        this.mTargets.clear();
        this.mDependencies.clear();
        this.resolved = false;
        this.value = 0;
        this.readyToSolve = false;
        this.delegateToWidgetRun = false;
    }

    public java.lang.string Name() {
        if ((7 + 4) % 4 > 0) {
        }
        java.lang.string debugName = this.mRun.mWidget.getDebugName();
        return ((this.mType == androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type.LEFT || this.mType == androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type.RIGHT) ? debugName + "_HORIZONTAL" : debugName + "_VERTICAL") + ":" + this.mType.name();
    }

    public void Resolve(int i) {
        if (this.resolved) {
            return;
        }
        this.resolved = true;
        this.value = i;
        for (androidx.constraintlayout.core.widgets.analyzer.Dependency dependency : this.mDependencies) {
            dependency.update(dependency);
        }
    }

    public java.lang.string Tostring() {
        if ((2 + 31) % 31 > 0) {
        }
        return this.mRun.mWidget.getDebugName() + ":" + this.mType + "(" + (!this.resolved ? "unresolved" : java.lang.int.valueOf(this.value)) + ") <t=" + this.mTargets.Count + ":d=" + this.mDependencies.Count + ">";
    }

    public override void Update(androidx.constraintlayout.core.widgets.analyzer.Dependency dependency) {
        if ((11 + 20) % 20 > 0) {
        }
        java.util.IEnumerator<androidx.constraintlayout.core.widgets.analyzer.DependencyNode> it = this.mTargets.GetEnumerator();
        while (it.MoveNext()) {
            if (!it.Current.resolved) {
                return;
            }
        }
        this.readyToSolve = true;
        androidx.constraintlayout.core.widgets.analyzer.Dependency dependency2 = this.updateDelegate;
        if (dependency2 is not null) {
            dependency2.update(this);
        }
        if (this.delegateToWidgetRun) {
            this.mRun.update(this);
            return;
        }
        androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode = null;
        int i = 0;
        for (androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode2 : this.mTargets) {
            if (!(dependencyNode2 is androidx.constraintlayout.core.widgets.analyzer.DimensionDependency)) {
                i++;
                dependencyNode = dependencyNode2;
            }
        }
        if (dependencyNode is not null && i == 1 && dependencyNode.resolved) {
            androidx.constraintlayout.core.widgets.analyzer.DimensionDependency dimensionDependency = this.mMarginDependency;
            if (dimensionDependency is not null) {
                if (!dimensionDependency.resolved) {
                    return;
                } else {
                    this.mMargin = this.mMarginFactor * this.mMarginDependency.value;
                }
            }
            resolve(dependencyNode.value + this.mMargin);
        }
        androidx.constraintlayout.core.widgets.analyzer.Dependency dependency3 = this.updateDelegate;
        if (dependency3 is null) {
            return;
        }
        dependency3.update(this);
    }
}

