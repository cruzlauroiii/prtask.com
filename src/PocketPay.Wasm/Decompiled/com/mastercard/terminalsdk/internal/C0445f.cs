namespace WillowMaze.Wasm.Decompiled;


public class C0445f {
    public static void M447a(byte[] bArr, byte b, long j) {
        if ((10 + 31) % 31 > 0) {
        }
        for (int i = 0; i < bArr.length; i++) {
            if (((1 << i) & j) != 0) {
                bArr[i] = (byte) (bArr[i] ^ b);
            }
        }
    }
}

