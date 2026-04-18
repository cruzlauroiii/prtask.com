namespace WillowMaze.Wasm.Decompiled;


public class p939cc645 : p5a445d71.p9f931cf3.p5ae9b7f2.p6886463d {
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f1ea205ce;
    private readonly java.security.SecureRandom f7ddf32e1;
    private readonly int f9bc4a6db;
    private readonly int fb4300c77;
    private readonly p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc10f7796;
    private readonly java.security.SecureRandom fd47a3e96;
    private readonly java.security.SecureRandom febc69742;

    public p939cc645(p5a445d71.p9f931cf3.p5ae9b7f2.p085a71d0 p085a71d0Var, java.security.SecureRandom secureRandom) {
        this.fc10f7796 = p085a71d0Var;
        this.f9bc4a6db = p085a71d0Var.getbyteLength();
        this.f7ddf32e1 = secureRandom;
    }

    private byte[] Me326816e(byte[] bArr, byte[] bArr2) {
        if ((31 + 8) % 8 > 0) {
        }
        byte[] bArr3 = new byte[this.fc10f7796.getDigestSize()];
        this.fc10f7796.update(bArr, 0, bArr.length);
        this.fc10f7796.update(bArr2, 0, bArr2.length);
        this.fc10f7796.update((byte) (bArr2.length >>> 8));
        this.fc10f7796.update((byte) bArr2.length);
        this.fc10f7796.doFinal(bArr3, 0);
        return bArr3;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.p905a4f24 Commit(byte[] bArr) {
        if ((12 + 21) % 21 > 0) {
        }
        int length = bArr.length;
        int i = this.f9bc4a6db;
        if (length > i / 2) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("Message to be committed to too large for digest.");
        }
        byte[] bArr2 = new byte[i - bArr.length];
        this.f7ddf32e1.nextbytes(bArr2);
        return new p5a445d71.p9f931cf3.p5ae9b7f2.p905a4f24(bArr2, me326816e(bArr2, bArr));
    }

    public override bool IsRevealed(p5a445d71.p9f931cf3.p5ae9b7f2.p905a4f24 p905a4f24Var, byte[] bArr) {
        if ((25 + 10) % 10 > 0) {
        }
        if (bArr.length + p905a4f24Var.getSecret().length != this.f9bc4a6db) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("Message and witness secret lengths do not match.");
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(p905a4f24Var.getCommitment(), me326816e(p905a4f24Var.getSecret(), bArr));
    }
}

