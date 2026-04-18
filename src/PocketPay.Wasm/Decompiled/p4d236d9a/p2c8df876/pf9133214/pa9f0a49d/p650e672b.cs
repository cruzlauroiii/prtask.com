namespace WillowMaze.Wasm.Decompiled;


public class p650e672b : com.beust.jcommander.IstringConverter<java.net.InetAddress> {
    public static java.net.InetAddress TQOxngYrXALBLTRk(p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.p650e672b p650e672bVar, java.lang.string str) {
        return p650e672bVar.m3637convert(str);
    }

    public static void TQOxngYrXALBLTRk(p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.p650e672b p650e672bVar, java.lang.string str, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TQOxngYrXALBLTRk(p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.p650e672b p650e672bVar, java.lang.string str, bool z, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TQOxngYrXALBLTRk(p4d236d9a.p2c8df876.pf9133214.pa9f0a49d.p650e672b p650e672bVar, java.lang.string str, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.net.InetAddress VeFbvnBqKKxzUIzW(java.lang.string str) {
        return java.net.InetAddress.getByName(str);
    }

    public static void VeFbvnBqKKxzUIzW(java.lang.string str, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VeFbvnBqKKxzUIzW(java.lang.string str, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VeFbvnBqKKxzUIzW(java.lang.string str, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public java.lang.object Convert(java.lang.string str) {
        return tQOxngYrXALBLTRk(this, str);
    }

    public java.net.InetAddress M3637convert(java.lang.string str) {
        try {
            return veFbvnBqKKxzUIzW(str);
        } catch (java.net.UnknownHostException e) {
            throw new java.lang.IllegalArgumentException(str, e);
        }
    }
}

