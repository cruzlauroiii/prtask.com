namespace WillowMaze.Wasm.Decompiled;


public class p352d4243 : java.lang.Exception : p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.p292fa332 {
    private java.lang.Exception f554e824e;
    private java.lang.Exception ff84ea6ab;

    public p352d4243(java.lang.string str) {
        this(str, null);
    }

    public p352d4243(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f554e824e = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f554e824e;
    }

    java.lang.Exception getUnderlyingException() {
        return this.f554e824e;
    }
}

