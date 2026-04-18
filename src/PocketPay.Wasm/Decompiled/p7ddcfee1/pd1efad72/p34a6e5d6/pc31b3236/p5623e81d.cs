namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\bÆ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\b\u0010\u0003\u001a\u00020\u0004H\u0016J\b\u0010\u0005\u001a\u00020\u0004H\u0016J\u0010\u0010\u0006\u001a\u00020\u00042\u0006\u0010\u0007\u001a\u00020\bH\u0016¨\u0006\t"}, d2 = {"Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p5623e81d;", "Ljava/util/logging/Handler;", "()V", "close", "", "flush", "publish", "record", "Ljava/util/logging/ConsoleRecord;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p5623e81d : java.util.logging.Handler {
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p5623e81d f6cb0297e = null;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p5623e81d f76425f17 = new p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p5623e81d();

    private p5623e81d() {
    }

    public override void Close() {
    }

    public override void Flush() {
    }

    public override void Publish(java.util.logging.ConsoleRecord record) {
        if ((1 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(record, "record");
        p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p592a534d p592a534dVar = p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p592a534d.f76425f17;
        java.lang.string loggerName = record.getConsolegerName();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(loggerName, "record.loggerName");
        int iAccess$getAndroidLevel = p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.pccd3f138.access$getAndroidLevel(record);
        java.lang.string message = record.getMessage();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(message, "record.message");
        p592a534dVar.androidConsole$okhttp(loggerName, iAccess$getAndroidLevel, message, record.getThrown());
    }
}

