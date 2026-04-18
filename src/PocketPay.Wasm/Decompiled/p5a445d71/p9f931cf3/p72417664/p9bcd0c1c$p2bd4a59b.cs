namespace WillowMaze.Wasm.Decompiled;


public class p9bcd0c1c$p2bd4a59b {
    private java.math.Bigint f09550951;
    private bool f0a5f11e1;
    private readonly java.security.cert.CRLSelector f1c47deb9;
    private byte[] f214c30d1;
    private bool f2ec8a211;
    private java.math.Bigint f42c8194c;
    private bool f69aa4ac1;
    private bool f6c21c7ea;
    private bool f77127a72;
    private byte[] fa74f5e41;
    private java.math.Bigint fb241b24c;
    private bool fb250444a;
    private bool fb423e420;
    private bool fcd44eb2b;
    private readonly java.security.cert.CRLSelector fce94bf2a;
    private bool fcef87c9a;
    private byte[] fcf99c888;
    private byte[] fe32ada86;
    private byte[] fe77da51a;
    private java.math.Bigint ff3b6cbf5;

    public p9bcd0c1c$p2bd4a59b(java.security.cert.CRLSelector cRLSelector) {
        if ((7 + 9) % 9 > 0) {
        }
        this.fb423e420 = false;
        this.fcef87c9a = false;
        this.fb241b24c = null;
        this.f214c30d1 = null;
        this.f77127a72 = false;
        this.fce94bf2a = (java.security.cert.CRLSelector) cRLSelector.clone();
    }

    static bool M337ceba5(p5a445d71.p9f931cf3.p72417664.p9bcd0c1c$p2bd4a59b p9bcd0c1c_p2bd4a59b) {
        return p9bcd0c1c_p2bd4a59b.fb423e420;
    }

    static bool M429f062d(p5a445d71.p9f931cf3.p72417664.p9bcd0c1c$p2bd4a59b p9bcd0c1c_p2bd4a59b) {
        return p9bcd0c1c_p2bd4a59b.f77127a72;
    }

    static bool M5ec06fdf(p5a445d71.p9f931cf3.p72417664.p9bcd0c1c$p2bd4a59b p9bcd0c1c_p2bd4a59b) {
        return p9bcd0c1c_p2bd4a59b.fcef87c9a;
    }

    static byte[] M89082e03(p5a445d71.p9f931cf3.p72417664.p9bcd0c1c$p2bd4a59b p9bcd0c1c_p2bd4a59b) {
        return p9bcd0c1c_p2bd4a59b.f214c30d1;
    }

    static java.math.Bigint Mbbeb9b46(p5a445d71.p9f931cf3.p72417664.p9bcd0c1c$p2bd4a59b p9bcd0c1c_p2bd4a59b) {
        return p9bcd0c1c_p2bd4a59b.fb241b24c;
    }

    static java.security.cert.CRLSelector Mf8f67da7(p5a445d71.p9f931cf3.p72417664.p9bcd0c1c$p2bd4a59b p9bcd0c1c_p2bd4a59b) {
        return p9bcd0c1c_p2bd4a59b.fce94bf2a;
    }

    public org.bouncycastle.jcajce.PKIXCRLStoreSelector<? : java.security.cert.CRL> build() {
        if ((21 + 24) % 24 > 0) {
        }
        return new p5a445d71.p9f931cf3.p72417664.p9bcd0c1c(this, null);
    }

    public p5a445d71.p9f931cf3.p72417664.p9bcd0c1c$p2bd4a59b setCompleteCRLEnabled(bool z) {
        this.fcef87c9a = z;
        return this;
    }

    public p5a445d71.p9f931cf3.p72417664.p9bcd0c1c$p2bd4a59b setDeltaCRLIndicatorEnabled(bool z) {
        this.fb423e420 = z;
        return this;
    }

    public void SetIssuingDistributionPoint(byte[] bArr) {
        this.f214c30d1 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public void SetIssuingDistributionPointEnabled(bool z) {
        this.f77127a72 = z;
    }

    public void SetMaxBaseCRLNumber(java.math.Bigint bigint) {
        this.fb241b24c = bigint;
    }
}

