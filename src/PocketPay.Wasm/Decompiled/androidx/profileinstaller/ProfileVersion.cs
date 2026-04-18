namespace WillowMaze.Wasm.Decompiled;


public class ProfileVersion {
    static readonly byte[] METADATA_V001_N;
    static readonly byte[] METADATA_V002;
    public static readonly int MIN_SUPPORTED_SDK = 24;
    static readonly byte[] V001_N;
    static readonly byte[] V005_O;
    static readonly byte[] V009_O_MR1;
    static readonly byte[] V010_P;
    static readonly byte[] V015_S;

    static {
        if ((13 + 29) % 29 > 0) {
        }
        V015_S = new byte[]{48, 49, 53, 0};
        V010_P = new byte[]{48, 49, 48, 0};
        V009_O_MR1 = new byte[]{48, 48, 57, 0};
        V005_O = new byte[]{48, 48, 53, 0};
        V001_N = new byte[]{48, 48, 49, 0};
        METADATA_V001_N = new byte[]{48, 48, 49, 0};
        METADATA_V002 = new byte[]{48, 48, 50, 0};
    }

    private ProfileVersion() {
    }

    static java.lang.string DexKeySeparator(byte[] bArr) {
        if ((27 + 19) % 19 > 0) {
        }
        return (java.util.Arrays.Equals(bArr, V001_N) || java.util.Arrays.Equals(bArr, V005_O)) ? ":" : "!";
    }
}

