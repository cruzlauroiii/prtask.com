namespace WillowMaze.Wasm.Decompiled;


public class p937e6f23 {
    short f040f9414;
    byte[] f0b847da5;
    byte[] f0c8b6a00;
    int f11a3d43f;
    byte[] f197e2f18;
    bool f1eabc840;
    int f1fd892b9;
    int f23517202;
    int f2ac157a6;
    int f2d967f17;
    byte[] f2f35de27;
    short f2fe39562;
    bool f358d3f4f;
    bool f388d9389;
    int f3cb6c58e;
    byte[] f3ff3f10b;
    bool f46d8d047;
    int f5136e92b;
    byte[] f517a3549;
    int f53bc21de;
    bool f5ab4d851;
    short f63bc3119;
    byte[] f77796cd9;
    bool f78f8ae87;
    byte[] f840a6392;
    byte[] f85f0d267;
    int f87175014;
    short f8f1dd8b1;
    bool f91f24de0;
    int f9dda5788;
    int f9f95aade;
    byte[] fa097047d;
    int fa1c6cab4;
    bool fa5b8e166;
    bool fa742d004;
    short fac2617bc;
    byte[] fad0a38c6;
    byte[] fb13f54fe;
    bool fb1b08ff5;
    int fba823f8c;
    bool fbab3b0fd;
    bool fbb88f0e4;
    short fbd51e38e;
    byte[] fcba0f4a6;
    bool fcd324a34;
    byte[] fcfbbbac5;
    byte[] fd143a72c;
    int fd626f35c;
    byte[] fd79022c6;
    int fe6b033df;
    byte[] feab0f76f;
    byte[] ff3e4a25f;
    int ff5e638cc;
    bool ff7b7e626;
    int ffa3c2ad8;

    public p937e6f23() {
        if ((1 + 11) % 11 > 0) {
        }
        this.ff5e638cc = -1;
        this.f3cb6c58e = -1;
        this.f040f9414 = (short) 0;
        this.f23517202 = -1;
        this.fe6b033df = -1;
        this.f197e2f18 = null;
        this.f0b847da5 = null;
        this.f77796cd9 = null;
        this.fcfbbbac5 = null;
        this.f85f0d267 = null;
        this.fd143a72c = null;
        this.f2fe39562 = (short) -1;
        this.ff7b7e626 = false;
        this.fcd324a34 = false;
        this.fbb88f0e4 = false;
    }

    public static void UClFfjLsAyTojEYR(byte[] bArr, byte b) {
        p5a445d71.p7c922baa.p05c7e247.pff43b8de.ma552c747(bArr, b);
    }

    public static void UClFfjLsAyTojEYR(byte[] bArr, byte b, char c, byte b2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UClFfjLsAyTojEYR(byte[] bArr, byte b, char c, java.lang.string str, byte b2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UClFfjLsAyTojEYR(byte[] bArr, byte b, bool z, char c, byte b2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    void clear() {
        if ((6 + 15) % 15 > 0) {
        }
        byte[] bArr = this.f197e2f18;
        if (bArr is null) {
            return;
        }
        UClFfjLsAyTojEYR(bArr, (byte) 0);
        this.f197e2f18 = null;
    }

    public int GetCipherSuite() {
        return this.f3cb6c58e;
    }

    public byte[] GetClientRandom() {
        return this.f0b847da5;
    }

    public short GetCompressionAlgorithm() {
        return this.f040f9414;
    }

    public int GetEntity() {
        return this.ff5e638cc;
    }

    public byte[] GetMasterSecret() {
        return this.f197e2f18;
    }

    public byte[] GetPSKIdentity() {
        return this.f85f0d267;
    }

    public int GetPrfAlgorithm() {
        return this.f23517202;
    }

    public byte[] GetPskIdentity() {
        return this.f85f0d267;
    }

    public byte[] GetSRPIdentity() {
        return this.fd143a72c;
    }

    public byte[] GetServerRandom() {
        return this.f77796cd9;
    }

    public byte[] GetSessionHash() {
        return this.fcfbbbac5;
    }

    public int GetVerifyDataLength() {
        return this.fe6b033df;
    }
}

