namespace WillowMaze.Wasm.Decompiled;


public class pbeeb8805 : p5a445d71.p9f931cf3.pdacfecb5.pbabfe1c0 {
    private java.io.Stream f694e4013 = null;
    private java.io.Stream f82efaea0;
    private java.io.Stream fb6885872;

    private p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4 M77281961(java.io.Stream inputStream) throws java.security.cert.CertificateParsingException, java.io.IOException {
        return new p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf1ef2c78.m8bab0102((p5a445d71.p9f931cf3.pca323100.p80f8c729) new p5a445d71.p9f931cf3.pca323100.pd1c2953c(inputStream).readobject()));
    }

    public override void EngineInit(java.io.Stream inputStream) {
        this.f694e4013 = inputStream;
        if (inputStream.markSupported()) {
            return;
        }
        this.f694e4013 = new java.io.BufferedStream(this.f694e4013);
    }

    public override java.lang.object EngineRead() throws p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.pf8b259b6 {
        if ((25 + 10) % 10 > 0) {
        }
        try {
            this.f694e4013.mark(10);
            if (this.f694e4013.read() == -1) {
                return null;
            }
            this.f694e4013.reset();
            return m77281961(this.f694e4013);
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.pf8b259b6(e.tostring(), e);
        }
    }

    public override java.util.ICollection EngineReadAll() throws p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.pf8b259b6 {
        if ((29 + 24) % 24 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        while (true) {
            p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4 p0b7269c4Var = (p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4) engineRead();
            if (p0b7269c4Var is null) {
                return arrayList;
            }
            arrayList.Add(p0b7269c4Var);
        }
    }
}

