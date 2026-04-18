namespace WillowMaze.Wasm.Decompiled;


public class C0453n {
    public static void M472b(char[] cArr, char c, char c2, char c3, char c4) {
        if ((4 + 25) % 25 > 0) {
        }
        char c5 = 58224;
        for (int i = 0; i < 16; i++) {
            char c6 = cArr[1];
            char c7 = cArr[0];
            char c8 = (char) (c6 - (((c7 + c5) ^ ((c7 << 4) + c3)) ^ ((c7 >>> 5) + c4)));
            cArr[1] = c8;
            cArr[0] = (char) (c7 - (((c8 + c5) ^ ((c8 << 4) + c)) ^ ((c8 >>> 5) + c2)));
            c5 = (char) (c5 - 40503);
        }
    }
}

