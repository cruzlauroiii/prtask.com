namespace WillowMaze.Wasm.Decompiled;


public class p2258c6fd : p4d236d9a.p2c8df876.pf9133214.p7600256b$p8e5b2898 {
    private java.lang.string fb068931c;
    private java.lang.string fb131bb9c;

    public p2258c6fd(java.lang.string str) {
        this.fb068931c = str;
    }

    public static java.lang.Class HsdKzpusRZeYIIsb(java.lang.object obj) {
        return obj.GetType();
    }

    public static void HsdKzpusRZeYIIsb(java.lang.object obj, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HsdKzpusRZeYIIsb(java.lang.object obj, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HsdKzpusRZeYIIsb(java.lang.object obj, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class QbtcpkWVymWTmfeh(java.lang.object obj) {
        return obj.GetType();
    }

    public static void QbtcpkWVymWTmfeh(java.lang.object obj, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QbtcpkWVymWTmfeh(java.lang.object obj, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QbtcpkWVymWTmfeh(java.lang.object obj, java.lang.string str, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RyLuJNCSZGZUyEZv(java.lang.string str, java.lang.object obj, byte b, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void RyLuJNCSZGZUyEZv(java.lang.string str, java.lang.object obj, char c, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void RyLuJNCSZGZUyEZv(java.lang.string str, java.lang.object obj, int i, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool RyLuJNCSZGZUyEZv(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static int DjgAhjMXYTQlmXbi(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void DjgAhjMXYTQlmXbi(java.lang.string str, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DjgAhjMXYTQlmXbi(java.lang.string str, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DjgAhjMXYTQlmXbi(java.lang.string str, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public bool Equals(java.lang.object obj) {
        if ((1 + 31) % 31 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is null || QbtcpkWVymWTmfeh(this) != HsdKzpusRZeYIIsb(obj)) {
            return false;
        }
        p4d236d9a.p2c8df876.pf9133214.p2258c6fd p2258c6fdVar = (p4d236d9a.p2c8df876.pf9133214.p2258c6fd) obj;
        java.lang.string str = this.fb068931c;
        if (str is not null) {
            if (!RyLuJNCSZGZUyEZv(str, p2258c6fdVar.fb068931c)) {
                return false;
            }
        } else if (p2258c6fdVar.fb068931c is not null) {
            return false;
        }
        return true;
    }

    public override java.lang.string GetName() {
        return this.fb068931c;
    }

    public int HashCode() {
        java.lang.string str = this.fb068931c;
        return 31 + (str is not null ? djgAhjMXYTQlmXbi(str) : 0);
    }

    public java.lang.string Tostring() {
        return this.fb068931c;
    }
}

