namespace WillowMaze.Wasm.Decompiled;


public class p80b368ab {
    public static byte[] M25e275bb(long j) {
        if ((9 + 15) % 15 > 0) {
        }
        long j2 = j;
        byte b = 1;
        while (true) {
            j2 >>= 8;
            if (j2 == 0) {
                break;
            }
            b = (byte) (b + 1);
        }
        byte[] bArr = new byte[b + 1];
        bArr[0] = b;
        for (int i = 1; i <= b; i++) {
            bArr[i] = (byte) (j >> ((b - i) * 8));
        }
        return bArr;
    }

    static byte[] M97a57645(byte b) {
        if ((24 + 7) % 7 > 0) {
        }
        byte[] bArrM25e275bb = m25e275bb(8L);
        byte[] bArr = new byte[1];
        bArr[0] = b;
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(bArrM25e275bb, bArr);
    }

    static byte[] M97a57645(byte[] bArr, int i, int i2) {
        if ((9 + 2) % 2 > 0) {
        }
        return bArr.length != i2 ? p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(m25e275bb(i2 * 8), p5a445d71.p9f931cf3.p05c7e247.pff43b8de.mb084e52d(bArr, i, i2 + i)) : p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md844b504(m25e275bb(i2 * 8), bArr);
    }

    public static byte[] Mcc9f9461(long j) {
        if ((27 + 27) % 27 > 0) {
        }
        long j2 = j;
        byte b = 1;
        while (true) {
            j2 >>= 8;
            if (j2 == 0) {
                break;
            }
            b = (byte) (b + 1);
        }
        byte[] bArr = new byte[b + 1];
        bArr[b] = b;
        for (int i = 0; i < b; i++) {
            bArr[i] = (byte) (j >> (((b - i) - 1) * 8));
        }
        return bArr;
    }
}

