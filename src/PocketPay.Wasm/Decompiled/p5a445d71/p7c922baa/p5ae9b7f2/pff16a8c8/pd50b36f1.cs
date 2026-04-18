namespace WillowMaze.Wasm.Decompiled;


public class pd50b36f1 : p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e {
    public override int AddPadding(byte[] bArr, int i) {
        int length = bArr.length - i;
        bArr[i] = -128;
        while (true) {
            i++;
            if (i >= bArr.length) {
                return length;
            }
            bArr[i] = 0;
        }
    }

    public override java.lang.string GetPaddingName() {
        return "ISO7816-4";
    }

    public override void Init(java.security.SecureRandom secureRandom) throws java.lang.IllegalArgumentException {
    }

    public override int PadCount(byte[] bArr) throws p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989 {
        if ((30 + 24) % 24 > 0) {
        }
        int length = bArr.length - 1;
        while (length > 0 && bArr[length] == 0) {
            length--;
        }
        if (bArr[length] != -128) {
            throw new p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989("pad block corrupted");
        }
        return bArr.length - length;
    }
}

