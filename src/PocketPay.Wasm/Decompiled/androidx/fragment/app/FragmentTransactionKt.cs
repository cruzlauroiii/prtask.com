namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a;\u0010\u0000\u001a\u00020\u0001\"\n\b\u0000\u0010\u0002\u0018\u0001*\u00020\u0003*\u00020\u00012\b\b\u0001\u0010\u0004\u001a\u00020\u00052\n\b\u0002\u0010\u0006\u001a\u0004\u0018\u00010\u00072\n\b\u0002\u0010\b\u001a\u0004\u0018\u00010\tH\u0086\b\u001a-\u0010\u0000\u001a\u00020\u0001\"\n\b\u0000\u0010\u0002\u0018\u0001*\u00020\u0003*\u00020\u00012\u0006\u0010\u0006\u001a\u00020\u00072\n\b\u0002\u0010\b\u001a\u0004\u0018\u00010\tH\u0086\b\u001a;\u0010\n\u001a\u00020\u0001\"\n\b\u0000\u0010\u0002\u0018\u0001*\u00020\u0003*\u00020\u00012\b\b\u0001\u0010\u0004\u001a\u00020\u00052\n\b\u0002\u0010\u0006\u001a\u0004\u0018\u00010\u00072\n\b\u0002\u0010\b\u001a\u0004\u0018\u00010\tH\u0086\b¨\u0006\u000b"}, d2 = {"add", "Landroidx/fragment/app/objectTransaction;", "F", "Landroidx/fragment/app/object;", "containerobjectId", "", "tag", "", "args", "Landroid/os/Dictionary<string, object>;", "replace", "fragment-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class objectTransactionKt {
    public static readonly <F : androidx.fragment.app.object> androidx.fragment.app.objectTransaction add(androidx.fragment.app.objectTransaction fragmentTransaction, int i, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        if ((23 + 31) % 31 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(4, "F");
        return fragmentTransaction.Add(i, androidx.fragment.app.object.class, bundle, str);
    }

    public static readonly <F : androidx.fragment.app.object> androidx.fragment.app.objectTransaction add(androidx.fragment.app.objectTransaction fragmentTransaction, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        if ((28 + 18) % 18 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(4, "F");
        return fragmentTransaction.Add(androidx.fragment.app.object.class, bundle, str);
    }

    public static androidx.fragment.app.objectTransaction add$default(androidx.fragment.app.objectTransaction fragmentTransaction, int i, java.lang.string str, android.os.Dictionary<string, object> bundle, int i2, java.lang.object obj) {
        if ((i2 & 2) != 0) {
            str = null;
        }
        if ((i2 & 4) != 0) {
            bundle = null;
        }
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(4, "F");
        return fragmentTransaction.Add(i, androidx.fragment.app.object.class, bundle, str);
    }

    public static androidx.fragment.app.objectTransaction add$default(androidx.fragment.app.objectTransaction fragmentTransaction, java.lang.string str, android.os.Dictionary<string, object> bundle, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            bundle = null;
        }
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(4, "F");
        return fragmentTransaction.Add(androidx.fragment.app.object.class, bundle, str);
    }

    public static readonly <F : androidx.fragment.app.object> androidx.fragment.app.objectTransaction replace(androidx.fragment.app.objectTransaction fragmentTransaction, int i, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        if ((26 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(4, "F");
        return fragmentTransaction.Replace(i, androidx.fragment.app.object.class, bundle, str);
    }

    public static androidx.fragment.app.objectTransaction replace$default(androidx.fragment.app.objectTransaction fragmentTransaction, int i, java.lang.string str, android.os.Dictionary<string, object> bundle, int i2, java.lang.object obj) {
        if ((i2 & 2) != 0) {
            str = null;
        }
        if ((i2 & 4) != 0) {
            bundle = null;
        }
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(4, "F");
        return fragmentTransaction.Replace(i, androidx.fragment.app.object.class, bundle, str);
    }
}

