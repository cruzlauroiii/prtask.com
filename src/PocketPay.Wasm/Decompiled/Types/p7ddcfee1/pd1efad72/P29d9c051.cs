namespace WillowMaze.Wasm.Decompiled;

public class P29d9c051
{
    private static bool ContainsInvalidHostnameAsciiCodes(string P0)
    {
        // str: " #%/:?@[\\]"
        // call: Intrinsics.compare
        // call: StringsKt.indexOf$default
        // call: string.charAt
        // call: string.length
        return false;
    }

    private static bool DecodeIpv4Suffix(string P0, int P1, int P2, byte[] P3, int P4)
    {
        // call: string.charAt
        // call: Intrinsics.compare
        return false;
    }

    private static InetAddress DecodeIpv6(string P0, int P1, int P2)
    {
        // str: ":"
        // str: "d77a3b5e20be592e03a8631f951937a9c5f27fcc6852ea92b4c2cfb8bf"
        // str: "::"
        // call: InetAddress.getByAddress
        // call: DecryptString.decryptString
        // call: p23e8a4b4.parseHexDigit
        // call: string.charAt
        // call: StringsKt.startsWith$default
        // call: p29d9c051.decodeIpv4Suffix
        // call: System.arraycopy
        // call: Arrays.fill
        return default!;
    }

    private static string Inet6AddressToAscii(byte[] P0)
    {
        // call: p7e62bc34.writeByte
        // call: p7e62bc34.<init>
        // call: p23e8a4b4.and
        // call: p7e62bc34.readUtf8
        // call: p7e62bc34.writeHexadecimalUnsignedLong
        // type: p7e62bc34
        return string.Empty;
    }

    public static string ToCanonicalHost(string P0)
    {
        // str: "]"
        // str: ":"
        // str: "toASCII(host)"
        // str: "US"
        // str: "this as java.lang.String).toLowerCase(locale)"
        // str: "address"
        // str: "Invalid IPv6 address: '"
        // str: "["
        // str: "<this>"
        // call: string.length
        // call: StringsKt.startsWith$default
        // call: Intrinsics.checkNotNullParameter
        // call: StringBuilder.toString
        // call: IDN.toASCII
        // call: Intrinsics.checkNotNullExpressionValue
        // call: string.toLowerCase
        // call: CharSequence.length
        // call: p29d9c051.containsInvalidHostnameAsciiCodes
        // call: InetAddress.getAddress
        // call: InetAddress.getHostAddress
        // call: StringBuilder.<init>
        // call: StringsKt.contains$default
        // call: StringBuilder.append
        // call: StringsKt.endsWith$default
        // call: AssertionError.<init>
        // call: p29d9c051.inet6AddressToAscii
        // call: p29d9c051.decodeIpv6
        // field: java.util.Locale.US
        // type: AssertionError
        // type: StringBuilder
        return string.Empty;
    }

}
