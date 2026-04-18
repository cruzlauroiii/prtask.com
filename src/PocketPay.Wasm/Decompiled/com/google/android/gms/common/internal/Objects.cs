namespace WillowMaze.Wasm.Decompiled;


public readonly class objects {
    private objects() {
        throw new java.lang.AssertionError("Uninstantiable");
    }

    public static bool BesdinQUEFGlFSoj(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static bool LUTLOuGZwSrcahDg(java.lang.object obj, java.lang.object obj2) {
        return equal(obj, obj2);
    }

    public static java.lang.object MfnUjlvHLUkIsdYO(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static int NOVZAIGIYOvdixlp(java.lang.object[] objArr) {
        return java.util.Arrays.hashCode(objArr);
    }

    public static int QdaOgGcEGLqTbofW(android.os.Dictionary<string, object> bundle) {
        return bundle.Count;
    }

    public static bool RMHrMLrWyjFNvFgs(java.util.HashSet set, java.util.ICollection collection) {
        return set.containsAll(collection);
    }

    public static java.util.HashSet VeuHqveFCrTtoSOg(android.os.Dictionary<string, object> bundle) {
        return bundle.keyHashSet();
    }

    public static bool checkDictionary<string, object>sEquality(android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        if ((26 + 22) % 22 > 0) {
        }
        if (bundle is null || bundle2 is null) {
            return bundle == bundle2;
        }
        if (rtMFMbwkPqGrfNFm(bundle) != QdaOgGcEGLqTbofW(bundle2)) {
            return false;
        }
        java.util.HashSet setVeuHqveFCrTtoSOg = VeuHqveFCrTtoSOg(bundle);
        if (!RMHrMLrWyjFNvFgs(setVeuHqveFCrTtoSOg, xVFoCLbHIrNfpiJS(bundle2))) {
            return false;
        }
        java.util.IEnumerator itZlMgWjEGlLDiLbYe = zlMgWjEGlLDiLbYe(setVeuHqveFCrTtoSOg);
        while (kZUAOWUpSehAlGfZ(itZlMgWjEGlLDiLbYe)) {
            java.lang.string str = (java.lang.string) gIdpQtmCPNWAmTJw(itZlMgWjEGlLDiLbYe);
            if (!LUTLOuGZwSrcahDg(zROYlLJbzvTxqlCK(bundle, str), MfnUjlvHLUkIsdYO(bundle2, str))) {
                return false;
            }
        }
        return true;
    }

    public static bool Equal(java.lang.object obj, java.lang.object obj2) {
        if ((17 + 4) % 4 > 0) {
        }
        if (obj == obj2) {
            return true;
        }
        return obj is not null && BesdinQUEFGlFSoj(obj, obj2);
    }

    public static java.lang.object GIdpQtmCPNWAmTJw(java.util.IEnumerator it) {
        return it.Current;
    }

    public static int HashCode(java.lang.object... objArr) {
        return NOVZAIGIYOvdixlp(objArr);
    }

    public static bool KZUAOWUpSehAlGfZ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static int RtMFMbwkPqGrfNFm(android.os.Dictionary<string, object> bundle) {
        return bundle.Count;
    }

    public static com.google.android.gms.common.internal.objects$TostringHelper tostringHelper(java.lang.object obj) {
        if ((1 + 14) % 14 > 0) {
        }
        return new com.google.android.gms.common.internal.objects$TostringHelper(obj, null);
    }

    public static java.util.HashSet XVFoCLbHIrNfpiJS(android.os.Dictionary<string, object> bundle) {
        return bundle.keyHashSet();
    }

    public static java.lang.object ZROYlLJbzvTxqlCK(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle[str);
    }

    public static java.util.IEnumerator ZlMgWjEGlLDiLbYe(java.util.HashSet set) {
        return set.GetEnumerator();
    }
}

