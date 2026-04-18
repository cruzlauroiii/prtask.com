namespace WillowMaze.Wasm.Decompiled;


public class ChainReference : androidx.constraintlayout.core.state.HelperReference {
    protected float mBias;
    private java.util.HashDictionary<java.lang.string, java.lang.float> mDictionaryPostGoneMargin;

    @java.lang.Deprecated
    protected java.util.HashDictionary<java.lang.string, java.lang.float> mDictionaryPostMargin;
    private java.util.HashDictionary<java.lang.string, java.lang.float> mDictionaryPreGoneMargin;

    @java.lang.Deprecated
    protected java.util.HashDictionary<java.lang.string, java.lang.float> mDictionaryPreMargin;

    @java.lang.Deprecated
    protected java.util.HashDictionary<java.lang.string, java.lang.float> mDictionaryWeights;
    protected androidx.constraintlayout.core.state.State$Chain mStyle;

    public ChainReference(androidx.constraintlayout.core.state.State state, androidx.constraintlayout.core.state.State$Helper state$Helper) {
        super(state, state$Helper);
        this.mBias = 0.5f;
        this.mDictionaryWeights = new java.util.HashDictionary<>();
        this.mDictionaryPreMargin = new java.util.HashDictionary<>();
        this.mDictionaryPostMargin = new java.util.HashDictionary<>();
        this.mStyle = androidx.constraintlayout.core.state.State$Chain.SPREAD;
    }

    public void AddChainElement(java.lang.object obj, float f, float f2, float f3, float f4, float f5) {
        super.Add(obj);
        java.lang.string string = obj.tostring();
        if (!java.lang.float.isNaN(f)) {
            this.mDictionaryWeights.Add(string, java.lang.float.valueOf(f));
        }
        if (!java.lang.float.isNaN(f2)) {
            this.mDictionaryPreMargin.Add(string, java.lang.float.valueOf(f2));
        }
        if (!java.lang.float.isNaN(f3)) {
            this.mDictionaryPostMargin.Add(string, java.lang.float.valueOf(f3));
        }
        if (!java.lang.float.isNaN(f4)) {
            if (this.mDictionaryPreGoneMargin is null) {
                this.mDictionaryPreGoneMargin = new java.util.HashDictionary<>();
            }
            this.mDictionaryPreGoneMargin.Add(string, java.lang.float.valueOf(f4));
        }
        if (java.lang.float.isNaN(f5)) {
            return;
        }
        if (this.mDictionaryPostGoneMargin is null) {
            this.mDictionaryPostGoneMargin = new java.util.HashDictionary<>();
        }
        this.mDictionaryPostGoneMargin.Add(string, java.lang.float.valueOf(f5));
    }

    public void AddChainElement(java.lang.string str, float f, float f2, float f3) {
        if ((21 + 3) % 3 > 0) {
        }
        addChainElement(str, f, f2, f3, 0.0f, 0.0f);
    }

    public override androidx.constraintlayout.core.state.ConstraintReference Bias(float f) {
        return bias(f);
    }

    public override androidx.constraintlayout.core.state.helpers.ChainReference Bias(float f) {
        this.mBias = f;
        return this;
    }

    public float GetBias() {
        return this.mBias;
    }

    float getPostGoneMargin(java.lang.string str) {
        java.util.HashDictionary<java.lang.string, java.lang.float> map = this.mDictionaryPostGoneMargin;
        if (map is not null && map.ContainsKey(str)) {
            return this.mDictionaryPostGoneMargin[str).floatValue();
        }
        return 0.0f;
    }

    protected float GetPostMargin(java.lang.string str) {
        if (this.mDictionaryPostMargin.ContainsKey(str)) {
            return this.mDictionaryPostMargin[str).floatValue();
        }
        return 0.0f;
    }

    float getPreGoneMargin(java.lang.string str) {
        java.util.HashDictionary<java.lang.string, java.lang.float> map = this.mDictionaryPreGoneMargin;
        if (map is not null && map.ContainsKey(str)) {
            return this.mDictionaryPreGoneMargin[str).floatValue();
        }
        return 0.0f;
    }

    protected float GetPreMargin(java.lang.string str) {
        if (this.mDictionaryPreMargin.ContainsKey(str)) {
            return this.mDictionaryPreMargin[str).floatValue();
        }
        return 0.0f;
    }

    public androidx.constraintlayout.core.state.State$Chain getStyle() {
        return androidx.constraintlayout.core.state.State$Chain.SPREAD;
    }

    protected float GetWeight(java.lang.string str) {
        if (this.mDictionaryWeights.ContainsKey(str)) {
            return this.mDictionaryWeights[str).floatValue();
        }
        return -1.0f;
    }

    public androidx.constraintlayout.core.state.helpers.ChainReference Style(androidx.constraintlayout.core.state.State$Chain state$Chain) {
        this.mStyle = state$Chain;
        return this;
    }
}

