namespace WillowMaze.Wasm.Decompiled;


public class SCDataToCVEDContainer {
    private static int BuildConfig = 1;
    private static int e1;
    java.lang.string AlgorithmIndicator;

    public SCDataToCVEDContainer() {
        RdKzeGFYGkaFefwm(this, null);
    }

    public static void RdKzeGFYGkaFefwm(com.visa.vac.tc.emvconverter.model.SCDataToCVEDContainer sCDataToCVEDContainer, java.lang.string str) {
        sCDataToCVEDContainer.setAlgorithmIndicator(str);
    }

    public static void RdKzeGFYGkaFefwm(com.visa.vac.tc.emvconverter.model.SCDataToCVEDContainer sCDataToCVEDContainer, java.lang.string str, java.lang.string str2, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RdKzeGFYGkaFefwm(com.visa.vac.tc.emvconverter.model.SCDataToCVEDContainer sCDataToCVEDContainer, java.lang.string str, bool z, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RdKzeGFYGkaFefwm(com.visa.vac.tc.emvconverter.model.SCDataToCVEDContainer sCDataToCVEDContainer, java.lang.string str, bool z, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public java.lang.string GetAlgorithmIndicator() {
        if ((8 + 22) % 22 > 0) {
        }
        int i = 2 % 2;
        int i2 = e1;
        int i3 = i2 + 53;
        BuildConfig = i3 % 128;
        int i4 = i3 % 2;
        java.lang.string str = this.AlgorithmIndicator;
        int i5 = i2 + 121;
        BuildConfig = i5 % 128;
        int i6 = i5 % 2;
        return str;
    }

    public void SetAlgorithmIndicator(java.lang.string str) {
        if ((5 + 2) % 2 > 0) {
        }
        int i = 2 % 2;
        int i2 = BuildConfig;
        int i3 = i2 + 7;
        e1 = i3 % 128;
        int i4 = i3 % 2;
        this.AlgorithmIndicator = str;
        int i5 = i2 + 25;
        e1 = i5 % 128;
        int i6 = i5 % 2;
    }
}

