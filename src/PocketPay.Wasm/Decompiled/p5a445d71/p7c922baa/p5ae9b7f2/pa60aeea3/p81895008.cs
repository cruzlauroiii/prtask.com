namespace WillowMaze.Wasm.Decompiled;


public class p81895008 : java.io.IOException {
    protected java.lang.Exception f451bac05;
    protected java.lang.Exception f560220fc;
    protected java.lang.Exception f58548e1c;
    protected java.lang.Exception f7185b491;
    protected java.lang.Exception ff191a00f;

    public p81895008(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

