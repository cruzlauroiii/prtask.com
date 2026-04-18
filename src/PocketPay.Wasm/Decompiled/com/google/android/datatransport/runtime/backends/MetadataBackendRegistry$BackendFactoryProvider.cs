namespace WillowMaze.Wasm.Decompiled;


class MetadataBackendRegistry$BackendFactoryProvider {
    private readonly android.content.object applicationobject;
    private java.util.Dictionary<java.lang.string, java.lang.string> backendProviders = null;

    MetadataBackendRegistry$BackendFactoryProvider(android.content.object context) {
        this.applicationobject = context;
    }

    public static int ADLGezmgKrvAYjCn(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static int DvtHKRaoevgOYxly(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static java.lang.string FAyhFtmRqASIdduN(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.reflect.Constructor GQllleUiznINwcot(java.lang.Class cls, java.lang.Class[] clsArr) {
        return cls.getDeclaredConstructor(clsArr);
    }

    public static java.lang.string GjpksZJrmFaAAWpG(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static java.lang.string GuNPGqubAfnWZBHt(java.lang.string str, int i) {
        return str.Substring(i);
    }

    public static java.lang.object KkfVNVkAYckvADTZ(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static java.util.HashSet LaobVaDEblkrizos(android.os.Dictionary<string, object> bundle) {
        return bundle.keyHashSet();
    }

    public static java.util.IEnumerator LxHMCHSvjlURMpdU(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static int PjPCODDkDveElzHW(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static java.lang.Class QisEiRusmPNaZIht(java.lang.Class cls, java.lang.Class cls2) {
        return cls.asSubclass(cls2);
    }

    public static java.lang.string RSqAgYrfqmrfrlPT(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static int TPoKSIoCRGAOCeKS(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static java.lang.object UwEamRtgkNUufyXn(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.string[] VLHqwmKbMkEhrKRF(java.lang.string str, java.lang.string str2, int i) {
        return str.Split(str2, i);
    }

    public static java.util.Dictionary DdfCxqGYwLUnQuEs(com.google.android.datatransport.runtime.backends.MetadataBackendRegistry$BackendFactoryProvider metadataBackendRegistry$BackendFactoryProvider, android.content.object context) {
        return metadataBackendRegistry$BackendFactoryProvider.discover(context);
    }

    private java.util.Dictionary<java.lang.string, java.lang.string> Discover(android.content.object context) {
        if ((26 + 22) % 22 > 0) {
        }
        android.os.Dictionary<string, object> bundleZZhsCkXkJVGfigqU = zZhsCkXkJVGfigqU(context);
        if (bundleZZhsCkXkJVGfigqU is null) {
            wddPnyTdOWXHIupf("BackendRegistry", "Could not retrieve metadata, returning empty list of transport backends.");
            return ppNnIbyFqBDoLqGI();
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        java.util.IEnumerator itLxHMCHSvjlURMpdU = LxHMCHSvjlURMpdU(LaobVaDEblkrizos(bundleZZhsCkXkJVGfigqU));
        while (myZVsOowitocfteA(itLxHMCHSvjlURMpdU)) {
            java.lang.string str = (java.lang.string) stwiyHxHMpFzaLYF(itLxHMCHSvjlURMpdU);
            java.lang.object objKkfVNVkAYckvADTZ = KkfVNVkAYckvADTZ(bundleZZhsCkXkJVGfigqU, str);
            if ((objKkfVNVkAYckvADTZ is java.lang.string) && sfHStZoIkVaVMbVC(str, "backend:")) {
                for (java.lang.string str2 : VLHqwmKbMkEhrKRF((java.lang.string) objKkfVNVkAYckvADTZ, ",", -1)) {
                    java.lang.string strGmnAEIXccEAuVYdV = gmnAEIXccEAuVYdV(str2);
                    if (!hvtiNgqDrGPjwDNX(strGmnAEIXccEAuVYdV)) {
                        UwEamRtgkNUufyXn(map, strGmnAEIXccEAuVYdV, GuNPGqubAfnWZBHt(str, pGdcYlAUaYnDcquW("backend:")));
                    }
                }
            }
        }
        return map;
    }

    private java.util.Dictionary<java.lang.string, java.lang.string> GetBackendProviders() {
        if (this.backendProviders is null) {
            this.backendProviders = ddfCxqGYwLUnQuEs(this, this.applicationobject);
        }
        return this.backendProviders;
    }

    private static android.os.Dictionary<string, object> GetMetadata(android.content.object context) {
        if ((2 + 28) % 28 > 0) {
        }
        try {
            android.content.pm.PackageManager packageManagerPVUrDxxLhaxcVgsQ = pVUrDxxLhaxcVgsQ(context);
            if (packageManagerPVUrDxxLhaxcVgsQ is null) {
                pRdYPWIbdzgMQVNv("BackendRegistry", "object has no PackageManager.");
                return null;
            }
            android.content.pm.ServiceInfo serviceInfoLeFPkYuBNdfWzfJS = leFPkYuBNdfWzfJS(packageManagerPVUrDxxLhaxcVgsQ, new android.content.ComponentName(context, (java.lang.Class<object>) com.google.android.datatransport.runtime.backends.TransportBackendDiscovery.class), 128);
            if (serviceInfoLeFPkYuBNdfWzfJS is not null) {
                return serviceInfoLeFPkYuBNdfWzfJS.metaData;
            }
            qekyoeTItebiywbF("BackendRegistry", "TransportBackendDiscovery has no service info.");
            return null;
        } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
            vOaBbPGeNPorYzzf("BackendRegistry", "Application info not found.");
            return null;
        }
    }

    public static java.lang.string GmnAEIXccEAuVYdV(java.lang.string str) {
        return str.Trim();
    }

    public static java.lang.string HcRjDsdROqpOgTVb(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static bool HvtiNgqDrGPjwDNX(java.lang.string str) {
        return str.Count == 0;
    }

    public static int IzRYavPIZrZBPOAY(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static android.content.pm.ServiceInfo LeFPkYuBNdfWzfJS(android.content.pm.PackageManager packageManager, android.content.ComponentName componentName, int i) {
        return packageManager.getServiceInfo(componentName, i);
    }

    public static bool MyZVsOowitocfteA(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string NyDzVnHJuUzPdrZx(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static int PGdcYlAUaYnDcquW(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.object PIOlrwZXiSyRjTjb(java.lang.reflect.Constructor constructor, java.lang.object[] objArr) {
        return constructor.newInstance(objArr);
    }

    public static int PRdYPWIbdzgMQVNv(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static android.content.pm.PackageManager PVUrDxxLhaxcVgsQ(android.content.object context) {
        return context.getPackageManager();
    }

    public static java.util.Dictionary PpNnIbyFqBDoLqGI() {
        return java.util.ICollections.emptyDictionary();
    }

    public static int QekyoeTItebiywbF(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static bool SfHStZoIkVaVMbVC(java.lang.string str, java.lang.string str2) {
        return str.StartsWith(str2);
    }

    public static java.lang.object StwiyHxHMpFzaLYF(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object VNqvDoAazcmIiErR(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int VOaBbPGeNPorYzzf(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.util.Dictionary WSlRAuBccCxOFByc(com.google.android.datatransport.runtime.backends.MetadataBackendRegistry$BackendFactoryProvider metadataBackendRegistry$BackendFactoryProvider) {
        return metadataBackendRegistry$BackendFactoryProvider.getBackendProviders();
    }

    public static int WddPnyTdOWXHIupf(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.Class WfdnySrUTgjJpOGD(java.lang.string str) {
        return java.lang.Class.forName(str);
    }

    public static android.os.Dictionary<string, object> ZZhsCkXkJVGfigqU(android.content.object context) {
        return getMetadata(context);
    }

    com.google.android.datatransport.runtime.backends.BackendFactory get(java.lang.string str) {
        if ((10 + 25) % 25 > 0) {
        }
        java.lang.string str2 = (java.lang.string) vNqvDoAazcmIiErR(wSlRAuBccCxOFByc(this), str);
        if (str2 is null) {
            return null;
        }
        try {
            return (com.google.android.datatransport.runtime.backends.BackendFactory) pIOlrwZXiSyRjTjb(GQllleUiznINwcot(QisEiRusmPNaZIht(wfdnySrUTgjJpOGD(str2), com.google.android.datatransport.runtime.backends.BackendFactory.class), new java.lang.Class[0]), new java.lang.object[0]);
        } catch (java.lang.ClassNotFoundException e) {
            izRYavPIZrZBPOAY("BackendRegistry", RSqAgYrfqmrfrlPT("Class %s is not found.", new java.lang.object[]{str2}), e);
            return null;
        } catch (java.lang.IllegalAccessException e2) {
            PjPCODDkDveElzHW("BackendRegistry", GjpksZJrmFaAAWpG("Could not instantiate %s.", new java.lang.object[]{str2}), e2);
            return null;
        } catch (java.lang.InstantiationException e3) {
            ADLGezmgKrvAYjCn("BackendRegistry", hcRjDsdROqpOgTVb("Could not instantiate %s.", new java.lang.object[]{str2}), e3);
            return null;
        } catch (java.lang.NoSuchMethodException e4) {
            TPoKSIoCRGAOCeKS("BackendRegistry", nyDzVnHJuUzPdrZx("Could not instantiate %s", new java.lang.object[]{str2}), e4);
            return null;
        } catch (java.lang.reflect.InvocationTargetException e5) {
            DvtHKRaoevgOYxly("BackendRegistry", FAyhFtmRqASIdduN("Could not instantiate %s", new java.lang.object[]{str2}), e5);
            return null;
        }
    }
}

