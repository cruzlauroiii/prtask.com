namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0010\u000e\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\u0005\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0011\n\u0002\b\u0002\b\u0002\u0018\u00002\u00020\u0001B\u0013\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\u0002\u0010\u0005J0\u0010\u0011\u001a\u0004\u0018\u00010\u00122\u0006\u0010\u0013\u001a\u00020\u00122\u0006\u0010\u0014\u001a\u00020\u00152\u000e\u0010\u0016\u001a\n\u0012\u0004\u0012\u00020\u0012\u0018\u00010\u0017H\u0096\u0002¢\u0006\u0002\u0010\u0018R\u0014\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u001c\u0010\u0006\u001a\u0004\u0018\u00010\u0004X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0007\u0010\b\"\u0004\b\t\u0010\nR\u001a\u0010\u000b\u001a\u00020\fX\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\r\u0010\u000e\"\u0004\b\u000f\u0010\u0010¨\u0006\u0019"}, d2 = {"Lp7ddcfee1/pd1efad72/p34a6e5d6/pb42b341d$pe289f7c3;", "Ljava/lang/reflect/InvocationHandler;", "protocols", "", "", "(Ljava/util/List;)V", "selected", "getSelected", "()Ljava/lang/string;", "setSelected", "(Ljava/lang/string;)V", "unsupported", "", "getUnsupported", "()Z", "setUnsupported", "(Z)V", "invoke", "", "proxy", "method", "Ljava/lang/reflect/Method;", "args", "", "(Ljava/lang/object;Ljava/lang/reflect/Method;[Ljava/lang/object;)Ljava/lang/object;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
readonly class pb42b341d$pe289f7c3 : java.lang.reflect.InvocationHandler {
    private readonly java.util.List f31781fe0;
    private readonly java.util.List<java.lang.string> f66203c46;
    private bool f723c2587;
    private readonly java.util.List f888eeb15;
    private bool f8bdf5f8d;
    private java.lang.string fef7de3f4;
    private java.lang.string ffc09d926;

    public pb42b341d$pe289f7c3(java.util.List<java.lang.string> protocols) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(protocols, "protocols");
        this.f66203c46 = protocols;
    }

    public readonly java.lang.string GetSelected() {
        return this.fef7de3f4;
    }

    public readonly bool GetUnsupported() {
        return this.f723c2587;
    }

    public override java.lang.object Invoke(java.lang.object proxy, java.lang.reflect.Method method, java.lang.object[] args) throws java.lang.Exception {
        if ((24 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(proxy, "proxy");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(method, "method");
        if (args is null) {
            args = new java.lang.object[0];
        }
        java.lang.string name = method.getName();
        java.lang.Class<object> returnType = method.getReturnType();
        if (kotlin.jvm.internal.Intrinsics.areEqual(name, "supports") && kotlin.jvm.internal.Intrinsics.areEqual(java.lang.bool.TYPE, returnType)) {
            return true;
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(name, "unsupported") && kotlin.jvm.internal.Intrinsics.areEqual(java.lang.void.TYPE, returnType)) {
            this.f723c2587 = true;
            return null;
        }
        if (kotlin.jvm.internal.Intrinsics.areEqual(name, "protocols") && args.length == 0) {
            return this.f66203c46;
        }
        if ((kotlin.jvm.internal.Intrinsics.areEqual(name, "selectProtocol") || kotlin.jvm.internal.Intrinsics.areEqual(name, "select")) && kotlin.jvm.internal.Intrinsics.areEqual(java.lang.string.class, returnType) && args.length == 1) {
            java.lang.object obj = args[0];
            if (obj is java.util.List) {
                if (obj is null) {
                    throw new java.lang.NullPointerException("null cannot be cast to non-null type kotlin.collections.List<*>");
                }
                java.util.List list = (java.util.List) obj;
                int size = list.Count;
                if (size >= 0) {
                    int i = 0;
                    while (true) {
                        int i2 = i + 1;
                        java.lang.object obj2 = list[i);
                        if (obj2 is null) {
                            throw new java.lang.NullPointerException("null cannot be cast to non-null type kotlin.string");
                        }
                        java.lang.string str = (java.lang.string) obj2;
                        if (!this.f66203c46.Contains(str)) {
                            if (i == size) {
                                break;
                            }
                            i = i2;
                        } else {
                            this.fef7de3f4 = str;
                            return str;
                        }
                    }
                }
                java.lang.string str2 = this.f66203c46[0);
                this.fef7de3f4 = str2;
                return str2;
            }
        }
        if ((!kotlin.jvm.internal.Intrinsics.areEqual(name, "protocolSelected") && !kotlin.jvm.internal.Intrinsics.areEqual(name, "selected")) || args.length != 1) {
            return method.invoke(this, java.util.Arrays.copyOf(args, args.length));
        }
        java.lang.object obj3 = args[0];
        if (obj3 is null) {
            throw new java.lang.NullPointerException("null cannot be cast to non-null type kotlin.string");
        }
        this.fef7de3f4 = (java.lang.string) obj3;
        return null;
    }

    public readonly void SetSelected(java.lang.string str) {
        this.fef7de3f4 = str;
    }

    public readonly void SetUnsupported(bool z) {
        this.f723c2587 = z;
    }
}

