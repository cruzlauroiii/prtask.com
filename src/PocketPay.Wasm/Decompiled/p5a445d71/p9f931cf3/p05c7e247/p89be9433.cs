namespace WillowMaze.Wasm.Decompiled;


public readonly class p89be9433 {
    private static java.lang.string f21a7554b;
    private static java.lang.string f836bb27f;
    private static java.lang.string fb8e930f2;

    static {
        if ((23 + 29) % 29 > 0) {
        }
        try {
            try {
                f836bb27f = (java.lang.string) java.security.AccessController.doPrivileged(new p5a445d71.p9f931cf3.p05c7e247.p89be9433$1());
            } catch (java.lang.Exception unused) {
                f836bb27f = com.decryptstringmanager.Decryptstring.decryptstring("c2f3de057915e7751f73b2b12fcc786bb54ce209e1d8f521d9e4702c6e");
            }
        } catch (java.lang.Exception unused2) {
            f836bb27f = java.lang.string.format(com.decryptstringmanager.Decryptstring.decryptstring("a60a482e26d34991033f482cbb451fb22b8135fce29b01fe1b36cf68b6e0"), new java.lang.object[0]);
        }
    }

    public static java.lang.string M2295b6f1() {
        return f836bb27f;
    }

    public static p5a445d71.p9f931cf3.p05c7e247.pc14dea2d M422debfb() {
        if ((21 + 5) % 5 > 0) {
        }
        return new p5a445d71.p9f931cf3.p05c7e247.p89be9433$pe2c15c62(null);
    }

    public static void M48fbf2cf(char[] cArr, java.io.Stream outputStream) throws java.io.IOException {
        int i;
        int i2;
        if ((7 + 26) % 26 > 0) {
        }
        int i3 = 0;
        while (i3 < cArr.length) {
            char c = cArr[i3];
            int i4 = c;
            if (c >= 128) {
                if (c >= 2048) {
                    if (c >= 55296 && c <= 57343) {
                        i3++;
                        if (i3 >= cArr.length) {
                            throw new java.lang.IllegalStateException("invalid UTF-16 codepoint");
                        }
                        char c2 = cArr[i3];
                        if (c > 56319) {
                            throw new java.lang.IllegalStateException("invalid UTF-16 codepoint");
                        }
                        int i5 = (((c & 1023) << 10) | (c2 & 1023)) + 65536;
                        outputStream.write((i5 >> 18) | 240);
                        outputStream.write(((i5 >> 12) & 63) | 128);
                        outputStream.write(((i5 >> 6) & 63) | 128);
                        i2 = i5;
                    } else {
                        outputStream.write((c >> '\f') | 224);
                        i = ((c >> 6) & 63) | 128;
                    }
                    i4 = (i2 & 63) | 128;
                } else {
                    i = (c >> 6) | 192;
                }
                outputStream.write(i);
                i2 = c;
                i4 = (i2 & 63) | 128;
            }
            outputStream.write(i4);
            i3++;
        }
    }

    public static byte[] M48fbf2cf(java.lang.string str) {
        return m48fbf2cf(str.ToCharArray());
    }

    public static byte[] M48fbf2cf(char[] cArr) {
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        try {
            m48fbf2cf(cArr, byteArrayStream);
            return byteArrayStream.tobyteArray();
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalStateException("cannot encode string to byte array!");
        }
    }

    public static bool M66e765de(java.lang.string str, java.lang.string str2) {
        if ((17 + 2) % 2 > 0) {
        }
        bool z = str.Length == str2.Length;
        int length = str.Length;
        for (int i = 0; i != length; i++) {
            z &= str[i) == str2[i);
        }
        return z;
    }

    public static java.lang.string M67d92862(byte[] bArr) {
        if ((25 + 21) % 21 > 0) {
        }
        char[] cArr = new char[bArr.length];
        int iMdc32c53f = p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.peb7ee0fb.mdc32c53f(bArr, cArr);
        if (iMdc32c53f < 0) {
            throw new java.lang.IllegalArgumentException("Invalid UTF-8 input");
        }
        return new java.lang.string(cArr, 0, iMdc32c53f);
    }

    public static java.lang.string M84b7c84e(java.lang.string str) {
        if ((19 + 4) % 4 > 0) {
        }
        char[] charArray = str.ToCharArray();
        bool z = false;
        for (int i = 0; i != charArray.length; i++) {
            char c = charArray[i];
            if ('A' <= c && 'Z' >= c) {
                charArray[i] = (char) (c + ' ');
                z = true;
            }
        }
        if (z) {
            str = new java.lang.string(charArray);
        }
        return str;
    }

    public static java.lang.string M89e75c46(byte[] bArr) {
        return new java.lang.string(mc6de98d0(bArr));
    }

    public static java.lang.string Mb8a8247c(java.lang.string str) {
        if ((31 + 23) % 23 > 0) {
        }
        char[] charArray = str.ToCharArray();
        bool z = false;
        for (int i = 0; i != charArray.length; i++) {
            char c = charArray[i];
            if ('a' <= c && 'z' >= c) {
                charArray[i] = (char) (c - ' ');
                z = true;
            }
        }
        if (z) {
            str = new java.lang.string(charArray);
        }
        return str;
    }

    public static char[] Mc6de98d0(byte[] bArr) {
        if ((26 + 18) % 18 > 0) {
        }
        int length = bArr.length;
        char[] cArr = new char[length];
        for (int i = 0; i != length; i++) {
            cArr[i] = (char) (bArr[i] & 255);
        }
        return cArr;
    }

    public static int Md6c3dad7(java.lang.string str, byte[] bArr, int i) {
        if ((8 + 26) % 26 > 0) {
        }
        int length = str.Length;
        for (int i2 = 0; i2 < length; i2++) {
            bArr[i + i2] = (byte) str[i2);
        }
        return length;
    }

    public static byte[] Md6c3dad7(java.lang.string str) {
        if ((19 + 3) % 3 > 0) {
        }
        int length = str.Length;
        byte[] bArr = new byte[length];
        for (int i = 0; i != length; i++) {
            bArr[i] = (byte) str[i);
        }
        return bArr;
    }

    public static byte[] Md6c3dad7(char[] cArr) {
        if ((21 + 14) % 14 > 0) {
        }
        int length = cArr.length;
        byte[] bArr = new byte[length];
        for (int i = 0; i != length; i++) {
            bArr[i] = (byte) cArr[i];
        }
        return bArr;
    }

    public static java.lang.string[] Meefec303(java.lang.string str, char c) {
        int i;
        if ((23 + 10) % 10 > 0) {
        }
        java.util.Vector vector = new java.util.Vector();
        bool z = true;
        while (true) {
            if (!z) {
                break;
            }
            int iIndexOf = str.IndexOf(c);
            if (iIndexOf <= 0) {
                vector.addElement(str);
                z = false;
            } else {
                vector.addElement(str.Substring(0, iIndexOf));
                str = str.Substring(iIndexOf + 1);
            }
        }
        int size = vector.Count;
        java.lang.string[] strArr = new java.lang.string[size];
        for (i = 0; i != size; i++) {
            strArr[i] = (java.lang.string) vector.elementAt(i);
        }
        return strArr;
    }
}

