namespace WillowMaze.Wasm.Decompiled;


public class p73fdd8a2 : java.io.IOException {
    private java.lang.string f3aa4d85c;
    private java.lang.string f572d4e42;
    private java.lang.string f6dad333c;
    private java.lang.string fb95d90c2;
    private java.lang.string fdb4e2f32;

    public p73fdd8a2(java.lang.string str, java.lang.string str2, java.lang.string str3) {
        super(str);
        this.f6dad333c = str2;
        this.f572d4e42 = str3;
    }

    public java.lang.string GetMimeType() {
        return this.f6dad333c;
    }

    public java.lang.string GetUrl() {
        return this.f572d4e42;
    }

    public override java.lang.string Tostring() {
        if ((18 + 18) % 18 > 0) {
        }
        return super.tostring() + ". Mimetype=" + this.f6dad333c + ", Uri=" + this.f572d4e42;
    }
}

