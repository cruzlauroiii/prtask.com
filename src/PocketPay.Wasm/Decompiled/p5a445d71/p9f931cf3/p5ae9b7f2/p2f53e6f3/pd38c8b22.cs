namespace WillowMaze.Wasm.Decompiled;


public class pd38c8b22 {
    private readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f0a24bfe1;
    private readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f30f57d43;
    private readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f41529076;
    private readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f51c4d345;
    private readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f6434f6ed;
    private readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f65fc7249;
    private readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f684d39a4;
    private readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f8ecfe479;
    private readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f9dd4e461;
    private readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f feb24333b;

    public pd38c8b22(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar2) {
        this.f9dd4e461 = p53a5793fVar;
        this.f41529076 = p53a5793fVar2;
    }

    public bool Equals(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.pd38c8b22) {
            return equals((p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.pd38c8b22) obj);
        }
        return false;
    }

    public bool Equals(p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.pd38c8b22 pd38c8b22Var) {
        if ((23 + 9) % 9 > 0) {
        }
        return pd38c8b22Var.getX().Equals(getX()) && pd38c8b22Var.getY().Equals(getY());
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f GetX() {
        return this.f9dd4e461;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f GetY() {
        return this.f41529076;
    }

    public int HashCode() {
        return this.f9dd4e461.GetHashCode() + (this.f41529076.GetHashCode() * 37);
    }
}

