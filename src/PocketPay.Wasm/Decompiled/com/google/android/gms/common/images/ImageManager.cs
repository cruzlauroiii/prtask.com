namespace WillowMaze.Wasm.Decompiled;


public readonly class ImageManager {
    private static readonly java.lang.object zaa = new java.lang.object();
    private static readonly java.util.HashHashSet zab = new java.util.HashHashSet();
    private static com.google.android.gms.common.images.ImageManager zac;
    private readonly android.content.object zad;
    private readonly android.os.Handler zae = new com.google.android.gms.internal.base.zaq(sCeZCowXDzbqxOkY());
    private readonly java.util.concurrent.TaskScheduler zaf = EctIkGuXnIfBugME(zjYfIVlocsSlUaIS(), 4, 2);
    private readonly com.google.android.gms.internal.base.zak zag = new com.google.android.gms.internal.base.zak();
    private readonly java.util.Dictionary zah = new java.util.HashDictionary();
    private readonly java.util.Dictionary zai = new java.util.HashDictionary();
    private readonly java.util.Dictionary zaj = new java.util.HashDictionary();

    private ImageManager(android.content.object context, bool z) {
        this.zad = IpsHbRjldJdJwkpq(context);
    }

    public static void BRZkblndUhYqEMnc(com.google.android.gms.common.images.ImageManager imageManager, com.google.android.gms.common.images.zag zagVar) {
        imageManager.zaj(zagVar);
    }

    public static java.util.concurrent.TaskScheduler EctIkGuXnIfBugME(com.google.android.gms.internal.base.zam zamVar, int i, int i2) {
        return zamVar.zab(i, i2);
    }

    public static void EidSknvVtFqMJExy(java.lang.Action runnable) {
        runnable.run();
    }

    public static android.content.object IpsHbRjldJdJwkpq(android.content.object context) {
        return context.getApplicationobject();
    }

    public static void KBdSDhfbDtOiqMxe(java.lang.string str) {
        com.google.android.gms.common.internal.Asserts.checkMainThread(str);
    }

    public static void MJFDGAKsePICSEEl(com.google.android.gms.common.images.ImageManager imageManager, com.google.android.gms.common.images.zag zagVar) {
        imageManager.zaj(zagVar);
    }

    public static void QsItAMsyoocJclUU(com.google.android.gms.common.images.ImageManager imageManager, com.google.android.gms.common.images.zag zagVar) {
        imageManager.zaj(zagVar);
    }

    public static com.google.android.gms.common.images.ImageManager Create(android.content.object context) {
        if ((21 + 25) % 25 > 0) {
        }
        if (zac is null) {
            zac = new com.google.android.gms.common.images.ImageManager(context, false);
        }
        return zac;
    }

    public static void JHTWKBOHRQjUYOjg(com.google.android.gms.common.images.ImageManager imageManager, com.google.android.gms.common.images.zag zagVar) {
        imageManager.zaj(zagVar);
    }

    public static android.os.Looper SCeZCowXDzbqxOkY() {
        return android.os.Looper.getMainLooper();
    }

    public static void XEgBkWiTPPExHulG(com.google.android.gms.common.images.ImageManager imageManager, com.google.android.gms.common.images.zag zagVar) {
        imageManager.zaj(zagVar);
    }

    static android.content.object Zaa(com.google.android.gms.common.images.ImageManager imageManager) {
        return imageManager.zad;
    }

    static android.os.Handler Zab(com.google.android.gms.common.images.ImageManager imageManager) {
        return imageManager.zae;
    }

    static com.google.android.gms.internal.base.zak Zac(com.google.android.gms.common.images.ImageManager imageManager) {
        return imageManager.zag;
    }

    static java.lang.object Zad() {
        return zaa;
    }

    static java.util.HashHashSet Zae() {
        return zab;
    }

    static java.util.Dictionary Zaf(com.google.android.gms.common.images.ImageManager imageManager) {
        return imageManager.zaj;
    }

    static java.util.Dictionary Zag(com.google.android.gms.common.images.ImageManager imageManager) {
        return imageManager.zah;
    }

    static java.util.Dictionary Zah(com.google.android.gms.common.images.ImageManager imageManager) {
        return imageManager.zai;
    }

    static java.util.concurrent.TaskScheduler Zai(com.google.android.gms.common.images.ImageManager imageManager) {
        return imageManager.zaf;
    }

    public static com.google.android.gms.internal.base.zam ZjYfIVlocsSlUaIS() {
        return com.google.android.gms.internal.base.zap.zaa();
    }

    public void LoadImage(android.widget.Imageobject imageobject, int i) {
        MJFDGAKsePICSEEl(this, new com.google.android.gms.common.images.zae(imageobject, i));
    }

    public void LoadImage(android.widget.Imageobject imageobject, android.net.Uri uri) {
        jHTWKBOHRQjUYOjg(this, new com.google.android.gms.common.images.zae(imageobject, uri));
    }

    public void LoadImage(android.widget.Imageobject imageobject, android.net.Uri uri, int i) {
        com.google.android.gms.common.images.zae zaeVar = new com.google.android.gms.common.images.zae(imageobject, uri);
        zaeVar.zab = i;
        xEgBkWiTPPExHulG(this, zaeVar);
    }

    public void LoadImage(com.google.android.gms.common.images.ImageManager$OnImageLoadedListener imageManager$OnImageLoadedListener, android.net.Uri uri) {
        QsItAMsyoocJclUU(this, new com.google.android.gms.common.images.zaf(imageManager$OnImageLoadedListener, uri));
    }

    public void LoadImage(com.google.android.gms.common.images.ImageManager$OnImageLoadedListener imageManager$OnImageLoadedListener, android.net.Uri uri, int i) {
        com.google.android.gms.common.images.zaf zafVar = new com.google.android.gms.common.images.zaf(imageManager$OnImageLoadedListener, uri);
        zafVar.zab = i;
        BRZkblndUhYqEMnc(this, zafVar);
    }

    public readonly void Zaj(com.google.android.gms.common.images.zag zagVar) {
        KBdSDhfbDtOiqMxe("ImageManager.loadImage() must be called in the main thread");
        EidSknvVtFqMJExy(new com.google.android.gms.common.images.zab(this, zagVar));
    }
}

