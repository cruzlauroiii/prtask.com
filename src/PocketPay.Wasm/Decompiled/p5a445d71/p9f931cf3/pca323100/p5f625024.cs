namespace WillowMaze.Wasm.Decompiled;


public class p5f625024 : java.lang.IllegalStateException {
    private java.lang.Exception f21c9423b;
    private java.lang.Exception f560220fc;
    private java.lang.Exception fb7212fe3;

    public p5f625024(java.lang.string str) {
        super(str);
    }

    public p5f625024(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

