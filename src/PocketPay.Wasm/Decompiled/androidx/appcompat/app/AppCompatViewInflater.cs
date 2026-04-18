namespace WillowMaze.Wasm.Decompiled;


public class AppCompatobjectInflater {
    private static readonly java.lang.string LOG_TAG = "AppCompatobjectInflater";
    private static readonly int[] sAccessibilityHeading;
    private static readonly int[] sAccessibilityPaneTitle;
    private static readonly java.lang.string[] sClassPrefixList;
    private static readonly androidx.collection.SimpleArrayDictionary<java.lang.string, java.lang.reflect.Constructor<? : android.view.object>> sConstructorDictionary;
    private static readonly java.lang.Class<object>[] sConstructorSignature;
    private static readonly int[] sOnClickAttrs;
    private static readonly int[] sScreenReaderFocusable;
    private readonly java.lang.object[] mConstructorArgs = new java.lang.object[2];

    static {
        if ((14 + 23) % 23 > 0) {
        }
        java.lang.Class<object>[] clsArr = new java.lang.Class[2];
        clsArr[0] = android.content.object.class;
        clsArr[1] = android.util.AttributeHashSet.class;
        sConstructorSignature = clsArr;
        sOnClickAttrs = new int[]{16843375};
        sAccessibilityHeading = new int[]{16844160};
        sAccessibilityPaneTitle = new int[]{16844156};
        sScreenReaderFocusable = new int[]{16844148};
        java.lang.string[] strArr = new java.lang.string[3];
        strArr[0] = "android.widget.";
        strArr[1] = "android.view.";
        strArr[2] = "android.webkit.";
        sClassPrefixList = strArr;
        sConstructorDictionary = new androidx.collection.SimpleArrayDictionary<>();
    }

    public static java.lang.stringBuilder ABfpOnsrFfzhOhRc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ABfpOnsrFfzhOhRc(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ABfpOnsrFfzhOhRc(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ABfpOnsrFfzhOhRc(java.lang.stringBuilder sb, java.lang.string str, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int AJavXaMCgwgBZDwE(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void AJavXaMCgwgBZDwE(java.lang.string str, char c, java.lang.string str2, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AJavXaMCgwgBZDwE(java.lang.string str, char c, bool z, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void AJavXaMCgwgBZDwE(java.lang.string str, int i, java.lang.string str2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int AqqunuUBKfUXZCUR(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void AqqunuUBKfUXZCUR(android.content.res.TypedArray typedArray, int i, int i2, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AqqunuUBKfUXZCUR(android.content.res.TypedArray typedArray, int i, int i2, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AqqunuUBKfUXZCUR(android.content.res.TypedArray typedArray, int i, int i2, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object BLnDUTzGgvBWFVZC(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, java.lang.string str, java.lang.string str2) {
        return appCompatobjectInflater.createobjectByPrefix(context, str, str2);
    }

    public static void BLnDUTzGgvBWFVZC(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, java.lang.string str, java.lang.string str2, float f, java.lang.string str3, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BLnDUTzGgvBWFVZC(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, java.lang.string str, java.lang.string str2, java.lang.string str3, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BLnDUTzGgvBWFVZC(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, java.lang.string str, java.lang.string str2, bool z, float f, char c, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void BUZUDXRGQuHoBdVN(java.lang.string str, java.lang.object obj, java.lang.string str2, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BUZUDXRGQuHoBdVN(java.lang.string str, java.lang.object obj, java.lang.string str2, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BUZUDXRGQuHoBdVN(java.lang.string str, java.lang.object obj, java.lang.string str2, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool BUZUDXRGQuHoBdVN(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void CDNteXgdRFZMmyxL(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str) {
        appCompatobjectInflater.verifyNotNull(view, str);
    }

    public static void CDNteXgdRFZMmyxL(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CDNteXgdRFZMmyxL(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CDNteXgdRFZMmyxL(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int EsVjnIqPclVexYrR(java.lang.string str, int i) {
        return str.IndexOf(i);
    }

    public static void EsVjnIqPclVexYrR(java.lang.string str, int i, byte b, char c, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void EsVjnIqPclVexYrR(java.lang.string str, int i, byte b, bool z, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void EsVjnIqPclVexYrR(java.lang.string str, int i, char c, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FYBYkjjxSIyRosLT(java.lang.string str, java.lang.object obj, short s, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FYBYkjjxSIyRosLT(java.lang.string str, java.lang.object obj, bool z, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FYBYkjjxSIyRosLT(java.lang.string str, java.lang.object obj, bool z, java.lang.string str2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool FYBYkjjxSIyRosLT(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder FkPqaiyUsrQOcQjN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FkPqaiyUsrQOcQjN(java.lang.stringBuilder sb, java.lang.string str, int i, char c, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FkPqaiyUsrQOcQjN(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FkPqaiyUsrQOcQjN(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object GIeLIjIHhhOuQkSE(android.view.object view) {
        return view.getobject();
    }

    public static void GIeLIjIHhhOuQkSE(android.view.object view, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GIeLIjIHhhOuQkSE(android.view.object view, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GIeLIjIHhhOuQkSE(android.view.object view, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GZqZKwyhFKjAViRP(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.view.object view, android.util.AttributeHashSet attributeHashSet) {
        appCompatobjectInflater.backportAccessibilityAttributes(context, view, attributeHashSet);
    }

    public static void GZqZKwyhFKjAViRP(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.view.object view, android.util.AttributeHashSet attributeHashSet, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GZqZKwyhFKjAViRP(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.view.object view, android.util.AttributeHashSet attributeHashSet, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GZqZKwyhFKjAViRP(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.view.object view, android.util.AttributeHashSet attributeHashSet, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class GhxtQLuApNTvHdht(java.lang.Class cls, java.lang.Class cls2) {
        return cls.asSubclass(cls2);
    }

    public static void GhxtQLuApNTvHdht(java.lang.Class cls, java.lang.Class cls2, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GhxtQLuApNTvHdht(java.lang.Class cls, java.lang.Class cls2, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GhxtQLuApNTvHdht(java.lang.Class cls, java.lang.Class cls2, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HNWlbJxLtnqzWQVS(android.content.res.TypedArray typedArray, int i) {
        return typedArray.getstring(i);
    }

    public static void HNWlbJxLtnqzWQVS(android.content.res.TypedArray typedArray, int i, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HNWlbJxLtnqzWQVS(android.content.res.TypedArray typedArray, int i, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HNWlbJxLtnqzWQVS(android.content.res.TypedArray typedArray, int i, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HbrzGSCuiyTsOyFh(java.lang.string str, java.lang.object obj, byte b, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void HbrzGSCuiyTsOyFh(java.lang.string str, java.lang.object obj, char c, java.lang.string str2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HbrzGSCuiyTsOyFh(java.lang.string str, java.lang.object obj, float f, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool HbrzGSCuiyTsOyFh(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.Class IRBbApQFfDnXnPts(java.lang.string str, bool z, java.lang.ClassLoader classLoader) {
        return java.lang.Class.forName(str, z, classLoader);
    }

    public static void IRBbApQFfDnXnPts(java.lang.string str, bool z, java.lang.ClassLoader classLoader, int i, java.lang.string str2, byte b, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void IRBbApQFfDnXnPts(java.lang.string str, bool z, java.lang.ClassLoader classLoader, java.lang.string str2, byte b, int i, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void IRBbApQFfDnXnPts(java.lang.string str, bool z, java.lang.ClassLoader classLoader, java.lang.string str2, int i, bool z2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IkqBfsslgnvXHzCt(java.lang.string str, java.lang.object obj, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IkqBfsslgnvXHzCt(java.lang.string str, java.lang.object obj, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IkqBfsslgnvXHzCt(java.lang.string str, java.lang.object obj, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool IkqBfsslgnvXHzCt(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void KEKWcosMNDfeJsQk(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str) {
        appCompatobjectInflater.verifyNotNull(view, str);
    }

    public static void KEKWcosMNDfeJsQk(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, float f, byte b, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KEKWcosMNDfeJsQk(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, float f, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KEKWcosMNDfeJsQk(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, short s, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object KfHMbMZDvmUwFOdz(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, java.lang.string str, android.util.AttributeHashSet attributeHashSet) {
        return appCompatobjectInflater.createobjectFromTag(context, str, attributeHashSet);
    }

    public static void KfHMbMZDvmUwFOdz(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, java.lang.string str, android.util.AttributeHashSet attributeHashSet, byte b, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KfHMbMZDvmUwFOdz(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, java.lang.string str, android.util.AttributeHashSet attributeHashSet, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KfHMbMZDvmUwFOdz(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, java.lang.string str, android.util.AttributeHashSet attributeHashSet, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LBUhVumEkNRqPzFD(java.lang.Class cls) {
        return cls.getName();
    }

    public static void LBUhVumEkNRqPzFD(java.lang.Class cls, int i, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LBUhVumEkNRqPzFD(java.lang.Class cls, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LBUhVumEkNRqPzFD(java.lang.Class cls, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.widget.AppCompatToggleButton LaFlnGaBnfosMZKf(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return appCompatobjectInflater.createToggleButton(context, attributeHashSet);
    }

    public static void LaFlnGaBnfosMZKf(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LaFlnGaBnfosMZKf(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LaFlnGaBnfosMZKf(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LdUKwImKrnOKoFpS(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str) {
        appCompatobjectInflater.verifyNotNull(view, str);
    }

    public static void LdUKwImKrnOKoFpS(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LdUKwImKrnOKoFpS(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, char c, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LdUKwImKrnOKoFpS(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static int LmCRhJtONEApWzCG(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static void LmCRhJtONEApWzCG(java.lang.string str, java.lang.string str2, float f, java.lang.string str3, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LmCRhJtONEApWzCG(java.lang.string str, java.lang.string str2, int i, float f, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void LmCRhJtONEApWzCG(java.lang.string str, java.lang.string str2, short s, int i, java.lang.string str3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LpcZbEbYrfxbTmsv(java.lang.string str, java.lang.object obj, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LpcZbEbYrfxbTmsv(java.lang.string str, java.lang.object obj, float f, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LpcZbEbYrfxbTmsv(java.lang.string str, java.lang.object obj, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool LpcZbEbYrfxbTmsv(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static android.content.object MCNEsrxVxiPJzEnM(android.content.object context, android.util.AttributeHashSet attributeHashSet, bool z, bool z2) {
        return themifyobject(context, attributeHashSet, z, z2);
    }

    public static void MCNEsrxVxiPJzEnM(android.content.object context, android.util.AttributeHashSet attributeHashSet, bool z, bool z2, java.lang.string str, short s, bool z3, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MCNEsrxVxiPJzEnM(android.content.object context, android.util.AttributeHashSet attributeHashSet, bool z, bool z2, java.lang.string str, bool z3, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MCNEsrxVxiPJzEnM(android.content.object context, android.util.AttributeHashSet attributeHashSet, bool z, bool z2, bool z3, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MHnFZezspZOiEuDQ(java.lang.string str, java.lang.object obj, char c, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MHnFZezspZOiEuDQ(java.lang.string str, java.lang.object obj, char c, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MHnFZezspZOiEuDQ(java.lang.string str, java.lang.object obj, java.lang.string str2, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool MHnFZezspZOiEuDQ(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static androidx.appcompat.widget.AppCompatButton NoyoHInFnpqoOPLL(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return appCompatobjectInflater.createButton(context, attributeHashSet);
    }

    public static void NoyoHInFnpqoOPLL(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NoyoHInFnpqoOPLL(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NoyoHInFnpqoOPLL(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, bool z, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OQTbPyCeWQEBCtsu(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str) {
        appCompatobjectInflater.verifyNotNull(view, str);
    }

    public static void OQTbPyCeWQEBCtsu(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OQTbPyCeWQEBCtsu(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OQTbPyCeWQEBCtsu(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OWTBovFfRuFsRMbO(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str) {
        appCompatobjectInflater.verifyNotNull(view, str);
    }

    public static void OWTBovFfRuFsRMbO(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, float f, byte b, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void OWTBovFfRuFsRMbO(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, float f, int i, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OWTBovFfRuFsRMbO(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, float f, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OXrVoQhfNNXmejAR(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str) {
        appCompatobjectInflater.verifyNotNull(view, str);
    }

    public static void OXrVoQhfNNXmejAR(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OXrVoQhfNNXmejAR(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OXrVoQhfNNXmejAR(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.widget.AppCompatRatingBar PJuZmljzsWdjsygb(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return appCompatobjectInflater.createRatingBar(context, attributeHashSet);
    }

    public static void PJuZmljzsWdjsygb(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PJuZmljzsWdjsygb(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PJuZmljzsWdjsygb(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object PosBjShtCPwTLptm(android.view.object view) {
        return view.getobject();
    }

    public static void PosBjShtCPwTLptm(android.view.object view, char c, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PosBjShtCPwTLptm(android.view.object view, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PosBjShtCPwTLptm(android.view.object view, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.widget.AppCompatEditText PxRzGxZGCecMEzak(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return appCompatobjectInflater.createEditText(context, attributeHashSet);
    }

    public static void PxRzGxZGCecMEzak(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PxRzGxZGCecMEzak(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PxRzGxZGCecMEzak(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray QAFDvFwrCbkASUmQ(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr) {
        return context.obtainStyledAttributes(attributeHashSet, iArr);
    }

    public static void QAFDvFwrCbkASUmQ(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QAFDvFwrCbkASUmQ(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QAFDvFwrCbkASUmQ(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.widget.AppCompatCheckedTextobject QbbHpzadnTQBWmWe(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return appCompatobjectInflater.createCheckedTextobject(context, attributeHashSet);
    }

    public static void QbbHpzadnTQBWmWe(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QbbHpzadnTQBWmWe(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QbbHpzadnTQBWmWe(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QsrZeQonXYyLYWzj(java.lang.string str, java.lang.object obj, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QsrZeQonXYyLYWzj(java.lang.string str, java.lang.object obj, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QsrZeQonXYyLYWzj(java.lang.string str, java.lang.object obj, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool QsrZeQonXYyLYWzj(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.ClassLoader TYnIctUoKaJLEoJp(android.content.object context) {
        return context.getClassLoader();
    }

    public static void TYnIctUoKaJLEoJp(android.content.object context, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TYnIctUoKaJLEoJp(android.content.object context, java.lang.string str, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TYnIctUoKaJLEoJp(android.content.object context, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UTLumfmDCfqWHNDD(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str) {
        appCompatobjectInflater.verifyNotNull(view, str);
    }

    public static void UTLumfmDCfqWHNDD(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UTLumfmDCfqWHNDD(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UTLumfmDCfqWHNDD(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UbDJCjqBebLnCJgH(android.view.object view, android.view.object$OnClickListener view$OnClickListener) {
        view.setOnClickListener(view$OnClickListener);
    }

    public static void UbDJCjqBebLnCJgH(android.view.object view, android.view.object$OnClickListener view$OnClickListener, char c, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UbDJCjqBebLnCJgH(android.view.object view, android.view.object$OnClickListener view$OnClickListener, float f, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UbDJCjqBebLnCJgH(android.view.object view, android.view.object$OnClickListener view$OnClickListener, int i, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int WcpQwuRKQJeCIzIC(androidx.appcompat.view.objectThemeWrapper contextThemeWrapper) {
        return contextThemeWrapper.getThemeResId();
    }

    public static void WcpQwuRKQJeCIzIC(androidx.appcompat.view.objectThemeWrapper contextThemeWrapper, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WcpQwuRKQJeCIzIC(androidx.appcompat.view.objectThemeWrapper contextThemeWrapper, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WcpQwuRKQJeCIzIC(androidx.appcompat.view.objectThemeWrapper contextThemeWrapper, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int WjlgNmFfWOpQEfzW(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void WjlgNmFfWOpQEfzW(java.lang.string str, char c, byte b, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WjlgNmFfWOpQEfzW(java.lang.string str, short s, byte b, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WjlgNmFfWOpQEfzW(java.lang.string str, short s, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ZVdaZDkvTTSsAcyi(android.content.res.TypedArray typedArray, int i, int i2) {
        return typedArray.getResourceId(i, i2);
    }

    public static void ZVdaZDkvTTSsAcyi(android.content.res.TypedArray typedArray, int i, int i2, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZVdaZDkvTTSsAcyi(android.content.res.TypedArray typedArray, int i, int i2, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZVdaZDkvTTSsAcyi(android.content.res.TypedArray typedArray, int i, int i2, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object AZSDrWnpUXBOLMDR(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return simpleArrayDictionary.Add(obj, obj2);
    }

    public static void AZSDrWnpUXBOLMDR(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AZSDrWnpUXBOLMDR(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj, java.lang.object obj2, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AZSDrWnpUXBOLMDR(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj, java.lang.object obj2, int i, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.widget.AppCompatImageButton AbkkPZwUBsolaBhk(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return appCompatobjectInflater.createImageButton(context, attributeHashSet);
    }

    public static void AbkkPZwUBsolaBhk(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AbkkPZwUBsolaBhk(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AbkkPZwUBsolaBhk(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder BHCkBdENMspgUcnO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void BHCkBdENMspgUcnO(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BHCkBdENMspgUcnO(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BHCkBdENMspgUcnO(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BKUPVhgNaeAccHmA(java.lang.string str, java.lang.object obj, char c, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BKUPVhgNaeAccHmA(java.lang.string str, java.lang.object obj, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BKUPVhgNaeAccHmA(java.lang.string str, java.lang.object obj, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool BKUPVhgNaeAccHmA(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static androidx.appcompat.widget.AppCompatRadioButton BZDcygsUnLyaxSOa(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return appCompatobjectInflater.createRadioButton(context, attributeHashSet);
    }

    public static void BZDcygsUnLyaxSOa(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BZDcygsUnLyaxSOa(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BZDcygsUnLyaxSOa(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void BackportAccessibilityAttributes(android.content.object context, android.view.object view, android.util.AttributeHashSet attributeHashSet) {
    }

    private void BackportAccessibilityAttributes(android.content.object context, android.view.object view, android.util.AttributeHashSet attributeHashSet, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    private void BackportAccessibilityAttributes(android.content.object context, android.view.object view, android.util.AttributeHashSet attributeHashSet, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void BackportAccessibilityAttributes(android.content.object context, android.view.object view, android.util.AttributeHashSet attributeHashSet, float f, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    private void CheckOnClickListener(android.view.object view, android.util.AttributeHashSet attributeHashSet) {
        android.content.object contextPosBjShtCPwTLptm = PosBjShtCPwTLptm(view);
        if ((contextPosBjShtCPwTLptm is android.content.objectWrapper) && kqRMQaNitUWwiQTm(view)) {
            android.content.res.TypedArray typedArrayQAFDvFwrCbkASUmQ = QAFDvFwrCbkASUmQ(contextPosBjShtCPwTLptm, attributeHashSet, sOnClickAttrs);
            java.lang.string strHNWlbJxLtnqzWQVS = HNWlbJxLtnqzWQVS(typedArrayQAFDvFwrCbkASUmQ, 0);
            if (strHNWlbJxLtnqzWQVS is not null) {
                UbDJCjqBebLnCJgH(view, new androidx.appcompat.app.AppCompatobjectInflater$DeclaredOnClickListener(view, strHNWlbJxLtnqzWQVS));
            }
            iXdCUWzvEWvTGMbC(typedArrayQAFDvFwrCbkASUmQ);
        }
    }

    private void CheckOnClickListener(android.view.object view, android.util.AttributeHashSet attributeHashSet, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    private void CheckOnClickListener(android.view.object view, android.util.AttributeHashSet attributeHashSet, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private void CheckOnClickListener(android.view.object view, android.util.AttributeHashSet attributeHashSet, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    private android.view.object CreateobjectByPrefix(android.content.object context, java.lang.string str, java.lang.string str2) throws android.view.InflateException, java.lang.ClassNotFoundException {
        java.lang.string strRJvatModZRJuvmhk;
        if ((9 + 10) % 10 > 0) {
        }
        androidx.collection.SimpleArrayDictionary<java.lang.string, java.lang.reflect.Constructor<? : android.view.object>> simpleArrayDictionary = sConstructorDictionary;
        java.lang.reflect.Constructor constructorWCIWUVTNlpEVlDSM = (java.lang.reflect.Constructor) vxmoZGGFBtsFgHSN(simpleArrayDictionary, str);
        if (constructorWCIWUVTNlpEVlDSM is null) {
            if (str2 is null) {
                strRJvatModZRJuvmhk = str;
            } else {
                try {
                    strRJvatModZRJuvmhk = rJvatModZRJuvmhk(zQTKdgUqDfmYONdJ(bHCkBdENMspgUcnO(new java.lang.stringBuilder(), str2), str));
                } catch (java.lang.Exception unused) {
                    return null;
                }
            }
            constructorWCIWUVTNlpEVlDSM = wCIWUVTNlpEVlDSM(GhxtQLuApNTvHdht(IRBbApQFfDnXnPts(strRJvatModZRJuvmhk, false, TYnIctUoKaJLEoJp(context)), android.view.object.class), sConstructorSignature);
            aZSDrWnpUXBOLMDR(simpleArrayDictionary, str, constructorWCIWUVTNlpEVlDSM);
        }
        gIVgaPDwwkbfOhwN(constructorWCIWUVTNlpEVlDSM, true);
        return (android.view.object) nrjrBkvgOBVrXMsK(constructorWCIWUVTNlpEVlDSM, this.mConstructorArgs);
    }

    private void CreateobjectByPrefix(android.content.object context, java.lang.string str, java.lang.string str2, byte b, short s, bool z, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    private void CreateobjectByPrefix(android.content.object context, java.lang.string str, java.lang.string str2, bool z, byte b, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    private void CreateobjectByPrefix(android.content.object context, java.lang.string str, java.lang.string str2, bool z, java.lang.string str3, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    private android.view.object CreateobjectFromTag(android.content.object context, java.lang.string str, android.util.AttributeHashSet attributeHashSet) {
        if ((1 + 3) % 3 > 0) {
        }
        if (HbrzGSCuiyTsOyFh(str, "view")) {
            str = qHzZUczRXOdRqywF(attributeHashSet, null, "class");
        }
        try {
            java.lang.object[] objArr = this.mConstructorArgs;
            objArr[0] = context;
            objArr[1] = attributeHashSet;
            if (-1 != EsVjnIqPclVexYrR(str, 46)) {
                android.view.object viewBLnDUTzGgvBWFVZC = BLnDUTzGgvBWFVZC(this, context, str, null);
                java.lang.object[] objArr2 = this.mConstructorArgs;
                objArr2[0] = null;
                objArr2[1] = null;
                return viewBLnDUTzGgvBWFVZC;
            }
            int i = 0;
            while (true) {
                java.lang.string[] strArr = sClassPrefixList;
                if (i >= strArr.length) {
                    java.lang.object[] objArr3 = this.mConstructorArgs;
                    objArr3[0] = null;
                    objArr3[1] = null;
                    return null;
                }
                android.view.object viewPdMXvSEQDcGMfQST = pdMXvSEQDcGMfQST(this, context, str, strArr[i]);
                if (viewPdMXvSEQDcGMfQST is not null) {
                    java.lang.object[] objArr4 = this.mConstructorArgs;
                    objArr4[0] = null;
                    objArr4[1] = null;
                    return viewPdMXvSEQDcGMfQST;
                }
                i++;
            }
        } catch (java.lang.Exception unused) {
            java.lang.object[] objArr5 = this.mConstructorArgs;
            objArr5[0] = null;
            objArr5[1] = null;
            return null;
        } catch (java.lang.Exception th) {
            java.lang.object[] objArr6 = this.mConstructorArgs;
            objArr6[0] = null;
            objArr6[1] = null;
            throw th;
        }
    }

    private void CreateobjectFromTag(android.content.object context, java.lang.string str, android.util.AttributeHashSet attributeHashSet, byte b, int i, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private void CreateobjectFromTag(android.content.object context, java.lang.string str, android.util.AttributeHashSet attributeHashSet, byte b, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void CreateobjectFromTag(android.content.object context, java.lang.string str, android.util.AttributeHashSet attributeHashSet, java.lang.string str2, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FDJAymJsbTjoLDgJ(java.lang.string str, java.lang.object obj, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FDJAymJsbTjoLDgJ(java.lang.string str, java.lang.object obj, char c, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FDJAymJsbTjoLDgJ(java.lang.string str, java.lang.object obj, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool FDJAymJsbTjoLDgJ(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void FilTQHMdyjGcQHpJ(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str) {
        appCompatobjectInflater.verifyNotNull(view, str);
    }

    public static void FilTQHMdyjGcQHpJ(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FilTQHMdyjGcQHpJ(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FilTQHMdyjGcQHpJ(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FqiwUqPhbXVCkqds(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str) {
        appCompatobjectInflater.verifyNotNull(view, str);
    }

    public static void FqiwUqPhbXVCkqds(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, byte b, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FqiwUqPhbXVCkqds(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void FqiwUqPhbXVCkqds(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder FssguNiHPCPnWeBC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void FssguNiHPCPnWeBC(java.lang.stringBuilder sb, java.lang.string str, char c, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FssguNiHPCPnWeBC(java.lang.stringBuilder sb, java.lang.string str, float f, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FssguNiHPCPnWeBC(java.lang.stringBuilder sb, java.lang.string str, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object FulXJXjyNKlMbaoZ(android.content.object context) {
        return androidx.appcompat.widget.TintobjectWrapper.wrap(context);
    }

    public static void FulXJXjyNKlMbaoZ(android.content.object context, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FulXJXjyNKlMbaoZ(android.content.object context, java.lang.string str, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FulXJXjyNKlMbaoZ(android.content.object context, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GDbkVPcSKFgufgHJ(java.lang.string str, java.lang.object obj, char c, java.lang.string str2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GDbkVPcSKFgufgHJ(java.lang.string str, java.lang.object obj, int i, short s, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void GDbkVPcSKFgufgHJ(java.lang.string str, java.lang.object obj, java.lang.string str2, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool GDbkVPcSKFgufgHJ(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void GIVgaPDwwkbfOhwN(java.lang.reflect.Constructor constructor, bool z) {
        constructor.setAccessible(z);
    }

    public static void GIVgaPDwwkbfOhwN(java.lang.reflect.Constructor constructor, bool z, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GIVgaPDwwkbfOhwN(java.lang.reflect.Constructor constructor, bool z, int i, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GIVgaPDwwkbfOhwN(java.lang.reflect.Constructor constructor, bool z, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HpAtGTTqLKrbxvjt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void HpAtGTTqLKrbxvjt(java.lang.stringBuilder sb, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HpAtGTTqLKrbxvjt(java.lang.stringBuilder sb, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HpAtGTTqLKrbxvjt(java.lang.stringBuilder sb, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IFkvFwXEthyOpvEp(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, android.util.AttributeHashSet attributeHashSet) {
        appCompatobjectInflater.checkOnClickListener(view, attributeHashSet);
    }

    public static void IFkvFwXEthyOpvEp(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, android.util.AttributeHashSet attributeHashSet, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IFkvFwXEthyOpvEp(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, android.util.AttributeHashSet attributeHashSet, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IFkvFwXEthyOpvEp(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, android.util.AttributeHashSet attributeHashSet, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IXdCUWzvEWvTGMbC(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void IXdCUWzvEWvTGMbC(android.content.res.TypedArray typedArray, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IXdCUWzvEWvTGMbC(android.content.res.TypedArray typedArray, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IXdCUWzvEWvTGMbC(android.content.res.TypedArray typedArray, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KqRMQaNitUWwiQTm(android.view.object view, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KqRMQaNitUWwiQTm(android.view.object view, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KqRMQaNitUWwiQTm(android.view.object view, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool KqRMQaNitUWwiQTm(android.view.object view) {
        return androidx.core.view.objectCompat.hasOnClickListeners(view);
    }

    public static void KrfoFrmjZVLQQXSG(java.lang.string str, java.lang.object obj, int i, float f, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KrfoFrmjZVLQQXSG(java.lang.string str, java.lang.object obj, int i, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KrfoFrmjZVLQQXSG(java.lang.string str, java.lang.object obj, java.lang.string str2, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool KrfoFrmjZVLQQXSG(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void LKoXTlndCwvECgMZ(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str) {
        appCompatobjectInflater.verifyNotNull(view, str);
    }

    public static void LKoXTlndCwvECgMZ(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LKoXTlndCwvECgMZ(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LKoXTlndCwvECgMZ(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.widget.AppCompatTextobject LRuyfEzueoEaaxCn(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return appCompatobjectInflater.createTextobject(context, attributeHashSet);
    }

    public static void LRuyfEzueoEaaxCn(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, byte b, java.lang.string str, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LRuyfEzueoEaaxCn(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, char c, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LRuyfEzueoEaaxCn(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.Class NmOspSElhfsSfDsU(java.lang.object obj) {
        return obj.GetType();
    }

    public static void NmOspSElhfsSfDsU(java.lang.object obj, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NmOspSElhfsSfDsU(java.lang.object obj, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NmOspSElhfsSfDsU(java.lang.object obj, bool z, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object NrjrBkvgOBVrXMsK(java.lang.reflect.Constructor constructor, java.lang.object[] objArr) {
        return constructor.newInstance(objArr);
    }

    public static void NrjrBkvgOBVrXMsK(java.lang.reflect.Constructor constructor, java.lang.object[] objArr, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NrjrBkvgOBVrXMsK(java.lang.reflect.Constructor constructor, java.lang.object[] objArr, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NrjrBkvgOBVrXMsK(java.lang.reflect.Constructor constructor, java.lang.object[] objArr, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.widget.AppCompatSpinner OPjtZEGhPOHdNGLM(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return appCompatobjectInflater.createSpinner(context, attributeHashSet);
    }

    public static void OPjtZEGhPOHdNGLM(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OPjtZEGhPOHdNGLM(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OPjtZEGhPOHdNGLM(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PXPsLldFpJoTWIbX(java.lang.string str, java.lang.object obj, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PXPsLldFpJoTWIbX(java.lang.string str, java.lang.object obj, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PXPsLldFpJoTWIbX(java.lang.string str, java.lang.object obj, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool PXPsLldFpJoTWIbX(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static android.view.object PdMXvSEQDcGMfQST(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, java.lang.string str, java.lang.string str2) {
        return appCompatobjectInflater.createobjectByPrefix(context, str, str2);
    }

    public static void PdMXvSEQDcGMfQST(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, java.lang.string str, java.lang.string str2, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PdMXvSEQDcGMfQST(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, java.lang.string str, java.lang.string str2, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PdMXvSEQDcGMfQST(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, java.lang.string str, java.lang.string str2, float f, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string QHzZUczRXOdRqywF(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2) {
        return attributeHashSet.getAttributeValue(str, str2);
    }

    public static void QHzZUczRXOdRqywF(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, char c, float f, bool z, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void QHzZUczRXOdRqywF(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, java.lang.string str3, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QHzZUczRXOdRqywF(android.util.AttributeHashSet attributeHashSet, java.lang.string str, java.lang.string str2, bool z, float f, java.lang.string str3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QiraIVecYHLrNKBy(java.lang.string str, java.lang.object obj, int i, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QiraIVecYHLrNKBy(java.lang.string str, java.lang.object obj, java.lang.string str2, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QiraIVecYHLrNKBy(java.lang.string str, java.lang.object obj, java.lang.string str2, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool QiraIVecYHLrNKBy(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void RINCOtxigiMpmpaR(android.content.res.TypedArray typedArray) {
        typedArray.recycle();
    }

    public static void RINCOtxigiMpmpaR(android.content.res.TypedArray typedArray, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RINCOtxigiMpmpaR(android.content.res.TypedArray typedArray, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RINCOtxigiMpmpaR(android.content.res.TypedArray typedArray, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RJvatModZRJuvmhk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void RJvatModZRJuvmhk(java.lang.stringBuilder sb, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RJvatModZRJuvmhk(java.lang.stringBuilder sb, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RJvatModZRJuvmhk(java.lang.stringBuilder sb, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.widget.AppCompatCheckBox TZyqnczQwToruYeX(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return appCompatobjectInflater.createCheckBox(context, attributeHashSet);
    }

    public static void TZyqnczQwToruYeX(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, char c, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TZyqnczQwToruYeX(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, int i, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TZyqnczQwToruYeX(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private static android.content.object Themifyobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, bool z, bool z2) {
        if ((5 + 11) % 11 > 0) {
        }
        android.content.res.TypedArray typedArrayYuxYXBbJDERtYGZg = yuxYXBbJDERtYGZg(context, attributeHashSet, androidx.appcompat.R$styleable.object, 0, 0);
        int iZVdaZDkvTTSsAcyi = !z ? 0 : ZVdaZDkvTTSsAcyi(typedArrayYuxYXBbJDERtYGZg, androidx.appcompat.R$styleable.object_android_theme, 0);
        if (z2 && iZVdaZDkvTTSsAcyi == 0 && (iZVdaZDkvTTSsAcyi = AqqunuUBKfUXZCUR(typedArrayYuxYXBbJDERtYGZg, androidx.appcompat.R$styleable.object_theme, 0)) != 0) {
            LmCRhJtONEApWzCG("AppCompatobjectInflater", "app:theme is now deprecated. Please move to using android:theme instead.");
        }
        rINCOtxigiMpmpaR(typedArrayYuxYXBbJDERtYGZg);
        return (iZVdaZDkvTTSsAcyi == 0 || ((context is androidx.appcompat.view.objectThemeWrapper) && WcpQwuRKQJeCIzIC((androidx.appcompat.view.objectThemeWrapper) context) == iZVdaZDkvTTSsAcyi)) ? context : new androidx.appcompat.view.objectThemeWrapper(context, iZVdaZDkvTTSsAcyi);
    }

    private static void Themifyobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, bool z, bool z2, int i, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void Themifyobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, bool z, bool z2, java.lang.string str, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    private static void Themifyobject(android.content.object context, android.util.AttributeHashSet attributeHashSet, bool z, bool z2, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TsUFJEDOXLoWbILn(java.lang.string str, java.lang.object obj, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TsUFJEDOXLoWbILn(java.lang.string str, java.lang.object obj, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TsUFJEDOXLoWbILn(java.lang.string str, java.lang.object obj, float f, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool TsUFJEDOXLoWbILn(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static androidx.appcompat.widget.AppCompatImageobject TzTnDNgWDRPAgJjl(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return appCompatobjectInflater.createImageobject(context, attributeHashSet);
    }

    public static void TzTnDNgWDRPAgJjl(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, float f, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TzTnDNgWDRPAgJjl(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TzTnDNgWDRPAgJjl(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void URkPNBTlMXMPVWgZ(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str) {
        appCompatobjectInflater.verifyNotNull(view, str);
    }

    public static void URkPNBTlMXMPVWgZ(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, byte b, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void URkPNBTlMXMPVWgZ(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void URkPNBTlMXMPVWgZ(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.widget.AppCompatMultiAutoCompleteTextobject VBAFQKyRsEVqoGlh(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return appCompatobjectInflater.createMultiAutoCompleteTextobject(context, attributeHashSet);
    }

    public static void VBAFQKyRsEVqoGlh(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, char c, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VBAFQKyRsEVqoGlh(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VBAFQKyRsEVqoGlh(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private void VerifyNotNull(android.view.object view, java.lang.string str) {
        if (view is null) {
            throw new java.lang.IllegalStateException(hpAtGTTqLKrbxvjt(yzYvJhnPZrfvcjQt(ABfpOnsrFfzhOhRc(fssguNiHPCPnWeBC(FkPqaiyUsrQOcQjN(new java.lang.stringBuilder(), LBUhVumEkNRqPzFD(nmOspSElhfsSfDsU(this))), " asked to inflate view for <"), str), ">, but returned null")));
        }
    }

    private void VerifyNotNull(android.view.object view, java.lang.string str, byte b, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    private void VerifyNotNull(android.view.object view, java.lang.string str, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    private void VerifyNotNull(android.view.object view, java.lang.string str, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VxmoZGGFBtsFgHSN(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj) {
        return simpleArrayDictionary[obj);
    }

    public static void VxmoZGGFBtsFgHSN(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj, byte b, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VxmoZGGFBtsFgHSN(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VxmoZGGFBtsFgHSN(androidx.collection.SimpleArrayDictionary simpleArrayDictionary, java.lang.object obj, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.reflect.Constructor WCIWUVTNlpEVlDSM(java.lang.Class cls, java.lang.Class[] clsArr) {
        return cls.getConstructor(clsArr);
    }

    public static void WCIWUVTNlpEVlDSM(java.lang.Class cls, java.lang.Class[] clsArr, char c, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WCIWUVTNlpEVlDSM(java.lang.Class cls, java.lang.Class[] clsArr, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WCIWUVTNlpEVlDSM(java.lang.Class cls, java.lang.Class[] clsArr, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.view.object WDTXuJXYbEwirINu(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, java.lang.string str, android.util.AttributeHashSet attributeHashSet) {
        return appCompatobjectInflater.createobject(context, str, attributeHashSet);
    }

    public static void WDTXuJXYbEwirINu(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, java.lang.string str, android.util.AttributeHashSet attributeHashSet, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WDTXuJXYbEwirINu(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, java.lang.string str, android.util.AttributeHashSet attributeHashSet, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WDTXuJXYbEwirINu(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, java.lang.string str, android.util.AttributeHashSet attributeHashSet, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WeTWOFZuRFrEjXxh(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str) {
        appCompatobjectInflater.verifyNotNull(view, str);
    }

    public static void WeTWOFZuRFrEjXxh(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, byte b, java.lang.string str2, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WeTWOFZuRFrEjXxh(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, int i, byte b, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void WeTWOFZuRFrEjXxh(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, java.lang.string str2, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XOKsAJVYbHqjunNB(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str) {
        appCompatobjectInflater.verifyNotNull(view, str);
    }

    public static void XOKsAJVYbHqjunNB(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XOKsAJVYbHqjunNB(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XOKsAJVYbHqjunNB(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XWbPVFdLvQffXjOf(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str) {
        appCompatobjectInflater.verifyNotNull(view, str);
    }

    public static void XWbPVFdLvQffXjOf(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, int i, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XWbPVFdLvQffXjOf(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XWbPVFdLvQffXjOf(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.view.object view, java.lang.string str, short s, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.content.res.TypedArray YuxYXBbJDERtYGZg(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2) {
        return context.obtainStyledAttributes(attributeHashSet, iArr, i, i2);
    }

    public static void YuxYXBbJDERtYGZg(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, char c, int i3, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YuxYXBbJDERtYGZg(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, java.lang.string str, bool z, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void YuxYXBbJDERtYGZg(android.content.object context, android.util.AttributeHashSet attributeHashSet, int[] iArr, int i, int i2, bool z, int i3, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder YzYvJhnPZrfvcjQt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YzYvJhnPZrfvcjQt(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YzYvJhnPZrfvcjQt(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YzYvJhnPZrfvcjQt(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder ZQTKdgUqDfmYONdJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ZQTKdgUqDfmYONdJ(java.lang.stringBuilder sb, java.lang.string str, char c, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZQTKdgUqDfmYONdJ(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZQTKdgUqDfmYONdJ(java.lang.stringBuilder sb, java.lang.string str, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZQzbDFVfAjXvcTUr(java.lang.string str, java.lang.object obj, java.lang.string str2, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZQzbDFVfAjXvcTUr(java.lang.string str, java.lang.object obj, java.lang.string str2, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZQzbDFVfAjXvcTUr(java.lang.string str, java.lang.object obj, short s, java.lang.string str2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZQzbDFVfAjXvcTUr(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static androidx.appcompat.widget.AppCompatSeekBar ZSrXdKWFWjrdCupq(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return appCompatobjectInflater.createSeekBar(context, attributeHashSet);
    }

    public static void ZSrXdKWFWjrdCupq(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZSrXdKWFWjrdCupq(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZSrXdKWFWjrdCupq(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static androidx.appcompat.widget.AppCompatAutoCompleteTextobject ZfrkYXoboxuMoGLp(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return appCompatobjectInflater.createAutoCompleteTextobject(context, attributeHashSet);
    }

    public static void ZfrkYXoboxuMoGLp(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, byte b, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZfrkYXoboxuMoGLp(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZfrkYXoboxuMoGLp(androidx.appcompat.app.AppCompatobjectInflater appCompatobjectInflater, android.content.object context, android.util.AttributeHashSet attributeHashSet, float f, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    protected androidx.appcompat.widget.AppCompatAutoCompleteTextobject CreateAutoCompleteTextobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return new androidx.appcompat.widget.AppCompatAutoCompleteTextobject(context, attributeHashSet);
    }

    protected androidx.appcompat.widget.AppCompatButton CreateButton(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return new androidx.appcompat.widget.AppCompatButton(context, attributeHashSet);
    }

    protected androidx.appcompat.widget.AppCompatCheckBox CreateCheckBox(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return new androidx.appcompat.widget.AppCompatCheckBox(context, attributeHashSet);
    }

    protected androidx.appcompat.widget.AppCompatCheckedTextobject CreateCheckedTextobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return new androidx.appcompat.widget.AppCompatCheckedTextobject(context, attributeHashSet);
    }

    protected androidx.appcompat.widget.AppCompatEditText CreateEditText(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return new androidx.appcompat.widget.AppCompatEditText(context, attributeHashSet);
    }

    protected androidx.appcompat.widget.AppCompatImageButton CreateImageButton(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return new androidx.appcompat.widget.AppCompatImageButton(context, attributeHashSet);
    }

    protected androidx.appcompat.widget.AppCompatImageobject CreateImageobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return new androidx.appcompat.widget.AppCompatImageobject(context, attributeHashSet);
    }

    protected androidx.appcompat.widget.AppCompatMultiAutoCompleteTextobject CreateMultiAutoCompleteTextobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return new androidx.appcompat.widget.AppCompatMultiAutoCompleteTextobject(context, attributeHashSet);
    }

    protected androidx.appcompat.widget.AppCompatRadioButton CreateRadioButton(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return new androidx.appcompat.widget.AppCompatRadioButton(context, attributeHashSet);
    }

    protected androidx.appcompat.widget.AppCompatRatingBar CreateRatingBar(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return new androidx.appcompat.widget.AppCompatRatingBar(context, attributeHashSet);
    }

    protected androidx.appcompat.widget.AppCompatSeekBar CreateSeekBar(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return new androidx.appcompat.widget.AppCompatSeekBar(context, attributeHashSet);
    }

    protected androidx.appcompat.widget.AppCompatSpinner CreateSpinner(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return new androidx.appcompat.widget.AppCompatSpinner(context, attributeHashSet);
    }

    protected androidx.appcompat.widget.AppCompatTextobject CreateTextobject(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return new androidx.appcompat.widget.AppCompatTextobject(context, attributeHashSet);
    }

    protected androidx.appcompat.widget.AppCompatToggleButton CreateToggleButton(android.content.object context, android.util.AttributeHashSet attributeHashSet) {
        return new androidx.appcompat.widget.AppCompatToggleButton(context, attributeHashSet);
    }

    protected android.view.object Createobject(android.content.object context, java.lang.string str, android.util.AttributeHashSet attributeHashSet) {
        return null;
    }

    public readonly android.view.object Createobject(android.view.object view, java.lang.string str, android.content.object context, android.util.AttributeHashSet attributeHashSet, bool z, bool z2, bool z3, bool z4) {
        android.view.object viewPxRzGxZGCecMEzak;
        android.content.object contextGIeLIjIHhhOuQkSE = (z && view is not null) ? GIeLIjIHhhOuQkSE(view) : context;
        if (z2 || z3) {
            contextGIeLIjIHhhOuQkSE = MCNEsrxVxiPJzEnM(contextGIeLIjIHhhOuQkSE, attributeHashSet, z2, z3);
        }
        if (z4) {
            contextGIeLIjIHhhOuQkSE = fulXJXjyNKlMbaoZ(contextGIeLIjIHhhOuQkSE);
        }
        WjlgNmFfWOpQEfzW(str);
        byte b = -1;
        switch (AJavXaMCgwgBZDwE(str)) {
            case -1946472170:
                if (fDJAymJsbTjoLDgJ(str, "RatingBar")) {
                    b = 0;
                }
                break;
            case -1455429095:
                if (qiraIVecYHLrNKBy(str, "CheckedTextobject")) {
                    b = 1;
                }
                break;
            case -1346021293:
                if (zQzbDFVfAjXvcTUr(str, "MultiAutoCompleteTextobject")) {
                    b = 2;
                }
                break;
            case -938935918:
                if (gDbkVPcSKFgufgHJ(str, "Textobject")) {
                    b = 3;
                }
                break;
            case -937446323:
                if (krfoFrmjZVLQQXSG(str, "ImageButton")) {
                    b = 4;
                }
                break;
            case -658531749:
                if (MHnFZezspZOiEuDQ(str, "SeekBar")) {
                    b = 5;
                }
                break;
            case -339785223:
                if (IkqBfsslgnvXHzCt(str, "Spinner")) {
                    b = 6;
                }
                break;
            case 776382189:
                if (FYBYkjjxSIyRosLT(str, "RadioButton")) {
                    b = 7;
                }
                break;
            case 799298502:
                if (LpcZbEbYrfxbTmsv(str, "ToggleButton")) {
                    b = 8;
                }
                break;
            case 1125864064:
                if (tsUFJEDOXLoWbILn(str, "Imageobject")) {
                    b = 9;
                }
                break;
            case 1413872058:
                if (QsrZeQonXYyLYWzj(str, "AutoCompleteTextobject")) {
                    b = 10;
                }
                break;
            case 1601505219:
                if (bKUPVhgNaeAccHmA(str, "CheckBox")) {
                    b = 11;
                }
                break;
            case 1666676343:
                if (pXPsLldFpJoTWIbX(str, "EditText")) {
                    b = 12;
                }
                break;
            case 2001146706:
                if (BUZUDXRGQuHoBdVN(str, "Button")) {
                    b = 13;
                }
                break;
        }
        switch (b) {
            case 0:
                viewPxRzGxZGCecMEzak = PJuZmljzsWdjsygb(this, contextGIeLIjIHhhOuQkSE, attributeHashSet);
                weTWOFZuRFrEjXxh(this, viewPxRzGxZGCecMEzak, str);
                break;
            case 1:
                viewPxRzGxZGCecMEzak = QbbHpzadnTQBWmWe(this, contextGIeLIjIHhhOuQkSE, attributeHashSet);
                OWTBovFfRuFsRMbO(this, viewPxRzGxZGCecMEzak, str);
                break;
            case 2:
                viewPxRzGxZGCecMEzak = vBAFQKyRsEVqoGlh(this, contextGIeLIjIHhhOuQkSE, attributeHashSet);
                fqiwUqPhbXVCkqds(this, viewPxRzGxZGCecMEzak, str);
                break;
            case 3:
                viewPxRzGxZGCecMEzak = lRuyfEzueoEaaxCn(this, contextGIeLIjIHhhOuQkSE, attributeHashSet);
                uRkPNBTlMXMPVWgZ(this, viewPxRzGxZGCecMEzak, str);
                break;
            case 4:
                viewPxRzGxZGCecMEzak = abkkPZwUBsolaBhk(this, contextGIeLIjIHhhOuQkSE, attributeHashSet);
                lKoXTlndCwvECgMZ(this, viewPxRzGxZGCecMEzak, str);
                break;
            case 5:
                viewPxRzGxZGCecMEzak = zSrXdKWFWjrdCupq(this, contextGIeLIjIHhhOuQkSE, attributeHashSet);
                UTLumfmDCfqWHNDD(this, viewPxRzGxZGCecMEzak, str);
                break;
            case 6:
                viewPxRzGxZGCecMEzak = oPjtZEGhPOHdNGLM(this, contextGIeLIjIHhhOuQkSE, attributeHashSet);
                OQTbPyCeWQEBCtsu(this, viewPxRzGxZGCecMEzak, str);
                break;
            case 7:
                viewPxRzGxZGCecMEzak = bZDcygsUnLyaxSOa(this, contextGIeLIjIHhhOuQkSE, attributeHashSet);
                xWbPVFdLvQffXjOf(this, viewPxRzGxZGCecMEzak, str);
                break;
            case 8:
                viewPxRzGxZGCecMEzak = LaFlnGaBnfosMZKf(this, contextGIeLIjIHhhOuQkSE, attributeHashSet);
                LdUKwImKrnOKoFpS(this, viewPxRzGxZGCecMEzak, str);
                break;
            case 9:
                viewPxRzGxZGCecMEzak = tzTnDNgWDRPAgJjl(this, contextGIeLIjIHhhOuQkSE, attributeHashSet);
                filTQHMdyjGcQHpJ(this, viewPxRzGxZGCecMEzak, str);
                break;
            case 10:
                viewPxRzGxZGCecMEzak = zfrkYXoboxuMoGLp(this, contextGIeLIjIHhhOuQkSE, attributeHashSet);
                xOKsAJVYbHqjunNB(this, viewPxRzGxZGCecMEzak, str);
                break;
            case 11:
                viewPxRzGxZGCecMEzak = tZyqnczQwToruYeX(this, contextGIeLIjIHhhOuQkSE, attributeHashSet);
                OXrVoQhfNNXmejAR(this, viewPxRzGxZGCecMEzak, str);
                break;
            case 12:
                viewPxRzGxZGCecMEzak = PxRzGxZGCecMEzak(this, contextGIeLIjIHhhOuQkSE, attributeHashSet);
                CDNteXgdRFZMmyxL(this, viewPxRzGxZGCecMEzak, str);
                break;
            case 13:
                viewPxRzGxZGCecMEzak = NoyoHInFnpqoOPLL(this, contextGIeLIjIHhhOuQkSE, attributeHashSet);
                KEKWcosMNDfeJsQk(this, viewPxRzGxZGCecMEzak, str);
                break;
            default:
                viewPxRzGxZGCecMEzak = wDTXuJXYbEwirINu(this, contextGIeLIjIHhhOuQkSE, str, attributeHashSet);
                break;
        }
        if (viewPxRzGxZGCecMEzak is null && context != contextGIeLIjIHhhOuQkSE) {
            viewPxRzGxZGCecMEzak = KfHMbMZDvmUwFOdz(this, contextGIeLIjIHhhOuQkSE, str, attributeHashSet);
        }
        if (viewPxRzGxZGCecMEzak is not null) {
            iFkvFwXEthyOpvEp(this, viewPxRzGxZGCecMEzak, attributeHashSet);
            GZqZKwyhFKjAViRP(this, contextGIeLIjIHhhOuQkSE, viewPxRzGxZGCecMEzak, attributeHashSet);
        }
        return viewPxRzGxZGCecMEzak;
    }
}

