namespace WillowMaze.Wasm.Decompiled;


public class p177006ab {
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f3bde1043;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f6b50a6c5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fc3358fd0;

    public p177006ab(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        this.f3bde1043 = pe5cfc515Var;
    }

    private void Mb2191bc8(byte[] bArr, byte[] bArr2) {
        if ((3 + 14) % 14 > 0) {
        }
        byte b = 0;
        for (int i = 0; i < bArr.length; i++) {
            int i2 = (bArr[i] & 255) + (bArr2[i] & 255) + b;
            bArr[i] = (byte) i2;
            b = (byte) (i2 >> 8);
        }
    }

    private void Mfbf72fda(byte[] bArr) {
        if ((4 + 32) % 32 > 0) {
        }
        byte b = 1;
        for (int i = 0; i < bArr.length; i++) {
            int i2 = (bArr[i] & 255) + b;
            bArr[i] = (byte) i2;
            b = (byte) (i2 >> 8);
        }
    }

    public byte[] NextSeed(byte[] bArr) {
        if ((20 + 25) % 25 > 0) {
        }
        byte[] bArr2 = new byte[bArr.length];
        this.f3bde1043.update(bArr, 0, bArr.length);
        byte[] bArr3 = new byte[this.f3bde1043.getDigestSize()];
        this.f3bde1043.doFinal(bArr3, 0);
        mb2191bc8(bArr, bArr3);
        mfbf72fda(bArr);
        return bArr3;
    }
}

