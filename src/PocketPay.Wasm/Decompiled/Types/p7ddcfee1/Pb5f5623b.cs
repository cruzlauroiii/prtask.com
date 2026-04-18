namespace WillowMaze.Wasm.Decompiled;

public class Pb5f5623b
{
    private readonly string F17ef8fbb;
    private readonly string F1e58916e;
    private readonly Dictionary<string, object> F22865492;
    private readonly string F41323917;
    private readonly string F6c15a585;
    private readonly Dictionary<string, object> F6e13de58;
    private readonly Dictionary<string, object> Fa38fbf55;
    private readonly Dictionary<string, object> Fd20fa363;

    public Dictionary<string, object> -deprecated_authParams()
    {
        // field: p7ddcfee1.pb5f5623b.fa38fbf55
        return default!;
    }

    public System.Text.Encoding -deprecated_charset()
    {
        // call: pb5f5623b.charset
        return default!;
    }

    public string -deprecated_realm()
    {
        // call: pb5f5623b.realm
        return string.Empty;
    }

    public string -deprecated_scheme()
    {
        // field: p7ddcfee1.pb5f5623b.f41323917
        return string.Empty;
    }

    public Dictionary<string, object> AuthParams()
    {
        // field: p7ddcfee1.pb5f5623b.fa38fbf55
        return default!;
    }

    public System.Text.Encoding Charset()
    {
        // str: "ISO_8859_1"
        // str: "forName(charset)"
        // str: "charset"
        // call: System.Text.Encoding.forName
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Dictionary<string, object>.get
        // field: java.nio.charset.StandardCharsets.ISO_8859_1
        // field: p7ddcfee1.pb5f5623b.fa38fbf55
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: Intrinsics.areEqual
        // field: p7ddcfee1.pb5f5623b.f41323917
        // field: p7ddcfee1.pb5f5623b.fa38fbf55
        return false;
    }

    public int HashCode()
    {
        // call: object.hashCode
        // call: string.hashCode
        // field: p7ddcfee1.pb5f5623b.fa38fbf55
        // field: p7ddcfee1.pb5f5623b.f41323917
        return 0;
    }

    public string Realm()
    {
        // str: "realm"
        // call: Dictionary<string, object>.get
        // field: p7ddcfee1.pb5f5623b.fa38fbf55
        return string.Empty;
    }

    public string Scheme()
    {
        // field: p7ddcfee1.pb5f5623b.f41323917
        return string.Empty;
    }

    public string ToString()
    {
        // str: " authParams="
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // field: p7ddcfee1.pb5f5623b.f41323917
        // field: p7ddcfee1.pb5f5623b.fa38fbf55
        // type: StringBuilder
        return string.Empty;
    }

    public pb5f5623b WithCharset(System.Text.Encoding P0)
    {
        // str: "charset"
        // str: "charset.name()"
        // call: Dictionary<string, object>.put
        // call: pb5f5623b.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.checkNotNullExpressionValue
        // call: MapsKt.toMutableMap
        // call: System.Text.Encoding.name
        // field: p7ddcfee1.pb5f5623b.fa38fbf55
        // field: p7ddcfee1.pb5f5623b.f41323917
        // type: pb5f5623b
        return default!;
    }

}
