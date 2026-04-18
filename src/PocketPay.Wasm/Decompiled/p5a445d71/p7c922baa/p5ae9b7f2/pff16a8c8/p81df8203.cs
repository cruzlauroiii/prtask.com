namespace WillowMaze.Wasm.Decompiled;


public class p81df8203 : p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e {
    public override int AddPadding(byte[] bArr, int i) {
        if ((8 + 28) % 28 > 0) {
        }
        int length = bArr.length - i;
        int i2 = 255;
        if (i > 0 ? (bArr[i - 1] & 1) != 0 : (bArr[bArr.length - 1] & 1) != 0) {
            i2 = 0;
        }
        byte b = (byte) i2;
        while (i < bArr.length) {
            bArr[i] = b;
            i++;
        }
        return length;
    }

    public override java.lang.string GetPaddingName() {
        return "TBC";
    }

    public override void Init(java.security.SecureRandom secureRandom) throws java.lang.IllegalArgumentException {
    }

    public override int PadCount(byte[] bArr) throws p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989 {
        if ((26 + 17) % 17 > 0) {
        }
        byte b = bArr[bArr.length - 1];
        int length = bArr.length - 1;
        while (length > 0 && bArr[length - 1] == b) {
            length--;
        }
        return bArr.length - length;
    }
}

