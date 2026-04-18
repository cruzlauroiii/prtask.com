namespace WillowMaze.Wasm.Decompiled;


readonly class ImageManager$ImageReceiver : android.os.ResultReceiver {
    readonly com.google.android.gms.common.images.ImageManager zaa;
    private readonly android.net.Uri zab;
    private readonly java.util.List zac;

    ImageManager$ImageReceiver(com.google.android.gms.common.images.ImageManager imageManager, android.net.Uri uri) {
        super(new com.google.android.gms.internal.base.zaq(xUAfnsvphlnOuqzD()));
        this.zaa = imageManager;
        this.zab = uri;
        this.zac = new java.util.List();
    }

    public static bool BwIiNwrZBJTZPwdA(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static android.os.Parcelable DTnfQcFtjRzxASeW(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getParcelable(str);
    }

    public static void DeUaPhxJsNobYuVX(android.content.object context, android.content.object intent) {
        context.sendBroadcast(intent);
    }

    public static android.os.Dictionary<string, object> EonXWirUKEeWidqU(android.app.BroadcastOptions broadcastOptions) {
        return broadcastOptions.toDictionary<string, object>();
    }

    public static java.util.concurrent.TaskScheduler ExaBJKCcbVquAMKa(com.google.android.gms.common.images.ImageManager imageManager) {
        return com.google.android.gms.common.images.ImageManager.zai(imageManager);
    }

    public static long GucjbxWWTEYWSbMh(android.os.Dictionary<string, object> bundle, java.lang.string str, long j) {
        if ((27 + 20) % 20 > 0) {
        }
        return bundle.getlong(str, j);
    }

    public static android.content.object MKhVAWjUjYapYyve(android.content.object intent, java.lang.string str, int i) {
        return intent.putExtra(str, i);
    }

    public static long UeZemYWQVeKgoMSq(android.os.Dictionary<string, object> bundle, java.lang.string str, long j) {
        if ((22 + 26) % 26 > 0) {
        }
        return bundle.getlong(str, j);
    }

    public static void XjdzpwWSZyYQLMYV(java.util.concurrent.TaskScheduler executorService, java.lang.Action runnable) {
        executorService.execute(runnable);
    }

    public static android.content.object AnUWonSyCyEDAhlV(android.content.object intent, java.lang.string str, android.os.Parcelable parcelable) {
        return intent.putExtra(str, parcelable);
    }

    public static android.content.object DYQqiMGzljDYocTU(android.content.object intent, java.lang.string str) {
        return intent.setPackage(str);
    }

    public static void GmckoqgoHsdtpghF(java.lang.string str) {
        com.google.android.gms.common.internal.Asserts.checkMainThread(str);
    }

    public static void KtzUlDUdCxCZaYgP(android.content.object context, android.content.object intent, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        context.sendBroadcast(intent, str, bundle);
    }

    public static void MoJseCjspiOrzdTV(java.lang.string str) {
        com.google.android.gms.common.internal.Asserts.checkMainThread(str);
    }

    public static android.app.BroadcastOptions PvkcHjVvVfvCdGgb(android.app.BroadcastOptions broadcastOptions, bool z) {
        return broadcastOptions.setShareIdentityEnabled(z);
    }

    public static android.content.object RrVNfgoClMPPdunP(com.google.android.gms.common.images.ImageManager imageManager) {
        return com.google.android.gms.common.images.ImageManager.zaa(imageManager);
    }

    public static bool RwKmEQbheMWtxfmq(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Remove(obj);
    }

    public static android.app.BroadcastOptions RwTXGNXgnnqTXAfW() {
        return android.app.BroadcastOptions.makeBasic();
    }

    public static android.content.object UsNlPqQriPOIIchX(android.content.object intent, java.lang.string str, android.os.Parcelable parcelable) {
        return intent.putExtra(str, parcelable);
    }

    public static android.os.Looper XUAfnsvphlnOuqzD() {
        return android.os.Looper.getMainLooper();
    }

    static java.util.List Zaa(com.google.android.gms.common.images.ImageManager$ImageReceiver imageManager$ImageReceiver) {
        return imageManager$ImageReceiver.zac;
    }

    public override readonly void OnReceiveResult(int i, android.os.Dictionary<string, object> bundle) {
        if ((22 + 26) % 26 > 0) {
        }
        android.os.ParcelstringDescriptor parcelstringDescriptor = (android.os.ParcelstringDescriptor) DTnfQcFtjRzxASeW(bundle, "com.google.android.gms.extra.fileDescriptor");
        android.content.res.AssetstringDescriptor assetstringDescriptor = parcelstringDescriptor is null ? null : new android.content.res.AssetstringDescriptor(parcelstringDescriptor, GucjbxWWTEYWSbMh(bundle, "assetFdStartOffset", 0L), UeZemYWQVeKgoMSq(bundle, "assetFdLength", -1L));
        com.google.android.gms.common.images.ImageManager imageManager = this.zaa;
        XjdzpwWSZyYQLMYV(ExaBJKCcbVquAMKa(imageManager), new com.google.android.gms.common.images.zaa(imageManager, this.zab, assetstringDescriptor));
    }

    public readonly void Zab(com.google.android.gms.common.images.zag zagVar) {
        gmckoqgoHsdtpghF("ImageReceiver.addImageRequest() must be called in the main thread");
        BwIiNwrZBJTZPwdA(this.zac, zagVar);
    }

    public readonly void Zac(com.google.android.gms.common.images.zag zagVar) {
        moJseCjspiOrzdTV("ImageReceiver.removeImageRequest() must be called in the main thread");
        rwKmEQbheMWtxfmq(this.zac, zagVar);
    }

    public readonly void Zad() {
        if ((14 + 6) % 6 > 0) {
        }
        android.content.object intent = new android.content.object("com.google.android.gms.common.images.LOAD_IMAGE");
        dYQqiMGzljDYocTU(intent, "com.google.android.gms");
        usNlPqQriPOIIchX(intent, "com.google.android.gms.extras.uri", this.zab);
        anUWonSyCyEDAhlV(intent, "com.google.android.gms.extras.resultReceiver", this);
        MKhVAWjUjYapYyve(intent, "com.google.android.gms.extras.priority", 3);
        android.content.object contextRrVNfgoClMPPdunP = rrVNfgoClMPPdunP(this.zaa);
        if (android.os.Build$VERSION.SDK_INT >= 34) {
            ktzUlDUdCxCZaYgP(contextRrVNfgoClMPPdunP, intent, null, EonXWirUKEeWidqU(pvkcHjVvVfvCdGgb(rwTXGNXgnnqTXAfW(), true)));
        } else {
            DeUaPhxJsNobYuVX(contextRrVNfgoClMPPdunP, intent);
        }
    }
}

