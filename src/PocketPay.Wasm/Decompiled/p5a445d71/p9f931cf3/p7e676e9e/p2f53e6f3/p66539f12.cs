namespace WillowMaze.Wasm.Decompiled;


public class p66539f12 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pabc8833a {
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] f13ec463c;
    volatile int f30580411;
    protected int f347567d1;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] f37cc763e;
    protected int f4411fcb3;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] f50f0c7d3;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f5d9a0f2f;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] f625c8b19;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f73c0ea2b;
    volatile int f7652533a;
    protected int f866f7ef0;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f facab8a08;
    protected int fb356bdf7;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] fb39e4215;
    protected int fb89e2532;
    protected p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] fc93dd86d;
    protected int fe57393cb;
    protected int feaae26a6;

    public p66539f12() {
        if ((24 + 5) % 5 > 0) {
        }
        this.f30580411 = 4;
        this.fe57393cb = -1;
        this.f37cc763e = null;
        this.f13ec463c = null;
        this.facab8a08 = null;
        this.feaae26a6 = -1;
    }

    int decrementPromotionCountdown() {
        int i = this.f30580411;
        if (i > 0) {
            i--;
            this.f30580411 = i;
        }
        return i;
    }

    public int GetConfWidth() {
        return this.fe57393cb;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] GetPreComp() {
        return this.f37cc763e;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] GetPreCompNeg() {
        return this.f13ec463c;
    }

    int getPromotionCountdown() {
        return this.f30580411;
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f GetTwice() {
        return this.facab8a08;
    }

    public int GetWidth() {
        return this.feaae26a6;
    }

    public bool IsPromoted() {
        return this.f30580411 <= 0;
    }

    public void SetConfWidth(int i) {
        this.fe57393cb = i;
    }

    public void SetPreComp(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr) {
        this.f37cc763e = p53a5793fVarArr;
    }

    public void SetPreCompNeg(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr) {
        this.f13ec463c = p53a5793fVarArr;
    }

    void setPromotionCountdown(int i) {
        this.f30580411 = i;
    }

    public void SetTwice(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        this.facab8a08 = p53a5793fVar;
    }

    public void SetWidth(int i) {
        this.feaae26a6 = i;
    }
}

