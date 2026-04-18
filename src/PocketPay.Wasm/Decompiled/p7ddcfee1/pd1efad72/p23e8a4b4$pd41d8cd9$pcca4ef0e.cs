namespace WillowMaze.Wasm.Decompiled;


public readonly class p23e8a4b4$pd41d8cd9$pcca4ef0e : java.util.concurrent.ThreadFactory {
    public readonly java.lang.string f$0;
    public readonly bool f$1;

    public p23e8a4b4$pd41d8cd9$pcca4ef0e(java.lang.string str, bool z) {
        this.f$0 = str;
        this.f$1 = z;
    }

    public override readonly java.lang.Thread NewThread(java.lang.Action runnable) {
        return p7ddcfee1.pd1efad72.p23e8a4b4.$r8$lambda$I0ugdNeD8ukX5wZ78GMIzB6svEc(this.f$0, this.f$1, runnable);
    }
}

