using System.Text;
using System.Text.RegularExpressions;

namespace PrTask.Transpiler;

public sealed class ServerToWssTranspiler
{
    private const string EmptyStr = "";
    private readonly string EndpointsDir;
    private readonly string OutputDir;

    public ServerToWssTranspiler(string EndpointsDir, string OutputDir)
    {
        this.EndpointsDir = EndpointsDir;
        this.OutputDir = OutputDir;
    }

    public void Transpile()
    {
        var EndpointFiles = Directory.GetFiles(EndpointsDir, "*Endpoints*.cs")
            .Where(F => !Path.GetFileName(F).Equals("EndpointContracts.cs", StringComparison.OrdinalIgnoreCase))
            .OrderBy(F => F)
            .ToList();

        var AllEndpoints = new List<EndpointDef>();

        foreach (var File in EndpointFiles)
        {
            var Source = System.IO.File.ReadAllText(File);
            var Parsed = ParseEndpoints(Source, Path.GetFileNameWithoutExtension(File));
            AllEndpoints.AddRange(Parsed);
        }

        Console.WriteLine($"  Parsed {AllEndpoints.Count} endpoints from {EndpointFiles.Count} files");

        var HandlerTs = GenerateHandler(AllEndpoints);
        var TypesTs = GenerateTypes(AllEndpoints);
        var CollectionsTs = GenerateCollections(AllEndpoints);

        Directory.CreateDirectory(Path.Combine(OutputDir, "websocket"));

        System.IO.File.WriteAllText(Path.Combine(OutputDir, "websocket", "handler.ts"), HandlerTs);
        System.IO.File.WriteAllText(Path.Combine(OutputDir, "websocket", "types.ts"), TypesTs);
        System.IO.File.WriteAllText(Path.Combine(OutputDir, "websocket", "collections.ts"), CollectionsTs);

        Console.WriteLine("  Generated websocket/handler.ts");
        Console.WriteLine("  Generated websocket/types.ts");
        Console.WriteLine("  Generated websocket/collections.ts");
    }

    private static List<EndpointDef> ParseEndpoints(string Source, string FileName)
    {
        var Results = new List<EndpointDef>();
        var GroupMatch = Regex.Match(Source, @"MapGroup\(\s*(?:RouteConstants\.)?(\w+)\s*\)");
        var GroupPrefix = GroupMatch.Success ? GroupMatch.Groups[1].Value : string.Empty;

        var MapPattern = new Regex(@"\.\s*Map(Get|Post|Put|Patch|Delete)\s*\(");
        var Matches = MapPattern.Matches(Source);

        foreach (Match M in Matches)
        {
            var HttpMethod = M.Groups[1].Value.ToUpperInvariant();
            var AfterMap = Source[M.Index..];

            var RouteMatch = Regex.Match(AfterMap, @"Map\w+\(\s*(?:RouteConstants\.)?(?:""([^""]*)""|(\w+)|\$""([^""]*)"")");
            var Route = string.Empty;
            if (RouteMatch.Success)
            {
                Route = RouteMatch.Groups[1].Success ? RouteMatch.Groups[1].Value
                    : RouteMatch.Groups[2].Success ? RouteMatch.Groups[2].Value
                    : RouteMatch.Groups[3].Success ? RouteMatch.Groups[3].Value
                    : string.Empty;
            }

            var ParamMatch = Regex.Match(AfterMap, @"async\s*\(([^)]*)\)");
            var Params = ParamMatch.Success ? ParamMatch.Groups[1].Value.Trim() : string.Empty;

            var EndIdx = Math.Min(M.Index + 2000, Source.Length);
            var Chunk = Source[M.Index..EndIdx];
            var HasAuth = Chunk.Contains("RequireAuthorization");

            var Ep = new EndpointDef
            {
                HttpMethod = HttpMethod,
                RouteLiteral = Route,
                ParameterList = Params,
                GroupPrefix = GroupPrefix,
                SourceFile = FileName,
                RequiresAuth = HasAuth,
            };
            Ep.DeriveMessageType();
            Ep.ParseParameters();
            Results.Add(Ep);
        }

        return Results;
    }

    private static string GenerateHandler(List<EndpointDef> Endpoints)
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("import { GitHubRead, GitHubWrite, GitHubDelete, GitHubList } from \"./collections\";");
        Sb.AppendLine("import type { UserClaims, WsMessage, Env, ClientConnection } from \"./types\";");
        Sb.AppendLine();
        Sb.AppendLine("const Clients = new Map<WebSocket, ClientConnection>();");
        Sb.AppendLine();
        Sb.AppendLine("export function registerClient(Ws: WebSocket, User: UserClaims | null): void {");
        Sb.AppendLine("  Clients.set(Ws, { Ws, User, Channels: new Set() });");
        Sb.AppendLine("}");
        Sb.AppendLine();
        Sb.AppendLine("export function unregisterClient(Ws: WebSocket): void {");
        Sb.AppendLine("  Clients.delete(Ws);");
        Sb.AppendLine("}");
        Sb.AppendLine();
        Sb.AppendLine("function BroadcastToChannel(Channel: string, Payload: string, ExcludeWs?: WebSocket): void {");
        Sb.AppendLine("  for (const [Ws, Client] of Clients) {");
        Sb.AppendLine("    if (Ws === ExcludeWs) continue;");
        Sb.AppendLine("    if (Client.Channels.has(Channel)) {");
        Sb.AppendLine("      try { Ws.send(Payload); } catch { Clients.delete(Ws); }");
        Sb.AppendLine("    }");
        Sb.AppendLine("  }");
        Sb.AppendLine("}");
        Sb.AppendLine();
        Sb.AppendLine("function Reply(Ws: WebSocket, Msg: WsMessage, Data: unknown): void {");
        Sb.AppendLine("  Ws.send(JSON.stringify({ Type: \"Data\", Id: Msg.Id, Data }));");
        Sb.AppendLine("}");
        Sb.AppendLine();
        Sb.AppendLine("function ReplyOk(Ws: WebSocket, Msg: WsMessage): void {");
        Sb.AppendLine("  Ws.send(JSON.stringify({ Type: \"Ack\", Id: Msg.Id, Success: true }));");
        Sb.AppendLine("}");
        Sb.AppendLine();
        Sb.AppendLine("function ReplyError(Ws: WebSocket, Msg: WsMessage, Message: string): void {");
        Sb.AppendLine("  Ws.send(JSON.stringify({ Type: \"Error\", Id: Msg.Id, Message }));");
        Sb.AppendLine("}");
        Sb.AppendLine();
        Sb.AppendLine("function RequireAuth(Ws: WebSocket, Msg: WsMessage, Client: ClientConnection): boolean {");
        Sb.AppendLine("  if (!Client.User) {");
        Sb.AppendLine("    ReplyError(Ws, Msg, \"Authentication required\");");
        Sb.AppendLine("    return false;");
        Sb.AppendLine("  }");
        Sb.AppendLine("  return true;");
        Sb.AppendLine("}");
        Sb.AppendLine();

        Sb.AppendLine("export async function handleWsMessage(");
        Sb.AppendLine("  Ws: WebSocket, Raw: string, Env: Env,");
        Sb.AppendLine("): Promise<void> {");
        Sb.AppendLine("  let Msg: WsMessage;");
        Sb.AppendLine("  try { Msg = JSON.parse(Raw); }");
        Sb.AppendLine("  catch { Ws.send(JSON.stringify({ Type: \"Error\", Message: \"Invalid JSON\" })); return; }");
        Sb.AppendLine();
        Sb.AppendLine("  const Client = Clients.get(Ws);");
        Sb.AppendLine("  if (!Client) { Ws.send(JSON.stringify({ Type: \"Error\", Message: \"Not registered\" })); return; }");
        Sb.AppendLine();
        Sb.AppendLine("  switch (Msg.Type) {");

        Sb.AppendLine("    case \"Subscribe\":");
        Sb.AppendLine("      if (Msg.Channel) {");
        Sb.AppendLine("        Client.Channels.add(Msg.Channel);");
        Sb.AppendLine("        Ws.send(JSON.stringify({ Type: \"Ack\", Id: Msg.Id, Channel: Msg.Channel }));");
        Sb.AppendLine("      }");
        Sb.AppendLine("      break;");
        Sb.AppendLine();
        Sb.AppendLine("    case \"UserInfo\":");
        Sb.AppendLine("      if (!Client.User) { ReplyError(Ws, Msg, \"Not authenticated\"); break; }");
        Sb.AppendLine("      Reply(Ws, Msg, Client.User);");
        Sb.AppendLine("      break;");
        Sb.AppendLine();

        var GroupedBySource = Endpoints.GroupBy(E => E.SourceFile).OrderBy(G => G.Key);
        var VarCounter = 0;

        foreach (var Group in GroupedBySource)
        {
            Sb.AppendLine($"    // {Group.Key}");
            foreach (var Ep in Group)
            {
                var Collection = Ep.DeriveCollection();
                var V = VarCounter++;
                Sb.AppendLine($"    case \"{Ep.MessageType}\": {{");

                if (Ep.RequiresAuth)
                {
                    Sb.AppendLine("      if (!RequireAuth(Ws, Msg, Client)) break;");
                }

                switch (Ep.HttpMethod)
                {
                    case "GET" when Ep.HasIdParam:
                        Sb.AppendLine($"      const R{V} = await GitHubRead(Env, \"{Collection}/\" + (Msg.Data?.Id ?? EmptyStr) + \".json\");");
                        Sb.AppendLine($"      if (!R{V}) {{ ReplyError(Ws, Msg, \"Not found\"); break; }}");
                        Sb.AppendLine($"      Reply(Ws, Msg, JSON.parse(R{V}.Content));");
                        break;
                    case "GET":
                        Sb.AppendLine($"      const L{V} = await GitHubList(Env, \"{Collection}\");");
                        Sb.AppendLine($"      Reply(Ws, Msg, L{V});");
                        break;
                    case "POST" when Ep.IsAction:
                        Sb.AppendLine($"      const E{V} = await GitHubRead(Env, \"{Collection}/\" + (Msg.Data?.Id ?? EmptyStr) + \".json\");");
                        Sb.AppendLine($"      if (!E{V}) {{ ReplyError(Ws, Msg, \"Not found\"); break; }}");
                        Sb.AppendLine($"      const U{V} = {{ ...JSON.parse(E{V}.Content), ...Msg.Data }};");
                        Sb.AppendLine($"      await GitHubWrite(Env, \"{Collection}/\" + Msg.Data?.Id + \".json\", JSON.stringify(U{V}, null, 2), \"{Ep.MessageType}\", E{V}.Sha);");
                        Sb.AppendLine("      ReplyOk(Ws, Msg);");
                        Sb.AppendLine($"      BroadcastToChannel(\"{Collection}\", JSON.stringify({{ Type: \"Mutation\", Channel: \"{Collection}\", Data: U{V} }}), Ws);");
                        break;
                    case "POST":
                        Sb.AppendLine($"      const I{V} = Msg.Data?.Id ?? crypto.randomUUID();");
                        Sb.AppendLine($"      const N{V} = {{ ...Msg.Data, Id: I{V} }};");
                        Sb.AppendLine($"      await GitHubWrite(Env, \"{Collection}/\" + I{V} + \".json\", JSON.stringify(N{V}, null, 2), \"Create {Collection}\");");
                        Sb.AppendLine($"      Reply(Ws, Msg, N{V});");
                        Sb.AppendLine($"      BroadcastToChannel(\"{Collection}\", JSON.stringify({{ Type: \"Mutation\", Channel: \"{Collection}\", Data: N{V} }}), Ws);");
                        break;
                    case "PUT":
                    case "PATCH":
                        Sb.AppendLine($"      const C{V} = await GitHubRead(Env, \"{Collection}/\" + (Msg.Data?.Id ?? EmptyStr) + \".json\");");
                        Sb.AppendLine($"      if (!C{V}) {{ ReplyError(Ws, Msg, \"Not found\"); break; }}");
                        Sb.AppendLine($"      const M{V} = {{ ...JSON.parse(C{V}.Content), ...Msg.Data }};");
                        Sb.AppendLine($"      await GitHubWrite(Env, \"{Collection}/\" + Msg.Data?.Id + \".json\", JSON.stringify(M{V}, null, 2), \"Update {Collection}\", C{V}.Sha);");
                        Sb.AppendLine($"      Reply(Ws, Msg, M{V});");
                        Sb.AppendLine($"      BroadcastToChannel(\"{Collection}\", JSON.stringify({{ Type: \"Mutation\", Channel: \"{Collection}\", Data: M{V} }}), Ws);");
                        break;
                    case "DELETE":
                        Sb.AppendLine($"      const D{V} = await GitHubRead(Env, \"{Collection}/\" + (Msg.Data?.Id ?? EmptyStr) + \".json\");");
                        Sb.AppendLine($"      if (!D{V}) {{ ReplyError(Ws, Msg, \"Not found\"); break; }}");
                        Sb.AppendLine($"      await GitHubDelete(Env, \"{Collection}/\" + Msg.Data?.Id + \".json\", D{V}.Sha, \"Delete {Collection}\");");
                        Sb.AppendLine("      ReplyOk(Ws, Msg);");
                        Sb.AppendLine($"      BroadcastToChannel(\"{Collection}\", JSON.stringify({{ Type: \"Deletion\", Channel: \"{Collection}\", Id: Msg.Data?.Id }}), Ws);");
                        break;
                }

                Sb.AppendLine("      break;");
                Sb.AppendLine("    }");
            }
        }

        Sb.AppendLine();
        Sb.AppendLine("    default:");
        Sb.AppendLine("      ReplyError(Ws, Msg, `Unknown message type: ${Msg.Type}`);");
        Sb.AppendLine("  }");
        Sb.AppendLine("}");
        Sb.AppendLine();
        Sb.AppendLine("const EmptyStr = \"\";");

        return Sb.ToString();
    }

    private static string GenerateTypes(List<EndpointDef> Endpoints)
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("export interface UserClaims {");
        Sb.AppendLine("  userId: string;");
        Sb.AppendLine("  username: string;");
        Sb.AppendLine("  email: string;");
        Sb.AppendLine("  avatarUrl: string;");
        Sb.AppendLine("  role: string;");
        Sb.AppendLine("  provider: string;");
        Sb.AppendLine("}");
        Sb.AppendLine();
        Sb.AppendLine("export interface Env {");
        Sb.AppendLine("  GOOGLE_CLIENT_ID: string;");
        Sb.AppendLine("  GOOGLE_CLIENT_SECRET: string;");
        Sb.AppendLine("  GITHUB_CLIENT_ID: string;");
        Sb.AppendLine("  GITHUB_CLIENT_SECRET: string;");
        Sb.AppendLine("  AZURE_CLIENT_ID: string;");
        Sb.AppendLine("  AZURE_CLIENT_SECRET: string;");
        Sb.AppendLine("  OKTA_CLIENT_ID: string;");
        Sb.AppendLine("  OKTA_CLIENT_SECRET: string;");
        Sb.AppendLine("  OKTA_DOMAIN: string;");
        Sb.AppendLine("  GITHUB_PAT: string;");
        Sb.AppendLine("  GITHUB_REPO_OWNER: string;");
        Sb.AppendLine("  GITHUB_REPO_NAME: string;");
        Sb.AppendLine("}");
        Sb.AppendLine();
        Sb.AppendLine("export interface ClientConnection {");
        Sb.AppendLine("  Ws: WebSocket;");
        Sb.AppendLine("  User: UserClaims | null;");
        Sb.AppendLine("  Channels: Set<string>;");
        Sb.AppendLine("}");
        Sb.AppendLine();
        Sb.AppendLine("export interface WsMessage {");
        Sb.AppendLine("  Type: string;");
        Sb.AppendLine("  Id?: string;");
        Sb.AppendLine("  Channel?: string;");
        Sb.AppendLine("  Collection?: string;");
        Sb.AppendLine("  Path?: string;");
        Sb.AppendLine("  Data?: Record<string, unknown>;");
        Sb.AppendLine("}");
        Sb.AppendLine();

        Sb.AppendLine("export type MessageType =");
        var Types = Endpoints.Select(E => E.MessageType).Distinct().OrderBy(T => T).ToList();
        for (var I = 0; I < Types.Count; I++)
        {
            var Suffix = I == Types.Count - 1 ? ";" : string.Empty;
            Sb.AppendLine($"  | \"{Types[I]}\"{Suffix}");
        }

        return Sb.ToString();
    }

    private static string GenerateCollections(List<EndpointDef> Endpoints)
    {
        var Sb = new StringBuilder();
        Sb.AppendLine("import type { Env } from \"./types\";");
        Sb.AppendLine();
        Sb.AppendLine("const BaseUrl = (Env: Env) => `https://api.github.com/repos/${Env.GITHUB_REPO_OWNER}/${Env.GITHUB_REPO_NAME}/contents`;");
        Sb.AppendLine();
        Sb.AppendLine("const Headers = (Env: Env) => ({");
        Sb.AppendLine("  Authorization: `Bearer ${Env.GITHUB_PAT}`,");
        Sb.AppendLine("  Accept: \"application/vnd.github.v3+json\",");
        Sb.AppendLine("  \"User-Agent\": \"PrTask\",");
        Sb.AppendLine("  \"Content-Type\": \"application/json\",");
        Sb.AppendLine("});");
        Sb.AppendLine();
        Sb.AppendLine("export async function GitHubRead(");
        Sb.AppendLine("  Env: Env, Path: string,");
        Sb.AppendLine("): Promise<{ Content: string; Sha: string } | null> {");
        Sb.AppendLine("  const Res = await fetch(`${BaseUrl(Env)}/${Path}`, { headers: Headers(Env) });");
        Sb.AppendLine("  if (!Res.ok) return null;");
        Sb.AppendLine("  const Json = (await Res.json()) as { content: string; sha: string };");
        Sb.AppendLine("  const Decoded = decodeURIComponent(escape(atob(Json.content.replace(/\\n/g, \"\"))));");
        Sb.AppendLine("  return { Content: Decoded, Sha: Json.sha };");
        Sb.AppendLine("}");
        Sb.AppendLine();
        Sb.AppendLine("export async function GitHubWrite(");
        Sb.AppendLine("  Env: Env, Path: string, Content: string, Message: string, Sha?: string,");
        Sb.AppendLine("): Promise<boolean> {");
        Sb.AppendLine("  const Body: Record<string, string> = {");
        Sb.AppendLine("    message: Message,");
        Sb.AppendLine("    content: btoa(unescape(encodeURIComponent(Content))),");
        Sb.AppendLine("  };");
        Sb.AppendLine("  if (Sha) Body.sha = Sha;");
        Sb.AppendLine("  const Res = await fetch(`${BaseUrl(Env)}/${Path}`, {");
        Sb.AppendLine("    method: \"PUT\",");
        Sb.AppendLine("    headers: Headers(Env),");
        Sb.AppendLine("    body: JSON.stringify(Body),");
        Sb.AppendLine("  });");
        Sb.AppendLine("  return Res.ok;");
        Sb.AppendLine("}");
        Sb.AppendLine();
        Sb.AppendLine("export async function GitHubDelete(");
        Sb.AppendLine("  Env: Env, Path: string, Sha: string, Message: string,");
        Sb.AppendLine("): Promise<boolean> {");
        Sb.AppendLine("  const Res = await fetch(`${BaseUrl(Env)}/${Path}`, {");
        Sb.AppendLine("    method: \"DELETE\",");
        Sb.AppendLine("    headers: Headers(Env),");
        Sb.AppendLine("    body: JSON.stringify({ message: Message, sha: Sha }),");
        Sb.AppendLine("  });");
        Sb.AppendLine("  return Res.ok;");
        Sb.AppendLine("}");
        Sb.AppendLine();
        Sb.AppendLine("export async function GitHubList(");
        Sb.AppendLine("  Env: Env, Dir: string,");
        Sb.AppendLine("): Promise<unknown[]> {");
        Sb.AppendLine("  const Res = await fetch(`${BaseUrl(Env)}/${Dir}`, { headers: Headers(Env) });");
        Sb.AppendLine("  if (!Res.ok) return [];");
        Sb.AppendLine("  const Files = (await Res.json()) as { name: string; path: string }[];");
        Sb.AppendLine("  const Results: unknown[] = [];");
        Sb.AppendLine("  for (const File of Files) {");
        Sb.AppendLine("    if (!File.name.endsWith(\".json\")) continue;");
        Sb.AppendLine("    const Item = await GitHubRead(Env, File.path);");
        Sb.AppendLine("    if (Item) Results.push(JSON.parse(Item.Content));");
        Sb.AppendLine("  }");
        Sb.AppendLine("  return Results;");
        Sb.AppendLine("}");

        var Collections = Endpoints.Select(E => E.DeriveCollection()).Distinct().OrderBy(C => C).ToList();
        Sb.AppendLine();
        Sb.AppendLine("export const Collections = [");
        foreach (var C in Collections)
        {
            Sb.AppendLine($"  \"{C}\",");
        }
        Sb.AppendLine("] as const;");

        return Sb.ToString();
    }
}

public sealed class EndpointDef
{
    public string HttpMethod { get; set; } = string.Empty;
    public string RouteLiteral { get; set; } = string.Empty;
    public string RouteConstant { get; set; } = string.Empty;
    public string RouteInterpolated { get; set; } = string.Empty;
    public string ParameterList { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public string GroupPrefix { get; set; } = string.Empty;
    public string SourceFile { get; set; } = string.Empty;
    public bool RequiresAuth { get; set; }
    public string MessageType { get; set; } = string.Empty;
    public bool HasIdParam { get; set; }
    public bool IsAction { get; set; }
    public List<string> ServiceMethods { get; set; } = [];
    public List<EndpointParam> Params { get; set; } = [];

    public void DeriveMessageType()
    {
        var BaseName = SourceFile.Replace("Endpoints", string.Empty).Replace(".", string.Empty);

        var Route = !string.IsNullOrEmpty(RouteLiteral) ? RouteLiteral : RouteConstant;

        var RouteSuffix = ExtractRouteSuffix(Route);

        var ActionWords = new[] { "Claim", "Approve", "Reject", "Execute", "Process", "Resolve", "Cancel", "Capture", "Void", "Refund" };
        foreach (var Word in ActionWords)
        {
            if (Route.Contains($"/{Word}", StringComparison.OrdinalIgnoreCase) ||
                RouteSuffix.Contains(Word, StringComparison.OrdinalIgnoreCase))
            {
                IsAction = true;
                break;
            }
        }

        if (Route.Contains('{'))
        {
            HasIdParam = true;
        }

        var Prefix = HttpMethod switch
        {
            "GET" when !HasIdParam => "List",
            "GET" => "Get",
            "POST" when IsAction => string.Empty,
            "POST" => "Create",
            "PUT" => "Update",
            "PATCH" => "Update",
            "DELETE" => "Delete",
            _ => HttpMethod,
        };

        MessageType = $"{Prefix}{BaseName}{RouteSuffix}";
    }

    private static string ExtractRouteSuffix(string Route)
    {
        var Segments = Route.Split('/', StringSplitOptions.RemoveEmptyEntries);
        var Sb = new StringBuilder();
        foreach (var Seg in Segments)
        {
            if (Seg.StartsWith('{'))
            {
                continue;
            }

            if (Seg.StartsWith("Sub", StringComparison.Ordinal))
            {
                Sb.Append(Seg.AsSpan(3));
            }
            else
            {
                Sb.Append(char.ToUpperInvariant(Seg[0]));
                Sb.Append(Seg.AsSpan(1));
            }
        }

        return Sb.ToString();
    }

    public void ParseParameters()
    {
        if (string.IsNullOrWhiteSpace(ParameterList))
        {
            return;
        }

        var Parts = ParameterList.Split(',', StringSplitOptions.TrimEntries);
        foreach (var Part in Parts)
        {
            var Tokens = Part.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (Tokens.Length >= 2)
            {
                var TypeName = Tokens[0];
                var ParamName = Tokens[1];
                if (TypeName.StartsWith('I') && TypeName.EndsWith("Service", StringComparison.Ordinal))
                {
                    continue;
                }

                if (TypeName == "ILogger" || TypeName.StartsWith("ILogger<", StringComparison.Ordinal))
                {
                    continue;
                }

                if (TypeName == "HttpContext")
                {
                    continue;
                }

                Params.Add(new EndpointParam { TypeName = TypeName, Name = ParamName });
                if (ParamName.EndsWith("Id", StringComparison.OrdinalIgnoreCase))
                {
                    HasIdParam = true;
                }
            }
        }
    }

    public string DeriveCollection()
    {
        var Name = SourceFile
            .Replace("Endpoints", string.Empty)
            .Replace(".", string.Empty)
            .Replace("V2", string.Empty)
            .Replace("Operations", string.Empty)
            .Replace("Vault", string.Empty)
            .Replace("Bin", string.Empty)
            .Replace("Recurring", string.Empty);

        return $"data/{CamelToKebab(Name)}";
    }

    private static string CamelToKebab(string Input)
    {
        return Regex.Replace(Input, @"(?<!^)([A-Z])", "-$1").ToLowerInvariant();
    }
}

public sealed class EndpointParam
{
    public string TypeName { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}
