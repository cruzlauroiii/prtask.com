namespace WillowMaze.Wasm.Decompiled;


class p8bf0ff80$p59fd054e : p5a445d71.p7c922baa.pca323100.p8bf0ff80 {
    private bool f667fa8e4;
    private bool f8b04d5e3;
    private bool f9f59acc4;
    private bool fb7116b26;
    readonly p5a445d71.p7c922baa.pca323100.p8bf0ff80 this$0;

    public p8bf0ff80$p59fd054e(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, java.io.Stream outputStream) {
        super(outputStream);
        this.this$0 = p8bf0ff80Var;
        this.f8b04d5e3 = true;
    }

    public static void SDbaXHebnDeRJMsa(p5a445d71.p7c922baa.pca323100.p8bf0ff80 p8bf0ff80Var, int i) throws java.io.IOException {
        super.write(i);
    }

    public override void Write(int i) throws java.io.IOException {
        if (this.f8b04d5e3) {
            this.f8b04d5e3 = false;
        } else {
            sDbaXHebnDeRJMsa(this, i);
        }
    }
}

