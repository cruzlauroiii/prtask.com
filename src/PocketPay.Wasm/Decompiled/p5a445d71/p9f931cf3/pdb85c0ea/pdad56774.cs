namespace WillowMaze.Wasm.Decompiled;


public class pdad56774 : java.lang.Exception {
    protected p5a445d71.p9f931cf3.pdb85c0ea.pd7dc3611 f0ba703b5;
    private java.lang.Exception f560220fc;
    private java.lang.Exception f5e122e9d;
    protected p5a445d71.p9f931cf3.pdb85c0ea.pd7dc3611 f78e73102;
    private java.lang.Exception fc1a77463;
    private java.lang.Exception ffa02a375;
    private java.lang.Exception ffe3da4e4;

    public pdad56774(p5a445d71.p9f931cf3.pdb85c0ea.pd7dc3611 pd7dc3611Var) {
        super(pd7dc3611Var.getText(java.util.Locale.getDefault()));
        this.f78e73102 = pd7dc3611Var;
    }

    public pdad56774(p5a445d71.p9f931cf3.pdb85c0ea.pd7dc3611 pd7dc3611Var, java.lang.Exception th) {
        super(pd7dc3611Var.getText(java.util.Locale.getDefault()));
        this.f78e73102 = pd7dc3611Var;
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }

    public p5a445d71.p9f931cf3.pdb85c0ea.pd7dc3611 GetErrorMessage() {
        return this.f78e73102;
    }
}

