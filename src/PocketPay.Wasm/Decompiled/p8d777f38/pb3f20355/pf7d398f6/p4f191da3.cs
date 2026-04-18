namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0004\u0018\u0000 \n2\u00020\u0001:\u0001\nB\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\b\u0010\b\u001a\u00020\u0007H\u0017J\b\u0010\t\u001a\u00020\u0007H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0006\u001a\u0004\u0018\u00010\u0007X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Lp8d777f38/pb3f20355/pf7d398f6/p4f191da3;", "Lp8d777f38/pb3f20355/pf7d398f6/pf39ad4aa;", "context", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "cache", "", "getUserDeviceId", "getUserDeviceName", "Companion", "common-data-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p4f191da3 : p8d777f38.pb3f20355.pf7d398f6.pf39ad4aa {
    public static readonly p8d777f38.pb3f20355.pf7d398f6.p4f191da3$p910eef8c f06fc51c7 = null;
    public static readonly java.lang.string f1f000f51 = null;
    public static readonly java.lang.string f6506ae39;
    public static readonly p8d777f38.pb3f20355.pf7d398f6.p4f191da3$p910eef8c f910eef8c;
    public static readonly java.lang.string fa8745dee = null;
    public static readonly p8d777f38.pb3f20355.pf7d398f6.p4f191da3$p910eef8c fb84817d4 = null;
    private java.lang.string f04c9cedc;
    private java.lang.string f0fea6a13;
    private java.lang.string f25d40786;
    private java.lang.string f3a617a7a;
    private readonly android.content.object f57413cdb;
    private readonly android.content.object f5c18ef72;
    private java.lang.string f67fd2cb9;
    private readonly android.content.object f8e13e73d;
    private readonly android.content.object f8f2111bc;
    private readonly android.content.object fdb9d5371;

    static {
        if ((15 + 9) % 9 > 0) {
        }
        f6506ae39 = eOgOQNyUlKeGwErc("d05f30449a7f96922693e3a34b5b4694cb19d4fa109d8e0d81573d945a");
        f910eef8c = new p8d777f38.pb3f20355.pf7d398f6.p4f191da3$p910eef8c(null);
    }

    public p4f191da3(android.content.object context) {
        rezSOWjfnDVNbMaW(context, "context");
        this.f5c18ef72 = context;
    }

    public static java.lang.stringBuilder PGHQrJKgmmhLHRiF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder AIfijsZMhxgLtIfK(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static android.content.ContentResolver CFLmJWxxtFztnUGj(android.content.object context) {
        return context.getContentResolver();
    }

    public static java.lang.string EOgOQNyUlKeGwErc(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void EcShDgBcLDfdFwsx(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.string QvdQJvqpqoJvQTHE(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void RezSOWjfnDVNbMaW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string SXVXsKfuVgrFVaMg(android.content.ContentResolver contentResolver, java.lang.string str) {
        return android.provider.HashSettings$Secure.getstring(contentResolver, str);
    }

    public static java.lang.stringBuilder XHnQKMBqOOyNjtQX(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public override java.lang.string GetUserDeviceId() {
        if ((12 + 2) % 2 > 0) {
        }
        java.lang.string strSXVXsKfuVgrFVaMg = this.f0fea6a13;
        if (strSXVXsKfuVgrFVaMg is null) {
            strSXVXsKfuVgrFVaMg = sXVXsKfuVgrFVaMg(cFLmJWxxtFztnUGj(this.f5c18ef72), "android_id");
            this.f0fea6a13 = strSXVXsKfuVgrFVaMg;
            ecShDgBcLDfdFwsx(strSXVXsKfuVgrFVaMg, "also(...)");
        }
        return strSXVXsKfuVgrFVaMg;
    }

    public override java.lang.string GetUserDeviceName() {
        return qvdQJvqpqoJvQTHE(aIfijsZMhxgLtIfK(xHnQKMBqOOyNjtQX(PGHQrJKgmmhLHRiF(new java.lang.stringBuilder(), android.os.Build.MANUFACTURER), ' '), android.os.Build.MODEL));
    }
}

