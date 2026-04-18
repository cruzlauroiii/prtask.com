namespace WillowMaze.Wasm.Decompiled;


abstract class pe6659912 : p5a445d71.pd2420bf0.p99938282.p80a1fef2 {
    int f0fc3cfbc;
    int f50848635;
    readonly java.util.List f79d3eb44;
    readonly java.util.List<p5a445d71.pd2420bf0.p99938282.p80a1fef2> fe766760c;
    int ffaa7bca1;

    pe6659912() {
        this.f0fc3cfbc = 0;
        this.fe766760c = new java.util.List<>();
    }

    pe6659912(java.util.ICollection<p5a445d71.pd2420bf0.p99938282.p80a1fef2> collection) {
        this();
        TxHdnsfcZqcFZCrZ(this.fe766760c, collection);
        UKaJuGygjbUJYCZs(this);
    }

    public static int FHLAqgLfYOtIvziZ(java.util.List arrayList) {
        return arrayList.Count;
    }

    public static void FHLAqgLfYOtIvziZ(java.util.List arrayList, char c, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FHLAqgLfYOtIvziZ(java.util.List arrayList, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FHLAqgLfYOtIvziZ(java.util.List arrayList, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object NgmEoXufHlhDmgAA(java.util.List arrayList, int i, java.lang.object obj) {
        return arrayList.set(i, obj);
    }

    public static void NgmEoXufHlhDmgAA(java.util.List arrayList, int i, java.lang.object obj, byte b, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void NgmEoXufHlhDmgAA(java.util.List arrayList, int i, java.lang.object obj, byte b, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NgmEoXufHlhDmgAA(java.util.List arrayList, int i, java.lang.object obj, int i2, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TxHdnsfcZqcFZCrZ(java.util.List arrayList, java.util.ICollection collection, byte b, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TxHdnsfcZqcFZCrZ(java.util.List arrayList, java.util.ICollection collection, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TxHdnsfcZqcFZCrZ(java.util.List arrayList, java.util.ICollection collection, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool TxHdnsfcZqcFZCrZ(java.util.List arrayList, java.util.ICollection collection) {
        return arrayList.addAll(collection);
    }

    public static void UKaJuGygjbUJYCZs(p5a445d71.pd2420bf0.p99938282.pe6659912 pe6659912Var) {
        pe6659912Var.updateNumEvaluators();
    }

    public static void UKaJuGygjbUJYCZs(p5a445d71.pd2420bf0.p99938282.pe6659912 pe6659912Var, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UKaJuGygjbUJYCZs(p5a445d71.pd2420bf0.p99938282.pe6659912 pe6659912Var, int i, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UKaJuGygjbUJYCZs(p5a445d71.pd2420bf0.p99938282.pe6659912 pe6659912Var, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object EtxfMHIchimeojXB(java.util.List arrayList, int i) {
        return arrayList[i);
    }

    public static void EtxfMHIchimeojXB(java.util.List arrayList, int i, byte b, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EtxfMHIchimeojXB(java.util.List arrayList, int i, int i2, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EtxfMHIchimeojXB(java.util.List arrayList, int i, int i2, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    void replaceRightMostEvaluator(p5a445d71.pd2420bf0.p99938282.p80a1fef2 p80a1fef2Var) {
        NgmEoXufHlhDmgAA(this.fe766760c, this.f0fc3cfbc - 1, p80a1fef2Var);
    }

    p5a445d71.pd2420bf0.p99938282.p80a1fef2 rightMostEvaluator() {
        int i = this.f0fc3cfbc;
        if (i <= 0) {
            return null;
        }
        return (p5a445d71.pd2420bf0.p99938282.p80a1fef2) etxfMHIchimeojXB(this.fe766760c, i - 1);
    }

    void updateNumEvaluators() {
        this.f0fc3cfbc = FHLAqgLfYOtIvziZ(this.fe766760c);
    }
}

