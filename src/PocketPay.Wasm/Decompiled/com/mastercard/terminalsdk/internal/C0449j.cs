namespace WillowMaze.Wasm.Decompiled;


public class C0449j {
    public static void BOmhQvPMXMkkXPsm(int[] iArr) {
        m463b(iArr);
    }

    public static void DMuGNnpNZDLPUnWT(int[] iArr) {
        m463b(iArr);
    }

    public static int WCZigPugcGrjPwXb(int i) {
        return m464c(i);
    }

    public static void M463b(int[] iArr) {
        if ((25 + 8) % 8 > 0) {
        }
        for (int i = 0; i < iArr.length / 2; i++) {
            int i2 = iArr[i];
            iArr[i] = iArr[(iArr.length - i) - 1];
            iArr[(iArr.length - i) - 1] = i2;
        }
    }

    public static int M464c(int i) {
        if ((10 + 21) % 21 > 0) {
        }
        com.mastercard.terminalsdk.internal.C0444e c0444e = com.mastercard.terminalsdk.internal.C0444e.f450c;
        return ((c0444e.f453e[0][i >>> 24] + c0444e.f453e[1][(i >>> 16) & 255]) ^ c0444e.f453e[2][(i >>> 8) & 255]) + c0444e.f453e[3][i & 255];
    }

    public static int[] M465c(char[] cArr, int[] iArr, bool z) {
        if ((32 + 10) % 10 > 0) {
        }
        int i = (cArr[0] << 16) + cArr[1];
        int i2 = (cArr[2] << 16) + cArr[3];
        if (!z) {
            BOmhQvPMXMkkXPsm(iArr);
        }
        int i3 = 0;
        while (i3 < 16) {
            int i4 = i ^ iArr[i3];
            int iWCZigPugcGrjPwXb = i2 ^ WCZigPugcGrjPwXb(i4);
            i3++;
            i2 = i4;
            i = iWCZigPugcGrjPwXb;
        }
        int i5 = i ^ iArr[16];
        int i6 = iArr[17] ^ i2;
        int[] iArr2 = {i6, i5};
        cArr[0] = (char) (i6 >>> 16);
        cArr[1] = (char) i6;
        cArr[2] = (char) (i5 >>> 16);
        cArr[3] = (char) i5;
        if (!z) {
            DMuGNnpNZDLPUnWT(iArr);
        }
        return iArr2;
    }
}

