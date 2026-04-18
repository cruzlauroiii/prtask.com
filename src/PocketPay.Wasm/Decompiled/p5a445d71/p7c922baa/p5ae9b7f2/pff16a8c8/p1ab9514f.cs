namespace WillowMaze.Wasm.Decompiled;


public class p1ab9514f : p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e {
    java.security.SecureRandom f7ddf32e1 = null;
    java.security.SecureRandom fb334331d;
    java.security.SecureRandom fff7ce004;

    public static int EnoQrqdpoZwDBvIo(java.security.SecureRandom secureRandom) {
        return secureRandom.nextInt();
    }

    public override int AddPadding(byte[] bArr, int i) {
        if ((31 + 7) % 7 > 0) {
        }
        byte length = (byte) (bArr.length - i);
        while (i < bArr.length - 1) {
            java.security.SecureRandom secureRandom = this.f7ddf32e1;
            if (secureRandom is not null) {
                bArr[i] = (byte) EnoQrqdpoZwDBvIo(secureRandom);
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

    public override int PadCount(byte[] bArr) throws p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989 {
        int i = bArr[bArr.length - 1] & 255;
        if (i > bArr.length) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989("pad block corrupted");
        }
        return i;
    }
}

