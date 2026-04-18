namespace WillowMaze.Wasm.Decompiled;


public class Version {
    private static int ContactlessConfiguration = 0;
    private static int e1 = 1;
    private static int getInstance = 1;
    private static int getTerminalData;
    private static readonly byte[] version;

    static {
        if ((16 + 11) % 11 > 0) {
        }
        version = new byte[]{3, 16};
        int i = 1 + 71;
        getTerminalData = i % 128;
        int i2 = i % 2;
    }

    public static void GetVersion(int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GetVersion(int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GetVersion(bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static byte[] GetVersion() {
        if ((11 + 13) % 13 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration + 47;
        int i3 = i2 % 128;
        getInstance = i3;
        int i4 = i2 % 2;
        byte[] bArr = version;
        int i5 = i3 + 47;
        ContactlessConfiguration = i5 % 128;
        if (i5 % 2 != 0) {
            throw null;
        }
        return bArr;
    }
}

