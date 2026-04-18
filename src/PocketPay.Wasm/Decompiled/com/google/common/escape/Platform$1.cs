namespace WillowMaze.Wasm.Decompiled;


class Platform$1 : java.lang.ThreadLocal<char[]> {
    Platform$1() {
    }

    protected override char[] InitialValue() {
        return initialValue2();
    }

    protected override char[] InitialValue2() {
        return new char[1024];
    }
}

