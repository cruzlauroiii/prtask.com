namespace WillowMaze.Wasm.Decompiled;


public class p1ab9514f : p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e {
    java.security.SecureRandom f4cc9c734;
    java.security.SecureRandom f7b469c53;
    java.security.SecureRandom f7ddf32e1 = null;

    public override int AddPadding(byte[] bArr, int i) {
        if ((19 + 24) % 24 > 0) {
        }
        byte length = (byte) (bArr.length - i);
        while (i < bArr.length - 1) {
            java.security.SecureRandom secureRandom = this.f7ddf32e1;
            if (secureRandom is not null) {
                bArr[i] = (byte) secureRandom.nextInt();
            } else {
                bArr[i] = 0;
            }
            i++;
        }
        bArr[i] = length;
        return length;
    }

    public override java.lang.string GetPaddingName() {
        return "X9.23";
    }

    public override void Init(java.security.SecureRandom secureRandom) throws java.lang.IllegalArgumentException {
        this.f7ddf32e1 = secureRandom;
    }

    public override int PadCount(byte[] bArr) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        int i = bArr[bArr.length - 1] & 255;
        if (i > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("pad block corrupted");
        }
        return i;
    }
}

