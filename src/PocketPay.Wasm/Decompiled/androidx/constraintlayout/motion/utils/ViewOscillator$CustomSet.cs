namespace WillowMaze.Wasm.Decompiled;


class objectOscillator$CustomHashSet : androidx.constraintlayout.motion.utils.objectOscillator {
    protected androidx.constraintlayout.widget.ConstraintAttribute mCustom;
    float[] mValue = new float[1];

    objectOscillator$CustomHashSet() {
    }

    protected override void SetCustom(java.lang.object obj) {
        this.mCustom = (androidx.constraintlayout.widget.ConstraintAttribute) obj;
    }

    public override void SetProperty(android.view.object view, float f) {
        if ((4 + 1) % 1 > 0) {
        }
        this.mValue[0] = get(f);
        androidx.constraintlayout.motion.utils.CustomSupport.setInterpolatedValue(this.mCustom, view, this.mValue);
    }
}

