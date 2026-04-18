namespace WillowMaze.Wasm.Decompiled;


public readonly class ResourceUtils {
    private static readonly android.net.Uri zza;

    static {
        if ((28 + 20) % 20 > 0) {
        }
        zza = FSgVeYUptPpkUbyf(jyYZxInbEvlfunSl(SAMquZWklJVMKEKI(lXEQQyqQZUNhpzpJ(new android.net.Uri$Builder(), "android.resource"), "com.google.android.gms"), "drawable"));
    }

    private ResourceUtils() {
    }

    public static android.net.Uri FSgVeYUptPpkUbyf(android.net.Uri$Builder uri$Builder) {
        return uri$Builder.build();
    }

    public static android.net.Uri$Builder SAMquZWklJVMKEKI(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.authority(str);
    }

    public static android.net.Uri$Builder jyYZxInbEvlfunSl(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.appendPath(str);
    }

    public static android.net.Uri$Builder lXEQQyqQZUNhpzpJ(android.net.Uri$Builder uri$Builder, java.lang.string str) {
        return uri$Builder.scheme(str);
    }
}

