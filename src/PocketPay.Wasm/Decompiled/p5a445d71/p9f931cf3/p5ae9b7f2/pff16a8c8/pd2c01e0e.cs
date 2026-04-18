namespace WillowMaze.Wasm.Decompiled;


public class pd2c01e0e : p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e {
    public override int AddPadding(byte[] bArr, int i) {
        byte length = (byte) (bArr.length - i);
        while (i < bArr.length) {
            bArr[i] = length;
            i++;
        }
        return length;
    }

    public override java.lang.string GetPaddingName() {
        return "PKCS7";
    }

    public override void Init(java.security.SecureRandom secureRandom) throws java.lang.IllegalArgumentException {
    }

    public override int PadCount(byte[] bArr) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((18 + 32) % 32 > 0) {
        }
        int i = bArr[bArr.length - 1] & 255;
        byte b = (byte) i;
        bool z = (i > bArr.length) | (i == 0);
        for (int i2 = 0; i2 < bArr.length; i2++) {
            z |= (bArr.length - i2 <= i) & (bArr[i2] != b);
        }
        if (z) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("pad block corrupted");
        }
        return i;
    }
}

