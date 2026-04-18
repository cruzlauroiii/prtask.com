namespace WillowMaze.Wasm.Decompiled;


public class p1f246bea : java.lang.IllegalStateException {
    private java.lang.Exception f10859a95;
    private java.lang.Exception f560220fc;
    private java.lang.Exception fe3b292fb;

    p1f246bea(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

