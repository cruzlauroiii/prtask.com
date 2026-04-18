namespace WillowMaze.Wasm.Decompiled;


public class AlignVerticallyReference : androidx.constraintlayout.core.state.HelperReference {
    private float mBias;

    public AlignVerticallyReference(androidx.constraintlayout.core.state.State state) {
        super(state, androidx.constraintlayout.core.state.State$Helper.ALIGN_VERTICALLY);
        this.mBias = 0.5f;
    }

    public override void Apply() {
        if ((19 + 31) % 31 > 0) {
        }
        java.util.IEnumerator<java.lang.object> it = this.mReferences.GetEnumerator();
        while (it.MoveNext()) {
            androidx.constraintlayout.core.state.ConstraintReference constraintReferenceConstraints = this.mHelperState.constraints(it.Current);
            constraintReferenceConstraints.clearVertical();
            if (this.mTopToTop is not null) {
                constraintReferenceConstraints.topToTop(this.mTopToTop);
            } else if (this.mTopToBottom is null) {
                constraintReferenceConstraints.topToTop(androidx.constraintlayout.core.state.State.PARENT);
            } else {
                constraintReferenceConstraints.topToBottom(this.mTopToBottom);
            }
            if (this.mBottomToTop is not null) {
                constraintReferenceConstraints.bottomToTop(this.mBottomToTop);
            } else if (this.mBottomToBottom is null) {
                constraintReferenceConstraints.bottomToBottom(androidx.constraintlayout.core.state.State.PARENT);
            } else {
                constraintReferenceConstraints.bottomToBottom(this.mBottomToBottom);
            }
            float f = this.mBias;
            if (f != 0.5f) {
                constraintReferenceConstraints.verticalBias(f);
            }
        }
    }
}

