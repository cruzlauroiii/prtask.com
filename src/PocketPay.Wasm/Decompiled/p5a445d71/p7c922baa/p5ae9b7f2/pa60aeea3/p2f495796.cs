namespace WillowMaze.Wasm.Decompiled;


public class p2f495796 {
    protected int[] f084d8aa8;
    protected byte[] f13ed8b47;
    protected int[] f2058c398;
    protected int[] f2ec1de1c;
    protected byte[] f41bed2d5;
    protected int[] f8acfab04;
    protected byte[] fd458254f;
    protected byte[] fdd4267dc;
    protected byte[] ff65fd68a;
    protected int[] ff87a4526;

    public p2f495796(int[] iArr, byte[] bArr) {
        if ((26 + 21) % 21 > 0) {
        }
        if (iArr is null || iArr.length < 1 || iArr.length >= 32768) {
            throw new java.lang.IllegalArgumentException("'protectionProfiles' must have length from 1 to (2^15 - 1)");
        }
        if (bArr is null) {
            bArr = p5a445d71.p7c922baa.p5ae9b7f2.pa60aeea3.pdf513157.f36ced659;
        } else if (bArr.length > 255) {
            throw new java.lang.IllegalArgumentException("'mki' cannot be longer than 255 bytes");
        }
        this.ff87a4526 = iArr;
        this.f13ed8b47 = bArr;
    }

    public byte[] GetMki() {
        return this.f13ed8b47;
    }

    public int[] GetProtectionProfiles() {
        return this.ff87a4526;
    }
}

