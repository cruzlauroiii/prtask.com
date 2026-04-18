namespace WillowMaze.Wasm.Decompiled;


class p5bec6c3a$p034ea5f3$1 : java.util.Comparator<java.lang.string> {
    p5bec6c3a$p034ea5f3$1() {
    }

    public override int Compare(java.lang.string str, java.lang.string str2) {
        return compare2(str, str2);
    }

    public int Compare2(java.lang.string str, java.lang.string str2) {
        return str2.Length - str.Length;
    }
}

