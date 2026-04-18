namespace WillowMaze.Wasm.Decompiled;

public class Pe5e1ca24
{
    public static pe5e1ca24$p910eef8c F47856a44;
    public static pe5e1ca24$p910eef8c F910eef8c;
    private readonly long F080ef4c4;
    private readonly ConcurrentLinkedQueue F08b48662;
    private readonly p6d96efb7 F1b899685;
    private readonly ConcurrentLinkedQueue F1e4e0a3e;
    private readonly int F46984842;
    private readonly p6d96efb7 F5b9968f5;
    private readonly ConcurrentLinkedQueue F5fda3f15;
    private readonly long F66c87832;
    private readonly p6d96efb7 F6b1108da;
    private readonly pe5e1ca24$p6be1458b$1 F6be1458b;
    private readonly long F75d1a1d5;
    private readonly long F87824bfb;
    private readonly ConcurrentLinkedQueue F87d9c1ae;
    private readonly ConcurrentLinkedQueue F91c4b75d;
    private readonly int Fc0a17d45;
    private readonly long Fcc3f6159;
    private readonly p6d96efb7 Fdc5247af;
    private readonly pe5e1ca24$p6be1458b$1 Fecde5910;

    private int PruneAndGetAllocationCount(pc2c7dd60 P0, long P1)
    {
        // str: " MUST hold lock on "
        // str: " was leaked. Did you forget to close a response body?"
        // str: "A connection to "
        // str: "Thread "
        // call: List<object>.size
        // call: p9405c3af.address
        // call: pdd7bf230.url
        // call: p6d310f89$p73392f00.getCallStackTrace
        // call: List<object>.remove
        // call: StringBuilder.toString
        // call: List<object>.get
        // call: p419f3742$p910eef8c.get
        // call: Thread.getName
        // call: p419f3742.logCloseableLeak
        // call: StringBuilder.append
        // call: pc2c7dd60.setIdleAtNs$okhttp
        // call: StringBuilder.<init>
        // call: pc2c7dd60.getCalls
        // call: Thread.holdsLock
        // call: pc2c7dd60.setNoNewExchanges
        // call: List<object>.isEmpty
        // call: Reference.get
        // call: pc2c7dd60.route
        // call: AssertionError.<init>
        // field: p7ddcfee1.pd1efad72.p34a6e5d6.p419f3742.f910eef8c
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // field: p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24.f080ef4c4
        // type: StringBuilder
        // type: AssertionError
        return 0;
    }

    public bool CallAcquirePooledConnection(pdd7bf230 P0, p6d310f89 P1, List<object> P2, bool P3)
    {
        // str: "address"
        // str: "11b054a357ab9ad5411b5f50df6db57d951addeb25e9dc9f04d6d4c7a083039689b2d7c2e633"
        // str: "call"
        // call: IEnumerator<object>.next
        // call: pc2c7dd60.isMultiplexed$okhttp
        // call: pc2c7dd60.isEligible$okhttp
        // call: Intrinsics.checkNotNullExpressionValue
        // call: IEnumerator<object>.hasNext
        // call: Intrinsics.checkNotNullParameter
        // call: ConcurrentLinkedQueue.iterator
        // call: p6d310f89.acquireConnectionNoEvents
        // call: DecryptString.decryptString
        // field: p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24.f1e4e0a3e
        // field: kotlin.Unit.INSTANCE
        return false;
    }

    public long Cleanup(long P0)
    {
        // str: "aa91c1f958bec2644b37f57abc614cee0f2c33a1e3328c6469f7e31068887cfab75cbf35186c"
        // call: pc2c7dd60.getCalls
        // call: ICollection<object>.isEmpty
        // call: Intrinsics.checkNotNullExpressionValue
        // call: DecryptString.decryptString
        // call: pe5e1ca24.pruneAndGetAllocationCount
        // call: int.valueOf
        // call: pc2c7dd60.getIdleAtNs$okhttp
        // call: pc2c7dd60.setNoNewExchanges
        // call: ConcurrentLinkedQueue.remove
        // call: IEnumerator<object>.hasNext
        // call: Intrinsics.checkNotNull
        // call: p6d96efb7.cancelAll
        // call: pc2c7dd60.socket
        // call: IEnumerator<object>.next
        // call: ConcurrentLinkedQueue.iterator
        // call: ConcurrentLinkedQueue.isEmpty
        // call: p23e8a4b4.closeQuietly
        // field: p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24.f1b899685
        // field: p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24.f080ef4c4
        // field: kotlin.Unit.INSTANCE
        // field: p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24.f1e4e0a3e
        // field: p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24.fc0a17d45
        return 0;
    }

    public bool ConnectionBecameIdle(pc2c7dd60 P0)
    {
        // str: "connection"
        // str: " MUST hold lock on "
        // str: "Thread "
        // call: p6d96efb7.schedule$default
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: AssertionError.<init>
        // call: Thread.getName
        // call: Thread.holdsLock
        // call: ConcurrentLinkedQueue.isEmpty
        // call: ConcurrentLinkedQueue.remove
        // call: StringBuilder.<init>
        // call: Thread.currentThread
        // call: pc2c7dd60.getNoNewExchanges
        // call: p6d96efb7.cancelAll
        // call: pc2c7dd60.setNoNewExchanges
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24.f1b899685
        // field: p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24.f1e4e0a3e
        // field: p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24.f6be1458b
        // field: p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24.fc0a17d45
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // type: StringBuilder
        // type: AssertionError
        return false;
    }

    public int ConnectionCount()
    {
        // call: ConcurrentLinkedQueue.size
        // field: p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24.f1e4e0a3e
        return 0;
    }

    public void EvictAll()
    {
        // str: "4c62ac74ac0b285f44b9589e8c91de8f9262ac0feed8a1f37d78da674a78f224a2c0fa9294d4"
        // str: "connections.iterator()"
        // call: pc2c7dd60.getCalls
        // call: List<object>.isEmpty
        // call: IEnumerator<object>.remove
        // call: pc2c7dd60.setNoNewExchanges
        // call: pc2c7dd60.socket
        // call: IEnumerator<object>.next
        // call: Intrinsics.checkNotNullExpressionValue
        // call: p6d96efb7.cancelAll
        // call: ConcurrentLinkedQueue.iterator
        // call: IEnumerator<object>.hasNext
        // call: ConcurrentLinkedQueue.isEmpty
        // call: DecryptString.decryptString
        // call: p23e8a4b4.closeQuietly
        // field: p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24.f1e4e0a3e
        // field: p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24.f1b899685
    }

    public int IdleConnectionCount()
    {
        // str: "it"
        // call: ICollection<object>.isEmpty
        // call: pc2c7dd60.getCalls
        // call: List<object>.isEmpty
        // call: IEnumerator<object>.next
        // call: IEnumerable<object>.iterator
        // call: Intrinsics.checkNotNullExpressionValue
        // call: IEnumerator<object>.hasNext
        // call: CollectionsKt.throwCountOverflow
        // field: p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24.f1e4e0a3e
        return 0;
    }

    public void Put(pc2c7dd60 P0)
    {
        // str: "Thread "
        // str: "connection"
        // str: " MUST hold lock on "
        // call: StringBuilder.append
        // call: Thread.holdsLock
        // call: Thread.getName
        // call: Thread.currentThread
        // call: AssertionError.<init>
        // call: StringBuilder.toString
        // call: Intrinsics.checkNotNullParameter
        // call: StringBuilder.<init>
        // call: p6d96efb7.schedule$default
        // call: ConcurrentLinkedQueue.add
        // field: p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24.f1b899685
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // field: p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24.f6be1458b
        // field: p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24.f1e4e0a3e
        // type: AssertionError
        // type: StringBuilder
    }

}
