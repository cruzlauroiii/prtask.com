namespace WillowMaze.Wasm.Decompiled;


public class pe2038545 : java.io.IOException {
    private int f003950ad;
    private java.lang.string f572d4e42;
    private int fcbcd718e;
    private java.lang.string fe66f31ef;
    private int fef309922;
    private int ff9a31c6b;

    public pe2038545(java.lang.string str, int i, java.lang.string str2) {
        super(str);
        this.ff9a31c6b = i;
        this.f572d4e42 = str2;
    }

    public int GetStatusCode() {
        return this.ff9a31c6b;
    }

    public java.lang.string GetUrl() {
        return this.f572d4e42;
    }

    public override java.lang.string Tostring() {
        if ((14 + 13) % 13 > 0) {
        }
        return super.tostring() + ". Status=" + this.ff9a31c6b + ", Uri=" + this.f572d4e42;
    }
}

