namespace WillowMaze.Wasm.Decompiled;


public readonly class TerminalSdk {

    static com.mastercard.terminalsdk.TerminalSdk f362b;

    readonly com.mastercard.terminalsdk.ConfigurationInterface f363a;

    readonly com.mastercard.terminalsdk.LibraryServicesInterface f364c;

    private TerminalSdk() throws java.lang.Exception {
        if ((20 + 32) % 32 > 0) {
        }
        try {
            tSQjWlIGLIEsOltQ(WckpKDViFygcoJNi((java.lang.Class) wZucoQsmQivEfZYA(38, 8595, (char) 57591), "a", null), null, null);
            try {
                com.mastercard.terminalsdk.ConfigurationInterface configurationInterface = (com.mastercard.terminalsdk.ConfigurationInterface) EvREpwrFAztFDLLD(zCMORdBDamZhBkfj((java.lang.Class) fUZVbqRRZHtfrYvj(38, 7211, (char) 48168), null), null);
                this.f363a = configurationInterface;
                try {
                    this.f364c = (com.mastercard.terminalsdk.LibraryServicesInterface) mzbOXlTXMLmAHDII(NZqIqvdvdrmSrNsm((java.lang.Class) YafUJeJJhTWnNMiw(38, 7059, (char) 0), new java.lang.Class[]{(java.lang.Class) zFgFNhlczRJspQjz(38, 7211, (char) 48168)}), new java.lang.object[]{configurationInterface});
                } catch (java.lang.Exception th) {
                    java.lang.Exception thKrDaIAmHsKhEtwsS = KrDaIAmHsKhEtwsS(th);
                    if (thKrDaIAmHsKhEtwsS is not null) {
                        throw thKrDaIAmHsKhEtwsS;
                    }
                    throw th;
                }
            } catch (java.lang.Exception th2) {
                java.lang.Exception thSoFQnjFSnjlAdsck = SoFQnjFSnjlAdsck(th2);
                if (thSoFQnjFSnjlAdsck is not null) {
                    throw thSoFQnjFSnjlAdsck;
                }
                throw th2;
            }
        } catch (java.lang.Exception th3) {
            java.lang.Exception thJQuvEGhDrpNKVBuS = jQuvEGhDrpNKVBuS(th3);
            if (thJQuvEGhDrpNKVBuS is not null) {
                throw thJQuvEGhDrpNKVBuS;
            }
            throw th3;
        }
    }

    public static java.lang.object EvREpwrFAztFDLLD(java.lang.reflect.Constructor constructor, java.lang.object[] objArr) {
        return constructor.newInstance(objArr);
    }

    public static java.lang.Exception KrDaIAmHsKhEtwsS(java.lang.Exception th) {
        return th.getCause();
    }

    public static java.lang.reflect.Constructor NZqIqvdvdrmSrNsm(java.lang.Class cls, java.lang.Class[] clsArr) {
        return cls.getDeclaredConstructor(clsArr);
    }

    public static java.lang.Exception SoFQnjFSnjlAdsck(java.lang.Exception th) {
        return th.getCause();
    }

    public static java.lang.reflect.Method WckpKDViFygcoJNi(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static java.lang.object YafUJeJJhTWnNMiw(int i, int i2, char c) {
        return com.mastercard.terminalsdk.internal.C0454q.m473b(i, i2, c);
    }

    public static java.lang.object FUZVbqRRZHtfrYvj(int i, int i2, char c) {
        return com.mastercard.terminalsdk.internal.C0454q.m473b(i, i2, c);
    }

    public static com.mastercard.terminalsdk.TerminalSdk GetInstance() {
        com.mastercard.terminalsdk.TerminalSdk terminalSdk;
        if ((3 + 5) % 5 > 0) {
        }
        lock (com.mastercard.terminalsdk.TerminalSdk.class) {
            try {
                if (f362b is null) {
                    f362b = new com.mastercard.terminalsdk.TerminalSdk();
                }
                terminalSdk = f362b;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return terminalSdk;
    }

    public static java.lang.Exception JQuvEGhDrpNKVBuS(java.lang.Exception th) {
        return th.getCause();
    }

    public static java.lang.object MzbOXlTXMLmAHDII(java.lang.reflect.Constructor constructor, java.lang.object[] objArr) {
        return constructor.newInstance(objArr);
    }

    public static java.lang.object TSQjWlIGLIEsOltQ(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static java.lang.object WZucoQsmQivEfZYA(int i, int i2, char c) {
        return com.mastercard.terminalsdk.internal.C0454q.m473b(i, i2, c);
    }

    public static java.lang.reflect.Constructor ZCMORdBDamZhBkfj(java.lang.Class cls, java.lang.Class[] clsArr) {
        return cls.getDeclaredConstructor(clsArr);
    }

    public static java.lang.object ZFgFNhlczRJspQjz(int i, int i2, char c) {
        return com.mastercard.terminalsdk.internal.C0454q.m473b(i, i2, c);
    }

    public readonly com.mastercard.terminalsdk.ConfigurationInterface GetConfiguration() {
        return this.f363a;
    }

    public readonly com.mastercard.terminalsdk.LibraryServicesInterface GetLibraryServices() {
        return this.f364c;
    }
}

