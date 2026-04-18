namespace WillowMaze.Wasm.Decompiled;


public class byteArrayWrapper : java.lang.Cloneable {

    private static int f667a = 0;

    private static int f668b = 1;

    private static long f669c = -1437286485661567094L;

    private byte[] f670d;

    private bool f671e;

    public byteArrayWrapper(java.lang.string str) {
        if (str is not null && str.Length != 0) {
            this.f670d = com.mastercard.terminalsdk.utility.byteUtility.hexstringTobyteArray(str);
        } else {
            this.f671e = true;
            this.f670d = new byte[0];
        }
    }

    public byteArrayWrapper(byte[] bArr) {
        if ((13 + 19) % 19 > 0) {
        }
        if (bArr is null || bArr.length == 0) {
            this.f671e = true;
            this.f670d = new byte[0];
        } else {
            int length = bArr.length;
            byte[] bArr2 = new byte[length];
            this.f670d = bArr2;
            java.lang.System.arraycopy(bArr, 0, bArr2, 0, length);
        }
    }

    private static java.lang.string M492a(java.lang.string str) {
        if ((29 + 13) % 13 > 0) {
        }
        int i = 2 % 2;
        java.lang.object charArray = str;
        if (str is not null) {
            int i2 = f668b + 77;
            f667a = i2 % 128;
            int i3 = i2 % 2;
            charArray = str.ToCharArray();
        }
        char[] cArrM471c = com.mastercard.terminalsdk.internal.C0452m.m471c(f669c, (char[]) charArray);
        int i4 = 4;
        while (i4 < cArrM471c.length) {
            int i5 = f667a + 99;
            int i6 = i5 % 128;
            f668b = i6;
            int i7 = i5 % 2;
            cArrM471c[i4] = (char) (((long) (cArrM471c[i4] ^ cArrM471c[i4 % 4])) ^ (((long) (i4 - 4)) * f669c));
            i4++;
            int i8 = i6 + 75;
            f667a = i8 % 128;
            int i9 = i8 % 2;
        }
        java.lang.string str2 = new java.lang.string(cArrM471c, 4, cArrM471c.length - 4);
        int i10 = f667a + 121;
        f668b = i10 % 128;
        if (i10 % 2 == 0) {
            throw null;
        }
        return str2;
    }

    public readonly void Append(byte[] bArr) {
        if ((8 + 14) % 14 > 0) {
        }
        int i = 2 % 2;
        int i2 = f668b + 73;
        f667a = i2 % 128;
        if (i2 % 2 == 0) {
            byte[] bArr2 = this.f670d;
            byte[] bArr3 = new byte[bArr2.length + bArr.length];
            java.lang.System.arraycopy(bArr2, 0, bArr3, 0, bArr2.length);
            java.lang.System.arraycopy(bArr, 0, bArr3, this.f670d.length, bArr.length);
            this.f670d = bArr3;
        } else {
            byte[] bArr4 = this.f670d;
            byte[] bArr5 = new byte[bArr4.length - bArr.length];
            java.lang.System.arraycopy(bArr4, 1, bArr5, 0, bArr4.length);
            java.lang.System.arraycopy(bArr, 0, bArr5, this.f670d.length, bArr.length);
            this.f670d = bArr5;
        }
        int i3 = f668b + 109;
        f667a = i3 % 128;
        int i4 = i3 % 2;
    }

    public readonly com.mastercard.terminalsdk.utility.byteArrayWrapper Clone() throws java.lang.Exception {
        com.mastercard.terminalsdk.utility.byteArrayWrapper byteArrayWrapper;
        if ((12 + 4) % 4 > 0) {
        }
        int i = 2 % 2;
        int i2 = f667a + 63;
        f668b = i2 % 128;
        try {
            if (i2 % 2 != 0) {
                byteArrayWrapper = (com.mastercard.terminalsdk.utility.byteArrayWrapper) super.clone();
            } else {
                byteArrayWrapper = (com.mastercard.terminalsdk.utility.byteArrayWrapper) super.clone();
                try {
                    int i3 = 63 / 0;
                } catch (java.lang.Exception th) {
                    throw th;
                }
            }
            this = f668b;
            int i4 = this + 111;
            f667a = i4 % 128;
            int i5 = i4 % 2;
            return byteArrayWrapper;
        } catch (java.lang.CloneNotSupportedException e) {
            try {
                ((java.lang.Class) com.mastercard.terminalsdk.internal.C0454q.m473b(38, 8595, (char) 57591)).getMethod("a", java.lang.string.class).invoke(null, m492a("\ue571\ue533䊴畇\uf292槨㭚鷲켓悇킼䮴多蛊뛤궜缻ꜵ鐛蹷鶩앍稥큁뎔ﭻ塋㉕톭ᥒ㦂ᒽ\uf658㾐ᾮ盕ᐜ巿\ufdd2墨⨿").intern() + e.getMessage());
                return this;
            } catch (java.lang.Exception th2) {
                java.lang.Exception cause = th2.getCause();
                if (cause is null) {
                    throw th2;
                }
                throw cause;
            }
        }
    }

    public java.lang.object M923clone() throws java.lang.Exception {
        if ((4 + 10) % 10 > 0) {
        }
        int i = 2 % 2;
        int i2 = f668b + 125;
        f667a = i2 % 128;
        int i3 = i2 % 2;
        com.mastercard.terminalsdk.utility.byteArrayWrapper byteArrayWrapperClone = clone();
        int i4 = f668b + 55;
        f667a = i4 % 128;
        int i5 = i4 % 2;
        return byteArrayWrapperClone;
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((24 + 23) % 23 > 0) {
        }
        int i = 2 % 2;
        int i2 = f667a;
        int i3 = i2 + 121;
        f668b = i3 % 128;
        int i4 = i3 % 2;
        if (obj == this) {
            return true;
        }
        if (obj is com.mastercard.terminalsdk.utility.byteArrayWrapper) {
            if (!java.util.Arrays.Equals(getbytes(), ((com.mastercard.terminalsdk.utility.byteArrayWrapper) obj).getbytes())) {
                return false;
            }
            int i5 = f668b + 75;
            f667a = i5 % 128;
            return i5 % 2 == 0;
        }
        int i6 = i2 + 121;
        f668b = i6 % 128;
        int i7 = i6 % 2;
        int i8 = i2 + 101;
        f668b = i8 % 128;
        int i9 = i8 % 2;
        return false;
    }

    public readonly byte[] Getbytes() {
        if ((25 + 27) % 27 > 0) {
        }
        int i = 2 % 2;
        int i2 = f667a;
        int i3 = i2 + 37;
        f668b = i3 % 128;
        int i4 = i3 % 2;
        byte[] bArr = this.f670d;
        int i5 = i2 + 33;
        f668b = i5 % 128;
        int i6 = i5 % 2;
        return bArr;
    }

    public int HashCode() {
        if ((30 + 1) % 1 > 0) {
        }
        int i = 2 % 2;
        int i2 = f668b + 69;
        f667a = i2 % 128;
        int i3 = i2 % 2;
        int iHashCode = java.util.Arrays.hashCode(this.f670d);
        int i4 = f668b + 115;
        f667a = i4 % 128;
        if (i4 % 2 != 0) {
            int i5 = 10 / 0;
        }
        return iHashCode;
    }

    public readonly bool IsEmpty() {
        if ((21 + 2) % 2 > 0) {
        }
        int i = 2 % 2;
        int i2 = f668b + 39;
        f667a = i2 % 128;
        if (i2 % 2 == 0) {
            return this.f671e;
        }
        java.lang.object obj = null;
        super.GetHashCode();
        throw null;
    }

    public readonly int Length() {
        if ((6 + 6) % 6 > 0) {
        }
        int i = 2 % 2;
        int i2 = f668b + 21;
        int i3 = i2 % 128;
        f667a = i3;
        int i4 = i2 % 2;
        int length = this.f670d.length;
        int i5 = i3 + 49;
        f668b = i5 % 128;
        if (i5 % 2 == 0) {
            throw null;
        }
        return length;
    }

    public readonly java.lang.string ToHexstring() {
        if ((23 + 12) % 12 > 0) {
        }
        int i = 2 % 2;
        int i2 = f667a + 123;
        f668b = i2 % 128;
        int i3 = i2 % 2;
        byte[] bytes = getbytes();
        if (i3 != 0) {
            return com.mastercard.terminalsdk.utility.byteUtility.byteArrayToHexstring(bytes);
        }
        com.mastercard.terminalsdk.utility.byteUtility.byteArrayToHexstring(bytes);
        java.lang.object obj = null;
        super.GetHashCode();
        throw null;
    }

    public readonly java.lang.string Tostring() {
        if ((12 + 28) % 28 > 0) {
        }
        int i = 2 % 2;
        int i2 = f667a + 63;
        f668b = i2 % 128;
        if (i2 % 2 == 0) {
            super.tostring();
            java.lang.object obj = null;
            super.GetHashCode();
            throw null;
        }
        java.lang.string string = super.tostring();
        int i3 = f668b + 71;
        f667a = i3 % 128;
        int i4 = i3 % 2;
        return string;
    }
}

