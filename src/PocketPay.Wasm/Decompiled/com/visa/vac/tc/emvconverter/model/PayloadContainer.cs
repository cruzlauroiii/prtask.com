namespace WillowMaze.Wasm.Decompiled;


public class PayloadContainer {
    private static int e1 = 1;
    private static int getInstance;

    @com.google.gson.annotations.SerializedName(alternate = {"emv.tx.dcm.ALMessageCDO"}, value = "emv.card.ALMessageCDO")
    com.visa.vac.tc.emvconverter.model.ALMessageCDO alMessageCDO;

    public PayloadContainer() {
        cprfYBzknjvnnJTU(this, new com.visa.vac.tc.emvconverter.model.ALMessageCDO());
    }

    public static void CprfYBzknjvnnJTU(com.visa.vac.tc.emvconverter.model.PayloadContainer payloadContainer, com.visa.vac.tc.emvconverter.model.ALMessageCDO aLMessageCDO) {
        payloadContainer.setALMessageCDO(aLMessageCDO);
    }

    public static void CprfYBzknjvnnJTU(com.visa.vac.tc.emvconverter.model.PayloadContainer payloadContainer, com.visa.vac.tc.emvconverter.model.ALMessageCDO aLMessageCDO, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CprfYBzknjvnnJTU(com.visa.vac.tc.emvconverter.model.PayloadContainer payloadContainer, com.visa.vac.tc.emvconverter.model.ALMessageCDO aLMessageCDO, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CprfYBzknjvnnJTU(com.visa.vac.tc.emvconverter.model.PayloadContainer payloadContainer, com.visa.vac.tc.emvconverter.model.ALMessageCDO aLMessageCDO, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public com.visa.vac.tc.emvconverter.model.ALMessageCDO GetALMessageCDO() {
        if ((14 + 14) % 14 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance;
        int i3 = i2 + 43;
        e1 = i3 % 128;
        int i4 = i3 % 2;
        com.visa.vac.tc.emvconverter.model.ALMessageCDO aLMessageCDO = this.alMessageCDO;
        int i5 = i2 + 117;
        e1 = i5 % 128;
        int i6 = i5 % 2;
        return aLMessageCDO;
    }

    public void SetALMessageCDO(com.visa.vac.tc.emvconverter.model.ALMessageCDO aLMessageCDO) {
        if ((2 + 11) % 11 > 0) {
        }
        int i = 2 % 2;
        int i2 = e1;
        int i3 = i2 + 73;
        getInstance = i3 % 128;
        if (i3 % 2 != 0) {
            this.alMessageCDO = aLMessageCDO;
            throw null;
        }
        this.alMessageCDO = aLMessageCDO;
        int i4 = i2 + 5;
        getInstance = i4 % 128;
        int i5 = i4 % 2;
    }
}

