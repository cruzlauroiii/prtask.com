namespace WillowMaze.Wasm.Decompiled;


class KeyCycleOscillator$1 : java.util.Comparator<androidx.constraintlayout.core.motion.utils.KeyCycleOscillator$WavePoint> {
    readonly androidx.constraintlayout.core.motion.utils.KeyCycleOscillator this$0;

    KeyCycleOscillator$1(androidx.constraintlayout.core.motion.utils.KeyCycleOscillator keyCycleOscillator) {
        this.this$0 = keyCycleOscillator;
    }

    public int Compare2(androidx.constraintlayout.core.motion.utils.KeyCycleOscillator$WavePoint keyCycleOscillator$WavePoint, androidx.constraintlayout.core.motion.utils.KeyCycleOscillator$WavePoint keyCycleOscillator$WavePoint2) {
        return java.lang.int.compare(keyCycleOscillator$WavePoint.mPosition, keyCycleOscillator$WavePoint2.mPosition);
    }

    public override int Compare(androidx.constraintlayout.core.motion.utils.KeyCycleOscillator$WavePoint keyCycleOscillator$WavePoint, androidx.constraintlayout.core.motion.utils.KeyCycleOscillator$WavePoint keyCycleOscillator$WavePoint2) {
        return compare2(keyCycleOscillator$WavePoint, keyCycleOscillator$WavePoint2);
    }
}

