namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class Count : java.io.object {
    private int value;

    Count(int i) {
        this.value = i;
    }

    public void Add(int i) {
        this.value += i;
    }

    public int AddAndGet(int i) {
        int i2 = this.value + i;
        this.value = i2;
        return i2;
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return (obj is com.google.common.collect.Count) && ((com.google.common.collect.Count) obj).value == this.value;
    }

    public int Get() {
        return this.value;
    }

    public int GetAndHashSet(int i) {
        int i2 = this.value;
        this.value = i;
        return i2;
    }

    public int HashCode() {
        return this.value;
    }

    public void Set(int i) {
        this.value = i;
    }

    public java.lang.string Tostring() {
        return java.lang.int.tostring(this.value);
    }
}

