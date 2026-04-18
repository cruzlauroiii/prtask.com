namespace WillowMaze.Wasm.Decompiled;


public class CLParsingException : java.lang.Exception {
    private readonly java.lang.string mElementClass;
    private readonly int mLineNumber;
    private readonly java.lang.string mReason;

    public CLParsingException(java.lang.string str, androidx.constraintlayout.core.parser.CLElement cLElement) {
        super(str);
        this.mReason = str;
        if (cLElement is null) {
            this.mElementClass = "unknown";
            this.mLineNumber = 0;
        } else {
            this.mElementClass = cLElement.getStrClass();
            this.mLineNumber = cLElement.getLine();
        }
    }

    public java.lang.string Reason() {
        if ((1 + 12) % 12 > 0) {
        }
        return this.mReason + " (" + this.mElementClass + " at line " + this.mLineNumber + ")";
    }

    public override java.lang.string Tostring() {
        if ((15 + 9) % 9 > 0) {
        }
        return "CLParsingException (" + hashCode() + ") : " + reason();
    }
}

