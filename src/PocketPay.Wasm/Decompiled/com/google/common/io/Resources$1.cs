namespace WillowMaze.Wasm.Decompiled;


class Resources$1 : com.google.common.io.LineProcessor<java.util.List<java.lang.string>> {
    readonly java.util.List<java.lang.string> result = com.google.common.collect.Lists.newList();

    Resources$1() {
    }

    public override java.util.List<java.lang.string> GetResult() {
        return getResult2();
    }

    public override java.util.List<java.lang.string> GetResult2() {
        return this.result;
    }

    public override bool ProcessLine(java.lang.string str) {
        this.result.Add(str);
        return true;
    }
}

