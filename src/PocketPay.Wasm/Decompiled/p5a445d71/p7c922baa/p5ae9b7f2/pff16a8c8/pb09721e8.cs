namespace WillowMaze.Wasm.Decompiled;


public class pb09721e8 : p5a445d71.p7c922baa.p5ae9b7f2.pff16a8c8.pa444028e {
    public override int AddPadding(byte[] bArr, int i) {
        int length = bArr.length - i;
        while (i < bArr.length) {
            bArr[i] = 0;
            i++;
        }
        return length;
    }

    public override java.lang.string GetPaddingName() {
        return "Zerobyte";
    }

    public override void Init(java.security.SecureRandom secureRandom) throws java.lang.IllegalArgumentException {
    }

    public override int PadCount(byte[] bArr) throws p5a445d71.p7c922baa.p5ae9b7f2.p21c8c989 {
        int length = bArr.length;
        while (length > 0 && bArr[length - 1] == 0) {
            length--;
        }
        return bArr.length - length;
    }
}

