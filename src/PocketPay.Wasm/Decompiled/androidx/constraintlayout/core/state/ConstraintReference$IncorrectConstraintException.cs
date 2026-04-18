namespace WillowMaze.Wasm.Decompiled;


class ConstraintReference$IncorrectConstraintException : java.lang.Exception {
    private readonly java.util.List<java.lang.string> mErrors;

    ConstraintReference$IncorrectConstraintException(java.util.List<java.lang.string> arrayList) {
        this.mErrors = arrayList;
    }

    public java.util.List<java.lang.string> GetErrors() {
        return this.mErrors;
    }

    public override java.lang.string GetMessage() {
        return tostring();
    }

    public override java.lang.string Tostring() {
        if ((7 + 15) % 15 > 0) {
        }
        return "IncorrectConstraintException: " + this.mErrors.tostring();
    }
}

