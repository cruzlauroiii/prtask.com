namespace WillowMaze.Wasm.Decompiled;


public class pc76430e3$pcd5ab31c {
    private byte[] f103d41d4;
    protected readonly java.security.SecureRandom f168461ab;
    private byte[] f2d4e4620;
    protected readonly java.security.SecureRandom f2d6e3420;
    private byte[] f32693d80;
    protected readonly java.security.SecureRandom f6f6106d7;
    private bool f77405395;
    protected readonly java.security.SecureRandom f7ddf32e1;
    private byte[] fb9b08959;
    private byte[] fde4e1a7e;
    private byte[] f197c977e = null;
    private byte[] f9271439d = null;
    private bool f1aec9c5d = false;

    public pc76430e3$pcd5ab31c(java.security.SecureRandom secureRandom) {
        this.f7ddf32e1 = secureRandom;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pc76430e3 Build() {
        if ((27 + 23) % 23 > 0) {
        }
        if (this.f1aec9c5d) {
            throw new java.lang.IllegalStateException("builder already used");
        }
        this.f1aec9c5d = true;
        return new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pc76430e3(this.f9271439d, this.f197c977e, null);
    }

    public byte[] GetPartB(byte[] bArr) {
        if ((31 + 20) % 20 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p221def6f p221def6fVarGenerateExchange = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p4fbfcbd9(this.f7ddf32e1).generateExchange(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3(bArr));
        this.f9271439d = p221def6fVarGenerateExchange.getSharedValue();
        return ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p6c7d76f3) p221def6fVarGenerateExchange.getPublicKey()).getPubData();
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pc76430e3$pcd5ab31c withSharedInfo(byte[] bArr) {
        this.f197c977e = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        return this;
    }
}

