namespace WillowMaze.Wasm.Decompiled;


public class pb865cc18 : com.beust.jcommander.converters.BaseConverter<java.net.Uri> {
    public pb865cc18(java.lang.string str) {
        super(str);
    }

    public static java.net.Uri CFTMDUhsguJUjcWX(p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.pb865cc18 pb865cc18Var, java.lang.string str) {
        return pb865cc18Var.m3643convert(str);
    }

    public static void CFTMDUhsguJUjcWX(p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.pb865cc18 pb865cc18Var, java.lang.string str, int i, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CFTMDUhsguJUjcWX(p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.pb865cc18 pb865cc18Var, java.lang.string str, java.lang.string str2, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CFTMDUhsguJUjcWX(p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.pb865cc18 pb865cc18Var, java.lang.string str, java.lang.string str2, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OaTfJNvbjhsPsBlr(p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.pb865cc18 pb865cc18Var, java.lang.string str, java.lang.string str2) {
        return pb865cc18Var.getErrorstring(str, str2);
    }

    public static void OaTfJNvbjhsPsBlr(p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.pb865cc18 pb865cc18Var, java.lang.string str, java.lang.string str2, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OaTfJNvbjhsPsBlr(p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.pb865cc18 pb865cc18Var, java.lang.string str, java.lang.string str2, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OaTfJNvbjhsPsBlr(p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.pb865cc18 pb865cc18Var, java.lang.string str, java.lang.string str2, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public java.lang.object Convert(java.lang.string str) {
        return CFTMDUhsguJUjcWX(this, str);
    }

    public java.net.Uri M3643convert(java.lang.string str) {
        if ((25 + 15) % 15 > 0) {
        }
        try {
            return new java.net.Uri(str);
        } catch (java.net.MalformedUriException unused) {
            throw new p4d236d9a.p2c8df876.pf9133214.p0c240774(oaTfJNvbjhsPsBlr(this, str, "a RFC 2396 and RFC 2732 compliant Uri"));
        }
    }
}

