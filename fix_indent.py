"""Fix indentation in split ClaudeMd files."""
import os, glob

for filepath in sorted(glob.glob('tests/PrTask.E2E/ArchitectureTests.ClaudeMd?.cs')):
    with open(filepath, 'r', encoding='utf-8') as f:
        content = f.read()

    # Find lines that start with [TestMethod (no indent) and add 4 spaces
    lines = content.split('\n')
    fixed = []
    for line in lines:
        if line.startswith('[TestMethod') or line.startswith('[DisplayName'):
            fixed.append('    ' + line)
        elif line.startswith('public void ') or line.startswith('public async '):
            fixed.append('    ' + line)
        else:
            fixed.append(line)

    new_content = '\n'.join(fixed)
    with open(filepath, 'w', encoding='utf-8') as f:
        f.write(new_content)

    print(f"Fixed {filepath}: {new_content.count(chr(10))} lines")
