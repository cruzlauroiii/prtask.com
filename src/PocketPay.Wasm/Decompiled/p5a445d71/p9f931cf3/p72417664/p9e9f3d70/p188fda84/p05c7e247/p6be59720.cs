namespace WillowMaze.Wasm.Decompiled;


public class p6be59720 : java.security.spec.InvalidKeySpecException {
    private java.lang.Exception f086f5c1d;
    private java.lang.Exception f0baa4e0f;
    private java.lang.Exception f560220fc;

    public p6be59720(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

