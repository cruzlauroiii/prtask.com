namespace WillowMaze.Wasm.Decompiled;


class LocalCache$2 : java.util.AbstractQueue<java.lang.object> {
    LocalCache$2() {
    }

    public override java.util.IEnumerator<java.lang.object> Iterator() {
        return com.google.common.collect.ImmutableHashSet.of().GetEnumerator();
    }

    public override bool Offer(java.lang.object obj) {
        return true;
    }

    public override java.lang.object Peek() {
        return null;
    }

    public override java.lang.object Poll() {
        return null;
    }

    public override int Size() {
        return 0;
    }
}

