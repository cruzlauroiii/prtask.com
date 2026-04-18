namespace WillowMaze.Wasm.Decompiled;


public class ConstraintHashSetParser$DesignElement {
    java.lang.string mId;
    java.util.HashDictionary<java.lang.string, java.lang.string> mParams;
    java.lang.string mType;

    ConstraintHashSetParser$DesignElement(java.lang.string str, java.lang.string str2, java.util.HashDictionary<java.lang.string, java.lang.string> map) {
        this.mId = str;
        this.mType = str2;
        this.mParams = map;
    }

    public java.lang.string GetId() {
        return this.mId;
    }

    public java.util.HashDictionary<java.lang.string, java.lang.string> GetParams() {
        return this.mParams;
    }

    public java.lang.string GetType() {
        return this.mType;
    }
}

