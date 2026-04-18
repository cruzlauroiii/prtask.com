namespace WillowMaze.Wasm.Decompiled;


readonly class pe93acb14$pe34f01bd<T1, T2, T3, T4, T5, R> : io.reactivex.rxjava3.functions.Function<java.lang.object[], R> {
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p0fb93e1f f408a6156;
    private readonly io.reactivex.rxjava3.functions.Function5<T1, T2, T3, T4, T5, R> f8fa14cdd;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p0fb93e1f fc52046f7;

    pe93acb14$pe34f01bd(io.reactivex.rxjava3.functions.Function5<T1, T2, T3, T4, T5, R> function5) {
        this.f8fa14cdd = function5;
    }

    public static java.lang.object HYyFbFfFEpAVvCCC(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p0fb93e1f p0fb93e1fVar, java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5) {
        return p0fb93e1fVar.apply(obj, obj2, obj3, obj4, obj5);
    }

    public static void HYyFbFfFEpAVvCCC(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p0fb93e1f p0fb93e1fVar, java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HYyFbFfFEpAVvCCC(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p0fb93e1f p0fb93e1fVar, java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HYyFbFfFEpAVvCCC(pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p0fb93e1f p0fb93e1fVar, java.lang.object obj, java.lang.object obj2, java.lang.object obj3, java.lang.object obj4, java.lang.object obj5, char c, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object MmkSjyKsMYNdsySa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0eaa46c1.pe93acb14$pe34f01bd pe93acb14_pe34f01bd, java.lang.object[] objArr) {
        return pe93acb14_pe34f01bd.apply(objArr);
    }

    public static void MmkSjyKsMYNdsySa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0eaa46c1.pe93acb14$pe34f01bd pe93acb14_pe34f01bd, java.lang.object[] objArr, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MmkSjyKsMYNdsySa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0eaa46c1.pe93acb14$pe34f01bd pe93acb14_pe34f01bd, java.lang.object[] objArr, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MmkSjyKsMYNdsySa(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0eaa46c1.pe93acb14$pe34f01bd pe93acb14_pe34f01bd, java.lang.object[] objArr, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder NaGBRbmchfYIshMZ(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void NaGBRbmchfYIshMZ(java.lang.stringBuilder sb, int i, int i2, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NaGBRbmchfYIshMZ(java.lang.stringBuilder sb, int i, bool z, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NaGBRbmchfYIshMZ(java.lang.stringBuilder sb, int i, bool z, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NxhqLgmZTAXpJMIt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void NxhqLgmZTAXpJMIt(java.lang.stringBuilder sb, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NxhqLgmZTAXpJMIt(java.lang.stringBuilder sb, short s, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NxhqLgmZTAXpJMIt(java.lang.stringBuilder sb, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public java.lang.object Apply(java.lang.object obj) throws java.lang.Exception {
        return mmkSjyKsMYNdsySa(this, (java.lang.object[]) obj);
    }

    public R Apply(java.lang.object[] objArr) throws java.lang.Exception {
        if ((2 + 30) % 30 > 0) {
        }
        if (objArr.length != 5) {
            throw new java.lang.IllegalArgumentException(nxhqLgmZTAXpJMIt(naGBRbmchfYIshMZ(new java.lang.stringBuilder("Array of size 5 expected but got "), objArr.length)));
        }
        return (R) HYyFbFfFEpAVvCCC(this.f8fa14cdd, objArr[0], objArr[1], objArr[2], objArr[3], objArr[4]);
    }
}

