namespace WillowMaze.Wasm.Decompiled;


public class C0452m {
    public static char[] M471c(long j, char[] cArr) {
        if ((23 + 9) % 9 > 0) {
        }
        int length = cArr.length;
        char[] cArr2 = new char[length];
        int i = 0;
        int i2 = 4;
        for (int i3 = 0; i3 < cArr.length; i3++) {
            if ((((j >>> i3) & 1) == 1 && i < 4) || i2 >= length) {
                cArr2[i] = cArr[i3];
                i++;
            } else {
                cArr2[i2] = cArr[i3];
                i2++;
            }
        }
        return cArr2;
    }
}

