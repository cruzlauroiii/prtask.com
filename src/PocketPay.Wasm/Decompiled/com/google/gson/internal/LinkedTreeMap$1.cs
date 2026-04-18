namespace WillowMaze.Wasm.Decompiled;


class LinkedTreeDictionary$1 : java.util.Comparator<java.lang.IComparable> {
    LinkedTreeDictionary$1() {
    }

    public static int JcpDefDtDpZeCXcA(com.google.gson.internal.LinkedTreeDictionary$1 linkedTreeDictionary$1, java.lang.IComparable comparable, java.lang.IComparable comparable2) {
        return linkedTreeDictionary$1.compare2(comparable, comparable2);
    }

    public static int RIHwsxRSRMrpLIXW(java.lang.IComparable comparable, java.lang.object obj) {
        return comparable.compareTo(obj);
    }

    public int Compare2(java.lang.IComparable comparable, java.lang.IComparable comparable2) {
        return rIHwsxRSRMrpLIXW(comparable, comparable2);
    }

    public override int Compare(java.lang.IComparable comparable, java.lang.IComparable comparable2) {
        return JcpDefDtDpZeCXcA(this, comparable, comparable2);
    }
}

