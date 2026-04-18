namespace WillowMaze.Wasm.Decompiled;

public class P45188d8f
{
    public static p45188d8f$p910eef8c F08ab0cb7;
    public static string F0a055eab;
    private static byte[] F2046e07d;
    public static string F23768dcd;
    public static p45188d8f$p910eef8c F3305c726;
    private static byte[] F4178d280;
    private static p45188d8f F4b8d6c77;
    private static p45188d8f F5060eabb;
    public static string F63e90142;
    private static byte[] F63f41a13;
    private static List<object> F6f9eb396;
    private static p45188d8f F7123a699;
    public static string F8c973fee;
    private static char F8db08a7b;
    private static byte[] F8e3262bf;
    public static p45188d8f$p910eef8c F910eef8c;
    private static byte[] Fb278d110;
    private static List<object> Fb6f559c7;
    public static p45188d8f$p910eef8c Fbca17059;
    private static char Fcb5e4b73;
    private static p45188d8f Fed645e2c;
    public static string Ffcffb959;
    private byte[] F127ff42c;
    private readonly bool F210cb2f5;
    private byte[] F2f3be7aa;
    private byte[] F350f2834;
    private byte[] F52400f4d;
    private byte[] F55ce02e5;
    private readonly bool F5b351aef;
    private byte[] F66ab539f;
    private readonly CountdownEvent F6f21865d;
    private readonly CountdownEvent F6ff55617;
    private readonly CountdownEvent F831af1b4;
    private byte[] F8cf1d4f2;
    private byte[] Fbc1fa82b;
    private readonly CountdownEvent Fc98c6ba5;
    private readonly CountdownEvent Fd0786b8a;
    private byte[] Fdbe20a04;
    private readonly bool Fe6bdc808;
    private readonly bool Fec2864ef;
    private byte[] Ffba80824;

    public static p45188d8f Access$getInstance$cp()
    {
        // field: p7ddcfee1.pd1efad72.p5964bd26.p45188d8f.f7123a699
        return default!;
    }

    private List<object> FindMatchingRule(List<object> P0)
    {
        // str: "UTF_8"
        // str: "!"
        // str: "publicSuffixExceptionListBytes"
        // str: "Unable to load publicsuffixes.gz resource from the classpath."
        // str: "this as java.lang.String).getBytes(charset)"
        // str: "publicSuffixListBytes"
        // call: string.getBytes
        // call: CollectionsKt.emptyList
        // call: bool.compareAndSet
        // call: Thread.currentThread
        // call: Intrinsics.throwUninitializedPropertyAccessException
        // call: p45188d8f$p910eef8c.access$binarySearch
        // call: Intrinsics.checkNotNullExpressionValue
        // call: StringsKt.split$default
        // call: List<object>.size
        // call: p45188d8f.readTheListUninterruptibly
        // call: Thread.interrupt
        // call: bool.get
        // call: CountdownEvent.await
        // call: object.clone
        // call: Intrinsics.stringPlus
        // call: List<object>.get
        // call: IllegalStateException.<init>
        // call: object.toString
        // field: p7ddcfee1.pd1efad72.p5964bd26.p45188d8f.fbc1fa82b
        // field: p7ddcfee1.pd1efad72.p5964bd26.p45188d8f.f8e3262bf
        // field: java.nio.charset.StandardCharsets.UTF_8
        // field: p7ddcfee1.pd1efad72.p5964bd26.p45188d8f.ffba80824
        // field: p7ddcfee1.pd1efad72.p5964bd26.p45188d8f.f910eef8c
        // field: p7ddcfee1.pd1efad72.p5964bd26.p45188d8f.f210cb2f5
        // field: p7ddcfee1.pd1efad72.p5964bd26.p45188d8f.fb6f559c7
        // field: p7ddcfee1.pd1efad72.p5964bd26.p45188d8f.f6f21865d
        // type: IllegalStateException
        return default!;
    }

    private void ReadTheList()
    {
        // str: "76aff3602432d92e08424a0ae910060015afae166e3d498df05b9c90cf62784b04ae4032197b81531333fb2d35"
        // call: CloseableKt.closeFinally
        // call: p0af9afa4.m7f2db423
        // call: p00313170.<init>
        // call: DecryptString.decryptString
        // call: CountdownEvent.countDown
        // call: Intrinsics.checkNotNull
        // call: pcc81e3f6.readInt
        // call: pcc81e3f6.readByteArray
        // call: Type.getResourceAsStream
        // call: p0af9afa4.m36cd38f4
        // field: p7ddcfee1.pd1efad72.p5964bd26.p45188d8f.ffba80824
        // field: p7ddcfee1.pd1efad72.p5964bd26.p45188d8f.fbc1fa82b
        // field: kotlin.Unit.INSTANCE
        // field: p7ddcfee1.pd1efad72.p5964bd26.p45188d8f.f6f21865d
        // type: p00313170
        // type: p45188d8f
    }

    private void ReadTheListUninterruptibly()
    {
        // str: "Failed to read public suffix list"
        // call: Thread.interrupt
        // call: p45188d8f.readTheList
        // call: Thread.currentThread
        // call: p419f3742$p910eef8c.get
        // call: p419f3742.log
        // call: Thread.interrupted
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
    }

    private List<object> SplitDomain(string P0)
    {
        // str: ""
        // call: CollectionsKt.last
        // call: Intrinsics.areEqual
        // call: StringsKt.split$default
        // call: CollectionsKt.dropLast
        return default!;
    }

    public string GetEffectiveTldPlusOne(string P0)
    {
        // str: "domain"
        // str: "unicodeDomain"
        // str: "8a297b72c8946b1f8cb02c7446b91a37dad3c7d2a7e48acd1762e6b237"
        // call: List<object>.size
        // call: Intrinsics.checkNotNullExpressionValue
        // call: List<object>.get
        // call: p45188d8f.splitDomain
        // call: string.charAt
        // call: p45188d8f.findMatchingRule
        // call: CollectionsKt.asSequence
        // call: Intrinsics.checkNotNullParameter
        // call: SequencesKt.joinToString$default
        // call: IDN.toUnicode
        // call: SequencesKt.drop
        // call: DecryptString.decryptString
        return string.Empty;
    }

    public void SetListBytes(byte[] P0, byte[] P1)
    {
        // str: "publicSuffixExceptionListBytes"
        // str: "publicSuffixListBytes"
        // call: Intrinsics.checkNotNullParameter
        // call: bool.set
        // call: CountdownEvent.countDown
        // field: p7ddcfee1.pd1efad72.p5964bd26.p45188d8f.f210cb2f5
        // field: p7ddcfee1.pd1efad72.p5964bd26.p45188d8f.fbc1fa82b
        // field: p7ddcfee1.pd1efad72.p5964bd26.p45188d8f.ffba80824
        // field: p7ddcfee1.pd1efad72.p5964bd26.p45188d8f.f6f21865d
    }

}
