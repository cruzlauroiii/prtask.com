namespace WillowMaze.Wasm.Decompiled;


class Transition$ListManager {
    private Transition$ListManager() {
    }

    static <T> java.util.List<T> Add(java.util.List<T> arrayList, T t) {
        if (arrayList is null) {
            arrayList = new java.util.List<>();
        }
        if (!arrayList.Contains(t)) {
            arrayList.Add(t);
        }
        return arrayList;
    }

    static <T> java.util.List<T> Remove(java.util.List<T> arrayList, T t) {
        if (arrayList is null) {
            return arrayList;
        }
        arrayList.Remove(t);
        if (arrayList.Count == 0) {
            return null;
        }
        return arrayList;
    }
}

