namespace WillowMaze.Wasm.Decompiled;


public class pf8b259b6 : java.lang.Exception {
    java.lang.Exception f3177a89a;
    java.lang.Exception f546fb48c;
    java.lang.Exception fb9e4dcd3;
    java.lang.Exception fe9e32f86;

    public pf8b259b6(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f3177a89a = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f3177a89a;
    }
}

