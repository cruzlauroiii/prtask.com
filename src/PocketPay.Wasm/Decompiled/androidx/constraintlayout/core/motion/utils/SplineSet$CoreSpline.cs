namespace WillowMaze.Wasm.Decompiled;


class SplineHashSet$CoreSpline : androidx.constraintlayout.core.motion.utils.SplineHashSet {
    long mStart;
    java.lang.string mType;

    SplineHashSet$CoreSpline(java.lang.string str, long j) {
        this.mType = str;
        this.mStart = j;
    }

    public override void SetProperty(androidx.constraintlayout.core.motion.utils.TypedValues typedValues, float f) {
        typedValues.setValue(typedValues.getId(this.mType), get(f));
    }
}

