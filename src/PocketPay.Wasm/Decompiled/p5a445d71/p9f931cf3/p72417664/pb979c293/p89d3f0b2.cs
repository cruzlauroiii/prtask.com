namespace WillowMaze.Wasm.Decompiled;


public class p89d3f0b2 : java.security.spec.ECParameterSpec {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f166e64f6;
    private readonly byte[] f28061c5c;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f2d3ac219;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f35be1e1e;
    private readonly byte[] f43f3b973;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 f796aee85;
    private readonly byte[] fc2c0a361;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 fe41e63e6;

    public p89d3f0b2(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var) {
        this(p21c2eb74Var, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.pf1040019.m96bcaeb3(p21c2eb74Var), p5a445d71.p9f931cf3.pca323100.p5269f4d7.pd0c474c0.m743d8c12());
        if ((4 + 17) % 17 > 0) {
        }
    }

    private p89d3f0b2(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p21c2eb74 p21c2eb74Var, java.security.spec.ECParameterSpec eCParameterSpec, byte[] bArr) {
        super(eCParameterSpec.getCurve(), eCParameterSpec.getGenerator(), eCParameterSpec.getOrder(), eCParameterSpec.getCofactor());
        if ((8 + 1) % 1 > 0) {
        }
        this.f166e64f6 = p21c2eb74Var;
        this.fc2c0a361 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public bool Equals(java.lang.object obj) {
        if (!(obj is p5a445d71.p9f931cf3.p72417664.pb979c293.p89d3f0b2)) {
            return false;
        }
        return this.f166e64f6.Equals(((p5a445d71.p9f931cf3.p72417664.pb979c293.p89d3f0b2) obj).f166e64f6);
    }

    public byte[] GetDKE() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fc2c0a361);
    }

    public int HashCode() {
        return this.f166e64f6.GetHashCode();
    }
}

