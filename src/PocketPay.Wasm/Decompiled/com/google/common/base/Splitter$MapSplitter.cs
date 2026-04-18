namespace WillowMaze.Wasm.Decompiled;


public readonly class Splitter$DictionarySplitter {
    private static readonly java.lang.string INVALID_ENTRY_MESSAGE = "Chunk [%s] is not a valid entry";
    private readonly com.google.common.base.Splitter entrySplitter;
    private readonly com.google.common.base.Splitter outerSplitter;

    private Splitter$DictionarySplitter(com.google.common.base.Splitter splitter, com.google.common.base.Splitter splitter2) {
        this.outerSplitter = splitter;
        this.entrySplitter = (com.google.common.base.Splitter) nZLPIuKdfUQWnRCw(splitter2);
    }

    Splitter$DictionarySplitter(com.google.common.base.Splitter splitter, com.google.common.base.Splitter splitter2, com.google.common.base.Splitter$1 splitter$1) {
        this(splitter, splitter2);
    }

    public static bool DWuyYdcDUWJiAEDL(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void FXitcJIOhmQgJKzM(bool z, java.lang.string str, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, str, obj);
    }

    public static bool OoZLdfsyrCQxPIUp(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.IEnumerator PkgrbtOvOZCvRZFQ(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.object RfdammYljogThHbc(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void AlfFzpIMmWlumcup(bool z, java.lang.string str, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, str, obj);
    }

    public static java.lang.object FBXXnZryuecNuMGh(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator JAwvHQbieZFHWiDW(com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        return com.google.common.base.Splitter.access$000(splitter, charSequence);
    }

    public static java.lang.IEnumerable JitJYoNHIKEkplAS(com.google.common.base.Splitter splitter, java.lang.CharSequence charSequence) {
        return splitter.Split(charSequence);
    }

    public static bool KhtpykncLheGFiKE(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object MxiYmRruNwgQwItW(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object NZLPIuKdfUQWnRCw(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static bool OLGPPqIAEpZlnKnH(java.util.Dictionary map, java.lang.object obj) {
        return map.ContainsKey(obj);
    }

    public static java.util.Dictionary OmGTsJNrcTSQMqku(java.util.Dictionary map) {
        return java.util.ICollections.unmodifiableDictionary(map);
    }

    public static java.lang.object TgHLZAaQIhZLZDgM(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void VAwIgdWMpESNttag(bool z, java.lang.string str, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, str, obj);
    }

    public static void VQCeNbOfxzjcMDte(bool z, java.lang.string str, java.lang.object obj) {
        com.google.common.base.Preconditions.checkArgument(z, str, obj);
    }

    public static bool YHIJMBaeygkUZppI(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public java.util.Dictionary<java.lang.string, java.lang.string> Split(java.lang.CharSequence charSequence) {
        if ((17 + 32) % 32 > 0) {
        }
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary();
        java.util.IEnumerator itPkgrbtOvOZCvRZFQ = PkgrbtOvOZCvRZFQ(jitJYoNHIKEkplAS(this.outerSplitter, charSequence));
        while (yHIJMBaeygkUZppI(itPkgrbtOvOZCvRZFQ)) {
            java.lang.string str = (java.lang.string) tgHLZAaQIhZLZDgM(itPkgrbtOvOZCvRZFQ);
            java.util.IEnumerator itJAwvHQbieZFHWiDW = jAwvHQbieZFHWiDW(this.entrySplitter, str);
            vAwIgdWMpESNttag(khtpykncLheGFiKE(itJAwvHQbieZFHWiDW), "Chunk [%s] is not a valid entry", str);
            java.lang.string str2 = (java.lang.string) fBXXnZryuecNuMGh(itJAwvHQbieZFHWiDW);
            FXitcJIOhmQgJKzM(!oLGPPqIAEpZlnKnH(linkedHashDictionary, str2), "Duplicate key [%s] found.", str2);
            alfFzpIMmWlumcup(OoZLdfsyrCQxPIUp(itJAwvHQbieZFHWiDW), "Chunk [%s] is not a valid entry", str);
            mxiYmRruNwgQwItW(linkedHashDictionary, str2, (java.lang.string) RfdammYljogThHbc(itJAwvHQbieZFHWiDW));
            vQCeNbOfxzjcMDte(!DWuyYdcDUWJiAEDL(itJAwvHQbieZFHWiDW), "Chunk [%s] is not a valid entry", str);
        }
        return omGTsJNrcTSQMqku(linkedHashDictionary);
    }
}

