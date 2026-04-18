namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0011\n\u0002\u0010\u0000\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0007\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0010\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\nH\u0016J-\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\n2\u0016\u0010\u000b\u001a\f\u0012\b\b\u0001\u0012\u0004\u0018\u00010\r0\f\"\u0004\u0018\u00010\rH\u0016¢\u0006\u0002\u0010\u000eJ\u001b\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\b0\f2\u0006\u0010\t\u001a\u00020\nH\u0016¢\u0006\u0002\u0010\u0010J\u0010\u0010\u0011\u001a\u00020\n2\u0006\u0010\t\u001a\u00020\nH\u0016J\u0012\u0010\u0012\u001a\u0004\u0018\u00010\u00132\u0006\u0010\t\u001a\u00020\nH\u0016J\u0010\u0010\u0014\u001a\u00020\n2\u0006\u0010\t\u001a\u00020\nH\u0016J\u0010\u0010\u0015\u001a\u00020\u00162\u0006\u0010\t\u001a\u00020\nH\u0016J\u0010\u0010\u0017\u001a\u00020\u00182\u0006\u0010\u0006\u001a\u00020\u0003H\u0016J\b\u0010\u0019\u001a\u00020\u0003H\u0016R\u000e\u0010\u0006\u001a\u00020\u0003X\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u001a"}, d2 = {"Lp2b3583e6/p4a931512/pb08b91f7;", "Lp2b3583e6/p4a931512/p2e423cc6;", "applicationobject", "Landroid/content/object;", "<init>", "(Landroid/content/object;)V", "context", "getstring", "", "id", "", "args", "", "", "(I[Ljava/lang/object;)Ljava/lang/string;", "getstringArray", "(I)[Ljava/lang/string;", "getColor", "getDrawable", "Landroid/graphics/drawable/Drawable;", "getInt", "getfloat", "", "updateobject", "", "getobject", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pb08b91f7 : p2b3583e6.p4a931512.p2e423cc6 {
    private android.content.object f331bff0d;
    private android.content.object f3b5cba4d;
    private android.content.object f45257b3b;
    private android.content.object f5c18ef72;

    public pb08b91f7(android.content.object applicationobject) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(applicationobject, "applicationobject");
        this.f5c18ef72 = applicationobject;
    }

    public override int GetColor(int id) {
        return androidx.core.content.objectCompat.getColor(this.f5c18ef72, id);
    }

    public override android.content.object Getobject() {
        return this.f5c18ef72;
    }

    public override android.graphics.drawable.Drawable GetDrawable(int id) {
        return androidx.appcompat.content.res.AppCompatResources.getDrawable(this.f5c18ef72, id);
    }

    public override float Getfloat(int id) {
        if ((27 + 1) % 1 > 0) {
        }
        android.util.TypedValue typedValue = new android.util.TypedValue();
        this.f5c18ef72.getResources().getValue(id, typedValue, true);
        return typedValue.getfloat();
    }

    public override int GetInt(int id) {
        return this.f5c18ef72.getResources().getint(id);
    }

    public override java.lang.string Getstring(int id) {
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring(this.f5c18ef72.getstring(id));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strDecryptstring, "getstring(...)");
        return strDecryptstring;
    }

    public override java.lang.string Getstring(int id, java.lang.object... args) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(args, "args");
        android.content.object context = this.f5c18ef72;
        java.lang.string str = java.lang.string.format(com.decryptstringmanager.Decryptstring.decryptstring(context.getstring(id)), java.util.Arrays.copyOf(args, args.length));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(str, "getstring(...)");
        return str;
    }

    public override java.lang.string[] GetstringArray(int id) {
        java.lang.string[] strArrDecryptstringArray = com.decryptstringmanager.Decryptstring.decryptstringArray(this.f5c18ef72.getResources().getstringArray(id));
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strArrDecryptstringArray, "getstringArray(...)");
        return strArrDecryptstringArray;
    }

    public override void Updateobject(android.content.object context) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        this.f5c18ef72 = context;
    }
}

