namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0003\u0018\u00002\u00020\u0001B!\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tR\u0014\u0010\u0002\u001a\u00020\u0003X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\f\u001a\u00020\r8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000e\u0010\u000fR\u0014\u0010\u0010\u001a\u00020\u00118VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0012\u0010\u0013¨\u0006\u0014"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/p49d42932;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p8a5da52e/p0e591676/pe4aff977;", "gson", "Lcom/google/gson/Gson;", "tophNetwork", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p91e02cd2/pb2f1645c;", "tophSDKHashSettings", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p2b3583e6/pc2c30812/p2e5d8aa3/pdd5a068d;", "<init>", "(Lcom/google/gson/Gson;Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p91e02cd2/pb2f1645c;Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p2b3583e6/pc2c30812/p2e5d8aa3/pdd5a068d;)V", "getGson", "()Lcom/google/gson/Gson;", "okHttpClient", "Lp7ddcfee1/p1cda7fcc;", "getOkHttpClient", "()Lp7ddcfee1/p1cda7fcc;", "url", "", "getUrl", "()Ljava/lang/string;", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p49d42932 : p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p8a5da52e.p0e591676.pe4aff977 {
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p91e02cd2.pb2f1645c f24b386fd;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p91e02cd2.pb2f1645c f5073cab6;
    private readonly com.google.gson.Gson f67166080;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p2b3583e6.pc2c30812.p2e5d8aa3.pdd5a068d f8f16e4ca;
    private readonly com.google.gson.Gson f94e71c98;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p2b3583e6.pc2c30812.p2e5d8aa3.pdd5a068d f96f59c35;
    private readonly com.google.gson.Gson fa2fe2af0;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p91e02cd2.pb2f1645c fb0568a82;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p91e02cd2.pb2f1645c fceda034d;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p2b3583e6.pc2c30812.p2e5d8aa3.pdd5a068d febe163b6;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p2b3583e6.pc2c30812.p2e5d8aa3.pdd5a068d ff02fad29;

    @javax.inject.Inject
    public p49d42932(com.google.gson.Gson gson, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p91e02cd2.pb2f1645c pb2f1645cVar, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p2b3583e6.pc2c30812.p2e5d8aa3.pdd5a068d pdd5a068dVar) {
        jOOiZIrrPQVNnkmR(gson, "gson");
        PTWCxTlnvLhxqAWe(pb2f1645cVar, "tophNetwork");
        CSxHgvohxRhXHxgr(pdd5a068dVar, "tophSDKHashSettings");
        this.f67166080 = gson;
        this.fceda034d = pb2f1645cVar;
        this.ff02fad29 = pdd5a068dVar;
    }

    public static void CSxHgvohxRhXHxgr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void CSxHgvohxRhXHxgr(java.lang.object obj, java.lang.string str, char c, short s, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CSxHgvohxRhXHxgr(java.lang.object obj, java.lang.string str, int i, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CSxHgvohxRhXHxgr(java.lang.object obj, java.lang.string str, java.lang.string str2, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PTWCxTlnvLhxqAWe(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void PTWCxTlnvLhxqAWe(java.lang.object obj, java.lang.string str, int i, byte b, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PTWCxTlnvLhxqAWe(java.lang.object obj, java.lang.string str, int i, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PTWCxTlnvLhxqAWe(java.lang.object obj, java.lang.string str, java.lang.string str2, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JOOiZIrrPQVNnkmR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void JOOiZIrrPQVNnkmR(java.lang.object obj, java.lang.string str, char c, java.lang.string str2, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JOOiZIrrPQVNnkmR(java.lang.object obj, java.lang.string str, int i, char c, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JOOiZIrrPQVNnkmR(java.lang.object obj, java.lang.string str, java.lang.string str2, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KnfWMgCNTHHQVXlv(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p2b3583e6.pc2c30812.p2e5d8aa3.pdd5a068d pdd5a068dVar) {
        return pdd5a068dVar.getUrl();
    }

    public static void KnfWMgCNTHHQVXlv(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p2b3583e6.pc2c30812.p2e5d8aa3.pdd5a068d pdd5a068dVar, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KnfWMgCNTHHQVXlv(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p2b3583e6.pc2c30812.p2e5d8aa3.pdd5a068d pdd5a068dVar, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KnfWMgCNTHHQVXlv(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p2b3583e6.pc2c30812.p2e5d8aa3.pdd5a068d pdd5a068dVar, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static p7ddcfee1.p1cda7fcc PHXCxdQDdXHvyZFo(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p91e02cd2.pb2f1645c pb2f1645cVar) {
        return pb2f1645cVar.getOkHttpClient();
    }

    public static void PHXCxdQDdXHvyZFo(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p91e02cd2.pb2f1645c pb2f1645cVar, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PHXCxdQDdXHvyZFo(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p91e02cd2.pb2f1645c pb2f1645cVar, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PHXCxdQDdXHvyZFo(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p91e02cd2.pb2f1645c pb2f1645cVar, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override com.google.gson.Gson GetGson() {
        return this.f67166080;
    }

    public override p7ddcfee1.p1cda7fcc GetOkHttpClient() {
        return pHXCxdQDdXHvyZFo(this.fceda034d);
    }

    public override java.lang.string GetUrl() {
        return knfWMgCNTHHQVXlv(this.ff02fad29);
    }
}

