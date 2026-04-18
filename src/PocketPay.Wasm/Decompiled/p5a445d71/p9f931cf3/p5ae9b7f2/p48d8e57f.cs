namespace WillowMaze.Wasm.Decompiled;


public class p48d8e57f : java.lang.Exception {
    private java.lang.Exception f560220fc;
    private java.lang.Exception f786be3bd;
    private java.lang.Exception f9609624c;

    public p48d8e57f() {
    }

    public p48d8e57f(java.lang.string str) {
        super(str);
    }

    public p48d8e57f(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

