namespace WillowMaze.Wasm.Decompiled;

public class Pa7af2095 : IDisposable, Flushable
{
    public static long F01e1ac99;
    public static string F03f6807f;
    public static string F05f3e9da;
    public static string F0fb31421;
    public static string F232e96f0;
    public static string F2e5f812b;
    public static string F3466fab4;
    public static string F38b81044;
    public static long F38f21b8a;
    public static string F4180e779;
    public static string F49d74138;
    public static string F5135d9c3;
    public static string F5fd9c8a8;
    public static string F6e6a964f;
    public static string F78baf367;
    public static string F7da982ad;
    public static string F7de3981a;
    public static string F82af524a;
    public static string F89c17b2d;
    public static string F8b7e5ea4;
    public static pa7af2095$p910eef8c F910eef8c;
    public static Regex F920ffee4;
    public static string Fa01d0436;
    public static string Fa5e01630;
    public static string Fa671a6ff;
    public static string Fa6b5a3f7;
    public static string Fa88a6a0c;
    public static string Fab6f969f;
    public static string Fad0795b1;
    public static string Fcff42d76;
    public static pa7af2095$p910eef8c Fd8705543;
    public static Regex Fd94ab8a4;
    public static string Feb651331;
    public static pa7af2095$p910eef8c Ff088032e;
    public static string Ffe8fa6eb;
    private readonly string F00bb6dac;
    private bool F01385ca4;
    private bool F056d2229;
    private int F06db5836;
    private bool F0749df5e;
    private readonly string F13252938;
    private readonly string F14182f78;
    private readonly string F1885bb20;
    private readonly p6d96efb7 F1b899685;
    private long F1d3e937b;
    private bool F2289305d;
    private bool F23e9a964;
    private long F2554b701;
    private readonly pa7af2095$p6be1458b$1 F313aef84;
    private readonly Dictionary<string, object> F331b0d39;
    private bool F343a71ce;
    private bool F349e6863;
    private readonly int F36f03369;
    private bool F380f2e2c;
    private readonly Dictionary<string, object> F3851866c;
    private readonly string F39149ba5;
    private readonly string F3c3c7378;
    private bool F3d3f5003;
    private bool F3da807a7;
    private readonly int F3ec0f2a5;
    private readonly pe2d63d19 F43c6a763;
    private int F44a4a22f;
    private readonly pe2d63d19 F44d4d4eb;
    private readonly pa7af2095$p6be1458b$1 F49cc5cde;
    private p08d84bc6 F4f7b3dc8;
    private readonly p6d96efb7 F52200b19;
    private readonly string F5310002e;
    private readonly string F5f8f22b8;
    private long F61ad0efc;
    private readonly pe2d63d19 F633f95db;
    private readonly Dictionary<string, object> F63d88d14;
    private readonly pa7af2095$p6be1458b$1 F66b7cb91;
    private readonly int F69db7801;
    private readonly pa7af2095$p6be1458b$1 F6be1458b;
    private readonly string F760c962a;
    private bool F84d10a1e;
    private readonly pa7af2095$p6be1458b$1 F8b67165f;
    private readonly string F8f0db097;
    private readonly Dictionary<string, object> F9149dd93;
    private readonly string F921c7130;
    private readonly pe2d63d19 F93d54879;
    private p08d84bc6 F9cb65621;
    private long F9dd4d71e;
    private int F9f271eb1;
    private readonly string Fa16a3aba;
    private readonly int Fa30c57cc;
    private readonly pe2d63d19 Fa75f232a;
    private int Facf4170a;
    private readonly string Fb0f51510;
    private readonly int Fb35e8ea3;
    private readonly string Fb460ae14;
    private readonly int Fb64c1364;
    private long Fb78e1120;
    private bool Fb9df24c6;
    private bool Fbb051fc7;
    private readonly string Fbbefe2c3;
    private p08d84bc6 Fc60a3903;
    private bool Fc676f06f;
    private long Fc7489078;
    private readonly string Fc9e5ded6;
    private bool Fca9b646c;
    private bool Fcab6baa7;
    private long Fcc451db8;
    private bool Fcdd52788;
    private bool Fd2fa8384;
    private p08d84bc6 Fd9387072;
    private p08d84bc6 Fd99fc47d;
    private bool Fdccfcc0d;
    private bool Fe23606a0;
    private readonly int Fe7f1edc6;
    private bool Ff16337dd;
    private long Ff7bd60b7;
    private readonly string Ff986d2b2;
    private bool Ffe4a469c;
    private bool Ffe893fe7;

    public static bool Access$getCivilizedFileSystem$p(pa7af2095 P0)
    {
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f2289305d
        return false;
    }

    public static bool Access$getInitialized$p(pa7af2095 P0)
    {
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f84d10a1e
        return false;
    }

    public static bool Access$journalRebuildRequired(pa7af2095 P0)
    {
        // call: pa7af2095.journalRebuildRequired
        return false;
    }

    public static void Access$setHasJournalErrors$p(pa7af2095 P0, bool P1)
    {
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fbb051fc7
    }

    public static void Access$setJournalWriter$p(pa7af2095 P0, p08d84bc6 P1)
    {
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f9cb65621
    }

    public static void Access$setMostRecentRebuildFailed$p(pa7af2095 P0, bool P1)
    {
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.ffe893fe7
    }

    public static void Access$setMostRecentTrimFailed$p(pa7af2095 P0, bool P1)
    {
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fb9df24c6
    }

    public static void Access$setRedundantOpCount$p(pa7af2095 P0, int P1)
    {
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.facf4170a
    }

    private void CheckNotClosed()
    {
        // str: "cache is closed"
        // call: object.toString
        // call: IllegalStateException.<init>
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f349e6863
        // type: IllegalStateException
    }

    public static pa7af2095$p344a7f42 Edit$default(pa7af2095 P0, string P1, long P2, int P3, object P4)
    {
        // call: pa7af2095.edit
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f01e1ac99
        return default!;
    }

    private bool JournalRebuildRequired()
    {
        // call: Dictionary<string, object>.size
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.facf4170a
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f3851866c
        return false;
    }

    private p08d84bc6 NewJournalWriter()
    {
        // call: pa7af2095$p8e2b0dfd$p99124190$1.<init>
        // call: pe2d63d19.appendingSink
        // call: p0bbab913.<init>
        // call: p0af9afa4.m7f2db423
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f44d4d4eb
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f3c3c7378
        // type: pa7af2095$p8e2b0dfd$p99124190$1
        // type: p0bbab913
        return default!;
    }

    private void ProcessJournal()
    {
        // str: "i.next()"
        // call: pa7af2095$pb948e8a0.getCleanFiles$okhttp
        // call: pa7af2095$pb948e8a0.setCurrentEditor$okhttp
        // call: Dictionary<string, object>.values
        // call: IEnumerator<object>.remove
        // call: List<object>.get
        // call: pe2d63d19.delete
        // call: IEnumerator<object>.next
        // call: pa7af2095$pb948e8a0.getDirtyFiles$okhttp
        // call: ICollection<object>.iterator
        // call: pa7af2095$pb948e8a0.getLengths$okhttp
        // call: pa7af2095$pb948e8a0.getCurrentEditor$okhttp
        // call: IEnumerator<object>.hasNext
        // call: Intrinsics.checkNotNullExpressionValue
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f44d4d4eb
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.ff7bd60b7
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fa30c57cc
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f3851866c
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fbbefe2c3
    }

    private void ReadJournal()
    {
        // str: "unexpected journal header: ["
        // str: ", "
        // call: pa7af2095.getLruEntries$okhttp
        // call: Dictionary<string, object>.size
        // call: pcc81e3f6.exhausted
        // call: pa7af2095.rebuildJournal$okhttp
        // call: pa7af2095.newJournalWriter
        // call: CloseableKt.closeFinally
        // call: pe2d63d19.source
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: IOException.<init>
        // call: p0af9afa4.m7f2db423
        // call: pcc81e3f6.readUtf8LineStrict
        // call: Intrinsics.areEqual
        // call: string.valueOf
        // call: pa7af2095.getValueCount$okhttp
        // call: CharSequence.length
        // call: pa7af2095.readJournalLine
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.facf4170a
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f9cb65621
        // field: kotlin.Unit.INSTANCE
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f44d4d4eb
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fcff42d76
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f03f6807f
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fb64c1364
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f3c3c7378
        // type: IOException
        // type: StringBuilder
    }

    private void ReadJournalLine(string P0)
    {
        // str: "this as java.lang.String…ing(startIndex, endIndex)"
        // str: "this as java.lang.String).substring(startIndex)"
        // str: "unexpected journal line: "
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Dictionary<string, object>.put
        // call: pa7af2095$pb948e8a0.setCurrentEditor$okhttp
        // call: string.length
        // call: StringsKt.indexOf$default
        // call: string.substring
        // call: StringsKt.startsWith$default
        // call: Intrinsics.stringPlus
        // call: Dictionary<string, object>.get
        // call: IOException.<init>
        // call: pa7af2095$pb948e8a0.setLengths$okhttp
        // call: pa7af2095$p344a7f42.<init>
        // call: pa7af2095$pb948e8a0.setReadable$okhttp
        // call: pa7af2095$pb948e8a0.<init>
        // call: Dictionary<string, object>.remove
        // call: StringsKt.split$default
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f3851866c
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fa88a6a0c
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f5fd9c8a8
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f3466fab4
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f78baf367
        // type: IOException
        // type: pa7af2095$p344a7f42
        // type: pa7af2095$pb948e8a0
    }

    private bool RemoveOldestEntry()
    {
        // str: "toEvict"
        // call: IEnumerator<object>.hasNext
        // call: Dictionary<string, object>.values
        // call: IEnumerator<object>.next
        // call: pa7af2095$pb948e8a0.getZombie$okhttp
        // call: Intrinsics.checkNotNullExpressionValue
        // call: pa7af2095.removeEntry$okhttp
        // call: ICollection<object>.iterator
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f3851866c
        return false;
    }

    private void ValidateKey(string P0)
    {
        // str: "keys must match regex [a-z0-9_-]{1,120}: \""
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: object.toString
        // call: Regex.matches
        // call: IllegalArgumentException.<init>
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fd94ab8a4
        // type: IllegalArgumentException
        // type: StringBuilder
    }

    public void Close()
    {
        // str: "lruEntries.values"
        // str: "null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.t..."
        // call: Dictionary<string, object>.values
        // call: Intrinsics.checkNotNullExpressionValue
        // call: ICollection<object>.toArray
        // call: pa7af2095$pb948e8a0.getCurrentEditor$okhttp
        // call: pa7af2095$p344a7f42.detach$okhttp
        // call: pa7af2095.trimToSize
        // call: Intrinsics.checkNotNull
        // call: p08d84bc6.close
        // call: NullPointerException.<init>
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f84d10a1e
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f349e6863
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f3851866c
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f9cb65621
        // type: NullPointerException
    }

    public void CompleteEdit$okhttp(pa7af2095$p344a7f42 P0, bool P1)
    {
        // str: "Newly created entry didn't create value for index "
        // str: "Check failed."
        // str: "editor"
        // call: pa7af2095$p344a7f42.abort
        // call: int.valueOf
        // call: Intrinsics.stringPlus
        // call: IllegalStateException.<init>
        // call: pa7af2095$pb948e8a0.getDirtyFiles$okhttp
        // call: List<object>.get
        // call: pa7af2095$pb948e8a0.getZombie$okhttp
        // call: pe2d63d19.exists
        // call: pa7af2095$pb948e8a0.getCleanFiles$okhttp
        // call: pe2d63d19.rename
        // call: pa7af2095$pb948e8a0.getLengths$okhttp
        // call: pe2d63d19.size
        // call: pe2d63d19.delete
        // call: pa7af2095$pb948e8a0.setCurrentEditor$okhttp
        // call: pa7af2095.removeEntry$okhttp
        // call: object.toString
        // call: Intrinsics.checkNotNull
        // call: pa7af2095$pb948e8a0.getReadable$okhttp
        // call: pa7af2095.getLruEntries$okhttp
        // call: pa7af2095$pb948e8a0.getKey$okhttp
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fa30c57cc
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f44d4d4eb
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.ff7bd60b7
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.facf4170a
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f9cb65621
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f78baf367
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fa88a6a0c
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fcc451db8
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fb78e1120
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f1b899685
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f6be1458b
        // type: IllegalStateException
    }

    public void Delete()
    {
        // call: pe2d63d19.deleteContents
        // call: pa7af2095.close
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f44d4d4eb
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f5f8f22b8
    }

    public pa7af2095$p344a7f42 Edit(string P0)
    {
        // str: "key"
        // call: pa7af2095.edit$default
        // call: Intrinsics.checkNotNullParameter
        return default!;
    }

    public pa7af2095$p344a7f42 Edit(string P0, long P1)
    {
        // str: "key"
        // call: Intrinsics.checkNotNull
        // call: p08d84bc6.writeUtf8
        // call: p08d84bc6.writeByte
        // call: p08d84bc6.flush
        // call: p6d96efb7.schedule$default
        // call: pa7af2095$pb948e8a0.<init>
        // call: Dictionary<string, object>.put
        // call: pa7af2095$p344a7f42.<init>
        // call: pa7af2095$pb948e8a0.setCurrentEditor$okhttp
        // call: pa7af2095$pb948e8a0.getCurrentEditor$okhttp
        // call: pa7af2095$pb948e8a0.getLockingSourceCount$okhttp
        // call: Intrinsics.checkNotNullParameter
        // call: pa7af2095.initialize
        // call: pa7af2095.checkNotClosed
        // call: pa7af2095.validateKey
        // call: Dictionary<string, object>.get
        // call: pa7af2095$pb948e8a0.getSequenceNumber$okhttp
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fb9df24c6
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.ffe893fe7
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f9cb65621
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f5fd9c8a8
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fbb051fc7
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f1b899685
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f6be1458b
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f3851866c
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f01e1ac99
        // type: pa7af2095$pb948e8a0
        // type: pa7af2095$p344a7f42
        return default!;
    }

    public void EvictAll()
    {
        // str: "null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.t..."
        // str: "lruEntries.values"
        // str: "entry"
        // call: NullPointerException.<init>
        // call: pa7af2095.initialize
        // call: Dictionary<string, object>.values
        // call: Intrinsics.checkNotNullExpressionValue
        // call: ICollection<object>.toArray
        // call: pa7af2095.removeEntry$okhttp
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f3851866c
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fb9df24c6
        // type: NullPointerException
    }

    public void Flush()
    {
        // call: pa7af2095.checkNotClosed
        // call: pa7af2095.trimToSize
        // call: Intrinsics.checkNotNull
        // call: p08d84bc6.flush
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f84d10a1e
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f9cb65621
    }

    public pa7af2095$pd4e2713d Get(string P0)
    {
        // str: "key"
        // call: Intrinsics.checkNotNullParameter
        // call: pa7af2095.initialize
        // call: pa7af2095.checkNotClosed
        // call: pa7af2095.validateKey
        // call: Dictionary<string, object>.get
        // call: Intrinsics.checkNotNull
        // call: p08d84bc6.writeUtf8
        // call: p08d84bc6.writeByte
        // call: pa7af2095.journalRebuildRequired
        // call: p6d96efb7.schedule$default
        // call: pa7af2095$pb948e8a0.snapshot$okhttp
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f3851866c
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.facf4170a
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f9cb65621
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f3466fab4
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f1b899685
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f6be1458b
        return default!;
    }

    public bool GetClosed$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f349e6863
        return false;
    }

    public string GetDirectory()
    {
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f5f8f22b8
        return string.Empty;
    }

    public pe2d63d19 GetFileSystem$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f44d4d4eb
        return default!;
    }

    public Dictionary<string, object> GetLruEntries$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f3851866c
        return default!;
    }

    public long GetMaxSize()
    {
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fb78e1120
        return 0;
    }

    public int GetValueCount$okhttp()
    {
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fa30c57cc
        return 0;
    }

    public void Initialize()
    {
        // str: " is corrupt: "
        // str: ", removing"
        // str: "DiskLruCache "
        // str: "Thread "
        // str: " MUST hold lock on "
        // call: p419f3742$p910eef8c.get
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: IOException.getMessage
        // call: StringBuilder.toString
        // call: p419f3742.log
        // call: pa7af2095.delete
        // call: pa7af2095.rebuildJournal$okhttp
        // call: pe2d63d19.exists
        // call: pe2d63d19.delete
        // call: pe2d63d19.rename
        // call: p23e8a4b4.isCivilized
        // call: pa7af2095.readJournal
        // call: pa7af2095.processJournal
        // call: Thread.holdsLock
        // call: Thread.currentThread
        // call: Thread.getName
        // call: AssertionError.<init>
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f5f8f22b8
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f349e6863
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f84d10a1e
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f44d4d4eb
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f921c7130
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f3c3c7378
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f2289305d
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // type: StringBuilder
        // type: AssertionError
    }

    public bool IsClosed()
    {
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f349e6863
        return false;
    }

    public void RebuildJournal$okhttp()
    {
        // call: CloseableKt.closeFinally
        // call: pe2d63d19.exists
        // call: pe2d63d19.rename
        // call: pe2d63d19.delete
        // call: pa7af2095.newJournalWriter
        // call: p08d84bc6.close
        // call: pe2d63d19.sink
        // call: p0af9afa4.m7f2db423
        // call: p08d84bc6.writeUtf8
        // call: p08d84bc6.writeByte
        // call: p08d84bc6.writeDecimalLong
        // call: pa7af2095.getValueCount$okhttp
        // call: pa7af2095.getLruEntries$okhttp
        // call: Dictionary<string, object>.values
        // call: ICollection<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: pa7af2095$pb948e8a0.getCurrentEditor$okhttp
        // call: pa7af2095$pb948e8a0.getKey$okhttp
        // call: pa7af2095$pb948e8a0.writeLengths$okhttp
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f44d4d4eb
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f3c3c7378
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f921c7130
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fbbefe2c3
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f9cb65621
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fbb051fc7
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.ffe893fe7
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fcff42d76
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f03f6807f
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fb64c1364
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f5fd9c8a8
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fa88a6a0c
        // field: kotlin.Unit.INSTANCE
    }

    public bool Remove(string P0)
    {
        // str: "key"
        // call: pa7af2095.removeEntry$okhttp
        // call: Intrinsics.checkNotNullParameter
        // call: pa7af2095.initialize
        // call: pa7af2095.checkNotClosed
        // call: pa7af2095.validateKey
        // call: Dictionary<string, object>.get
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.ff7bd60b7
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fb78e1120
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fb9df24c6
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f3851866c
        return false;
    }

    public bool RemoveEntry$okhttp(pa7af2095$pb948e8a0 P0)
    {
        // str: "entry"
        // call: p08d84bc6.writeByte
        // call: p08d84bc6.writeUtf8
        // call: List<object>.get
        // call: pa7af2095$pb948e8a0.getLengths$okhttp
        // call: pa7af2095$pb948e8a0.getLockingSourceCount$okhttp
        // call: Intrinsics.checkNotNullParameter
        // call: pa7af2095$pb948e8a0.getKey$okhttp
        // call: pa7af2095$pb948e8a0.getCurrentEditor$okhttp
        // call: p6d96efb7.schedule$default
        // call: pa7af2095.journalRebuildRequired
        // call: Dictionary<string, object>.remove
        // call: p08d84bc6.flush
        // call: pe2d63d19.delete
        // call: pa7af2095$pb948e8a0.getCleanFiles$okhttp
        // call: pa7af2095$p344a7f42.detach$okhttp
        // call: pa7af2095$pb948e8a0.setZombie$okhttp
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f78baf367
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f9cb65621
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.facf4170a
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.ff7bd60b7
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f2289305d
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fa30c57cc
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f3851866c
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f6be1458b
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f5fd9c8a8
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f44d4d4eb
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f1b899685
        return false;
    }

    public void SetClosed$okhttp(bool P0)
    {
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f349e6863
    }

    public void SetMaxSize(long P0)
    {
        // call: p6d96efb7.schedule$default
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fb78e1120
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f84d10a1e
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f1b899685
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.f6be1458b
    }

    public long Size()
    {
        // call: pa7af2095.initialize
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.ff7bd60b7
        return 0;
    }

    public IEnumerator<object> Snapshots()
    {
        // call: pa7af2095.initialize
        // call: pa7af2095$p69563329$1.<init>
        // type: pa7af2095$p69563329$1
        return default!;
    }

    public void TrimToSize()
    {
        // call: pa7af2095.removeOldestEntry
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fb9df24c6
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.ff7bd60b7
        // field: p7ddcfee1.pd1efad72.p0fea6a13.pa7af2095.fb78e1120
    }

}
