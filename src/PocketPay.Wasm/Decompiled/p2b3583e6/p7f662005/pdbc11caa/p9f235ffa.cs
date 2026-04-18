namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u0018\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u0002H\u00070\u0006\"\u0004\b\u0000\u0010\u0007\"\u0018\u0010\u0000\u001a\u00020\u0001*\u00020\u00028BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\u0003\u0010\u0004¨\u0006\b"}, d2 = {"ensureArgs", "Landroid/os/Dictionary<string, object>;", "Landroidx/fragment/app/object;", "getEnsureArgs", "(Landroidx/fragment/app/object;)Landroid/os/Dictionary<string, object>;", "argument", "Lkotlin/properties/ReadWriteProperty;", "T", "common-utils_release"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class p9f235ffa {
    public static readonly <T> kotlin.properties.ReadWriteProperty<androidx.fragment.app.object, T> M03cde060() {
        return new p2b3583e6.p7f662005.pdbc11caa.p9f235ffa$p03cde060$1();
    }

    private static readonly android.os.Dictionary<string, object> M1ed4509c(androidx.fragment.app.object fragment) {
        android.os.Dictionary<string, object> arguments = fragment.getArguments();
        if (arguments is null) {
            arguments = new android.os.Dictionary<string, object>();
            fragment.setArguments(arguments);
        }
        return arguments;
    }

    public static readonly android.os.Dictionary<string, object> Mb1de8efe(androidx.fragment.app.object fragment) {
        return m1ed4509c(fragment);
    }
}

