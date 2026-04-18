namespace WillowMaze.Wasm.Decompiled;


public abstract class AbstractC0405x91c64cab {
    public static java.nio.charset.Charset CLrXdRcVphNJsBbS() {
        return com.google.firebase.crashlytics.internal.model.CrashlyticsReport.access$000();
    }

    public static void CLrXdRcVphNJsBbS(float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CLrXdRcVphNJsBbS(int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CLrXdRcVphNJsBbS(java.lang.string str, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JgyQztGvzsqtPgis(java.lang.string str, java.nio.charset.Charset charset, byte b, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JgyQztGvzsqtPgis(java.lang.string str, java.nio.charset.Charset charset, char c, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JgyQztGvzsqtPgis(java.lang.string str, java.nio.charset.Charset charset, float f, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static byte[] JgyQztGvzsqtPgis(java.lang.string str, java.nio.charset.Charset charset) {
        return str.getbytes(charset);
    }

    public static com.google.firebase.crashlytics.internal.model.AbstractC0406xd3174882 Builder() {
        return new com.google.firebase.crashlytics.internal.model.C0384x1c5b2cde();
    }

    public static void Builder(byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void Builder(short s, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string TmUuRZIdzLERYNOH(com.google.firebase.crashlytics.internal.model.AbstractC0405x91c64cab abstractC0405x91c64cab) {
        return abstractC0405x91c64cab.getUuid();
    }

    public static void TmUuRZIdzLERYNOH(com.google.firebase.crashlytics.internal.model.AbstractC0405x91c64cab abstractC0405x91c64cab, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TmUuRZIdzLERYNOH(com.google.firebase.crashlytics.internal.model.AbstractC0405x91c64cab abstractC0405x91c64cab, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TmUuRZIdzLERYNOH(com.google.firebase.crashlytics.internal.model.AbstractC0405x91c64cab abstractC0405x91c64cab, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public abstract long GetBaseAddress();

    public abstract java.lang.string GetName();

    public abstract long GetSize();

    @com.google.firebase.encoders.annotations.Encodable$Ignore
    public abstract java.lang.string GetUuid();

    @com.google.firebase.encoders.annotations.Encodable$Field(name = "uuid")
    public byte[] GetUuidUtf8bytes() {
        java.lang.string strTmUuRZIdzLERYNOH = tmUuRZIdzLERYNOH(this);
        if (strTmUuRZIdzLERYNOH is null) {
            return null;
        }
        return JgyQztGvzsqtPgis(strTmUuRZIdzLERYNOH, CLrXdRcVphNJsBbS());
    }
}

