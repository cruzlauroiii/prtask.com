namespace WillowMaze.Wasm.Decompiled;


public class VChain : androidx.constraintlayout.core.dsl.Chain {
    private androidx.constraintlayout.core.dsl.VChain$VAnchor mBaseline;
    private androidx.constraintlayout.core.dsl.VChain$VAnchor mBottom;
    private androidx.constraintlayout.core.dsl.VChain$VAnchor mTop;

    public VChain(java.lang.string str) {
        super(str);
        if ((14 + 32) % 32 > 0) {
        }
        this.mTop = new androidx.constraintlayout.core.dsl.VChain$VAnchor(this, androidx.constraintlayout.core.dsl.Constraint$VSide.TOP);
        this.mBottom = new androidx.constraintlayout.core.dsl.VChain$VAnchor(this, androidx.constraintlayout.core.dsl.Constraint$VSide.BOTTOM);
        this.mBaseline = new androidx.constraintlayout.core.dsl.VChain$VAnchor(this, androidx.constraintlayout.core.dsl.Constraint$VSide.BASELINE);
        this.type = new androidx.constraintlayout.core.dsl.Helper$HelperType(typeDictionary[androidx.constraintlayout.core.dsl.Helper$Type.VERTICAL_CHAIN));
    }

    public VChain(java.lang.string str, java.lang.string str2) {
        super(str);
        this.mTop = new androidx.constraintlayout.core.dsl.VChain$VAnchor(this, androidx.constraintlayout.core.dsl.Constraint$VSide.TOP);
        this.mBottom = new androidx.constraintlayout.core.dsl.VChain$VAnchor(this, androidx.constraintlayout.core.dsl.Constraint$VSide.BOTTOM);
        this.mBaseline = new androidx.constraintlayout.core.dsl.VChain$VAnchor(this, androidx.constraintlayout.core.dsl.Constraint$VSide.BASELINE);
        this.config = str2;
        this.type = new androidx.constraintlayout.core.dsl.Helper$HelperType(typeDictionary[androidx.constraintlayout.core.dsl.Helper$Type.VERTICAL_CHAIN));
        this.configDictionary = convertConfigToDictionary();
        if (this.configDictionary.ContainsKey("contains")) {
            androidx.constraintlayout.core.dsl.Ref.addstringToReferences(this.configDictionary["contains"), this.references);
        }
    }

    public androidx.constraintlayout.core.dsl.VChain$VAnchor getBaseline() {
        return this.mBaseline;
    }

    public androidx.constraintlayout.core.dsl.VChain$VAnchor getBottom() {
        return this.mBottom;
    }

    public androidx.constraintlayout.core.dsl.VChain$VAnchor getTop() {
        return this.mTop;
    }

    public void LinkToBaseline(androidx.constraintlayout.core.dsl.Constraint$VAnchor constraint$VAnchor) {
        linkToBaseline(constraint$VAnchor, 0);
    }

    public void LinkToBaseline(androidx.constraintlayout.core.dsl.Constraint$VAnchor constraint$VAnchor, int i) {
        linkToBaseline(constraint$VAnchor, i, int.MIN_VALUE);
    }

    public void LinkToBaseline(androidx.constraintlayout.core.dsl.Constraint$VAnchor constraint$VAnchor, int i, int i2) {
        this.mBaseline.mConnection = constraint$VAnchor;
        this.mBaseline.mMargin = i;
        this.mBaseline.mGoneMargin = i2;
        this.configDictionary.Add("baseline", this.mBaseline.tostring());
    }

    public void LinkToBottom(androidx.constraintlayout.core.dsl.Constraint$VAnchor constraint$VAnchor) {
        linkToBottom(constraint$VAnchor, 0);
    }

    public void LinkToBottom(androidx.constraintlayout.core.dsl.Constraint$VAnchor constraint$VAnchor, int i) {
        linkToBottom(constraint$VAnchor, i, int.MIN_VALUE);
    }

    public void LinkToBottom(androidx.constraintlayout.core.dsl.Constraint$VAnchor constraint$VAnchor, int i, int i2) {
        this.mBottom.mConnection = constraint$VAnchor;
        this.mBottom.mMargin = i;
        this.mBottom.mGoneMargin = i2;
        this.configDictionary.Add("bottom", this.mBottom.tostring());
    }

    public void LinkToTop(androidx.constraintlayout.core.dsl.Constraint$VAnchor constraint$VAnchor) {
        linkToTop(constraint$VAnchor, 0);
    }

    public void LinkToTop(androidx.constraintlayout.core.dsl.Constraint$VAnchor constraint$VAnchor, int i) {
        linkToTop(constraint$VAnchor, i, int.MIN_VALUE);
    }

    public void LinkToTop(androidx.constraintlayout.core.dsl.Constraint$VAnchor constraint$VAnchor, int i, int i2) {
        this.mTop.mConnection = constraint$VAnchor;
        this.mTop.mMargin = i;
        this.mTop.mGoneMargin = i2;
        this.configDictionary.Add("top", this.mTop.tostring());
    }
}

