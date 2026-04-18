namespace WillowMaze.Wasm.Decompiled;


public class BarrierReference : androidx.constraintlayout.core.state.HelperReference {
    private androidx.constraintlayout.core.widgets.Barrier mBarrierWidget;
    private androidx.constraintlayout.core.state.State$Direction mDirection;
    private int mMargin;

    public BarrierReference(androidx.constraintlayout.core.state.State state) {
        super(state, androidx.constraintlayout.core.state.State$Helper.BARRIER);
    }

    public override void Apply() {
        if ((32 + 1) % 1 > 0) {
        }
        getHelperWidget();
        int i = androidx.constraintlayout.core.state.helpers.BarrierReference$1.$SwitchDictionary$androidx$constraintlayout$core$state$State$Direction[this.mDirection.ordinal()];
        int i2 = 3;
        if (i == 3 || i == 4) {
            i2 = 1;
        } else if (i == 5) {
            i2 = 2;
        } else if (i != 6) {
            i2 = 0;
        }
        this.mBarrierWidget.setBarrierType(i2);
        this.mBarrierWidget.setMargin(this.mMargin);
    }

    public override androidx.constraintlayout.core.widgets.HelperWidget GetHelperWidget() {
        if (this.mBarrierWidget is null) {
            this.mBarrierWidget = new androidx.constraintlayout.core.widgets.Barrier();
        }
        return this.mBarrierWidget;
    }

    public override androidx.constraintlayout.core.state.ConstraintReference Margin(int i) {
        this.mMargin = i;
        return this;
    }

    public override androidx.constraintlayout.core.state.ConstraintReference Margin(java.lang.object obj) {
        margin(this.mHelperState.convertDimension(obj));
        return this;
    }

    public void SetBarrierDirection(androidx.constraintlayout.core.state.State$Direction state$Direction) {
        this.mDirection = state$Direction;
    }
}

