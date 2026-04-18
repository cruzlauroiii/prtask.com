namespace WillowMaze.Wasm.Decompiled;


class p7cf40e66 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pabc8833a {
    static readonly java.lang.string f360b70c5 = com.decryptstringmanager.Decryptstring.decryptstring("9600079e58f97b9117fcb2856851011859b8c239cc582fbf5f1dfe84f5692c4bc6bad7417267e8");
    static readonly java.lang.string f8f3c5a8f = null;
    static readonly java.lang.string fcdc3af12 = null;
    static readonly java.lang.string fe9c56bc7 = null;
    static readonly java.lang.string ffcdd9ba1 = null;
    private bool f0e2cdc24;
    private bool f2d5effd6;
    private bool f2f3f4a1b;
    private bool f6d9114ff;
    private bool f7b5e47ba;
    private bool f9105e716;
    private bool f99617404;
    private bool f9a877be8;
    private bool fbac2527f;
    private bool f26934eb3 = false;
    private bool f9ef8b933 = false;
    private bool fe086dfb7 = false;

    p7cf40e66() {
    }

    bool hasCurveEquationPassed() {
        return this.f9ef8b933;
    }

    bool hasFailed() {
        return this.f26934eb3;
    }

    bool hasOrderPassed() {
        return this.fe086dfb7;
    }

    void reportCurveEquationPassed() {
        this.f9ef8b933 = true;
    }

    void reportFailed() {
        this.f26934eb3 = true;
    }

    void reportOrderPassed() {
        this.fe086dfb7 = true;
    }
}

