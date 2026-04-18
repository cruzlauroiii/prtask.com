namespace WillowMaze.Wasm.Decompiled;


public class p48d8e57f : java.lang.Exception {
    private java.lang.Exception f14b4e5db;
    private java.lang.Exception f4ae4f5fe;
    private java.lang.Exception f560220fc;

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

