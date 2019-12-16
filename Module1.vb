Imports System.IO
Module Module1

    Public Sub Main(ByVal args() As String)

        Dim objStreamWriter As StreamWriter = New StreamWriter("D:/User's Files/Desktop/Textfile.txt")

        Dim fruits(3) As String
        Dim i As Integer

        'Ask for 3 fruits and Store to Array
        For i = 0 To 2
            Console.WriteLine("Enter a fruit")
            fruits(i) = Console.ReadLine()
        Next i

        'Print array and write to a text file
        For i = 0 To 2
            Console.WriteLine(i + 1 & " " & fruits(i))
            objStreamWriter.WriteLine(i + 1 & " " & fruits(i))
        Next i

        objStreamWriter.Close()

    End Sub

End Module
