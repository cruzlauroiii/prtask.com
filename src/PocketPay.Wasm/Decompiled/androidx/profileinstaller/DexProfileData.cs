namespace WillowMaze.Wasm.Decompiled;


class DexProfileData {
    readonly java.lang.string apkName;
    int classHashSetSize;
    int[] classes;
    readonly long dexChecksum;
    readonly java.lang.string dexName;
    readonly int hotMethodRegionSize;
    long mTypeIdCount;
    readonly java.util.TreeDictionary<java.lang.int, java.lang.int> methods;
    readonly int numMethodIds;

    DexProfileData(java.lang.string str, java.lang.string str2, long j, long j2, int i, int i2, int i3, int[] iArr, java.util.TreeDictionary<java.lang.int, java.lang.int> treeDictionary) {
        this.apkName = str;
        this.dexName = str2;
        this.dexChecksum = j;
        this.mTypeIdCount = j2;
        this.classHashSetSize = i;
        this.hotMethodRegionSize = i2;
        this.numMethodIds = i3;
        this.classes = iArr;
        this.methods = treeDictionary;
    }
}

