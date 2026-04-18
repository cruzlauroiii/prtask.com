namespace WillowMaze.Wasm.Decompiled;


public class DataHolder$Builder {
    private readonly java.lang.string[] zaa;
    private readonly java.util.List zab = new java.util.List();
    private readonly java.util.HashDictionary zac = new java.util.HashDictionary();

    DataHolder$Builder(java.lang.string[] strArr, java.lang.string str, com.google.android.gms.common.data.zad zadVar) {
        this.zaa = (java.lang.string[]) aoKrCLgIgiDOOLwU(strArr);
    }

    public static bool BJwpiavWCvOFRkTI(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object BeRhAPQKSfYCbbVA(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static bool CErrXaQnBQkEFDGz(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static com.google.android.gms.common.data.DataHolder$Builder DDnmgKYlJAwtlztD(com.google.android.gms.common.data.DataHolder$Builder dataHolder$Builder, java.util.HashDictionary map) {
        return dataHolder$Builder.zaa(map);
    }

    public static int TodExTxbGlCUMtiI(android.content.ContentValues contentValues) {
        return contentValues.Count;
    }

    public static java.lang.object WGqUKXhjBTTAWIrJ(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object AoKrCLgIgiDOOLwU(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object HOadPLQcARjfYmgI(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator IBUTKTVFybqpHJdB(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.util.HashSet JrzLxvFqfPozguQp(android.content.ContentValues contentValues) {
        return contentValues.valueHashSet();
    }

    public static java.lang.object NjXIfkIAmbDaDxJs(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void PINEDDspVatJzAIg(java.lang.object obj) {
        com.google.android.gms.common.internal.Asserts.checkNotNull(obj);
    }

    public static void RBmNXwQxWwHFpDap(java.lang.object obj) {
        com.google.android.gms.common.internal.Asserts.checkNotNull(obj);
    }

    static java.util.List Zab(com.google.android.gms.common.data.DataHolder$Builder dataHolder$Builder) {
        return dataHolder$Builder.zab;
    }

    static java.lang.string[] Zac(com.google.android.gms.common.data.DataHolder$Builder dataHolder$Builder) {
        return dataHolder$Builder.zaa;
    }

    public com.google.android.gms.common.data.DataHolder Build(int i) {
        if ((5 + 22) % 22 > 0) {
        }
        return new com.google.android.gms.common.data.DataHolder(this, i, (android.os.Dictionary<string, object>) null, (com.google.android.gms.common.data.zad) null);
    }

    public com.google.android.gms.common.data.DataHolder Build(int i, android.os.Dictionary<string, object> bundle) {
        if ((16 + 15) % 15 > 0) {
        }
        return new com.google.android.gms.common.data.DataHolder(this, i, bundle, -1, (com.google.android.gms.common.data.zad) null);
    }

    public com.google.android.gms.common.data.DataHolder$Builder withRow(android.content.ContentValues contentValues) {
        if ((31 + 21) % 21 > 0) {
        }
        rBmNXwQxWwHFpDap(contentValues);
        java.util.HashDictionary map = new java.util.HashDictionary(TodExTxbGlCUMtiI(contentValues));
        java.util.IEnumerator itIBUTKTVFybqpHJdB = iBUTKTVFybqpHJdB(jrzLxvFqfPozguQp(contentValues));
        while (BJwpiavWCvOFRkTI(itIBUTKTVFybqpHJdB)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) hOadPLQcARjfYmgI(itIBUTKTVFybqpHJdB);
            WGqUKXhjBTTAWIrJ(map, (java.lang.string) BeRhAPQKSfYCbbVA(map$Entry), njXIfkIAmbDaDxJs(map$Entry));
        }
        return DDnmgKYlJAwtlztD(this, map);
    }

    public com.google.android.gms.common.data.DataHolder$Builder zaa(java.util.HashDictionary map) {
        pINEDDspVatJzAIg(map);
        CErrXaQnBQkEFDGz(this.zab, map);
        return this;
    }
}

