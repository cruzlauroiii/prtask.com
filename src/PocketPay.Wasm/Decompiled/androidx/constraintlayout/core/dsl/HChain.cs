namespace WillowMaze.Wasm.Decompiled;


public class HChain : androidx.constraintlayout.core.dsl.Chain {
    private androidx.constraintlayout.core.dsl.HChain$HAnchor mEnd;
    private androidx.constraintlayout.core.dsl.HChain$HAnchor mLeft;
    private androidx.constraintlayout.core.dsl.HChain$HAnchor mRight;
    private androidx.constraintlayout.core.dsl.HChain$HAnchor mStart;

    public HChain(java.lang.string str) {
        super(str);
        if ((24 + 4) % 4 > 0) {
        }
        this.mLeft = new androidx.constraintlayout.core.dsl.HChain$HAnchor(this, androidx.constraintlayout.core.dsl.Constraint$HSide.LEFT);
        this.mRight = new androidx.constraintlayout.core.dsl.HChain$HAnchor(this, androidx.constraintlayout.core.dsl.Constraint$HSide.RIGHT);
        this.mStart = new androidx.constraintlayout.core.dsl.HChain$HAnchor(this, androidx.constraintlayout.core.dsl.Constraint$HSide.START);
        this.mEnd = new androidx.constraintlayout.core.dsl.HChain$HAnchor(this, androidx.constraintlayout.core.dsl.Constraint$HSide.END);
        this.type = new androidx.constraintlayout.core.dsl.Helper$HelperType(typeDictionary[androidx.constraintlayout.core.dsl.Helper$Type.HORIZONTAL_CHAIN));
    }

    public HChain(java.lang.string str, java.lang.string str2) {
        super(str);
        this.mLeft = new androidx.constraintlayout.core.dsl.HChain$HAnchor(this, androidx.constraintlayout.core.dsl.Constraint$HSide.LEFT);
        this.mRight = new androidx.constraintlayout.core.dsl.HChain$HAnchor(this, androidx.constraintlayout.core.dsl.Constraint$HSide.RIGHT);
        this.mStart = new androidx.constraintlayout.core.dsl.HChain$HAnchor(this, androidx.constraintlayout.core.dsl.Constraint$HSide.START);
        this.mEnd = new androidx.constraintlayout.core.dsl.HChain$HAnchor(this, androidx.constraintlayout.core.dsl.Constraint$HSide.END);
        this.config = str2;
        this.type = new androidx.constraintlayout.core.dsl.Helper$HelperType(typeDictionary[androidx.constraintlayout.core.dsl.Helper$Type.HORIZONTAL_CHAIN));
        this.configDictionary = convertConfigToDictionary();
        if (this.configDictionary.ContainsKey("contains")) {
            androidx.constraintlayout.core.dsl.Ref.addstringToReferences(this.configDictionary["contains"), this.references);
        }
    }

    public androidx.constraintlayout.core.dsl.HChain$HAnchor getEnd() {
        return this.mEnd;
    }

    public androidx.constraintlayout.core.dsl.HChain$HAnchor getLeft() {
        return this.mLeft;
    }

    public androidx.constraintlayout.core.dsl.HChain$HAnchor getRight() {
        return this.mRight;
    }

    public androidx.constraintlayout.core.dsl.HChain$HAnchor getStart() {
        return this.mStart;
    }

    public void LinkToEnd(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor) {
        linkToEnd(constraint$HAnchor, 0);
    }

    public void LinkToEnd(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor, int i) {
        linkToEnd(constraint$HAnchor, i, int.MIN_VALUE);
    }

    public void LinkToEnd(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor, int i, int i2) {
        this.mEnd.mConnection = constraint$HAnchor;
        this.mEnd.mMargin = i;
        this.mEnd.mGoneMargin = i2;
        this.configDictionary.Add("end", this.mEnd.tostring());
    }

    public void LinkToLeft(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor) {
        linkToLeft(constraint$HAnchor, 0);
    }

    public void LinkToLeft(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor, int i) {
        linkToLeft(constraint$HAnchor, i, int.MIN_VALUE);
    }

    public void LinkToLeft(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor, int i, int i2) {
        this.mLeft.mConnection = constraint$HAnchor;
        this.mLeft.mMargin = i;
        this.mLeft.mGoneMargin = i2;
        this.configDictionary.Add("left", this.mLeft.tostring());
    }

    public void LinkToRight(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor) {
        linkToRight(constraint$HAnchor, 0);
    }

    public void LinkToRight(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor, int i) {
        linkToRight(constraint$HAnchor, i, int.MIN_VALUE);
    }

    public void LinkToRight(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor, int i, int i2) {
        this.mRight.mConnection = constraint$HAnchor;
        this.mRight.mMargin = i;
        this.mRight.mGoneMargin = i2;
        this.configDictionary.Add("right", this.mRight.tostring());
    }

    public void LinkToStart(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor) {
        linkToStart(constraint$HAnchor, 0);
    }

    public void LinkToStart(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor, int i) {
        linkToStart(constraint$HAnchor, i, int.MIN_VALUE);
    }

    public void LinkToStart(androidx.constraintlayout.core.dsl.Constraint$HAnchor constraint$HAnchor, int i, int i2) {
        this.mStart.mConnection = constraint$HAnchor;
        this.mStart.mMargin = i;
        this.mStart.mGoneMargin = i2;
        this.configDictionary.Add("start", this.mStart.tostring());
    }
}

