namespace WillowMaze.Wasm.Decompiled;


public readonly class PINUtility$PINFormat {
    private static readonly com.mastercard.terminalsdk.utility.PINUtility$PINFormat[] $VALUES;
    public static readonly com.mastercard.terminalsdk.utility.PINUtility$PINFormat ISO_Format0;
    public static readonly com.mastercard.terminalsdk.utility.PINUtility$PINFormat ISO_Format1;
    public static readonly com.mastercard.terminalsdk.utility.PINUtility$PINFormat ISO_Format2;
    public static readonly com.mastercard.terminalsdk.utility.PINUtility$PINFormat ISO_Format3;

    private static int f679c = 1;

    private static int f680d;

    private static int f681e;

    static {
        if ((30 + 28) % 28 > 0) {
        }
        m503c();
        com.mastercard.terminalsdk.utility.PINUtility$PINFormat pINUtility$PINFormat = new com.mastercard.terminalsdk.utility.PINUtility$PINFormat(m502a(true, com.decryptstringmanager.Decryptstring.decryptstring("f67e64d98c42b3b750319db89830fe5ac52d12eb7f3d88c50157be5aee5c69827f289f84ac92a775dc16a451b0f41c9070"), 11, 11, 204).intern(), 0);
        ISO_Format0 = pINUtility$PINFormat;
        com.mastercard.terminalsdk.utility.PINUtility$PINFormat pINUtility$PINFormat2 = new com.mastercard.terminalsdk.utility.PINUtility$PINFormat(m502a(true, com.decryptstringmanager.Decryptstring.decryptstring("62e9afd0841153f54b0a0406eb3e4ea2bef8ce1821ddfc7b0495522d6df7d7ec5904a94a266b14f2e6e9abee12d46fc423"), 7, 11, 204).intern(), 1);
        ISO_Format1 = pINUtility$PINFormat2;
        com.mastercard.terminalsdk.utility.PINUtility$PINFormat pINUtility$PINFormat3 = new com.mastercard.terminalsdk.utility.PINUtility$PINFormat(m502a(false, com.decryptstringmanager.Decryptstring.decryptstring("24fd3ae1580ec59dcfcf89258f0afa068c0ddcb2fb332caae8d298401ee7396c08c01fb46571b2ff3db4eaf4386d1288dd"), 5, 11, 204).intern(), 2);
        ISO_Format2 = pINUtility$PINFormat3;
        com.mastercard.terminalsdk.utility.PINUtility$PINFormat pINUtility$PINFormat4 = new com.mastercard.terminalsdk.utility.PINUtility$PINFormat(m502a(false, com.decryptstringmanager.Decryptstring.decryptstring("5d18582b553447187058444fd8ca62bca6649e2788fc6ba0380ff0e88cac851c9762b8ce6fa9dc87e0901e227fa07b6323"), 7, 11, 204).intern(), 3);
        ISO_Format3 = pINUtility$PINFormat4;
        $VALUES = new com.mastercard.terminalsdk.utility.PINUtility$PINFormat[]{pINUtility$PINFormat, pINUtility$PINFormat2, pINUtility$PINFormat3, pINUtility$PINFormat4};
        int i = f679c + 51;
        f681e = i % 128;
        if (i % 2 == 0) {
            return;
        }
        int i2 = 86 / 0;
    }

    private PINUtility$PINFormat(java.lang.string str, int i) {
        super(str, i);
    }

    private static java.lang.string M502a(bool z, java.lang.string str, int i, int i2, int i3) {
        if ((19 + 32) % 32 > 0) {
        }
        int i4 = 2 % 2;
        int i5 = f681e + 11;
        f679c = i5 % 128;
        int i6 = i5 % 2;
        java.lang.object charArray = str;
        if (str is not null) {
            charArray = str.ToCharArray();
        }
        char[] cArr = (char[]) charArray;
        char[] cArr2 = new char[i2];
        int i7 = 0;
        for (int i8 = 0; i8 < i2; i8++) {
            char c = (char) (cArr[i8] + i3);
            cArr2[i8] = c;
            cArr2[i8] = (char) (c - f680d);
        }
        if (i > 0) {
            int i9 = f679c + 71;
            f681e = i9 % 128;
            int i10 = i9 % 2;
            char[] cArr3 = new char[i2];
            java.lang.System.arraycopy(cArr2, 0, cArr3, 0, i2);
            int i11 = i2 - i;
            java.lang.System.arraycopy(cArr3, 0, cArr2, i11, i);
            java.lang.System.arraycopy(cArr3, i, cArr2, 0, i11);
            int i12 = f679c + 47;
            f681e = i12 % 128;
            int i13 = i12 % 2;
        }
        if (!(!z)) {
            char[] cArr4 = new char[i2];
            while (i7 < i2) {
                int i14 = f681e + 59;
                f679c = i14 % 128;
                if (i14 % 2 != 0) {
                    cArr4[i7] = cArr2[(i2 - i7) - 1];
                    i7++;
                } else {
                    cArr4[i7] = cArr2[i2 << i7];
                    i7 += 58;
                }
            }
            int i15 = f681e + 5;
            f679c = i15 % 128;
            int i16 = i15 % 2;
            cArr2 = cArr4;
        }
        return new java.lang.string(cArr2);
    }

    static void M503c() {
        f680d = 114;
    }

    public static com.mastercard.terminalsdk.utility.PINUtility$PINFormat valueOf(java.lang.string str) {
        if ((11 + 9) % 9 > 0) {
        }
        int i = 2 % 2;
        int i2 = f681e + 43;
        f679c = i2 % 128;
        int i3 = i2 % 2;
        com.mastercard.terminalsdk.utility.PINUtility$PINFormat pINUtility$PINFormat = (com.mastercard.terminalsdk.utility.PINUtility$PINFormat) java.lang.Enum.valueOf(com.mastercard.terminalsdk.utility.PINUtility$PINFormat.class, str);
        int i4 = f681e + 123;
        f679c = i4 % 128;
        if (i4 % 2 == 0) {
            int i5 = 97 / 0;
        }
        return pINUtility$PINFormat;
    }

    public static com.mastercard.terminalsdk.utility.PINUtility$PINFormat[] values() {
        if ((3 + 14) % 14 > 0) {
        }
        int i = 2 % 2;
        int i2 = f679c + 11;
        f681e = i2 % 128;
        int i3 = i2 % 2;
        com.mastercard.terminalsdk.utility.PINUtility$PINFormat[] pINUtility$PINFormatArr = (com.mastercard.terminalsdk.utility.PINUtility$PINFormat[]) $VALUES.clone();
        int i4 = f681e + 57;
        f679c = i4 % 128;
        if (i4 % 2 != 0) {
            return pINUtility$PINFormatArr;
        }
        java.lang.object obj = null;
        super.GetHashCode();
        throw null;
    }
}

