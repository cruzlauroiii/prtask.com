namespace WillowMaze.Wasm.Decompiled;


class CAL$getInstance {
    byte BuildConfig;
    byte[] ContactlessConfiguration;
    java.lang.string ContactlessKernel;
    byte[] e1;
    private com.visa.vac.tc.emvconverter.CAL getCAKeys;
    byte getInstance;
    byte[] getTerminalData;
    private byte[] setCAKeys;
    private byte[] setTerminalData;

    CAL$getInstance(com.visa.vac.tc.emvconverter.CAL cal, byte[] bArr, byte[] bArr2, byte[] bArr3, byte[] bArr4, byte b, byte b2, byte[] bArr5, int i) {
        this.getCAKeys = cal;
        this.getTerminalData = bArr;
        this.ContactlessConfiguration = bArr2;
        this.setCAKeys = bArr3;
        this.setTerminalData = bArr4;
        this.BuildConfig = b;
        this.getInstance = b2;
        this.e1 = bArr5;
        this.ContactlessKernel = ASsyGJIOTGbxyGRF((byte[]) GDRalwrqpvnWBZYC(com.visa.vac.tc.emvconverter.CAL.e1, i));
    }

    public static java.lang.string ASsyGJIOTGbxyGRF(byte[] bArr) {
        return com.visa.vac.tc.emvconverter.Utils.getHexstring(bArr);
    }

    public static void ASsyGJIOTGbxyGRF(byte[] bArr, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ASsyGJIOTGbxyGRF(byte[] bArr, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ASsyGJIOTGbxyGRF(byte[] bArr, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GDRalwrqpvnWBZYC(java.util.List list, int i) {
        return list[i);
    }

    public static void GDRalwrqpvnWBZYC(java.util.List list, int i, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GDRalwrqpvnWBZYC(java.util.List list, int i, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GDRalwrqpvnWBZYC(java.util.List list, int i, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }
}

