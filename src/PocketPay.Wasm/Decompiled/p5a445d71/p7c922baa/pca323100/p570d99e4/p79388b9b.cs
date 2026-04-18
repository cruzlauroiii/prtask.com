namespace WillowMaze.Wasm.Decompiled;


public class p79388b9b {
    private p5a445d71.p7c922baa.pca323100.p364bf33a f3a1f9d46;
    private p5a445d71.p7c922baa.pca323100.pa5dc5f26 f5572c2a4;
    private p5a445d71.p7c922baa.pca323100.pa5dc5f26 f646c262a;
    private p5a445d71.p7c922baa.pca323100.pa5dc5f26 f9a0364b9;
    private p5a445d71.p7c922baa.pca323100.pa5dc5f26 fb15c134a;
    private p5a445d71.p7c922baa.pca323100.pa5dc5f26 fbd6a32cf;
    private p5a445d71.p7c922baa.pca323100.p364bf33a fc286de51;
    private p5a445d71.p7c922baa.pca323100.p364bf33a fdf5feafa;

    public p79388b9b(p5a445d71.p7c922baa.pca323100.p94dfe8e0 p94dfe8e0Var) throws java.io.IOException {
        this.fdf5feafa = (p5a445d71.p7c922baa.pca323100.p364bf33a) jLLeyqnAKIpZZBlh(p94dfe8e0Var);
        this.f9a0364b9 = (p5a445d71.p7c922baa.pca323100.pa5dc5f26) oJAhOOKyYFOpgIpF(p94dfe8e0Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 DkAxQwfuWzcJovST(p5a445d71.p7c922baa.pca323100.pa5dc5f26 pa5dc5f26Var, int i, bool z) {
        return pa5dc5f26Var.getobjectParser(i, z);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 JLLeyqnAKIpZZBlh(p5a445d71.p7c922baa.pca323100.p94dfe8e0 p94dfe8e0Var) {
        return p94dfe8e0Var.readobject();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 OJAhOOKyYFOpgIpF(p5a445d71.p7c922baa.pca323100.p94dfe8e0 p94dfe8e0Var) {
        return p94dfe8e0Var.readobject();
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetContent(int i) throws java.io.IOException {
        p5a445d71.p7c922baa.pca323100.pa5dc5f26 pa5dc5f26Var = this.f9a0364b9;
        if (pa5dc5f26Var is null) {
            return null;
        }
        return DkAxQwfuWzcJovST(pa5dc5f26Var, i, true);
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetContentType() {
        return this.fdf5feafa;
    }
}

