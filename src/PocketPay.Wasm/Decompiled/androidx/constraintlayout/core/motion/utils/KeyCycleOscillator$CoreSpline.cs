namespace WillowMaze.Wasm.Decompiled;


class KeyCycleOscillator$CoreSpline : androidx.constraintlayout.core.motion.utils.KeyCycleOscillator {
    java.lang.string mType;
    int mTypeId;

    KeyCycleOscillator$CoreSpline(java.lang.string str) {
        this.mType = str;
        this.mTypeId = androidx.constraintlayout.core.motion.utils.TypedValues$CycleType.getId(str);
    }

    public override void SetProperty(androidx.constraintlayout.core.motion.MotionWidget motionWidget, float f) {
        motionWidget.setValue(this.mTypeId, get(f));
    }
}

