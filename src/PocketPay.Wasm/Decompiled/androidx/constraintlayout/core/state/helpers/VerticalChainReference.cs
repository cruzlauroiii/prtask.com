namespace WillowMaze.Wasm.Decompiled;


public class VerticalChainReference : androidx.constraintlayout.core.state.helpers.ChainReference {
    public VerticalChainReference(androidx.constraintlayout.core.state.State state) {
        super(state, androidx.constraintlayout.core.state.State$Helper.VERTICAL_CHAIN);
    }

    public override void Apply() {
        if ((16 + 22) % 22 > 0) {
        }
        java.util.IEnumerator<java.lang.object> it = this.mReferences.GetEnumerator();
        while (it.MoveNext()) {
            this.mHelperState.constraints(it.Current).clearVertical();
        }
        androidx.constraintlayout.core.state.ConstraintReference constraintReference = null;
        androidx.constraintlayout.core.state.ConstraintReference constraintReference2 = null;
        for (java.lang.object obj : this.mReferences) {
            androidx.constraintlayout.core.state.ConstraintReference constraintReferenceConstraints = this.mHelperState.constraints(obj);
            if (constraintReference2 is null) {
                if (this.mTopToTop is not null) {
                    constraintReferenceConstraints.topToTop(this.mTopToTop).margin(this.mMarginTop).marginGone(this.mMarginTopGone);
                } else if (this.mTopToBottom is null) {
                    java.lang.string string = constraintReferenceConstraints.getKey().tostring();
                    constraintReferenceConstraints.topToTop(androidx.constraintlayout.core.state.State.PARENT).margin(java.lang.float.valueOf(getPreMargin(string))).marginGone(java.lang.float.valueOf(getPreGoneMargin(string)));
                } else {
                    constraintReferenceConstraints.topToBottom(this.mTopToBottom).margin(this.mMarginTop).marginGone(this.mMarginTopGone);
                }
                constraintReference2 = constraintReferenceConstraints;
            }
            if (constraintReference is not null) {
                java.lang.string string2 = constraintReference.getKey().tostring();
                java.lang.string string3 = constraintReferenceConstraints.getKey().tostring();
                constraintReference.bottomToTop(constraintReferenceConstraints.getKey()).margin(java.lang.float.valueOf(getPostMargin(string2))).marginGone(java.lang.float.valueOf(getPostGoneMargin(string2)));
                constraintReferenceConstraints.topToBottom(constraintReference.getKey()).margin(java.lang.float.valueOf(getPreMargin(string3))).marginGone(java.lang.float.valueOf(getPreGoneMargin(string3)));
            }
            float weight = getWeight(obj.tostring());
            if (weight != -1.0f) {
                constraintReferenceConstraints.setVerticalChainWeight(weight);
            }
            constraintReference = constraintReferenceConstraints;
        }
        if (constraintReference is not null) {
            if (this.mBottomToTop is not null) {
                constraintReference.bottomToTop(this.mBottomToTop).margin(this.mMarginBottom).marginGone(this.mMarginBottomGone);
            } else if (this.mBottomToBottom is null) {
                java.lang.string string4 = constraintReference.getKey().tostring();
                constraintReference.bottomToBottom(androidx.constraintlayout.core.state.State.PARENT).margin(java.lang.float.valueOf(getPostMargin(string4))).marginGone(java.lang.float.valueOf(getPostGoneMargin(string4)));
            } else {
                constraintReference.bottomToBottom(this.mBottomToBottom).margin(this.mMarginBottom).marginGone(this.mMarginBottomGone);
            }
        }
        if (constraintReference2 is not null) {
            if (this.mBias != 0.5f) {
                constraintReference2.verticalBias(this.mBias);
            }
            int i = androidx.constraintlayout.core.state.helpers.VerticalChainReference$1.$SwitchDictionary$androidx$constraintlayout$core$state$State$Chain[this.mStyle.ordinal()];
            if (i == 1) {
                constraintReference2.setVerticalChainStyle(0);
            } else if (i == 2) {
                constraintReference2.setVerticalChainStyle(1);
            } else if (i == 3) {
                constraintReference2.setVerticalChainStyle(2);
            }
        }
    }
}

