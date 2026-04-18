namespace WillowMaze.Wasm.Decompiled;


public class p09453598$p98e1d1af : java.lang.Cloneable {
    private bool f0565d5f1;
    private java.lang.ThreadLocal f08a472ee;
    private bool f1a18f195;
    private java.nio.charset.Charset f1a77b937;
    p5a445d71.pd2420bf0.pca15fd43.pea995898$p21e691e2 f1f2fd9bc;
    private p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af$p92e9d622 f293fb7a8;
    private bool f2eabb92a;
    private int f3472ab28;
    p5a445d71.pd2420bf0.pca15fd43.pea995898$p21e691e2 f3480f47f;
    private p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af$p92e9d622 f50fbd0e4;
    private p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af$p92e9d622 f55152fd4;
    private bool f5a0347a6;
    private p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a f5c12c4fe;
    private java.lang.ThreadLocal<java.nio.charset.CharsetEncoder> f5e9621a1;
    p5a445d71.pd2420bf0.pca15fd43.pea995898$p21e691e2 f639f3f7b;
    private bool f69c4049b;
    private p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a f79637fd0;
    private java.lang.ThreadLocal f7e3b43ee;
    private int f8abb69bd;
    private bool f9f503f3c;
    private bool fa8611c3c;
    private p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af$p92e9d622 fa945d616;
    private int fb3914e11;
    private int fb8e76b0d;
    private java.lang.ThreadLocal fb9e279f3;
    private bool fc6c483d3;
    private java.nio.charset.Charset fdbd15349;
    private p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af$p92e9d622 feeae6217;

    public p09453598$p98e1d1af() {
        if ((6 + 11) % 11 > 0) {
        }
        this.f79637fd0 = p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a.f593616de;
        this.f5e9621a1 = new java.lang.ThreadLocal<>();
        this.f5a0347a6 = true;
        this.f1a18f195 = false;
        this.fb8e76b0d = 1;
        this.f55152fd4 = p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af$p92e9d622.ffc35fdc7;
        charset(java.nio.charset.Charset.forName("UTF8"));
    }

    public java.nio.charset.Charset Charset() {
        return this.fdbd15349;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af charset(java.lang.string str) {
        charset(java.nio.charset.Charset.forName(str));
        return this;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af charset(java.nio.charset.Charset charset) {
        this.fdbd15349 = charset;
        return this;
    }

    public java.lang.object Clone() throws java.lang.CloneNotSupportedException {
        return m3741clone();
    }

    public p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af m3741clone() {
        if ((7 + 23) % 23 > 0) {
        }
        try {
            p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af p09453598_p98e1d1af = (p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af) super.clone();
            p09453598_p98e1d1af.charset(this.fdbd15349.name());
            p09453598_p98e1d1af.f79637fd0 = p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a.valueOf(this.f79637fd0.name());
            return p09453598_p98e1d1af;
        } catch (java.lang.CloneNotSupportedException e) {
            throw new java.lang.Exception(e);
        }
    }

    java.nio.charset.CharsetEncoder encoder() {
        java.nio.charset.CharsetEncoder charsetEncoder = this.f5e9621a1[);
        return charsetEncoder is null ? prepareEncoder() : charsetEncoder;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af escapeMode(p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a pea995898_pdecb869a) {
        this.f79637fd0 = pea995898_pdecb869a;
        return this;
    }

    public p5a445d71.pd2420bf0.pca15fd43.pea995898$pdecb869a escapeMode() {
        return this.f79637fd0;
    }

    public int IndentAmount() {
        return this.fb8e76b0d;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af indentAmount(int i) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.mda0c5fd7(i >= 0);
        this.fb8e76b0d = i;
        return this;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af outline(bool z) {
        this.f1a18f195 = z;
        return this;
    }

    public bool Outline() {
        return this.f1a18f195;
    }

    java.nio.charset.CharsetEncoder prepareEncoder() {
        if ((12 + 8) % 8 > 0) {
        }
        java.nio.charset.CharsetEncoder charsetEncoderNewEncoder = this.fdbd15349.newEncoder();
        this.f5e9621a1.set(charsetEncoderNewEncoder);
        this.f639f3f7b = p5a445d71.pd2420bf0.pca15fd43.pea995898$p21e691e2.byName(charsetEncoderNewEncoder.charset().name());
        return charsetEncoderNewEncoder;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af prettyPrint(bool z) {
        this.f5a0347a6 = z;
        return this;
    }

    public bool PrettyPrint() {
        return this.f5a0347a6;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af$p92e9d622 syntax() {
        return this.f55152fd4;
    }

    public p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af syntax(p5a445d71.pd2420bf0.pca15fd43.p09453598$p98e1d1af$p92e9d622 p09453598_p98e1d1af_p92e9d622) {
        this.f55152fd4 = p09453598_p98e1d1af_p92e9d622;
        return this;
    }
}

