namespace WillowMaze.Wasm.Decompiled;


public class p977cf76a : java.lang.Exception {
    private java.lang.Exception f26791271;
    private java.lang.Exception f560220fc;
    private java.lang.Exception f8aa94e69;

    public p977cf76a(java.lang.string str) {
        super(str);
    }

    public p977cf76a(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

