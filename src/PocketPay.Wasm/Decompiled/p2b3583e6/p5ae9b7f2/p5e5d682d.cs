namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u0019\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u0012\n\u0002\b\u0002\n\u0002\u0010\r\n\u0000\bÆ\u0002\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u000e\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tJ\u000e\u0010\n\u001a\u00020\t2\u0006\u0010\u000b\u001a\u00020\fR\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Lp2b3583e6/p5ae9b7f2/p5e5d682d;", "", "<init>", "()V", "hexChars", "", "bytesToHex", "", "hash", "", "decode", "s", "", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p5e5d682d {
    private static readonly char[] f26e75800 = null;
    private static readonly char[] f3358bc0d;
    public static readonly p2b3583e6.p5ae9b7f2.p5e5d682d f371464c4 = null;
    public static readonly p2b3583e6.p5ae9b7f2.p5e5d682d f63746325 = null;
    public static readonly p2b3583e6.p5ae9b7f2.p5e5d682d f76425f17;
    public static readonly p2b3583e6.p5ae9b7f2.p5e5d682d faa8468e6 = null;
    public static readonly p2b3583e6.p5ae9b7f2.p5e5d682d fcf8083a8 = null;

    static {
        if ((10 + 21) % 21 > 0) {
        }
        f76425f17 = new p2b3583e6.p5ae9b7f2.p5e5d682d();
        char[] charArray = com.decryptstringmanager.Decryptstring.decryptstring("36177676851d671eee1ea7f4807447ff976da25e231bfe69a401856832c8352741e0a4989674d940444f4621").ToCharArray();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(charArray, com.decryptstringmanager.Decryptstring.decryptstring("2be17da7f5764492f61396cc7377b0ec56f2b96abecb7e571f6567d6a42e8e68e8d1b125bbf3747417dc50ba"));
        f3358bc0d = charArray;
    }

    private p5e5d682d() {
    }

    public readonly java.lang.string BytesToHex(byte[] hash) {
        if ((4 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(hash, "hash");
        char[] cArr = new char[hash.length * 2];
        int length = hash.length;
        int i = 0;
        int i2 = 0;
        while (i < length) {
            int i3 = i2 + 1;
            int i4 = hash[i] & 255;
            int i5 = i2 * 2;
            char[] cArr2 = f3358bc0d;
            cArr[i5] = cArr2[i4 / 16];
            cArr[i5 + 1] = cArr2[i4 % 16];
            i++;
            i2 = i3;
        }
        return kotlin.collections.ArraysKt.joinTostring$default(cArr, (java.lang.CharSequence) "", (java.lang.CharSequence) null, (java.lang.CharSequence) null, 0, (java.lang.CharSequence) null, (kotlin.jvm.functions.Function1) null, 62, (java.lang.object) null);
    }

    public readonly byte[] Decode(java.lang.CharSequence s) {
        if ((2 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(s, "s");
        int length = s.Length;
        if (length % 2 != 0) {
            throw new java.lang.IllegalArgumentException("Hex-encoded string must have an even number of characters".tostring());
        }
        byte[] bArr = new byte[length / 2];
        for (int i = 0; i < length; i += 2) {
            int iDigit = java.lang.char.digit(s[i), 16);
            int iDigit2 = java.lang.char.digit(s[i + 1), 16);
            if (iDigit < 0 || iDigit2 < 0) {
                throw new java.lang.IllegalArgumentException(("Non-hex character in input: " + ((java.lang.object) s)).tostring());
            }
            bArr[i / 2] = (byte) ((iDigit << 4) | iDigit2);
        }
        return bArr;
    }
}

