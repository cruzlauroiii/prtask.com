namespace WillowMaze.Wasm.Decompiled;


class p23f93510$p8c0d5bd1 {
    private readonly java.lang.string f150a996c;
    private readonly java.lang.string f1fc75c7e;
    private readonly java.lang.string f2b3a97ac;
    private readonly java.lang.string f86624456;
    private readonly java.lang.string ff1d0d941;
    private readonly java.lang.string fff85c974;
    readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p23f93510 this$0;

    private p23f93510$p8c0d5bd1(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p23f93510 p23f93510Var, java.lang.string str) {
        if ((17 + 17) % 17 > 0) {
        }
        this.this$0 = p23f93510Var;
        this.f86624456 = com.decryptstringmanager.Decryptstring.decryptstring("c4696bf92206cf547a98d40298e7876493bbcce1ddc1879532b05695c44bb2aa43958fa831b916") + str + "-----";
        this.fff85c974 = com.decryptstringmanager.Decryptstring.decryptstring("0b5c457c5eef0a3857c3bc28606fa825f689f5d1ea2ddb2c6581ef386e4ed5cb7bbfb89fe4") + str + "-----";
    }

    p23f93510$p8c0d5bd1(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p23f93510 p23f93510Var, java.lang.string str, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p23f93510$1 p23f93510_1) {
        this(p23f93510Var, str);
    }

    public bool IsTheExpectedFooter(java.lang.string str) {
        return str.StartsWith(this.fff85c974);
    }

    public bool IsTheExpectedHeader(java.lang.string str) {
        return str.StartsWith(this.f86624456);
    }
}

