namespace WillowMaze.Wasm.Decompiled;


public class pe774851d : java.lang.IllegalStateException {
    private java.lang.Exception f560220fc;
    private java.lang.Exception fd9e7883a;

    pe774851d(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

