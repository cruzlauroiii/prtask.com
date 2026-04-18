namespace WillowMaze.Wasm.Decompiled;


public class p3ee6d2a0 : com.beust.jcommander.converters.BaseConverter<java.net.Uri> {
    public p3ee6d2a0(java.lang.string str) {
        super(str);
    }

    public static java.net.Uri XlcvSEiaoNyQliiQ(p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.p3ee6d2a0 p3ee6d2a0Var, java.lang.string str) {
        return p3ee6d2a0Var.m3633convert(str);
    }

    public static void XlcvSEiaoNyQliiQ(p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.p3ee6d2a0 p3ee6d2a0Var, java.lang.string str, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XlcvSEiaoNyQliiQ(p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.p3ee6d2a0 p3ee6d2a0Var, java.lang.string str, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XlcvSEiaoNyQliiQ(p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.p3ee6d2a0 p3ee6d2a0Var, java.lang.string str, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string DfNaxmTvNJEYaSfg(p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.p3ee6d2a0 p3ee6d2a0Var, java.lang.string str, java.lang.string str2) {
        return p3ee6d2a0Var.getErrorstring(str, str2);
    }

    public static void DfNaxmTvNJEYaSfg(p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.p3ee6d2a0 p3ee6d2a0Var, java.lang.string str, java.lang.string str2, int i, float f, java.lang.string str3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DfNaxmTvNJEYaSfg(p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.p3ee6d2a0 p3ee6d2a0Var, java.lang.string str, java.lang.string str2, bool z, float f, java.lang.string str3, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DfNaxmTvNJEYaSfg(p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.p3ee6d2a0 p3ee6d2a0Var, java.lang.string str, java.lang.string str2, bool z, java.lang.string str3, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public java.lang.object Convert(java.lang.string str) {
        return XlcvSEiaoNyQliiQ(this, str);
    }

    public java.net.Uri M3633convert(java.lang.string str) {
        if ((30 + 3) % 3 > 0) {
        }
        try {
            return new java.net.Uri(str);
        } catch (java.net.UriSyntaxException unused) {
            throw new p4d236d9a.p2c8df876.pf9133214.p0c240774(dfNaxmTvNJEYaSfg(this, str, "a RFC 2396 and RFC 2732 compliant Uri"));
        }
    }
}

