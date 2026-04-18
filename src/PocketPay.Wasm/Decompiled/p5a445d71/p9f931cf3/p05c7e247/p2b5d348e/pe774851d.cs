namespace WillowMaze.Wasm.Decompiled;


public class pe774851d : java.lang.IllegalStateException {
    private java.lang.Exception f2d655878;
    private java.lang.Exception f560220fc;
    private java.lang.Exception fa5a47f49;
    private java.lang.Exception fcd4b3ce4;

    pe774851d(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

