'Author:
'   V. Sudharsan (vsudharsan@novell.com)
'
' (C) 2005 Novell, Inc.

Module ExpConversionBooleantoStringA
	Sub Main()
			Dim a as Boolean = False
			Dim b as String= a.toString()
			if b <> "False"
				Throw new System.Exception("Conversion of Boolean to String not working. Expected False but got " &b) 
			End if		
	End Sub
End Module
