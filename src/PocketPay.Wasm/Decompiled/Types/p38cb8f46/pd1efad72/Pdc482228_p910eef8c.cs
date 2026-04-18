namespace WillowMaze.Wasm.Decompiled;

public class Pdc482228_p910eef8c
{
    private bool Mc122ad42(pac70412e P0)
    {
        // str: ".class"
        // call: pac70412e.name
        // call: StringsKt.endsWith
        return false;
    }

    public static bool Me59ee7ad(pdc482228$p910eef8c P0, pac70412e P1)
    {
        // call: pdc482228$p910eef8c.mc122ad42
        return false;
    }

    public pac70412e GetROOT()
    {
        // call: pdc482228.m4baba847
        return default!;
    }

    public pac70412e RemoveBase(pac70412e P0, pac70412e P1)
    {
        // str: "<this>"
        // str: "base"
        // call: pac70412e.toString
        // call: StringsKt.replace$default
        // call: pdc482228$p910eef8c.getROOT
        // call: Intrinsics.checkNotNullParameter
        // call: StringsKt.removePrefix
        // call: pac70412e.resolve
        return default!;
    }

    public List<object> ToClasspathRoots(ClassLoader P0)
    {
        // str: "META-INF/MANIFEST.MF"
        // str: "getResources(\"\")"
        // str: "it"
        // str: ""
        // str: "<this>"
        // str: "list(this)"
        // str: "getResources(\"META-INF/MANIFEST.MF\")"
        // call: Collections.list
        // call: IEnumerator<object>.next
        // call: Intrinsics.checkNotNullExpressionValue
        // call: pdc482228$p910eef8c.toFileRoot
        // call: IEnumerable<object>.iterator
        // call: CollectionsKt.plus
        // call: ClassLoader.getResources
        // call: pdc482228$p910eef8c.toJarRoot
        // call: IEnumerator<object>.hasNext
        // call: pdc482228.m6b378b54
        // call: ICollection<object>.add
        // call: List<object>.<init>
        // call: Intrinsics.checkNotNullParameter
        // type: List<object>
        return default!;
    }

    public ValueTuple<object, object> ToFileRoot(Uri P0)
    {
        // str: "file"
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: TuplesKt.to
        // call: Uri.getProtocol
        // call: string.<init>
        // call: pac70412e$p910eef8c.ma89e983a
        // call: Uri.toURI
        // call: Intrinsics.areEqual
        // field: p38cb8f46.pe2d63d19.ffa177138
        // field: p38cb8f46.pac70412e.f910eef8c
        // type: string
        return default!;
    }

    public ValueTuple<object, object> ToJarRoot(Uri P0)
    {
        // str: "jar:file:"
        // str: "this as java.lang.String…ing(startIndex, endIndex)"
        // str: "!"
        // str: "<this>"
        // str: "toString()"
        // call: pac70412e$p910eef8c.ma89e983a
        // call: StringsKt.startsWith$default
        // call: pdc482228$p910eef8c.getROOT
        // call: p5dd44a36.m8547461a
        // call: string.substring
        // call: string.<init>
        // call: Uri.create
        // call: TuplesKt.to
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.checkNotNullExpressionValue
        // call: StringsKt.lastIndexOf$default
        // call: Uri.toString
        // field: p38cb8f46.pd1efad72.pdc482228$p910eef8c$p18bd1067$padcdbd79$1.f76425f17
        // field: p38cb8f46.pe2d63d19.ffa177138
        // field: p38cb8f46.pac70412e.f910eef8c
        // type: string
        return default!;
    }

}
