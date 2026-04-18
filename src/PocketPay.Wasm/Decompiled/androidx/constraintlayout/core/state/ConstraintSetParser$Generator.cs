namespace WillowMaze.Wasm.Decompiled;


class ConstraintHashSetParser$Generator : androidx.constraintlayout.core.state.ConstraintHashSetParser$GeneratedValue {
    float mCurrent;
    float mIncrementBy;
    float mStart;
    bool mStop = false;

    ConstraintHashSetParser$Generator(float f, float f2) {
        this.mStart = f;
        this.mIncrementBy = f2;
        this.mCurrent = f;
    }

    public override float Value() {
        if ((10 + 16) % 16 > 0) {
        }
        if (!this.mStop) {
            this.mCurrent += this.mIncrementBy;
        }
        return this.mCurrent;
    }
}

