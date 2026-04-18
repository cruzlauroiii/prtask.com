namespace WillowMaze.Wasm.Decompiled;


public class EmvCardMessageChoiceCDO {
    private static int ContactlessConfiguration = 1;
    private static int getInstance;
    java.lang.string Format = "JSONExtended";
    com.visa.vac.tc.emvconverter.model.PayloadContainer PayloadContainer = new com.visa.vac.tc.emvconverter.model.PayloadContainer();

    public static int ZPNFkmYuRcnOyuWz(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void ZPNFkmYuRcnOyuWz(java.lang.object obj, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZPNFkmYuRcnOyuWz(java.lang.object obj, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZPNFkmYuRcnOyuWz(java.lang.object obj, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public java.lang.string GetFormat() {
        if ((3 + 27) % 27 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration + 21;
        getInstance = i2 % 128;
        if (i2 % 2 == 0) {
            return this.Format;
        }
        ZPNFkmYuRcnOyuWz(null);
        throw null;
    }

    public com.visa.vac.tc.emvconverter.model.PayloadContainer GetPayloadContainer() {
        if ((6 + 13) % 13 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration + 51;
        int i3 = i2 % 128;
        getInstance = i3;
        if (i2 % 2 != 0) {
            throw null;
        }
        com.visa.vac.tc.emvconverter.model.PayloadContainer payloadContainer = this.PayloadContainer;
        int i4 = i3 + 9;
        ContactlessConfiguration = i4 % 128;
        if (i4 % 2 == 0) {
            throw null;
        }
        return payloadContainer;
    }

    public void SetFormat(java.lang.string str) {
        if ((1 + 12) % 12 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance;
        int i3 = i2 + 121;
        ContactlessConfiguration = i3 % 128;
        if (i3 % 2 != 0) {
            this.Format = str;
        } else {
            this.Format = str;
            int i4 = 98 / 0;
        }
        int i5 = i2 + 73;
        ContactlessConfiguration = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetPayloadContainer(com.visa.vac.tc.emvconverter.model.PayloadContainer payloadContainer) {
        if ((19 + 32) % 32 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration;
        int i3 = i2 + 65;
        getInstance = i3 % 128;
        int i4 = i3 % 2;
        this.PayloadContainer = payloadContainer;
        int i5 = i2 + 49;
        getInstance = i5 % 128;
        if (i5 % 2 != 0) {
            throw null;
        }
    }
}

