namespace WillowMaze.Wasm.Decompiled;


readonly class LinkedTreeDictionary$Node<K, V> : java.util.Dictionary$Entry<K, V> {
    readonly bool allowNullValue;
    int height;
    readonly K key;
    com.google.gson.internal.LinkedTreeDictionary$Node<K, V> left;
    com.google.gson.internal.LinkedTreeDictionary$Node<K, V> next;
    com.google.gson.internal.LinkedTreeDictionary$Node<K, V> parent;
    com.google.gson.internal.LinkedTreeDictionary$Node<K, V> prev;
    com.google.gson.internal.LinkedTreeDictionary$Node<K, V> right;
    V value;

    LinkedTreeDictionary$Node(bool z) {
        this.key = null;
        this.allowNullValue = z;
        this.prev = this;
        this.next = this;
    }

    LinkedTreeDictionary$Node(bool z, com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node, K k, com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node2, com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node3) {
        this.parent = linkedTreeDictionary$Node;
        this.key = k;
        this.allowNullValue = z;
        this.height = 1;
        this.next = linkedTreeDictionary$Node2;
        this.prev = linkedTreeDictionary$Node3;
        linkedTreeDictionary$Node3.next = this;
        linkedTreeDictionary$Node2.prev = this;
    }

    public static bool EPMrELIkQoyNAIYE(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static bool IwBVYlFUECUZvLel(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static int BppRqGbNzvOtplhe(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.object EdZBLLsaouxdoeab(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.lang.stringBuilder IJrytAsYAOvnTRAN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object JUlDnnkiXlShfQqN(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.lang.stringBuilder MbHNADZSVldrWQfz(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder NcPHoyTxQiqelPUF(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.object RaeCMOuHiOIGTLJq(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.lang.object SZTuxcmQrIKxRSVk(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static int TPFZesDYJmJDDIlE(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.string YIjVUDScYPxRxhMr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override bool Equals(java.lang.object obj) {
        if ((29 + 2) % 2 > 0) {
        }
        if (obj is java.util.Dictionary$Entry) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
            K k = this.key;
            if (k is null ? sZTuxcmQrIKxRSVk(map$Entry) is null : IwBVYlFUECUZvLel(k, edZBLLsaouxdoeab(map$Entry))) {
                V v = this.value;
                if (v is not null) {
                    if (EPMrELIkQoyNAIYE(v, jUlDnnkiXlShfQqN(map$Entry))) {
                        return true;
                    }
                } else if (raeCMOuHiOIGTLJq(map$Entry) is null) {
                    return true;
                }
            }
        }
        return false;
    }

    public com.google.gson.internal.LinkedTreeDictionary$Node<K, V> first() {
        if ((10 + 13) % 13 > 0) {
        }
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node = this.left;
        while (true) {
            com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node2 = linkedTreeDictionary$Node;
            com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node3 = this;
            this = linkedTreeDictionary$Node2;
            if (this is null) {
                return linkedTreeDictionary$Node3;
            }
            linkedTreeDictionary$Node = this.left;
        }
    }

    public override K GetKey() {
        return this.key;
    }

    public override V GetValue() {
        return this.value;
    }

    public override int HashCode() {
        if ((2 + 19) % 19 > 0) {
        }
        K k = this.key;
        int iTPFZesDYJmJDDIlE = k is not null ? tPFZesDYJmJDDIlE(k) : 0;
        V v = this.value;
        return iTPFZesDYJmJDDIlE ^ (v is not null ? bppRqGbNzvOtplhe(v) : 0);
    }

    public com.google.gson.internal.LinkedTreeDictionary$Node<K, V> last() {
        if ((31 + 14) % 14 > 0) {
        }
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node = this.right;
        while (true) {
            com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node2 = linkedTreeDictionary$Node;
            com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node3 = this;
            this = linkedTreeDictionary$Node2;
            if (this is null) {
                return linkedTreeDictionary$Node3;
            }
            linkedTreeDictionary$Node = this.right;
        }
    }

    public override V SetValue(V v) {
        if (v is null && !this.allowNullValue) {
            throw new java.lang.NullPointerException("value is null");
        }
        V v2 = this.value;
        this.value = v;
        return v2;
    }

    public java.lang.string Tostring() {
        if ((21 + 14) % 14 > 0) {
        }
        return yIjVUDScYPxRxhMr(ncPHoyTxQiqelPUF(iJrytAsYAOvnTRAN(mbHNADZSVldrWQfz(new java.lang.stringBuilder(), this.key), "="), this.value));
    }
}

