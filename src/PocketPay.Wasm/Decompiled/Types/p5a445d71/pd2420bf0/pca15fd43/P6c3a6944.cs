namespace WillowMaze.Wasm.Decompiled;

public abstract class P6c3a6944 : Cloneable
{
    private static string F5492317d;
    private static string F923e26ea;
    private static string Fc202ea5d;
    private static string Ff7b8d752;
    private int F4dc031a9;
    private p6c3a6944 F53e0b0b0;
    private p6c3a6944 F549658e6;
    private p6c3a6944 F59afa285;
    private int Fc2a042fe;
    private int Fd1671dfb;
    private p6c3a6944 Fdd43f4fe;
    private int Fef491881;

    private void M06ddc1e7(int P0)
    {
        // call: p6c3a6944.setSiblingIndex
        // call: List<object>.get
        // call: List<object>.size
        // call: p6c3a6944.ensureChildNodes
    }

    private void M248a472d(int P0, string P1)
    {
        // call: pad3d06d0.m78a62b57
        // call: List<object>.size
        // call: p6c3a6944.parent
        // call: p6c3a6944.baseUri
        // call: List<object>.toArray
        // call: p9a83ab0d.m9d829e92
        // call: p6c3a6944.addChildren
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.f549658e6
    }

    private p231afe47 M76cc8b46(p231afe47 P0)
    {
        // call: p231afe47.children
        // call: List<object>.size
        // call: p6c3a6944.m76cc8b46
        // call: List<object>.get
        return default!;
    }

    public string AbsUrl(string P0)
    {
        // str: ""
        // call: p6c3a6944.baseUri
        // call: pad3d06d0.m4d495f50
        // call: p6c3a6944.hasAttr
        // call: p101ebc0f.m785e254f
        // call: p6c3a6944.attr
        return string.Empty;
    }

    private void AddChildren(int P0, p6c3a6944[] P1)
    {
        // call: p6c3a6944.ensureChildNodes
        // call: p6c3a6944.reparentChild
        // call: p6c3a6944.m06ddc1e7
        // call: pad3d06d0.m3c1f94c2
        // call: List<object>.addAll
        // call: Arrays.asList
    }

    private void AddChildren(p6c3a6944[] P0)
    {
        // call: p6c3a6944.ensureChildNodes
        // call: p6c3a6944.reparentChild
        // call: List<object>.add
        // call: p6c3a6944.setSiblingIndex
        // call: List<object>.size
    }

    public p6c3a6944 After(string P0)
    {
        // call: p6c3a6944.m248a472d
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.fd1671dfb
        return default!;
    }

    public p6c3a6944 After(p6c3a6944 P0)
    {
        // call: pad3d06d0.m78a62b57
        // call: p6c3a6944.addChildren
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.f549658e6
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.fd1671dfb
        return default!;
    }

    public string Attr(string P0)
    {
        // str: "abs:"
        // str: ""
        // call: string.length
        // call: string.substring
        // call: pad3d06d0.m78a62b57
        // call: p6c3a6944.attributes
        // call: string.startsWith
        // call: p6c3a6944.absUrl
        // call: p6c3a6944.hasAttributes
        // call: p287234a1.getIgnoreCase
        return string.Empty;
    }

    public p6c3a6944 Attr(string P0, string P1)
    {
        // call: p287234a1.putIgnoreCase
        // call: p6c3a6944.attributes
        return default!;
    }

    public p287234a1 Attributes()
    {
        return default!;
    }

    public string BaseUri()
    {
        return string.Empty;
    }

    public p6c3a6944 Before(string P0)
    {
        // call: p6c3a6944.m248a472d
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.fd1671dfb
        return default!;
    }

    public p6c3a6944 Before(p6c3a6944 P0)
    {
        // call: pad3d06d0.m78a62b57
        // call: p6c3a6944.addChildren
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.f549658e6
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.fd1671dfb
        return default!;
    }

    public p6c3a6944 ChildNode(int P0)
    {
        // call: List<object>.get
        // call: p6c3a6944.ensureChildNodes
        return default!;
    }

    public int ChildNodeSize()
    {
        return 0;
    }

    public List<object> ChildNodes()
    {
        // call: Collections.unmodifiableList
        // call: p6c3a6944.ensureChildNodes
        return default!;
    }

    private p6c3a6944[] ChildNodesAsArray()
    {
        // call: p6c3a6944.ensureChildNodes
        // call: List<object>.toArray
        // call: p6c3a6944.childNodeSize
        return default!;
    }

    public List<object> ChildNodesCopy()
    {
        // call: List<object>.iterator
        // call: List<object>.add
        // call: p6c3a6944.clone
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: List<object>.<init>
        // call: List<object>.size
        // call: p6c3a6944.ensureChildNodes
        // type: List<object>
        return default!;
    }

    public p6c3a6944 ClearAttributes()
    {
        // call: IEnumerator<object>.next
        // call: IEnumerator<object>.remove
        // call: IEnumerator<object>.hasNext
        // call: p6c3a6944.attributes
        // call: p287234a1.iterator
        return default!;
    }

    public object Clone()
    {
        // call: p6c3a6944.clone
        return default!;
    }

    public p6c3a6944 Clone()
    {
        // call: p6c3a6944.ensureChildNodes
        // call: List<object>.add
        // call: List<object>.isEmpty
        // call: List<object>.get
        // call: List<object>.remove
        // call: List<object>.set
        // call: p6c3a6944.doClone
        // call: p6c3a6944.childNodeSize
        // call: List<object>.<init>
        // type: List<object>
        return default!;
    }

    private p6c3a6944 DoClone(p6c3a6944 P0)
    {
        // call: object.clone
        // call: Exception.<init>
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.fd1671dfb
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.f549658e6
        // type: Exception
        return default!;
    }

    private void DoSetBaseUri(string P0)
    {
    }

    private List<object> EnsureChildNodes()
    {
        return default!;
    }

    public bool Equals(object P0)
    {
        return false;
    }

    public p6c3a6944 Filter(p6ba5bed5 P0)
    {
        // call: pad3d06d0.m78a62b57
        // call: p0c1f47ee.mb2c97ae4
        return default!;
    }

    private p09453598$p98e1d1af GetOutputSettings()
    {
        // str: ""
        // call: p09453598.outputSettings
        // call: p6c3a6944.ownerDocument
        // call: p09453598.<init>
        // type: p09453598
        return default!;
    }

    public bool HasAttr(string P0)
    {
        // str: ""
        // str: "abs:"
        // call: string.substring
        // call: string.length
        // call: p287234a1.hasKeyIgnoreCase
        // call: p6c3a6944.attributes
        // call: pad3d06d0.m78a62b57
        // call: string.equals
        // call: p6c3a6944.absUrl
        // call: string.startsWith
        return false;
    }

    private bool HasAttributes()
    {
        return false;
    }

    public bool HasParent()
    {
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.f549658e6
        return false;
    }

    public bool HasSameValue(object P0)
    {
        // call: object.getClass
        // call: p6c3a6944.outerHtml
        // call: string.equals
        return false;
    }

    public Appendable Html(Appendable P0)
    {
        // call: p6c3a6944.outerHtml
        return default!;
    }

    private void Indent(Appendable P0, int P1, p09453598$p98e1d1af P2)
    {
        // call: p101ebc0f.mb70cdb87
        // call: Appendable.append
        // call: p09453598$p98e1d1af.indentAmount
    }

    public p6c3a6944 NextSibling()
    {
        // call: p6c3a6944.ensureChildNodes
        // call: List<object>.get
        // call: List<object>.size
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.fd1671dfb
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.f549658e6
        return default!;
    }

    public string NodeName()
    {
        return string.Empty;
    }

    private void NodelistChanged()
    {
    }

    public string OuterHtml()
    {
        // call: StringBuilder.<init>
        // call: p6c3a6944.outerHtml
        // call: StringBuilder.toString
        // type: StringBuilder
        return string.Empty;
    }

    private void OuterHtml(Appendable P0)
    {
        // call: p0c1f47ee.me6b03443
        // call: p6c3a6944$p303307bc.<init>
        // call: p6c3a6944.getOutputSettings
        // type: p6c3a6944$p303307bc
    }

    private void OuterHtmlHead(Appendable P0, int P1, p09453598$p98e1d1af P2)
    {
    }

    private void OuterHtmlTail(Appendable P0, int P1, p09453598$p98e1d1af P2)
    {
    }

    public p09453598 OwnerDocument()
    {
        // call: p6c3a6944.root
        return default!;
    }

    public p6c3a6944 Parent()
    {
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.f549658e6
        return default!;
    }

    public p6c3a6944 ParentNode()
    {
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.f549658e6
        return default!;
    }

    public p6c3a6944 PreviousSibling()
    {
        // call: p6c3a6944.ensureChildNodes
        // call: List<object>.get
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.f549658e6
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.fd1671dfb
        return default!;
    }

    public void Remove()
    {
        // call: p6c3a6944.removeChild
        // call: pad3d06d0.m78a62b57
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.f549658e6
    }

    public p6c3a6944 RemoveAttr(string P0)
    {
        // call: p287234a1.removeIgnoreCase
        // call: pad3d06d0.m78a62b57
        // call: p6c3a6944.attributes
        return default!;
    }

    private void RemoveChild(p6c3a6944 P0)
    {
        // call: p6c3a6944.ensureChildNodes
        // call: p6c3a6944.m06ddc1e7
        // call: pad3d06d0.mda0c5fd7
        // call: List<object>.remove
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.f549658e6
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.fd1671dfb
    }

    private void ReparentChild(p6c3a6944 P0)
    {
        // call: p6c3a6944.setParentNode
    }

    private void ReplaceChild(p6c3a6944 P0, p6c3a6944 P1)
    {
        // call: p6c3a6944.setSiblingIndex
        // call: pad3d06d0.mda0c5fd7
        // call: pad3d06d0.m78a62b57
        // call: p6c3a6944.ensureChildNodes
        // call: p6c3a6944.removeChild
        // call: List<object>.set
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.fd1671dfb
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.f549658e6
    }

    public void ReplaceWith(p6c3a6944 P0)
    {
        // call: p6c3a6944.replaceChild
        // call: pad3d06d0.m78a62b57
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.f549658e6
    }

    public p6c3a6944 Root()
    {
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.f549658e6
        return default!;
    }

    public void SetBaseUri(string P0)
    {
        // call: p6c3a6944.traverse
        // call: pad3d06d0.m78a62b57
        // call: p6c3a6944$1.<init>
        // type: p6c3a6944$1
    }

    private void SetParentNode(p6c3a6944 P0)
    {
        // call: p6c3a6944.removeChild
        // call: pad3d06d0.m78a62b57
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.f549658e6
    }

    private void SetSiblingIndex(int P0)
    {
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.fd1671dfb
    }

    public p6c3a6944 ShallowClone()
    {
        // call: p6c3a6944.doClone
        return default!;
    }

    public int SiblingIndex()
    {
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.fd1671dfb
        return 0;
    }

    public List<object> SiblingNodes()
    {
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: Collections.emptyList
        // call: List<object>.add
        // call: List<object>.<init>
        // call: List<object>.size
        // call: p6c3a6944.ensureChildNodes
        // call: List<object>.iterator
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.f549658e6
        // type: List<object>
        return default!;
    }

    public string ToString()
    {
        // call: p6c3a6944.outerHtml
        return string.Empty;
    }

    public p6c3a6944 Traverse(p6a4234ce P0)
    {
        // call: pad3d06d0.m78a62b57
        // call: p0c1f47ee.me6b03443
        return default!;
    }

    public p6c3a6944 Unwrap()
    {
        // call: List<object>.get
        // call: p6c3a6944.childNodesAsArray
        // call: p6c3a6944.ensureChildNodes
        // call: List<object>.size
        // call: pad3d06d0.m78a62b57
        // call: p6c3a6944.remove
        // call: p6c3a6944.addChildren
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.fd1671dfb
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.f549658e6
        return default!;
    }

    public p6c3a6944 Wrap(string P0)
    {
        // call: List<object>.size
        // call: p9a83ab0d.m9d829e92
        // call: p231afe47.appendChild
        // call: p231afe47.addChildren
        // call: p6c3a6944.m76cc8b46
        // call: p6c3a6944.removeChild
        // call: p6c3a6944.parent
        // call: List<object>.get
        // call: p6c3a6944.baseUri
        // call: pad3d06d0.m4d495f50
        // call: p6c3a6944.replaceChild
        // field: p5a445d71.pd2420bf0.pca15fd43.p6c3a6944.f549658e6
        return default!;
    }

}
