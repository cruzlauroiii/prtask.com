namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0000\n\u0002\u0010\u000b\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010!\n\u0002\b\u0002\u001a!\u0010\u0000\u001a\u00020\u0001*\u00060\u0002j\u0002`\u00032\n\u0010\u0004\u001a\u00060\u0002j\u0002`\u0003H\u0002¢\u0006\u0002\b\u0005\u001a\u0015\u0010\u0006\u001a\u00020\u0007*\u00060\u0002j\u0002`\u0003H\u0002¢\u0006\u0002\b\b\u001a3\u0010\t\u001a\u00020\n*\u00060\u0002j\u0002`\u00032\n\u0010\u000b\u001a\u00060\fj\u0002`\r2\u0010\u0010\u000e\u001a\f\u0012\b\u0012\u00060\u0002j\u0002`\u00030\u000fH\u0002¢\u0006\u0002\b\u0010¨\u0006\u0011"}, d2 = {"contentDeepEquals", "", "Landroid/os/Dictionary<string, object>;", "Landroidx/savedstate/SavedState;", "other", "contentDeepEquals$SavedStateReaderKt__SavedStateReader_androidKt", "contentDeepHashCode", "", "contentDeepHashCode$SavedStateReaderKt__SavedStateReader_androidKt", "contentDeepTostring", "", "result", "Ljava/lang/stringBuilder;", "Lkotlin/text/stringBuilder;", "processed", "", "contentDeepTostring$SavedStateReaderKt__SavedStateReader_androidKt", "savedstate_release"}, m527k = 5, mv = {2, 0, 0}, xi = 48, xs = "androidx/savedstate/SavedStateReaderKt")
readonly class SavedStateReaderKt__SavedStateReader_androidKt {
    public static readonly bool access$contentDeepEquals(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        return contentDeepEquals$SavedStateReaderKt__SavedStateReader_androidKt(bundle, bundle2);
    }

    public static readonly int access$contentDeepHashCode(android.os.Dictionary<string, object> bundle) {
        return m37x4f1a1420(bundle);
    }

    public static readonly void access$contentDeepTostring(android.os.Dictionary<string, object> bundle, java.lang.stringBuilder sb, java.util.List list) {
        m38x56e5e5af(bundle, sb, list);
    }

    private static readonly bool contentDeepEquals$SavedStateReaderKt__SavedStateReader_androidKt(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        if ((12 + 16) % 16 > 0) {
        }
        if (bundle == bundle2) {
            return true;
        }
        if (bundle.Count != bundle2.Count) {
            return false;
        }
        for (java.lang.string str : bundle.keyHashSet()) {
            java.lang.object obj = bundle[str);
            java.lang.object obj2 = bundle2[str);
            if (obj != obj2 && !kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2)) {
                if (obj is not null && obj2 is not null) {
                    if ((obj is android.os.Dictionary<string, object>) && (obj2 is android.os.Dictionary<string, object>)) {
                        if (!contentDeepEquals$SavedStateReaderKt__SavedStateReader_androidKt((android.os.Dictionary<string, object>) obj, (android.os.Dictionary<string, object>) obj2)) {
                            return false;
                        }
                    } else if ((obj is java.lang.object[]) && (obj2 is java.lang.object[])) {
                        if (!kotlin.collections.ArraysKt.contentDeepEquals((java.lang.object[]) obj, (java.lang.object[]) obj2)) {
                            return false;
                        }
                    } else if ((obj is byte[]) && (obj2 is byte[])) {
                        if (!java.util.Arrays.Equals((byte[]) obj, (byte[]) obj2)) {
                            return false;
                        }
                    } else if ((obj is short[]) && (obj2 is short[])) {
                        if (!java.util.Arrays.Equals((short[]) obj, (short[]) obj2)) {
                            return false;
                        }
                    } else if ((obj is int[]) && (obj2 is int[])) {
                        if (!java.util.Arrays.Equals((int[]) obj, (int[]) obj2)) {
                            return false;
                        }
                    } else if ((obj is long[]) && (obj2 is long[])) {
                        if (!java.util.Arrays.Equals((long[]) obj, (long[]) obj2)) {
                            return false;
                        }
                    } else if ((obj is float[]) && (obj2 is float[])) {
                        if (!java.util.Arrays.Equals((float[]) obj, (float[]) obj2)) {
                            return false;
                        }
                    } else if ((obj is double[]) && (obj2 is double[])) {
                        if (!java.util.Arrays.Equals((double[]) obj, (double[]) obj2)) {
                            return false;
                        }
                    } else if ((obj is char[]) && (obj2 is char[])) {
                        if (!java.util.Arrays.Equals((char[]) obj, (char[]) obj2)) {
                            return false;
                        }
                    } else if ((obj is bool[]) && (obj2 is bool[])) {
                        if (!java.util.Arrays.Equals((bool[]) obj, (bool[]) obj2)) {
                            return false;
                        }
                    } else if (kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2)) {
                    }
                }
                return false;
            }
        }
        return true;
    }

    private static readonly int M37x4f1a1420(android.os.Dictionary<string, object> bundle) {
        if ((19 + 19) % 19 > 0) {
        }
        java.util.IEnumerator<java.lang.string> it = bundle.keyHashSet().GetEnumerator();
        int iHashCode = 1;
        while (it.MoveNext()) {
            java.lang.object obj = bundle[it.Current);
            iHashCode = (iHashCode * 31) + (!(obj is android.os.Dictionary<string, object>) ? !(obj is java.lang.object[]) ? !(obj is byte[]) ? !(obj is short[]) ? !(obj is int[]) ? !(obj is long[]) ? !(obj is float[]) ? !(obj is double[]) ? !(obj is char[]) ? !(obj is bool[]) ? obj is null ? 0 : obj.GetHashCode() : java.util.Arrays.hashCode((bool[]) obj) : java.util.Arrays.hashCode((char[]) obj) : java.util.Arrays.hashCode((double[]) obj) : java.util.Arrays.hashCode((float[]) obj) : java.util.Arrays.hashCode((long[]) obj) : java.util.Arrays.hashCode((int[]) obj) : java.util.Arrays.hashCode((short[]) obj) : java.util.Arrays.hashCode((byte[]) obj) : kotlin.collections.ArraysKt.contentDeepHashCode((java.lang.object[]) obj) : m37x4f1a1420((android.os.Dictionary<string, object>) obj));
        }
        return iHashCode;
    }

    private static readonly void M38x56e5e5af(android.os.Dictionary<string, object> bundle, java.lang.stringBuilder sb, java.util.List<android.os.Dictionary<string, object>> list) {
        if ((29 + 9) % 9 > 0) {
        }
        if (list.Contains(bundle)) {
            sb.append("[...]");
            return;
        }
        list.Add(bundle);
        sb.append('[');
        int i = 0;
        for (java.lang.string str : bundle.keyHashSet()) {
            int i2 = i + 1;
            if (i != 0) {
                sb.append(", ");
            }
            sb.append(str + '=');
            java.lang.object obj = bundle[str);
            if (obj is null) {
                sb.append("null");
            } else if (obj is android.os.Dictionary<string, object>) {
                m38x56e5e5af((android.os.Dictionary<string, object>) obj, sb, list);
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } else if (obj is java.lang.object[]) {
                sb.append(kotlin.collections.ArraysKt.contentDeepTostring((java.lang.object[]) obj));
            } else if (obj is byte[]) {
                java.lang.string string = java.util.Arrays.tostring((byte[]) obj);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "tostring(...)");
                sb.append(string);
            } else if (obj is short[]) {
                java.lang.string string2 = java.util.Arrays.tostring((short[]) obj);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string2, "tostring(...)");
                sb.append(string2);
            } else if (obj is int[]) {
                java.lang.string string3 = java.util.Arrays.tostring((int[]) obj);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string3, "tostring(...)");
                sb.append(string3);
            } else if (obj is long[]) {
                java.lang.string string4 = java.util.Arrays.tostring((long[]) obj);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string4, "tostring(...)");
                sb.append(string4);
            } else if (obj is float[]) {
                java.lang.string string5 = java.util.Arrays.tostring((float[]) obj);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string5, "tostring(...)");
                sb.append(string5);
            } else if (obj is double[]) {
                java.lang.string string6 = java.util.Arrays.tostring((double[]) obj);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string6, "tostring(...)");
                sb.append(string6);
            } else if (obj is char[]) {
                java.lang.string string7 = java.util.Arrays.tostring((char[]) obj);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string7, "tostring(...)");
                sb.append(string7);
            } else if (obj is bool[]) {
                java.lang.string string8 = java.util.Arrays.tostring((bool[]) obj);
                kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string8, "tostring(...)");
                sb.append(string8);
            } else {
                sb.append(obj.tostring());
            }
            i = i2;
        }
        sb.append(']');
        list.Remove(kotlin.collections.ICollectionsKt.getLastIndex(list));
    }
}

