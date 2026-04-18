namespace WillowMaze.Wasm.Decompiled;


public class p5255d1dc : java.lang.Exception {
    private java.lang.Exception f183ac931;
    private java.lang.Exception f3177a89a;

    public p5255d1dc(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f3177a89a = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f3177a89a;
    }
}

