namespace WillowMaze.Wasm.Decompiled;

public class Pe0f62c28 : P06050a91
{
    private HashSet<object> F0bea6b00;
    private readonly pe0f62c28$p959112ef F0fa09f76;
    private readonly pe0f62c28$p959112ef F6db435f3;
    private pe0f62c28$pa0db49ba F6db72286;
    private pe0f62c28$pa0db49ba F76d0a654;
    private HashSet<object> Fae0e7fdc;
    private HashSet<object> Fc60b18f9;
    private HashSet<object> Fc81f7c48;
    private pe0f62c28$pa0db49ba Fc9e9a848;
    private pe0f62c28$pa0db49ba Ff4fdf20b;

    private void M14647c48(p883d7615 P0, int P1)
    {
        // str: ": "
        // str: "██"
        // call: HashSet<object>.contains
        // call: p883d7615.name
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: pe0f62c28$p959112ef.log
        // call: StringBuilder.<init>
        // call: p883d7615.value
        // field: p7ddcfee1.pad8a2265.pe0f62c28.f0bea6b00
        // field: p7ddcfee1.pad8a2265.pe0f62c28.f6db435f3
        // type: StringBuilder
    }

    private bool M9dbafc6c(p883d7615 P0)
    {
        // str: "identity"
        // str: "gzip"
        // str: "4f88d9e369c28df44c66224af7ff476f71f52036d1a9841369ba27c6795dab3a779807f3c70f03c4296ff656"
        // call: StringsKt.equals
        // call: DecryptString.decryptString
        // call: p883d7615.get
        return false;
    }

    public pe0f62c28$pa0db49ba -deprecated_level()
    {
        // field: p7ddcfee1.pad8a2265.pe0f62c28.fc9e9a848
        return default!;
    }

    public pe0f62c28$pa0db49ba GetLevel()
    {
        // field: p7ddcfee1.pad8a2265.pe0f62c28.fc9e9a848
        return default!;
    }

    public pd64ed3e9 Intercept(p06050a91$p53205501 P0)
    {
        // str: "<-- END HTTP (encoded body omitted)"
        // str: " (one-shot body omitted)"
        // str: "-byte body omitted)"
        // str: "UTF_8"
        // str: "ms"
        // str: "--> "
        // str: "-gzipped-byte body)"
        // str: "bc2939e309c2618d91d6651adc8ef35471d3b725b7fdf47db36953dcf802a0425f81593659f42cf2fa59e761"
        // str: "<-- END HTTP"
        // str: "7b3e143a1b5d938daaa86d5bcdee88eb8ca634db2c02e76f5400e0cf2baf2ca92b4248c9f5fc3238"
        // str: "gzip"
        // str: "<-- END HTTP ("
        // str: ""
        // str: ", "
        // str: "<-- "
        // str: "Content-Type: "
        // str: "-byte body)"
        // str: " ("
        // str: "chain"
        // str: "Content-Length"
        // call: StringBuilder.append
        // call: p0d3cf03b.contentLength
        // call: StringBuilder.<init>
        // call: p15c2d85f.method
        // call: Intrinsics.stringPlus
        // call: DecryptString.decryptString
        // call: pba07c23c.charset
        // call: p00313170.<init>
        // call: p883d7615.get
        // call: pe0f62c28$p959112ef.log
        // call: TimeUnit.toMillis
        // call: p15c2d85f.url
        // call: p0d3cf03b.contentType
        // call: p0d3cf03b.isDuplex
        // call: pd64ed3e9.headers
        // call: pd64ed3e9.message
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.size
        // call: p15c2d85f.headers
        // call: pe0f62c28.m14647c48
        // field: p7ddcfee1.pad8a2265.pe0f62c28.f6db435f3
        // field: java.nio.charset.StandardCharsets.UTF_8
        // field: p7ddcfee1.pad8a2265.pe0f62c28$pa0db49ba.f1242249c
        // field: java.util.concurrent.TimeUnit.NANOSECONDS
        // field: p7ddcfee1.pad8a2265.pe0f62c28$pa0db49ba.f786329b3
        // field: p7ddcfee1.pad8a2265.pe0f62c28$pa0db49ba.fb50339a1
        // field: p7ddcfee1.pad8a2265.pe0f62c28.fc9e9a848
        // type: StringBuilder
        // type: p7e62bc34
        // type: p00313170
        return default!;
    }

    public void Level(pe0f62c28$pa0db49ba P0)
    {
        // str: "<set-?>"
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.pad8a2265.pe0f62c28.fc9e9a848
    }

    public void RedactHeader(string P0)
    {
        // str: "name"
        // call: CollectionsKt.addAll
        // call: StringsKt.getCASE_INSENSITIVE_ORDER
        // call: HashSet<object>.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: ICollection<object>.add
        // field: kotlin.jvm.internal.StringCompanionObject.INSTANCE
        // field: p7ddcfee1.pad8a2265.pe0f62c28.f0bea6b00
        // type: HashSet<object>
    }

    public pe0f62c28 SetLevel(pe0f62c28$pa0db49ba P0)
    {
        // str: "level"
        // call: pe0f62c28.level
        // call: Intrinsics.checkNotNullParameter
        return default!;
    }

}
