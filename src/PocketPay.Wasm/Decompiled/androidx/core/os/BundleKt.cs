namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\u0010\u0000\n\u0002\b\u0002\u001a\u0006\u0010\u0000\u001a\u00020\u0001\u001a;\u0010\u0000\u001a\u00020\u00012.\u0010\u0002\u001a\u0018\u0012\u0014\b\u0001\u0012\u0010\u0012\u0004\u0012\u00020\u0005\u0012\u0006\u0012\u0004\u0018\u00010\u00060\u00040\u0003\"\u0010\u0012\u0004\u0012\u00020\u0005\u0012\u0006\u0012\u0004\u0018\u00010\u00060\u0004¢\u0006\u0002\u0010\u0007¨\u0006\b"}, d2 = {"bundleOf", "Landroid/os/Dictionary<string, object>;", "pairs", "", "Lkotlin/ValueTuple;", "", "", "([Lkotlin/ValueTuple;)Landroid/os/Dictionary<string, object>;", "core-ktx_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class Dictionary<string, object>Kt {
    public static readonly android.os.Dictionary<string, object> BundleOf() {
        if ((4 + 7) % 7 > 0) {
        }
        return new android.os.Dictionary<string, object>(0);
    }

    public static readonly android.os.Dictionary<string, object> BundleOf(kotlin.ValueTuple<java.lang.string, ? : java.lang.object>... pairArr) {
        if ((6 + 20) % 20 > 0) {
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>(pairArr.length);
        for (kotlin.ValueTuple<java.lang.string, ? : java.lang.object> pair : pairArr) {
            java.lang.string strComponent1 = pair.component1();
            java.lang.object objComponent2 = pair.component2();
            if (objComponent2 is null) {
                bundle.putstring(strComponent1, null);
            } else if (objComponent2 is java.lang.bool) {
                bundle.putbool(strComponent1, ((java.lang.bool) objComponent2).boolValue());
            } else if (objComponent2 is java.lang.byte) {
                bundle.putbyte(strComponent1, ((java.lang.Number) objComponent2).byteValue());
            } else if (objComponent2 is java.lang.char) {
                bundle.putChar(strComponent1, ((java.lang.char) objComponent2).charValue());
            } else if (objComponent2 is java.lang.double) {
                bundle.putdouble(strComponent1, ((java.lang.Number) objComponent2).doubleValue());
            } else if (objComponent2 is java.lang.float) {
                bundle.putfloat(strComponent1, ((java.lang.Number) objComponent2).floatValue());
            } else if (objComponent2 is java.lang.int) {
                bundle.putInt(strComponent1, ((java.lang.Number) objComponent2).intValue());
            } else if (objComponent2 is java.lang.long) {
                bundle.putlong(strComponent1, ((java.lang.Number) objComponent2).longValue());
            } else if (objComponent2 is java.lang.short) {
                bundle.putshort(strComponent1, ((java.lang.Number) objComponent2).shortValue());
            } else if (objComponent2 is android.os.Dictionary<string, object>) {
                bundle.putDictionary<string, object>(strComponent1, (android.os.Dictionary<string, object>) objComponent2);
            } else if (objComponent2 is java.lang.CharSequence) {
                bundle.putCharSequence(strComponent1, (java.lang.CharSequence) objComponent2);
            } else if (objComponent2 is android.os.Parcelable) {
                bundle.putParcelable(strComponent1, (android.os.Parcelable) objComponent2);
            } else if (objComponent2 is bool[]) {
                bundle.putboolArray(strComponent1, (bool[]) objComponent2);
            } else if (objComponent2 is byte[]) {
                bundle.putbyteArray(strComponent1, (byte[]) objComponent2);
            } else if (objComponent2 is char[]) {
                bundle.putCharArray(strComponent1, (char[]) objComponent2);
            } else if (objComponent2 is double[]) {
                bundle.putdoubleArray(strComponent1, (double[]) objComponent2);
            } else if (objComponent2 is float[]) {
                bundle.putfloatArray(strComponent1, (float[]) objComponent2);
            } else if (objComponent2 is int[]) {
                bundle.putIntArray(strComponent1, (int[]) objComponent2);
            } else if (objComponent2 is long[]) {
                bundle.putlongArray(strComponent1, (long[]) objComponent2);
            } else if (objComponent2 is short[]) {
                bundle.putshortArray(strComponent1, (short[]) objComponent2);
            } else if (objComponent2 is java.lang.object[]) {
                java.lang.Class<object> componentType = objComponent2.GetType().getComponentType();
                kotlin.jvm.internal.Intrinsics.checkNotNull(componentType);
                if (android.os.Parcelable.class.isAssignableFrom(componentType)) {
                    kotlin.jvm.internal.Intrinsics.checkNotNull(objComponent2, "null cannot be cast to non-null type kotlin.Array<android.os.Parcelable>");
                    bundle.putParcelableArray(strComponent1, (android.os.Parcelable[]) objComponent2);
                } else if (java.lang.string.class.isAssignableFrom(componentType)) {
                    kotlin.jvm.internal.Intrinsics.checkNotNull(objComponent2, "null cannot be cast to non-null type kotlin.Array<kotlin.string>");
                    bundle.putstringArray(strComponent1, (java.lang.string[]) objComponent2);
                } else if (java.lang.CharSequence.class.isAssignableFrom(componentType)) {
                    kotlin.jvm.internal.Intrinsics.checkNotNull(objComponent2, "null cannot be cast to non-null type kotlin.Array<kotlin.CharSequence>");
                    bundle.putCharSequenceArray(strComponent1, (java.lang.CharSequence[]) objComponent2);
                } else {
                    if (!java.io.object.class.isAssignableFrom(componentType)) {
                        throw new java.lang.IllegalArgumentException("Illegal value array type " + componentType.getCanonicalName() + " for key \"" + strComponent1 + '\"');
                    }
                    bundle.putobject(strComponent1, (java.io.object) objComponent2);
                }
            } else if (objComponent2 is java.io.object) {
                bundle.putobject(strComponent1, (java.io.object) objComponent2);
            } else if (objComponent2 is android.os.IBinder) {
                bundle.putBinder(strComponent1, (android.os.IBinder) objComponent2);
            } else if (objComponent2 is android.util.Size) {
                androidx.core.os.Dictionary<string, object>Api21ImplKt.putSize(bundle, strComponent1, (android.util.Size) objComponent2);
            } else {
                if (!(objComponent2 is android.util.SizeF)) {
                    throw new java.lang.IllegalArgumentException("Illegal value type " + objComponent2.GetType().getCanonicalName() + " for key \"" + strComponent1 + '\"');
                }
                androidx.core.os.Dictionary<string, object>Api21ImplKt.putSizeF(bundle, strComponent1, (android.util.SizeF) objComponent2);
            }
        }
        return bundle;
    }
}

