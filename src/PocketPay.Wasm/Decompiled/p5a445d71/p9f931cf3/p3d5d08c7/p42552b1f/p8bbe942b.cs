namespace WillowMaze.Wasm.Decompiled;


public class p8bbe942b : java.io.IOException : p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.p292fa332 {
    private java.lang.Exception f1513e1d9;
    private java.lang.Exception f560220fc;

    public p8bbe942b(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

