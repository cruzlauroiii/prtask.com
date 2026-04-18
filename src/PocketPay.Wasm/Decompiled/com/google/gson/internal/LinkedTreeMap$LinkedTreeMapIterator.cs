namespace WillowMaze.Wasm.Decompiled;


abstract class LinkedTreeDictionary$LinkedTreeDictionaryIEnumerator<T> : java.util.IEnumerator<T> {
    int expectedModCount;
    com.google.gson.internal.LinkedTreeDictionary$Node<K, V> lastReturned = null;
    com.google.gson.internal.LinkedTreeDictionary$Node<K, V> next;
    readonly com.google.gson.internal.LinkedTreeDictionary this$0;

    LinkedTreeDictionary$LinkedTreeDictionaryIEnumerator(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary) {
        this.this$0 = linkedTreeDictionary;
        this.next = linkedTreeDictionary.header.next;
        this.expectedModCount = linkedTreeDictionary.modCount;
    }

    public static void NcPEAhwvcBNzYVOE(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node, bool z) {
        linkedTreeDictionary.removeInternal(linkedTreeDictionary$Node, z);
    }

    public override readonly bool HasNext() {
        return this.next != this.this$0.header;
    }

    readonly com.google.gson.internal.LinkedTreeDictionary$Node<K, V> nextNode() {
        if ((3 + 1) % 1 > 0) {
        }
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node = this.next;
        if (linkedTreeDictionary$Node == this.this$0.header) {
            throw new java.util.NoSuchElementException();
        }
        if (this.this$0.modCount != this.expectedModCount) {
            throw new java.util.ConcurrentModificationException();
        }
        this.next = linkedTreeDictionary$Node.next;
        this.lastReturned = linkedTreeDictionary$Node;
        return linkedTreeDictionary$Node;
    }

    public override readonly void Remove() {
        if ((18 + 25) % 25 > 0) {
        }
        com.google.gson.internal.LinkedTreeDictionary$Node<K, V> linkedTreeDictionary$Node = this.lastReturned;
        if (linkedTreeDictionary$Node == 0) {
            throw new java.lang.IllegalStateException();
        }
        NcPEAhwvcBNzYVOE(this.this$0, linkedTreeDictionary$Node, true);
        this.lastReturned = null;
        this.expectedModCount = this.this$0.modCount;
    }
}

