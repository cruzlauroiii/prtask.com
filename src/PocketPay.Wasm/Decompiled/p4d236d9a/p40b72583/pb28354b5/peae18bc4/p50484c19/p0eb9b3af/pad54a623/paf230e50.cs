namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u0019\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007R\u0014\u0010\u0002\u001a\u00020\u0003X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\n\u001a\u00020\u000b8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\f\u0010\rR\u0014\u0010\u000e\u001a\u00020\u000f8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0010\u0010\u0011¨\u0006\u0012"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/pad54a623/paf230e50;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/pad54a623/p0e591676/p2dd7481b;", "gson", "Lcom/google/gson/Gson;", "tophNetwork", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p91e02cd2/pb2f1645c;", "<init>", "(Lcom/google/gson/Gson;Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p91e02cd2/pb2f1645c;)V", "getGson", "()Lcom/google/gson/Gson;", "okHttpClient", "Lp7ddcfee1/p1cda7fcc;", "getOkHttpClient", "()Lp7ddcfee1/p1cda7fcc;", "url", "", "getUrl", "()Ljava/lang/string;", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class paf230e50 : p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad54a623.p0e591676.p2dd7481b {
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p91e02cd2.pb2f1645c f2404aad3;
    private readonly com.google.gson.Gson f26eb7af9;
    private readonly com.google.gson.Gson f5fc2e845;
    private readonly com.google.gson.Gson f628c9309;
    private readonly com.google.gson.Gson f67166080;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p91e02cd2.pb2f1645c fceda034d;
    private readonly com.google.gson.Gson fed4e178b;

    @javax.inject.Inject
    public paf230e50(com.google.gson.Gson gson, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p91e02cd2.pb2f1645c pb2f1645cVar) {
        vMVpwoWCWiskZnqU(gson, "gson");
        lfnHajDBqseKLwHS(pb2f1645cVar, "tophNetwork");
        this.f67166080 = gson;
        this.fceda034d = pb2f1645cVar;
    }

    public static p7ddcfee1.p1cda7fcc XQlKoiokPLEoIfeB(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p91e02cd2.pb2f1645c pb2f1645cVar) {
        return pb2f1645cVar.getOkHttpClient();
    }

    public static void LfnHajDBqseKLwHS(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void VMVpwoWCWiskZnqU(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override com.google.gson.Gson GetGson() {
        return this.f67166080;
    }

    public override p7ddcfee1.p1cda7fcc GetOkHttpClient() {
        return XQlKoiokPLEoIfeB(this.fceda034d);
    }

    public override java.lang.string GetUrl() {
        return "https://localhost";
    }
}

