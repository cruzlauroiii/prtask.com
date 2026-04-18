namespace WillowMaze.Wasm.Decompiled;

public class Pb9794896
{
    private readonly bool F18584a08;
    private readonly List<object> F1a7c2614;
    private readonly pc3755e61$p1c6e980e F1b7883ea;
    private readonly Dictionary<string, object> F1bc675ac;
    private readonly pdfadebdd F22c48431;
    private readonly bool F27a88005;
    private readonly List<object> F38c9fe91;
    private readonly List<object> F3ebb1149;
    private readonly Dictionary<string, object> F4bfe2dc0;
    private readonly pc3755e61$p1c6e980e F6dad1c95;
    private readonly TaskScheduler F6f14068c;
    private readonly pdfadebdd F6fdef5f4;
    private readonly TaskScheduler Fa7112515;
    private readonly pc3755e61$p1c6e980e Fafdddcb9;
    private readonly pc3755e61$p1c6e980e Fc9e298d7;
    private readonly List<object> Fcb8764fe;
    private readonly Dictionary<string, object> Fceba71e6;
    private readonly List<object> Fd9cf565c;
    private readonly List<object> Ff794a14c;
    private readonly pdfadebdd Ffded938d;

    private void ValidateServiceInterface(Type P0)
    {
        // str: "API declarations must be interfaces."
        // str: " which is an interface of "
        // str: "Type parameters are unsupported on "
        // call: p419f3742.isDefaultMethod
        // call: StringBuilder.append
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.toString
        // call: Type.isInterface
        // call: Method.getModifiers
        // call: Modifier.isStatic
        // call: Queue<object>.<init>
        // call: Type.getName
        // call: Type.getDeclaredMethods
        // call: Type.getTypeParameters
        // call: StringBuilder.<init>
        // call: pb9794896.loadServiceMethod
        // call: p419f3742.get
        // call: Type.getInterfaces
        // call: Collections.addAll
        // call: Queue<object>.add
        // call: Queue<object>.isEmpty
        // call: Queue<object>.removeFirst
        // field: paa20ed97.pb9794896.f27a88005
        // type: Queue<object>
        // type: IllegalArgumentException
        // type: StringBuilder
    }

    public pdfadebdd BaseUrl()
    {
        // field: paa20ed97.pb9794896.f22c48431
        return default!;
    }

    public pdb8ce672 CallAdapter(Type P0, Annotation[] P1)
    {
        // call: pb9794896.nextCallAdapter
        return default!;
    }

    public List<object> CallAdapterFactories()
    {
        // field: paa20ed97.pb9794896.fd9cf565c
        return default!;
    }

    public pc3755e61$p1c6e980e CallFactory()
    {
        // field: paa20ed97.pb9794896.fc9e298d7
        return default!;
    }

    public TaskScheduler CallbackExecutor()
    {
        // field: paa20ed97.pb9794896.fa7112515
        return default!;
    }

    public List<object> ConverterFactories()
    {
        // field: paa20ed97.pb9794896.fcb8764fe
        return default!;
    }

    public object Create(Type P0)
    {
        // call: pb9794896.validateServiceInterface
        // call: Type.getClassLoader
        // call: pb9794896$1.<init>
        // call: Proxy.newProxyInstance
        // type: pb9794896$1
        return default!;
    }

    private p4e021fbd LoadServiceMethod(Method P0)
    {
        // call: Dictionary<string, object>.get
        // call: p4e021fbd.parseAnnotations
        // call: Dictionary<string, object>.put
        // field: paa20ed97.pb9794896.f4bfe2dc0
        return default!;
    }

    public pb9794896$p2bd4a59b NewBuilder()
    {
        // call: pb9794896$p2bd4a59b.<init>
        // type: pb9794896$p2bd4a59b
        return default!;
    }

    public pdb8ce672 NextCallAdapter(pdb8ce672$p1c6e980e P0, Type P1, Annotation[] P2)
    {
        // str: "  Tried:"
        // str: "returnType == null"
        // str: "  Skipped:"
        // str: "\n   * "
        // str: "annotations == null"
        // str: ".\n"
        // str: "Could not locate call adapter for "
        // call: object.getClass
        // call: List<object>.indexOf
        // call: IllegalArgumentException.<init>
        // call: List<object>.get
        // call: List<object>.size
        // call: StringBuilder.toString
        // call: Type.getName
        // call: StringBuilder.append
        // call: Objects.requireNonNull
        // call: StringBuilder.<init>
        // call: pdb8ce672$p1c6e980e.get
        // field: paa20ed97.pb9794896.fd9cf565c
        // type: StringBuilder
        // type: IllegalArgumentException
        return default!;
    }

    public p60ad5b1d NextRequestBodyConverter(p60ad5b1d$p1c6e980e P0, Type P1, Annotation[] P2, Annotation[] P3)
    {
        // str: ".\n"
        // str: "Could not locate RequestBody converter for "
        // str: "type == null"
        // str: "  Skipped:"
        // str: "\n   * "
        // str: "methodAnnotations == null"
        // str: "parameterAnnotations == null"
        // str: "  Tried:"
        // call: p60ad5b1d$p1c6e980e.requestBodyConverter
        // call: StringBuilder.append
        // call: List<object>.indexOf
        // call: IllegalArgumentException.<init>
        // call: List<object>.get
        // call: Objects.requireNonNull
        // call: StringBuilder.<init>
        // call: object.getClass
        // call: List<object>.size
        // call: Type.getName
        // call: StringBuilder.toString
        // field: paa20ed97.pb9794896.fcb8764fe
        // type: IllegalArgumentException
        // type: StringBuilder
        return default!;
    }

    public p60ad5b1d NextResponseBodyConverter(p60ad5b1d$p1c6e980e P0, Type P1, Annotation[] P2)
    {
        // str: ".\n"
        // str: "\n   * "
        // str: "annotations == null"
        // str: "Could not locate ResponseBody converter for "
        // str: "  Skipped:"
        // str: "type == null"
        // str: "  Tried:"
        // call: StringBuilder.append
        // call: List<object>.get
        // call: List<object>.size
        // call: IllegalArgumentException.<init>
        // call: Objects.requireNonNull
        // call: List<object>.indexOf
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: Type.getName
        // call: object.getClass
        // call: p60ad5b1d$p1c6e980e.responseBodyConverter
        // field: paa20ed97.pb9794896.fcb8764fe
        // type: StringBuilder
        // type: IllegalArgumentException
        return default!;
    }

    public p60ad5b1d RequestBodyConverter(Type P0, Annotation[] P1, Annotation[] P2)
    {
        // call: pb9794896.nextRequestBodyConverter
        return default!;
    }

    public p60ad5b1d ResponseBodyConverter(Type P0, Annotation[] P1)
    {
        // call: pb9794896.nextResponseBodyConverter
        return default!;
    }

    public p60ad5b1d StringConverter(Type P0, Annotation[] P1)
    {
        // str: "annotations == null"
        // str: "type == null"
        // call: List<object>.size
        // call: List<object>.get
        // call: Objects.requireNonNull
        // call: p60ad5b1d$p1c6e980e.stringConverter
        // field: paa20ed97.pb9794896.fcb8764fe
        // field: paa20ed97.peeaf755e$pc8443200.f76425f17
        return default!;
    }

}
