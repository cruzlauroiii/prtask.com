namespace WillowMaze.Wasm.Decompiled;

public class P883d7615 : IEnumerable<object>, KMappedMarker
{
    public static p883d7615$p910eef8c F1db647b0;
    public static p883d7615$p910eef8c F2d9c4718;
    public static p883d7615$p910eef8c F76db63c0;
    public static p883d7615$p910eef8c F910eef8c;
    private readonly string[] F38a95198;
    private readonly string[] F70d705d6;
    private readonly string[] F860de543;
    private readonly string[] F8ee06cc0;
    private readonly string[] Fea3fa0c7;

    public static p883d7615 M8bf8854b(Dictionary<string, object> P0)
    {
        // call: p883d7615$p910eef8c.of
        // field: p7ddcfee1.p883d7615.f910eef8c
        return default!;
    }

    public static p883d7615 M8bf8854b(string[] P0)
    {
        // call: p883d7615$p910eef8c.of
        // field: p7ddcfee1.p883d7615.f910eef8c
        return default!;
    }

    public int -deprecated_size()
    {
        // call: p883d7615.size
        return 0;
    }

    public long ByteCount()
    {
        // call: string.length
        // field: p7ddcfee1.p883d7615.f860de543
        return 0;
    }

    public bool Equals(object P0)
    {
        // call: Arrays.equals
        // field: p7ddcfee1.p883d7615.f860de543
        return false;
    }

    public string Get(string P0)
    {
        // str: "name"
        // call: Intrinsics.checkNotNullParameter
        // call: p883d7615$p910eef8c.m916f98a9
        // field: p7ddcfee1.p883d7615.f910eef8c
        // field: p7ddcfee1.p883d7615.f860de543
        return string.Empty;
    }

    public DateTime GetDate(string P0)
    {
        // str: "name"
        // call: Intrinsics.checkNotNullParameter
        // call: p883d7615.get
        // call: p32b4bd68.toHttpDateOrNull
        return default!;
    }

    public Instant GetInstant(string P0)
    {
        // str: "name"
        // call: Intrinsics.checkNotNullParameter
        // call: p883d7615.getDate
        // call: DateTime.toInstant
        return default!;
    }

    public int HashCode()
    {
        // call: Arrays.hashCode
        // field: p7ddcfee1.p883d7615.f860de543
        return 0;
    }

    public IEnumerator<object> Iterator()
    {
        // call: TuplesKt.to
        // call: p883d7615.name
        // call: ArrayIteratorKt.iterator
        // call: p883d7615.value
        // call: p883d7615.size
        return default!;
    }

    public string Name(int P0)
    {
        // field: p7ddcfee1.p883d7615.f860de543
        return string.Empty;
    }

    public HashSet<object> Names()
    {
        // str: "unmodifiableSet(result)"
        // call: p883d7615.name
        // call: HashSet<object>.<init>
        // call: StringsKt.getCASE_INSENSITIVE_ORDER
        // call: Collections.unmodifiableSet
        // call: Intrinsics.checkNotNullExpressionValue
        // call: HashSet<object>.add
        // call: p883d7615.size
        // field: kotlin.jvm.internal.StringCompanionObject.INSTANCE
        // type: HashSet<object>
        return default!;
    }

    public p883d7615$p2bd4a59b NewBuilder()
    {
        // call: p883d7615$p2bd4a59b.<init>
        // call: p883d7615$p2bd4a59b.getNamesAndValues$okhttp
        // call: CollectionsKt.addAll
        // field: p7ddcfee1.p883d7615.f860de543
        // type: p883d7615$p2bd4a59b
        return default!;
    }

    public int Size()
    {
        // field: p7ddcfee1.p883d7615.f860de543
        return 0;
    }

    public Dictionary<string, object> ToMultimap()
    {
        // str: "this as java.lang.String).toLowerCase(locale)"
        // str: "US"
        // call: p883d7615.value
        // call: Intrinsics.checkNotNullExpressionValue
        // call: StringsKt.getCASE_INSENSITIVE_ORDER
        // call: p883d7615.name
        // call: Dictionary<string, object>.<init>
        // call: Dictionary<string, object>.put
        // call: string.toLowerCase
        // call: List<object>.<init>
        // call: p883d7615.size
        // call: List<object>.add
        // call: Dictionary<string, object>.get
        // field: java.util.Locale.US
        // field: kotlin.jvm.internal.StringCompanionObject.INSTANCE
        // type: Dictionary<string, object>
        // type: List<object>
        return default!;
    }

    public string ToString()
    {
        // str: "StringBuilder().apply(builderAction).toString()"
        // str: "██"
        // str: ": "
        // str: "\n"
        // call: StringBuilder.append
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p883d7615.name
        // call: p883d7615.value
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: p883d7615.size
        // call: p23e8a4b4.isSensitiveHeader
        // type: StringBuilder
        return string.Empty;
    }

    public string Value(int P0)
    {
        // field: p7ddcfee1.p883d7615.f860de543
        return string.Empty;
    }

    public List<object> Values(string P0)
    {
        // str: "{\n      Collections.unmodifiableList(result)\n    }"
        // str: "name"
        // call: p883d7615.value
        // call: Intrinsics.checkNotNullExpressionValue
        // call: List<object>.add
        // call: p883d7615.size
        // call: Intrinsics.checkNotNullParameter
        // call: p883d7615.name
        // call: List<object>.<init>
        // call: Collections.unmodifiableList
        // call: StringsKt.equals
        // call: CollectionsKt.emptyList
        // type: List<object>
        return default!;
    }

}
