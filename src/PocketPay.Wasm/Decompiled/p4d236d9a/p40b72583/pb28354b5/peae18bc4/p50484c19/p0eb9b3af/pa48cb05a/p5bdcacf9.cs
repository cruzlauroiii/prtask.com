namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0003\u0018\u00002\u00020\u0001B!\b\u0007\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007¢\u0006\u0004\b\b\u0010\tR\u0014\u0010\u0002\u001a\u00020\u0003X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\f\u001a\u00020\r8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000e\u0010\u000fR\u0014\u0010\u0010\u001a\u00020\u00118VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0012\u0010\u0013¨\u0006\u0014"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p0eb9b3af/pa48cb05a/p5bdcacf9;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/pa48cb05a/p0e591676/p3f178564;", "gson", "Lcom/google/gson/Gson;", "tophNetwork", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p91e02cd2/pb2f1645c;", "tophSDKHashSettings", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p2b3583e6/pc2c30812/p2e5d8aa3/pdd5a068d;", "<init>", "(Lcom/google/gson/Gson;Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p0eb9b3af/p91e02cd2/pb2f1645c;Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p3a21cd73/p50484c19/p2b3583e6/pc2c30812/p2e5d8aa3/pdd5a068d;)V", "getGson", "()Lcom/google/gson/Gson;", "okHttpClient", "Lp7ddcfee1/p1cda7fcc;", "getOkHttpClient", "()Lp7ddcfee1/p1cda7fcc;", "url", "", "getUrl", "()Ljava/lang/string;", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p5bdcacf9 : p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pa48cb05a.p0e591676.p3f178564 {
    private readonly com.google.gson.Gson f62ca54f9;
    private readonly com.google.gson.Gson f67166080;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p91e02cd2.pb2f1645c f79dee312;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p2b3583e6.pc2c30812.p2e5d8aa3.pdd5a068d f7c9ba311;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p91e02cd2.pb2f1645c f85cf5d0c;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p91e02cd2.pb2f1645c fa2ff9a2a;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p91e02cd2.pb2f1645c fa677fe65;
    private readonly com.google.gson.Gson fc6f2db79;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p91e02cd2.pb2f1645c fceda034d;
    private readonly com.google.gson.Gson fda26f0b8;
    private readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p2b3583e6.pc2c30812.p2e5d8aa3.pdd5a068d ff02fad29;
    private readonly com.google.gson.Gson ff3ccdcd8;

    @javax.inject.Inject
    public p5bdcacf9(com.google.gson.Gson gson, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p91e02cd2.pb2f1645c pb2f1645cVar, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p2b3583e6.pc2c30812.p2e5d8aa3.pdd5a068d pdd5a068dVar) {
        gpmCJJMwuZwhtFAe(gson, "gson");
        bHqsEivNHTVRasEr(pb2f1645cVar, "tophNetwork");
        kjBRlEckauKrNWrV(pdd5a068dVar, "tophSDKHashSettings");
        this.f67166080 = gson;
        this.fceda034d = pb2f1645cVar;
        this.ff02fad29 = pdd5a068dVar;
    }

    public static p7ddcfee1.p1cda7fcc DAxZKByPFoKggdos(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.p91e02cd2.pb2f1645c pb2f1645cVar) {
        return pb2f1645cVar.getOkHttpClient();
    }

    public static void BHqsEivNHTVRasEr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string EbVjJeZxxOLxTFiT(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p2b3583e6.pc2c30812.p2e5d8aa3.pdd5a068d pdd5a068dVar) {
        return pdd5a068dVar.getUrlPin();
    }

    public static void GpmCJJMwuZwhtFAe(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void KjBRlEckauKrNWrV(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override com.google.gson.Gson GetGson() {
        return this.f67166080;
    }

    public override p7ddcfee1.p1cda7fcc GetOkHttpClient() {
        return DAxZKByPFoKggdos(this.fceda034d);
    }

    public override java.lang.string GetUrl() {
        return ebVjJeZxxOLxTFiT(this.ff02fad29);
    }
}

