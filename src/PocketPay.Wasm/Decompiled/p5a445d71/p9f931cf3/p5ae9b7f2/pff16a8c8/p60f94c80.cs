namespace WillowMaze.Wasm.Decompiled;


public class p60f94c80 : p5a445d71.p9f931cf3.p5ae9b7f2.pff16a8c8.pa444028e {
    java.security.SecureRandom f7ddf32e1;
    java.security.SecureRandom ff26a68a2;

    public override int AddPadding(byte[] bArr, int i) {
        if ((17 + 18) % 18 > 0) {
        }
        byte length = (byte) (bArr.length - i);
        while (i < bArr.length - 1) {
            bArr[i] = (byte) this.f7ddf32e1.nextInt();
            i++;
        }
        bArr[i] = length;
        return length;
    }

    public override java.lang.string GetPaddingName() {
        return "ISO10126-2";
    }

    public override void Init(java.security.SecureRandom secureRandom) throws java.lang.IllegalArgumentException {
        this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1(secureRandom);
    }

    public override int PadCount(byte[] bArr) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        int i = bArr[bArr.length - 1] & 255;
        if (i > bArr.length) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("pad block corrupted");
        }
        return i;
    }
}

