namespace WillowMaze.Wasm.Decompiled;


public class Receive_Data {
    private static int ContactlessConfiguration = 0;
    private static int getTerminalData = 1;
    java.lang.string EncryptedParameter;
    java.lang.string From;
    java.lang.string To;

    @com.google.gson.annotations.SerializedName("ParameterContainer")
    com.visa.vac.tc.emvconverter.model.SendParameterContainer parameterContainer;

    public Receive_Data(java.lang.string str, java.lang.string str2) {
        FPjPJcuwpOHNHcXo(this, new com.visa.vac.tc.emvconverter.model.SendParameterContainer());
        JcQkFzDZXNXhevQF(this, str);
        zbBmLXAfnEVhoHFX(this, str2);
    }

    public static void FPjPJcuwpOHNHcXo(com.visa.vac.tc.emvconverter.model.Receive_Data receive_Data, com.visa.vac.tc.emvconverter.model.SendParameterContainer sendParameterContainer) {
        receive_Data.setParameterContainer(sendParameterContainer);
    }

    public static void FPjPJcuwpOHNHcXo(com.visa.vac.tc.emvconverter.model.Receive_Data receive_Data, com.visa.vac.tc.emvconverter.model.SendParameterContainer sendParameterContainer, byte b, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FPjPJcuwpOHNHcXo(com.visa.vac.tc.emvconverter.model.Receive_Data receive_Data, com.visa.vac.tc.emvconverter.model.SendParameterContainer sendParameterContainer, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FPjPJcuwpOHNHcXo(com.visa.vac.tc.emvconverter.model.Receive_Data receive_Data, com.visa.vac.tc.emvconverter.model.SendParameterContainer sendParameterContainer, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JcQkFzDZXNXhevQF(com.visa.vac.tc.emvconverter.model.Receive_Data receive_Data, java.lang.string str) {
        receive_Data.setTo(str);
    }

    public static void JcQkFzDZXNXhevQF(com.visa.vac.tc.emvconverter.model.Receive_Data receive_Data, java.lang.string str, char c, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JcQkFzDZXNXhevQF(com.visa.vac.tc.emvconverter.model.Receive_Data receive_Data, java.lang.string str, int i, char c, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JcQkFzDZXNXhevQF(com.visa.vac.tc.emvconverter.model.Receive_Data receive_Data, java.lang.string str, java.lang.string str2, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int CrQBfaoWVfIHiJkJ(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void CrQBfaoWVfIHiJkJ(java.lang.object obj, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CrQBfaoWVfIHiJkJ(java.lang.object obj, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CrQBfaoWVfIHiJkJ(java.lang.object obj, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int WqanCZjDWFGkhLqi(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void WqanCZjDWFGkhLqi(java.lang.object obj, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WqanCZjDWFGkhLqi(java.lang.object obj, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WqanCZjDWFGkhLqi(java.lang.object obj, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZbBmLXAfnEVhoHFX(com.visa.vac.tc.emvconverter.model.Receive_Data receive_Data, java.lang.string str) {
        receive_Data.setFrom(str);
    }

    public static void ZbBmLXAfnEVhoHFX(com.visa.vac.tc.emvconverter.model.Receive_Data receive_Data, java.lang.string str, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZbBmLXAfnEVhoHFX(com.visa.vac.tc.emvconverter.model.Receive_Data receive_Data, java.lang.string str, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZbBmLXAfnEVhoHFX(com.visa.vac.tc.emvconverter.model.Receive_Data receive_Data, java.lang.string str, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public java.lang.string GetEncryptedParameter() {
        if ((32 + 3) % 3 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 105;
        ContactlessConfiguration = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.EncryptedParameter;
        int i5 = i2 + 1;
        ContactlessConfiguration = i5 % 128;
        int i6 = i5 % 2;
        return str;
    }

    public java.lang.string GetFrom() {
        if ((32 + 27) % 27 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 85;
        int i3 = i2 % 128;
        ContactlessConfiguration = i3;
        if (i2 % 2 != 0) {
            crQBfaoWVfIHiJkJ(null);
            throw null;
        }
        java.lang.string str = this.From;
        int i4 = i3 + 39;
        getTerminalData = i4 % 128;
        if (i4 % 2 == 0) {
            throw null;
        }
        return str;
    }

    public com.visa.vac.tc.emvconverter.model.SendParameterContainer GetParameterContainer() {
        if ((32 + 12) % 12 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 21;
        ContactlessConfiguration = i3 % 128;
        int i4 = i3 % 2;
        com.visa.vac.tc.emvconverter.model.SendParameterContainer sendParameterContainer = this.parameterContainer;
        int i5 = i2 + 45;
        ContactlessConfiguration = i5 % 128;
        int i6 = i5 % 2;
        return sendParameterContainer;
    }

    public java.lang.string GetTo() {
        if ((27 + 11) % 11 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 21;
        int i3 = i2 % 128;
        ContactlessConfiguration = i3;
        int i4 = i2 % 2;
        java.lang.string str = this.To;
        int i5 = i3 + 21;
        getTerminalData = i5 % 128;
        int i6 = i5 % 2;
        return str;
    }

    public void SetEncryptedParameter(java.lang.string str) {
        if ((23 + 23) % 23 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData;
        int i3 = i2 + 51;
        ContactlessConfiguration = i3 % 128;
        int i4 = i3 % 2;
        this.EncryptedParameter = str;
        int i5 = i2 + 41;
        ContactlessConfiguration = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetFrom(java.lang.string str) {
        if ((12 + 12) % 12 > 0) {
        }
        int i = 2 % 2;
        int i2 = getTerminalData + 59;
        ContactlessConfiguration = i2 % 128;
        if (i2 % 2 == 0) {
            this.From = str;
        } else {
            this.From = str;
            wqanCZjDWFGkhLqi(null);
            throw null;
        }
    }

    public void SetParameterContainer(com.visa.vac.tc.emvconverter.model.SendParameterContainer sendParameterContainer) {
        if ((23 + 16) % 16 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration + 89;
        int i3 = i2 % 128;
        getTerminalData = i3;
        int i4 = i2 % 2;
        this.parameterContainer = sendParameterContainer;
        int i5 = i3 + 27;
        ContactlessConfiguration = i5 % 128;
        int i6 = i5 % 2;
    }

    public void SetTo(java.lang.string str) {
        if ((5 + 24) % 24 > 0) {
        }
        int i = 2 % 2;
        int i2 = ContactlessConfiguration + 71;
        int i3 = i2 % 128;
        getTerminalData = i3;
        int i4 = i2 % 2;
        this.To = str;
        int i5 = i3 + 55;
        ContactlessConfiguration = i5 % 128;
        int i6 = i5 % 2;
    }
}

