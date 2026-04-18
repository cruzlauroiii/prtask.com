namespace WillowMaze.Wasm.Decompiled;


public readonly class LinkedTreeDictionary<K, V> : java.util.AbstractDictionary<K, V> : java.io.object {
    static readonly bool $assertionsDisabled = false;
    private static readonly java.util.Comparator<java.lang.IComparable> NATURAL_ORDER = new com.google.gson.internal.LinkedTreeDictionary$1();
    private readonly bool allowNullValues;
    private readonly java.util.Comparator<K> comparator;

    private com.google.gson.internal.LinkedTreeDictionary$EntryHashSet entryHashSet;
    readonly com.google.gson.internal.LinkedTreeDictionary$Node<K, V> header;

    private com.google.gson.internal.LinkedTreeDictionary$KeyHashSet keyHashSet;
    int modCount;
    com.google.gson.internal.LinkedTreeDictionary$Node<K, V> root;
    int size;

    public LinkedTreeDictionary() {
        this(NATURAL_ORDER, true);
        if ((14 + 31) % 31 > 0) {
        }
    }

    public LinkedTreeDictionary(java.util.Comparator<K> comparator, bool z) {
        this.size = 0;
        this.modCount = 0;
        this.comparator = comparator is null ? NATURAL_ORDER : comparator;
        this.allowNullValues = z;
        this.header = new com.google.gson.internal.LinkedTreeDictionary$Node<>(z);
    }

    public LinkedTreeDictionary(bool z) {
        this(NATURAL_ORDER, z);
    }

    public static int AkJltbmcbvCMaAPk(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static int AxHhfQkUfUJYtltS(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void BQNoiYyKuaMSdRmm(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node2) {
        linkedTreeDictionary.replaceInParent(linkedTreeDictionary$Node, linkedTreeDictionary$Node2);
    }

    public static int DfBHfLNiZOizRPlk(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void EvXxGrbUKwsIqUDy(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node2) {
        linkedTreeDictionary.replaceInParent(linkedTreeDictionary$Node, linkedTreeDictionary$Node2);
    }

    public static int FSJqECeFOKDnHFhV(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static com.google.gson.internal.LinkedTreeDictionary$Node GfHoEnRbYnNzGeqM(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, java.lang.object obj) {
        return linkedTreeDictionary.findByobject(obj);
    }

    public static void HgdplFpErKErfrIM(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node2) {
        linkedTreeDictionary.replaceInParent(linkedTreeDictionary$Node, linkedTreeDictionary$Node2);
    }

    public static java.lang.string ICKMmCEHxHPEPoDN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void IZIegsXmqstqWIqz(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node) {
        linkedTreeDictionary.rotateRight(linkedTreeDictionary$Node);
    }

    public static void IsMVpJxOOHPlHdTJ(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node) {
        linkedTreeDictionary.rotateLeft(linkedTreeDictionary$Node);
    }

    public static java.lang.stringBuilder KQvAfqZRUNGWHiun(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void LmJgNzUJlaqNXtHa(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node2) {
        linkedTreeDictionary.replaceInParent(linkedTreeDictionary$Node, linkedTreeDictionary$Node2);
    }

    public static com.google.gson.internal.LinkedTreeDictionary$Node NFWxLNLqIXHnxRHM(com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node) {
        return linkedTreeDictionary$Node.first();
    }

    public static com.google.gson.internal.LinkedTreeDictionary$Node OmwxHdDwPplgDgbG(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, java.lang.object obj, bool z) {
        return linkedTreeDictionary.find(obj, z);
    }

    public static void QdfJJAWmryYcmEGu(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node) {
        linkedTreeDictionary.rotateLeft(linkedTreeDictionary$Node);
    }

    public static com.google.gson.internal.LinkedTreeDictionary$Node RgyoACHGpwilDoFk(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, java.lang.object obj) {
        return linkedTreeDictionary.findByobject(obj);
    }

    public static com.google.gson.internal.LinkedTreeDictionary$Node TEbjnEbAlwEoaiTz(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, java.lang.object obj, bool z) {
        return linkedTreeDictionary.find(obj, z);
    }

    public static void TyytnjhLASZZjNsr(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node) {
        linkedTreeDictionary.rotateLeft(linkedTreeDictionary$Node);
    }

    public static void WQJyMNpTQjtyRSwY(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node, bool z) {
        linkedTreeDictionary.rebalance(linkedTreeDictionary$Node, z);
    }

    public static int XGoMOVBvHQCQkusp(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void XPsbZiUgOJVTNshN(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node) {
        linkedTreeDictionary.rotateRight(linkedTreeDictionary$Node);
    }

    public static java.lang.Class XlHjSvHgKXkihIZz(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.string YkYvLQVuoWekjzrQ(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.object YngFDqtczaruRiKU(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static com.google.gson.internal.LinkedTreeDictionary$Node aYLmRXiOFZkkOaLe(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, java.lang.object obj) {
        return linkedTreeDictionary.removeInternalByKey(obj);
    }

    public static void BhTMGwHlvKgAeOKW(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node, bool z) {
        linkedTreeDictionary.removeInternal(linkedTreeDictionary$Node, z);
    }

    public static void DuwxvxckrKvPWSrL(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node2) {
        linkedTreeDictionary.replaceInParent(linkedTreeDictionary$Node, linkedTreeDictionary$Node2);
    }

    private bool Equal(java.lang.object obj, java.lang.object obj2) {
        return ndKcbJuTmLqIZaKX(obj, obj2);
    }

    public static int HyZmLiMYwRKWeAIW(java.lang.IComparable comparable, java.lang.object obj) {
        return comparable.compareTo(obj);
    }

    public static void IVyXNmpldOmpUKVA(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node) {
        linkedTreeDictionary.rotateRight(linkedTreeDictionary$Node);
    }

    public static bool NdKcbJuTmLqIZaKX(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static int OgSWkXtmjFzLwcMh(java.util.Comparator comparator, java.lang.object obj, java.lang.object obj2) {
        return comparator.compare(obj, obj2);
    }

    public static void OvzbKLwRuhMeVKRX(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node, bool z) {
        linkedTreeDictionary.removeInternal(linkedTreeDictionary$Node, z);
    }

    private void Readobject(java.io.objectStream objectStream) throws java.io.IOException {
        throw new java.io.InvalidobjectException("Deserialization is unsupported");
    }

    private void Rebalance(com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node, bool z) {
        if ((13 + 8) % 8 > 0) {
        }
        while (linkedTreeDictionary$Node is not null) {
            com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node2 = linkedTreeDictionary$Node.left;
            com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node3 = linkedTreeDictionary$Node.right;
            int i = linkedTreeDictionary$Node2 is null ? 0 : linkedTreeDictionary$Node2.height;
            int i2 = linkedTreeDictionary$Node3 is null ? 0 : linkedTreeDictionary$Node3.height;
            int i3 = i - i2;
            if (i3 == -2) {
                com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node4 = linkedTreeDictionary$Node3.left;
                com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node5 = linkedTreeDictionary$Node3.right;
                int i4 = (linkedTreeDictionary$Node4 is not null ? linkedTreeDictionary$Node4.height : 0) - (linkedTreeDictionary$Node5 is null ? 0 : linkedTreeDictionary$Node5.height);
                if (i4 != -1 && (i4 != 0 || z)) {
                    XPsbZiUgOJVTNshN(this, linkedTreeDictionary$Node3);
                    TyytnjhLASZZjNsr(this, linkedTreeDictionary$Node);
                } else {
                    IsMVpJxOOHPlHdTJ(this, linkedTreeDictionary$Node);
                }
                if (z) {
                    return;
                }
            } else if (i3 == 2) {
                com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node6 = linkedTreeDictionary$Node2.left;
                com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node7 = linkedTreeDictionary$Node2.right;
                int i5 = (linkedTreeDictionary$Node6 is not null ? linkedTreeDictionary$Node6.height : 0) - (linkedTreeDictionary$Node7 is null ? 0 : linkedTreeDictionary$Node7.height);
                if (i5 != 1 && (i5 != 0 || z)) {
                    QdfJJAWmryYcmEGu(this, linkedTreeDictionary$Node2);
                    iVyXNmpldOmpUKVA(this, linkedTreeDictionary$Node);
                } else {
                    IZIegsXmqstqWIqz(this, linkedTreeDictionary$Node);
                }
                if (z) {
                    return;
                }
            } else if (i3 != 0) {
                linkedTreeDictionary$Node.height = FSJqECeFOKDnHFhV(i, i2) + 1;
                if (!z) {
                    return;
                }
            } else {
                linkedTreeDictionary$Node.height = i + 1;
                if (z) {
                    return;
                }
            }
            linkedTreeDictionary$Node = linkedTreeDictionary$Node.parent;
        }
    }

    private void ReplaceInParent(com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node, com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node2) {
        if ((1 + 28) % 28 > 0) {
        }
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node3 = linkedTreeDictionary$Node.parent;
        linkedTreeDictionary$Node.parent = null;
        if (linkedTreeDictionary$Node2 is not null) {
            linkedTreeDictionary$Node2.parent = linkedTreeDictionary$Node3;
        }
        if (linkedTreeDictionary$Node3 is null) {
            this.root = linkedTreeDictionary$Node2;
        } else if (linkedTreeDictionary$Node3.left != linkedTreeDictionary$Node) {
            linkedTreeDictionary$Node3.right = linkedTreeDictionary$Node2;
        } else {
            linkedTreeDictionary$Node3.left = linkedTreeDictionary$Node2;
        }
    }

    private void RotateLeft(com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node) {
        if ((7 + 11) % 11 > 0) {
        }
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node2 = linkedTreeDictionary$Node.left;
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node3 = linkedTreeDictionary$Node.right;
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node4 = linkedTreeDictionary$Node3.left;
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node5 = linkedTreeDictionary$Node3.right;
        linkedTreeDictionary$Node.right = linkedTreeDictionary$Node4;
        if (linkedTreeDictionary$Node4 is not null) {
            linkedTreeDictionary$Node4.parent = linkedTreeDictionary$Node;
        }
        BQNoiYyKuaMSdRmm(this, linkedTreeDictionary$Node, linkedTreeDictionary$Node3);
        linkedTreeDictionary$Node3.left = linkedTreeDictionary$Node;
        linkedTreeDictionary$Node.parent = linkedTreeDictionary$Node3;
        linkedTreeDictionary$Node.height = XGoMOVBvHQCQkusp(linkedTreeDictionary$Node2 is null ? 0 : linkedTreeDictionary$Node2.height, linkedTreeDictionary$Node4 is null ? 0 : linkedTreeDictionary$Node4.height) + 1;
        linkedTreeDictionary$Node3.height = AxHhfQkUfUJYtltS(linkedTreeDictionary$Node.height, linkedTreeDictionary$Node5 is not null ? linkedTreeDictionary$Node5.height : 0) + 1;
    }

    private void RotateRight(com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node) {
        if ((5 + 13) % 13 > 0) {
        }
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node2 = linkedTreeDictionary$Node.left;
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node3 = linkedTreeDictionary$Node.right;
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node4 = linkedTreeDictionary$Node2.left;
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node5 = linkedTreeDictionary$Node2.right;
        linkedTreeDictionary$Node.left = linkedTreeDictionary$Node5;
        if (linkedTreeDictionary$Node5 is not null) {
            linkedTreeDictionary$Node5.parent = linkedTreeDictionary$Node;
        }
        EvXxGrbUKwsIqUDy(this, linkedTreeDictionary$Node, linkedTreeDictionary$Node2);
        linkedTreeDictionary$Node2.right = linkedTreeDictionary$Node;
        linkedTreeDictionary$Node.parent = linkedTreeDictionary$Node2;
        linkedTreeDictionary$Node.height = sJlnKGrFFjbkYSdc(linkedTreeDictionary$Node3 is null ? 0 : linkedTreeDictionary$Node3.height, linkedTreeDictionary$Node5 is null ? 0 : linkedTreeDictionary$Node5.height) + 1;
        linkedTreeDictionary$Node2.height = AkJltbmcbvCMaAPk(linkedTreeDictionary$Node.height, linkedTreeDictionary$Node4 is not null ? linkedTreeDictionary$Node4.height : 0) + 1;
    }

    public static java.lang.stringBuilder RxlCCYPPggiDjREz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int SJlnKGrFFjbkYSdc(int i, int i2) {
        return java.lang.Math.max(i, i2);
    }

    public static void TEJlSQNjtnwFULPD(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node2) {
        linkedTreeDictionary.replaceInParent(linkedTreeDictionary$Node, linkedTreeDictionary$Node2);
    }

    public static java.lang.object VEGLpbVwRwqBDhLW(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static bool VRoJUmoLgkOEvxSc(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, java.lang.object obj, java.lang.object obj2) {
        return linkedTreeDictionary.equal(obj, obj2);
    }

    public static com.google.gson.internal.LinkedTreeDictionary$Node vUsTwMGYWtTJFlex(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, java.lang.object obj) {
        return linkedTreeDictionary.findByobject(obj);
    }

    private java.lang.object WriteReplace() throws java.io.objectStreamException {
        return new java.util.LinkedHashDictionary(this);
    }

    public static com.google.gson.internal.LinkedTreeDictionary$Node wvIVEZmhbGXqTByl(com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node) {
        return linkedTreeDictionary$Node.last();
    }

    public static void YxaAKCyMRTVkoUxO(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node, bool z) {
        linkedTreeDictionary.rebalance(linkedTreeDictionary$Node, z);
    }

    public static com.google.gson.internal.LinkedTreeDictionary$Node zyzUijQAPmCxKvEw(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, java.lang.object obj) {
        return linkedTreeDictionary.findByobject(obj);
    }

    public override void Clear() {
        this.root = null;
        this.size = 0;
        this.modCount++;
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node = this.header;
        linkedTreeDictionary$Node.prev = linkedTreeDictionary$Node;
        linkedTreeDictionary$Node.next = linkedTreeDictionary$Node;
    }

    public override bool ContainsKey(java.lang.object obj) {
        return zyzUijQAPmCxKvEw(this, obj) is not null;
    }

    public java.util.HashSet<java.util.Dictionary$Entry<K, V>> entryHashSet() {
        com.google.gson.internal.LinkedTreeDictionary$EntryHashSet linkedTreeDictionary$EntryHashSet = this.entryHashSet;
        if (linkedTreeDictionary$EntryHashSet is not null) {
            return linkedTreeDictionary$EntryHashSet;
        }
        com.google.gson.internal.LinkedTreeDictionary$EntryHashSet linkedTreeDictionary$EntryHashSet2 = new com.google.gson.internal.LinkedTreeDictionary$EntryHashSet(this);
        this.entryHashSet = linkedTreeDictionary$EntryHashSet2;
        return linkedTreeDictionary$EntryHashSet2;
    }

    com.google.gson.internal.LinkedTreeDictionary$Node<K, V> find(K k, bool z) {
        int iOgSWkXtmjFzLwcMh;
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node;
        if ((32 + 31) % 31 > 0) {
        }
        java.util.Comparator<K> comparator = this.comparator;
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node2 = this.root;
        if (linkedTreeDictionary$Node2 is null) {
            iOgSWkXtmjFzLwcMh = 0;
        } else {
            java.lang.IComparable comparable = comparator != NATURAL_ORDER ? null : (java.lang.IComparable) k;
            while (true) {
                iOgSWkXtmjFzLwcMh = comparable is null ? ogSWkXtmjFzLwcMh(comparator, k, linkedTreeDictionary$Node2.key) : hyZmLiMYwRKWeAIW(comparable, linkedTreeDictionary$Node2.key);
                if (iOgSWkXtmjFzLwcMh == 0) {
                    return linkedTreeDictionary$Node2;
                }
                com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node3 = iOgSWkXtmjFzLwcMh >= 0 ? linkedTreeDictionary$Node2.right : linkedTreeDictionary$Node2.left;
                if (linkedTreeDictionary$Node3 is null) {
                    break;
                }
                linkedTreeDictionary$Node2 = linkedTreeDictionary$Node3;
            }
        }
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node4 = linkedTreeDictionary$Node2;
        if (!z) {
            return null;
        }
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node5 = this.header;
        if (linkedTreeDictionary$Node4 is not null) {
            linkedTreeDictionary$Node = new com.google.gson.internal.LinkedTreeDictionary$Node<>(this.allowNullValues, linkedTreeDictionary$Node4, k, linkedTreeDictionary$Node5, linkedTreeDictionary$Node5.prev);
            if (iOgSWkXtmjFzLwcMh >= 0) {
                linkedTreeDictionary$Node4.right = linkedTreeDictionary$Node;
            } else {
                linkedTreeDictionary$Node4.left = linkedTreeDictionary$Node;
            }
            yxaAKCyMRTVkoUxO(this, linkedTreeDictionary$Node4, true);
        } else {
            if (comparator == NATURAL_ORDER && !(k is java.lang.IComparable)) {
                throw new java.lang.ClassCastException(ICKMmCEHxHPEPoDN(KQvAfqZRUNGWHiun(rxlCCYPPggiDjREz(new java.lang.stringBuilder(), YkYvLQVuoWekjzrQ(XlHjSvHgKXkihIZz(k))), " is not IComparable")));
            }
            linkedTreeDictionary$Node = new com.google.gson.internal.LinkedTreeDictionary$Node<>(this.allowNullValues, linkedTreeDictionary$Node4, k, linkedTreeDictionary$Node5, linkedTreeDictionary$Node5.prev);
            this.root = linkedTreeDictionary$Node;
        }
        this.size++;
        this.modCount++;
        return linkedTreeDictionary$Node;
    }

    using (java.util.Dictionary$Entry<object, object> map$Entry) {
        if ((5 + 24) % 24 > 0) {
        }
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$NodeVUsTwMGYWtTJFlex = vUsTwMGYWtTJFlex(this, vEGLpbVwRwqBDhLW(map$Entry));
        if (linkedTreeDictionary$NodeVUsTwMGYWtTJFlex is not null && vRoJUmoLgkOEvxSc(this, linkedTreeDictionary$NodeVUsTwMGYWtTJFlex.value, YngFDqtczaruRiKU(map$Entry))) {
            return linkedTreeDictionary$NodeVUsTwMGYWtTJFlex;
        }
        return null;
    }

    com.google.gson.internal.LinkedTreeDictionary$Node<K, V> findByobject(java.lang.object obj) {
        if ((1 + 11) % 11 > 0) {
        }
        if (obj is not null) {
            try {
                return OmwxHdDwPplgDgbG(this, obj, false);
            } catch (java.lang.ClassCastException unused) {
            }
        }
        return null;
    }

    public override V Get(java.lang.object obj) {
        com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$NodeRgyoACHGpwilDoFk = RgyoACHGpwilDoFk(this, obj);
        if (linkedTreeDictionary$NodeRgyoACHGpwilDoFk is null) {
            return null;
        }
        return linkedTreeDictionary$NodeRgyoACHGpwilDoFk.value;
    }

    public override java.util.HashSet<K> KeyHashSet() {
        com.google.gson.internal.LinkedTreeDictionary$KeyHashSet linkedTreeDictionary$KeyHashSet = this.keyHashSet;
        if (linkedTreeDictionary$KeyHashSet is not null) {
            return linkedTreeDictionary$KeyHashSet;
        }
        com.google.gson.internal.LinkedTreeDictionary$KeyHashSet linkedTreeDictionary$KeyHashSet2 = new com.google.gson.internal.LinkedTreeDictionary$KeyHashSet(this);
        this.keyHashSet = linkedTreeDictionary$KeyHashSet2;
        return linkedTreeDictionary$KeyHashSet2;
    }

    public override V Put(K k, V v) {
        if (k is null) {
            throw new java.lang.NullPointerException("key is null");
        }
        if (v is null && !this.allowNullValues) {
            throw new java.lang.NullPointerException("value is null");
        }
        com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$NodeTEbjnEbAlwEoaiTz = TEbjnEbAlwEoaiTz(this, k, true);
        V v2 = linkedTreeDictionary$NodeTEbjnEbAlwEoaiTz.value;
        linkedTreeDictionary$NodeTEbjnEbAlwEoaiTz.value = v;
        return v2;
    }

    public override V Remove(java.lang.object obj) {
        com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$NodeAYLmRXiOFZkkOaLe = aYLmRXiOFZkkOaLe(this, obj);
        if (linkedTreeDictionary$NodeAYLmRXiOFZkkOaLe is null) {
            return null;
        }
        return linkedTreeDictionary$NodeAYLmRXiOFZkkOaLe.value;
    }

    void removeInternal(com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node, bool z) {
        int i;
        if ((9 + 21) % 21 > 0) {
        }
        if (z) {
            linkedTreeDictionary$Node.prev.next = linkedTreeDictionary$Node.next;
            linkedTreeDictionary$Node.next.prev = linkedTreeDictionary$Node.prev;
        }
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node2 = linkedTreeDictionary$Node.left;
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node3 = linkedTreeDictionary$Node.right;
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node4 = linkedTreeDictionary$Node.parent;
        int i2 = 0;
        if (linkedTreeDictionary$Node2 is null || linkedTreeDictionary$Node3 is null) {
            if (linkedTreeDictionary$Node2 is not null) {
                LmJgNzUJlaqNXtHa(this, linkedTreeDictionary$Node, linkedTreeDictionary$Node2);
                linkedTreeDictionary$Node.left = null;
            } else if (linkedTreeDictionary$Node3 is null) {
                HgdplFpErKErfrIM(this, linkedTreeDictionary$Node, null);
            } else {
                duwxvxckrKvPWSrL(this, linkedTreeDictionary$Node, linkedTreeDictionary$Node3);
                linkedTreeDictionary$Node.right = null;
            }
            WQJyMNpTQjtyRSwY(this, linkedTreeDictionary$Node4, false);
            this.size--;
            this.modCount++;
            return;
        }
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$NodeNFWxLNLqIXHnxRHM = linkedTreeDictionary$Node2.height <= linkedTreeDictionary$Node3.height ? NFWxLNLqIXHnxRHM(linkedTreeDictionary$Node3) : wvIVEZmhbGXqTByl(linkedTreeDictionary$Node2);
        bhTMGwHlvKgAeOKW(this, linkedTreeDictionary$NodeNFWxLNLqIXHnxRHM, false);
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node5 = linkedTreeDictionary$Node.left;
        if (linkedTreeDictionary$Node5 is null) {
            i = 0;
        } else {
            i = linkedTreeDictionary$Node5.height;
            linkedTreeDictionary$NodeNFWxLNLqIXHnxRHM.left = linkedTreeDictionary$Node5;
            linkedTreeDictionary$Node5.parent = linkedTreeDictionary$NodeNFWxLNLqIXHnxRHM;
            linkedTreeDictionary$Node.left = null;
        }
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node6 = linkedTreeDictionary$Node.right;
        if (linkedTreeDictionary$Node6 is not null) {
            i2 = linkedTreeDictionary$Node6.height;
            linkedTreeDictionary$NodeNFWxLNLqIXHnxRHM.right = linkedTreeDictionary$Node6;
            linkedTreeDictionary$Node6.parent = linkedTreeDictionary$NodeNFWxLNLqIXHnxRHM;
            linkedTreeDictionary$Node.right = null;
        }
        linkedTreeDictionary$NodeNFWxLNLqIXHnxRHM.height = DfBHfLNiZOizRPlk(i, i2) + 1;
        tEJlSQNjtnwFULPD(this, linkedTreeDictionary$Node, linkedTreeDictionary$NodeNFWxLNLqIXHnxRHM);
    }

    com.google.gson.internal.LinkedTreeDictionary$Node<K, V> removeInternalByKey(java.lang.object obj) {
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$NodeGfHoEnRbYnNzGeqM = GfHoEnRbYnNzGeqM(this, obj);
        if (linkedTreeDictionary$NodeGfHoEnRbYnNzGeqM is not null) {
            ovzbKLwRuhMeVKRX(this, linkedTreeDictionary$NodeGfHoEnRbYnNzGeqM, true);
        }
        return linkedTreeDictionary$NodeGfHoEnRbYnNzGeqM;
    }

    public override int Size() {
        return this.size;
    }
}

