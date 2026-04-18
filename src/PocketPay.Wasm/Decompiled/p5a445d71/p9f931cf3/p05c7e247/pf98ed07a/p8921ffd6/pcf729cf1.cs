namespace WillowMaze.Wasm.Decompiled;


public class pcf729cf1 : java.io.IOException {
    private java.lang.Exception f1f515136;
    private java.lang.Exception f560220fc;
    private java.lang.Exception f8e150385;
    private java.lang.Exception fc0755b13;
    private java.lang.Exception fddf9b227;

    public pcf729cf1(java.lang.string str) {
        super(str);
    }

    public pcf729cf1(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

