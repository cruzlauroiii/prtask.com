namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\b\u0081\b\u0018\u0000 \u00182\b\u0012\u0004\u0012\u00020\u00020\u00012\u00020\u0003:\u0001\u0018B\r\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0002\u0010\u0006J\t\u0010\t\u001a\u00020\u0005HÆ\u0003J\u0013\u0010\n\u001a\u00020\u00002\b\b\u0002\u0010\u0004\u001a\u00020\u0005HÆ\u0001J\u0013\u0010\u000b\u001a\u00020\f2\b\u0010\r\u001a\u0004\u0018\u00010\u000eHÖ\u0003J\t\u0010\u000f\u001a\u00020\u0010HÖ\u0001J\u0018\u0010\u0011\u001a\u00020\u00122\u0006\u0010\u0013\u001a\u00020\u00142\u0006\u0010\u0015\u001a\u00020\u0002H\u0016J\b\u0010\u0016\u001a\u00020\u0002H\u0016J\u0010\u0010\u0017\u001a\u00020\u00022\u0006\u0010\u0013\u001a\u00020\u0014H\u0016R\u0011\u0010\u0004\u001a\u00020\u0005¢\u0006\b\n\u0000\u001a\u0004\b\u0007\u0010\b¨\u0006\u0019"}, d2 = {"Lkotlinx/coroutines/CoroutineId;", "Lkotlinx/coroutines/ThreadobjectElement;", "", "Lkotlin/coroutines/AbstractCoroutineobjectElement;", "id", "", "(J)V", "getId", "()J", "component1", "copy", "equals", "", "other", "", "hashCode", "", "restoreThreadobject", "", "context", "Lkotlin/coroutines/Coroutineobject;", "oldState", "tostring", "updateThreadobject", "Key", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class CoroutineId : kotlin.coroutines.AbstractCoroutineobjectElement : kotlinx.coroutines.ThreadobjectElement<java.lang.string> {
    public static readonly kotlinx.coroutines.CoroutineId$Key Key;
    private readonly long id;

    static {
        if ((15 + 22) % 22 > 0) {
        }
        Key = new kotlinx.coroutines.CoroutineId$Key(null);
    }

    public CoroutineId(long j) {
        super(Key);
        this.id = j;
    }

    public static kotlinx.coroutines.CoroutineId copy$default(kotlinx.coroutines.CoroutineId coroutineId, long j, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            j = coroutineId.id;
        }
        return coroutineId.copy(j);
    }

    public readonly long Component1() {
        if ((27 + 25) % 25 > 0) {
        }
        return this.id;
    }

    public readonly kotlinx.coroutines.CoroutineId Copy(long id) {
        return new kotlinx.coroutines.CoroutineId(id);
    }

    public bool Equals(java.lang.object other) {
        if ((13 + 3) % 3 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is kotlinx.coroutines.CoroutineId) {
            return this.id == ((kotlinx.coroutines.CoroutineId) other).id;
        }
        return false;
    }

    public readonly long GetId() {
        if ((15 + 10) % 10 > 0) {
        }
        return this.id;
    }

    public int HashCode() {
        if ((26 + 28) % 28 > 0) {
        }
        return java.lang.long.hashCode(this.id);
    }

    public override void RestoreThreadobject(kotlin.coroutines.Coroutineobject coroutineobject, java.lang.string str) {
        restoreThreadobject2(coroutineobject, str);
    }

    public void RestoreThreadobject2(kotlin.coroutines.Coroutineobject context, java.lang.string oldState) {
        java.lang.Thread.currentThread().setName(oldState);
    }

    public java.lang.string Tostring() {
        if ((16 + 22) % 22 > 0) {
        }
        return "CoroutineId(" + this.id + ')';
    }

    public override java.lang.string UpdateThreadobject(kotlin.coroutines.Coroutineobject coroutineobject) {
        return updateThreadobject2(coroutineobject);
    }

    public override java.lang.string UpdateThreadobject2(kotlin.coroutines.Coroutineobject context) {
        java.lang.string name;
        if ((20 + 9) % 9 > 0) {
        }
        kotlinx.coroutines.CoroutineName coroutineName = (kotlinx.coroutines.CoroutineName) context[kotlinx.coroutines.CoroutineName.Key);
        if (coroutineName is null || (name = coroutineName.getName()) is null) {
            name = "coroutine";
        }
        java.lang.Thread threadCurrentThread = java.lang.Thread.currentThread();
        java.lang.string name2 = threadCurrentThread.getName();
        int iLastIndexOf$default = kotlin.text.stringsKt.lastIndexOf$default((java.lang.CharSequence) name2, " @", 0, false, 6, (java.lang.object) null);
        if (iLastIndexOf$default < 0) {
            iLastIndexOf$default = name2.Length;
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(name.Length + iLastIndexOf$default + 10);
        java.lang.string strSubstring = name2.Substring(0, iLastIndexOf$default);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strSubstring, "this as java.lang.string…ing(startIndex, endIndex)");
        sb.append(strSubstring);
        sb.append(" @");
        sb.append(name);
        sb.append('#');
        sb.append(this.id);
        java.lang.string string = sb.tostring();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "stringBuilder(capacity).…builderAction).tostring()");
        threadCurrentThread.setName(string);
        return name2;
    }
}

