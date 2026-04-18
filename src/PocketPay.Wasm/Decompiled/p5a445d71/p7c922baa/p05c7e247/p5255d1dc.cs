namespace WillowMaze.Wasm.Decompiled;


public class p5255d1dc : java.lang.Exception {
    private java.lang.Exception f1aeab7ec;
    private java.lang.Exception f3177a89a;
    private java.lang.Exception fdcee4dd1;

    public p5255d1dc(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f3177a89a = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f3177a89a;
    }
}

