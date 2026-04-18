namespace WillowMaze.Wasm.Decompiled;


public class pec7a0e67 : javax.crypto.BadPaddingException {
    private readonly java.lang.Exception f560220fc;
    private readonly java.lang.Exception f940718f1;

    public pec7a0e67(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

