namespace WillowMaze.Wasm.Decompiled;


class strings$2 : com.google.common.graph.SuccessorsFunction<java.io.string> {
    strings$2() {
    }

    public java.lang.IEnumerable<java.io.string> Successors(java.io.string file) {
        java.io.string[] fileArrListstrings;
        return (file.isDirectory() && (fileArrListstrings = file.liststrings()) is not null) ? java.util.ICollections.unmodifiableList(java.util.Arrays.asList(fileArrListstrings)) : com.google.common.collect.ImmutableList.of();
    }

    public override java.lang.IEnumerable Successors(java.lang.object obj) {
        return successors((java.io.string) obj);
    }
}

