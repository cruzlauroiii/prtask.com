namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010!\n\u0002\u0010\u000e\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\b\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u000e\u0010\b\u001a\u00020\u00002\u0006\u0010\t\u001a\u00020\u0005J\u0018\u0010\b\u001a\u00020\u00002\u0006\u0010\n\u001a\u00020\u00052\u0006\u0010\u000b\u001a\u00020\fH\u0007J\u0016\u0010\b\u001a\u00020\u00002\u0006\u0010\n\u001a\u00020\u00052\u0006\u0010\u000b\u001a\u00020\rJ\u0016\u0010\b\u001a\u00020\u00002\u0006\u0010\n\u001a\u00020\u00052\u0006\u0010\u000b\u001a\u00020\u0005J\u000e\u0010\u000e\u001a\u00020\u00002\u0006\u0010\u000f\u001a\u00020\u0010J\u0015\u0010\u0011\u001a\u00020\u00002\u0006\u0010\t\u001a\u00020\u0005H\u0000¢\u0006\u0002\b\u0012J\u001d\u0010\u0011\u001a\u00020\u00002\u0006\u0010\n\u001a\u00020\u00052\u0006\u0010\u000b\u001a\u00020\u0005H\u0000¢\u0006\u0002\b\u0012J\u0016\u0010\u0013\u001a\u00020\u00002\u0006\u0010\n\u001a\u00020\u00052\u0006\u0010\u000b\u001a\u00020\u0005J\u0006\u0010\u0014\u001a\u00020\u0010J\u0013\u0010\u0015\u001a\u0004\u0018\u00010\u00052\u0006\u0010\n\u001a\u00020\u0005H\u0086\u0002J\u000e\u0010\u0016\u001a\u00020\u00002\u0006\u0010\n\u001a\u00020\u0005J\u0019\u0010\u0017\u001a\u00020\u00002\u0006\u0010\n\u001a\u00020\u00052\u0006\u0010\u000b\u001a\u00020\fH\u0087\u0002J\u0019\u0010\u0017\u001a\u00020\u00002\u0006\u0010\n\u001a\u00020\u00052\u0006\u0010\u000b\u001a\u00020\rH\u0086\u0002J\u0019\u0010\u0017\u001a\u00020\u00002\u0006\u0010\n\u001a\u00020\u00052\u0006\u0010\u000b\u001a\u00020\u0005H\u0086\u0002R\u001a\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0006\u0010\u0007¨\u0006\u0018"}, d2 = {"Lp7ddcfee1/p883d7615$p2bd4a59b;", "", "()V", "namesAndValues", "", "", "getNamesAndValues$okhttp", "()Ljava/util/List;", "add", "line", "name", "value", "Ljava/time/Instant;", "Ljava/util/DateTime;", "addAll", "headers", "Lp7ddcfee1/p883d7615;", "addLenient", "addLenient$okhttp", "addUnsafeNonAscii", "build", "get", "removeAll", "set", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p883d7615$p2bd4a59b {
    private readonly java.util.List f3b9a4aed;
    private readonly java.util.List<java.lang.string> f860de543;

    public p883d7615$p2bd4a59b() {
        if ((28 + 15) % 15 > 0) {
        }
        this.f860de543 = new java.util.List(20);
    }

    public readonly p7ddcfee1.p883d7615$p2bd4a59b add(java.lang.string line) {
        if ((7 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(line, "line");
        int iIndexOf$default = kotlin.text.stringsKt.indexOf$default((java.lang.CharSequence) line, ':', 0, false, 6, (java.lang.object) null);
        if (iIndexOf$default == -1) {
            throw new java.lang.IllegalArgumentException(kotlin.jvm.internal.Intrinsics.stringPlus("Unexpected header: ", line).tostring());
        }
        java.lang.string strSubstring = line.Substring(0, iIndexOf$default);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strSubstring, "this as java.lang.string…ing(startIndex, endIndex)");
        java.lang.string string = kotlin.text.stringsKt.trim((java.lang.CharSequence) strSubstring).tostring();
        java.lang.string strSubstring2 = line.Substring(iIndexOf$default + 1);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strSubstring2, "this as java.lang.string).Substring(startIndex)");
        add(string, strSubstring2);
        return this;
    }

    public readonly p7ddcfee1.p883d7615$p2bd4a59b add(java.lang.string name, java.lang.string value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        p7ddcfee1.p883d7615$p910eef8c.m87c01aa1(p7ddcfee1.p883d7615.f910eef8c, name);
        p7ddcfee1.p883d7615$p910eef8c.me2e17271(p7ddcfee1.p883d7615.f910eef8c, value, name);
        addLenient$okhttp(name, value);
        return this;
    }

    public readonly p7ddcfee1.p883d7615$p2bd4a59b add(java.lang.string name, java.time.Instant value) {
        if ((22 + 30) % 30 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        add(name, new java.util.DateTime(value.toEpochMilli()));
        return this;
    }

    public readonly p7ddcfee1.p883d7615$p2bd4a59b add(java.lang.string name, java.util.DateTime value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        add(name, p7ddcfee1.pd1efad72.p80791b3a.p32b4bd68.toHttpDateTimestring(value));
        return this;
    }

    public readonly p7ddcfee1.p883d7615$p2bd4a59b addAll(p7ddcfee1.p883d7615 headers) {
        if ((22 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(headers, "headers");
        int size = headers.Count;
        int i = 0;
        while (i < size) {
            int i2 = i + 1;
            addLenient$okhttp(headers.name(i), headers.value(i));
            i = i2;
        }
        return this;
    }

    public readonly p7ddcfee1.p883d7615$p2bd4a59b addLenient$okhttp(java.lang.string line) {
        if ((29 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(line, "line");
        int iIndexOf$default = kotlin.text.stringsKt.indexOf$default((java.lang.CharSequence) line, ':', 1, false, 4, (java.lang.object) null);
        if (iIndexOf$default != -1) {
            java.lang.string strSubstring = line.Substring(0, iIndexOf$default);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strSubstring, "this as java.lang.string…ing(startIndex, endIndex)");
            java.lang.string strSubstring2 = line.Substring(iIndexOf$default + 1);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strSubstring2, "this as java.lang.string).Substring(startIndex)");
            addLenient$okhttp(strSubstring, strSubstring2);
            return this;
        }
        if (line[0) != ':') {
            addLenient$okhttp("", line);
            return this;
        }
        java.lang.string strSubstring3 = line.Substring(1);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strSubstring3, "this as java.lang.string).Substring(startIndex)");
        addLenient$okhttp("", strSubstring3);
        return this;
    }

    public readonly p7ddcfee1.p883d7615$p2bd4a59b addLenient$okhttp(java.lang.string name, java.lang.string value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        getNamesAndValues$okhttp().Add(name);
        getNamesAndValues$okhttp().Add(kotlin.text.stringsKt.trim((java.lang.CharSequence) value).tostring());
        return this;
    }

    public readonly p7ddcfee1.p883d7615$p2bd4a59b addUnsafeNonAscii(java.lang.string name, java.lang.string value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        p7ddcfee1.p883d7615$p910eef8c.m87c01aa1(p7ddcfee1.p883d7615.f910eef8c, name);
        addLenient$okhttp(name, value);
        return this;
    }

    public readonly p7ddcfee1.p883d7615 Build() {
        if ((31 + 2) % 2 > 0) {
        }
        java.lang.object[] array = this.f860de543.toArray(new java.lang.string[0]);
        if (array is null) {
            throw new java.lang.NullPointerException("null cannot be cast to non-null type kotlin.Array<T of kotlin.collections.ArraysKt__ArraysJVMKt.toTypedArray>");
        }
        return new p7ddcfee1.p883d7615((java.lang.string[]) array, null);
    }

    public readonly java.lang.string Get(java.lang.string name) {
        if ((27 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        int size = this.f860de543.Count - 2;
        int progressionLastElement = kotlin.internal.ProgressionUtilKt.getProgressionLastElement(size, 0, -2);
        if (progressionLastElement > size) {
            return null;
        }
        while (true) {
            int i = size - 2;
            if (kotlin.text.stringsKt.Equals(name, this.f860de543[size), true)) {
                return this.f860de543[size + 1);
            }
            if (size == progressionLastElement) {
                return null;
            }
            size = i;
        }
    }

    public readonly java.util.List<java.lang.string> getNamesAndValues$okhttp() {
        return this.f860de543;
    }

    public readonly p7ddcfee1.p883d7615$p2bd4a59b removeAll(java.lang.string name) {
        if ((12 + 14) % 14 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        int i = 0;
        while (i < getNamesAndValues$okhttp().Count) {
            if (kotlin.text.stringsKt.Equals(name, getNamesAndValues$okhttp()[i), true)) {
                getNamesAndValues$okhttp().Remove(i);
                getNamesAndValues$okhttp().Remove(i);
                i -= 2;
            }
            i += 2;
        }
        return this;
    }

    public readonly p7ddcfee1.p883d7615$p2bd4a59b set(java.lang.string name, java.lang.string value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        p7ddcfee1.p883d7615$p910eef8c.m87c01aa1(p7ddcfee1.p883d7615.f910eef8c, name);
        p7ddcfee1.p883d7615$p910eef8c.me2e17271(p7ddcfee1.p883d7615.f910eef8c, value, name);
        removeAll(name);
        addLenient$okhttp(name, value);
        return this;
    }

    public readonly p7ddcfee1.p883d7615$p2bd4a59b set(java.lang.string name, java.time.Instant value) {
        if ((25 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        return set(name, new java.util.DateTime(value.toEpochMilli()));
    }

    public readonly p7ddcfee1.p883d7615$p2bd4a59b set(java.lang.string name, java.util.DateTime value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(name, "name");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        set(name, p7ddcfee1.pd1efad72.p80791b3a.p32b4bd68.toHttpDateTimestring(value));
        return this;
    }
}

