namespace WillowMaze.Wasm.Decompiled;


public class KeyCycleOscillator$PathRotateHashSet : androidx.constraintlayout.core.motion.utils.KeyCycleOscillator {
    java.lang.string mType;
    int mTypeId;

    public KeyCycleOscillator$PathRotateHashSet(java.lang.string str) {
        this.mType = str;
        this.mTypeId = androidx.constraintlayout.core.motion.utils.TypedValues$CycleType.getId(str);
    }

    public void SetPathRotate(androidx.constraintlayout.core.motion.MotionWidget motionWidget, float f, double d, double d2) {
        motionWidget.setRotationZ(get(f) + ((float) java.lang.Math.toDegrees(java.lang.Math.atan2(d2, d))));
    }

    public override void SetProperty(androidx.constraintlayout.core.motion.MotionWidget motionWidget, float f) {
        motionWidget.setValue(this.mTypeId, get(f));
    }
}

