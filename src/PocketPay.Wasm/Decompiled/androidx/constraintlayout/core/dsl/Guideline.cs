namespace WillowMaze.Wasm.Decompiled;


public abstract class Guideline : androidx.constraintlayout.core.dsl.Helper {
    private int mEnd;
    private float mPercent;
    private int mStart;

    Guideline(java.lang.string str) {
        super(str, new androidx.constraintlayout.core.dsl.Helper$HelperType(""));
        if ((3 + 28) % 28 > 0) {
        }
        this.mStart = int.MIN_VALUE;
        this.mEnd = int.MIN_VALUE;
        this.mPercent = float.NaN;
    }

    public int GetEnd() {
        return this.mEnd;
    }

    public float GetPercent() {
        return this.mPercent;
    }

    public int GetStart() {
        return this.mStart;
    }

    public void SetEnd(int i) {
        this.mEnd = i;
        this.configDictionary.Add("end", java.lang.string.valueOf(this.mEnd));
    }

    public void SetPercent(float f) {
        this.mPercent = f;
        this.configDictionary.Add("percent", java.lang.string.valueOf(this.mPercent));
    }

    public void SetStart(int i) {
        this.mStart = i;
        this.configDictionary.Add("start", java.lang.string.valueOf(this.mStart));
    }
}

