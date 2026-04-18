import re, os

test_dir = 'tests/PrTask.E2E'
files = sorted([f for f in os.listdir(test_dir) if f.startswith('FeatureTests.') and f.endswith('.cs') and f != 'FeatureTests.cs'])

global_seen = set()

for f in files:
    path = os.path.join(test_dir, f)
    content = open(path, encoding='utf-8-sig').read()

    pattern = r'\[TestMethod,\s*TestCategory\("(\w+)"\)\]\s*\[DisplayName\("([^"]+)"\)\]\s*public void (\w+)\(\)'

    methods_to_keep = []
    duplicates_removed = 0

    for m in re.finditer(pattern, content):
        cat, display, name = m.group(1), m.group(2), m.group(3)

        if name in global_seen:
            duplicates_removed += 1
            continue
        global_seen.add(name)

        rest = content[m.end():]
        brace_idx = rest.index('{')
        body_start = m.end() + brace_idx + 1

        # String-aware brace matching
        depth = 1
        i = body_start
        in_string = False
        escape_next = False
        while i < len(content) and depth > 0:
            ch = content[i]
            if escape_next:
                escape_next = False
                i += 1
                continue
            if ch == "\\" and in_string:
                escape_next = True
                i += 1
                continue
            if ch == '"':
                in_string = not in_string
            elif not in_string:
                if ch == '{':
                    depth += 1
                elif ch == '}':
                    depth -= 1
            i += 1

        body_raw = content[body_start:i-1]

        body_lines = []
        for line in body_raw.split('\n'):
            s = line.strip()
            if s and not s.startswith('[TestMethod') and not s.startswith('[DisplayName') and not s.startswith('public void'):
                body_lines.append('        ' + s)

        if body_lines:
            methods_to_keep.append((name, display, cat, '\n'.join(body_lines)))

    if duplicates_removed > 0:
        print(f"  {f}: removed {duplicates_removed} duplicates, keeping {len(methods_to_keep)}")

    if not methods_to_keep:
        os.remove(path)
        print(f"  DELETED {f} (empty)")
        continue

    lines = ['namespace PrTask.E2E;', 'public partial class FeatureTests', '{']
    for name, display, cat, body in methods_to_keep:
        lines.append(f'    [TestMethod, TestCategory("{cat}")]')
        lines.append(f'    [DisplayName("{display}")]')
        lines.append(f'    public void {name}()')
        lines.append('    {')
        lines.append(body)
        lines.append('    }')
    lines.append('}')
    lines.append('')

    result = '\n'.join(lines)
    with open(path, 'w', encoding='utf-8') as fout:
        fout.write(result)

# Final counts
files2 = sorted([f for f in os.listdir(test_dir) if f.startswith('FeatureTests.') and f.endswith('.cs') and f != 'FeatureTests.cs'])
total = 0
over = []
for f in files2:
    path = os.path.join(test_dir, f)
    c = open(path).read()
    mc = len(re.findall(r'public void \w+\(\)', c))
    lc = c.count('\n') + 1
    total += mc
    if lc > 300:
        over.append((f, lc, mc))

print(f"\nTotal: {total} methods across {len(files2)} files")
if over:
    print("Over 300 lines:")
    for f, lc, mc in over:
        print(f"  {f}: {lc} lines ({mc} methods)")
