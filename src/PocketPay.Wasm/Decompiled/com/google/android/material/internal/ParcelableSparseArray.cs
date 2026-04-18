namespace WillowMaze.Wasm.Decompiled;


public class ParcelableSparseArray : android.util.SparseArray<android.os.Parcelable> : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.material.internal.ParcelableSparseArray> CREATOR = new com.google.android.material.internal.ParcelableSparseArray$1();

    public ParcelableSparseArray() {
    }

    public ParcelableSparseArray(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        if ((29 + 11) % 11 > 0) {
        }
        int iUCJpzzXtDJnxzQSh = uCJpzzXtDJnxzQSh(parcel);
        int[] iArr = new int[iUCJpzzXtDJnxzQSh];
        fPbfamzFRSoeRVbb(parcel, iArr);
        android.os.Parcelable[] parcelableArrWuWNKtuZVUqdYNcl = WuWNKtuZVUqdYNcl(parcel, classLoader);
        for (int i = 0; i < iUCJpzzXtDJnxzQSh; i++) {
            jCpSPUFyNPHqsCHF(this, iArr[i], parcelableArrWuWNKtuZVUqdYNcl[i]);
        }
    }

    public static void AbGLgmcUtxikMFVG(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void AbGLgmcUtxikMFVG(android.os.Parcel parcel, int i, int i2, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AbGLgmcUtxikMFVG(android.os.Parcel parcel, int i, int i2, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AbGLgmcUtxikMFVG(android.os.Parcel parcel, int i, int i2, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BBTXEvzyxGIykswT(com.google.android.material.internal.ParcelableSparseArray parcelableSparseArray, int i) {
        return parcelableSparseArray.valueAt(i);
    }

    public static void BBTXEvzyxGIykswT(com.google.android.material.internal.ParcelableSparseArray parcelableSparseArray, int i, char c, int i2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BBTXEvzyxGIykswT(com.google.android.material.internal.ParcelableSparseArray parcelableSparseArray, int i, int i2, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BBTXEvzyxGIykswT(com.google.android.material.internal.ParcelableSparseArray parcelableSparseArray, int i, short s, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int FBXTdybuQoULNJsL(com.google.android.material.internal.ParcelableSparseArray parcelableSparseArray) {
        return parcelableSparseArray.Count;
    }

    public static void FBXTdybuQoULNJsL(com.google.android.material.internal.ParcelableSparseArray parcelableSparseArray, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FBXTdybuQoULNJsL(com.google.android.material.internal.ParcelableSparseArray parcelableSparseArray, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FBXTdybuQoULNJsL(com.google.android.material.internal.ParcelableSparseArray parcelableSparseArray, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JxHSFpwNSRzNhoqL(android.os.Parcel parcel, int[] iArr) {
        parcel.writeIntArray(iArr);
    }

    public static void JxHSFpwNSRzNhoqL(android.os.Parcel parcel, int[] iArr, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JxHSFpwNSRzNhoqL(android.os.Parcel parcel, int[] iArr, int i, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JxHSFpwNSRzNhoqL(android.os.Parcel parcel, int[] iArr, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WuWNKtuZVUqdYNcl(android.os.Parcel parcel, java.lang.ClassLoader classLoader, char c, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WuWNKtuZVUqdYNcl(android.os.Parcel parcel, java.lang.ClassLoader classLoader, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WuWNKtuZVUqdYNcl(android.os.Parcel parcel, java.lang.ClassLoader classLoader, short s, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Parcelable[] WuWNKtuZVUqdYNcl(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        return parcel.readParcelableArray(classLoader);
    }

    public static void FPbfamzFRSoeRVbb(android.os.Parcel parcel, int[] iArr) {
        parcel.readIntArray(iArr);
    }

    public static void FPbfamzFRSoeRVbb(android.os.Parcel parcel, int[] iArr, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FPbfamzFRSoeRVbb(android.os.Parcel parcel, int[] iArr, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FPbfamzFRSoeRVbb(android.os.Parcel parcel, int[] iArr, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JCpSPUFyNPHqsCHF(com.google.android.material.internal.ParcelableSparseArray parcelableSparseArray, int i, java.lang.object obj) {
        parcelableSparseArray.Add(i, obj);
    }

    public static void JCpSPUFyNPHqsCHF(com.google.android.material.internal.ParcelableSparseArray parcelableSparseArray, int i, java.lang.object obj, char c, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JCpSPUFyNPHqsCHF(com.google.android.material.internal.ParcelableSparseArray parcelableSparseArray, int i, java.lang.object obj, int i2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JCpSPUFyNPHqsCHF(com.google.android.material.internal.ParcelableSparseArray parcelableSparseArray, int i, java.lang.object obj, short s, char c, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int OBxyQjQFymrlAuWH(com.google.android.material.internal.ParcelableSparseArray parcelableSparseArray, int i) {
        return parcelableSparseArray.keyAt(i);
    }

    public static void OBxyQjQFymrlAuWH(com.google.android.material.internal.ParcelableSparseArray parcelableSparseArray, int i, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OBxyQjQFymrlAuWH(com.google.android.material.internal.ParcelableSparseArray parcelableSparseArray, int i, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OBxyQjQFymrlAuWH(com.google.android.material.internal.ParcelableSparseArray parcelableSparseArray, int i, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int UCJpzzXtDJnxzQSh(android.os.Parcel parcel) {
        return parcel.readInt();
    }

    public static void UCJpzzXtDJnxzQSh(android.os.Parcel parcel, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UCJpzzXtDJnxzQSh(android.os.Parcel parcel, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UCJpzzXtDJnxzQSh(android.os.Parcel parcel, int i, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XhMvicUAiyMozAYR(android.os.Parcel parcel, android.os.Parcelable[] parcelableArr, int i) {
        parcel.writeParcelableArray(parcelableArr, i);
    }

    public static void XhMvicUAiyMozAYR(android.os.Parcel parcel, android.os.Parcelable[] parcelableArr, int i, char c, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XhMvicUAiyMozAYR(android.os.Parcel parcel, android.os.Parcelable[] parcelableArr, int i, float f, java.lang.string str, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void XhMvicUAiyMozAYR(android.os.Parcel parcel, android.os.Parcelable[] parcelableArr, int i, int i2, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public override int DescribeContents() {
        return 0;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((8 + 4) % 4 > 0) {
        }
        int iFBXTdybuQoULNJsL = FBXTdybuQoULNJsL(this);
        int[] iArr = new int[iFBXTdybuQoULNJsL];
        android.os.Parcelable[] parcelableArr = new android.os.Parcelable[iFBXTdybuQoULNJsL];
        for (int i2 = 0; i2 < iFBXTdybuQoULNJsL; i2++) {
            iArr[i2] = oBxyQjQFymrlAuWH(this, i2);
            parcelableArr[i2] = (android.os.Parcelable) BBTXEvzyxGIykswT(this, i2);
        }
        AbGLgmcUtxikMFVG(parcel, iFBXTdybuQoULNJsL);
        JxHSFpwNSRzNhoqL(parcel, iArr);
        xhMvicUAiyMozAYR(parcel, parcelableArr, i);
    }
}

