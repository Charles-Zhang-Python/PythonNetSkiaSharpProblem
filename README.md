# PythonNetSkiaSharpProblem

Per https://github.com/pythonnet/pythonnet/issues/2588

To replicate the problem:

1. Open `PythonNetSkiaSharpProblem.sln`, build all
2. Go to Test folder, do `python SamplePython.py`
3. Observer the output

You may need to adjust paths accordingly inside `SamplePython.py`

## Workaround

Notice a workaround is to copy `libSkiaSharp.dll` directly to the root of the published folder.
