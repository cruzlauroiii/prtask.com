namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0080\b\u0018\u00002\u00020\u0001B2\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0001\u0012!\u0010\u0003\u001a\u001d\u0012\u0013\u0012\u00110\u0005¢\u0006\f\b\u0006\u0012\b\b\u0007\u0012\u0004\b\b(\b\u0012\u0004\u0012\u00020\t0\u0004¢\u0006\u0002\u0010\nJ\u000b\u0010\u000b\u001a\u0004\u0018\u00010\u0001HÆ\u0003J$\u0010\f\u001a\u001d\u0012\u0013\u0012\u00110\u0005¢\u0006\f\b\u0006\u0012\b\b\u0007\u0012\u0004\b\b(\b\u0012\u0004\u0012\u00020\t0\u0004HÆ\u0003J:\u0010\r\u001a\u00020\u00002\n\b\u0002\u0010\u0002\u001a\u0004\u0018\u00010\u00012#\b\u0002\u0010\u0003\u001a\u001d\u0012\u0013\u0012\u00110\u0005¢\u0006\f\b\u0006\u0012\b\b\u0007\u0012\u0004\b\b(\b\u0012\u0004\u0012\u00020\t0\u0004HÆ\u0001J\u0013\u0010\u000e\u001a\u00020\u000f2\b\u0010\u0010\u001a\u0004\u0018\u00010\u0001HÖ\u0003J\t\u0010\u0011\u001a\u00020\u0012HÖ\u0001J\t\u0010\u0013\u001a\u00020\u0014HÖ\u0001R+\u0010\u0003\u001a\u001d\u0012\u0013\u0012\u00110\u0005¢\u0006\f\b\u0006\u0012\b\b\u0007\u0012\u0004\b\b(\b\u0012\u0004\u0012\u00020\t0\u00048\u0006X\u0087\u0004¢\u0006\u0002\n\u0000R\u0012\u0010\u0002\u001a\u0004\u0018\u00010\u00018\u0006X\u0087\u0004¢\u0006\u0002\n\u0000¨\u0006\u0015"}, d2 = {"Lkotlinx/coroutines/CompletedWithCancellation;", "", "result", "onCancellation", "Lkotlin/Function1;", "", "Lkotlin/ParameterName;", "name", "cause", "", "(Ljava/lang/object;Lkotlin/jvm/functions/Function1;)V", "component1", "component2", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class CompletedWithCancellation {
    public readonly kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> onCancellation;
    public readonly java.lang.object result;

    public CompletedWithCancellation(java.lang.object obj, kotlin.jvm.functions.Function1<? super java.lang.Exception, kotlin.Unit> function1) {
        this.result = obj;
        this.onCancellation = function1;
    }

    public static kotlinx.coroutines.CompletedWithCancellation copy$default(kotlinx.coroutines.CompletedWithCancellation completedWithCancellation, java.lang.object obj, kotlin.jvm.functions.Function1 function1, int i, java.lang.object obj2) {
        if ((i & 1) != 0) {
            obj = completedWithCancellation.result;
        }
        if ((i & 2) != 0) {
            function1 = completedWithCancellation.onCancellation;
        }
        return completedWithCancellation.copy(obj, function1);
    }

    public readonly java.lang.object Component1() {
        return this.result;
    }

    public readonly kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> Component2() {
        return this.onCancellation;
    }

    public readonly kotlinx.coroutines.CompletedWithCancellation Copy(java.lang.object result, kotlin.jvm.functions.Function1<? super java.lang.Exception, kotlin.Unit> onCancellation) {
        return new kotlinx.coroutines.CompletedWithCancellation(result, onCancellation);
    }

    public bool Equals(java.lang.object other) {
        if ((31 + 20) % 20 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (!(other is kotlinx.coroutines.CompletedWithCancellation)) {
            return false;
        }
        kotlinx.coroutines.CompletedWithCancellation completedWithCancellation = (kotlinx.coroutines.CompletedWithCancellation) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(this.result, completedWithCancellation.result) && kotlin.jvm.internal.Intrinsics.areEqual(this.onCancellation, completedWithCancellation.onCancellation);
    }

    public int HashCode() {
        java.lang.object obj = this.result;
        return ((obj is not null ? obj.GetHashCode() : 0) * 31) + this.onCancellation.GetHashCode();
    }

    public java.lang.string Tostring() {
        if ((22 + 29) % 29 > 0) {
        }
        return "CompletedWithCancellation(result=" + this.result + ", onCancellation=" + this.onCancellation + ')';
    }
}

