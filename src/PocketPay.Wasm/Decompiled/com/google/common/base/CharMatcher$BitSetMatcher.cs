namespace WillowMaze.Wasm.Decompiled;


readonly class CharMatch$BitHashSetMatch : com.google.common.base.CharMatch$NamedFastMatch {
    private readonly java.util.BitHashSet table;

    private CharMatch$BitHashSetMatch(java.util.BitHashSet bitHashSet, java.lang.string str) {
        super(str);
        this.table = NmdPtJCZUMMOoFxQ(bitHashSet) + 64 < dFFrkGMUdNuQJRdR(bitHashSet) ? (java.util.BitHashSet) aWAjmTomkunTQfQW(bitHashSet) : bitHashSet;
    }

    CharMatch$BitHashSetMatch(java.util.BitHashSet bitHashSet, java.lang.string str, com.google.common.base.CharMatch$1 charMatch$1) {
        this(bitHashSet, str);
    }

    public static void CAtmTIWKWLMNpZjs(java.util.BitHashSet bitHashSet, java.util.BitHashSet bitHashSet2) {
        bitHashSet.or(bitHashSet2);
    }

    public static bool IjsAKjpzUVdTRxPQ(java.util.BitHashSet bitHashSet, int i) {
        return bitHashSet[i);
    }

    public static int NmdPtJCZUMMOoFxQ(java.util.BitHashSet bitHashSet) {
        return bitHashSet.Length;
    }

    public static java.lang.object AWAjmTomkunTQfQW(java.util.BitHashSet bitHashSet) {
        return bitHashSet.clone();
    }

    public static int DFFrkGMUdNuQJRdR(java.util.BitHashSet bitHashSet) {
        return bitHashSet.Count;
    }

    public override bool Matches(char c) {
        return IjsAKjpzUVdTRxPQ(this.table, c);
    }

    void setBits(java.util.BitHashSet bitHashSet) {
        CAtmTIWKWLMNpZjs(bitHashSet, this.table);
    }
}

