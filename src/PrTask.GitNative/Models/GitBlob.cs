using System.Text;

namespace PrTask.GitNative.Models;

#pragma warning disable SA1600
public sealed class GitBlob : GitObject
{
    public byte[] Content { get; set; } = [];

    public override GitObjectType Type => GitObjectType.Blob;

    public override byte[] Serialize() => Content;

    public int Size => Content.Length;

    public string GetText() => Encoding.UTF8.GetString(Content);

    public static GitBlob FromBytes(byte[] Data) => new() { Content = Data };

    public static GitBlob FromText(string Text) => new() { Content = Encoding.UTF8.GetBytes(Text) };

    public static GitBlob FromRaw(GitRawObject Obj) => new()
    {
        Hash = Obj.Hash,
        Content = Obj.Data,
    };
}
#pragma warning restore SA1600
