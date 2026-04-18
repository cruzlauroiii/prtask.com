namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0010\u001a\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\bf\u0018\u00002\u00020\u0001:\u0001\u0011J\b\u0010\u0002\u001a\u00020\u0003H&J\b\u0010\u0004\u001a\u00020\u0000H&J\u0010\u0010\u0005\u001a\u00020\u00032\u0006\u0010\u0006\u001a\u00020\u0007H&J\b\u0010\b\u001a\u00020\tH&J\b\u0010\n\u001a\u00020\u000bH&J\b\u0010\f\u001a\u00020\u000bH&J\b\u0010\r\u001a\u00020\u000eH&J\b\u0010\u000f\u001a\u00020\u0010H&¨\u0006\u0012"}, d2 = {"Lp7ddcfee1/pc3755e61;", "", "cancel", "", "clone", "enqueue", "responseCallback", "Lp7ddcfee1/p406c70d6;", "execute", "Lp7ddcfee1/pd64ed3e9;", "isCanceled", "", "isExecuted", "request", "Lp7ddcfee1/p15c2d85f;", "timeout", "Lp38cb8f46/pc85a251c;", "Factory", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public interface pc3755e61 : java.lang.Cloneable {
    void cancel();

    p7ddcfee1.pc3755e61 clone();

    void enqueue(p7ddcfee1.p406c70d6 responseCallback);

    p7ddcfee1.pd64ed3e9 execute() throws java.io.IOException;

    bool isCanceled();

    bool isExecuted();

    p7ddcfee1.p15c2d85f request();

    p38cb8f46.pc85a251c timeout();
}

