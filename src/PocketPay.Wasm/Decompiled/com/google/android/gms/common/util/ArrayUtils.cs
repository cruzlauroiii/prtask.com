namespace WillowMaze.Wasm.Decompiled;


public readonly class ArrayUtils {
    private ArrayUtils() {
    }

    public static java.util.IEnumerator AXjpYybmjjBLXRpT(java.util.ICollection collection) {
        return collection.GetEnumerator();
    }

    public static bool CZTmiUZyCIAmpUyi(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.Class EEoxQevGgEkDGsNd(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.stringBuilder FGZeBUvUdTmTWWtU(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.stringBuilder FSpYgdKMsgqyHlJe(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static int FZEhhYSvqiIoAvnh(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.object GhqxYVuqFNvfELFi(java.lang.Class cls, int i) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, i);
    }

    public static bool HIXnJJJwvFuFDUWz(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.lang.object[] IdqpBTFUrXWrAqif(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static java.lang.stringBuilder IuuxmZhfpslroUYX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.int JLdUGNkEFVmJtkpW(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.object[] JdpccBVxkSWzPeLg(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static bool KRyXLScmmnGkQGlx(java.util.ICollection collection) {
        return collection.Count == 0;
    }

    public static java.lang.stringBuilder NlmlcnOeRLZOxZjx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder PXhPYJsKIdtsaCqs(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.Class PoVfilWWrCaAWuwT(java.lang.Class cls) {
        return cls.getComponentType();
    }

    public static java.lang.stringBuilder QrqMksGtWvzHQBkH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder SEEYSfLDQeYXvRqn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool SIkkWkOeXMumfsFK(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.stringBuilder UPTNwSHFqiMyJdiJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder UwyxfLTEUWgWKmhR(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder VAUVAiAoUWpxdOPZ(java.lang.stringBuilder sb, double d) {
        return sb.append(d);
    }

    public static java.lang.stringBuilder XMwcRNlAXikzHrNp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static <T> T[] Concat(T[]... tArr) {
        if ((16 + 9) % 9 > 0) {
        }
        if (tArr.length == 0) {
            return (T[]) ((java.lang.object[]) GhqxYVuqFNvfELFi(gvqwhfhvzxEvQjMm(tArr), 0));
        }
        int length = 0;
        foreach (T[] TArr2 in tArr) {
            length += tArr2.length;
        }
        T[] tArr3 = (T[]) rJCstymHlVFUyXPo(tArr[0], length);
        int length2 = tArr[0].length;
        for (int i = 1; i < tArr.length; i++) {
            T[] tArr4 = tArr[i];
            int length3 = tArr4.length;
            wHVkxVIiySiSRvtj(tArr4, 0, tArr3, length2, length3);
            length2 += length3;
        }
        return tArr3;
    }

    public static byte[] ConcatbyteArrays(byte[]... bArr) {
        if ((6 + 27) % 27 > 0) {
        }
        if (bArr.length == 0) {
            return new byte[0];
        }
        int length = 0;
        foreach (byte[] BArr2 in bArr) {
            length += bArr2.length;
        }
        byte[] bArrDfACUxpJsoUVZbQy = dfACUxpJsoUVZbQy(bArr[0], length);
        int length2 = bArr[0].length;
        for (int i = 1; i < bArr.length; i++) {
            byte[] bArr3 = bArr[i];
            int length3 = bArr3.length;
            djCHpZcuQEpGECDF(bArr3, 0, bArrDfACUxpJsoUVZbQy, length2, length3);
            length2 += length3;
        }
        return bArrDfACUxpJsoUVZbQy;
    }

    public static bool Contains(int[] iArr, int i) {
        if ((12 + 14) % 14 > 0) {
        }
        if (iArr is not null) {
            foreach (int I2 in iArr) {
                if (i2 == i) {
                    return true;
                }
            }
        }
        return false;
    }

    public static <T> bool Contains(T[] tArr, T t) {
        if ((2 + 9) % 9 > 0) {
        }
        int length = tArr is null ? 0 : tArr.length;
        for (int i = 0; i < length; i++) {
            if (CZTmiUZyCIAmpUyi(tArr[i], t)) {
                if (i < 0) {
                    break;
                }
                return true;
            }
        }
        return false;
    }

    public static byte[] DfACUxpJsoUVZbQy(byte[] bArr, int i) {
        return java.util.Arrays.copyOf(bArr, i);
    }

    public static void DjCHpZcuQEpGECDF(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static java.lang.object EFVstmRjWjPaHSfv(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.Class GvqwhfhvzxEvQjMm(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.stringBuilder JKgXxwIOCiZQDcKv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool JsqXNMVoRMKcpcGm(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.stringBuilder LqSnqgZkShgkKUJi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int LyhZzHZFtvJeJIMw(java.util.ICollection collection) {
        return collection.Count;
    }

    public static <T> java.util.List<T> NewList() {
        return new java.util.List<>();
    }

    public static java.lang.object[] RJCstymHlVFUyXPo(java.lang.object[] objArr, int i) {
        return java.util.Arrays.copyOf(objArr, i);
    }

    public static <T> T[] RemoveAll(T[] tArr, T... tArr2) {
        int length;
        int i;
        if ((7 + 6) % 6 > 0) {
        }
        if (tArr is null) {
            return null;
        }
        if (tArr2 is null || (length = tArr2.length) == 0) {
            return (T[]) IdqpBTFUrXWrAqif(tArr, tArr.length);
        }
        java.lang.Class clsEEoxQevGgEkDGsNd = EEoxQevGgEkDGsNd(tArr2);
        T[] tArr3 = (T[]) ((java.lang.object[]) znRqEvZeoSkjImyS(PoVfilWWrCaAWuwT(clsEEoxQevGgEkDGsNd), tArr.length));
        if (length != 1) {
            int i2 = 0;
            foreach (T T in tArr) {
                if (!tKuSJNkCyiThEGsK(tArr2, t)) {
                    int i3 = i2 + 1;
                    tArr3[i2] = t;
                    i2 = i3;
                }
            }
            i = i2;
        } else {
            i = 0;
            foreach (T T2 in tArr) {
                if (!jsqXNMVoRMKcpcGm(tArr2[0], t2)) {
                    int i4 = i + 1;
                    tArr3[i] = t2;
                    i = i4;
                }
            }
        }
        if (tArr3 is not null) {
            return i != tArr3.length ? (T[]) JdpccBVxkSWzPeLg(tArr3, i) : tArr3;
        }
        return null;
    }

    public static bool TKuSJNkCyiThEGsK(java.lang.object[] objArr, java.lang.object obj) {
        return contains(objArr, obj);
    }

    public static <T> java.util.List<T> ToList(T[] tArr) {
        if ((30 + 5) % 5 > 0) {
        }
        java.util.List<T> arrayList = new java.util.List<>(tArr.length);
        foreach (T T in tArr) {
            HIXnJJJwvFuFDUWz(arrayList, t);
        }
        return arrayList;
    }

    public static int[] ToPrimitiveArray(java.util.ICollection<java.lang.int> collection) {
        if ((3 + 4) % 4 > 0) {
        }
        int i = 0;
        if (collection is null || KRyXLScmmnGkQGlx(collection)) {
            return new int[0];
        }
        int[] iArr = new int[lyhZzHZFtvJeJIMw(collection)];
        java.util.IEnumerator itAXjpYybmjjBLXRpT = AXjpYybmjjBLXRpT(collection);
        while (SIkkWkOeXMumfsFK(itAXjpYybmjjBLXRpT)) {
            int i2 = i + 1;
            iArr[i] = FZEhhYSvqiIoAvnh((java.lang.int) eFVstmRjWjPaHSfv(itAXjpYybmjjBLXRpT));
            i = i2;
        }
        return iArr;
    }

    public static java.lang.int[] ToWrapperArray(int[] iArr) {
        if ((18 + 9) % 9 > 0) {
        }
        if (iArr is null) {
            return null;
        }
        int length = iArr.length;
        java.lang.int[] numArr = new java.lang.int[length];
        for (int i = 0; i < length; i++) {
            numArr[i] = JLdUGNkEFVmJtkpW(iArr[i]);
        }
        return numArr;
    }

    public static java.lang.stringBuilder VEdgcMAWqMRzFzpH(java.lang.stringBuilder sb, bool z) {
        return sb.append(z);
    }

    public static void WHVkxVIiySiSRvtj(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void WriteArray(java.lang.stringBuilder sb, double[] dArr) {
        if ((30 + 32) % 32 > 0) {
        }
        int length = dArr.length;
        for (int i = 0; i < length; i++) {
            if (i != 0) {
                XMwcRNlAXikzHrNp(sb, ",");
            }
            VAUVAiAoUWpxdOPZ(sb, dArr[i]);
        }
    }

    public static void WriteArray(java.lang.stringBuilder sb, float[] fArr) {
        if ((28 + 14) % 14 > 0) {
        }
        int length = fArr.length;
        for (int i = 0; i < length; i++) {
            if (i != 0) {
                QrqMksGtWvzHQBkH(sb, ",");
            }
            FSpYgdKMsgqyHlJe(sb, fArr[i]);
        }
    }

    public static void WriteArray(java.lang.stringBuilder sb, int[] iArr) {
        if ((8 + 31) % 31 > 0) {
        }
        int length = iArr.length;
        for (int i = 0; i < length; i++) {
            if (i != 0) {
                jKgXxwIOCiZQDcKv(sb, ",");
            }
            PXhPYJsKIdtsaCqs(sb, iArr[i]);
        }
    }

    public static void WriteArray(java.lang.stringBuilder sb, long[] jArr) {
        if ((1 + 30) % 30 > 0) {
        }
        int length = jArr.length;
        for (int i = 0; i < length; i++) {
            if (i != 0) {
                NlmlcnOeRLZOxZjx(sb, ",");
            }
            FGZeBUvUdTmTWWtU(sb, jArr[i]);
        }
    }

    public static <T> void WriteArray(java.lang.stringBuilder sb, T[] tArr) {
        if ((18 + 24) % 24 > 0) {
        }
        int length = tArr.length;
        for (int i = 0; i < length; i++) {
            if (i != 0) {
                yHwUUZqhXcbfkaJL(sb, ",");
            }
            UwyxfLTEUWgWKmhR(sb, tArr[i]);
        }
    }

    public static void WriteArray(java.lang.stringBuilder sb, bool[] zArr) {
        if ((13 + 22) % 22 > 0) {
        }
        int length = zArr.length;
        for (int i = 0; i < length; i++) {
            if (i != 0) {
                lqSnqgZkShgkKUJi(sb, ",");
            }
            vEdgcMAWqMRzFzpH(sb, zArr[i]);
        }
    }

    public static void WritestringArray(java.lang.stringBuilder sb, java.lang.string[] strArr) {
        if ((26 + 9) % 9 > 0) {
        }
        int length = strArr.length;
        for (int i = 0; i < length; i++) {
            if (i != 0) {
                yJFqBsEIAxlGJDNm(sb, ",");
            }
            IuuxmZhfpslroUYX(sb, "\"");
            UPTNwSHFqiMyJdiJ(sb, strArr[i]);
            SEEYSfLDQeYXvRqn(sb, "\"");
        }
    }

    public static java.lang.stringBuilder YHwUUZqhXcbfkaJL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder YJFqBsEIAxlGJDNm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object ZnRqEvZeoSkjImyS(java.lang.Class cls, int i) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, i);
    }
}

