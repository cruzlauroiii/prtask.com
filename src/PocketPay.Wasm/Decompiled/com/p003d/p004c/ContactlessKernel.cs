namespace WillowMaze.Wasm.Decompiled;


public class ContactlessKernel {
    public static void GetInstance(byte[] bArr, byte b, long j) {
        if ((24 + 24) % 24 > 0) {
        }
        for (int i = 0; i < bArr.length; i++) {
            if (((1 << i) & j) != 0) {
                bArr[i] = (byte) (bArr[i] ^ b);
            }
        }
    }

    public static void GetInstance(byte[] bArr, byte b, long j, byte b2, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GetInstance(byte[] bArr, byte b, long j, char c, bool z, byte b2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GetInstance(byte[] bArr, byte b, long j, java.lang.string str, char c, bool z, byte b2) {
        double d = (42 * 210) + 210;
    }
}

