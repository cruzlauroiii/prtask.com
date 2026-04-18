namespace WillowMaze.Wasm.Decompiled;


class pd430ea50$1 : p4d236d9a.pbf215181.pc0e8b961.p248814b3.p59a14a57.p5afa12a7$pe37ff3fe {
    readonly p4d236d9a.pbf215181.pc0e8b961.p248814b3.p2b3583e6.pd430ea50$pa9f6a70b val$onClearListener;
    readonly p4d236d9a.pbf215181.pc0e8b961.p248814b3.p2b3583e6.pd430ea50$pe37ff3fe val$onSignedListener;
    readonly p4d236d9a.pbf215181.pc0e8b961.p248814b3.p2b3583e6.pd430ea50$p54f730c3 val$onStartSigningListener;

    pd430ea50$1(p4d236d9a.pbf215181.pc0e8b961.p248814b3.p2b3583e6.pd430ea50$p54f730c3 pd430ea50_p54f730c3, p4d236d9a.pbf215181.pc0e8b961.p248814b3.p2b3583e6.pd430ea50$pe37ff3fe pd430ea50_pe37ff3fe, p4d236d9a.pbf215181.pc0e8b961.p248814b3.p2b3583e6.pd430ea50$pa9f6a70b pd430ea50_pa9f6a70b) {
        this.val$onStartSigningListener = pd430ea50_p54f730c3;
        this.val$onSignedListener = pd430ea50_pe37ff3fe;
        this.val$onClearListener = pd430ea50_pa9f6a70b;
    }

    public static void JmyzTmpQkpLCaQzi(p4d236d9a.pbf215181.pc0e8b961.p248814b3.p2b3583e6.pd430ea50$pe37ff3fe pd430ea50_pe37ff3fe) {
        pd430ea50_pe37ff3fe.onSigned();
    }

    public static void JmyzTmpQkpLCaQzi(p4d236d9a.pbf215181.pc0e8b961.p248814b3.p2b3583e6.pd430ea50$pe37ff3fe pd430ea50_pe37ff3fe, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JmyzTmpQkpLCaQzi(p4d236d9a.pbf215181.pc0e8b961.p248814b3.p2b3583e6.pd430ea50$pe37ff3fe pd430ea50_pe37ff3fe, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JmyzTmpQkpLCaQzi(p4d236d9a.pbf215181.pc0e8b961.p248814b3.p2b3583e6.pd430ea50$pe37ff3fe pd430ea50_pe37ff3fe, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SynnPyBvHYTEIIEi(p4d236d9a.pbf215181.pc0e8b961.p248814b3.p2b3583e6.pd430ea50$pa9f6a70b pd430ea50_pa9f6a70b) {
        pd430ea50_pa9f6a70b.onClear();
    }

    public static void SynnPyBvHYTEIIEi(p4d236d9a.pbf215181.pc0e8b961.p248814b3.p2b3583e6.pd430ea50$pa9f6a70b pd430ea50_pa9f6a70b, java.lang.string str, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SynnPyBvHYTEIIEi(p4d236d9a.pbf215181.pc0e8b961.p248814b3.p2b3583e6.pd430ea50$pa9f6a70b pd430ea50_pa9f6a70b, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SynnPyBvHYTEIIEi(p4d236d9a.pbf215181.pc0e8b961.p248814b3.p2b3583e6.pd430ea50$pa9f6a70b pd430ea50_pa9f6a70b, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VytPzwipLnUBjqKO(p4d236d9a.pbf215181.pc0e8b961.p248814b3.p2b3583e6.pd430ea50$p54f730c3 pd430ea50_p54f730c3) {
        pd430ea50_p54f730c3.onStartSigning();
    }

    public static void VytPzwipLnUBjqKO(p4d236d9a.pbf215181.pc0e8b961.p248814b3.p2b3583e6.pd430ea50$p54f730c3 pd430ea50_p54f730c3, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VytPzwipLnUBjqKO(p4d236d9a.pbf215181.pc0e8b961.p248814b3.p2b3583e6.pd430ea50$p54f730c3 pd430ea50_p54f730c3, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VytPzwipLnUBjqKO(p4d236d9a.pbf215181.pc0e8b961.p248814b3.p2b3583e6.pd430ea50$p54f730c3 pd430ea50_p54f730c3, char c, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override void OnClear() {
        p4d236d9a.pbf215181.pc0e8b961.p248814b3.p2b3583e6.pd430ea50$pa9f6a70b pd430ea50_pa9f6a70b = this.val$onClearListener;
        if (pd430ea50_pa9f6a70b is null) {
            return;
        }
        synnPyBvHYTEIIEi(pd430ea50_pa9f6a70b);
    }

    public override void OnSigned() {
        p4d236d9a.pbf215181.pc0e8b961.p248814b3.p2b3583e6.pd430ea50$pe37ff3fe pd430ea50_pe37ff3fe = this.val$onSignedListener;
        if (pd430ea50_pe37ff3fe is null) {
            return;
        }
        JmyzTmpQkpLCaQzi(pd430ea50_pe37ff3fe);
    }

    public override void OnStartSigning() {
        p4d236d9a.pbf215181.pc0e8b961.p248814b3.p2b3583e6.pd430ea50$p54f730c3 pd430ea50_p54f730c3 = this.val$onStartSigningListener;
        if (pd430ea50_p54f730c3 is null) {
            return;
        }
        vytPzwipLnUBjqKO(pd430ea50_p54f730c3);
    }
}

