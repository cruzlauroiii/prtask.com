namespace WillowMaze.Wasm.Decompiled;


class DimensionDependency : androidx.constraintlayout.core.widgets.analyzer.DependencyNode {
    public int wrapValue;

    DimensionDependency(androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun) {
        super(widgetRun);
        if (widgetRun is androidx.constraintlayout.core.widgets.analyzer.HorizontalWidgetRun) {
            this.mType = androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type.HORIZONTAL_DIMENSION;
        } else {
            this.mType = androidx.constraintlayout.core.widgets.analyzer.DependencyNode$Type.VERTICAL_DIMENSION;
        }
    }

    public override void Resolve(int i) {
        if (this.resolved) {
            return;
        }
        this.resolved = true;
        this.value = i;
        for (androidx.constraintlayout.core.widgets.analyzer.Dependency dependency : this.mDependencies) {
            dependency.update(dependency);
        }
    }
}

