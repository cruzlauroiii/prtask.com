namespace WillowMaze.Wasm.Decompiled;


public class Cancel_Transaction {
    private static int getInstance = 1;
    private static int getTerminalData;
    java.lang.string EncryptedParameter;
    java.lang.string From;
    java.lang.string To;

    @com.google.gson.annotations.SerializedName("ParameterContainer")
    com.visa.vac.tc.emvconverter.model.Cancel_Transaction$ParameterContainer parameterContainer;

    public Cancel_Transaction(java.lang.string str, java.lang.string str2) {
        ouxTKQgiknSZGiOH(this, new com.visa.vac.tc.emvconverter.model.Cancel_Transaction$ParameterContainer(this));
        wkobADodxbtJrZun(this, str);
        CCBvvzvuYTIVlyMy(this, str2);
    }

    public static void CCBvvzvuYTIVlyMy(com.visa.vac.tc.emvconverter.model.Cancel_Transaction cancel_Transaction, java.lang.string str) {
        cancel_Transaction.setFrom(str);
    }

    public static void CCBvvzvuYTIVlyMy(com.visa.vac.tc.emvconverter.model.Cancel_Transaction cancel_Transaction, java.lang.string str, float f, char c, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CCBvvzvuYTIVlyMy(com.visa.vac.tc.emvconverter.model.Cancel_Transaction cancel_Transaction, java.lang.string str, float f, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CCBvvzvuYTIVlyMy(com.visa.vac.tc.emvconverter.model.Cancel_Transaction cancel_Transaction, java.lang.string str, java.lang.string str2, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OuxTKQgiknSZGiOH(com.visa.vac.tc.emvconverter.model.Cancel_Transaction cancel_Transaction, com.visa.vac.tc.emvconverter.model.Cancel_Transaction$ParameterContainer cancel_Transaction$ParameterContainer) {
        cancel_Transaction.setParameterContainer(cancel_Transaction$ParameterContainer);
    }

    public static void OuxTKQgiknSZGiOH(com.visa.vac.tc.emvconverter.model.Cancel_Transaction cancel_Transaction, com.visa.vac.tc.emvconverter.model.Cancel_Transaction$ParameterContainer cancel_Transaction$ParameterContainer, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OuxTKQgiknSZGiOH(com.visa.vac.tc.emvconverter.model.Cancel_Transaction cancel_Transaction, com.visa.vac.tc.emvconverter.model.Cancel_Transaction$ParameterContainer cancel_Transaction$ParameterContainer, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OuxTKQgiknSZGiOH(com.visa.vac.tc.emvconverter.model.Cancel_Transaction cancel_Transaction, com.visa.vac.tc.emvconverter.model.Cancel_Transaction$ParameterContainer cancel_Transaction$ParameterContainer, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WkobADodxbtJrZun(com.visa.vac.tc.emvconverter.model.Cancel_Transaction cancel_Transaction, java.lang.string str) {
        cancel_Transaction.setTo(str);
    }

    public static void WkobADodxbtJrZun(com.visa.vac.tc.emvconverter.model.Cancel_Transaction cancel_Transaction, java.lang.string str, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WkobADodxbtJrZun(com.visa.vac.tc.emvconverter.model.Cancel_Transaction cancel_Transaction, java.lang.string str, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WkobADodxbtJrZun(com.visa.vac.tc.emvconverter.model.Cancel_Transaction cancel_Transaction, java.lang.string str, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public java.lang.string GetEncryptedParameter() {
        if ((14 + 18) % 18 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance;
        int i3 = i2 + 79;
        getTerminalData = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.EncryptedParameter;
        int i5 = i2 + 29;
        getTerminalData = i5 % 128;
        int i6 = i5 % 2;
        return str;
    }

    public java.lang.string GetFrom() {
        if ((26 + 1) % 1 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 35;
        getInstance = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.From;
        int i5 = i2 + 75;
        getInstance = i5 % 128;
        int i6 = i5 % 2;
        return str;
    }

    public com.visa.vac.tc.emvconverter.model.Cancel_Transaction$ParameterContainer getParameterContainer() {
        if ((6 + 26) % 26 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance + 77;
        int i3 = i2 % 128;
        getTerminalData = i3;
        int i4 = i2 % 2;
        com.visa.vac.tc.emvconverter.model.Cancel_Transaction$ParameterContainer cancel_Transaction$ParameterContainer = this.parameterContainer;
        int i5 = i3 + 93;
        getInstance = i5 % 128;
        int i6 = i5 % 2;
        return cancel_Transaction$ParameterContainer;
    }

    public java.lang.string GetTo() {
        if ((3 + 24) % 24 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 11;
        getInstance = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.To;
        int i5 = i2 + 85;
        getInstance = i5 % 128;
        if (i5 % 2 == 0) {
            throw null;
        }
        return str;
    }

    public void SetEncryptedParameter(java.lang.string str) {
        if ((30 + 26) % 26 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 119;
        int i3 = i2 % 128;
        getInstance = i3;
        int i4 = i2 % 2;
        this.EncryptedParameter = str;
        int i5 = i3 + 109;
        getTerminalData = i5 % 128;
        if (i5 % 2 != 0) {
            throw null;
        }
    }

    public void SetFrom(java.lang.string str) {
        if ((22 + 1) % 1 > 0) {
        }
        int i = 2 % 2;
        int i2 = getInstance + 57;
        getTerminalData = i2 % 128;
        if (i2 % 2 != 0) {
            this.From = str;
            throw null;
        }
        this.From = str;
    }

    public void SetParameterContainer(com.visa.vac.tc.emvconverter.model.Cancel_Transaction$ParameterContainer cancel_Transaction$ParameterContainer) {
        if ((4 + 20) % 20 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 3;
        int i3 = i2 % 128;
        getInstance = i3;
        int i4 = i2 % 2;
        this.parameterContainer = cancel_Transaction$ParameterContainer;
        int i5 = i3 + 63;
        getTerminalData = i5 % 128;
        if (i5 % 2 == 0) {
            return;
        }
        int i6 = 0 / 0;
    }

    public void SetTo(java.lang.string str) {
        if ((2 + 18) % 18 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 3;
        getInstance = i3 % 128;
        int i4 = i3 % 2;
        this.To = str;
        int i5 = i2 + 43;
        getInstance = i5 % 128;
        if (i5 % 2 != 0) {
            return;
        }
        int i6 = 81 / 0;
    }
}

