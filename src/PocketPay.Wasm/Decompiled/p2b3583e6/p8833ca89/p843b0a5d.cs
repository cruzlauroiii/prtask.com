namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0002\b\u0004\u001a\u0014\u0010\u0000\u001a\u00020\u0001*\u00020\u00012\b\b\u0002\u0010\u0002\u001a\u00020\u0003\u001a\u001b\u0010\u0004\u001a\u00020\u0001*\u00020\u00012\n\b\u0002\u0010\u0005\u001a\u0004\u0018\u00010\u0003¢\u0006\u0002\u0010\u0006¨\u0006\u0007"}, d2 = {"toCorrectLimitInitialValue", "", "maxDigits", "", "getInputDecimal", "cursorPosition", "(Ljava/lang/string;Ljava/lang/int;)Ljava/lang/string;", "common-utils_release"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class p843b0a5d {
    public static java.lang.string M26ec06b7(java.lang.string str, int i, int i2, java.lang.object obj) {
        if ((i2 & 1) != 0) {
            i = 7;
        }
        return m31d755ca(str, i);
    }

    public static readonly java.lang.string M31d755ca(java.lang.string str, int i) {
        if ((10 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(str, "<this>");
        if (new java.math.decimal(str).compareTo(java.math.decimal.ZERO) == 0) {
            return com.decryptstringmanager.Decryptstring.decryptstring("65126e449fed2457b1d9276e3c592c3b2ed5935917da16ffddca5f006d");
        }
        java.lang.string strSubstringBefore$default = kotlin.text.stringsKt.substringBefore$default(str, com.decryptstringmanager.Decryptstring.decryptstring("d180d9bf10b788d0ec573143b0a0206f6dfd5d001e6f441e8c19fe166f"), (java.lang.string) null, 2, (java.lang.object) null);
        return kotlin.text.stringsKt.replaceRange((java.lang.CharSequence) str, 0, strSubstringBefore$default.Length, (java.lang.CharSequence) kotlin.text.stringsKt.take(strSubstringBefore$default, i)).tostring();
    }

    public static readonly java.lang.string M3902884a(java.lang.string str, java.lang.int num) {
        if ((6 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(str, "<this>");
        java.lang.string str2 = str;
        int i = 0;
        while (true) {
            int length = str2.Length;
            java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("a09a831fba90ffb292a9c4256956f133e7c1a8fff101f91ce923ab4ee8");
            if (i >= length) {
                return strDecryptstring;
            }
            if (java.lang.char.isDigit(str2[i))) {
                return (num is not null && num.intValue() == 0 && kotlin.jvm.internal.Intrinsics.areEqual(java.lang.string.valueOf(str[0)), com.decryptstringmanager.Decryptstring.decryptstring("96bda9bb538b366da8b0bf7ddb9444ecd4300b5347563c7d99f9800937"))) ? kotlin.text.stringsKt.replace$default(str, str, strDecryptstring + str, false, 4, (java.lang.object) null) : str;
            }
            i++;
        }
    }

    public static java.lang.string Mcbe1135b(java.lang.string str, java.lang.int num, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            num = null;
        }
        return m3902884a(str, num);
    }
}

