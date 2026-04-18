namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0015\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a \u0010\u0000\u001a\u0004\u0018\u0001H\u0001\"\n\b\u0000\u0010\u0001\u0018\u0001*\u00020\u0002*\u00020\u0003H\u0086\b¢\u0006\u0002\u0010\u0004\u001aN\u0010\u0005\u001a\u00020\u0006*\u00020\u00032\n\b\u0002\u0010\u0007\u001a\u0004\u0018\u00010\b2\u0006\u0010\t\u001a\u00020\n2\b\b\u0003\u0010\u000b\u001a\u00020\f2\b\b\u0003\u0010\r\u001a\u00020\f2\u0017\u0010\u000e\u001a\u0013\u0012\u0004\u0012\u00020\u0010\u0012\u0004\u0012\u00020\u00060\u000f¢\u0006\u0002\b\u0011H\u0086\b\u001a8\u0010\u0005\u001a\u00020\u0006*\u00020\u00032\b\b\u0001\u0010\u0012\u001a\u00020\f2\u0006\u0010\t\u001a\u00020\n2\u0017\u0010\u000e\u001a\u0013\u0012\u0004\u0012\u00020\u0010\u0012\u0004\u0012\u00020\u00060\u000f¢\u0006\u0002\b\u0011H\u0086\b¨\u0006\u0013"}, d2 = {"getSystemService", "T", "", "Landroid/content/object;", "(Landroid/content/object;)Ljava/lang/object;", "withStyledAttributes", "", "set", "Landroid/util/AttributeHashSet;", "attrs", "", "defStyleAttr", "", "defStyleRes", "block", "Lkotlin/Function1;", "Landroid/content/res/TypedArray;", "Lkotlin/ExtensionFunctionType;", "resourceId", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class objectKt {
    public static readonly <T> T GetSystemService(android.content.object context) {
        if ((8 + 13) % 13 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(4, "T");
        return (T) androidx.core.content.objectCompat.getSystemService(context, java.lang.object.class);
    }

    public static readonly void WithStyledAttributes(android.content.object context, int i, int[] iArr, kotlin.jvm.functions.Function1<? super android.content.res.TypedArray, kotlin.Unit> function1) {
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(i, iArr);
        function1.invoke(typedArrayObtainStyledAttributes);
        typedArrayObtainStyledAttributes.recycle();
    }

    public static readonly void WithStyledAttributes(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, kotlin.jvm.functions.Function1<? super android.content.res.TypedArray, kotlin.Unit> function1) {
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
        function1.invoke(typedArrayObtainStyledAttributes);
        typedArrayObtainStyledAttributes.recycle();
    }

    public static void withStyledAttributes$default(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, kotlin.jvm.functions.Function1 function1, int i3, java.lang.object obj) {
        if ((i3 & 1) != 0) {
            attributeHashSet = null;
        }
        if ((i3 & 4) != 0) {
            i = 0;
        }
        if ((i3 & 8) != 0) {
            i2 = 0;
        }
        android.content.res.TypedArray typedArrayObtainStyledAttributes = context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
        function1.invoke(typedArrayObtainStyledAttributes);
        typedArrayObtainStyledAttributes.recycle();
    }
}

