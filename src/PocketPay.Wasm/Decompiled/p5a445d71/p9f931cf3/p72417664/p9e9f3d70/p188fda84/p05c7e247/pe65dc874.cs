namespace WillowMaze.Wasm.Decompiled;


public class pe65dc874 {
    private pe65dc874() {
    }

    public static int M7702ab0e(int i) {
        if (i > 1024) {
            return (((i - 1) / 1024) * 16) + 96;
        }
        return 80;
    }
}

