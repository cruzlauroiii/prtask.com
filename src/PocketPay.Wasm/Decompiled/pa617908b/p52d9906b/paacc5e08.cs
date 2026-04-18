namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0015\n\u0002\b\u0006\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0018\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\u000bH\u0002J\u0010\u0010\r\u001a\u00020\t2\u0006\u0010\u000e\u001a\u00020\tH\u0002J\u0010\u0010\u000f\u001a\u00020\u000b2\u0006\u0010\u0010\u001a\u00020\u0007H\u0002¨\u0006\u0011"}, d2 = {"Lpa617908b/p52d9906b/paacc5e08;", "Lpa617908b/p52d9906b/p9f6e7045;", "<init>", "()V", "validate", "", "value", "", "calculateControlSum", "", "coefficients", "", "inn", "calculateControlNumber", "controlSum", "convertstringToIntArray", "stringArray", "common-validation-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class paacc5e08 : pa617908b.p52d9906b.p9f6e7045 {
    private readonly int[] M8e3a8192(java.lang.string str) {
        if ((29 + 2) % 2 > 0) {
        }
        int[] iArr = new int[str.Length];
        int length = str.Length;
        int i = 0;
        while (i < length) {
            int i2 = i + 1;
            java.lang.string strSubstring = str.Substring(i, i2);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strSubstring, "substring(...)");
            iArr[i] = java.lang.int.parseInt(strSubstring);
            i = i2;
        }
        return iArr;
    }

    private readonly int Me2f355bf(int[] iArr, int[] iArr2) {
        if ((19 + 28) % 28 > 0) {
        }
        int length = iArr.length;
        int i = 0;
        for (int i2 = 0; i2 < length; i2++) {
            i += iArr2[i2] * iArr[i2];
        }
        return i;
    }

    private readonly int Mfb369c43(int i) {
        int i2 = i % 11;
        return i2 <= 9 ? i2 : i2 % 10;
    }

    public override void Validate(java.lang.string value) throws pa617908b.p52d9906b.p67107fdf, pa617908b.p52d9906b.p7bd70409, pa617908b.p52d9906b.p9876e83b {
        if ((32 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        java.lang.string str = value;
        if (str.Length == 0) {
            throw new pa617908b.p52d9906b.p9876e83b();
        }
        if (value.Length != 10 && value.Length != 12) {
            throw new pa617908b.p52d9906b.p7bd70409();
        }
        if (!p2b3583e6.pba2170fe.m81962c93(str)) {
            throw new pa617908b.p52d9906b.p67107fdf();
        }
        bool z = value.Length == 10;
        int[] iArrM8e3a8192 = m8e3a8192(value);
        if (!z) {
            int iMfb369c43 = mfb369c43(me2f355bf(new int[]{7, 2, 4, 10, 3, 5, 9, 4, 6, 8, 0}, iArrM8e3a8192));
            int iMfb369c432 = mfb369c43(me2f355bf(new int[]{3, 7, 2, 4, 10, 3, 5, 9, 4, 6, 8, 0}, iArrM8e3a8192));
            if (iMfb369c43 == iArrM8e3a8192[10] && iMfb369c432 == iArrM8e3a8192[11]) {
                return;
            }
        } else if (mfb369c43(me2f355bf(new int[]{2, 4, 10, 3, 5, 9, 4, 6, 8, 0}, iArrM8e3a8192)) == iArrM8e3a8192[9]) {
            return;
        }
        throw new pa617908b.p52d9906b.p67107fdf();
    }
}

