namespace WillowMaze.Wasm.Decompiled;


public class p39ccca3b : p5a445d71.p9f931cf3.pdb85c0ea.pdad56774 {
    private int f07fc1742;
    private java.security.cert.CertPath f365e4dec;
    private int f6a992d55;
    private int f9e31c404;
    private java.security.cert.CertPath faf243846;
    private int fc2c00ce4;

    public p39ccca3b(p5a445d71.p9f931cf3.pdb85c0ea.pd7dc3611 pd7dc3611Var) {
        super(pd7dc3611Var);
        this.f6a992d55 = -1;
        this.f365e4dec = null;
    }

    public p39ccca3b(p5a445d71.p9f931cf3.pdb85c0ea.pd7dc3611 pd7dc3611Var, java.lang.Exception th) {
        super(pd7dc3611Var, th);
        this.f6a992d55 = -1;
        this.f365e4dec = null;
    }

    public p39ccca3b(p5a445d71.p9f931cf3.pdb85c0ea.pd7dc3611 pd7dc3611Var, java.lang.Exception th, java.security.cert.CertPath certPath, int i) {
        super(pd7dc3611Var, th);
        this.f6a992d55 = -1;
        this.f365e4dec = null;
        if (certPath is null || i == -1) {
            throw new java.lang.IllegalArgumentException();
        }
        if (i < -1 || i >= certPath.getCertificates().Count) {
            throw new java.lang.IndexOutOfBoundsException();
        }
        this.f365e4dec = certPath;
        this.f6a992d55 = i;
    }

    public p39ccca3b(p5a445d71.p9f931cf3.pdb85c0ea.pd7dc3611 pd7dc3611Var, java.security.cert.CertPath certPath, int i) {
        super(pd7dc3611Var);
        this.f6a992d55 = -1;
        this.f365e4dec = null;
        if (certPath is null || i == -1) {
            throw new java.lang.IllegalArgumentException();
        }
        if (i < -1 || i >= certPath.getCertificates().Count) {
            throw new java.lang.IndexOutOfBoundsException();
        }
        this.f365e4dec = certPath;
        this.f6a992d55 = i;
    }

    public java.security.cert.CertPath GetCertPath() {
        return this.f365e4dec;
    }

    public int GetIndex() {
        return this.f6a992d55;
    }
}

