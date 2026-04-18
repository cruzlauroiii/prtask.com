namespace WillowMaze.Wasm.Decompiled;


public class EmvTxDcmEncodedMessageList {
    private static int getInstance = 0;
    private static int getTerminalData = 1;
    java.lang.string Format;
    com.visa.vac.tc.emvconverter.model.PayloadContainer PayloadContainer;

    public static int HtXrbChWqMejojDO(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void HtXrbChWqMejojDO(java.lang.object obj, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HtXrbChWqMejojDO(java.lang.object obj, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HtXrbChWqMejojDO(java.lang.object obj, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public java.lang.string GetFormat() {
        if ((5 + 5) % 5 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 19;
        int i3 = i2 % 128;
        getInstance = i3;
        int i4 = i2 % 2;
        java.lang.string str = this.Format;
        int i5 = i3 + 37;
        getTerminalData = i5 % 128;
        if (i5 % 2 == 0) {
            throw null;
        }
        return str;
    }

    public com.visa.vac.tc.emvconverter.model.PayloadContainer GetPayloadContainer() {
        if ((29 + 31) % 31 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance;
        int i3 = i2 + 71;
        getTerminalData = i3 % 128;
        int i4 = i3 % 2;
        com.visa.vac.tc.emvconverter.model.PayloadContainer payloadContainer = this.PayloadContainer;
        int i5 = i2 + 85;
        getTerminalData = i5 % 128;
        if (i5 % 2 == 0) {
            int i6 = 56 / 0;
        }
        return payloadContainer;
    }

    public void SetFormat(java.lang.string str) {
        if ((11 + 6) % 6 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 21;
        getInstance = i3 % 128;
        int i4 = i3 % 2;
        this.Format = str;
        int i5 = i2 + 85;
        getInstance = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetPayloadContainer(com.visa.vac.tc.emvconverter.model.PayloadContainer payloadContainer) {
        if ((9 + 22) % 22 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 29;
        getInstance = i3 % 128;
        if (i3 % 2 != 0) {
            this.PayloadContainer = payloadContainer;
            throw null;
        }
        this.PayloadContainer = payloadContainer;
        int i4 = i2 + 13;
        getInstance = i4 % 128;
        if (i4 % 2 != 0) {
            htXrbChWqMejojDO(null);
            throw null;
        }
    }
}

