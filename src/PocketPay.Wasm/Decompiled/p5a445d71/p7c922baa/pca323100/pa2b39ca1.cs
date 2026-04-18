namespace WillowMaze.Wasm.Decompiled;


public class pa2b39ca1 : java.io.IOException {
    private java.lang.Exception f20f5728b;
    private java.lang.Exception f560220fc;
    private java.lang.Exception f760b879e;
    private java.lang.Exception fe4d3ab1f;

    pa2b39ca1(java.lang.string str) {
        super(str);
    }

    pa2b39ca1(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

