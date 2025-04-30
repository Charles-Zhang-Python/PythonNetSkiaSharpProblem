import sys
sys.path.insert(0, r"C:\Users\Charles Zhang\Desktop\Temp\PythonNetSkiaSharpProblem\PythonNetSkiaSharpProblem\bin\Debug\net8.0")

import pythonnet
pythonnet.load("coreclr")

import clr
clr.AddReference("PythonNetSkiaSharpProblem")

from PythonNetSkiaSharpProblem import Program
Program.Main([]) # Exception in stack