namespace WillowMaze.Wasm.Decompiled;


public class p34e82524$pe1110b8b : p5a445d71.pd2420bf0.pc2cc7082$pe1110b8b {
    private java.lang.string f2063c160;
    private java.lang.string f3c6e0b8a;
    private java.io.Stream f46d9c3ea;
    private java.lang.string f5471466d;
    private java.lang.string f5b7f1f85;
    private java.lang.string f5babd3f7;
    private java.lang.string fb9a403a6;
    private java.lang.string fc795a20c;
    private java.lang.string fcb6b7a34;
    private java.lang.string fdf5feafa;
    private java.lang.string fe2c646ef;
    private java.io.Stream ff7b44cfa;
    private java.io.Stream ffa31a9d0;
    private java.lang.string ffd6a4c0e;

    private p34e82524$pe1110b8b() {
    }

    public static p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pe1110b8b m76ea0beb(java.lang.string str, java.lang.string str2) {
        return new p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pe1110b8b().key(str).value(str2);
    }

    public static p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pe1110b8b m76ea0beb(java.lang.string str, java.lang.string str2, java.io.Stream inputStream) {
        return new p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pe1110b8b().key(str).value(str2).inputStream(inputStream);
    }

    public override java.lang.string ContentType() {
        return this.fdf5feafa;
    }

    public p5a445d71.pd2420bf0.pc2cc7082$pe1110b8b contentType(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str);
        this.fdf5feafa = str;
        return this;
    }

    public override bool HasStream() {
        return this.ff7b44cfa is not null;
    }

    public override java.io.Stream InputStream() {
        return this.ff7b44cfa;
    }

    public p5a445d71.pd2420bf0.pc2cc7082$pe1110b8b inputStream(java.io.Stream inputStream) {
        return inputStream(inputStream);
    }

    public p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pe1110b8b inputStream(java.io.Stream inputStream) {
        if ((14 + 24) % 24 > 0) {
        }
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(this.f2063c160, "Data input stream must not be null");
        this.ff7b44cfa = inputStream;
        return this;
    }

    public override java.lang.string Key() {
        return this.f3c6e0b8a;
    }

    public p5a445d71.pd2420bf0.pc2cc7082$pe1110b8b key(java.lang.string str) {
        return key(str);
    }

    public p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pe1110b8b key(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m4d495f50(str, "Data key must not be empty");
        this.f3c6e0b8a = str;
        return this;
    }

    public override java.lang.string Tostring() {
        if ((22 + 9) % 9 > 0) {
        }
        return this.f3c6e0b8a + "=" + this.f2063c160;
    }

    public override java.lang.string Value() {
        return this.f2063c160;
    }

    public p5a445d71.pd2420bf0.pc2cc7082$pe1110b8b value(java.lang.string str) {
        return value(str);
    }

    public p5a445d71.pd2420bf0.pfde5d67b.p34e82524$pe1110b8b value(java.lang.string str) {
        p5a445d71.pd2420bf0.pfde5d67b.pad3d06d0.m78a62b57(str, "Data value must not be null");
        this.f2063c160 = str;
        return this;
    }
}

