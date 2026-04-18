namespace WillowMaze.Wasm.Decompiled;


public class pf8b259b6 : java.lang.Exception {
    java.lang.Exception f3177a89a;
    java.lang.Exception fcaca4e19;

    public pf8b259b6(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f3177a89a = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f3177a89a;
    }
}

