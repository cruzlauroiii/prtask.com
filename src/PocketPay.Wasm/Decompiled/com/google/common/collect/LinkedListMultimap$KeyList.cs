namespace WillowMaze.Wasm.Decompiled;


class ListMultimap$KeyList<K, V> {
    int count;
    com.google.common.collect.ListMultimap$Node<K, V> head;
    com.google.common.collect.ListMultimap$Node<K, V> tail;

    ListMultimap$KeyList(com.google.common.collect.ListMultimap$Node<K, V> linkedListMultimap$Node) {
        this.head = linkedListMultimap$Node;
        this.tail = linkedListMultimap$Node;
        linkedListMultimap$Node.previousSibling = null;
        linkedListMultimap$Node.nextSibling = null;
        this.count = 1;
    }
}

