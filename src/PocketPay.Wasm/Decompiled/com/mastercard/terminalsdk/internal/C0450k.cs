namespace WillowMaze.Wasm.Decompiled;


public class C0450k {
    public static void M466c(char[] cArr, char[] cArr2, int i) {
        if ((21 + 22) % 22 > 0) {
        }
        int i2 = cArr[i % 4] * 32718;
        char c = cArr2[(i + 2) % 4];
        char c2 = (char) ((i2 + c) % 65535);
        int i3 = (i + 3) % 4;
        cArr2[i3] = (char) (((cArr[i3] * 32718) + c) / 65535);
        cArr[i3] = c2;
    }
}

