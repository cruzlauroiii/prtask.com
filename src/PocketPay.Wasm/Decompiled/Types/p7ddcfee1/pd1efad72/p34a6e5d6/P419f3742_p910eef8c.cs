namespace WillowMaze.Wasm.Decompiled;

public class P419f3742_p910eef8c
{
    public static p419f3742 Access$findPlatform(p419f3742$p910eef8c P0)
    {
        // call: p419f3742$p910eef8c.findPlatform
        return default!;
    }

    private p419f3742 FindAndroidPlatform()
    {
        // call: pb95e9adf$p910eef8c.buildIfSupported
        // call: pd9002adb$p910eef8c.buildIfSupported
        // call: Intrinsics.checkNotNull
        // call: p592a534d.enable
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pd9002adb.f910eef8c
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p592a534d.f76425f17
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pb95e9adf.f910eef8c
        return default!;
    }

    private p419f3742 FindJvmPlatform()
    {
        // call: pb42b341d$p910eef8c.buildIfSupported
        // call: p419f3742.<init>
        // call: p419f3742$p910eef8c.isConscryptPreferred
        // call: p419f3742$p910eef8c.isBouncyCastlePreferred
        // call: p5c24dc0b$p910eef8c.buildIfSupported
        // call: p5111b6a9$p910eef8c.buildIfSupported
        // call: p2ce5caa5$p910eef8c.buildIfSupported
        // call: pb82ad7ea$p910eef8c.buildIfSupported
        // call: p419f3742$p910eef8c.isOpenJSSEPreferred
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pb82ad7ea.f910eef8c
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p5111b6a9.f910eef8c
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p2ce5caa5.f910eef8c
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p5c24dc0b.f910eef8c
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.pb42b341d.f910eef8c
        // type: p419f3742
        return default!;
    }

    private p419f3742 FindPlatform()
    {
        // call: p419f3742$p910eef8c.isAndroid
        // call: p419f3742$p910eef8c.findJvmPlatform
        // call: p419f3742$p910eef8c.findAndroidPlatform
        return default!;
    }

    private bool IsBouncyCastlePreferred()
    {
        // str: "7128735bd0191731dc4b8454d17484a7ea3b41930a8cee2a095d57bfb2f4"
        // call: DecryptString.decryptString
        // call: Security.getProviders
        // call: Intrinsics.areEqual
        // call: Provider.getName
        return false;
    }

    private bool IsConscryptPreferred()
    {
        // str: "Conscrypt"
        // call: Provider.getName
        // call: Intrinsics.areEqual
        // call: Security.getProviders
        return false;
    }

    private bool IsOpenJSSEPreferred()
    {
        // str: "OpenJSSE"
        // call: Provider.getName
        // call: Security.getProviders
        // call: Intrinsics.areEqual
        return false;
    }

    public static void ResetForTests$default(p419f3742$p910eef8c P0, p419f3742 P1, int P2, object P3)
    {
        // call: p419f3742$p910eef8c.findPlatform
        // call: p419f3742$p910eef8c.resetForTests
    }

    public List<object> AlpnProtocolNames(List<object> P0)
    {
        // str: "protocols"
        // call: IEnumerator<object>.hasNext
        // call: CollectionsKt.collectionSizeOrDefault
        // call: ICollection<object>.add
        // call: IEnumerable<object>.iterator
        // call: IEnumerator<object>.next
        // call: List<object>.<init>
        // call: p888a77f5.toString
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.p888a77f5.f1d02efaf
        // type: List<object>
        return default!;
    }

    public byte[] ConcatLengthPrefixed(List<object> P0)
    {
        // str: "protocols"
        // call: p7e62bc34.readByteArray
        // call: p7e62bc34.writeByte
        // call: p7e62bc34.writeUtf8
        // call: IEnumerator<object>.hasNext
        // call: string.length
        // call: p7e62bc34.<init>
        // call: List<object>.iterator
        // call: p419f3742$p910eef8c.alpnProtocolNames
        // call: IEnumerator<object>.next
        // call: Intrinsics.checkNotNullParameter
        // type: p7e62bc34
        return default!;
    }

    public p419f3742 Get()
    {
        // call: p419f3742.access$getPlatform$cp
        return default!;
    }

    public bool IsAndroid()
    {
        // str: "java.vm.name"
        // str: "Dalvik"
        // call: Intrinsics.areEqual
        // call: System.getProperty
        return false;
    }

    public void ResetForTests(p419f3742 P0)
    {
        // str: "platform"
        // call: p419f3742.access$setPlatform$cp
        // call: Intrinsics.checkNotNullParameter
    }

}
