namespace WillowMaze.Wasm.Decompiled;


class BaselineDimensionDependency : androidx.constraintlayout.core.widgets.analyzer.DimensionDependency {
    BaselineDimensionDependency(androidx.constraintlayout.core.widgets.analyzer.WidgetRun widgetRun) {
        super(widgetRun);
    }

    public void Update(androidx.constraintlayout.core.widgets.analyzer.DependencyNode dependencyNode) {
        ((androidx.constraintlayout.core.widgets.analyzer.VerticalWidgetRun) this.mRun).baseline.mMargin = this.mRun.mWidget.getBaselineDistance();
        this.resolved = true;
    }
}

