namespace WillowMaze.Wasm.Decompiled;

public class P23e8a4b4
{
    public static p883d7615 F12ea5829;
    public static bool F13c6c92d;
    public static byte[] F166340b1;
    private static pdae8ace1 F39712ba0;
    public static p0d3cf03b F3c2531ea;
    public static string F3d22ebcb;
    public static string F49b09214;
    private static Regex F6098fc2a;
    private static pdae8ace1 F69bae5a1;
    public static p883d7615 F6a1c2c1a;
    public static bool F6b82155d;
    public static TimeZoneInfo F7c236c67;
    public static string F8a2e3fb3;
    public static TimeZoneInfo F9234324d;
    public static p883d7615 F95117f2b;
    public static p0d3cf03b F955ee983;
    public static string F9c2e39df;
    private static Regex Fa398d402;
    public static p42c567ea Fafc9db28;
    public static TimeZoneInfo Fb6f26933;
    public static byte[] Fb7c07aae;
    public static bool Fc549b1fe;
    public static bool Fc7a55bf6;
    private static Regex Fd0639744;
    public static p0d3cf03b Fd59dd2f2;
    public static string Fd75ce000;
    private static Regex Fd953170e;
    public static byte[] Fe0a0c85d;
    private static Regex Fe27a744c;
    public static p42c567ea Fe3a113da;
    public static byte[] Ff39c2294;
    public static string Ffa71f997;
    public static string Ffcd12e30;

    public static Thread $r8$lambda$I0ugdNeD8ukX5wZ78GMIzB6svEc(string P0, bool P1, Action P2)
    {
        // call: p23e8a4b4.threadFactory$lambda-1
        return default!;
    }

    public static p4f9a1811 $r8$lambda$axE76qkBaw0kHFTAwPF_6zUWBjE(p4f9a1811 P0, pc3755e61 P1)
    {
        // call: p23e8a4b4.asFactory$lambda-8
        return default!;
    }

    public static void AddIfAbsent(List<object> P0, object P1)
    {
        // str: "<this>"
        // call: List<object>.contains
        // call: List<object>.add
        // call: Intrinsics.checkNotNullParameter
    }

    public static int And(byte P0, int P1)
    {
        return 0;
    }

    public static int And(short P0, int P1)
    {
        return 0;
    }

    public static long And(int P0, long P1)
    {
        return 0;
    }

    public static p4f9a1811$p1c6e980e AsFactory(p4f9a1811 P0)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: p23e8a4b4$pd41d8cd9$p95263d50.<init>
        // type: p23e8a4b4$pd41d8cd9$p95263d50
        return default!;
    }

    private static p4f9a1811 AsFactory$lambda-8(p4f9a1811 P0, pc3755e61 P1)
    {
        // str: "$this_asFactory"
        // str: "it"
        // call: Intrinsics.checkNotNullParameter
        return default!;
    }

    public static void AssertThreadDoesntHoldLock(object P0)
    {
        // str: " MUST NOT hold lock on "
        // str: "Thread "
        // str: "<this>"
        // call: StringBuilder.append
        // call: Thread.holdsLock
        // call: StringBuilder.toString
        // call: AssertionError.<init>
        // call: StringBuilder.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: Thread.currentThread
        // call: Thread.getName
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // type: AssertionError
        // type: StringBuilder
    }

    public static void AssertThreadHoldsLock(object P0)
    {
        // str: " MUST hold lock on "
        // str: "<this>"
        // str: "Thread "
        // call: StringBuilder.append
        // call: Thread.getName
        // call: Thread.currentThread
        // call: Thread.holdsLock
        // call: Intrinsics.checkNotNullParameter
        // call: StringBuilder.toString
        // call: AssertionError.<init>
        // call: StringBuilder.<init>
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // type: AssertionError
        // type: StringBuilder
    }

    public static bool CanParseAsIpAddress(string P0)
    {
        // str: "<this>"
        // call: Regex.matches
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fd953170e
        return false;
    }

    public static bool CanReuseConnectionFor(pdfadebdd P0, pdfadebdd P1)
    {
        // str: "other"
        // str: "<this>"
        // call: pdfadebdd.port
        // call: pdfadebdd.host
        // call: pdfadebdd.scheme
        // call: Intrinsics.areEqual
        // call: Intrinsics.checkNotNullParameter
        return false;
    }

    public static int CheckDuration(string P0, long P1, TimeUnit P2)
    {
        // str: " too small."
        // str: " < 0"
        // str: " too large."
        // str: "unit == null"
        // str: "name"
        // call: IllegalStateException.<init>
        // call: object.toString
        // call: IllegalArgumentException.<init>
        // call: Intrinsics.stringPlus
        // call: Intrinsics.checkNotNullParameter
        // call: TimeUnit.toMillis
        // type: IllegalArgumentException
        // type: IllegalStateException
        return 0;
    }

    public static void CheckOffsetAndCount(long P0, long P1, long P2)
    {
        // call: ArrayIndexOutOfBoundsException.<init>
        // type: ArrayIndexOutOfBoundsException
    }

    public static void CloseQuietly(IDisposable P0)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: IDisposable.close
    }

    public static void CloseQuietly(ServerSocket P0)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: ServerSocket.close
    }

    public static void CloseQuietly(Socket P0)
    {
        // str: "bio == null"
        // str: "<this>"
        // call: Exception.getMessage
        // call: Intrinsics.areEqual
        // call: Intrinsics.checkNotNullParameter
        // call: Socket.close
    }

    public static string[] Concat(string[] P0, string P1)
    {
        // str: "value"
        // str: "<this>"
        // str: "copyOf(this, newSize)"
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Arrays.copyOf
        // call: ArraysKt.getLastIndex
        return default!;
    }

    public static int DelimiterOffset(string P0, char P1, int P2, int P3)
    {
        // str: "<this>"
        // call: string.charAt
        // call: Intrinsics.checkNotNullParameter
        return 0;
    }

    public static int DelimiterOffset(string P0, string P1, int P2, int P3)
    {
        // str: "<this>"
        // str: "delimiters"
        // call: Intrinsics.checkNotNullParameter
        // call: StringsKt.contains$default
        // call: string.charAt
        return 0;
    }

    public static int DelimiterOffset$default(string P0, char P1, int P2, int P3, int P4, object P5)
    {
        // call: string.length
        // call: p23e8a4b4.delimiterOffset
        return 0;
    }

    public static int DelimiterOffset$default(string P0, string P1, int P2, int P3, int P4, object P5)
    {
        // call: p23e8a4b4.delimiterOffset
        // call: string.length
        return 0;
    }

    public static bool Discard(pf31bbdd1 P0, int P1, TimeUnit P2)
    {
        // str: "<this>"
        // str: "timeUnit"
        // call: Intrinsics.checkNotNullParameter
        // call: p23e8a4b4.skipAll
        return false;
    }

    public static List<object> FilterList(IEnumerable<object> P0, Func<object, object> P1)
    {
        // str: "<this>"
        // str: "predicate"
        // call: TypeIntrinsics.asMutableList
        // call: List<object>.add
        // call: IEnumerator<object>.hasNext
        // call: List<object>.isEmpty
        // call: Intrinsics.checkNotNullParameter
        // call: bool.booleanValue
        // call: IEnumerable<object>.iterator
        // call: Func<object, object>.invoke
        // call: CollectionsKt.emptyList
        // call: IEnumerator<object>.next
        // call: List<object>.<init>
        // type: List<object>
        return default!;
    }

    public static string Format(string P0, object[] P1)
    {
        // str: "format"
        // str: "args"
        // str: "format(locale, format, *args)"
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Arrays.copyOf
        // call: string.format
        // field: java.util.Locale.US
        // field: kotlin.jvm.internal.StringCompanionObject.INSTANCE
        return string.Empty;
    }

    public static bool HasIntersection(string[] P0, string[] P1, Comparator P2)
    {
        // str: "comparator"
        // str: "<this>"
        // call: IEnumerator<object>.next
        // call: Comparator.compare
        // call: Intrinsics.checkNotNullParameter
        // call: IEnumerator<object>.hasNext
        // call: ArrayIteratorKt.iterator
        return false;
    }

    public static long HeadersContentLength(pd64ed3e9 P0)
    {
        // str: "Content-Length"
        // str: "<this>"
        // call: pd64ed3e9.headers
        // call: p23e8a4b4.toLongOrDefault
        // call: Intrinsics.checkNotNullParameter
        // call: p883d7615.get
        return 0;
    }

    public static void IgnoreIoExceptions(Func<object> P0)
    {
        // str: "block"
        // call: Intrinsics.checkNotNullParameter
        // call: Func<object>.invoke
    }

    public static List<object> ImmutableListOf(object[] P0)
    {
        // str: "elements"
        // str: "unmodifiableList(listOf(*elements.clone()))"
        // call: Intrinsics.checkNotNullExpressionValue
        // call: object.clone
        // call: Collections.unmodifiableList
        // call: Intrinsics.checkNotNullParameter
        // call: Arrays.copyOf
        // call: CollectionsKt.listOf
        return default!;
    }

    public static int IndexOf(string[] P0, string P1, Comparator P2)
    {
        // str: "comparator"
        // str: "value"
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: Comparator.compare
        return 0;
    }

    public static int IndexOfControlOrNonAscii(string P0)
    {
        // str: "<this>"
        // call: string.charAt
        // call: Intrinsics.compare
        // call: Intrinsics.checkNotNullParameter
        // call: string.length
        return 0;
    }

    public static int IndexOfFirstNonAsciiWhitespace(string P0, int P1, int P2)
    {
        // str: "<this>"
        // call: string.charAt
        // call: Intrinsics.checkNotNullParameter
        return 0;
    }

    public static int IndexOfFirstNonAsciiWhitespace$default(string P0, int P1, int P2, int P3, object P4)
    {
        // call: p23e8a4b4.indexOfFirstNonAsciiWhitespace
        // call: string.length
        return 0;
    }

    public static int IndexOfLastNonAsciiWhitespace(string P0, int P1, int P2)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: string.charAt
        return 0;
    }

    public static int IndexOfLastNonAsciiWhitespace$default(string P0, int P1, int P2, int P3, object P4)
    {
        // call: string.length
        // call: p23e8a4b4.indexOfLastNonAsciiWhitespace
        return 0;
    }

    public static int IndexOfNonWhitespace(string P0, int P1)
    {
        // str: "<this>"
        // call: string.charAt
        // call: Intrinsics.checkNotNullParameter
        // call: string.length
        return 0;
    }

    public static int IndexOfNonWhitespace$default(string P0, int P1, int P2, object P3)
    {
        // call: p23e8a4b4.indexOfNonWhitespace
        return 0;
    }

    public static string[] Intersect(string[] P0, string[] P1, Comparator P2)
    {
        // str: "comparator"
        // str: "null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.t..."
        // str: "other"
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: List<object>.add
        // call: NullPointerException.<init>
        // call: List<object>.<init>
        // call: Comparator.compare
        // call: ICollection<object>.toArray
        // type: NullPointerException
        // type: List<object>
        return default!;
    }

    public static bool IsCivilized(pe2d63d19 P0, string P1)
    {
        // str: "file"
        // str: "<this>"
        // call: CloseableKt.closeFinally
        // call: pe2d63d19.sink
        // call: pe2d63d19.delete
        // call: Intrinsics.checkNotNullParameter
        // field: kotlin.Unit.INSTANCE
        return false;
    }

    public static bool IsHealthy(Socket P0, pcc81e3f6 P1)
    {
        // str: "source"
        // str: "<this>"
        // call: Socket.setSoTimeout
        // call: Socket.getSoTimeout
        // call: pcc81e3f6.exhausted
        // call: Intrinsics.checkNotNullParameter
        return false;
    }

    public static bool IsSensitiveHeader(string P0)
    {
        // str: "Proxy-Authorization"
        // str: "5f3c7066c42f7ba415e20663fb5a114a8e908ca686b9f4e5b35e47d35f4a5188c26c964adcc604ebdb"
        // str: "name"
        // str: "Cookie"
        // str: "Set-Cookie"
        // call: StringsKt.equals
        // call: DecryptString.decryptString
        // call: Intrinsics.checkNotNullParameter
        return false;
    }

    public static void Notify(object P0)
    {
        // str: "<this>"
        // call: object.notify
        // call: Intrinsics.checkNotNullParameter
    }

    public static void NotifyAll(object P0)
    {
        // str: "<this>"
        // call: object.notifyAll
        // call: Intrinsics.checkNotNullParameter
    }

    public static int ParseHexDigit(char P0)
    {
        return 0;
    }

    public static string PeerName(Socket P0)
    {
        // str: "address.hostName"
        // str: "<this>"
        // call: Socket.getRemoteSocketAddress
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.checkNotNullExpressionValue
        // call: SocketAddress.toString
        // call: InetSocketAddress.getHostName
        return string.Empty;
    }

    public static System.Text.Encoding ReadBomAsCharset(pcc81e3f6 P0, System.Text.Encoding P1)
    {
        // str: "default"
        // str: "UTF_16LE"
        // str: "UTF_16BE"
        // str: "UTF_8"
        // str: "<this>"
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Intrinsics.checkNotNullParameter
        // call: Charsets.UTF32_BE
        // call: AssertionError.<init>
        // call: pcc81e3f6.select
        // call: Charsets.UTF32_LE
        // field: java.nio.charset.StandardCharsets.UTF_16LE
        // field: kotlin.text.Charsets.INSTANCE
        // field: java.nio.charset.StandardCharsets.UTF_16BE
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.f69bae5a1
        // field: java.nio.charset.StandardCharsets.UTF_8
        // type: AssertionError
        return default!;
    }

    public static object ReadFieldOrNull(object P0, Type P1, string P2)
    {
        // str: "c.superclass"
        // str: "instance"
        // str: "fieldName"
        // str: "fieldType"
        // str: "delegate"
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Type.getDeclaredField
        // call: Field.setAccessible
        // call: Field.get
        // call: Type.isInstance
        // call: Type.cast
        // call: Intrinsics.areEqual
        // call: object.getClass
        // call: p23e8a4b4.readFieldOrNull
        // call: Type.getSuperclass
        // type: object
        return default!;
    }

    public static int ReadMedium(pcc81e3f6 P0)
    {
        // str: "<this>"
        // call: p23e8a4b4.and
        // call: Intrinsics.checkNotNullParameter
        // call: pcc81e3f6.readByte
        return 0;
    }

    public static int SkipAll(p7e62bc34 P0, byte P1)
    {
        // str: "<this>"
        // call: p7e62bc34.exhausted
        // call: p7e62bc34.readByte
        // call: Intrinsics.checkNotNullParameter
        // call: p7e62bc34.getByte
        return 0;
    }

    public static bool SkipAll(pf31bbdd1 P0, int P1, TimeUnit P2)
    {
        // str: "<this>"
        // str: "timeUnit"
        // call: pf31bbdd1.timeout
        // call: pc85a251c.deadlineNanoTime
        // call: pc85a251c.clearDeadline
        // call: Intrinsics.checkNotNullParameter
        // call: pc85a251c.hasDeadline
        // call: System.nanoTime
        // call: Math.min
        // call: p7e62bc34.<init>
        // call: pf31bbdd1.read
        // call: p7e62bc34.clear
        // call: TimeUnit.toNanos
        // type: p7e62bc34
        return false;
    }

    public static ThreadFactory ThreadFactory(string P0, bool P1)
    {
        // str: "name"
        // call: p23e8a4b4$pd41d8cd9$pcca4ef0e.<init>
        // call: Intrinsics.checkNotNullParameter
        // type: p23e8a4b4$pd41d8cd9$pcca4ef0e
        return default!;
    }

    private static Thread ThreadFactory$lambda-1(string P0, bool P1, Action P2)
    {
        // str: "$name"
        // call: Thread.setDaemon
        // call: Thread.<init>
        // call: Intrinsics.checkNotNullParameter
        // type: Thread
        return default!;
    }

    public static void ThreadName(string P0, Func<object> P1)
    {
        // str: "name"
        // str: "block"
        // call: Thread.getName
        // call: Thread.setName
        // call: Thread.currentThread
        // call: Intrinsics.checkNotNullParameter
        // call: Func<object>.invoke
    }

    public static List<object> ToHeaderList(p883d7615 P0)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: CollectionsKt.collectionSizeOrDefault
        // call: IntIterator.nextInt
        // call: IEnumerable<object>.iterator
        // call: RangesKt.until
        // call: List<object>.<init>
        // call: IEnumerator<object>.hasNext
        // call: p883d7615.value
        // call: ICollection<object>.add
        // call: p883d7615.name
        // call: pbf50d5e6.<init>
        // call: p883d7615.size
        // type: pbf50d5e6
        // type: List<object>
        return default!;
    }

    public static p883d7615 ToHeaders(List<object> P0)
    {
        // str: "<this>"
        // call: p58efa9e8.utf8
        // call: p883d7615$p2bd4a59b.<init>
        // call: IEnumerator<object>.next
        // call: IEnumerator<object>.hasNext
        // call: pbf50d5e6.component2
        // call: Intrinsics.checkNotNullParameter
        // call: pbf50d5e6.component1
        // call: List<object>.iterator
        // call: p883d7615$p2bd4a59b.build
        // call: p883d7615$p2bd4a59b.addLenient$okhttp
        // type: p883d7615$p2bd4a59b
        return default!;
    }

    public static string ToHexString(int P0)
    {
        // str: "toHexString(this)"
        // call: int.toHexString
        // call: Intrinsics.checkNotNullExpressionValue
        return string.Empty;
    }

    public static string ToHexString(long P0)
    {
        // str: "toHexString(this)"
        // call: long.toHexString
        // call: Intrinsics.checkNotNullExpressionValue
        return string.Empty;
    }

    public static string ToHostHeader(pdfadebdd P0, bool P1)
    {
        // str: ":"
        // str: "["
        // str: "<this>"
        // call: pdfadebdd$p910eef8c.defaultPort
        // call: StringBuilder.append
        // call: StringBuilder.<init>
        // call: pdfadebdd.host
        // call: StringBuilder.toString
        // call: pdfadebdd.scheme
        // call: Intrinsics.checkNotNullParameter
        // call: pdfadebdd.port
        // call: StringsKt.contains$default
        // field: p7ddcfee1.pdfadebdd.f910eef8c
        // type: StringBuilder
        return string.Empty;
    }

    public static string ToHostHeader$default(pdfadebdd P0, bool P1, int P2, object P3)
    {
        // call: p23e8a4b4.toHostHeader
        return string.Empty;
    }

    public static List<object> ToImmutableList(List<object> P0)
    {
        // str: "<this>"
        // str: "unmodifiableList(toMutableList())"
        // call: CollectionsKt.toMutableList
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Intrinsics.checkNotNullParameter
        // call: Collections.unmodifiableList
        return default!;
    }

    public static Dictionary<string, object> ToImmutableMap(Dictionary<string, object> P0)
    {
        // str: "<this>"
        // str: "{\n    Collections.unmodi…(LinkedHashMap(this))\n  }"
        // call: Dictionary<string, object>.<init>
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Collections.unmodifiableMap
        // call: Dictionary<string, object>.isEmpty
        // call: MapsKt.emptyMap
        // call: Intrinsics.checkNotNullParameter
        // type: Dictionary<string, object>
        return default!;
    }

    public static long ToLongOrDefault(string P0, long P1)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: long.parseLong
        return 0;
    }

    public static int ToNonNegativeInt(string P0, int P1)
    {
        // call: long.parseLong
        // call: long.valueOf
        // call: long.longValue
        return 0;
    }

    public static string TrimSubstring(string P0, int P1, int P2)
    {
        // str: "<this>"
        // str: "this as java.lang.String…ing(startIndex, endIndex)"
        // call: p23e8a4b4.indexOfFirstNonAsciiWhitespace
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.checkNotNullExpressionValue
        // call: string.substring
        // call: p23e8a4b4.indexOfLastNonAsciiWhitespace
        return string.Empty;
    }

    public static string TrimSubstring$default(string P0, int P1, int P2, int P3, object P4)
    {
        // call: string.length
        // call: p23e8a4b4.trimSubstring
        return string.Empty;
    }

    public static void Wait(object P0)
    {
        // str: "<this>"
        // call: Intrinsics.checkNotNullParameter
        // call: object.wait
    }

    public static Exception WithSuppressed(Exception P0, List<object> P1)
    {
        // str: "<this>"
        // str: "suppressed"
        // call: Intrinsics.checkNotNullParameter
        // call: TextWriter.println
        // call: IEnumerator<object>.hasNext
        // call: List<object>.size
        // call: List<object>.iterator
        // call: IEnumerator<object>.next
        // call: ExceptionsKt.addSuppressed
        // field: java.lang.System.out
        return default!;
    }

    public static void WriteMedium(p08d84bc6 P0, int P1)
    {
        // str: "<this>"
        // call: p08d84bc6.writeByte
        // call: Intrinsics.checkNotNullParameter
    }

}
