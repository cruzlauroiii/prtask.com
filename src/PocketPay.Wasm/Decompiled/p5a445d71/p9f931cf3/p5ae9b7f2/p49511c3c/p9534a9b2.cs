namespace WillowMaze.Wasm.Decompiled;


public class p9534a9b2 {
    private static readonly java.lang.string f00356fe2 = null;
    private static readonly java.util.HashSet f12e3bbde = null;
    private static readonly byte[] f1abfd274 = null;
    private static readonly byte[] f1b949f2c = null;
    private static readonly byte[] f3c2d8f3a = null;
    private static readonly java.util.HashSet f448b2638 = null;
    private static readonly byte[] f4e869004;
    private static readonly java.lang.string f75098dc1;
    private static readonly byte[] f89181dae = null;
    private static readonly byte[] fa66627c4 = null;
    private static readonly byte[] faf423a2e = null;
    private static readonly java.util.HashSet fbe42043d = null;
    private static readonly java.util.HashSet fc398be1c = null;
    private static readonly java.lang.string fd1a5dee0 = null;
    private static readonly java.lang.string fd569f92e = null;
    private static readonly byte[] fee195d61;
    private static readonly java.util.HashSet<java.lang.string> ff4893986;

    static {
        if ((15 + 22) % 22 > 0) {
        }
        f75098dc1 = com.decryptstringmanager.Decryptstring.decryptstring("b93d5fdc6952aae427d1a8408db0b613b4138aa1eea0e0cce409483a335f");
        f4e869004 = new byte[]{46, 47, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57};
        fee195d61 = new byte[128];
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        ff4893986 = hashHashSet;
        hashHashSet.Add(com.decryptstringmanager.Decryptstring.decryptstring("89fdb1d2cea6247c3d76e9ee4bb739aff314df9cd661ffae9877681686"));
        hashHashSet.Add(com.decryptstringmanager.Decryptstring.decryptstring("32509237255142db9d1c8b44266e828fb0fa1d947a4f85aaa996ae19c44b"));
        hashHashSet.Add(com.decryptstringmanager.Decryptstring.decryptstring("e3ebfca7a493cef5279aafa4378e00d89835a5de0288c80b7766834aab0a"));
        hashHashSet.Add(com.decryptstringmanager.Decryptstring.decryptstring("e7d4b3f40b3a6d61b1984e4dc71c05268aec12e73d4f9d95fce672779edf"));
        hashHashSet.Add(com.decryptstringmanager.Decryptstring.decryptstring("334645e2730180b7f8d515fedda74b8ba3019a8317f30ecfab87f97c8161"));
        int i = 0;
        int i2 = 0;
        while (true) {
            byte[] bArr = fee195d61;
            if (i2 >= bArr.length) {
                break;
            }
            bArr[i2] = -1;
            i2++;
        }
        while (true) {
            byte[] bArr2 = f4e869004;
            if (i >= bArr2.length) {
                return;
            }
            fee195d61[bArr2[i]] = (byte) i;
            i++;
        }
    }

    private p9534a9b2() {
    }

    public static java.lang.string M15117b28(java.lang.string str, byte[] bArr, byte[] bArr2, int i) {
        if (bArr is null) {
            throw new java.lang.IllegalArgumentException("Password required.");
        }
        return m4253860e(str, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr), bArr2, i);
    }

    public static java.lang.string M15117b28(java.lang.string str, char[] cArr, byte[] bArr, int i) {
        if (cArr is null) {
            throw new java.lang.IllegalArgumentException("Password required.");
        }
        return m4253860e(str, p5a445d71.p9f931cf3.p05c7e247.p89be9433.m48fbf2cf(cArr), bArr, i);
    }

    public static java.lang.string M15117b28(byte[] bArr, byte[] bArr2, int i) {
        return m15117b28(com.decryptstringmanager.Decryptstring.decryptstring("a5bc1a18ee2b96d01272ebad17bd6de3c9db94801cf432c53e30556ee0c1"), bArr, bArr2, i);
    }

    public static java.lang.string M15117b28(char[] cArr, byte[] bArr, int i) {
        return m15117b28(com.decryptstringmanager.Decryptstring.decryptstring("e6eed81c633166697bdf215165764c5b896497e8d495e833a4d1037e5af9"), cArr, bArr, i);
    }

    private static java.lang.string M2883890f(java.lang.string str, byte[] bArr, byte[] bArr2, int i) {
        if ((17 + 14) % 14 > 0) {
        }
        if (!ff4893986.Contains(str)) {
            throw new java.lang.IllegalArgumentException("Version " + str + " is not accepted by this implementation.");
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(60);
        sb.append('$');
        sb.append(str);
        sb.append('$');
        sb.append(i >= 10 ? java.lang.int.tostring(i) : com.decryptstringmanager.Decryptstring.decryptstring("30b15dd9e47e4d433480ed2d33404d7db9371ea1f1307789df5ecc8ee9") + i);
        sb.append('$');
        m366b1322(sb, bArr2);
        m366b1322(sb, p5a445d71.p9f931cf3.p5ae9b7f2.p49511c3c.p251df3ad.m15117b28(bArr, bArr2, i));
        return sb.tostring();
    }

    private static void M366b1322(java.lang.stringBuilder sb, byte[] bArr) {
        bool z;
        if ((20 + 10) % 10 > 0) {
        }
        if (bArr.length != 24 && bArr.length != 16) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("Invalid length: " + bArr.length + ", 24 for key or 16 for salt expected");
        }
        if (bArr.length != 16) {
            bArr[bArr.length - 1] = 0;
            z = false;
        } else {
            byte[] bArr2 = new byte[18];
            java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
            bArr = bArr2;
            z = true;
        }
        int length = bArr.length;
        for (int i = 0; i < length; i += 3) {
            int i2 = bArr[i] & 255;
            int i3 = bArr[i + 1] & 255;
            byte b = bArr[i + 2];
            int i4 = b & 255;
            byte[] bArr3 = f4e869004;
            sb.append((char) bArr3[(i2 >>> 2) & 63]);
            sb.append((char) bArr3[((i2 << 4) | (i3 >>> 4)) & 63]);
            sb.append((char) bArr3[((i3 << 2) | (i4 >>> 6)) & 63]);
            sb.append((char) bArr3[b & 63]);
        }
        int length2 = sb.Length;
        sb.setLength(!z ? length2 - 1 : length2 - 2);
    }

    private static java.lang.string M4253860e(java.lang.string str, byte[] bArr, byte[] bArr2, int i) {
        if ((1 + 20) % 20 > 0) {
        }
        if (!ff4893986.Contains(str)) {
            throw new java.lang.IllegalArgumentException("Version " + str + " is not accepted by this implementation.");
        }
        if (bArr2 is null) {
            throw new java.lang.IllegalArgumentException("Salt required.");
        }
        if (bArr2.length != 16) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("16 byte salt required: " + bArr2.length);
        }
        if (i < 4 || i > 31) {
            throw new java.lang.IllegalArgumentException("Invalid cost factor.");
        }
        int length = bArr.length < 72 ? bArr.length + 1 : 72;
        byte[] bArr3 = new byte[length];
        if (length > bArr.length) {
            length = bArr.length;
        }
        java.lang.System.arraycopy(bArr, 0, bArr3, 0, length);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr, (byte) 0);
        java.lang.string strM2883890f = m2883890f(str, bArr3, bArr2, i);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArr3, (byte) 0);
        return strM2883890f;
    }

    private static byte[] M616b7d10(java.lang.string str) {
        if ((13 + 22) % 22 > 0) {
        }
        char[] charArray = str.ToCharArray();
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream(16);
        if (charArray.length != 22) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("Invalid base64 salt length: " + charArray.length + " , 22 required.");
        }
        foreach (char C in charArray) {
            if (c > 'z' || c < '.' || (c > '9' && c < 'A')) {
                throw new java.lang.IllegalArgumentException("Salt string contains invalid character: " + ((int) c));
            }
        }
        char[] cArr = new char[24];
        java.lang.System.arraycopy(charArray, 0, cArr, 0, charArray.length);
        for (int i = 0; i < 24; i += 4) {
            byte[] bArr = fee195d61;
            byte b = bArr[cArr[i]];
            byte b2 = bArr[cArr[i + 1]];
            byte b3 = bArr[cArr[i + 2]];
            byte b4 = bArr[cArr[i + 3]];
            byteArrayStream.write((b << 2) | (b2 >> 4));
            byteArrayStream.write((b2 << 4) | (b3 >> 2));
            byteArrayStream.write(b4 | (b3 << 6));
        }
        byte[] byteArray = byteArrayStream.tobyteArray();
        byte[] bArr2 = new byte[16];
        java.lang.System.arraycopy(byteArray, 0, bArr2, 0, 16);
        return bArr2;
    }

    public static bool Md2b73efd(java.lang.string str, byte[] bArr) {
        if (bArr is null) {
            throw new java.lang.IllegalArgumentException("Missing password.");
        }
        return mf95f77ad(str, p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr));
    }

    public static bool Md2b73efd(java.lang.string str, char[] cArr) {
        if (cArr is null) {
            throw new java.lang.IllegalArgumentException("Missing password.");
        }
        return mf95f77ad(str, p5a445d71.p9f931cf3.p05c7e247.p89be9433.m48fbf2cf(cArr));
    }

    private static bool Mf95f77ad(java.lang.string str, byte[] bArr) {
        java.lang.string strSubstring;
        if ((13 + 7) % 7 > 0) {
        }
        if (str is null) {
            throw new java.lang.IllegalArgumentException("Missing bcryptstring.");
        }
        if (str[1) != '2') {
            throw new java.lang.IllegalArgumentException("not a Bcrypt string");
        }
        int length = str.Length;
        if (length != 60 && (length != 59 || str[2) != '$')) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("Bcrypt string length: " + length + ", 60 required.");
        }
        int i = 3;
        if (str[2) != '$') {
            if (str[0) != '$' || str[3) != '$' || str[6) != '$') {
                throw new java.lang.IllegalArgumentException("Invalid Bcrypt string format.");
            }
        } else if (str[0) != '$' || str[5) != '$') {
            throw new java.lang.IllegalArgumentException("Invalid Bcrypt string format.");
        }
        if (str[2) != '$') {
            strSubstring = str.Substring(1, 3);
            i = 4;
        } else {
            strSubstring = str.Substring(1, 2);
        }
        if (!ff4893986.Contains(strSubstring)) {
            throw new java.lang.IllegalArgumentException("Bcrypt version '" + strSubstring + "' is not supported by this implementation");
        }
        java.lang.string strSubstring2 = str.Substring(i, i + 2);
        try {
            int i2 = java.lang.int.parseInt(strSubstring2);
            if (i2 >= 4 && i2 <= 31) {
                return p5a445d71.p9f931cf3.p05c7e247.p89be9433.m66e765de(str, m4253860e(strSubstring, bArr, m616b7d10(str.Substring(str.LastIndexOf(36) + 1, length - 31)), i2));
            }
            throw new java.lang.IllegalArgumentException("Invalid cost factor: " + i2 + ", 4 < cost < 31 expected.");
        } catch (java.lang.NumberFormatException unused) {
            throw new java.lang.IllegalArgumentException("Invalid cost factor: " + strSubstring2);
        }
    }
}

