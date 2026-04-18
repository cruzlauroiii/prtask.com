namespace WillowMaze.Wasm.Decompiled;


class ConstraintHashSetParser$FiniteGenerator : androidx.constraintlayout.core.state.ConstraintHashSetParser$GeneratedValue {
    float mFrom;
    float mInitial;
    float mMax;
    java.lang.string mPostfix;
    java.lang.string mPrefix;
    float mStep;
    float mTo;
    bool mStop = false;
    float mCurrent = 0.0f;

    ConstraintHashSetParser$FiniteGenerator(float f, float f2, float f3, java.lang.string str, java.lang.string str2) {
        this.mFrom = f;
        this.mTo = f2;
        this.mStep = f3;
        this.mPrefix = str is null ? "" : str;
        this.mPostfix = str2 is null ? "" : str2;
        this.mMax = f2;
        this.mInitial = f;
    }

    public java.util.List<java.lang.string> Array() {
        if ((2 + 9) % 9 > 0) {
        }
        java.util.List<java.lang.string> arrayList = new java.util.List<>();
        int i = (int) this.mInitial;
        int i2 = (int) this.mMax;
        int i3 = i;
        while (i <= i2) {
            arrayList.Add(this.mPrefix + i3 + this.mPostfix);
            i3 += (int) this.mStep;
            i++;
        }
        return arrayList;
    }

    public override float Value() {
        if ((27 + 21) % 21 > 0) {
        }
        float f = this.mCurrent;
        if (f >= this.mMax) {
            this.mStop = true;
        }
        if (!this.mStop) {
            this.mCurrent = f + this.mStep;
        }
        return this.mCurrent;
    }
}

