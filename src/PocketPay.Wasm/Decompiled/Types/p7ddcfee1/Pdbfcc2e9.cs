namespace WillowMaze.Wasm.Decompiled;

public class Pdbfcc2e9
{
    private readonly Queue<object> F08a9cdbb;
    private readonly Queue<object> F08f40eeb;
    private int F0d49030d;
    private readonly Queue<object> F30fcedbc;
    private readonly Queue<object> F3e856e75;
    private readonly Queue<object> F425abd8b;
    private int F4298e2d2;
    private int F47d913f0;
    private readonly Queue<object> F48628f8d;
    private readonly Queue<object> F48ac2f2c;
    private int F490c3fe2;
    private int F647674cb;
    private readonly Queue<object> F727feb51;
    private readonly Queue<object> F7beaaa13;
    private TaskScheduler F81d3a543;
    private readonly Queue<object> F926bd706;
    private readonly Queue<object> F9e5817b5;
    private Action Fa721bd7b;
    private Action Fb770353c;
    private int Fc3502a1c;
    private Action Fc51a8557;
    private readonly Queue<object> Fd15d53ab;
    private readonly Queue<object> Fd7267ffd;
    private TaskScheduler Fdae02700;
    private int Fe151e897;
    private TaskScheduler Ff39bbc65;
    private int Ff64d785d;
    private TaskScheduler Ffb95123f;

    private p6d310f89$p9319e475 M9450d532(string P0)
    {
        // call: IEnumerator<object>.next
        // call: Intrinsics.areEqual
        // call: IEnumerator<object>.hasNext
        // call: p6d310f89$p9319e475.getHost
        // call: Queue<object>.iterator
        // field: p7ddcfee1.pdbfcc2e9.f48628f8d
        // field: p7ddcfee1.pdbfcc2e9.f425abd8b
        return default!;
    }

    private void Ma5d7ceb2(Queue<object> P0, object P1)
    {
        // str: "Call wasn't in-flight!"
        // call: AssertionError.<init>
        // call: Action.run
        // call: pdbfcc2e9.mdb2177a7
        // call: Queue<object>.remove
        // call: pdbfcc2e9.getIdleCallback
        // field: kotlin.Unit.INSTANCE
        // type: AssertionError
    }

    private bool Mdb2177a7()
    {
        // str: " MUST NOT hold lock on "
        // str: "Thread "
        // str: "readyAsyncCalls.iterator()"
        // str: "asyncCall"
        // call: List<object>.size
        // call: StringBuilder.<init>
        // call: p6d310f89$p9319e475.executeOn
        // call: List<object>.get
        // call: StringBuilder.append
        // call: Thread.getName
        // call: Queue<object>.iterator
        // call: Intrinsics.checkNotNullExpressionValue
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: Queue<object>.size
        // call: pdbfcc2e9.getMaxRequests
        // call: p6d310f89$p9319e475.getCallsPerHost
        // call: int.get
        // call: pdbfcc2e9.getMaxRequestsPerHost
        // call: IEnumerator<object>.remove
        // call: int.incrementAndGet
        // call: List<object>.add
        // call: Queue<object>.add
        // call: pdbfcc2e9.runningCallsCount
        // field: p7ddcfee1.pdbfcc2e9.f425abd8b
        // field: p7ddcfee1.pdbfcc2e9.f48628f8d
        // field: kotlin.Unit.INSTANCE
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.fc549b1fe
        // type: List<object>
        // type: StringBuilder
        // type: AssertionError
        return false;
    }

    public TaskScheduler -deprecated_executorService()
    {
        // call: pdbfcc2e9.executorService
        return default!;
    }

    public void CancelAll()
    {
        // call: Queue<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: p6d310f89$p9319e475.getCall
        // call: p6d310f89.cancel
        // field: p7ddcfee1.pdbfcc2e9.f425abd8b
        // field: p7ddcfee1.pdbfcc2e9.f48628f8d
        // field: p7ddcfee1.pdbfcc2e9.fd7267ffd
    }

    public void Enqueue$okhttp(p6d310f89$p9319e475 P0)
    {
        // str: "call"
        // call: Queue<object>.add
        // call: p6d310f89$p9319e475.getCall
        // call: p6d310f89.getForWebSocket
        // call: p6d310f89$p9319e475.getHost
        // call: pdbfcc2e9.m9450d532
        // call: p6d310f89$p9319e475.reuseCallsPerHostFrom
        // call: pdbfcc2e9.mdb2177a7
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.pdbfcc2e9.f425abd8b
        // field: kotlin.Unit.INSTANCE
    }

    public void Executed$okhttp(p6d310f89 P0)
    {
        // str: "call"
        // call: Intrinsics.checkNotNullParameter
        // call: Queue<object>.add
        // field: p7ddcfee1.pdbfcc2e9.fd7267ffd
    }

    public TaskScheduler ExecutorService()
    {
        // str: " Dispatcher"
        // call: SynchronousQueue.<init>
        // call: Intrinsics.stringPlus
        // call: p23e8a4b4.threadFactory
        // call: ThreadPoolExecutor.<init>
        // call: Intrinsics.checkNotNull
        // field: p7ddcfee1.pdbfcc2e9.ff39bbc65
        // field: java.util.concurrent.TimeUnit.SECONDS
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.ffcd12e30
        // type: ThreadPoolExecutor
        // type: SynchronousQueue
        return default!;
    }

    public void Finished$okhttp(p6d310f89$p9319e475 P0)
    {
        // str: "call"
        // call: int.decrementAndGet
        // call: p6d310f89$p9319e475.getCallsPerHost
        // call: pdbfcc2e9.ma5d7ceb2
        // call: Intrinsics.checkNotNullParameter
        // field: p7ddcfee1.pdbfcc2e9.f48628f8d
    }

    public void Finished$okhttp(p6d310f89 P0)
    {
        // str: "call"
        // call: Intrinsics.checkNotNullParameter
        // call: pdbfcc2e9.ma5d7ceb2
        // field: p7ddcfee1.pdbfcc2e9.fd7267ffd
    }

    public Action GetIdleCallback()
    {
        // field: p7ddcfee1.pdbfcc2e9.fa721bd7b
        return default!;
    }

    public int GetMaxRequests()
    {
        // field: p7ddcfee1.pdbfcc2e9.f647674cb
        return 0;
    }

    public int GetMaxRequestsPerHost()
    {
        // field: p7ddcfee1.pdbfcc2e9.ff64d785d
        return 0;
    }

    public List<object> QueuedCalls()
    {
        // str: "unmodifiableList(readyAsyncCalls.map { it.call })"
        // call: CollectionsKt.collectionSizeOrDefault
        // call: List<object>.<init>
        // call: IEnumerable<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: p6d310f89$p9319e475.getCall
        // call: ICollection<object>.add
        // call: Collections.unmodifiableList
        // call: Intrinsics.checkNotNullExpressionValue
        // field: p7ddcfee1.pdbfcc2e9.f425abd8b
        // type: List<object>
        return default!;
    }

    public int QueuedCallsCount()
    {
        // call: Queue<object>.size
        // field: p7ddcfee1.pdbfcc2e9.f425abd8b
        return 0;
    }

    public List<object> RunningCalls()
    {
        // str: "unmodifiableList(running…yncCalls.map { it.call })"
        // call: CollectionsKt.collectionSizeOrDefault
        // call: List<object>.<init>
        // call: IEnumerable<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: p6d310f89$p9319e475.getCall
        // call: ICollection<object>.add
        // call: CollectionsKt.plus
        // call: Collections.unmodifiableList
        // call: Intrinsics.checkNotNullExpressionValue
        // field: p7ddcfee1.pdbfcc2e9.fd7267ffd
        // field: p7ddcfee1.pdbfcc2e9.f48628f8d
        // type: List<object>
        return default!;
    }

    public int RunningCallsCount()
    {
        // call: Queue<object>.size
        // field: p7ddcfee1.pdbfcc2e9.f48628f8d
        // field: p7ddcfee1.pdbfcc2e9.fd7267ffd
        return 0;
    }

    public void SetIdleCallback(Action P0)
    {
        // field: p7ddcfee1.pdbfcc2e9.fa721bd7b
    }

    public void SetMaxRequests(int P0)
    {
        // str: "max < 1: "
        // call: Intrinsics.stringPlus
        // call: object.toString
        // call: IllegalArgumentException.<init>
        // call: int.valueOf
        // call: pdbfcc2e9.mdb2177a7
        // field: p7ddcfee1.pdbfcc2e9.f647674cb
        // field: kotlin.Unit.INSTANCE
        // type: IllegalArgumentException
    }

    public void SetMaxRequestsPerHost(int P0)
    {
        // str: "max < 1: "
        // call: Intrinsics.stringPlus
        // call: object.toString
        // call: pdbfcc2e9.mdb2177a7
        // call: IllegalArgumentException.<init>
        // call: int.valueOf
        // field: p7ddcfee1.pdbfcc2e9.ff64d785d
        // field: kotlin.Unit.INSTANCE
        // type: IllegalArgumentException
    }

}
