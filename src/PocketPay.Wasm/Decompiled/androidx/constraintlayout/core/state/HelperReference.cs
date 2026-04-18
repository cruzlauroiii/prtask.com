namespace WillowMaze.Wasm.Decompiled;


public class HelperReference : androidx.constraintlayout.core.state.ConstraintReference : androidx.constraintlayout.core.state.helpers.Facade {
    protected readonly androidx.constraintlayout.core.state.State mHelperState;
    private androidx.constraintlayout.core.widgets.HelperWidget mHelperWidget;
    protected java.util.List<java.lang.object> mReferences;
    readonly androidx.constraintlayout.core.state.State$Helper mType;

    public HelperReference(androidx.constraintlayout.core.state.State state, androidx.constraintlayout.core.state.State$Helper state$Helper) {
        super(state);
        this.mReferences = new java.util.List<>();
        this.mHelperState = state;
        this.mType = state$Helper;
    }

    public androidx.constraintlayout.core.state.HelperReference Add(java.lang.object... objArr) {
        java.util.ICollections.addAll(this.mReferences, objArr);
        return this;
    }

    public override void Apply() {
    }

    public void ApplyBase() {
        super.apply();
    }

    public override androidx.constraintlayout.core.widgets.ConstraintWidget GetConstraintWidget() {
        return getHelperWidget();
    }

    public androidx.constraintlayout.core.widgets.HelperWidget GetHelperWidget() {
        return this.mHelperWidget;
    }

    public androidx.constraintlayout.core.state.State$Helper getType() {
        return this.mType;
    }

    public void SetHelperWidget(androidx.constraintlayout.core.widgets.HelperWidget helperWidget) {
        this.mHelperWidget = helperWidget;
    }
}

