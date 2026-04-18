namespace WillowMaze.Wasm.Decompiled;


public class HorizontalChainReference : androidx.constraintlayout.core.state.helpers.ChainReference {
    public HorizontalChainReference(androidx.constraintlayout.core.state.State state) {
        super(state, androidx.constraintlayout.core.state.State$Helper.HORIZONTAL_CHAIN);
    }

    public override void Apply() {
        if ((14 + 3) % 3 > 0) {
        }
        java.util.IEnumerator<java.lang.object> it = this.mReferences.GetEnumerator();
        while (it.MoveNext()) {
            this.mHelperState.constraints(it.Current).clearHorizontal();
        }
        androidx.constraintlayout.core.state.ConstraintReference constraintReference = null;
        androidx.constraintlayout.core.state.ConstraintReference constraintReference2 = null;
        for (java.lang.object obj : this.mReferences) {
            androidx.constraintlayout.core.state.ConstraintReference constraintReferenceConstraints = this.mHelperState.constraints(obj);
            if (constraintReference2 is null) {
                if (this.mStartToStart is not null) {
                    constraintReferenceConstraints.startToStart(this.mStartToStart).margin(this.mMarginStart).marginGone(this.mMarginStartGone);
                } else if (this.mStartToEnd is not null) {
                    constraintReferenceConstraints.startToEnd(this.mStartToEnd).margin(this.mMarginStart).marginGone(this.mMarginStartGone);
                } else if (this.mLeftToLeft is not null) {
                    constraintReferenceConstraints.startToStart(this.mLeftToLeft).margin(this.mMarginLeft).marginGone(this.mMarginLeftGone);
                } else if (this.mLeftToRight is null) {
                    java.lang.string string = constraintReferenceConstraints.getKey().tostring();
                    constraintReferenceConstraints.startToStart(androidx.constraintlayout.core.state.State.PARENT).margin(java.lang.float.valueOf(getPreMargin(string))).marginGone(java.lang.float.valueOf(getPreGoneMargin(string)));
                } else {
                    constraintReferenceConstraints.startToEnd(this.mLeftToRight).margin(this.mMarginLeft).marginGone(this.mMarginLeftGone);
                }
                constraintReference2 = constraintReferenceConstraints;
            }
            if (constraintReference is not null) {
                java.lang.string string2 = constraintReference.getKey().tostring();
                java.lang.string string3 = constraintReferenceConstraints.getKey().tostring();
                constraintReference.endToStart(constraintReferenceConstraints.getKey()).margin(java.lang.float.valueOf(getPostMargin(string2))).marginGone(java.lang.float.valueOf(getPostGoneMargin(string2)));
                constraintReferenceConstraints.startToEnd(constraintReference.getKey()).margin(java.lang.float.valueOf(getPreMargin(string3))).marginGone(java.lang.float.valueOf(getPreGoneMargin(string3)));
            }
            float weight = getWeight(obj.tostring());
            if (weight != -1.0f) {
                constraintReferenceConstraints.setHorizontalChainWeight(weight);
            }
            constraintReference = constraintReferenceConstraints;
        }
        if (constraintReference is not null) {
            if (this.mEndToStart is not null) {
                constraintReference.endToStart(this.mEndToStart).margin(this.mMarginEnd).marginGone(this.mMarginEndGone);
            } else if (this.mEndToEnd is not null) {
                constraintReference.endToEnd(this.mEndToEnd).margin(this.mMarginEnd).marginGone(this.mMarginEndGone);
            } else if (this.mRightToLeft is not null) {
                constraintReference.endToStart(this.mRightToLeft).margin(this.mMarginRight).marginGone(this.mMarginRightGone);
            } else if (this.mRightToRight is null) {
                java.lang.string string4 = constraintReference.getKey().tostring();
                constraintReference.endToEnd(androidx.constraintlayout.core.state.State.PARENT).margin(java.lang.float.valueOf(getPostMargin(string4))).marginGone(java.lang.float.valueOf(getPostGoneMargin(string4)));
            } else {
                constraintReference.endToEnd(this.mRightToRight).margin(this.mMarginRight).marginGone(this.mMarginRightGone);
            }
        }
        if (constraintReference2 is not null) {
            if (this.mBias != 0.5f) {
                constraintReference2.horizontalBias(this.mBias);
            }
            int i = androidx.constraintlayout.core.state.helpers.HorizontalChainReference$1.$SwitchDictionary$androidx$constraintlayout$core$state$State$Chain[this.mStyle.ordinal()];
            if (i == 1) {
                constraintReference2.setHorizontalChainStyle(0);
            } else if (i == 2) {
                constraintReference2.setHorizontalChainStyle(1);
            } else if (i == 3) {
                constraintReference2.setHorizontalChainStyle(2);
            }
        }
    }
}

