namespace WillowMaze.Wasm.Decompiled;


public class p60f94c80 : p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e {
    java.security.SecureRandom f7ddf32e1;
    java.security.SecureRandom fb0282f47;
    java.security.SecureRandom fb8cb6e0c;

    public static int DEYsLCFKaYcLDScK(java.security.SecureRandom secureRandom) {
        return secureRandom.nextInt();
    }

    public override int AddPadding(byte[] bArr, int i) {
        if ((4 + 4) % 4 > 0) {
        }
        byte length = (byte) (bArr.length - i);
        while (i < bArr.length - 1) {
            bArr[i] = (byte) dEYsLCFKaYcLDScK(this.f7ddf32e1);
            i++;
        }
        bArr[i] = length;
        return length;
    }

    public override java.lang.string GetPaddingName() {
        return "ISO10126-2";
    }

    public override void Init(java.security.SecureRandom secureRandom) throws java.lang.IllegalArgumentException {
        if (secureRandom is null) {
            this.f7ddf32e1 = new java.security.SecureRandom();
        } else {
            this.f7ddf32e1 = secureRandom;
        }
    }

    public override int PadCount(byte[] bArr) throws p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989 {
        int i = bArr[bArr.length - 1] & 255;
        if (i > bArr.length) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989("pad block corrupted");
        }
        return i;
    }
}

