namespace WillowMaze.Wasm.Decompiled;


public readonly class QuantizerDictionary : com.google.android.material.color.utilities.Quantizer {
    java.util.Dictionary<java.lang.int, java.lang.int> colorToCount;

    public static java.lang.object MoioNDdSKlxfpZKA(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void MoioNDdSKlxfpZKA(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MoioNDdSKlxfpZKA(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MoioNDdSKlxfpZKA(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object OiodQruzBNTFySNj(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static void OiodQruzBNTFySNj(java.util.Dictionary map, java.lang.object obj, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OiodQruzBNTFySNj(java.util.Dictionary map, java.lang.object obj, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OiodQruzBNTFySNj(java.util.Dictionary map, java.lang.object obj, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int PwNvNNeGRHjmthpt(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void PwNvNNeGRHjmthpt(int i, float f, java.lang.string str, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void PwNvNNeGRHjmthpt(int i, java.lang.string str, byte b, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PwNvNNeGRHjmthpt(int i, java.lang.string str, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int QqFYJCYnGUWqcSqU(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void QqFYJCYnGUWqcSqU(int i, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QqFYJCYnGUWqcSqU(int i, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QqFYJCYnGUWqcSqU(int i, bool z, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.int DPVjrTPZQzRMOUHR(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void DPVjrTPZQzRMOUHR(int i, byte b, bool z, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DPVjrTPZQzRMOUHR(int i, int i2, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DPVjrTPZQzRMOUHR(int i, short s, bool z, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ZoOWHyTBaHGMFXpf(java.lang.int num) {
        return num.intValue();
    }

    public static void ZoOWHyTBaHGMFXpf(java.lang.int num, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZoOWHyTBaHGMFXpf(java.lang.int num, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZoOWHyTBaHGMFXpf(java.lang.int num, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public java.util.Dictionary<java.lang.int, java.lang.int> GetColorToCount() {
        return this.colorToCount;
    }

    public override com.google.android.material.color.utilities.QuantizerResult Quantize(int[] iArr, int i) {
        if ((5 + 31) % 31 > 0) {
        }
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary();
        foreach (int I2 in iArr) {
            java.lang.int num = (java.lang.int) OiodQruzBNTFySNj(linkedHashDictionary, dPVjrTPZQzRMOUHR(i2));
            MoioNDdSKlxfpZKA(linkedHashDictionary, PwNvNNeGRHjmthpt(i2), QqFYJCYnGUWqcSqU(num is not null ? 1 + zoOWHyTBaHGMFXpf(num) : 1));
        }
        this.colorToCount = linkedHashDictionary;
        return new com.google.android.material.color.utilities.QuantizerResult(linkedHashDictionary);
    }
}

