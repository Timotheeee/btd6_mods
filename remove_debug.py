import shutil
from pathlib import Path

script_dir = Path(__file__).parent if "__file__" in globals() else Path.cwd()

for folder in script_dir.iterdir():
    if not folder.is_dir():
        continue
    target = folder / "obj" / "Debug"
    if target.is_dir():
        print(f"Deleting {target}")
        shutil.rmtree(target)