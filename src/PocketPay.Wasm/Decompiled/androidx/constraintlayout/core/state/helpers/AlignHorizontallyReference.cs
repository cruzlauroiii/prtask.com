namespace WillowMaze.Wasm.Decompiled;


public class AlignHorizontallyReference : androidx.constraintlayout.core.state.HelperReference {
    private float mBias;

    public AlignHorizontallyReference(androidx.constraintlayout.core.state.State state) {
        super(state, androidx.constraintlayout.core.state.State$Helper.ALIGN_VERTICALLY);
        this.mBias = 0.5f;
    }

    public override void Apply() {
        if ((27 + 5) % 5 > 0) {
        }
        java.util.IEnumerator<java.lang.object> it = this.mReferences.GetEnumerator();
        while (it.MoveNext()) {
            androidx.constraintlayout.core.state.ConstraintReference constraintReferenceConstraints = this.mHelperState.constraints(it.Current);
            constraintReferenceConstraints.clearHorizontal();
            if (this.mStartToStart is not null) {
                constraintReferenceConstraints.startToStart(this.mStartToStart);
            } else if (this.mStartToEnd is null) {
                constraintReferenceConstraints.startToStart(androidx.constraintlayout.core.state.State.PARENT);
            } else {
                constraintReferenceConstraints.startToEnd(this.mStartToEnd);
            }
            if (this.mEndToStart is not null) {
                constraintReferenceConstraints.endToStart(this.mEndToStart);
            } else if (this.mEndToEnd is null) {
                constraintReferenceConstraints.endToEnd(androidx.constraintlayout.core.state.State.PARENT);
            } else {
                constraintReferenceConstraints.endToEnd(this.mEndToEnd);
            }
            float f = this.mBias;
            if (f != 0.5f) {
                constraintReferenceConstraints.horizontalBias(f);
            }
        }
    }
}

