namespace WillowMaze.Wasm.Decompiled;

public class P5dd44a36
{
    private static int F016ede19;
    private static int F0985a342;
    private static long F0a33a565;
    private static int F0fd92401;
    private static int F12bd0ff8;
    private static int F15f617d1;
    private static int F1b03dfc0;
    private static int F278d498f;
    private static int F2d53ca13;
    private static int F31520017;
    private static int F34e177b4;
    public static int F392d9c02;
    private static int F3a387665;
    private static int F3d5da274;
    private static int F45aab230;
    private static int F561a4194;
    private static int F671ef195;
    private static int F686705d4;
    private static int F6a465079;
    private static int F793fc7d0;
    public static int F79c72906;
    public static int F7b75cfe1;
    public static int F8547738f;
    private static int F89609d91;
    private static int F92fcbc88;
    public static int F95ad58a6;
    private static int F970d96af;
    private static int F98c7f6af;
    private static int Fa2420da6;
    private static int Fa47f1c5b;
    public static int Fac6bf7e7;
    private static long Faea25d87;
    private static long Fb7604fa4;
    public static int Fbe003847;
    private static int Fc071e8df;
    private static int Fc17b86a6;
    private static int Fc19b4745;
    private static int Fc81a62d5;
    private static int Fcdf88e32;
    private static int Fd1b020ed;
    private static long Fd433af61;
    private static int Fd82f7b6d;
    private static int Fe7b830ee;
    private static int Feee34f7b;
    public static int Ff826af28;
    public static int Ffaa09e67;
    public static int Ffaf48135;
    private static int Fff8a0bf2;

    private static long M05d9fe08(int P0, int P1)
    {
        // call: DateTime.<init>
        // call: DateTime.getTime
        // call: DateTime.set
        // call: long.valueOf
        // type: DateTime
        return 0;
    }

    private static p3a731bfc M27fd909b(pcc81e3f6 P0)
    {
        // str: "unsupported zip: spanned"
        // call: pcc81e3f6.readShortLe
        // call: IOException.<init>
        // call: pcc81e3f6.skip
        // call: pcc81e3f6.readIntLe
        // call: p3a731bfc.<init>
        // type: IOException
        // type: p3a731bfc
        return default!;
    }

    private static p3a731bfc M3eb1837b(pcc81e3f6 P0, p3a731bfc P1)
    {
        // str: "unsupported zip: spanned"
        // call: p3a731bfc.getCommentByteCount
        // call: pcc81e3f6.readLongLe
        // call: pcc81e3f6.readIntLe
        // call: p3a731bfc.<init>
        // call: IOException.<init>
        // call: pcc81e3f6.skip
        // type: p3a731bfc
        // type: IOException
        return default!;
    }

    public static p50ca3499 M514ac98d(pcc81e3f6 P0, p50ca3499 P1)
    {
        // str: "<this>"
        // str: "basicMetadata"
        // call: p5dd44a36.me69d8fa7
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.checkNotNull
        return default!;
    }

    private static string M64b08292(int P0)
    {
        // str: "0x"
        // str: "toString(this, checkRadix(radix))"
        // call: StringBuilder.toString
        // call: CharsKt.checkRadix
        // call: StringBuilder.append
        // call: int.toString
        // call: StringBuilder.<init>
        // call: Intrinsics.checkNotNullExpressionValue
        // type: StringBuilder
        return string.Empty;
    }

    public static pf3ce07b0 M64dbe03a(pcc81e3f6 P0)
    {
        // str: " but was "
        // str: "bad zip: filename contains 0x00"
        // str: "bad zip: zip64 extra required but absent"
        // str: "<this>"
        // str: "unsupported zip: general purpose bit flag="
        // str: "/"
        // str: "bad zip: expected "
        // call: StringBuilder.<init>
        // call: pcc81e3f6.readShortLe
        // call: IOException.<init>
        // call: p5dd44a36$p64dbe03a$1.<init>
        // call: StringBuilder.toString
        // call: p5dd44a36.m64b08292
        // call: pcc81e3f6.readIntLe
        // call: StringsKt.contains$default
        // call: pf3ce07b0.<init>
        // call: Ref$LongRef.<init>
        // call: pcc81e3f6.skip
        // call: Ref$BooleanRef.<init>
        // call: StringBuilder.append
        // call: pcc81e3f6.readUtf8
        // call: pac70412e$p910eef8c.ma89e983a
        // call: StringsKt.endsWith$default
        // call: p5dd44a36.mb2866b0c
        // call: Intrinsics.checkNotNullParameter
        // call: p5dd44a36.m05d9fe08
        // call: pac70412e.resolve
        // field: kotlin.jvm.internal.Ref$LongRef.element
        // field: p38cb8f46.pac70412e.f910eef8c
        // field: kotlin.jvm.internal.Ref$BooleanRef.element
        // type: IOException
        // type: StringBuilder
        // type: Ref$LongRef
        // type: Ref$BooleanRef
        // type: pf3ce07b0
        // type: p5dd44a36$p64dbe03a$1
        return default!;
    }

    public static pced66f81 M8547461a(pac70412e P0, pe2d63d19 P1, Func<object, object> P2)
    {
        // str: "zipPath"
        // str: "bad zip: expected "
        // str: " but was "
        // str: "not a zip: size="
        // str: "bad zip: local file header offset >= central directory offset"
        // str: "predicate"
        // str: "fileSystem"
        // str: "unsupported zip: spanned"
        // str: "not a zip: end of central directory signature not found"
        // call: CloseableKt.closeFinally
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: p5dd44a36.m64b08292
        // call: StringBuilder.toString
        // call: IOException.<init>
        // call: p223127e3.size
        // call: Math.max
        // call: p223127e3.source
        // call: p0af9afa4.m7f2db423
        // call: pcc81e3f6.readIntLe
        // call: p5dd44a36.m27fd909b
        // call: p3a731bfc.getCommentByteCount
        // call: pcc81e3f6.readUtf8
        // call: pcc81e3f6.close
        // call: pcc81e3f6.readLongLe
        // call: p5dd44a36.m3eb1837b
        // call: List<object>.<init>
        // call: p3a731bfc.getCentralDirectoryOffset
        // call: p3a731bfc.getEntryCount
        // field: kotlin.Unit.INSTANCE
        // type: IOException
        // type: StringBuilder
        // type: List<object>
        // type: pced66f81
        return default!;
    }

    private static Dictionary<string, object> Maf5a60b2(List<object> P0)
    {
        // str: "/"
        // call: pac70412e$p910eef8c.ma89e983a
        // call: pf3ce07b0.getCanonicalPath
        // call: p5dd44a36$paf5a60b2$pd41d8cd9$pec404527$pe8462a18$1.<init>
        // call: ICollection<object>.add
        // call: TuplesKt.to
        // call: IEnumerator<object>.next
        // call: pf3ce07b0.getChildren
        // call: IEnumerator<object>.hasNext
        // call: pac70412e.parent
        // call: MapsKt.mutableMapOf
        // call: List<object>.iterator
        // call: pf3ce07b0.<init>
        // call: Dictionary<string, object>.put
        // call: Dictionary<string, object>.get
        // call: CollectionsKt.sortedWith
        // field: p38cb8f46.pac70412e.f910eef8c
        // type: p5dd44a36$paf5a60b2$pd41d8cd9$pec404527$pe8462a18$1
        // type: pf3ce07b0
        return default!;
    }

    private static void Mb2866b0c(pcc81e3f6 P0, int P1, Func<object, object, object> P2)
    {
        // str: "bad zip: truncated header in extra field"
        // str: "bad zip: truncated value in extra field"
        // str: "unsupported zip: too many bytes processed for "
        // call: long.valueOf
        // call: StringBuilder.append
        // call: pcc81e3f6.getBuffer
        // call: pcc81e3f6.readShortLe
        // call: int.valueOf
        // call: pcc81e3f6.require
        // call: p7e62bc34.skip
        // call: Func<object, object, object>.invoke
        // call: p7e62bc34.size
        // call: StringBuilder.<init>
        // call: IOException.<init>
        // call: StringBuilder.toString
        // type: StringBuilder
        // type: IOException
    }

    public static void Mc4eaa582(pcc81e3f6 P0)
    {
        // str: "<this>"
        // call: p5dd44a36.me69d8fa7
        // call: Intrinsics.checkNotNullParameter
    }

    public static pced66f81 Mcec0f42a(pac70412e P0, pe2d63d19 P1, Func<object, object> P2, int P3, object P4)
    {
        // call: p5dd44a36.m8547461a
        // field: p38cb8f46.pd1efad72.p5dd44a36$p8547461a$1.f76425f17
        return default!;
    }

    private static p50ca3499 Me69d8fa7(pcc81e3f6 P0, p50ca3499 P1)
    {
        // str: "bad zip: expected "
        // str: "unsupported zip: general purpose bit flag="
        // str: " but was "
        // call: p50ca3499.<init>
        // call: pcc81e3f6.skip
        // call: p5dd44a36.m64b08292
        // call: IOException.<init>
        // call: p50ca3499.isRegularFile
        // call: p50ca3499.isDirectory
        // call: StringBuilder.<init>
        // call: p50ca3499.getLastModifiedAtMillis
        // call: p5dd44a36.mb2866b0c
        // call: Ref$ObjectRef.<init>
        // call: StringBuilder.append
        // call: p50ca3499.getSize
        // call: pcc81e3f6.readShortLe
        // call: pcc81e3f6.readIntLe
        // call: p5dd44a36$pe69d8fa7$1.<init>
        // call: StringBuilder.toString
        // field: kotlin.jvm.internal.Ref$ObjectRef.element
        // type: p5dd44a36$pe69d8fa7$1
        // type: StringBuilder
        // type: p50ca3499
        // type: Ref$ObjectRef
        // type: IOException
        return default!;
    }

}
