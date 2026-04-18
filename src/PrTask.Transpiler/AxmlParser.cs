using System.Text;

namespace PrTask.Transpiler;

public sealed class AxmlParser
{
    private readonly byte[] Data;
    private string[] StringPool = [];

    public AxmlParser(byte[] Data)
    {
        this.Data = Data;
    }

    public AxmlDocument? Parse()
    {
        if (Data.Length < 8)
        {
            return null;
        }

        var Magic = R32(0);
        if (Magic != 0x00080003)
        {
            return null;
        }

        var Pos = 8;
        StringPool = [];

        var Doc = new AxmlDocument();
        var Stack = new Stack<AxmlElement>();

        while (Pos + 8 <= Data.Length)
        {
            var ChunkType = R16(Pos);
            var ChunkSize = R32(Pos + 4);

            if (ChunkSize <= 0 || Pos + ChunkSize > Data.Length)
            {
                break;
            }

            if (ChunkType == 0x0001)
            {
                StringPool = ParseStringPool(Pos, ChunkSize);
            }
            else if (ChunkType == 0x0100)
            {
                if (Pos + 24 <= Data.Length)
                {
                    var NsIdx = R32(Pos + 16);
                    var UriIdx = R32(Pos + 20);
                    if (NsIdx >= 0 && NsIdx < StringPool.Length && UriIdx >= 0 && UriIdx < StringPool.Length)
                    {
                        Doc.Namespaces[StringPool[NsIdx]] = StringPool[UriIdx];
                    }
                }
            }
            else if (ChunkType == 0x0102)
            {
                var NameIdx = R32(Pos + 20);
                var AttrCount = R16(Pos + 28);

                var TagName = NameIdx >= 0 && NameIdx < StringPool.Length ? StringPool[NameIdx] : "unknown";
                var Element = new AxmlElement(TagName);

                for (var A = 0; A < AttrCount; A++)
                {
                    var AttrOffset = Pos + 36 + (A * 20);
                    if (AttrOffset + 20 > Data.Length)
                    {
                        break;
                    }

                    var AttrNsIdx = R32(AttrOffset);
                    var AttrNameIdx = R32(AttrOffset + 4);
                    var AttrValueStringIdx = R32(AttrOffset + 8);
                    var AttrValueType = R16(AttrOffset + 14);
                    var AttrValueData = R32(AttrOffset + 16);

                    var AttrName = AttrNameIdx >= 0 && AttrNameIdx < StringPool.Length ? StringPool[AttrNameIdx] : "attr" + A;
                    var AttrValue = ResolveAttrValue(AttrValueStringIdx, AttrValueType, AttrValueData);

                    Element.Attributes.Add(new AxmlAttr(string.Empty, AttrName, AttrValue, AttrValueType, AttrValueData));
                }

                if (Stack.Count > 0)
                {
                    Stack.Peek().Children.Add(Element);
                }
                else
                {
                    Doc.Root = Element;
                }

                Stack.Push(Element);
            }
            else if (ChunkType == 0x0103)
            {
                if (Stack.Count > 0)
                {
                    Stack.Pop();
                }
            }

            Pos += ChunkSize;
        }

        return Doc.Root is not null ? Doc : null;
    }

    private string[] ParseStringPool(int Offset, int ChunkSize)
    {
        var StringCount = R32(Offset + 8);
        var Flags = R32(Offset + 16);
        var StringsStart = R32(Offset + 20);
        var IsUtf8 = (Flags & (1 << 8)) != 0;
        var Pool = new string[StringCount];

        for (var I = 0; I < StringCount; I++)
        {
            var StringOffset = R32(Offset + 28 + (I * 4));
            var AbsOffset = Offset + StringsStart + StringOffset;

            if (AbsOffset >= Data.Length)
            {
                Pool[I] = string.Empty;
                continue;
            }

            if (IsUtf8)
            {
                Pool[I] = ReadUtf8String(AbsOffset);
            }
            else
            {
                Pool[I] = ReadUtf16String(AbsOffset);
            }
        }

        return Pool;
    }

    private string ReadUtf8String(int Offset)
    {
        var Pos = Offset;
        var CharLen = Data[Pos++];
        if ((CharLen & 0x80) != 0)
        {
            Pos++;
        }

        var ByteLen = (int)Data[Pos++];
        if ((ByteLen & 0x80) != 0)
        {
            ByteLen = ((ByteLen & 0x7F) << 8) | Data[Pos++];
        }

        if (Pos + ByteLen > Data.Length)
        {
            return string.Empty;
        }

        return Encoding.UTF8.GetString(Data, Pos, ByteLen);
    }

    private string ReadUtf16String(int Offset)
    {
        var Len = R16(Offset);
        if ((Len & 0x8000) != 0)
        {
            Len = ((Len & 0x7FFF) << 16) | R16(Offset + 2);
            Offset += 4;
        }
        else
        {
            Offset += 2;
        }

        if (Offset + (Len * 2) > Data.Length)
        {
            return string.Empty;
        }

        return Encoding.Unicode.GetString(Data, Offset, Len * 2);
    }

    private string ResolveAttrValue(int StringIdx, int ValueType, int ValueData)
    {
        if (ValueType == 0x03 && StringIdx >= 0 && StringIdx < StringPool.Length)
        {
            return StringPool[StringIdx];
        }

        return ValueType switch
        {
            0x01 => string.Format(System.Globalization.CultureInfo.InvariantCulture, "@ref/0x{0:X8}", ValueData),
            0x02 => string.Format(System.Globalization.CultureInfo.InvariantCulture, "?attr/0x{0:X8}", ValueData),
            0x04 => ValueData.ToString(System.Globalization.CultureInfo.InvariantCulture) + "f",
            0x05 => FormatDimension(ValueData),
            0x10 => ValueData.ToString(System.Globalization.CultureInfo.InvariantCulture),
            0x11 => string.Format(System.Globalization.CultureInfo.InvariantCulture, "0x{0:X8}", ValueData),
            0x12 => ValueData != 0 ? "true" : "false",
            0x1C => string.Format(System.Globalization.CultureInfo.InvariantCulture, "#{0:X8}", ValueData),
            _ when StringIdx >= 0 && StringIdx < StringPool.Length => StringPool[StringIdx],
            _ => ValueData.ToString(System.Globalization.CultureInfo.InvariantCulture)
        };
    }

    private static string FormatDimension(int Value)
    {
        var UnitTypes = new[] { "px", "dp", "sp", "pt", "in", "mm" };
        var Unit = Value & 0x0F;
        var Mantissa = (Value >> 8) & 0xFFFFFF;
        var UnitStr = Unit < UnitTypes.Length ? UnitTypes[Unit] : "px";
        return Mantissa + UnitStr;
    }

    private int R16(int Off)
    {
        return Off + 1 < Data.Length ? BitConverter.ToUInt16(Data, Off) : 0;
    }

    private int R32(int Off)
    {
        return Off + 3 < Data.Length ? BitConverter.ToInt32(Data, Off) : 0;
    }
}

public sealed class AxmlDocument
{
    public AxmlElement? Root { get; set; }
    public Dictionary<string, string> Namespaces { get; } = new();
}

public sealed class AxmlElement
{
    public string Tag { get; }
    public List<AxmlAttr> Attributes { get; } = [];
    public List<AxmlElement> Children { get; } = [];

    public AxmlElement(string Tag) => this.Tag = Tag;

    public string? GetAttr(string Name) => Attributes.FirstOrDefault(A => A.Name == Name)?.Value;
}

public sealed record AxmlAttr(string Namespace, string Name, string Value, int ValueType, int ValueData);
